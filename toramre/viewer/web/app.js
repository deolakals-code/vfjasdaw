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
  document.title = `${e.name || id} · toramre viewer`;
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

/* ---------- Router ---------- */
function go(base, params) { const u = new URLSearchParams(); for (const [k, v] of Object.entries(params || {})) if (v) u.set(k, v); location.hash = base + (u.toString() ? "?" + u : ""); }
async function route() {
  const [path, qs] = (location.hash.slice(1) || "/").split("?");
  const p = Object.fromEntries(new URLSearchParams(qs || ""));
  const seg = path.split("/").filter(Boolean).map(decodeURIComponent);
  document.title = "toramre viewer";
  const tab = seg[0] === "search" || !seg.length ? "search" : ["skills", "balance", "compare", "calc"].includes(seg[0]) ? seg[0] : "";
  document.querySelectorAll("#nav a").forEach((a) => a.toggleAttribute("aria-current", a.dataset.t === tab) || a.removeAttribute("aria-current"));
  document.querySelectorAll("#nav a[aria-current]").forEach((a) => a.setAttribute("aria-current", "page"));
  try {
    if (!seg.length || seg[0] === "search") await pageSearch(p.q || "");
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
