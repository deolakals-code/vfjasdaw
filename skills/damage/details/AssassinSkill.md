# アサシンスキル (`AssassinSkill`) — skill details

15 entries.

### แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ (AssassinStub) · uid 993

<img src="../../icons/sk_993.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 1) · **Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `AssassinStubAction`

> โจมตีเป้าหมายหนึ่งครั้งอย่างหมายเอาชีวิต
> ประสิทธิภาพจะเปลี่ยนไปตามทิศทางการโจมตี
> จะแสดงพลังความสามารถได้มากที่สุดจากการเล็งทางด้านหลังของศัตรู

**How it works**

- Attack skill of the アサシンスキル tree (tier 1, max Lv 15); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05]: skill multiplier ×2.08 at Lv1 to 2.35 at Lv10; skill multiplier ×1.51 at Lv1 to 1.6 at Lv10; skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05]: skill multiplier ×2.08 at Lv1 to 2.35 at Lv10; skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +30 at Lv1 to 300 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `AssassinStubBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionPreparation` — before the cast starts: 16 set, 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 12 set, 9 tpl, 1 call, 1 info
- `OnEnd` — when the action ends: 1 call
- `GetLocalizeKey` — skill-specific method: 1 set
- `<ActionPreparation>b__28_0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05] | 2.08 | 2.11 | 2.14 | 2.17 | 2.2 | 2.23 | 2.26 | 2.29 | 2.32 | 2.35 |
| SkillRate × [!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05] | 2.08 | 2.11 | 2.14 | 2.17 | 2.2 | 2.23 | 2.26 | 2.29 | 2.32 | 2.35 |
| SkillRate × [UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05] | 1.51 | 1.52 | 1.53 | 1.54 | 1.55 | 1.56 | 1.57 | 1.58 | 1.59 | 1.6 |
| Flat dmg + | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05 & direction eq 1
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- SkillRate × `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)` — UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Equality(playerAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)`
  - when `direction eq 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int((((((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) eq 0 ? 1 : (((BackstepBuf.GetParam(50) * 0.01) + 1) + ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1))) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)`
  - when `direction eq 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int(((((BackstepBuf.GetParam(50) * 0.01) + 1) eq 0 ? 1 : ((BackstepBuf.GetParam(50) * 0.01) + 1)) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int(((((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) * (((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100))))) / 100)`
  - when `direction eq 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int(((((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1) eq 0 ? 1 : ((SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) * 0.01) + 1)) * ((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int((((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1)))) + ((1) eq 0 ? SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) : (SkillMasteryBase.GetMasteryParam(MasteryId.LastDmgRate) + 100)))) / 100)`
  - when `direction eq 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(int(((((1) eq 0 ? 105 : 205) + (Lv + (Lv << 1))))) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 993
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): constructs `AssassinStubBuf` — `.ctor(Lv, gemCart(1004[2]))`
  - when `!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05`
- `ActionPreparation` (before the cast starts): adds the caster's buff of `new AssassinStubBuf` — `AddSelfBuffer(new AssassinStubBuf, Id)`
  - when `!UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05`
- `calcPlayerToMobDamage` (damage calculation against a monster): removes the caster's buff of skill 995 (Backstep) — `RemoveSelfBuffer(995)`
- `OnEnd` (when the action ends): removes the caster's buff of skill 993 (AssassinStub) — `RemoveSelfBuffer(993)`
  - when `UnityEngine.Object.op_Inequality(playerAction) AND hasBuff(993)`
- `<ActionPreparation>b__28_0` (method): adds the caster's buff of skill 999 (Seekerius) — `AddSelfBuffer(999, PlayerStatusBase.get_SkillManager().SkillMasteryList[999].skillData.Level, stubRate)`
  - when `direction eq 1 OR (SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().skillBufList[999], 50) * 0.01) le stubRate AND direction eq 1`

**Buff values** (every recovered field; durations in seconds)

**Buff `AssassinStubBuf`**
- `HitRate` = `(hitUp)` _(when BuffEffectActive ne 0)_
- `HitRate` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `hitUp` = `hitUp`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AssassinStubBuf$$.ctor<-AssassinStubAction$$ActionPreparation` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `HitRate`: accuracy %

**In-game level notes**

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *พลัง+50 สำหรับฟรอนท์สแทบ  * พลัง+100 สำหรับไซด์สแทบ *พลัง+300 สำหรับแบ็คสแต็บ

**Where else this skill takes effect**

- Effect applied in `AssassinStubAction$$OnEnd` (2 guarded paths):
  - always
    - calls `SkillBufferManager$$RemoveSelfBuffer`, `PlayerAttackBase$$OnEnd`
  - always
    - calls `PlayerAttackBase$$OnEnd`
- Code that reads this skill's level / buff by constant id: `AssassinStubAction$$OnEnd (ContainsBuffer)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 993_

---

### อีเวชัน (Evolution) · uid 994

<img src="../../icons/sk_994.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 1) · **Type:** Support · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `EvolutionAction`

> สกิลเพิ่มความสามารถในการหลบหลีก
> เพิ่มอัตราการหลบหลีกชั่วขณะ
> เมื่อใช้จะปลดสถานะผิดปกติ "เชื่องช้า"

**How it works**

- Support skill of the アサシンスキル tree (tier 1, max Lv 15); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `EvolutionBuf`: lasts `((Lv + 20) + (Lv + 20))` s / `(Lv + 20)` s; Lv1 → Lv10: Flee (dodge +) 11 → 20, FleeRate (dodge %) 1 → 10
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 994
- No proration slot: ExpType None: no proration slot.

**Status ailments**

- Removes ailment **Slow (11)** (`ActionHit`)
  - when `AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 11)`

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `EvolutionBuf` — `.ctor(Lv, 0, subWeaponType)`
- `ActionHit` (when the attack connects): adds a target's buff of `new EvolutionBuf` — `AddBuffer(new EvolutionBuf, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `EvolutionBuf`**
- Duration: `((Lv + 20) + (Lv + 20))` s [itemType eq 23 OR itemType eq 18 AND itemType ne 23]; `(Lv + 20)` s [itemType ne 18 AND itemType ne 23]

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flee | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |
| FleeRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `flee` = `(Lv + 10)` → Lv1..10 [11, 12, 13, 14, 15, 16, 17, 18, 19, 20] when itemType eq 23 OR itemType eq 18 AND itemType ne 23
  - `flee` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when itemType ne 18 AND itemType ne 23
  - `fleeRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when itemType eq 23 OR itemType eq 18 AND itemType ne 23 OR itemType ne 18 AND itemType ne 23
  - `isViewSelfIcon` = `(isSelf & 1)` when itemType eq 23 OR itemType eq 18 AND itemType ne 23 OR itemType ne 18 AND itemType ne 23
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:EvolutionBuf$$.ctor<-EvolutionAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `Flee`: dodge +
- `FleeRate`: dodge %

**In-game level notes**

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *2x ระยะเวลาแสดงผล *หลบหลีก +10

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 994_

---

### เวนอมอินเจค (VenomInject) · uid 1001

<img src="../../icons/sk_1001.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 15 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Flags:** NoMarketSearch · **Client class:** `VenomInjectAction`

> ทักษะลอบสังหารเคลือบพิษที่อาวุธ
> ใช้ HP ของตัวเองเพื่อเพิ่มโอกาสติดพิษร้าย
> ระหว่างการโจมตีปกติ อัตราการติด
> จะเปลี่ยนไปตามประสิทธิภาพของ
> ดาบสั้น/ม้วนคัมภีร์นินจูตสึ, คริติคอลและ Graze

**How it works**

- Buffer skill of the アサシンスキル tree (tier 1, max Lv 15); usable with ShortSword, NinjutsuScroll, MainHand.
- It installs a buff on the caster.
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Buffs:
  - `VenomInjectBuf`; Lv1 → Lv10: Percent (generic percent) 10 → 100
  - `CountBufferBase`
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `ActionHit` — when the attack connects: 3 call
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1001
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `VenomInjectBuf` — `.ctor(Lv, SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1001), 20), EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator))`
  - when `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1001) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new VenomInjectBuf` — `AddSelfBuffer(new VenomInjectBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1001) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): constructs `VenomInjectBuf` — `.ctor(Lv, 0, EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator))`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `VenomInjectBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `Prev`
- `Percent` = `CountBufferBase.GetParam(this, id)` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] when ((1 << weaponType) & 1537) ne 0 AND weaponType ls 10
  - `percent` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when weaponType hi 10 OR ((1 << weaponType) & 1537) eq 0 AND weaponType ls 10
  - `Count` = `(Max lt (addCount + lv) ? Max : (addCount + lv))` when weaponType hi 10 OR ((1 << weaponType) & 1537) eq 0 AND weaponType ls 10 OR ((1 << weaponType) & 1537) ne 0 AND weaponType ls 10
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:VenomInjectBuf$$.ctor<-VenomInjectAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Percent`: generic percent

**In-game level notes**

- Lv10: *อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล
- Lv9: *อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล
- Lv254: **อัตราติดพิษเพิ่มขึ้นตามสกิลเลเวล

**Where else this skill takes effect**

- Effect applied in `NormalAttackAction$$PossibilityAbnormalState` (3 guarded paths):
  - always
    - returns `0x165d9d4(meta(0x39744c8, AbnormalType[]_TypeInfo), 1, ?x2, ?x3)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165d9d4`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165d9d4`, `0x165db8c`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$PossibilityAbnormalState`
- Effect applied in `VenomInjectAction$$CalcPercent` (62 guarded paths):
  - when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) eq 0`
    - returns `((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1))`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) ne 0`
    - returns `(((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) ne 0`
    - returns `((((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1)) lt 0 ? (((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1)) + 1) : ((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) eq 0`
    - returns `((((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) lt 100 ? ((([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) lt 10 ? ([EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)+0x42] // 50) : 10) * SkillLv(1001)) : 100) << (critical & 1))`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) eq 0`
    - returns `((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1))`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) ne 0` AND `(glaze & 1) ne 0`
    - returns `(((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) ne 0`
    - returns `((((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1)) lt 0 ? (((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1)) + 1) : ((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1))) >> 1)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1001) ge 1` AND `(critical & 1) eq 0` AND `(glaze & 1) eq 0`
    - returns `((((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) lt 100 ? ((SkillLv(1001) + (SkillLv(1001) << 2)) << 1) : 100) << (critical & 1))`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- Code that reads this skill's level / buff by constant id: `NormalAttackAction$$PossibilityAbnormalState (ContainsBuffer)`, `VenomInjectAction$$CalcPercent (GetSkillLv)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1001_

---

### แบ็คสเต็ป (Backstep) · uid 995

<img src="../../icons/sk_995.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 2) · **Type:** Special · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]แอสแซสซินสแทบ[F]ฟรอนท์สแทบ[S]ไซด์สแทบ[B]แบ็คสแทบ[N] · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `BackstepAction`

> สกิลหลบหลีกอย่างว่องไว
> เมื่อเคลื่อนย้ายในระยะทางที่กำหนดได้สำเร็จ
> เพิ่มพลังโจมตีของแอสแซสซินสแทบที่จะใช้ถัดไป
> MP จะเพิ่มขึ้นเล็กน้อย
> เมื่อใช้ให้เข้ากับสัญญาณเตือนโจมตีของมอนสเตอร์

**How it works**

- Special skill of the アサシンスキル tree (tier 2, max Lv 35); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Buffs:
  - `BackstepBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 5 → 50
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionStart` — when the cast starts: 4 set, 2 call

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 995
- No proration slot: IsExpDefFluctuate=false.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `BackstepBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05`
- `ActionStart` (when the cast starts): adds the caster's buff of `new BackstepBuf` — `AddSelfBuffer(new BackstepBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) OR !PlayerAttackBase.IsBlank(this) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))` _(when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) ge MathUtil.DisplayMeterToDistance(3) AND MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) OR !MobManager.CheckMobRangeAttck(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_transform(actarAction)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND BackstepAction.CalcMoveDist(MathUtil.DisplayMeterToDistance(5), UnityEngine.Component.get_transform(actarAction), MathUtil.DisplayMeterToDistance(5)) lt MathUtil.DisplayMeterToDistance(3))_

**Buff values** (every recovered field; durations in seconds)

**Buff `BackstepBuf`**
- `Value` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

- Buff fields set in the constructor (all recovered):
  - `attackRate` = `((Lv << 2) + lv)` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BackstepBuf$$.ctor<-BackstepAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ปริมาณฟื้นฟู MP เป็น 2 เท่า

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 995_

---

### เซียรัม (Sierram) · uid 996

<img src="../../icons/sk_996.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 2) · **Type:** Support · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อีเวชัน · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `SierramAction`

> สกิลระงับความเจ็บปวด
> จะลดความเสียหายที่มีอย่างต่อเนื่องของพิษและไหม้ไฟชั่วระยะเวลาหนึ่ง

**How it works**

- Support skill of the アサシンスキル tree (tier 2, max Lv 35); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `SierramBuf`: lasts `((Lv + 10) * 3)` s / `(Lv + 10)` s; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 27 → 50, Value2 (second generic value) 12 → 30

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `ActionHit` — when the attack connects: 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 996
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `SierramBuf` — `.ctor(Lv, 0, EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator))`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds a target's buff of `new SierramBuf` — `AddBuffer(new SierramBuf, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0

**Buff values** (every recovered field; durations in seconds)

**Buff `SierramBuf`**
- Duration: `((Lv + 10) * 3)` s [subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon == ShortSword]; `(Lv + 10)` s [subWeapon != NinjutsuBook AND subWeapon != ShortSword]

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 27 | 30 | 32 | 35 | 37 | 40 | 42 | 45 | 47 | 50 |
| Value2 | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `BuffEffectActive` = `1` = 1 when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `BufEffectTakeUid` = `-1` = -1 when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `IsSelfAction` = `(self & 1)` when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `reducePoisonDamage` = `int(((Lv * 2.5) + 25))` → Lv1..10 [27, 30, 32, 35, 37, 40, 42, 45, 47, 50] when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `reduceIgnitionDamage` = `((Lv << 1) + 10)` → Lv1..10 [12, 14, 16, 18, 20, 22, 24, 26, 28, 30] when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
  - `isViewSelfIcon` = `(self & 1)` when subWeapon == NinjutsuBook OR subWeapon != NinjutsuBook AND subWeapon != ShortSword OR subWeapon != NinjutsuBook AND subWeapon == ShortSword
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)
- `Value2`: second generic value

**In-game level notes**

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ระยะเวลาแสดงผล x3

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 996_

---

### พิษกัดกร่อน (CorrosivePoison) · uid 1002

<img src="../../icons/sk_1002.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 35 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** เวนอมอินเจค · **Flags:** NoMarketSearch · **Client class:** `CorrosivePoison` (passive mastery)

> เวนอมอินเจคทำให้เพิ่มพิษร้ายซ้อนกันได้
> ถ้าเพิ่มพิษร้ายโดยการซ้อน(สูงสุด+2)
> การโจมตีของผู้เล่นอาจทำให้
> เกิดความเสียหายจากพิษร้ายได้ด้วย

**How it works**

- Mastery skill of the アサシンスキル tree (tier 2, max Lv 35); usable with ShortSword, NinjutsuScroll, MainHand.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `CorrosivePoison$$CalcCorrosivePoison` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Effect applied in `CorrosivePoison$$CalcCorrosivePoison` (9 guarded paths):
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
    - returns `1`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
    - returns `0`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
    - returns `1`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) ne 1`
    - returns `0`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
    - returns `1`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
    - returns `0`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
    - returns `1`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`, `AbnormalPoisonData$$get_PoisonLevel`
  - when `(AbnormalStateManager.TryGetAbnormalStateData(EnemyMobActionManagerBase.get_AbnormalStateManager(mobAction, 0, damageData, poisonType), 5, stkp(-56), 0) & 1) ne 0` AND `TryGetAbnormalStateData.out2() ne 0` AND `SkillLv(1002) ge 1` AND `SkillLv(1002) eq 1`
    - returns `0`
    - calls `EnemyMobActionManagerBase$$get_AbnormalStateManager`, `AbnormalStateManager$$TryGetAbnormalStateData`, `AbnormalPoisonData$$CheckMaxPoisonLevel`, `AbnormalPoisonData$$get_PoisonLevel`, `VenomInjectAction$$CalcPercent`, `UnityEngine.Random$$Range`
- Code that reads this skill's level / buff by constant id: `CorrosivePoison$$CalcCorrosivePoison (GetSkillLv)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1002_

---

### ฟูเนวินเด (FuneVinte) · uid 997

<img src="../../icons/sk_997.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** ShortSword, NinjutsuScroll · **Requires:** แบ็คสเต็ป · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `FuneVinteAction`

> แก่นแท้สกิลของกลุ่มนักฆ่าที่สืบทอดต่อกันมา
> ใช้ MP ทั้งหมดเพื่อโจมตีเป้าหมาย
> เพิ่มปริมาณการฟื้นฟู MP สูงขึ้นจนกว่าจะใช้สกิลถัดไป
> ถ้าไม่ถูกเล็งเป้าเฮทของตัวเองจะลดน้อยลงเป็นอย่างมาก

**How it works**

- Attack skill of the アサシンスキル tree (tier 3, max Lv 125); usable with ShortSword, NinjutsuScroll.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- MP: `PlayerAttackBase.CalcCostMp(this, actarAction)` (conditional variants below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +550 at Lv1 to 1000 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `FuneVinteBuf`; Lv1 → Lv10: AttackMprecoveryUp (MP recovered per attack (flat)) 10 → 20
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `PlayerAttackBase.CalcCostMp(this, actarAction)`
- **MP cost** (`costMp` in `OnInitialize`): `PlayerAttackBase.CalcCostMp(this, actarAction)`
- **MP cost** (`mp` in `SetComboType`): `0` = 0
  - when `comboType eq 4`
- **MP cost** (`costMp` in `SetComboType`): `0` = 0
  - when `comboType eq 4`
- **MP cost** (`mp` in `RecalcCostMp`): `0` = 0
  - when `(SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4`
- **MP cost** (`costMp` in `RecalcCostMp`): `0` = 0
  - when `(SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4`
- **MP cost** (`mp` in `RecalcCostMp`): `PlayerAttackBase.CalcCostMp(this, playerAction)`
  - when `(SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) ne 4`
- **MP cost** (`costMp` in `RecalcCostMp`): `PlayerAttackBase.CalcCostMp(this, playerAction)`
  - when `(SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) ne 4`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(3)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `SetComboType` — skill-specific method: 2 set
- `ActionPreparation` — before the cast starts: 3 set
- `ActionStart` — when the cast starts: 7 set, 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 5 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info
- `RecalcCostMp` — skill-specific method: 4 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 550 | 600 | 650 | 700 | 750 | 800 | 850 | 900 | 950 | 1000 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))) / 100)` — !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `(((((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))) / 100)` — !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 1) + ((PlayerAttackBase.get_Mp() // 100) * ((int((AssassinationSecrets.GetFuneVinteMpSkillRate(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1005, 1), PlayerActionManagerBase.get_PlayerStatus()))) + 60) + (Lv << 2))))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 50) + 500))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 997
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int((MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) * 100))`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `FuneVinteBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05`
- `ActionStart` (when the cast starts): adds the caster's buff of `new FuneVinteBuf` — `AddSelfBuffer(new FuneVinteBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05`

**Other recovered parameters**

- **MP cost** (`mp`): `PlayerAttackBase.CalcCostMp(this, actarAction)`; `0` = 0 _(when comboType eq 4)_; `0` = 0 _(when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4)_
- **MP cost** (`costMp`): `PlayerAttackBase.CalcCostMp(this, actarAction)`; `0` = 0 _(when comboType eq 4)_; `0` = 0 _(when (SkillComboState.get_CurrentComboType(_currentSkillCombo) & 255) eq 4)_
- **Loop / hit-repeat count** (`LoopParam`): `int((MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) * 100))`

**Buff values** (every recovered field; durations in seconds)

**Buff `FuneVinteBuf`**
- `AttackMprecoveryUp` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AttackMprecoveryUp | 10 | 10 | 10 | 10 | 10 | 20 | 20 | 20 | 20 | 20 |

- Buff fields set in the constructor (all recovered):
  - `atkMpRecovery` = `(Lv hi 5 ? 20 : 10)` → Lv1..10 [10, 10, 10, 10, 10, 20, 20, 20, 20, 20]
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:FuneVinteBuf$$.ctor<-FuneVinteAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
    - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyMotionSpeedValue` = `255`
    - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
    - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
    - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
    - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyMotionSpeedValue` = `255`
    - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
    - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
    - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
    - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyMotionSpeedValue` = `255`
    - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
    - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
    - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
    - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyMotionSpeedValue` = `255`
    - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
  - when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
    - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
    - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- Code that reads this skill's level / buff by constant id: `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 997_

---

### ละทิ้ง (Abandonment) · uid 998

<img src="../../icons/sk_998.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เซียรัม · **Flags:** NoMarketSearch · **Client class:** `Abandonment` (passive mastery)

> เพิ่มความสามารถในการหลบหลีกของตัวเองจนเกินขีดจำกัด
> ลดความแม่นที่มีของมอนสเตอร์ลงต่ำสุด
> ทำให้หลบหลีกได้ดีกว่าเดิม
> เพิ่มพลังของแอสแซสซินสแทบ

**How it works**

- Mastery skill of the アサシンスキル tree (tier 3, max Lv 125); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): LastDmgRate (final damage dealt %) 5 at Lv1 to 50 at Lv10, Hit (accuracy) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Hit | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `LastDmgRate`: final damage dealt %
- `Hit`: accuracy

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 998_

---

### เวนอมสแนทช (VenomSnatch) · uid 1003

<img src="../../icons/sk_1003.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** พิษกัดกร่อน · **Flags:** NoMarketSearch · **Client class:** `VenomSnatchAction`

> ช่วงชิงพิษกัดกร่อนเป้าหมาย
> ฟื้นฟู HP และสถานะพิษของตัวเอง
> 
> ถ้าเป็นพิษร้ายที่อัพเกรดจะฟื้นฟู MP ด้วย
> ถ้าไม่มีพิษที่สามารถกำจัดออกจาก
> ตัวเองได้จะได้รับผลการป้องกัน

**How it works**

- Attack skill of the アサシンスキル tree (tier 3, max Lv 125); usable with ShortSword, NinjutsuScroll, MainHand.
- It installs a buff on the caster.
- Buffs:
  - `VenomSnatchBuf`
  - `CountBufferBase`
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(12)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `CheckCollectionAbnormalPoisonTarget` — skill-specific method: 3 set
- `BattleResult` — when the battle result arrives: 4 call
- `GiveVaccinations` — skill-specific method: 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 1003
- No proration slot: IsExpDefFluctuate=false.

**Buffs and effects it installs or removes**

- `BattleResult` (when the battle result arrives): constructs `VenomSnatchBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), ?ubfx)`
  - when `(flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1`
- `BattleResult` (when the battle result arrives): adds the caster's buff of `new VenomSnatchBuf` — `AddSelfBuffer(new VenomSnatchBuf, 0)`
  - when `(flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 OR (flag & 255) eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1004, 1) ge 1 AND VenomSnatchAction.CalcHpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) lt 1 AND VenomSnatchAction.CalcMpHealValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1003, 1), PlayerActionManagerBase.get_PlayerStatus(), ?ubfx) ge 1`
- `GiveVaccinations` (method): removes a target's buff of skill 231 (Recovery) — `RemoveBuffer(231)`
  - when `(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 231).effectType - 1) ls 1 AND RecoveryBuf.CreateVenomSnatchBuf(poisonLevel).LeftTime gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 231).LeftTime AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 231) ne 0`
- `GiveVaccinations` (method): adds the caster's buff of `RecoveryBuf.CreateVenomSnatchBuf(poisonLevel)` — `AddSelfBuffer(RecoveryBuf.CreateVenomSnatchBuf(poisonLevel), 0)`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(12)`

**Buff values** (every recovered field; durations in seconds)

**Buff `VenomSnatchBuf`**
- `Value` = `(poisonLevel)` _(when BuffEffectActive ne 0)_
- `Value` = `CountBufferBase.GetParam(this, id)` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `poisonLevel` = `poisonLevel`
  - `Count` = `poisonLevel`
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:VenomSnatchBuf$$.ctor<-VenomSnatchAction$$BattleResult` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `DeathReceptionAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `VenomSnatchAction$$BattleResult` (17 guarded paths):
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `0x165db78`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`, `0x165db78`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `0x165db78`, `VenomSnatchBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`
- Code that reads this skill's level / buff by constant id: `DeathReceptionAction$$IsFailure (ContainsBuffer)`, `VenomSnatchAction$$BattleResult (GetSkillLv)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1003_

---

### ซิคาเรียส (Seekerius) · uid 999

<img src="../../icons/sk_999.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แบ็คสเต็ป · **Flags:** NoMarketSearch · **Client class:** `Seekerius` (passive mastery)

> เพิ่มพลังของแบ็คสแทบแบบถาวร
> นอกจากนี้ถ้าใช้แบ็คสแทบสำเร็จ
> เมื่อได้รับความเสียหายจากATKและอาวุธเจาะเข้าที่อัพเกรดขึ้นเล็กน้อย
> จะทำให้บรรเทาลงและการอัพเกรดจะสิ้นสุด

**How it works**

- Mastery skill of the アサシンスキル tree (tier 4, max Lv 205); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `SeekeriusBuf`: lasts `30` s; Lv1 → Lv10: AtkUp (ATK +) 10 → 100, PowerResistBreaker (physical pierce) 16 → 25
- Passive modifiers (negative = penalty): LastDmgRate (final damage dealt %) 15 at Lv1 to 150 at Lv10.

**Buff values** (every recovered field; durations in seconds)

**Buff `SeekeriusBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `30` s
- `Value` = `int(((rate) * 100))`
- `MobLastDamageRateBuf` = `(int(((Lv + 10) * rate)))`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkUp | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| PowerResistBreaker | 16 | 17 | 18 | 19 | 20 | 21 | 22 | 23 | 24 | 25 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `stubRate` = `rate`
  - `damageCut` = `int(((Lv + 10) * rate))`
  - `IsDamageCancel` = `1` = 1
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `atkUp` = `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] when val eq 1
  - `atkUp` = `((Lv << 2) + lv)` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50] when val ne 1
  - `powerResistBreaker` = `(Lv + 15)` → Lv1..10 [16, 17, 18, 19, 20, 21, 22, 23, 24, 25] when val eq 1
  - `powerResistBreaker` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when val ne 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUp`: ATK +
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)
- `PowerResistBreaker`: physical pierce
- `Value`: generic value (meaning set by the code that reads the buff)

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgRate | 15 | 30 | 45 | 60 | 75 | 90 | 105 | 120 | 135 | 150 |


Bonus meanings (inferred from the names):

- `LastDmgRate`: final damage dealt %

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 999_

---

### ชาโดว์วอล์ค (ShadowWalk) · uid 1000

<img src="../../icons/sk_1000.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 205 · **Weapons:** ShortSword, NinjutsuScroll · **Requires:** ละทิ้ง · **Flags:** NoMarketSearch · **Client class:** `ShadowWalkAction`

> ถ้าตัวเองไม่ได้ถูกเล็งเป็นเป้าหมายในระยะเวลาสั้นๆ
> ผลการโจมตีเพิ่มจะเปลี่ยนตาม Avoid (ระยะยิงขึ้นอยู่กับอาวุธ)
> การโจมตีเพิ่มจะถูกอัพเกรดด้วยการกระทำที่เจาะจงแต่ถ้าได้รับ
> ความเสียหายขณะถูกเล็งการอัพเกรดจะถูกรีเซ็ตและไม่สามารถใช้งานได้อีก

**How it works**

- Buffer skill of the アサシンスキル tree (tier 4, max Lv 205); usable with ShortSword, NinjutsuScroll.
- It installs a buff on the caster.
- Buffs:
  - `ShadowWalkBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1000
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `ShadowWalkBuf` — `.ctor(Lv, actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ShadowWalkBuf` — `AddSelfBuffer(new ShadowWalkBuf, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `ShadowWalkBuf`**
- Buff hook methods: `SyncStackCount`, `get_InvincibilityLocalId`, `get_IsInRange`, `get_IsInvalidDamage`, `get_IsManual`, `set_InvincibilityLocalId`, `set_IsInRange`, `set_IsInvalidDamage`, `set_IsManual`
- Buff fields set in the constructor (all recovered):
  - `playerAction` = `player`
- Hook `set_IsInvalidDamage`: `IsInvalidDamage`=(value & 1)
- Hook `set_IsInRange`: `IsInRange`=(value & 1)
- Hook `set_IsManual`: `IsManual`=(value & 1)
- Hook `set_InvincibilityLocalId`: `InvincibilityLocalId`=value
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SyncStackCount`: `Count`=(stack lt 0 ? 0 : (Max lt stack ? Max : stack))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:ShadowWalkBuf$$.ctor<-ShadowWalkAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter

**In-game level notes**

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] จะอัพเกรดเพิ่มการโจมตีเมื่อใช้ Avoid, แอสแซสซินสแทบ แบ็คสเต็ป (เฉพาะที่สำเร็จ)  ถ้าค่าอัพเกรดตั้งแต่ 10 ขึ้นไป เมื่อได้รับความเสียหายระหว่าง Avoid จะใช้ค่าอัพเกรดเพื่ออัพเกรดเพิ่มการโจมตีให้มากขึ้นอีก

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (297 guarded paths, truncated):
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
  - when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
    - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- Code that reads this skill's level / buff by constant id: `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1000_

---

### เดธรีเซฟชัน (DeathReception) · uid 1004

<img src="../../icons/sk_1004.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 4) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** เวนอมสแนทช · **Flags:** NoMarketSearch · **Client class:** `DeathReceptionAction`

> ใช้พิษที่ช่วงชิงมาด้วยเวนอมสแนทชจะสร้าง
> ความเสียหายและดีบัฟพิษร้ายแก่เป้าหมาย
> นอกจากนี้จะสร้างความเสียหายเพิ่มเติม
> ก่อให้เกิดพิษต่อพื้นที่โดยรอบขึ้นอยู่กับพิษที่ใช้

**How it works**

- Attack skill of the アサシンスキル tree (tier 4, max Lv 205); usable with ShortSword, NinjutsuScroll, MainHand.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2]: skill multiplier depends on Dex (formula below)
  - ... and 2 more variants (see the tables below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Poison (5).
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(7)`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 28 set
- `ActionPreparation` — before the cast starts: 8 set, 1 call
- `CheckRangeHit` — range-hit test: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 4 tpl, 2 call, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [!UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword & UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2
- SkillRate × `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon != OneHandSword & !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500))) / 100)`
  - when `UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`
  - when `UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) OR (poisonLevel & 0x80000000) ne 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)) / 100)`
  - when `!UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(0)`
  - when `!UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1004
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `100`% to inflict **Poison (5)** (`CheckRangeHit`)
  - when `!FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND MobActionManagerBase.HasPlayerHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND PlayerAttackBase.checkAbnormalPercent(this, 5, 100, actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND !PlayerAttackBase.checkAbnormalPercent(this, 5, 100, actorPlayerAction) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND MobActionManagerBase.HasPlayerHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND MobActionManagerBase.HasPlayerHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND PlayerAttackBase.checkAbnormalPercent(this, 5, 100, actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size)`
- Rolls `VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1))`% to inflict **Poison (5)** (`CheckRangeHit`)
  - when `!MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND PlayerAttackBase.checkAbnormalPercent(this, 5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !PlayerAttackBase.checkAbnormalPercent(this, 5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size) OR !FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) AND !MobActionManagerBase.GetHate(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !MobActionManagerBase.get_IsDeadOrLocalDead(UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)) AND !UnityEngine.Object.op_Equality(mainTarget, targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).x - attackPos) * (UnityEngine.Transform.get_position(targetTransform).x - attackPos)) + ((UnityEngine.Transform.get_position(targetTransform).z - attackPos.z) * (UnityEngine.Transform.get_position(targetTransform).z - attackPos.z))) le ((attackRange + size) * (attackRange + size)) AND PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND PlayerAttackBase.checkAbnormalPercent(this, 5, VenomInjectAction.CalcPercent(PlayerActionManagerBase.get_PlayerStatus(), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 6) & 1), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, actorPlayerAction, UnityEngine.Component.GetComponent<MobActionManagerBase>(targetTransform)), 4) & 1)), actorPlayerAction) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - attackPos.y), size)`
- Marks the hit with ailment **Poison (5)** (`calcPlayerToMobDamage`)
  - when `!UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel eq 2 AND poisonLevel ne 1 OR !UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction))) AND poisonLevel ne 1 AND poisonLevel ne 2`
- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): removes the caster's buff of skill 1003 (VenomSnatch) — `RemoveSelfBuffer(1003)`
  - when `!PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1007, 1) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1003) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): constructs `DeadlyPoisonDebuff` — `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), poisonLevel)`
  - when `(poisonLevel & 0x80000000) eq 0 AND UnityEngine.Object.op_Equality(mainTarget, UnityEngine.GameObject.get_transform(MobActionManagerBase.get_gameObject(mobAction)))`

**Other recovered parameters**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(8)`
- **Range-dependent multiplier (%)** (`rangeSkillRate`): `(((((Lv * 25) + 250) + status.Dex) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function lt 500 ? EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function : 500)) * 0.5)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword)_; `((((Lv * 25) + 250) + status.Dex) * 0.5)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword)_; `(((((Lv * 25) + 250) + status.Dex) + (int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) lt 500 ? int((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function * 0.8)) : 500)) * 0.5)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 23 AND mainWeapon != Halberd AND mainWeapon != Null AND mainWeapon == OneHandSword)_

**In-game level notes**

- Lv10: *พลังเพิ่มตามค่า DEX ของตัวเอง *อาวุธเจาะเข้า+25%
- Lv254: *พลังเพิ่มตามเลเวลของตัวเอง *อาวุธเจาะเข้า+25%

**Where else this skill takes effect**

- Effect applied in `FuneVinteAction$$ActionPreparation` (6 guarded paths):
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
    - returns `?blr`
    - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
    - returns `?blr`
    - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`
  - when `SkillLv(1004) lt 1` AND `SkillLv(1005) ge 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
  - when `SkillLv(1004) lt 1` AND `SkillLv(1005) lt 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`
- Effect applied in `VenomSnatchAction$$BattleResult` (16 guarded paths):
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `Singleton<object>$$get_Instance`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `0x165db78`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`, `0x165db78`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryMp`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) ge 1`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`, `0x165db78`, `VenomSnatchBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(1003) ge 1` AND `(flag & 255) eq 0` AND `SkillLv(1004) lt 1`
    - returns `SkillLv(1004)`
    - calls `VenomSnatchAction$$CalcHpHealValue`, `VenomSnatchAction$$CalcMpHealValue`, `VenomSnatchAction$$GiveVaccinations`
- Code that reads this skill's level / buff by constant id: `FuneVinteAction$$ActionPreparation (GetSkillLv)`, `VenomSnatchAction$$BattleResult (GetSkillLv)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1004_

---

### เคล็ดลับลอบสังหาร (AssassinationSecrets) · uid 1005

<img src="../../icons/sk_1005.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ฟูเนวินเด · **Flags:** NoMarketSearch · **Client class:** `AssassinationSecrets` (passive mastery)

> เพิ่มความเข้าใจในทักษะการลอบสังหาร
> เพิ่มพลังของสกิล[แอสแซสซินสแทบ]และสกิล[ฟิวเนวินเต้]

**How it works**

- Mastery skill of the アサシンスキル tree (tier 5, max Lv 285); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `AssassinStubAction$$ActionPreparation`, `FuneVinteAction$$ActionPreparation` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**In-game level notes**

- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *พลังของแอสแซสซินสแทบจะเพิ่มขึ้นอีก

**Where else this skill takes effect**

- Effect applied in `FuneVinteAction$$ActionPreparation` (6 guarded paths):
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
    - returns `?blr`
    - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
    - returns `?blr`
    - set `targetDeadlyPoison` = `(MobBuffManager.Contains(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3), 14, 0,`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$get_BuffManager`, `MobBuffManager$$Contains`
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) ge 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
  - when `SkillLv(1004) ge 1` AND `SkillLv(1005) lt 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`
  - when `SkillLv(1004) lt 1` AND `SkillLv(1005) ge 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * ((int(fcvt(AssassinationSecrets.GetFuneVinteMpSkillRate(SkillLv(1005), ?blr, 0, ?x3))) + 60) + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `AssassinationSecrets$$GetFuneVinteMpSkillRate`
  - when `SkillLv(1004) lt 1` AND `SkillLv(1005) lt 1`
    - returns `?blr`
    - set `skillRate` = `(((Lv + (Lv << 2)) << 1) + ((?blr // 100) * (60 + (Lv << 2))))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`
- Effect applied in `AssassinStubAction$$ActionPreparation` (8 guarded paths):
  - when `SkillLv(1005) ge 1`
    - set `direction` = `2`
    - set `skillRate` = `((((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(?blr, 1005, 1`
    - set `SkillIndividualFlag` = `2`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) lt 1`
    - set `direction` = `2`
    - set `skillRate` = `(((isEquipBonus eq 0 ? 105 : 205) + (Lv + (Lv << 1))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
    - set `SkillIndividualFlag` = `2`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) ge 1`
    - set `direction` = `0`
    - set `skillRate` = `((((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillLv(1005), ?bl`
    - set `SkillIndividualFlag` = `0`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) lt 1`
    - set `direction` = `0`
    - set `skillRate` = `(((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
    - set `SkillIndividualFlag` = `0`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) ge 1`
    - set `direction` = `0`
    - set `skillRate` = `((((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillLv(1005), ?bl`
    - set `SkillIndividualFlag` = `0`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) lt 1`
    - set `direction` = `0`
    - set `skillRate` = `(((Lv + (isEquipBonus eq 0 ? 0 : 50)) + 100) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
    - set `SkillIndividualFlag` = `0`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) ge 1`
    - set `direction` = `1`
    - set `skillRate` = `((((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3)) + AssassinationSecrets.GetAssassinStubSkillRate(SkillManager.GetSkillLv(?blr, 1005, 1`
    - set `SkillIndividualFlag` = `1`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
  - when `SkillLv(1005) lt 1`
    - set `direction` = `1`
    - set `skillRate` = `(((isEquipBonus eq 0 ? 110 : 410) + (Lv + (Lv << 3))) + GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1004, 0, ?x3), 4, 0, ?x3))`
    - set `SkillIndividualFlag` = `1`
    - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, UnityEngine.GameObject.GetComponent<object>(target, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3), 0)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_forward`, `MathUtil$$RelativeXZAngle`
- Code that reads this skill's level / buff by constant id: `AssassinStubAction$$ActionPreparation (GetSkillLv)`, `FuneVinteAction$$ActionPreparation (GetSkillLv)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1005_

---

### แอสเซาท์เชส (AssaultChase) · uid 1006

<img src="../../icons/sk_1006.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 5) · **Type:** Buffer · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ชาโดว์วอล์ค · **Flags:** NoMarketSearch · **Client class:** `AssaultChaseAction`

> เมื่อได้รับผลของบัฟใหม่จะฟื้นฟูAvoid 50%
> ลดปริมาณการใช้Avoidที่มุ่งไปยัง(หรือรอบๆ)เป้าหมาย
> ที่โจมตีเป็นเวลา 180 วินาที
> เมื่อจำนวนAvoidที่เหลืออยู่เป็น 0 ผลของบัฟจะสิ้นสุดลงเช่นกัน

**How it works**

- Buffer skill of the アサシンスキル tree (tier 5, max Lv 285); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Buffs:
  - `AssaultChaseBuf`: lasts `180` s; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 2750 → 5000
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**When each part runs**

- `ActionHit` — when the attack connects: 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1006
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `AssaultChaseBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new AssaultChaseBuf` — `AddSelfBuffer(new AssaultChaseBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `AssaultChaseBuf`**
- Buff hook methods: `AvoidSuccess`
- Duration: `180` s [EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23]
- `ShortRangeRate` = `(0)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2750 | 3000 | 3250 | 3500 | 3750 | 4000 | 4250 | 4500 | 4750 | 5000 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `shortRangeRate` = `0` when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23
  - `isShortRangeRateBonus` = `1` = 1 when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18
  - `isShortRangeRateBonus` = `0` when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23
  - `avoidConsumptionReductionValue` = `int((((Lv * 2.5) + 25) * 100))` → Lv1..10 [2750, 3000, 3250, 3500, 3750, 4000, 4250, 4500, 4750, 5000] when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 23 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18
  - `avoidConsumptionReductionValue` = `int(((Lv * 2.5) * 100))` → Lv1..10 [250, 500, 750, 1000, 1250, 1500, 1750, 2000, 2250, 2500] when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18 AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 23
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `AvoidSuccess`: `shortRangeRate`=(((isShortRangeRateBonus ne 0 ? 2 : 1) + shortRangeRate) lt 10 ? ((isShortRangeRateBonus ne 0 ? 2 : 1) + shortRangeRate) : 10)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AssaultChaseBuf$$.ctor<-AssaultChaseAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `ShortRangeRate`: short-range damage %
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv255: เมื่อหลบหลีกด้วย Avoid ได้สำเร็จในขณะที่ บัฟทำงานอยู่จะเพิ่มผลทำให้พลังโจมตีระยะใกล้เพิ่มขึ้น  เพิ่มผล Avoid ในท่าเปิดใช้งานของ แอสเซาท์เชสเฉพาะสกิลเลเวล 10 เท่านั้น
- Lv18: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *ลดการใช้ของ Avoid ลงอีก *เพิ่มจำนวนพลังโจมตีระยะใกล้เมื่อ Avoid สำเร็จ (ขีดจำกัดสูงสุดยังคงไม่เปลี่ยนแปลง)

**Where else this skill takes effect**

- Effect applied in `AssaultChaseAction$$CheckAssaultChase` (3 guarded paths):
  - always
    - returns `0`
  - always
    - returns `(1 | (0 | (int(MathUtil.DistanceToDisplayMeter(0, [((vtab(UnityEngine.GameObject.GetComponent<object>([[[playerAction+0x30]+0x48]+0x18], meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3)) + ([(meta(0) + 8)+0x0] << 4)) + 312)+0x8], ?x2, ?x3)) lt 8 ? 1 : 0)))`
    - calls `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Quaternion$$AngleAxis`, `UnityEngine.Quaternion$$op_Multiply`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`
  - always
    - returns `0`
- Code that reads this skill's level / buff by constant id: `AssaultChaseAction$$CheckAssaultChase (ContainsBuffer)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1006_

---

### นักปรุงยาพิษ (PoisonMixer) · uid 1007

<img src="../../icons/sk_1007.png" width="40" alt="icon"> 
**Tree:** アサシンスキル (`AssassinSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** ShortSword, NinjutsuScroll, MainHand · **Requires:** เดธรีเซฟชัน · **Flags:** NoMarketSearch · **Client class:** `PoisonMixer` (passive mastery)

> เพิ่มระยะเวลาภาวะผิดปกติของ[พิษ]
> และพลังของสกิล[เดธรีเซฟชัน]
> มีโอกาสทำให้ติดพิษจากความเสียหายที่เกิดจากพิษร้าย
> เพิ่ม(การพึ่งพาเวนอมอินเจค) 

**How it works**

- Mastery skill of the アサシンスキル tree (tier 5, max Lv 285); usable with ShortSword, NinjutsuScroll, MainHand.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `DeathReceptionAction$$ActionPreparation` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Where else this skill takes effect**

- Effect applied in `DeathReceptionAction$$ActionPreparation` (6 guarded paths):
  - when `SkillLv(1007) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1003, 0, ?x3)`
    - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x12c` = `?v1`
    - set `+0x130` = `?v2`
    - set `actorPlayerAction` = `actarAction`
    - set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
    - set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
    - set `poisonLevel` = `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3)`
    - set `singleResistBreaker` = `((SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3) * 25) + singleResistBreaker)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `PoisonMixer$$GetDeathReceptionSingleAttackSkillRate`, `PoisonMixer$$GetDeathReceptionRangeAttackSkillRate`
  - when `SkillLv(1007) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x12c` = `?v1`
    - set `+0x130` = `?v2`
    - set `actorPlayerAction` = `actarAction`
    - set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
    - set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `PoisonMixer$$GetDeathReceptionSingleAttackSkillRate`, `PoisonMixer$$GetDeathReceptionRangeAttackSkillRate`
  - when `SkillLv(1007) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>()))`
    - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x12c` = `?v1`
    - set `+0x130` = `?v2`
    - set `actorPlayerAction` = `actarAction`
    - set `singleSkillRate` = `(singleSkillRate + PoisonMixer.GetDeathReceptionSingleAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
    - set `rangeSkillRate` = `(rangeSkillRate + PoisonMixer.GetDeathReceptionRangeAttackSkillRate(SkillLv(1007), ?blr, 0, ?x3))`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `PoisonMixer$$GetDeathReceptionSingleAttackSkillRate`, `PoisonMixer$$GetDeathReceptionRangeAttackSkillRate`
  - when `SkillLv(1007) lt 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1003, 0, ?x3)`
    - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x12c` = `?v1`
    - set `+0x130` = `?v2`
    - set `actorPlayerAction` = `actarAction`
    - set `poisonLevel` = `SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3)`
    - set `singleResistBreaker` = `((SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(), 50, 0, ?x3) * 25) + singleResistBreaker)`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$RemoveSelfBuffer`
  - when `SkillLv(1007) lt 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x12c` = `?v1`
    - set `+0x130` = `?v2`
    - set `actorPlayerAction` = `actarAction`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db84`
  - when `SkillLv(1007) lt 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>())) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf<object>(?blr, 1003, stkp(-56), meta(0x39a7e98, Method$SkillBufferManager.TryGetBuf<VenomSnatchBuf>()))`
    - set `mainTarget` = `UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x12c` = `?v1`
    - set `+0x130` = `?v2`
    - set `actorPlayerAction` = `actarAction`
    - calls `PlayerAttackBase$$ActionPreparation`, `UnityEngine.GameObject$$get_transform`, `0x165d8dc`, `UnityEngine.Transform$$get_position`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`
- Code that reads this skill's level / buff by constant id: `DeathReceptionAction$$ActionPreparation (GetSkillLv)`

_Raw recovered data (every method item): [trees/AssassinSkill.md](../trees/AssassinSkill.md) — uid 1007_

---
