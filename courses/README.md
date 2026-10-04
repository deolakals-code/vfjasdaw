# Monthly courses (คอร์สรายเดือน)

Three subscription courses. Benefit list = the game's own text (System_th `OrbShop<platform>course<n>CourseInfo`,
identical on PC/iOS/Android), cross-checked against client code where the client applies the benefit itself.
Binary: S1 (`libil2cpp.so`, Android). Raw dumps: `D:\toram_re\course\course_all.txt`, `D:\toram_re\course_system_th.txt`.

## Benefits

| Benefit | course1 ขยายกระเป๋า (Bag Expansion) | course2 มาตรฐาน (Standard) | course3 เร่งเลเวล (Leveling) | Where applied |
|---|---|---|---|---|
| Equipment/tool bag slots | +25 | +15 | +10 | server (text only) |
| Monster EXP | – | +50% | +100% | server (text only); "own character only" |
| Drop rate | – | +10% | +30% | server (text only); "own character only" |
| Market listing fee | −10% | −20% | −30% | server (text only) |
| Material point cap | ×2 | – | – | **client code**, below |
| Daily special trophy | 10224: ชิ้นส่วนตั๋ว x5 | 10225: ชิ้นส่วนตั๋ว x10 | 10226: ชิ้นส่วนตั๋ว x15 | Trophy_th (daily trophy "ซื้อคอร์ส…") |

Any active course (all three) also gives, from client code:

| Benefit | Code |
|---|---|
| Special storage withdraw fee = `max(0, 5 − number of active courses)` % (5% → 4/3/2% with 1/2/3 courses) | `UISpecialStorageManager.GetStorageWithdrawFee` 0x1C86310 |
| Log out while the stall (Bazaar) stays open, instead of closing it | `UIBazaarOpen.OnLogOutButton` 0x1D1473C: `EntryCourseNum > 0 → LogOut` else `OnCloseBazaar` |
| My Room switch (saved layouts) usable | `UIHouseMyroomSwitchElement.SetData` 0x1B00490; text `MyroomSwitchAttentionMes` |
| New house address right away (no 72 h wait) | text `HouseAddressMessageDeleteAddressHint` (server check) |
| Mail list item counter hidden | `UIMiniMailManager.initializeMailList` 0x1B55A54 (`EntryCourseNum >= 1` disables `itemCountLabel`); what that means for mail limits is not visible client-side |

Event daily trophies that also require a course: 10230 (Halloween), 10233 (Christmas), 10103 (snowball).

## Code

| Item | Where | Behaviour |
|---|---|---|
| Course record | `CourseData` (TypeDefIndex 11140) | `{byte CourseType, int ItemId, DateTime LimitDate}` from the server (`OrbMonthlyCourse.Courses`, `OrbCourseUpdateResponse.UpdateCourses`) |
| Store state | enum `OrbManager.CourseState` | 0 None, 1 AccountHold (payment pending), 2 Paid |
| Active count | `OrbManager.get_EntryCourseNum` 0x2521D5C | store subscriptions with state Paid (key ≠ "free") + non-null entries of `gameCourseList` (item-activated courses) |
| One course active? | `OrbManager.CheckEntryCourse("course1")` 0x25250F0 | `gameCourseList` entry of that type, or store state Paid |
| Material cap | `ShopUtil.MaterialPointMax` 0x1D75784 | `(ParameterMaxSlot*3000 + 90000 + guild facility 6 bonus) * (2 if course1)` (`MaterialParamaterPointMax` 0x1D7572C: `ParameterMaxSlot * 0xBB8`; base 0x15F90) |

## Course items (ItemMaster, type 100 OrbConsumption)

| Id | Item | Id | Item | Id | Item |
|---|---|---|---|---|---|
| 1000219 | ขยายกระเป๋า 30 วัน | 1000220 | มาตรฐาน 30 วัน | 1000221 | เร่งเลเวล 30 วัน |
| 1000230 | ขยายกระเป๋า 15 วัน | 1000231 | มาตรฐาน 15 วัน | 1000232 | เร่งเลเวล 15 วัน |
| 1000227 | ขยายกระเป๋า 7 วัน | 1000228 | มาตรฐาน 7 วัน | 1000229 | เร่งเลเวล 7 วัน |
| 1000224 | ขยายกระเป๋า 3 วัน | 1000225 | มาตรฐาน 3 วัน | 1000226 | เร่งเลเวล 3 วัน |

The items carry no stats in ItemProperties: using one only registers the course on the server.
Store product ids: `com.asobimo.toramonline_course1..3`. Prices come from the store at runtime (not in client data).
