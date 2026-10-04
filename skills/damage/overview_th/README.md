# คำอธิบายโดยรวมของสกิล (overview_th)

สร้างโดย `scripts/build_overview.py` จาก `calc_spec/`, `skill_reference.json`, `skillrecipes/`, `variables.json` (label: Code / Inferred / Text).
อ่านวิธีอ่านหน้าสกิลที่ [ENGINE.md](ENGINE.md)

| ทรี | สกิล | มี damage term | แยกอาวุธ | คงกระพัน/Super Armor | บัพป้องกัน |
|---|---|---|---|---|---|
| [(internal)](internal.md) | 53 | 36 | 6 | 3 | 7 |
| [สกิลดาบ](BladeSkill.md) | 24 | 16 | 10 | 1 | 3 |
| [สกิลยิง](ShootSkill.md) | 25 | 16 | 12 | 1 | 0 |
| [สกิลเวทมนตร์](MagicSkill.md) | 24 | 13 | 9 | 1 | 2 |
| [สกิลมาร์เชียล](MarshallSkill.md) | 22 | 13 | 4 | 1 | 1 |
| [สกิลการ์ด](GuardSkill.md) | 7 | 0 | 0 | 0 | 0 |
| [สกิลเอาตัวรอด](SurvivalSkill.md) | 9 | 0 | 0 | 0 | 0 |
| [สกิลสนับสนุน](SupportSkill.md) | 13 | 0 | 0 | 0 | 5 |
| [สกิลโล่](ShieldSkill.md) | 14 | 5 | 3 | 0 | 4 |
| [สกิลมีดสั้น](KnifeSkill.md) | 13 | 8 | 3 | 1 | 1 |
| [สกิลพ่อค้า](MerchantSkill.md) | 11 | 0 | 0 | 0 | 0 |
| [สกิลช่างตีเหล็ก](SmithSkill.md) | 23 | 0 | 0 | 0 | 0 |
| [สกิลเล่นแร่แปรธาตุ](AlchemySkill.md) | 19 | 0 | 0 | 0 | 0 |
| [สกิลฟาลังซ์](LuckSkill.md) | 9 | 0 | 0 | 0 | 0 |
| [สกิลเทมเมอร์](TamerSkill.md) | 7 | 0 | 0 | 0 | 0 |
| [สกิลต่อสู้](BattleSkill.md) | 15 | 0 | 0 | 0 | 0 |
| [สกิลอัศวิน](KnightSkill.md) | 15 | 6 | 4 | 0 | 5 |
| [สกิลฮันเตอร์](HunterSkill.md) | 17 | 11 | 7 | 1 | 1 |
| [สกิลโกเล็ม](GolemSkill.md) | 12 | 3 | 0 | 0 | 1 |
| [สกิลโมโนโนฟุ](MononofuSkill.md) | 23 | 13 | 0 | 3 | 2 |
| [สกิลดาบคู่](DualSword.md) | 21 | 13 | 3 | 1 | 4 |
| [สกิลพาร์ทิซาน](PartisanSkill.md) | 9 | 4 | 0 | 0 | 1 |
| [สกิลสไปรท์](SpriteSkill.md) | 18 | 5 | 0 | 1 | 2 |
| [สกิลมินสเตรล](Minstrel.md) | 10 | 1 | 0 | 0 | 3 |
| [สกิลแดนเซอร์](DancerSkill.md) | 7 | 1 | 0 | 0 | 1 |
| [สกิลนักบวช](PriestSkill.md) | 15 | 5 | 1 | 0 | 3 |
| [สกิลเมจิกเบลด](MagicBladeSkill.md) | 15 | 5 | 1 | 0 | 2 |
| [ทรี 28 (สกิล NPC/ผู้ช่วย)](28.md) | 6 | 2 | 0 | 0 | 0 |
| [สกิลสัตว์เลี้ยง](PetSkill.md) | 27 | 13 | 0 | 0 | 1 |
| [สกิลหอกวายุ](HalberdSkill.md) | 22 | 15 | 2 | 3 | 3 |
| [สกิลนักฆ่า](AssassinSkill.md) | 15 | 3 | 2 | 0 | 2 |
| [สกิลจอมเวทย์](WizardSkill.md) | 15 | 5 | 0 | 0 | 0 |
| [สกิลพลังมืด](DarkPowerSkill.md) | 12 | 10 | 0 | 1 | 3 |
| [สกิลมือเปล่า](BareHandSkill.md) | 12 | 0 | 0 | 0 | 1 |
| [สกิลเนโครแมนเซอร์](NecromancerSkill.md) | 12 | 6 | 0 | 0 | 2 |
| [สกิลครัชเชอร์](CrusherSkill.md) | 10 | 7 | 0 | 0 | 1 |
| [ทรี 37 (ไม่มีชื่อ ยังไม่เปิดใช้)](37.md) | 8 | 0 | 0 | 0 | 0 |
| [สกิลนินจา](NinjaSkill.md) | 4 | 0 | 0 | 0 | 0 |
| [สกิลอีเวนต์](EventSkill.md) | 3 | 3 | 0 | 1 | 0 |
| [สกิลอีเวนต์/คอลแลบ](AvatarSkill_1.md) | 5 | 4 | 0 | 0 | 1 |
| [สกิลดีบั๊ก](DebugSkill.md) | 29 | 0 | 0 | 0 | 0 |

## Coverage

| item | skills |
|---|---|
| skills | 630 |
| with_damage_terms | 242 |
| weapon_split | 67 |
| cast_state_code | 20 |
| defense_buff | 62 |
| game_text_state | 100 |
| has_link | 258 |
| variants | 30 |
| ailment | 90 |

## Cross-check: in-game text vs decoded code

- skills whose in-game text says invincible (คงกระพัน/อมตะ): 11; of them with a decoded invincibility call/effect: 9
- text but no call in the action (effect lives in an engine hook that reads the buff; see section 3 of the skill): แอดลิบ (773), ชิฟท์ (1039)
- decoded invincibility without matching in-game text: 8 skills (not an error: the text may omit it)

## Open items (Inferred / not decoded)

- `IsInterruptable` / `IsHitRigidity`: values decoded for every action class (`overview/action_flags.json`); what they do in game is read from the names only.
- `MobLastDamageRate*` (damage-cut buff parameters): consumed in `MobAttackBase.CalcLastDamage`; unit and stacking with other cuts not verified in game. GodHand `damageDownRate` by buff lv (7 -> 45, 8 -> 57, 9 -> 72, else 90) is as decoded and looks non-monotonic.
- Ichijhinnokaze: the mapping of the Thai names (ลมสงบนิ่ง ... สี่ฤดูกาล) to Nagi / Kariwatashi / Hibari / Ibuki / Arahae / Setsunakenran is by order (Inferred); the input pattern that sets `activeSkill = 3` (key sequence) is not decoded.
- Shift (1039) / ImprovisationSong (773): protection is applied by engine hooks that read the buff; durations and exact rules not decoded here.
- Skills with several name variants ([N2], [F][A][W]...) are listed by name only, except Ichijhinnokaze; the other variants are not split into their own formulas.
- Weapon scenarios use: main weapon in the skill's equip limit (or every weapon named in its conditions), sub weapon in {none, other, and the sub weapons named in its conditions}. Conditions that are not weapon tests stay as text.

## Residual markers left in the generated text (decoder output not yet readable)

- unresolved ?x/?v/?mi: 4 lines
- UnityEngine plumbing: 9 lines
- raw offset +0x..: 5 lines
