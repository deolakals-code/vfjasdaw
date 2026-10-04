"use strict";
const $ = (s, r = document) => r.querySelector(s);
const view = $("#view");
const state = { lang: (() => { try { return localStorage.getItem("toramre.lang") || "th"; } catch (e) { return "th"; } })(), meta: null };
const TYPE_LABEL = { skill: "Skills", item: "Items", monster: "Monsters", recipe: "Recipes", registlet: "Registlets", quest: "Quests" };
const SOURCE_LABEL = { data: "master data", text: "skill text", rate: "multiplier", buff: "buff table" };

function el(tag, attrs, ...kids) {
  const n = document.createElement(tag);
  for (const [k, v] of Object.entries(attrs || {})) {
    if (k === "class") n.className = v; else if (k === "text") n.textContent = v;
    else if (k.startsWith("on")) n.addEventListener(k.slice(2), v); else if (v !== false && v != null) n.setAttribute(k, v === true ? "" : v);
  }
  for (const c of kids.flat(Infinity)) if (c != null && c !== false) n.append(c.nodeType ? c : document.createTextNode(String(c)));
  return n;
}
async function api(path, params) {
  const u = new URL("/api/" + path, location.origin);
  const p = Object.assign({ lang: state.lang }, params || {});
  for (const [k, v] of Object.entries(p)) if (v !== "" && v != null) u.searchParams.set(k, v);
  const r = await fetch(u);
  const j = await r.json();
  if (!r.ok) throw new Error(j.error || r.statusText);
  return j;
}
const pill = (v) => el("span", { class: "pill " + v, text: v });
const fmt = (x) => x == null ? "-" : (typeof x === "number" ? (Number.isInteger(x) ? String(x) : String(+x.toFixed(3))) : String(x));
function delta(d, pct, verdict) {
  if (d == null) return el("span", { class: "flat", text: "-" });
  const cls = verdict === "BUFF" ? "up" : verdict === "NERF" ? "down" : "flat";
  const arrow = d > 0 ? "▲" : d < 0 ? "▼" : "";
  return el("span", { class: cls, text: `${arrow} ${d > 0 ? "+" : ""}${fmt(d)}${pct != null ? ` (${pct > 0 ? "+" : ""}${pct.toFixed(1)}%)` : ""}` });
}
function loading() { view.replaceChildren(el("div", { class: "empty", text: "Loading…" })); }
function fail(e) { view.replaceChildren(el("div", { class: "empty", text: "Could not load: " + e.message })); }
const href = (t, id) => `#/${t}/${encodeURIComponent(id)}`;

/* ---------- Search ---------- */
async function pageSearch(q) {
  $("#q").value = q || "";
  if (!q) return view.replaceChildren(el("div", { class: "empty", text: "Type a name or id in the box above: skills, items, monsters, recipes, registlets and quests are searched in all 6 languages." }));
  loading();
  const r = await api("search", { q, limit: 15 });
  const kinds = Object.keys(r.results);
  if (!kinds.length) return view.replaceChildren(el("div", { class: "empty", text: `Nothing found for “${q}”.` }));
  view.replaceChildren(...kinds.map((t) => el("section", { class: "card" }, el("h2", { text: `${TYPE_LABEL[t]} (${r.results[t].length}${r.results[t].length === 15 ? "+" : ""})` }),
    r.results[t].map((x) => el("a", { class: "row", href: href(t, x.id) }, el("span", { class: "t", text: x.name || `(no name) ${x.id}` }), el("span", { class: "s mono", text: `#${x.id}` }))))));
}

/* ---------- Entity ---------- */
function levelTable(levels) {
  const keys = Object.keys(levels || {}).filter((k) => levels[k].length);
  if (!keys.length) return null;
  const n = Math.max(...keys.map((k) => levels[k].length));
  return el("div", { class: "scroll" }, el("table", { class: "tbl" }, el("thead", null, el("tr", null, el("th", { text: "" }), Array.from({ length: n }, (_, i) => el("th", { class: "num", text: "Lv" + (i + 1) })))),
    el("tbody", null, keys.map((k) => el("tr", null, el("th", { text: k === "rate" ? "multiplier" : "flat damage" }), levels[k].map((v) => el("td", { class: "num", text: v })))))));
}
function changeRows(entry) {
  const rows = [];
  for (const c of entry.changes) {
    if (c.levels) {
      for (const l of c.levels) rows.push(el("tr", null, el("td", { class: "mono", text: c.field }), el("td", { text: "Lv" + l.level }), el("td", { class: "num", text: fmt(l.before) }), el("td", { class: "num", text: fmt(l.after) }), el("td", null, delta(l.delta, l.pct, l.verdict)), el("td", null, pill(l.verdict))));
    } else {
      rows.push(el("tr", null, el("td", { class: "mono", text: c.field }), el("td", { text: "" }), el("td", { class: "num", text: fmt(c.before) }), el("td", { class: "num", text: fmt(c.after) }), el("td", null, delta(c.delta, c.pct, c.verdict)), el("td", null, pill(c.verdict))));
    }
  }
  return rows;
}
function changesCard(typ, b) {
  const box = el("section", { class: "card" }, el("h2", { text: "Changes between versions" }));
  const body = el("div", { class: "body" });
  if (b.note) body.append(el("div", { class: "note", text: b.note }));
  if (!b.entries.length) body.append(el("div", { class: "empty", text: typ === "skill" ? "No recorded change for this skill in the kept data or texts. Multiplier and buff changes will appear here after the next game update." : "No recorded change in the kept versions." }));
  const groups = new Map();
  for (const e of b.entries) { const k = `${e.from} → ${e.to}`; if (!groups.has(k)) groups.set(k, []); groups.get(k).push(e); }
  for (const [k, es] of groups) {
    body.append(el("div", { class: "group" }, el("h3", null, el("span", { class: "mono", text: k }), " ", es.map((e) => [pill(e.verdict), " "])),
      es.map((e) => e.changes.length ? el("div", { class: "scroll" }, el("table", { class: "tbl" },
        el("thead", null, el("tr", null, ["field", "level", "before", "after", "change", "verdict"].map((h, i) => el("th", { class: i === 2 || i === 3 ? "num" : "", text: h })))),
        el("tbody", null, changeRows(e)))) : el("div", { class: "muted", text: e.verdict === "ADDED" ? "Added in this version." : e.verdict === "REMOVED" ? "Removed in this version." : "" })),
      es.map((e) => el("div", { class: "s muted", text: `source: ${SOURCE_LABEL[e.source] || e.source}` }))));
  }
  box.append(body);
  return box;
}
async function pageEntity(typ, id) {
  loading();
  const e = await api(`entity/${typ}/${encodeURIComponent(id)}`);
  const f = e.fields;
  const names = Object.entries(e.names).filter(([, n]) => n && n !== e.name);
  const head = el("section", { class: "card" }, el("div", { class: "head" }, el("div", { class: "label", text: `${typ} #${e.id}` }), el("h1", { text: e.name || "(no name)" }),
    names.length ? el("div", { class: "chips" }, names.map(([l, n]) => el("span", { class: "chip", title: l, text: `${l}: ${n}` }))) : null));
  const info = el("section", { class: "card" }, el("h2", { text: "Details" }), el("div", { class: "body" },
    f.description ? el("div", null, el("div", { class: "label", text: "Description" }), el("div", { style: "white-space:pre-line", text: f.description })) : null,
    f.level_notes ? el("div", null, el("div", { class: "label", text: "Level notes" }), el("div", { style: "white-space:pre-line", text: f.level_notes })) : null,
    levelTable(f.levels),
    el("div", { class: "scroll" }, el("table", { class: "tbl" }, el("tbody", null, Object.entries(f).filter(([k, v]) => !["description", "level_notes", "levels"].includes(k) && v !== "" && v != null)
      .map(([k, v]) => el("tr", null, el("th", { text: k }), el("td", { text: v }))))))));
  const groups = {};
  for (const l of e.links) (groups[l.rel] = groups[l.rel] || []).push(l);
  const links = Object.keys(groups).length ? el("section", { class: "card" }, el("h2", { text: "Linked" }),
    Object.entries(groups).map(([rel, ls]) => el("div", { class: "row", style: "grid-template-columns:110px minmax(0,1fr)" }, el("span", { class: "label", text: rel }),
      el("span", { class: "chips" }, ls.slice(0, 40).map((l) => el("a", { class: "chip", href: href(l.type, l.id), text: `${l.name || l.id}` })), ls.length > 40 ? el("span", { class: "muted", text: `+${ls.length - 40} more` }) : null)))) : null;
  view.replaceChildren(head, e.balance ? changesCard(typ, e.balance) : null, info, links);
  document.title = `${e.name || id} · toramre`;
}

/* ---------- Skills ---------- */
async function pageSkills(params) {
  loading();
  const q = params.q || "", verdict = params.verdict || "";
  const r = await api("skills", { q, verdict, limit: 700 });
  const input = el("input", { type: "search", value: q, placeholder: "Filter skills by name or id", "aria-label": "Filter skills" });
  const chips = ["BUFF", "NERF", "MIXED"].map((v) => el("button", { class: "chip", type: "button", "aria-pressed": verdict.split(",").includes(v) ? "true" : "false", text: v, onclick: () => {
    const s = new Set(verdict.split(",").filter(Boolean)); s.has(v) ? s.delete(v) : s.add(v); go("#/skills", { q: input.value, verdict: [...s].join(",") }); } }));
  input.addEventListener("keydown", (ev) => { if (ev.key === "Enter") go("#/skills", { q: input.value, verdict }); });
  view.replaceChildren(el("div", { class: "filters" }, input, chips, el("span", { class: "muted", text: `${r.total} skills` })),
    el("section", { class: "card" }, r.rows.map((s) => el("a", { class: "row", href: href("skill", s.id) }, el("span", { class: "t", text: s.name || s.id }),
      el("span", { class: "s" }, s.verdict ? pill(s.verdict) : null, " ", el("span", { class: "mono", text: `#${s.id} · ${s.category}` }))))));
  if (!r.rows.length) view.append(el("div", { class: "empty", text: "No skill matches." }));
}

/* ---------- Balance ---------- */
async function pageBalance(params) {
  loading();
  const sel = { kind: params.kind || "", verdict: params.verdict || "BUFF,NERF,MIXED", version: params.version || "" };
  const r = await api("balance", { ...sel, limit: 300 });
  const mk = (name, opts, cur) => el("select", { "aria-label": name, onchange: (ev) => go("#/balance", { ...sel, [name]: ev.target.value }) }, opts.map(([v, t]) => el("option", { value: v, selected: v === cur, text: t })));
  const vchips = ["BUFF", "NERF", "MIXED", "NEUTRAL", "ADDED"].map((v) => el("button", { class: "chip", type: "button", "aria-pressed": sel.verdict.split(",").includes(v) ? "true" : "false", text: v, onclick: () => {
    const s = new Set(sel.verdict.split(",").filter(Boolean)); s.has(v) ? s.delete(v) : s.add(v); go("#/balance", { ...sel, verdict: [...s].join(",") }); } }));
  view.replaceChildren(el("div", { class: "filters" }, mk("kind", [["", "All kinds"], ["skill", "Skills"], ["item", "Items"], ["recipe", "Recipes"], ["registlet", "Registlets"]], sel.kind),
    mk("version", [["", "All versions"], ...r.versions.map((v) => [v, v])], sel.version), vchips, el("span", { class: "muted", text: `${r.total} entries` })),
    el("div", { class: "note", text: state.meta ? state.meta.balance_note : "" }),
    el("section", { class: "card" }, r.rows.map((e) => el("a", { class: "row", href: href(e.kind, e.id) }, el("span", { class: "t" }, pill(e.verdict), " ", el("b", { text: e.name || e.id }), el("div", { class: "s", text: e.line })),
      el("span", { class: "s mono", text: `${e.from} → ${e.to}` })))), r.rows.length ? null : el("div", { class: "empty", text: "No entries with these filters." }));
}

/* ---------- Compare ---------- */
async function pageCompare(a, b) {
  const ia = el("input", { value: a || "", placeholder: "skill id, e.g. 33", "aria-label": "First skill id" }), ib = el("input", { value: b || "", placeholder: "skill id, e.g. 34", "aria-label": "Second skill id" });
  const form = el("form", { class: "cmp", onsubmit: (ev) => { ev.preventDefault(); location.hash = `#/compare/${encodeURIComponent(ia.value)}/${encodeURIComponent(ib.value)}`; } },
    el("label", null, "Skill A", ia), el("label", null, "Skill B", ib), el("button", { class: "btn", type: "submit", text: "Compare" }));
  view.replaceChildren(form);
  if (!a || !b) return view.append(el("div", { class: "empty", text: "Enter two skill ids (find them with Search) to see both side by side; differing fields are marked." }));
  try {
    const r = await api("compare", { a, b });
    const col = (e) => el("section", { class: "card" }, el("div", { class: "head" }, el("div", { class: "label", text: `skill #${e.id}` }), el("a", { href: href("skill", e.id) }, el("h2", { text: e.name }))),
      el("div", { class: "body" }, levelTable(e.fields.levels), el("div", { class: "scroll" }, el("table", { class: "tbl" }, el("tbody", null, Object.entries(e.fields).filter(([k]) => k !== "levels").map(([k, v]) =>
        el("tr", { class: r.differs.includes(k) ? "diffmark" : "" }, el("th", { text: k }), el("td", { style: "white-space:pre-line;overflow-wrap:anywhere", text: v }))))))));
    view.append(el("div", { class: "muted", text: r.differs.length ? `Differs in: ${r.differs.join(", ")}` : "No differing fields." }), el("div", { class: "vs" }, col(r.a), col(r.b)));
  } catch (e) { view.append(el("div", { class: "empty", text: e.message })); }
}

/* ---------- Calculator ---------- */
const calcState = { monster: null, steps: [10, 10, 10], hits: [] };
async function pageCalc() {
  const caps = await api("calc/capabilities").catch(() => ({}));
  const out = el("div"), claimBox = el("div"), claimsList = el("div");
  const stepIn = [0, 1, 2].map((i) => el("input", { type: "number", min: 0, max: 1000, value: calcState.steps[i], "aria-label": ["Normal", "Skill", "Magic"][i] + " step", onchange: (ev) => { calcState.steps[i] = +ev.target.value; calcState.monster = null; renderMon(); } }));
  const monBox = el("div", { class: "muted" });
  const renderMon = () => { monBox.textContent = calcState.monster ? `Steps from monster ${calcState.monster.name} (#${calcState.monster.id})` : "Manual steps"; stepIn.forEach((x, i) => { x.value = calcState.steps[i]; }); };
  const results = el("div", { class: "card", hidden: true });
  const q = el("input", { type: "search", placeholder: "Monster name or id (fills the three steps)", "aria-label": "Monster" });
  q.addEventListener("input", async () => {
    if (q.value.trim().length < 2) return results.replaceChildren(), (results.hidden = true);
    const r = await api("search", { q: q.value.trim(), types: "monster", limit: 8 });
    results.hidden = false;
    results.replaceChildren(...(r.results.monster || []).map((m) => el("button", { class: "row", type: "button", style: "width:100%;text-align:left;background:none;border:0;border-top:1px solid var(--line);font:inherit;color:inherit;cursor:pointer", onclick: async () => {
      const c = await api("calc/proration", { monster: m.id, hits: "Normal" });
      calcState.steps = c.steps; calcState.monster = { id: m.id, name: m.name }; renderMon(); results.hidden = true; q.value = m.name; } }, el("span", { class: "t", text: m.name }), el("span", { class: "s mono", text: "#" + m.id }))));
  });
  const hitChips = el("div", { class: "chips" });
  const renderHits = () => hitChips.replaceChildren(...[...calcState.hits.map((h, i) => el("button", { class: "chip", type: "button", title: "Remove", onclick: () => { calcState.hits.splice(i, 1); renderHits(); } }, `${i + 1}. ${h} ✕`)),
    calcState.hits.length ? null : el("span", { class: "muted", text: "No hits yet: add the hits in the order they land." })].filter(Boolean));
  const add = (slot) => el("button", { class: "btn", type: "button", text: "+ " + slot, onclick: () => { if (calcState.hits.length < 200) calcState.hits.push(slot); renderHits(); } });
  async function run() {
    if (!calcState.hits.length) return out.replaceChildren(el("div", { class: "empty", text: "Add at least one hit." }));
    try {
      const r = await api("calc/proration", { steps: calcState.steps.join(","), hits: calcState.hits.join(",") });
      out.replaceChildren(el("section", { class: "card" }, el("h2", { text: "Proration after each hit" }), el("div", { class: "scroll" }, el("table", { class: "tbl" },
        el("thead", null, el("tr", null, ["#", "slot", "Normal", "Skill", "Magic", "damage × (state before the hit)", "damage × (state after the hit)"].map((h) => el("th", { text: h })))),
        el("tbody", null, r.hits.map((h) => el("tr", null, el("td", { text: h.hit }), el("td", { text: h.slot }), el("td", { class: "num", text: h.state_after.Normal }), el("td", { class: "num", text: h.state_after.Skill }), el("td", { class: "num", text: h.state_after.Magic }),
          el("td", { class: "num", text: h.multiplier_before.toFixed(2) }), el("td", { class: "num", text: h.multiplier_after.toFixed(2) }))))))),
        el("div", { class: "note", text: "Which of the two multipliers a hit really uses (state before or after its own update) is an open point in the client-code evidence; both are shown. Nothing here is checked in game until you save a value below." }));
      claimForm(r.hits);
    } catch (e) { out.replaceChildren(el("div", { class: "empty", text: e.message })); }
  }
  function claimForm(hits) {
    const idx = el("select", { "aria-label": "Hit" }, hits.map((h) => el("option", { value: h.hit - 1, text: `hit ${h.hit} (${h.slot})` })));
    const basis = el("select", { "aria-label": "Basis" }, el("option", { value: "multiplier_before", text: "state before" }), el("option", { value: "multiplier_after", text: "state after" }));
    const seen = el("input", { type: "number", step: "any", placeholder: "damage × seen in game, e.g. 0.9", "aria-label": "Value seen in game" });
    const note = el("input", { placeholder: "note (optional)", "aria-label": "Note" });
    const msg = el("div", { class: "muted" });
    claimBox.replaceChildren(el("section", { class: "card" }, el("h2", { text: "Check against the game" }), el("div", { class: "body" }, el("div", { class: "cmp" }, el("label", null, "Hit", idx), el("label", null, "Compare with", basis), el("label", null, "Seen in game", seen), el("label", null, "Note", note),
      el("button", { class: "btn", type: "button", text: "Save", onclick: async () => {
        const h = hits[+idx.value];
        const r = await fetch("/api/claims", { method: "POST", headers: { "Content-Type": "application/json", "X-Toramre": "1" }, body: JSON.stringify({ tool: "proration", inputs: { steps: calcState.steps, monster: calcState.monster && calcState.monster.id, hits: calcState.hits, hit: h.hit, basis: basis.value }, computed: h[basis.value], seen: seen.value, note: note.value }) });
        const j = await r.json();
        msg.replaceChildren(r.ok ? el("span", null, pill(j.status === "In-game" ? "BUFF" : "NERF"), ` ${j.status}: computed ${j.computed}, seen ${j.seen}`) : (j.error || "failed"));
        loadClaims(); } })), msg)));
  }
  async function loadClaims() {
    const c = await api("claims");
    claimsList.replaceChildren(el("section", { class: "card" }, el("h2", { text: `Saved checks (${c.claims.length})` }), c.claims.length ? c.claims.slice(-10).reverse().map((x) => el("div", { class: "row" },
      el("span", { class: "t" }, pill(x.status === "In-game" ? "BUFF" : "NERF"), ` ${x.tool}: computed ${x.computed}, seen ${x.seen}`, x.note ? ` · ${x.note}` : ""), el("span", { class: "s mono", text: x.at }))) : el("div", { class: "row" }, el("span", { class: "muted", text: "None yet." }))));
  }
  const capNote = Object.entries(caps).filter(([, v]) => !v.available).map(([k, v]) => `${k}: ${v.reason}`);
  view.replaceChildren(el("section", { class: "card" }, el("h2", { text: "Proration simulator" }), el("div", { class: "body" }, q, results, monBox,
    el("div", { class: "cmp" }, el("label", null, "Normal step", stepIn[0]), el("label", null, "Skill step", stepIn[1]), el("label", null, "Magic step", stepIn[2])),
    el("div", { class: "chips" }, add("Normal"), add("Skill"), add("Magic"), el("button", { class: "chip", type: "button", text: "Clear", onclick: () => { calcState.hits = []; renderHits(); out.replaceChildren(); claimBox.replaceChildren(); } })),
    hitChips, el("div", null, el("button", { class: "btn", type: "button", text: "Calculate", onclick: run })))), out, claimBox, claimsList,
    capNote.length ? el("div", { class: "note", text: "Not available in this viewer yet — " + capNote.join(" · ") }) : null);
  renderMon(); renderHits(); loadClaims();
}

/* ---------- Overview ---------- */
const bytesText = (n) => n >= 1e9 ? (n / 1e9).toFixed(1) + " GB" : (n / 1e6).toFixed(n >= 1e8 ? 0 : 1) + " MB";
async function pageOverview() {
  loading();
  const o = await api("overview");
  const stat = (label, value, cls, sub) => el("div", { class: "stat " + (cls || "") }, el("span", { class: "label", text: label }), el("b", { text: value }), sub ? el("span", { class: "muted", text: sub }) : null);
  const byVer = {};
  for (const n of o.new_data) (byVer[n.version] = byVer[n.version] || []).push(n.channel);
  const banners = Object.entries(byVer).map(([ver, chs]) => el("section", { class: "banner" }, el("div", null, el("b", { text: `Channel${chs.length > 1 ? "s" : ""} ${chs.join(", ")} carry BynaryData ${ver}` }),
    el("div", { class: "muted", text: "Not decoded here yet. The version number alone does not say whether it is newer or a test channel; fetch it and compare." })),
    el("a", { class: "btn", href: "#/fetch" }, "Fetch data and text")));
  const catRows = Object.entries(o.fetched);
  view.replaceChildren(
    el("div", { class: "top-row" }, el("div", { class: "label", text: "Overview" }), el("h1", { text: `Data version ${o.newest || "-"}` }),
      el("div", { class: "muted", text: `${o.date ? "Cached " + o.date + " · " : ""}${o.versions} master versions kept · Doctor: ${o.doctor.ok} ok, ${o.doctor.warn} warnings, ${o.doctor.missing} missing` })),
    ...banners,
    el("section", { class: "strip", "aria-label": "Summary" }, stat("High alerts", o.alerts.high, "high"), stat("Medium alerts", o.alerts.medium, "medium"), stat("Low alerts", o.alerts.low, "low"),
      stat("Table layouts learned", o.layouts.learned, "", `${o.layouts.open} still open`),
      stat("Fetched here", catRows.reduce((n, [, v]) => n + v.bundles, 0), "", bytesText(catRows.reduce((n, [, v]) => n + v.bytes, 0)))),
    el("div", { class: "two" },
      el("section", { class: "card wide" }, el("div", { class: "head" }, el("h2", { text: "Most important alerts" })),
        o.recent.length ? o.recent.map((e) => el("a", { class: "row", href: e.bundle.startsWith("balance/") ? href(e.bundle.slice(8), e.item) : "#/balance" }, el("span", { class: "t" }, pill(e.tag), " ", el("b", { text: `${e.bundle}/${e.item}` }), el("div", { class: "s", text: e.detail })),
          el("span", { class: "s mono", text: `${e.from} → ${e.to}` }))) : el("div", { class: "row" }, el("span", { class: "muted", text: "No alerts." })),
        el("a", { class: "row", href: "#/balance" }, el("span", { class: "t", text: "All buff / nerf changes" }), el("span", { class: "s", text: "Balance →" }))),
      el("section", { class: "card narrow" }, el("div", { class: "head" }, el("h2", { text: "CDN channels" })),
        Object.entries(o.channels).map(([c, r]) => el("div", { class: "row" }, el("span", { class: "t" }, el("b", { text: c }), c === o.default_channel ? " (default) " : " ", el("span", { class: "mono", text: r.BynaryData || "-" })),
          el("span", { class: "s", text: r.decoded_here ? "decoded here" : "not decoded" }))),
        el("a", { class: "row", href: "#/fetch" }, el("span", { class: "t", text: "Fetch and update" }), el("span", { class: "s", text: "→" })))));
}

/* ---------- Table layouts ---------- */
async function pageLayouts() {
  loading();
  const b = await api("layouts");
  const learned = el("div", { class: "grid3" }, b.learned.map((e) => el("article", { class: "card" }, el("div", { class: "head" }, el("div", { class: "chips" }, el("h2", { text: e.table }), el("span", { class: "pill ADDED", text: e.strategy }))),
    el("div", { class: "body" }, el("b", { style: "font:600 1.5rem var(--f-display)", text: e.records.toLocaleString() }),
      el("span", { class: "mono muted", style: "overflow-wrap:anywhere", text: e.names.length ? e.names.join(" · ") : e.describe }),
      el("span", { class: "muted", text: `${e.label}; ${e.versions} distinct version${e.versions === 1 ? "" : "s"}` })))));
  const open = el("section", { class: "card" }, el("div", { class: "head" }, el("h2", { text: `Still open (${b.frontier.length})` })),
    el("div", { class: "scroll" }, el("table", { class: "tbl" }, el("thead", null, el("tr", null, ["Table", "Bytes", "Why open", "Best guess", "Next link"].map((h, i) => el("th", { class: i === 1 ? "num" : "", text: h })))),
      el("tbody", null, b.frontier.map((f) => el("tr", null, el("td", null, el("b", { text: f.table })), el("td", { class: "num", text: f.bytes.toLocaleString() }), el("td", { text: f.why }),
        el("td", { class: "mono" }, f.best ? [el("span", { class: "pill " + (f.confidence === "weak" ? "MIXED" : ""), text: f.confidence || "?" }), " " + f.best] : el("span", { class: "muted", text: f.tried ? "no layout found (nested variable parts)" : "not tried yet" })),
        el("td", { text: f.next.join(", ") })))))));
  const st = Object.entries(b.stats || {}).map(([k, v]) => `${k} ${v.solved}/${v.tried}`).join(" · ");
  view.replaceChildren(el("div", null, el("div", { class: "label", text: "Table layouts" }), el("h1", { text: `${b.learned.length} learned, ${b.frontier.length} still open` }),
    el("div", { class: "muted", text: "A layout is kept only when it reads every cached version to the last byte and shuffled bytes never fit it." + (st ? " Strategy record: " + st : "") })),
    learned, open);
}

/* ---------- Doctor ---------- */
async function pageDoctor() {
  loading();
  const d = await api("doctor");
  view.replaceChildren(el("div", null, el("div", { class: "label", text: "Doctor" }), el("h1", { text: "What this machine can run" })),
    el("section", { class: "card" }, d.checks.map((c) => el("div", { class: "check" }, el("span", { class: "st " + c.state, text: c.state.toUpperCase() }),
      el("div", null, el("b", { text: c.what }), " ", el("span", { class: "muted", text: c.detail }), c.state !== "ok" && c.needed_for ? el("div", { class: "s muted", text: "needed for: " + c.needed_for }) : null)))));
}

/* ---------- Fetch ---------- */
const fetchState = { only: new Set(["data", "text", "script"]), channel: "", force: false, timer: null };
function stopPolling() { if (fetchState.timer) { clearInterval(fetchState.timer); fetchState.timer = null; } }
async function post(path, body) {
  const r = await fetch("/api/" + path, { method: "POST", headers: { "Content-Type": "application/json", "X-Toramre": "1" }, body: JSON.stringify(body || {}) });
  const j = await r.json();
  if (!r.ok) throw new Error(j.error || r.statusText);
  return j;
}
async function pageFetch() {
  stopPolling();
  loading();
  const s = await api("fetch/status", { only: [...fetchState.only].join(","), channel: fetchState.channel, force: fetchState.force ? "1" : "" });
  if (s.error) {
    return view.replaceChildren(el("div", null, el("div", { class: "label", text: "Fetch" }), el("h1", { text: "Download from the CDN" })), el("div", { class: "empty", text: s.error }),
      el("div", null, el("button", { class: "btn", type: "button", text: "Check the CDN now", onclick: async (ev) => { ev.target.disabled = true; try { await post("fetch/catalog"); } catch (e) { /* the retry below shows the same error */ } pageFetch(); } })));
  }
  const jobs = el("input", { type: "number", min: 1, max: 32, value: s.defaults.jobs, id: "o-jobs" }), mbps = el("input", { type: "number", min: 0, step: "any", value: s.defaults.max_mbps, id: "o-mbps" });
  const force = el("input", { type: "checkbox", id: "o-force", checked: fetchState.force, onchange: (ev) => { fetchState.force = ev.target.checked; pageFetch(); } });
  const live = el("div"), msg = el("div", { class: "muted", role: "status" });
  const startBtn = el("button", { class: "btn", type: "button", text: "Start download" }), stopBtn = el("button", { class: "btn secondary", type: "button", text: "Stop", hidden: true });
  const cats = s.categories.map((c) => {
    const pct = c.total ? Math.round(c.fetched / c.total * 100) : 0;
    return el("div", { class: "cat" }, el("input", { type: "checkbox", id: "c-" + c.name, checked: fetchState.only.has(c.name), onchange: (ev) => { ev.target.checked ? fetchState.only.add(c.name) : fetchState.only.delete(c.name); pageFetch(); } }),
      el("label", { for: "c-" + c.name }, el("b", { text: c.name }), el("span", { class: "bar" }, el("i", { style: `width:${pct}%` }))),
      el("span", { class: "n", text: `${c.fetched.toLocaleString()} / ${c.total.toLocaleString()}` }), el("span", { class: "mb", text: c.to_fetch ? "~" + bytesText(c.bytes) + " to go" : "current" }));
  });
  function paint(j) {
    const running = j.state === "running" || j.state === "stopping";
    startBtn.disabled = running; stopBtn.hidden = !running;
    if (!j.total_files && !j.message && !j.error) return live.replaceChildren();
    const pct = j.total_bytes ? Math.min(100, Math.round(j.bytes / j.total_bytes * 100)) : (j.state === "done" ? 100 : 0);
    live.replaceChildren(el("div", { class: "card" }, el("div", { class: "body" },
      el("div", null, pill(j.state === "done" ? "BUFF" : j.state === "failed" ? "NERF" : j.state === "stopped" ? "MIXED" : "ADDED"), " ", el("b", { text: j.state }), j.message ? " · " + j.message : "", j.error ? " · " + j.error : ""),
      j.total_files ? el("span", { class: "bar" }, el("i", { style: `width:${pct}%` })) : null,
      j.total_files ? el("div", { class: "muted", style: "font-variant-numeric:tabular-nums", text: `${j.files}/${j.total_files} files · ${bytesText(j.bytes)} of ~${bytesText(j.total_bytes)} · ${(j.rate / 1e6).toFixed(2)} MB/s${j.eta ? " · about " + Math.ceil(j.eta) + " s left" : ""} · ${j.failed || 0} failed` }) : null,
      j.report && j.report.failed && j.report.failed.length ? el("div", { class: "s" }, j.report.failed.slice(0, 5).map((f) => el("div", { class: "mono", text: `${f.key}: ${f.error}` }))) : null)));
    if (!running && fetchState.timer) { stopPolling(); setTimeout(pageFetch, 800); }
  }
  async function poll() { try { paint(await api("fetch/job")); } catch (e) { stopPolling(); } }
  startBtn.addEventListener("click", async () => {
    msg.textContent = "";
    try { await post("fetch/start", { only: [...fetchState.only], channel: s.channel, jobs: +jobs.value, max_mbps: +mbps.value, force: fetchState.force }); fetchState.timer = setInterval(poll, 1000); poll(); }
    catch (e) { msg.textContent = e.message; }
  });
  stopBtn.addEventListener("click", async () => { await post("fetch/stop"); poll(); });
  view.replaceChildren(
    el("div", { class: "top-row" }, el("div", { class: "label", text: "Fetch" }), el("h1", { text: "Download from the CDN" }),
      el("div", { class: "muted", text: `Channel ${s.channel} · files go to ${s.root} · every file is checked against its MD5 before it enters the cache` })),
    el("div", { class: "two" },
      el("section", { class: "card wide" }, el("div", { class: "head" }, el("h2", { text: "Categories" }), el("span", { class: "muted", text: "Order: data first, heavy media last" })), cats,
        el("div", { class: "row" }, el("span", { class: "t", text: `${s.to_fetch.toLocaleString()} bundles to fetch, ${s.skipped.toLocaleString()} current` }), el("span", { class: "s", text: "sizes are estimates" }))),
      el("section", { class: "card narrow" }, el("div", { class: "head" }, el("h2", { text: "Options" })), el("div", { class: "body" },
        el("label", { for: "o-jobs", class: "cmp" }, el("span", { text: "Parallel files" }), jobs), el("label", { for: "o-mbps", class: "cmp" }, el("span", { text: "Speed cap MB/s (0 = none)" }), mbps),
        el("label", { for: "o-force", style: "display:flex;gap:10px;align-items:center;min-height:36px" }, force, "Download again even when the file is current"),
        el("div", { class: "chips" }, startBtn, stopBtn, el("button", { class: "btn secondary", type: "button", text: "Check the CDN now", onclick: async (ev) => { ev.target.disabled = true; msg.textContent = "Checking…"; try { const r = await post("fetch/catalog"); msg.textContent = `${r.changes} change${r.changes === 1 ? "" : "s"} since the last check.`; } catch (e) { msg.textContent = e.message; } setTimeout(pageFetch, 1200); } })),
        msg))),
    live);
  paint(s.job);
  if (s.job.state === "running") { fetchState.timer = setInterval(poll, 1000); }
}

/* ---------- Router ---------- */
function go(base, params) { const u = new URLSearchParams(); for (const [k, v] of Object.entries(params || {})) if (v) u.set(k, v); location.hash = base + (u.toString() ? "?" + u : ""); }
async function route() {
  const [path, qs] = (location.hash.slice(1) || "/").split("?");
  const p = Object.fromEntries(new URLSearchParams(qs || ""));
  const seg = path.split("/").filter(Boolean).map(decodeURIComponent);
  document.title = "toramre";
  stopPolling();
  const tab = !seg.length ? "overview" : ["search", "skills", "balance", "compare", "calc", "fetch", "layouts", "doctor"].includes(seg[0]) ? seg[0] : "";
  document.querySelectorAll("#nav a").forEach((n) => { if (n.dataset.t === tab) n.setAttribute("aria-current", "page"); else n.removeAttribute("aria-current"); });
  try {
    if (!seg.length) await pageOverview();
    else if (seg[0] === "search") await pageSearch(p.q || "");
    else if (seg[0] === "fetch") await pageFetch();
    else if (seg[0] === "layouts") await pageLayouts();
    else if (seg[0] === "doctor") await pageDoctor();
    else if (seg[0] === "skills") await pageSkills(p);
    else if (seg[0] === "balance") await pageBalance(p);
    else if (seg[0] === "compare") await pageCompare(seg[1], seg[2]);
    else if (seg[0] === "calc") await pageCalc();
    else if (seg.length === 2) await pageEntity(seg[0], seg[1]);
    else view.replaceChildren(el("div", { class: "empty", text: "Unknown page." }));
  } catch (e) { fail(e); }
  view.focus({ preventScroll: true });
}
$("#searchform").addEventListener("submit", (ev) => { ev.preventDefault(); go("#/search", { q: $("#q").value.trim() }); });
$("#lang").value = state.lang;
$("#lang").addEventListener("change", (ev) => { state.lang = ev.target.value; try { localStorage.setItem("toramre.lang", state.lang); } catch (e) { /* storage may be blocked */ } route(); });
window.addEventListener("hashchange", route);
api("meta").then((m) => { state.meta = m; $("#foot").textContent = `Local viewer · data ${m.newest} · ${m.data_versions.length} versions kept · ${Object.values(m.counts).reduce((a, b) => a + b, 0).toLocaleString()} entries · snapshots: ${m.snapshots.join(", ") || "none"}`; }).catch(() => {});
route();
