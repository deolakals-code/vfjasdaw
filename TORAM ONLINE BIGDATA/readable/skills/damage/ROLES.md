# Skills grouped by role

Roles are derived from the client code (see README, section "Roles"). A skill can appear in several groups.

## buff (self) (255)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 897 |  | NpcFirstAidAction | 28 | Special | `NpcFirstAidAction` | `FirstAidBuf`: FirstAidCost |
| 900 | <img src="../icons/sk_900.png" width="24"> | JudgmentOfTheDarkGodAction | 28 | Attack | `JudgmentOfTheDarkGodAction` | `JudgmentOfTheDarkGodBuf` 30s |
| 901 |  | WarProvokeAction | 28 | Buffer | `WarProvokeAction` | `WarProvokeBuf` 10s: Value |
| 993 | <img src="../icons/sk_993.png" width="24"> | แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ | アサシンスキル | Attack | `AssassinStubAction` | `AssassinStubBuf`: HitRate; `SkillBufferDataBase` |
| 994 | <img src="../icons/sk_994.png" width="24"> | อีเวชัน | アサシンスキル | Support | `EvolutionAction` | `EvolutionBuf` ((Lv + 20) + (Lv + 20))s: Flee, FleeRate; `SkillBufferDataBase` |
| 995 | <img src="../icons/sk_995.png" width="24"> | แบ็คสเต็ป | アサシンスキル | Special | `BackstepAction` | `BackstepBuf`: Value; `SkillBufferDataBase` |
| 996 | <img src="../icons/sk_996.png" width="24"> | เซียรัม | アサシンスキル | Support | `SierramAction` | `SierramBuf` ((Lv + 10) * 3)s: Value, Value2 |
| 997 | <img src="../icons/sk_997.png" width="24"> | ฟูเนวินเด | アサシンスキル | Attack | `FuneVinteAction` | `FuneVinteBuf`: AttackMprecoveryUp; `SkillBufferDataBase` |
| 999 | <img src="../icons/sk_999.png" width="24"> | ซิคาเรียส | アサシンスキル | Mastery | `Seekerius` | `SeekeriusBuf` 30s: AtkUp, PowerResistBreaker, Value, MobLastDamageRateBuf |
| 1000 | <img src="../icons/sk_1000.png" width="24"> | ชาโดว์วอล์ค | アサシンスキル | Buffer | `ShadowWalkAction` | `ShadowWalkBuf`; `CountBufferBase`: Count |
| 1001 | <img src="../icons/sk_1001.png" width="24"> | เวนอมอินเจค | アサシンスキル | Buffer | `VenomInjectAction` | `VenomInjectBuf`: Percent; `CountBufferBase`: Count |
| 1003 | <img src="../icons/sk_1003.png" width="24"> | เวนอมสแนทช | アサシンスキル | Attack | `VenomSnatchAction` | `VenomSnatchBuf`: Value; `CountBufferBase`: Count |
| 1006 | <img src="../icons/sk_1006.png" width="24"> | แอสเซาท์เชส | アサシンスキル | Buffer | `AssaultChaseAction` | `AssaultChaseBuf` 180s: Value, ShortRangeRate; `SkillBufferDataBase` |
| 1283 | <img src="../icons/sk_1283.png" width="24"> | Morning Star | AvatarSkill_1 | Attack | `MorningStarAction` | `MorningStarBuf`: MobLastDamageRateBuf; `SkillBufferDataBase` |
| 1284 | <img src="../icons/sk_1284.png" width="24"> | 1284 | AvatarSkill_1 | Buffer | `` | `DivaCheeringBuf` 10s: CspdUp, LastDmgUpRate, Aspd, AttackMprecoveryUp |
| 1089 | <img src="../icons/sk_1089.png" width="24"> | ความชำนาญการสู้มือเปล่า | ベアハンドスキル | Mastery | `BarehandMastery` | `TakeQigongBuf` 600s: Value, Count |
| 1090 | <img src="../icons/sk_1090.png" width="24"> | ชาร์จพลังชี่กง | ベアハンドスキル | Buffer | `CollectQigongAction` | `CollectQigongBuf` 180s: AtkUp, Stable, Count |
| 1091 | <img src="../icons/sk_1091.png" width="24"> | ซีซ่าแสลชเชอร์ | ベアハンドスキル | Buffer | `FuriousEffortsAction` | `FuriousEffortsBuf` 30s: NormalAttackRate, NormalAttackConstantDamage, Aspd, Count, CrtUp; `CountBufferBase`: Count |
| 1092 | <img src="../icons/sk_1092.png" width="24"> | วายุโหมคลื่นกระหน่ำ | ベアハンドスキル | Buffer | `StormAndUrgeAction` | `StormAndUrgeBuf` 30s: HitUp, Value, Aspd, AttackMprecoveryUp, Count |
| 1093 | <img src="../icons/sk_1093.png" width="24"> | ชี่กงฟื้นฟู | ベアハンドスキル | Buffer | `HealQigongAction` | `HealQigongBuf`: Percent, AtkUpRate, Count, MobLastDamageRateUnique; `CountBufferBase`: Count |
| 1095 | <img src="../icons/sk_1095.png" width="24"> | ซีซ่าแสลชเชอร์อัลติมา | ベアハンドスキル | Mastery | `FuriousEffortsExtreme` | `CountBufferBase`: Count; `FuriousEffortsExtremeBuf`: Value |
| 1096 | <img src="../icons/sk_1096.png" width="24"> | วายุโหมคลื่นกระหน่ำอัลติมา | ベアハンドスキル | Mastery | `StormAndUrgeExtreme` | `StormAndUrgeExtremeBuf`: Percent, PowerResistBreaker, Value |
| 1098 | <img src="../icons/sk_1098.png" width="24"> | สะเทือนโลกา | ベアハンドスキル | Buffer | `EarthShatteringAction` | `EarthShatteringBuf`: Percent, PowerResistBreaker, Value, Stable, Count; `EquipMagicBarrierBuf`: Value; `EquipPhysicalBarrierBuf`: Value; `SkillBuffer |
| 1099 | <img src="../icons/sk_1099.png" width="24"> | ฟื้นคืนชีพ | ベアハンドスキル | Mastery | `Revival` | `RevivalBuf` 900s; `CountBufferBase`: Count |
| 34 | <img src="../icons/sk_034.png" width="24"> | แอสทิวท์ | สกิลดาบ | Attack | `AstuteAction` | `AstuteBuf` (((Lv // 6) + ((Lv // 6) << 2)) + 5)s: CrtUp |
| 35 | <img src="../icons/sk_035.png" width="24"> | โซนิคเบรด | สกิลดาบ | Attack | `AccelBladeAction` | `AccelBladeBuf` times |
| 38 | <img src="../icons/sk_038.png" width="24"> | ทริกเกอร์สแลช | สกิลดาบ | Attack | `TriggerSlashAction` | `TriggerSlashBuf`: AttackMprecoveryUp, MotionSpeed |
| 39 | <img src="../icons/sk_039.png" width="24"> | สไปรัลแอร์ | สกิลดาบ | Attack | `SpiralAirAction` | `SpiralAirBuf` Lvs: CrtDamageUp |
| 41 | <img src="../icons/sk_041.png" width="24"> | รัมเพจ | สกิลดาบ | Buffer | `RampageAction` | `RampageBuf` 600s: Value, Value2; `CountBufferBase`: Count |
| 43 | <img src="../icons/sk_043.png" width="24"> | วอร์คราย | สกิลดาบ | Support | `WarCryAction` | `WarCryBuf` ((val & 255) eq 10 ? ((Lv + 15) + 50) : (Lv + 15))s: AtkUpRate |
| 45 | <img src="../icons/sk_045.png" width="24"> | บัสตาร์ดเบลด | สกิลดาบ | Attack | `BusterBladeAction` | `BusterBladeBuf` 10s: EqAtkUpRate |
| 46 | <img src="../icons/sk_046.png" width="24"> | เบอร์เซิร์ก | สกิลดาบ | Buffer | `BerserkAction` | `BerserkBuf` 10s: NormalAttackRate, Stable, AspdRate, Aspd, MdefRate, DefRate, CrtUp |
| 47 | <img src="../icons/sk_047.png" width="24"> | ฟาสต์แอคแทค | สกิลดาบ | Attack | `FastAttackAction` | `FastAttackBuf` |
| 49 | <img src="../icons/sk_049.png" width="24"> | ลูนาร์สแลช | สกิลดาบ | Attack | `MoonSlashAction` | `MoonSlashBuf`; `CountBufferBase`: Count |
| 50 | <img src="../icons/sk_050.png" width="24"> | ออร่าเบลด | สกิลดาบ | Attack | `AuraBladeAction` | `AuraBladeBuf` 40s: Value, PhysicalPursuitSkillRate; `SkillBufferDataBase` |
| 51 | <img src="../icons/sk_051.png" width="24"> | แกลดดีเอท | สกิลดาบ | Buffer | `GladiateAction` | `GladiateBuf`: MobLastDamageRateBuf; `CountBufferBase`: Count |
| 52 | <img src="../icons/sk_052.png" width="24"> | แฮมเมอร์สแลม | สกิลดาบ | Attack | `HammerDownAction` | `HammerDownBuf`; `SkillBufferDataBase` |
| 54 | <img src="../icons/sk_054.png" width="24"> | สตรอมเบลซ | สกิลดาบ | Attack | `StormBlazerAction` | `StormBlazerBuf`; `CountBufferBase`: Count |
| 55 | <img src="../icons/sk_055.png" width="24"> | การ์ดเบลด | สกิลดาบ | Buffer | `GuardyBladeAction` | `GuardyBladeBuf` 70s: PowerDmgCut, MagicDmgCut; `SkillBufferDataBase` |
| 56 | <img src="../icons/sk_056.png" width="24"> | ออร์คสแลช | สกิลดาบ | Attack | `OrgaslashAction` | `OrgaslashBuf`; `CountBufferBase`: Count |
| 1153 | <img src="../icons/sk_1153.png" width="24"> | กำปั้นผดุงคุณธรรม | クラッシャー | Attack | `ForefistPunchAction` | `ForefistPunchBuf`: Value |
| 1154 | <img src="../icons/sk_1154.png" width="24"> | วิธีการหายใจ | クラッシャー | Buffer | `BreathingMethodAction` |  |
| 1155 | <img src="../icons/sk_1155.png" width="24"> | กลอเรียเทคชอต | クラッシャー | Attack | `GoliathTakeShotAction` | `GoliathTakeShotBuf`: Value |
| 1158 | <img src="../icons/sk_1158.png" width="24"> | ก็อดแฮนด์ | クラッシャー | Attack | `GodHandAction` | `GodHandBuf` times: Value, AbnormalRegist, MobLastDamageRateBuf, MobLastDamageRateUnique |
| 1159 | <img src="../icons/sk_1159.png" width="24"> | ผู้ทำลายล้าง | クラッシャー | Buffer | `DestroyerAction` | `DestroyerBuf`: BaseEqAtkUpRate, Value, Stable; `SkillBufferDataBase` |
| 1160 | <img src="../icons/sk_1160.png" width="24"> | เทอราบลาสต์ | クラッシャー | Attack | `GeoImpactAction` | `GeoImpactBuf` 10s: Value; `CountBufferBase`: Count |
| 1162 | <img src="../icons/sk_1162.png" width="24"> | กีย์เซอร์ชู้ต | クラッシャー | Attack | `GazerShootAction` | `BreathingMethodBuf`: Value; `SkillBufferDataBase` |
| 801 | <img src="../icons/sk_801.png" width="24"> | การร่ายรำแห่งภูตพราย | ダンサー | Support | `FairyDanceAction` | `FairyDanceBuf` times: Value, Count |
| 802 | <img src="../icons/sk_802.png" width="24"> | การร่ายรำอันรุนแรง | ダンサー | Support | `PassionDanceAction` | `PassionDanceBuf` times: Value |
| 803 | <img src="../icons/sk_803.png" width="24"> | การร่ายรำให้กำลังใจ | ダンサー | Support | `SupportDanceAction` | `SupportDanceBuf` times |
| 804 | <img src="../icons/sk_804.png" width="24"> | การร่ายรำอันเฉียบคม | ダンサー | Support | `SharpDanceAction` | `SharpDanceBuf` times: Value |
| 805 | <img src="../icons/sk_805.png" width="24"> | ตั้งรับอย่างสง่างาม | ダンサー | Buffer | `ElegantStanceAction` | `ElegantStanceBuf`: MobLastDamageRateBuf, AbnormalAvoid; `SkillBufferDataBase` |
| 806 | <img src="../icons/sk_806.png" width="24"> | การร่ายรำอันทรงเสน่ห์ | ダンサー | Support | `EnchantedDanceAction` | `EnchantedDanceBuf` times: Value, Count |
| 807 | <img src="../icons/sk_807.png" width="24"> | วิจิตรธรรมชาติ | ダンサー | Attack | `BeautiesOfNatureAction` | `BeautiesOfNatureBuf`; `SkillBufferDataBase` |
| 1058 | <img src="../icons/sk_1058.png" width="24"> | แซครีไฟซ์ | ダークパワースキル | Special | `SacrificeAction` | `SoulHuntBuf`; `CountBufferBase`: Count |
| 1059 | <img src="../icons/sk_1059.png" width="24"> | ดาร์คสตริงเกอร์ | ダークパワースキル | Attack | `DarkStingerAction` | `SoulHuntBuf`; `DarkStingerBuf` 30s: MaxHpUpRate, Value; `CountBufferBase`: Count |
| 1061 | <img src="../icons/sk_1061.png" width="24"> | เรดเทีย | ダークパワースキル | Object | `RedTearAction` | `RedTearBuf` ((int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1) + 1)s |
| 1062 | <img src="../icons/sk_1062.png" width="24"> | รีเกรทเลส | ダークパワースキル | Buffer | `RegretAction` | `RegretBuf` 30s: MaxMpUp, MaxHpUpRate, MatkUp, AtkUp, Value, AttackMprecoveryUp, MagicDmgCut, PowerDmgCut |
| 1063 | <img src="../icons/sk_1063.png" width="24"> | โซลฮันเตอร์ / เดธรีปเปอร์ | ダークパワースキル | Attack | `SoulHuntAction` | `SoulHuntBuf`; `CountBufferBase`: Count |
| 1064 | <img src="../icons/sk_1064.png" width="24"> | อีเทอนอลไนท์แมร์ | ダークパワースキル | Object | `EternalNightmareAction` | `EternalNightmareBuf` (IsSelfAction eq 0 ? 3 : 300)s: MaxHpUpRate, TargetDefDown, TargetMdefDown, ReceiveLightElementDmgRate, ReceiveDarkElementDmgRat |
| 1067 | <img src="../icons/sk_1067.png" width="24"> | เนตรมารเพลิงทมิฬ | ダークパワースキル | Attack | `BlackFlameEvilEyeAction` | `BlackFlameEvilEyeBuf`; `SkillBufferDataBase` |
| 643 | <img src="../icons/sk_643.png" width="24"> | ครอสแพรี่ | デュアルスキル | Attack | `ParryingSwordAction` | `ParryingSwordBuf` 0s: AtkUpRate, PowerDmgCut, MagicDmgCut, AspdRate |
| 644 | <img src="../icons/sk_644.png" width="24"> | รีเฟล็กซ์ | デュアルスキル | Buffer | `StepReactorAction` | `StepReactorbuf` times: AvoidUp, MdefRate, DefRate |
| 649 | <img src="../icons/sk_649.png" width="24"> | แฟนทอมสแลช / แฟนทอมอิคลิพส์ | デュアルスキル | Attack | `PhantomRaveAction` | `DoubleThrowBuf` (30 - lv)s |
| 650 | <img src="../icons/sk_650.png" width="24"> | แฟลชบลาส | デュアルスキル | Buffer | `PhiloEclairAction` | `PhiloEclairBuf` 120s: EqAtkUpRate, FirstAttackRate, AvoidStack |
| 651 | <img src="../icons/sk_651.png" width="24"> | ชาโดว์สเต็ป | デュアルスキル | Attack | `WrapAroundAction` |  |
| 652 | <img src="../icons/sk_652.png" width="24"> | ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส | デュアルスキル | Attack | `ShiningClothAction` | `ShiningClothBuf` 9s |
| 653 | <img src="../icons/sk_653.png" width="24"> | สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ | デュアルスキル | Attack | `SturmLeaperAction` | `SturmLeaperBuf`: ShortRangeRate, LongRangeRate; `CountBufferBase`: Count |
| 654 | <img src="../icons/sk_654.png" width="24"> | เซเบอร์ออร่า | デュアルスキル | Buffer | `SaberAuraAction` | `SaberAuraBuf`: Count, HitUp, Value, AspdRate, AttackMprecoveryUp, CrtUp |
| 655 | <img src="../icons/sk_655.png" width="24"> | ลูนาดิธเธอร์สตาร์ | デュアルスキル | Attack | `LunaDitherStarAction` | `WrapAroundBuf`: CrtUpRate, AttackMprecoveryUp; `CountBufferBase`: Count |
| 656 | <img src="../icons/sk_656.png" width="24"> | ทวินบัสตาร์ดเบลด | デュアルスキル | Attack | `TwinBusterBladeAction` |  |
| 657 | <img src="../icons/sk_657.png" width="24"> | อาร์คเซเบอร์ | デュアルスキル | Buffer | `ArkSaberAction` | `ArkSaberBuf` ((count + (count << 1)) gt 10 ? (count + (count << 1)) : 10)s: Value, AttackMprecoveryUp, Count, CrtUp; `SkillBufferDataBase` |
| 659 | <img src="../icons/sk_659.png" width="24"> | เอเลียสลีย์ | デュアルスキル | Special | `ArialSlayAction` | `ArialSlayBuf` 5s: MobLastDamageRateBuf; `SkillBufferDataBase` |
| 660 | <img src="../icons/sk_660.png" width="24"> | ฮอร์ริซอนคัท | デュアルスキル | Attack | `HorizontalCutAction` | `HorizontalCutBuf` |
| 1251 | <img src="../icons/sk_1251.png" width="24"> | แม็กนั่ม | EventSkill | Attack | `MagnumAction` | `MagnumBuf`: Count, HitRate |
| 577 | <img src="../icons/sk_577.png" width="24"> | อัญเชิญโกเล็ม | ゴーレムスキル | Object | `CallGolemAction` | `CallGolemBuf` ((10 + ((((ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetP |
| 587 | <img src="../icons/sk_587.png" width="24"> | บาเรียสกรีน | ゴーレムスキル | Object | `BarrierScreenAction` | `BarrierScreenBuf`: AttackMprecoveryUpRate, Value; `SkillBufferDataBase` |
| 166 | <img src="../icons/sk_166.png" width="24"> | มิราจอีวาชั่น | GuardSkill | Mastery | `MirageStep` | `MirageStepBuf` (20 - lv)s |
| 963 | <img src="../icons/sk_963.png" width="24"> | เดดลี่สเปียร์ | ハルバードスキル | Attack | `DeadlySpearAction` | `DeadlySpearBuf` |
| 966 | <img src="../icons/sk_966.png" width="24"> | ดราก้อนเทล | ハルバードスキル | Attack | `DragonTailAction` | `DragonTailBuf`: MobLastDamageRateUnique; `SkillBufferDataBase` |
| 967 | <img src="../icons/sk_967.png" width="24"> | วานิชเรย์ | ハルバードスキル | Attack | `PunishRayAction` | `PunishRayBuf`: CrtUp; `CountBufferBase`: Count |
| 973 | <img src="../icons/sk_973.png" width="24"> | โครนอสไดรฟ์ | ハルバードスキル | Attack | `CronosDriveAction` | `CronosDriveBuf` (int((Lv eq 0 ? 0 : ((?ands - 1) * 0.5))) + 5)s |
| 974 | <img src="../icons/sk_974.png" width="24"> | เทพลมกรด | ハルバードスキル | Buffer | `HandlingerOfGodspeedAction` | `HandlingerOfGodspeedBuf` ((Lv << 1) + 10)s: AvoidUp, MaxMpUp, Value, Aspd, MagicDmgCut, PowerDmgCut, MotionSpeedRate |
| 976 | <img src="../icons/sk_976.png" width="24"> | ดราโกนิกชาร์จ | ハルバードスキル | Attack | `DragonicChargeAction` | `DragonicChargeBuf`: Count |
| 979 | <img src="../icons/sk_979.png" width="24"> | ทอร์นาโดแลนซ์ | ハルバードスキル | Mastery | `TornadoLanceMastary` | `TornadoLanceBuf` 100s: Percent, CrtDamageUp, Count, FleeRate |
| 980 | <img src="../icons/sk_980.png" width="24"> | บลิทซ์ไปก์ | ハルバードスキル | Object | `BlitzPikeAction` | `BlitzPikeBuf`: Value, Count; `SkillBufferDataBase` |
| 981 | <img src="../icons/sk_981.png" width="24"> | ไลท์นิ่งเฮล | ハルバードスキル | Object | `LightningHailAction` | `LightningHailBuf`: Count; `SkillBufferDataBase` |
| 982 | <img src="../icons/sk_982.png" width="24"> | ธอร์แฮมเมอร์ | ハルバードスキル | Object | `ThorHammerAction` | `ThorHammerBuf`: MagiclPursuitSkillRate, MagicResistBreaker, HitUp |
| 547 | <img src="../icons/sk_547.png" width="24"> | เมจิคแอร์โรว์ | ハンタースキル | Buffer | `ForceArrow` | `ForceArrowBuf`: EqAtkUpRate, AttackMprecoveryUp, NormalAttackConstantDamage; `CountBufferBase`: Count |
| 553 | <img src="../icons/sk_553.png" width="24"> | ดีเทคชั่น | ハンタースキル | Buffer | `DetectionAction` | `DetectionBuf` 40s: CrtUp |
| 558 | <img src="../icons/sk_558.png" width="24"> | มัลติเพิลฮันท์ / วูปสไนเปอร์ / สไนเปอร์วอลเลย์ / วันแฮนด์ช็อต / ชาร์ปชูตเตอร์ | ハンタースキル | Attack | `MultipleHuntAction` | `MultipleHuntBuf`: ShortRangeRate, MagicDmgCut, PowerDmgCut, CrtUp, MobLastDamageRateUnique |
| 559 | <img src="../icons/sk_559.png" width="24"> | แคมฟลาจ | ハンタースキル | Buffer | `CamouflageAction` | `CamouflageBuf`: AtkUp, CrtUp; `SkillBufferDataBase` |
| 561 | <img src="../icons/sk_561.png" width="24"> | โฟกัส | ハンタースキル | Attack | `FocusAction` | `FocusBuf`: LongRangeRate, ShortRangeRate; `SkillBufferDataBase` |
| 298 | <img src="../icons/sk_298.png" width="24"> | เมลเบรคเกอร์ | ナイフスキル | Mastery | `MailBreaker` | `MailBreakerBuf`: CrtUp, AttackMprecoveryUpRate |
| 299 | <img src="../icons/sk_299.png" width="24"> | ไนฟ์คอมแบท | ナイフスキル | Special | `KnifeCombatAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `SkillBufferDataBase` |
| 300 | <img src="../icons/sk_300.png" width="24"> | ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ | ナイフスキル | Attack | `FlinchKnifeAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `SkillBufferDataBase` |
| 301 | <img src="../icons/sk_301.png" width="24"> | เครซี่แดกเกอร์ | ナイフスキル | Object | `CrazyDaggerAction` | `CrazyDaggerBuf`: Count; `SkillBufferDataBase` |
| 302 | <img src="../icons/sk_302.png" width="24"> | วีลไบต์ | ナイフスキル | Attack | `WheelBiteAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `WheelBiteBuf`: MobLastDamageRateUnique; `SkillBufferDataBase` |
| 516 | <img src="../icons/sk_516.png" width="24"> | เรจซอร์ด | ナイトスキル | Attack | `RageSwordAction` | `RageSwordBuf` |
| 517 | <img src="../icons/sk_517.png" width="24"> | N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ | ナイトスキル | Buffer | `P_DeffenceAction` | `P_DeffenceActionBuf` 1s; `SkillBufferDataBase` |
| 519 | <img src="../icons/sk_519.png" width="24"> | ฟาเรส | ナイトスキル | Buffer | `FearlessAction` | `FearlessBuf` 240s: PowerResistBreaker, NormalAttackRate, Aspd, MobLastDamageRateBuf; `SkillBufferDataBase` |
| 521 | <img src="../icons/sk_521.png" width="24"> | ไนท์สแตนซ์ | ナイトスキル | Buffer | `KnightStanceAction` | `KnightStanceBuf` 360s: RateDamageResist, HateRate, Value; `CountBufferBase`: Count |
| 523 | <img src="../icons/sk_523.png" width="24"> | เรเวอเนีย | ナイトスキル | Attack | `LevenirAction` | `LevenirBuf`; `CountBufferBase`: Count |
| 525 | <img src="../icons/sk_525.png" width="24"> | อาฟเตอร์ชีลด์ | ナイトスキル | Mastery | `AfterShield` | `AfterShieldBuf`: MobLastDamageRateBuf; `SkillBufferDataBase` |
| 526 | <img src="../icons/sk_526.png" width="24"> | บลิงค์ซอร์ด | ナイトスキル | Attack | `BlinkSwordAction` | `BlinkSwordBuf` 3s: RateDamageResist; `SkillBufferDataBase` |
| 527 | <img src="../icons/sk_527.png" width="24"> | ไนท์เพลดจ์ | ナイトスキル | Object | `KnightPledgeAction` | `KnightPledgeBuf`: KnockbackDistReduceRate, Count, Value2, Value, MobLastDamageRateUnique, LastDamageRateDecimal |
| 866 | <img src="../icons/sk_866.png" width="24"> | อีเทอร์แฟลร์ | マジックブレードスキル | Attack | `EtherFlareAction` | `EtherFlareBuf` 20s: AttackMprecoveryUp; `SkillBufferDataBase` |
| 867 | <img src="../icons/sk_867.png" width="24"> | คอนเวอร์ชั่น | マジックブレードスキル | Mastery | `ConversionAction` | `ConversionBuf`; `SkillBufferDataBase` |
| 869 | <img src="../icons/sk_869.png" width="24"> | เรโซแนนซ์ | マジックブレードスキル | Buffer | `ResonanceAction` | `ResonanceBuf` 30s: AtkUp, MatkUp, HitUp, Aspd, CspdUp, CrtUp |
| 870 | <img src="../icons/sk_870.png" width="24"> | เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด | マジックブレードスキル | Attack | `EnchantedSwordAction` | `EnchantedSwordBuf` Lvs |
| 871 | <img src="../icons/sk_871.png" width="24"> | เอนชานท์สเปล | マジックブレードスキル | Extra | `EnchantedSpell` | `EnchantedSpellBuf` times |
| 872 | <img src="../icons/sk_872.png" width="24"> | เอนชานท์บลาส / เอนชานท์อกรา | マジックブレードスキル | Attack | `EnchantedBurstAction` | `EnchantedBurstBuf`: Count; `EnchantedBurstSwordBuf` (((stack & 255) * (stack & 255)) * (Lv + 4))s; `SkillBufferDataBase` |
| 873 | <img src="../icons/sk_873.png" width="24"> | ดูอัลบริงเกอร์ | マジックブレードスキル | Buffer | `DualBringerAction` | `DualBringerBuf` max((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function // 5), 10)s: MagicCrtDamage; `SkillBufferDataBase` |
| 874 | <img src="../icons/sk_874.png" width="24"> | ยูเนียนซอร์ด / รียูเนียนซอร์ด | マジックブレードスキル | Attack | `UnionSwordAction` | `UnionSwordBuf` |
| 875 | <img src="../icons/sk_875.png" width="24"> | เดรนบาเรีย | マジックブレードスキル | Buffer | `DrainBarrierAction` | `DrainBarrierBuf`: PowerDmgCut, MagicDmgCut; `EnchantedBurstBuf`: Count; `DrainRecallBuf` (Lv << 1)s: Value; `SkillBufferDataBase` |
| 877 | <img src="../icons/sk_877.png" width="24"> | เดรนรีคอล | マジックブレードスキル | Mastery | `DrainRecall` | `DrainRecallBuf` (Lv << 1)s: Value; `SkillBufferDataBase` |
| 878 | <img src="../icons/sk_878.png" width="24"> | โฟรทแดช | マジックブレードスキル | Buffer | `FloatDashAction` | `FloatDashBuf`: MoveSpeed, AvoidUp, Flee; `SkillBufferDataBase` |
| 879 | <img src="../icons/sk_879.png" width="24"> | เมจิกสกิน | マジックブレードスキル | Mastery | `MagicSkin` | `MagicSkinBuf` 120s; `SkillBufferDataBase` |
| 97 | <img src="../icons/sk_097.png" width="24"> | เวทมนตร์:แอร์โรว์ / ธนูไฟ / ธนูน้ำ / ธนูลม / ธนูดิน / ธนูแสง / ธนูมืด | マジックスキル | Object | `MagicArrowAction` |  |
| 101 | <img src="../icons/sk_101.png" width="24"> | ชาร์จ MP | マジックスキル | Buffer | `ChargingAction` | `ChargingBuf` |
| 104 | <img src="../icons/sk_104.png" width="24"> | เชนแคสต์ | マジックスキル | Mastery | `ChainCast` | `ChainCastBuf`: MotionSpeedRate; `ChainCastStackBuf`: Count, MotionSpeed, MatkUp, Value |
| 105 | <img src="../icons/sk_105.png" width="24"> | เวทมนตร์:อิมแพ็ค | マジックスキル | Attack | `MagicImpactAction` | `MagicImpactBuf` |
| 109 | <img src="../icons/sk_109.png" width="24"> | เวทมนตร์: บลาส / เฮลอินเฟรูโน่ / อีเทอนอลบลิซซาร์ด / ฟอร์สเทมเพสต์ / เทิร์นกราวิตี้ / พันนิชเมนท์ / อีคลิปส์ | マジックスキル | Attack | `MagicBurstAction` | `MagicBurstBuf`: Value; `CountBufferBase`: Count |
| 111 | <img src="../icons/sk_111.png" width="24"> | เวทมนตร์:อีเกล | マジックスキル | Buffer | `MagicEgelAction` | `MagicEgelBuf`; `CountBufferBase`: Count |
| 114 | <img src="../icons/sk_114.png" width="24"> | โครนอสชิฟท์ | マジックスキル | Special | `ChronosShiftAction` | `ChronosShiftBuf` 0s |
| 115 | <img src="../icons/sk_115.png" width="24"> | แรพพิดชาร์จ | マジックスキル | Mastery | `RapidCharge` | `RapidChargeBuf` (((((Lv << 2) + lv) << 1) hi 50 ? (((Lv << 2) + lv) << 1) : 50) - 10)s: MatkUp, MagicResistBreaker |
| 116 | <img src="../icons/sk_116.png" width="24"> | เอนชานท์บาเรีย | マジックスキル | Buffer | `MagicProtectionAction` | `MagicProtectionBuf`: MotionSpeed, MobLastDamageRateUnique, Value; `CountBufferBase`: Count |
| 118 | <img src="../icons/sk_118.png" width="24"> | คาดาร์เอเล็คซิโอ | マジックスキル | Buffer | `KadarElexioAction` | `CountBufferBase`: Count; `KadarElexioBuf`: MaxHpUpRate, Value2, Value, LastDmgUpRate |
| 120 | <img src="../icons/sk_120.png" width="24"> | เวทมนตร์:เรเซอร์ | マジックスキル | Attack | `MagicLazerAction` | `MagicLazerBuf` 10s: MagicResistBreaker |
| 141 | <img src="../icons/sk_141.png" width="24"> | รัช | マーシャルスキル | Attack | `RushAction` | `RushBuf` 10s: MotionSpeed |
| 142 | <img src="../icons/sk_142.png" width="24"> | จักรา | マーシャルスキル | Support | `ChakraAction` |  |
| 143 | <img src="../icons/sk_143.png" width="24"> | สไลด์ดิ้ง | マーシャルスキル | Special | `SlidingAction` | `SlidingBuf`: HitUp |
| 145 | <img src="../icons/sk_145.png" width="24"> | อาชูร่าออร่า | マーシャルスキル | Buffer | `AshuraAuraAction` | `AshuraAuraBuf`: SkillConstantDamage, NormalAttackConstantDamage, CrtUp, LastDmgUpRate; `CountBufferBase`: Count |
| 146 | <img src="../icons/sk_146.png" width="24"> | เฟลชบลิงค์ | マーシャルスキル | Attack | `FlashArtsAction` | `FlashArtsBuf`: ShortRangeRate, Count; `NextAttackBufferBase` |
| 147 | <img src="../icons/sk_147.png" width="24"> | เอเนอร์จี้คอนโทรล | マーシャルスキル | Buffer | `KakeiAction` | `ChakraBuf` ((Lv + 10) + 10)s: AttackMprecoveryUp, BaseDamageCut, MobLastDamageRateSupport; `KakeiBuf` (int((((Lv * Lv) * 60) / 100)) + 30)s: BaseEqAt |
| 148 | <img src="../icons/sk_148.png" width="24"> | แนบพิงภูเขา | マーシャルスキル | Attack | `ThieshankaiAction` | `ThieshankaiBuf` seconds: Count, Value, Value2 |
| 150 | <img src="../icons/sk_150.png" width="24"> | หมุนปัด / ขากงจักร | マーシャルスキル | Attack | `SenfutsuAction` | `SenfutsuBuf` seconds |
| 769 | <img src="../icons/sk_769.png" width="24"> | บทเพลงแห่งการเยียวยา | ミンストレル | Circle | `HealingSongAction` | `HealingSongBuf`: HpRecoveryRate, MpRecoveryRate, Value; `SongBufferBase` |
| 770 | <img src="../icons/sk_770.png" width="24"> | บทเพลงแห่งภูตพราย | ミンストレル | Circle | `FairySongAction` | `FairySongBuf`: FleeRate, HitRate, HitUp, Flee; `SongBufferBase` |
| 771 | <img src="../icons/sk_771.png" width="24"> | บทเพลงแห่งชีวิต | ミンストレル | Circle | `SongOfLifeAction` | `SongOfLifeBuf`: Count; `SongBufferBase` |
| 772 | <img src="../icons/sk_772.png" width="24"> | บทเพลงแห่งมายา | ミンストレル | Circle | `PhantomSongAction` | `PhantomSongBuf`: Value; `SongBufferBase` |
| 773 | <img src="../icons/sk_773.png" width="24"> | แอดลิบ | ミンストレル | Buffer | `ImprovisationSongAction` | `BeatBlastBuf`; `ImprovisationSongBuf` 1s: MobLastDamageRateUnique; `CountBufferBase`: Count; `SkillBufferDataBase`; `SongBufferBase` |
| 774 | <img src="../icons/sk_774.png" width="24"> | บทเพลงแห่งความเร่าร้อน | ミンストレル | Circle | `EnthusiasticSongAction` | `EnthusiasticSongBuf`: Value; `SongBufferBase` |
| 775 | <img src="../icons/sk_775.png" width="24"> | บทเพลงแห่งภูมิปัญญา | ミンストレル | Circle | `KnowledgeSongAction` | `KnowledgeSongBuf`: MobLastDamageRateSupport, Value; `SongBufferBase` |
| 611 | <img src="../icons/sk_611.png" width="24"> | พัลส์เบลด / สวิฟต์พัลส์เบลด | モノノフスキル | Attack | `WaveBladeAction` | `SwordMoveBuf`: Value |
| 614 | <img src="../icons/sk_614.png" width="24"> | ทริปเปิ้ลทรัสต์ | モノノフスキル | Attack | `ThreeStageThrustAction` | `ThreeStageThrustBuf`: SkillConstantDamage; `CountBufferBase`: Count |
| 615 | <img src="../icons/sk_615.png" width="24"> | มากาดาจิ | モノノフスキル | Special | `CutOffTheDisasterAction` | `HeavenlyStarBuf` 10s; `CutOffTheDisasterBuf`; `CountBufferBase`: Count |
| 616 | <img src="../icons/sk_616.png" width="24"> | เมเคียวชิซุย | モノノフスキル | Buffer | `ClearAndSereneAction` |  |
| 617 | <img src="../icons/sk_617.png" width="24"> | ฮัซโซฮัปปะ | モノノフスキル | Object | `HassohappaAction` | `SwordMoveBuf`: Value |
| 618 | <img src="../icons/sk_618.png" width="24"> | ซังเทเซตเท็ตสึ | モノノフスキル | Attack | `ZanteisettetsuAction` | `HeavenlyStarBuf` 10s; `ZanteisettetsuBuf`; `CountBufferBase`: Count |
| 619 | <img src="../icons/sk_619.png" width="24"> | ชูคุจิ | モノノフスキル | Mastery | `ShukuchiAction` | `ShukuchiBuf`: NormalAttackRate, Value |
| 620 | <img src="../icons/sk_620.png" width="24"> | เท็นริวรันเซ | モノノフスキル | Attack | `HeavenlyStarAction` | `HeavenlyStarBuf` 10s; `CountBufferBase`: Count |
| 621 | <img src="../icons/sk_621.png" width="24"> | การิวเท็นเซ | モノノフスキル | Attack | `FinishingTouchAction` | `FinishingTouchBuf`: Value, FirstAttackRate, AttackMprecoveryUp, Count, MobLastDamageRateBuf; `SkillBufferDataBase` |
| 622 | <img src="../icons/sk_622.png" width="24"> | ไคริกิรันชิน | モノノフスキル | Buffer | `WeirdnessOfGodAction` | `WeirdnessOfGodBuf` (int((Lv * 0.5)) + 5)s: AtkUp, NormalAttackRate, Value, AttackMprecoveryUp |
| 623 | <img src="../icons/sk_623.png" width="24"> | คมดาบมายา | モノノフスキル | Special | `RepelBladeAction` | `RepelBladeBuf`: HitRate, Value; `SwordMoveBuf`: Value |
| 624 | <img src="../icons/sk_624.png" width="24"> | คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ | モノノフスキル | Attack | `IllusionarySceneAction` | `IllusionarySceneBuf`: MobLastDamageRateBuf; `OkaranmanBuf`; `CountBufferBase`: Count; `SkillBufferDataBase` |
| 625 | <img src="../icons/sk_625.png" width="24"> | ชาโดว์เลสสแลช | モノノフスキル | Object | `ShadowlessSlashAction` | `ShadowlessSlashBuf` 1s: HitRate; `SwordMoveBuf`: Value |
| 627 | <img src="../icons/sk_627.png" width="24"> | ดอนท์เลส | モノノフスキル | Mastery | `Inflexibility` | `InflexibilityBuf` ((?sbfx - lv) + 12)s: HitUp, FirstAttackRate, BaseEqAtk, EqAtk, MotionSpeed |
| 628 | <img src="../icons/sk_628.png" width="24"> | ลมมงคล | モノノフスキル | Mastery | `Mizukaze` | `CountBufferBase`: Count; `MizukazeBuf` 30s: ShortRangeRate, CrtDmg, HitUp |
| 629 | <img src="../icons/sk_629.png" width="24"> | ลมกระโชก / ลมสงบนิ่ง[N3]ลมเหนือ[N4]ลมตะวันออก[N5]ลมตะวันตก[N6]ลมใต้[N7]สี่ฤดูกาล | モノノフスキル | Special | `IchijhinnokazeAction` | `IchijhinnokazeBuf`: BaseEqAtk, AtkUp, Percent, Value2, Value, AtkUpRate, Count; `CountBufferBase`: Count |
| 631 | <img src="../icons/sk_631.png" width="24"> | ลมกระโชกแรง | モノノフスキル | Mastery | `IchijhinnokazeAratame` | `ShukuchiBuf`: NormalAttackRate, Value |
| 1121 | <img src="../icons/sk_1121.png" width="24"> | เกรฟดิกเกอร์ | ネクロマンサースキル | Object | `GlaiveTiggerAction` | `GlaiveTiggerBuf`: Percent, Value, AbnormalRegist; `CountBufferBase`: Count |
| 1126 | <img src="../icons/sk_1126.png" width="24"> | บลัดสตีล | ネクロマンサースキル | Special | `BloodSteelAction` | `BloodSteelBuf` (((Lv << 1) + lv) << 2)s; `SkillBufferDataBase` |
| 1129 | <img src="../icons/sk_1129.png" width="24"> | เดนเจอร์เชค | ネクロマンサースキル | Attack | `DengerShakeAction` | `DengerShakeBuf`: MotionSpeed; `SkillBufferDataBase` |
| 1131 | <img src="../icons/sk_1131.png" width="24"> | ซัมมอนเดโมนิก | ネクロマンサースキル | Extra | `SummonDemonicAction` | `SummonDemonicBuf`: MaxHpUpRate, Value |
| 0 |  | NormalAttackAction |  |  | `NormalAttackAction` | `SamuraiArcheryBuf`: HitRate; `UnannouncedDestinationBuf` ((shortcut & 1) ne 0 ? ((12 - lv) + -2) : (12 - lv))s; `CountBufferBase`: Count; `ShukuchiBu |
| 7 |  | PhiloEclailAttackAction |  |  | `PhiloEclailAttackAction` |  |
| 9 |  | FirstAidAction |  |  | `FirstAidAction` | `FirstAidBuf`: FirstAidCost |
| 14 |  | SkillChargeAction |  |  | `SkillChargeAction` | `MagicCannonBuf`: Value, Count; `SlashReaperBuf`; `CountBufferBase`: Count |
| 17 |  | ComboRelfectionAction |  |  | `ComboRelfectionAction` |  |
| 95 |  | JumpbackShotPursuitAction |  |  | `JumpbackShotPursuitAction` | `JumpBackShotBuf` |
| 158 |  | MindimageSenjuSupportAction |  |  | `MindimageSenjuSupportAction` | `ChakraBuf` ((Lv + 10) + 10)s: AttackMprecoveryUp, BaseDamageCut, MobLastDamageRateSupport; `ClearAndSereneBuf` ((Lv << 1) + 10)s: CrtDamageUpRate, Md |
| 159 |  | MindimageSenjuAttackAction |  |  | `MindimageSenjuAttackAction` | `MindimageSenjuBuf` ((isMainKnuckle & 1) ne 0 ? ((20 - lv) + -10) : (20 - lv))s; `NemesisBuf` ((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))s: Co |
| 637 |  | IchijhinnokazeAttackAction |  |  | `IchijhinnokazeAttackAction` |  |
| 638 |  | TenjhoTengeMusouSwordAction |  |  | `TenjhoTengeMusouSwordAction` | `WeirdnessOfGodBuf` (int((Lv * 0.5)) + 5)s: AtkUp, NormalAttackRate, Value, AttackMprecoveryUp |
| 671 |  | LunaDitherStarBladeRainAction |  |  | `LunaDitherStarBladeRainAction` | `LunaDitherStarBladeRainBuf`; `LunaDitherStarBuf` ((hitCount + (hitCount << 1)) << 1)s; `SkillBufferDataBase` |
| 988 |  | BlitzPikePursuitAction |  |  | `BlitzPikePursuitAction` |  |
| 989 |  | GodSpearHandling3Action |  |  | `GodSpearHandling3Action` | `HandlingerOfGodspeedBuf` ((Lv << 1) + 10)s: AvoidUp, MaxMpUp, Value, Aspd, MagicDmgCut, PowerDmgCut, MotionSpeedRate |
| 990 |  | GodSpearHandling2Action |  |  | `GodSpearHandling2Action` | `HandlingerOfGodspeedBuf` ((Lv << 1) + 10)s: AvoidUp, MaxMpUp, Value, Aspd, MagicDmgCut, PowerDmgCut, MotionSpeedRate |
| 991 |  | GodSpearHandling1Action |  |  | `GodSpearHandling1Action` | `HandlingerOfGodspeedBuf` ((Lv << 1) + 10)s: AvoidUp, MaxMpUp, Value, Aspd, MagicDmgCut, PowerDmgCut, MotionSpeedRate |
| 1222 |  | ThunderStyleAction |  |  | `ThunderStyleAction` | `SwordMoveBuf`: Value |
| 1223 |  | WaterStyleAction |  |  | `WaterStyleAction` | `WaterStyleBuf` 3s: MobLastDamageRateSupport |
| 1224 |  | EarthStyleAction |  |  | `EarthStyleAction` | `EarthStyleBuf`: MobLastDamageRateBuf, Count; `SkillBufferDataBase` |
| 1225 |  | WindStyleAction |  |  | `WindStyleAction` | `WindStyleBuf` 20s: CrtUp, FirstAttackRate |
| 1226 |  | CloningTechniqueAction |  |  | `CloningTechniqueAction` | `CloningTechniqueBuf` 60s: MaxHpUpRate; `SkillBufferDataBase` |
| 673 | <img src="../icons/sk_673.png" width="24"> | Lบูมเมอแรง / เลเพจบูมเมอแรง | パルチザンスキル | Object | `L_BoomerangAction` | `BoomerangBuf` |
| 674 | <img src="../icons/sk_674.png" width="24"> | LบูมเมอแรงII / เลเพจบูมเมอแรงII | パルチザンスキル | Object | `L_Boomerang2Action` |  |
| 675 | <img src="../icons/sk_675.png" width="24"> | LบูมเมอแรงIII / เลเพจบูมเมอแรงIII | パルチザンスキル | Object | `L_Boomerang3Action` |  |
| 676 | <img src="../icons/sk_676.png" width="24"> | Nดราก้อนทูธ / นีโน่ดราก้อนทูธ | パルチザンスキル | Attack | `N_DragonToothAction` | `N_DragonToothBuf`: Value |
| 677 | <img src="../icons/sk_677.png" width="24"> | ฮีลลิ่งช็อต | パルチザンスキル | Special | `HealingShotAction` | `SoulHuntBuf`; `HealingShotBuf` times; `CountBufferBase`: Count |
| 678 | <img src="../icons/sk_678.png" width="24"> | ลับคมลูกศร | パルチザンスキル | Buffer | `ArrowSharpeningAction` | `ArrowSharpeningBuf`: PowerResistBreaker, CrtDamageUpRate, CrtUpRate, MotionSpeed; `SkillBufferDataBase` |
| 679 | <img src="../icons/sk_679.png" width="24"> | สัญชาตญาณการอยู่รอด | パルチザンスキル | Mastery | `` | `SurvivalInstinctBuf` 20s: MaxHpUp, MaxHpUpRate, RateDamageResist |
| 680 | <img src="../icons/sk_680.png" width="24"> | ค้ำจุนแนวหน้า | パルチザンスキル | Buffer | `MaintainingTheFrontAction` | `MaintainingTheFrontBuf`: Value, Percent, HateRate |
| 934 | <img src="../icons/sk_934.png" width="24"> | คริติคอลอัพ | ペット専用スキル | Buffer | `PetCriticalUp` | `PetCriticalUpBuf` 10s: CrtDmg |
| 940 | <img src="../icons/sk_940.png" width="24"> | กระตุ้นพลัง | ペット専用スキル | Buffer | `BraveUp` | `BraveUpBuf` 10s: Aspd, AtkUpRate, AtkUp, AspdRate |
| 941 | <img src="../icons/sk_941.png" width="24"> | ปฐมพยาบาล | ペット専用スキル | Special | `PetFirstAid` | `FirstAidBuf`: FirstAidCost |
| 942 | <img src="../icons/sk_942.png" width="24"> | เพิ่มกำลังใจ | ペット専用スキル | Buffer | `MindUp` | `MindUpBuf` 10s: CspdUpRate, MAtkUpRate, MatkUp, CspdUp |
| 948 | <img src="../icons/sk_948.png" width="24"> | เพิ่มแรงต้านทาน | ペット専用スキル | Buffer | `CutUp` | `CutUpBuf` 10s: PowerDmgCut, MagicDmgCut |
| 833 | <img src="../icons/sk_833.png" width="24"> | เบลส | PriestSkill | Support | `BlessAction` | `BlessBuf` times; `SkillBufferDataBase` |
| 835 | <img src="../icons/sk_835.png" width="24"> | กลอเรีย | PriestSkill | Support | `GloriaAction` | `GloriaBuf` 30s: DefRate, MdefRate, GuardRate; `SkillBufferDataBase` |
| 838 | <img src="../icons/sk_838.png" width="24"> | อีเธอร์บาเรีย | PriestSkill | Support | `EtherCoatAction` | `EtherCoatBuf` 5s: AbnormalRegist, MAtkUpRate; `SkillBufferDataBase` |
| 840 | <img src="../icons/sk_840.png" width="24"> | พรีเอล | PriestSkill | Support | `PriereAction` | `PriereBuf` ((Lv + 15) + 50)s: MAtkUpRate |
| 842 | <img src="../icons/sk_842.png" width="24"> | เอ็กซอร์ซิสต์ | PriestSkill | Attack | `ExorcismAction` | `ExorcismBuf` |
| 843 | <img src="../icons/sk_843.png" width="24"> | โฮลี่ไบเบิ้ล | PriestSkill | Buffer | `HolyBibleAction` | `HolyBibleBuf` 600s: Percent, ReceiveDarkElementDmgRate |
| 844 | <img src="../icons/sk_844.png" width="24"> | เนเมซิส | PriestSkill | Attack | `NemesisAction` | `NemesisBuf` ((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))s: Count; `CountBufferBase`: Count |
| 845 | <img src="../icons/sk_845.png" width="24"> | แอสพิสโซล | PriestSkill | Mastery | `AspisSeoul` | `AspisSeoulBuf` ((Lv << 1) + lv)s |
| 846 | <img src="../icons/sk_846.png" width="24"> | คำสอนศักดิ์สิทธิ์ | PriestSkill | Mastery | `SacredTeachings` | `CountBufferBase`: Count; `SacredTeachingsBuf`: Value2, Value |
| 847 | <img src="../icons/sk_847.png" width="24"> | โฮลี่เกรซ | PriestSkill | Support | `HolyGraceAction` | `HolyGraceBuf` ((Lv + (Lv << 2)) << 1)s; `HolyGraceNextSkillMpHalvingBuf` (((Lv << 2) + lv) << 1)s; `NextAttackBufferBase`; `SkillBufferDataBase` |
| 263 | <img src="../icons/sk_263.png" width="24"> | โพรเทคชั่น | シールドスキル | Support | `ProtectionAction` | `AegisBuf` (Lv * 60)s: MagicDmgCut, PowerDmgCut; `ProtectionBuf` (Lv * 60)s: PowerDmgCut, MagicDmgCut; `SkillBufferDataBase` |
| 264 | <img src="../icons/sk_264.png" width="24"> | อีจิส | シールドスキル | Support | `AegisAction` | `AegisBuf` (Lv * 60)s: MagicDmgCut, PowerDmgCut; `ProtectionBuf` (Lv * 60)s: PowerDmgCut, MagicDmgCut; `SkillBufferDataBase` |
| 265 | <img src="../icons/sk_265.png" width="24"> | การ์เดียน | シールドスキル | Support | `GuardianAction` | `GuardianBuf` (((System.Math.Max(0, (Lv - 5)) + lv) * 10) + 30)s: HateRate, Guard, AttackMprecoveryUp, MAtkUpRate, AtkUpRate, MobLastDamageRateSupport |
| 266 | <img src="../icons/sk_266.png" width="24"> | ชีลด์อัปเปอร์คัต | シールドスキル | Attack | `ShieldUpperAction` | `ShieldUpperBuf`: MobLastDamageRateUnique |
| 267 | <img src="../icons/sk_267.png" width="24"> | ดูอัลชีลด์ | シールドスキル | Buffer | `PairOfShieldsAction` | `PairOfShieldsBuf` (LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))s: NormalAttackRate, Hit |
| 269 | <img src="../icons/sk_269.png" width="24"> | บาลาเกรุง | シールドスキル | Object | `BeragelungAction` | `BeragelungBuf`: LastDmgUpRate, AttackMprecoveryUp; `SkillBufferDataBase` |
| 69 | <img src="../icons/sk_069.png" width="24"> | สเนคแอคแทค | สกิลยิง | Buffer | `HideAttackAction` | `HideAttackBuf` int((Lv * 1.5))s; `CountBufferBase`: Count |
| 71 | <img src="../icons/sk_071.png" width="24"> | พาราไลซิสช็อต | สกิลยิง | Attack | `ParalysisShotAction` | `ParalysisShotBuf` times: Stable |
| 73 | <img src="../icons/sk_073.png" width="24"> | สไนป์ | สกิลยิง | Attack | `SnipingAction` | `SnipingBuf`: CrtUp, Stable |
| 74 | <img src="../icons/sk_074.png" width="24"> | สโมคดัส | สกิลยิง | Attack | `SmokeDustAction` | `SmokeDustBuf` times: HitUp |
| 76 | <img src="../icons/sk_076.png" width="24"> | ครอสสเฟียร์ | สกิลยิง | Attack | `CrossFireAction` | `CrossFireBuf`: Value |
| 79 | <img src="../icons/sk_079.png" width="24"> | เดสทอลก์ช็อต | สกิลยิง | Attack | `DeathTorqueShotAction` | `DeathTorqueShotBuf`: HitRate, CrtUp; `SkillBufferDataBase` |
| 80 | <img src="../icons/sk_080.png" width="24"> | รีโทรเกรดชอท | สกิลยิง | Attack | `JumpbackShotAction` | `JumpbackShotProtectionBuf`; `SkillBufferDataBase`; `JumpBackShotBuf` |
| 82 | <img src="../icons/sk_082.png" width="24"> | ทวินสตอร์ม | สกิลยิง | Buffer | `TwinStormAction` | `TwinStormBuf`: NormalAttackRate, MoveSpeed, NormalAttackConstantDamage, Value, Stable, Aspd, LastDmgUpRate; `CountBufferBase`: Count |
| 85 | <img src="../icons/sk_085.png" width="24"> | ควิกโหลดเดอร์ | สกิลยิง | Buffer | `QuickLoaderAction` | `HideAttackBuf` int((Lv * 1.5))s; `QuickLoaderBuf` ((Lv * 0xfffffffa) + 120)s: MotionSpeed; `CountBufferBase`: Count |
| 86 | <img src="../icons/sk_086.png" width="24"> | เอเลเมนท์สตาร์ทเตอร์ | สกิลยิง | Mastery | `ElementReach` | `ElementReachBuf`; `SkillBufferDataBase` |
| 87 | <img src="../icons/sk_087.png" width="24"> | คู่หูนักล่า | สกิลยิง | Special | `HuntingOneAction` | `HuntingOneBuf` |
| 88 | <img src="../icons/sk_088.png" width="24"> | เจาะทะลุ | สกิลยิง | Attack | `PenetratorAction` | `PenetratorBuf`; `CountBufferBase`: Count |
| 89 | <img src="../icons/sk_089.png" width="24"> | ไวด์สเปรด | สกิลยิง | Object | `WideSpreadAction` | `WideSpreadBuf`: HitRate |
| 705 | <img src="../icons/sk_705.png" width="24"> | ออโต้ดีไวซ์ | スプライトスキル | Buffer | `AutoDeviceAction` | `AutoDeviceBuf` (0 + 60)s: Percent, Value; `SkillBufferDataBase` |
| 706 | <img src="../icons/sk_706.png" width="24"> | เอ็กเพรสเอด | スプライトスキル | Mastery | `RushAidMastery` | `RushAidBuf`: MobLastDamageRateBuf |
| 707 | <img src="../icons/sk_707.png" width="24"> | เคาน์เตอร์ฟอร์ส | スプライトスキル | Object | `CounterForceAction` | `CounterForceBuf` (30 + EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], CounterForceBuf.get_SkillId()))s; `Sk |
| 709 | <img src="../icons/sk_709.png" width="24"> | เอนฮานซ์ | スプライトスキル | Support | `EnhanceAction` | `EnhanceBuf` ((Lv * 10) + 20)s: AtkUp, MatkUp, LastDmgUpRate; `SkillBufferDataBase` |
| 710 | <img src="../icons/sk_710.png" width="24"> | แอสเทิลแลนซ์ | スプライトスキル | Special | `AstralLanceAction` | `AstralLanceBuf` (90 + EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], AstralLanceBuf.get_SkillId()))s: Count |
| 712 | <img src="../icons/sk_712.png" width="24"> | สเตบิไลซ์ | スプライトスキル | Support | `StabilisAction` | `StabilisBuf` (0 + 45)s: Value, CrtUpRate, Count, CrtUp |
| 713 | <img src="../icons/sk_713.png" width="24"> | สไปรท์ชีลด์ | スプライトスキル | Buffer | `SpriteShieldAction` | `SoulHuntBuf`; `SpriteShieldBuf`: Value, MobLastDamageRateSupport; `CountBufferBase`: Count |
| 714 | <img src="../icons/sk_714.png" width="24"> | เมจิกวัลแคน | スプライトスキル | Object | `MagicBalkanAction` | `MagicBalkanBuf`; `SkillBufferDataBase` |
| 717 | <img src="../icons/sk_717.png" width="24"> | แฟกทิสอาร์ม | スプライトスキル | Attack | `FacticeArmeAction` | `SkillBufferDataBase` |
| 720 | <img src="../icons/sk_720.png" width="24"> | รีเทค | スプライトスキル | Mastery | `Retake` | `RetakeBuf` ((Lv + 2) * Lv)s |
| 722 | <img src="../icons/sk_722.png" width="24"> | เลเบนส์กลานซ์ | スプライトスキル | Attack | `LebenGlanzAction` | `LebenGlanzBuf`: AttackMprecoveryUp; `SkillBufferDataBase` |
| 226 | <img src="../icons/sk_226.png" width="24"> | ไลฟ์รีคัฟเวอรี่ | サポートスキル | Circle | `LifeRecoveryAction` | `LifeRecoveryBuf`: MobLastDamageRateBuf, HpRecoveryUp; `CircleBufferBase` 900s |
| 227 | <img src="../icons/sk_227.png" width="24"> | มานารีชาร์จ | サポートスキル | Circle | `ManaRechargeAction` | `ManaRechargeBuf`: LastDmgDownRate, MpRecoveryUp; `CircleBufferBase` 900s |
| 229 | <img src="../icons/sk_229.png" width="24"> | เบรฟออร่า | サポートスキル | Circle | `BraveAuraAction` | `BraveAuraBuf`: LastDmgUpRate, EqAtkUpRate, HitRate |
| 230 | <img src="../icons/sk_230.png" width="24"> | เมจิกบาเรีย | サポートスキル | Circle | `MagicBarrierAction` | `MagicBarrierBuf`: MdefRate, DefRate, FleeRate, MobLastDamageRateSupport |
| 231 | <img src="../icons/sk_231.png" width="24"> | รีคัฟเวอรี่ | サポートスキル | Heal | `RecoveryAction` | `RecoveryBuf`: Value |
| 232 | <img src="../icons/sk_232.png" width="24"> | ไฮไซเคิล | サポートスキル | Circle | `HighCycleAction` | `HighCycleBuf`: CspdUpRate, MpRecoveryUp, AttackMprecoveryUpRate, CspdUp |
| 233 | <img src="../icons/sk_233.png" width="24"> | อิมมูนิตี้ | サポートスキル | Circle | `DiseasetSealAction` | `DiseasetSealBuf`: AbnormalRegist, AspdRate |
| 234 | <img src="../icons/sk_234.png" width="24"> | แซงจูรี่ | サポートスキル | Object | `SanctuaryAction` | `SanctuaryBuf` 2s: LimitRegistDamage, MobLastDamageRateUnique |
| 235 | <img src="../icons/sk_235.png" width="24"> | ควิกโมชั่น | サポートスキル | Circle | `QuickMotionAction` | `QuickMotionBuf`: AspdRate, Aspd, AttackMprecoveryUpRate |
| 236 | <img src="../icons/sk_236.png" width="24"> | ฟาสต์รีเอคชั่น | サポートスキル | Circle | `HighReactionAction` | `HighReactionBuf`: Guard, AvoidUp, CspdUpRate |
| 1025 | <img src="../icons/sk_1025.png" width="24"> | แฟมิเรีย | ウィザードスキル | Special | `FamiliaAction` | `FamiliaBuf`: Value, MatkUp, MaxMpUp |
| 1026 | <img src="../icons/sk_1026.png" width="24"> | มานาคริสตัล | ウィザードスキル | Support | `ManaCrystalAction` | `ManaCrystalBuf`: Count |
| 1030 | <img src="../icons/sk_1030.png" width="24"> | สโตนสกิล | ウィザードスキル | Support | `StoneSkinAction` | `StoneSkinBuf` times: Value |
| 1031 | <img src="../icons/sk_1031.png" width="24"> | อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์ | ウィザードスキル | Attack | `ImperialRayAction` | `ImperialRayBuf` |
| 1032 | <img src="../icons/sk_1032.png" width="24"> | ไฮแฟมิเรีย | ウィザードスキル | Special | `HighFamiliaAction` | `HighFamiliaBuf`: Value, MatkUp, MaxMpUp |
| 1035 | <img src="../icons/sk_1035.png" width="24"> | โอเวอร์ลิมิต | ウィザードスキル | Buffer | `OverLimitAction` | `OverLimitBuf`: CspdUp, Value |
| 1039 | <img src="../icons/sk_1039.png" width="24"> | ชิฟท์ | ウィザードスキル | Buffer | `ShiftAction` | `ShiftBuf`; `ShiftMotionSpeedBuf` min((buf.LeftTime + ((int((((Lv * Lv) / 5) + 0.5)) + 10) * count)), 60)s: MotionSpeed; `CountBufferBase`: Count |

## buff (party / others) (26)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 994 | <img src="../icons/sk_994.png" width="24"> | อีเวชัน | アサシンスキル | Support | `EvolutionAction` | `EvolutionBuf` ((Lv + 20) + (Lv + 20))s: Flee, FleeRate; `SkillBufferDataBase` |
| 996 | <img src="../icons/sk_996.png" width="24"> | เซียรัม | アサシンスキル | Support | `SierramAction` | `SierramBuf` ((Lv + 10) * 3)s: Value, Value2 |
| 43 | <img src="../icons/sk_043.png" width="24"> | วอร์คราย | สกิลดาบ | Support | `WarCryAction` | `WarCryBuf` ((val & 255) eq 10 ? ((Lv + 15) + 50) : (Lv + 15))s: AtkUpRate |
| 801 | <img src="../icons/sk_801.png" width="24"> | การร่ายรำแห่งภูตพราย | ダンサー | Support | `FairyDanceAction` | `FairyDanceBuf` times: Value, Count |
| 802 | <img src="../icons/sk_802.png" width="24"> | การร่ายรำอันรุนแรง | ダンサー | Support | `PassionDanceAction` | `PassionDanceBuf` times: Value |
| 803 | <img src="../icons/sk_803.png" width="24"> | การร่ายรำให้กำลังใจ | ダンサー | Support | `SupportDanceAction` | `SupportDanceBuf` times |
| 804 | <img src="../icons/sk_804.png" width="24"> | การร่ายรำอันเฉียบคม | ダンサー | Support | `SharpDanceAction` | `SharpDanceBuf` times: Value |
| 806 | <img src="../icons/sk_806.png" width="24"> | การร่ายรำอันทรงเสน่ห์ | ダンサー | Support | `EnchantedDanceAction` | `EnchantedDanceBuf` times: Value, Count |
| 644 | <img src="../icons/sk_644.png" width="24"> | รีเฟล็กซ์ | デュアルスキル | Buffer | `StepReactorAction` | `StepReactorbuf` times: AvoidUp, MdefRate, DefRate |
| 650 | <img src="../icons/sk_650.png" width="24"> | แฟลชบลาส | デュアルスキル | Buffer | `PhiloEclairAction` | `PhiloEclairBuf` 120s: EqAtkUpRate, FirstAttackRate, AvoidStack |
| 965 | <img src="../icons/sk_965.png" width="24"> | ควิกออร่า | ハルバードスキル | Buffer | `QuickAuraAction` |  |
| 561 | <img src="../icons/sk_561.png" width="24"> | โฟกัส | ハンタースキル | Attack | `FocusAction` | `FocusBuf`: LongRangeRate, ShortRangeRate; `SkillBufferDataBase` |
| 875 | <img src="../icons/sk_875.png" width="24"> | เดรนบาเรีย | マジックブレードスキル | Buffer | `DrainBarrierAction` | `DrainBarrierBuf`: PowerDmgCut, MagicDmgCut; `EnchantedBurstBuf`: Count; `DrainRecallBuf` (Lv << 1)s: Value; `SkillBufferDataBase` |
| 146 | <img src="../icons/sk_146.png" width="24"> | เฟลชบลิงค์ | マーシャルスキル | Attack | `FlashArtsAction` | `FlashArtsBuf`: ShortRangeRate, Count; `NextAttackBufferBase` |
| 158 |  | MindimageSenjuSupportAction |  |  | `MindimageSenjuSupportAction` | `ChakraBuf` ((Lv + 10) + 10)s: AttackMprecoveryUp, BaseDamageCut, MobLastDamageRateSupport; `ClearAndSereneBuf` ((Lv << 1) + 10)s: CrtDamageUpRate, Md |
| 934 | <img src="../icons/sk_934.png" width="24"> | คริติคอลอัพ | ペット専用スキル | Buffer | `PetCriticalUp` | `PetCriticalUpBuf` 10s: CrtDmg |
| 940 | <img src="../icons/sk_940.png" width="24"> | กระตุ้นพลัง | ペット専用スキル | Buffer | `BraveUp` | `BraveUpBuf` 10s: Aspd, AtkUpRate, AtkUp, AspdRate |
| 942 | <img src="../icons/sk_942.png" width="24"> | เพิ่มกำลังใจ | ペット専用スキル | Buffer | `MindUp` | `MindUpBuf` 10s: CspdUpRate, MAtkUpRate, MatkUp, CspdUp |
| 948 | <img src="../icons/sk_948.png" width="24"> | เพิ่มแรงต้านทาน | ペット専用スキル | Buffer | `CutUp` | `CutUpBuf` 10s: PowerDmgCut, MagicDmgCut |
| 833 | <img src="../icons/sk_833.png" width="24"> | เบลส | PriestSkill | Support | `BlessAction` | `BlessBuf` times; `SkillBufferDataBase` |
| 835 | <img src="../icons/sk_835.png" width="24"> | กลอเรีย | PriestSkill | Support | `GloriaAction` | `GloriaBuf` 30s: DefRate, MdefRate, GuardRate; `SkillBufferDataBase` |
| 838 | <img src="../icons/sk_838.png" width="24"> | อีเธอร์บาเรีย | PriestSkill | Support | `EtherCoatAction` | `EtherCoatBuf` 5s: AbnormalRegist, MAtkUpRate; `SkillBufferDataBase` |
| 840 | <img src="../icons/sk_840.png" width="24"> | พรีเอล | PriestSkill | Support | `PriereAction` | `PriereBuf` ((Lv + 15) + 50)s: MAtkUpRate |
| 263 | <img src="../icons/sk_263.png" width="24"> | โพรเทคชั่น | シールドスキル | Support | `ProtectionAction` | `AegisBuf` (Lv * 60)s: MagicDmgCut, PowerDmgCut; `ProtectionBuf` (Lv * 60)s: PowerDmgCut, MagicDmgCut; `SkillBufferDataBase` |
| 264 | <img src="../icons/sk_264.png" width="24"> | อีจิส | シールドスキル | Support | `AegisAction` | `AegisBuf` (Lv * 60)s: MagicDmgCut, PowerDmgCut; `ProtectionBuf` (Lv * 60)s: PowerDmgCut, MagicDmgCut; `SkillBufferDataBase` |
| 709 | <img src="../icons/sk_709.png" width="24"> | เอนฮานซ์ | スプライトスキル | Support | `EnhanceAction` | `EnhanceBuf` ((Lv * 10) + 20)s: AtkUp, MatkUp, LastDmgUpRate; `SkillBufferDataBase` |

## changes attack pattern (13)

_Heuristic: the buff class exposes a motion/combo hook. Check in game._

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 299 | <img src="../icons/sk_299.png" width="24"> | ไนฟ์คอมแบท | ナイフスキル | Special | `KnifeCombatAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `SkillBufferDataBase` |
| 300 | <img src="../icons/sk_300.png" width="24"> | ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ | ナイフスキル | Attack | `FlinchKnifeAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `SkillBufferDataBase` |
| 302 | <img src="../icons/sk_302.png" width="24"> | วีลไบต์ | ナイフスキル | Attack | `WheelBiteAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `WheelBiteBuf`: MobLastDamageRateUnique; `SkillBufferDataBase` |
| 145 | <img src="../icons/sk_145.png" width="24"> | อาชูร่าออร่า | マーシャルスキル | Buffer | `AshuraAuraAction` | `AshuraAuraBuf`: SkillConstantDamage, NormalAttackConstantDamage, CrtUp, LastDmgUpRate; `CountBufferBase`: Count |
| 615 | <img src="../icons/sk_615.png" width="24"> | มากาดาจิ | モノノフスキル | Special | `CutOffTheDisasterAction` | `HeavenlyStarBuf` 10s; `CutOffTheDisasterBuf`; `CountBufferBase`: Count |
| 618 | <img src="../icons/sk_618.png" width="24"> | ซังเทเซตเท็ตสึ | モノノフスキル | Attack | `ZanteisettetsuAction` | `HeavenlyStarBuf` 10s; `ZanteisettetsuBuf`; `CountBufferBase`: Count |
| 620 | <img src="../icons/sk_620.png" width="24"> | เท็นริวรันเซ | モノノフスキル | Attack | `HeavenlyStarAction` | `HeavenlyStarBuf` 10s; `CountBufferBase`: Count |
| 1126 | <img src="../icons/sk_1126.png" width="24"> | บลัดสตีล | ネクロマンサースキル | Special | `BloodSteelAction` | `BloodSteelBuf` (((Lv << 1) + lv) << 2)s; `SkillBufferDataBase` |
| 159 |  | MindimageSenjuAttackAction |  |  | `MindimageSenjuAttackAction` | `MindimageSenjuBuf` ((isMainKnuckle & 1) ne 0 ? ((20 - lv) + -10) : (20 - lv))s; `NemesisBuf` ((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))s: Co |
| 844 | <img src="../icons/sk_844.png" width="24"> | เนเมซิส | PriestSkill | Attack | `NemesisAction` | `NemesisBuf` ((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))s: Count; `CountBufferBase`: Count |
| 267 | <img src="../icons/sk_267.png" width="24"> | ดูอัลชีลด์ | シールドスキル | Buffer | `PairOfShieldsAction` | `PairOfShieldsBuf` (LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))s: NormalAttackRate, Hit |
| 82 | <img src="../icons/sk_082.png" width="24"> | ทวินสตอร์ม | สกิลยิง | Buffer | `TwinStormAction` | `TwinStormBuf`: NormalAttackRate, MoveSpeed, NormalAttackConstantDamage, Value, Stable, Aspd, LastDmgUpRate; `CountBufferBase`: Count |
| 709 | <img src="../icons/sk_709.png" width="24"> | เอนฮานซ์ | スプライトスキル | Support | `EnhanceAction` | `EnhanceBuf` ((Lv * 10) + 20)s: AtkUp, MatkUp, LastDmgUpRate; `SkillBufferDataBase` |

## modifies normal-attack behaviour (20)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 1001 | <img src="../icons/sk_1001.png" width="24"> | เวนอมอินเจค | アサシンスキル | Buffer | `VenomInjectAction` | `VenomInjectBuf`: Percent; `CountBufferBase`: Count |
| 56 | <img src="../icons/sk_056.png" width="24"> | ออร์คสแลช | สกิลดาบ | Attack | `OrgaslashAction` | `OrgaslashBuf`; `CountBufferBase`: Count |
| 301 | <img src="../icons/sk_301.png" width="24"> | เครซี่แดกเกอร์ | ナイフスキル | Object | `CrazyDaggerAction` | `CrazyDaggerBuf`: Count; `SkillBufferDataBase` |
| 111 | <img src="../icons/sk_111.png" width="24"> | เวทมนตร์:อีเกล | マジックスキル | Buffer | `MagicEgelAction` | `MagicEgelBuf`; `CountBufferBase`: Count |
| 118 | <img src="../icons/sk_118.png" width="24"> | คาดาร์เอเล็คซิโอ | マジックスキル | Buffer | `KadarElexioAction` | `CountBufferBase`: Count; `KadarElexioBuf`: MaxHpUpRate, Value2, Value, LastDmgUpRate |
| 611 | <img src="../icons/sk_611.png" width="24"> | พัลส์เบลด / สวิฟต์พัลส์เบลด | モノノフスキル | Attack | `WaveBladeAction` | `SwordMoveBuf`: Value |
| 615 | <img src="../icons/sk_615.png" width="24"> | มากาดาจิ | モノノフスキル | Special | `CutOffTheDisasterAction` | `HeavenlyStarBuf` 10s; `CutOffTheDisasterBuf`; `CountBufferBase`: Count |
| 617 | <img src="../icons/sk_617.png" width="24"> | ฮัซโซฮัปปะ | モノノフスキル | Object | `HassohappaAction` | `SwordMoveBuf`: Value |
| 618 | <img src="../icons/sk_618.png" width="24"> | ซังเทเซตเท็ตสึ | モノノフスキル | Attack | `ZanteisettetsuAction` | `HeavenlyStarBuf` 10s; `ZanteisettetsuBuf`; `CountBufferBase`: Count |
| 619 | <img src="../icons/sk_619.png" width="24"> | ชูคุจิ | モノノフスキル | Mastery | `ShukuchiAction` | `ShukuchiBuf`: NormalAttackRate, Value |
| 620 | <img src="../icons/sk_620.png" width="24"> | เท็นริวรันเซ | モノノフスキル | Attack | `HeavenlyStarAction` | `HeavenlyStarBuf` 10s; `CountBufferBase`: Count |
| 623 | <img src="../icons/sk_623.png" width="24"> | คมดาบมายา | モノノフスキル | Special | `RepelBladeAction` | `RepelBladeBuf`: HitRate, Value; `SwordMoveBuf`: Value |
| 625 | <img src="../icons/sk_625.png" width="24"> | ชาโดว์เลสสแลช | モノノフスキル | Object | `ShadowlessSlashAction` | `ShadowlessSlashBuf` 1s: HitRate; `SwordMoveBuf`: Value |
| 629 | <img src="../icons/sk_629.png" width="24"> | ลมกระโชก / ลมสงบนิ่ง[N3]ลมเหนือ[N4]ลมตะวันออก[N5]ลมตะวันตก[N6]ลมใต้[N7]สี่ฤดูกาล | モノノフスキル | Special | `IchijhinnokazeAction` | `IchijhinnokazeBuf`: BaseEqAtk, AtkUp, Percent, Value2, Value, AtkUpRate, Count; `CountBufferBase`: Count |
| 631 | <img src="../icons/sk_631.png" width="24"> | ลมกระโชกแรง | モノノフスキル | Mastery | `IchijhinnokazeAratame` | `ShukuchiBuf`: NormalAttackRate, Value |
| 1126 | <img src="../icons/sk_1126.png" width="24"> | บลัดสตีล | ネクロマンサースキル | Special | `BloodSteelAction` | `BloodSteelBuf` (((Lv << 1) + lv) << 2)s; `SkillBufferDataBase` |
| 0 |  | NormalAttackAction |  |  | `NormalAttackAction` | `SamuraiArcheryBuf`: HitRate; `UnannouncedDestinationBuf` ((shortcut & 1) ne 0 ? ((12 - lv) + -2) : (12 - lv))s; `CountBufferBase`: Count; `ShukuchiBu |
| 1222 |  | ThunderStyleAction |  |  | `ThunderStyleAction` | `SwordMoveBuf`: Value |
| 845 | <img src="../icons/sk_845.png" width="24"> | แอสพิสโซล | PriestSkill | Mastery | `AspisSeoul` | `AspisSeoulBuf` ((Lv << 1) + lv)s |
| 82 | <img src="../icons/sk_082.png" width="24"> | ทวินสตอร์ม | สกิลยิง | Buffer | `TwinStormAction` | `TwinStormBuf`: NormalAttackRate, MoveSpeed, NormalAttackConstantDamage, Value, Stable, Aspd, LastDmgUpRate; `CountBufferBase`: Count |

## boosts normal-attack damage (15)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 1091 | <img src="../icons/sk_1091.png" width="24"> | ซีซ่าแสลชเชอร์ | ベアハンドスキル | Buffer | `FuriousEffortsAction` | `FuriousEffortsBuf` 30s: NormalAttackRate, NormalAttackConstantDamage, Aspd, Count, CrtUp; `CountBufferBase`: Count |
| 46 | <img src="../icons/sk_046.png" width="24"> | เบอร์เซิร์ก | สกิลดาบ | Buffer | `BerserkAction` | `BerserkBuf` 10s: NormalAttackRate, Stable, AspdRate, Aspd, MdefRate, DefRate, CrtUp |
| 547 | <img src="../icons/sk_547.png" width="24"> | เมจิคแอร์โรว์ | ハンタースキル | Buffer | `ForceArrow` | `ForceArrowBuf`: EqAtkUpRate, AttackMprecoveryUp, NormalAttackConstantDamage; `CountBufferBase`: Count |
| 299 | <img src="../icons/sk_299.png" width="24"> | ไนฟ์คอมแบท | ナイフスキル | Special | `KnifeCombatAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `SkillBufferDataBase` |
| 300 | <img src="../icons/sk_300.png" width="24"> | ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ | ナイフスキル | Attack | `FlinchKnifeAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `SkillBufferDataBase` |
| 302 | <img src="../icons/sk_302.png" width="24"> | วีลไบต์ | ナイフスキル | Attack | `WheelBiteAction` | `KnifeCombatBuf`: NormalAttackRate, Value, AttackMprecoveryUp, CrtUp; `WheelBiteBuf`: MobLastDamageRateUnique; `SkillBufferDataBase` |
| 519 | <img src="../icons/sk_519.png" width="24"> | ฟาเรส | ナイトスキル | Buffer | `FearlessAction` | `FearlessBuf` 240s: PowerResistBreaker, NormalAttackRate, Aspd, MobLastDamageRateBuf; `SkillBufferDataBase` |
| 145 | <img src="../icons/sk_145.png" width="24"> | อาชูร่าออร่า | マーシャルスキル | Buffer | `AshuraAuraAction` | `AshuraAuraBuf`: SkillConstantDamage, NormalAttackConstantDamage, CrtUp, LastDmgUpRate; `CountBufferBase`: Count |
| 619 | <img src="../icons/sk_619.png" width="24"> | ชูคุจิ | モノノフスキル | Mastery | `ShukuchiAction` | `ShukuchiBuf`: NormalAttackRate, Value |
| 622 | <img src="../icons/sk_622.png" width="24"> | ไคริกิรันชิน | モノノフスキル | Buffer | `WeirdnessOfGodAction` | `WeirdnessOfGodBuf` (int((Lv * 0.5)) + 5)s: AtkUp, NormalAttackRate, Value, AttackMprecoveryUp |
| 631 | <img src="../icons/sk_631.png" width="24"> | ลมกระโชกแรง | モノノフスキル | Mastery | `IchijhinnokazeAratame` | `ShukuchiBuf`: NormalAttackRate, Value |
| 0 |  | NormalAttackAction |  |  | `NormalAttackAction` | `SamuraiArcheryBuf`: HitRate; `UnannouncedDestinationBuf` ((shortcut & 1) ne 0 ? ((12 - lv) + -2) : (12 - lv))s; `CountBufferBase`: Count; `ShukuchiBu |
| 638 |  | TenjhoTengeMusouSwordAction |  |  | `TenjhoTengeMusouSwordAction` | `WeirdnessOfGodBuf` (int((Lv * 0.5)) + 5)s: AtkUp, NormalAttackRate, Value, AttackMprecoveryUp |
| 267 | <img src="../icons/sk_267.png" width="24"> | ดูอัลชีลด์ | シールドスキル | Buffer | `PairOfShieldsAction` | `PairOfShieldsBuf` (LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))s: NormalAttackRate, Hit |
| 82 | <img src="../icons/sk_082.png" width="24"> | ทวินสตอร์ม | สกิลยิง | Buffer | `TwinStormAction` | `TwinStormBuf`: NormalAttackRate, MoveSpeed, NormalAttackConstantDamage, Value, Stable, Aspd, LastDmgUpRate; `CountBufferBase`: Count |

## applies status ailment (99)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 1004 | <img src="../icons/sk_1004.png" width="24"> | เดธรีเซฟชัน | アサシンスキル | Attack | `DeathReceptionAction` |  |
| 1285 |  | ดราก้อนสเลฟ / ดราก้อนสเลฟ | AvatarSkill_1 | Attack | `DragSlaveAction` |  |
| 33 | <img src="../icons/sk_033.png" width="24"> | ฮาร์ดฮิต | สกิลดาบ | Attack | `HardHitAction` | flinchPercent |
| 44 | <img src="../icons/sk_044.png" width="24"> | เมเทโอเบรคเกอร์ | สกิลดาบ | Attack | `MeteoBreakerAction` | abnormalPercent |
| 47 | <img src="../icons/sk_047.png" width="24"> | ฟาสต์แอคแทค | สกิลดาบ | Attack | `FastAttackAction` |  |
| 48 | <img src="../icons/sk_048.png" width="24"> | ชัทเอาท์ | สกิลดาบ | Attack | `ShutOutAction` |  |
| 49 | <img src="../icons/sk_049.png" width="24"> | ลูนาร์สแลช | สกิลดาบ | Attack | `MoonSlashAction` |  |
| 56 | <img src="../icons/sk_056.png" width="24"> | ออร์คสแลช | สกิลดาบ | Attack | `OrgaslashAction` |  |
| 1060 | <img src="../icons/sk_1060.png" width="24"> | เดมอนคลอว์ | ダークパワースキル | Attack | `DemonCroweAction` |  |
| 1063 | <img src="../icons/sk_1063.png" width="24"> | โซลฮันเตอร์ / เดธรีปเปอร์ | ダークパワースキル | Attack | `SoulHuntAction` |  |
| 1065 | <img src="../icons/sk_1065.png" width="24"> | เนตรมารข่มขวัญ | ダークパワースキル | Attack | `IntimidatingEvilEyeAction` | flinchPercent, slowPercent |
| 1068 | <img src="../icons/sk_1068.png" width="24"> | เนตรมารโกลาหล | ダークパワースキル | Attack | `ChaosEvilEyeAction` |  |
| 643 | <img src="../icons/sk_643.png" width="24"> | ครอสแพรี่ | デュアルスキル | Attack | `ParryingSwordAction` |  |
| 646 | <img src="../icons/sk_646.png" width="24"> | สปินนิ่งสแลช | デュアルスキル | Object | `AirSlideAction` | blindPercent |
| 649 | <img src="../icons/sk_649.png" width="24"> | แฟนทอมสแลช / แฟนทอมอิคลิพส์ | デュアルスキル | Attack | `PhantomRaveAction` | freezeRate |
| 658 | <img src="../icons/sk_658.png" width="24"> | แอร์สไลเซอร์ | デュアルスキル | Attack | `AirSlicerAction` |  |
| 659 | <img src="../icons/sk_659.png" width="24"> | เอเลียสลีย์ | デュアルスキル | Special | `ArialSlayAction` |  |
| 1249 | <img src="../icons/sk_1249.png" width="24"> | ท่อเหล็ก | EventSkill | Attack | `IronPipeAction` |  |
| 585 | <img src="../icons/sk_585.png" width="24"> | ระเบิดเยือกแข็ง | ゴーレムスキル | Attack | `FreezeGrenadeAction` |  |
| 586 | <img src="../icons/sk_586.png" width="24"> | ระเบิดแสง | ゴーレムスキル | Attack | `FlashGrenadeAction` |  |
| 962 | <img src="../icons/sk_962.png" width="24"> | แคนนอนสเปียร์ | ハルバードスキル | Attack | `CannonSpearAction` |  |
| 966 | <img src="../icons/sk_966.png" width="24"> | ดราก้อนเทล | ハルバードスキル | Attack | `DragonTailAction` | tumblePercent |
| 969 | <img src="../icons/sk_969.png" width="24"> | ไดฟ์อิมแพ็ค | ハルバードスキル | Object | `DiveImpactAction` |  |
| 970 | <img src="../icons/sk_970.png" width="24"> | สไตร์คสเต็ป | ハルバードスキル | Attack | `StrikeStubAction` | abnormalRate |
| 972 | <img src="../icons/sk_972.png" width="24"> | ดราก้อนทูธ | ハルバードスキル | Attack | `DragonToothAction` |  |
| 976 | <img src="../icons/sk_976.png" width="24"> | ดราโกนิกชาร์จ | ハルバードスキル | Attack | `DragonicChargeAction` | abnormalPercent |
| 977 | <img src="../icons/sk_977.png" width="24"> | อินฟิไนท์ไดเมนชัน | ハルバードスキル | Object | `DimensionTillAction` |  |
| 980 | <img src="../icons/sk_980.png" width="24"> | บลิทซ์ไปก์ | ハルバードスキル | Object | `BlitzPikeAction` |  |
| 982 | <img src="../icons/sk_982.png" width="24"> | ธอร์แฮมเมอร์ | ハルバードスキル | Object | `ThorHammerAction` |  |
| 549 | <img src="../icons/sk_549.png" width="24"> | กับดักนิทรา | ハンタースキル | Object | `SleepTrapAction` | abnormalPercent |
| 550 | <img src="../icons/sk_550.png" width="24"> | กับดักล่าสัตว์ | ハンタースキル | Object | `SteelTrapAction` | abnormalPercent |
| 551 | <img src="../icons/sk_551.png" width="24"> | ทุ่นระเบิด | ハンタースキル | Object | `ExplossiveAction` |  |
| 552 | <img src="../icons/sk_552.png" width="24"> | กับดักความมืด | ハンタースキル | Object | `BlankTrapAction` | abnormalPercent |
| 558 | <img src="../icons/sk_558.png" width="24"> | มัลติเพิลฮันท์ / วูปสไนเปอร์ / สไนเปอร์วอลเลย์ / วันแฮนด์ช็อต / ชาร์ปชูตเตอร์ | ハンタースキル | Attack | `MultipleHuntAction` | abnormalPercent |
| 290 | <img src="../icons/sk_290.png" width="24"> | สไปก์ดาร์ต | ナイフスキル | Attack | `SpikeDartAction` | slowPercent |
| 291 | <img src="../icons/sk_291.png" width="24"> | พอยซั่นแดกเกอร์ | ナイフスキル | Attack | `PoisonDaggerAction` | poisonPercent |
| 300 | <img src="../icons/sk_300.png" width="24"> | ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ | ナイフスキル | Attack | `FlinchKnifeAction` | flinchPercent |
| 513 | <img src="../icons/sk_513.png" width="24"> | แอสเซาต์แอคแทค | ナイトスキル | Attack | `AssaultAttackAction` | slowRate |
| 518 | <img src="../icons/sk_518.png" width="24"> | ไบด์สไตร์ค | ナイトスキル | Attack | `BindStrikeAction` |  |
| 522 | <img src="../icons/sk_522.png" width="24"> | โซนิคทรัสต์ | ナイトスキル | Attack | `SonicThrustAction` |  |
| 526 | <img src="../icons/sk_526.png" width="24"> | บลิงค์ซอร์ด | ナイトスキル | Attack | `BlinkSwordAction` |  |
| 866 | <img src="../icons/sk_866.png" width="24"> | อีเทอร์แฟลร์ | マジックブレードスキル | Attack | `EtherFlareAction` |  |
| 868 | <img src="../icons/sk_868.png" width="24"> | เอเลเม้นต์สแลช | マジックブレードスキル | Attack | `ElementSlashAction` |  |
| 872 | <img src="../icons/sk_872.png" width="24"> | เอนชานท์บลาส / เอนชานท์อกรา | マジックブレードスキル | Attack | `EnchantedBurstAction` |  |
| 874 | <img src="../icons/sk_874.png" width="24"> | ยูเนียนซอร์ด / รียูเนียนซอร์ด | マジックブレードスキル | Attack | `UnionSwordAction` |  |
| 98 | <img src="../icons/sk_098.png" width="24"> | เวทมนตร์:แจฟลิน / หอกเพลิง / หอกน้ำแข็ง / หอกวายุ / หอกศิลา / หอกศักดิ์สิทธิ์ / หอกอนธการ | マジックスキル | Attack | `MagicJabelinAction` | abnormalRate |
| 102 | <img src="../icons/sk_102.png" width="24"> | เวทมนตร์:แลนซ์  / วัลแคน  / ไอซ์ซิเคิล / สลาตัน / ปืนใหญ่ศิลา / แสงสังหาร / สุริยคราส | マジックスキル | Object | `MagicLancerAction` | stopPercent |
| 103 | <img src="../icons/sk_103.png" width="24"> | เวทมนตร์:บลาส / เอ็กซ์โพลชั่น  / แอบโซลูทซีโร่ / แอร์โรว์บลาส / จีโออิมแพ็ค / ไชน์นิ่งบลาส / อีวิลบลาส | マジックスキル | Attack | `MagicBlastAction` | abnormalRate |
| 105 | <img src="../icons/sk_105.png" width="24"> | เวทมนตร์:อิมแพ็ค | マジックスキル | Attack | `MagicImpactAction` | abnormalRate |
| 108 | <img src="../icons/sk_108.png" width="24"> | เวทมนตร์: ไฟนอล | マジックスキル | Attack | `MagicFinawAction` |  |
| 109 | <img src="../icons/sk_109.png" width="24"> | เวทมนตร์: บลาส / เฮลอินเฟรูโน่ / อีเทอนอลบลิซซาร์ด / ฟอร์สเทมเพสต์ / เทิร์นกราวิตี้ / พันนิชเมนท์ / อีคลิปส์ | マジックスキル | Attack | `MagicBurstAction` | abnormalPercent |
| 113 | <img src="../icons/sk_113.png" width="24"> | เวทมนตร์:แครช / เมเทโอเรน / เฮล / ฟลูกูไรต์ / ร็อคฟอล / เมเทโอไลท์ / คอสมอส | マジックスキル | Attack | `MagicFallAction` |  |
| 116 | <img src="../icons/sk_116.png" width="24"> | เอนชานท์บาเรีย | マジックスキル | Buffer | `MagicProtectionAction` |  |
| 120 | <img src="../icons/sk_120.png" width="24"> | เวทมนตร์:เรเซอร์ | マジックスキル | Attack | `MagicLazerAction` | abnormalRate |
| 129 | <img src="../icons/sk_129.png" width="24"> | สแมช | マーシャルスキル | Attack | `SmashAction` | flinchPercent |
| 130 | <img src="../icons/sk_130.png" width="24"> | บาช | マーシャルスキル | Attack | `BashAction` | stunPercent |
| 131 | <img src="../icons/sk_131.png" width="24"> | โซนิคเวฟ | マーシャルスキル | Attack | `SonicWaveAction` | tumblePercent |
| 134 | <img src="../icons/sk_134.png" width="24"> | เชลเบรค | マーシャルスキル | Attack | `ShellBreakAction` |  |
| 135 | <img src="../icons/sk_135.png" width="24"> | เอิร์ธไบด์ | マーシャルスキル | Attack | `EarthBindAction` | stopPercent |
| 137 | <img src="../icons/sk_137.png" width="24"> | เฮวี่สแมช | マーシャルスキル | Attack | `HeavySmashAction` |  |
| 140 | <img src="../icons/sk_140.png" width="24"> | เชอริออต | マーシャルスキル | Attack | `ChariotAction` | abnormalPercent |
| 148 | <img src="../icons/sk_148.png" width="24"> | แนบพิงภูเขา | マーシャルスキル | Attack | `ThieshankaiAction` | stunPercent |
| 149 | <img src="../icons/sk_149.png" width="24"> | กระทืบพสุธา | マーシャルスキル | Attack | `ShinkyakuAction` | flinchPercent |
| 150 | <img src="../icons/sk_150.png" width="24"> | หมุนปัด / ขากงจักร | マーシャルスキル | Attack | `SenfutsuAction` | tumblePercent[0], tumblePercent[1] |
| 610 | <img src="../icons/sk_610.png" width="24"> | ปอมเมลสไตร์ค | モノノフスキル | Attack | `StrikeBackOfSwordAction` | abnormalPercent, stunPercent |
| 615 | <img src="../icons/sk_615.png" width="24"> | มากาดาจิ | モノノフスキル | Special | `CutOffTheDisasterAction` |  |
| 618 | <img src="../icons/sk_618.png" width="24"> | ซังเทเซตเท็ตสึ | モノノフスキル | Attack | `ZanteisettetsuAction` | abnormalPercent |
| 623 | <img src="../icons/sk_623.png" width="24"> | คมดาบมายา | モノノフスキル | Special | `RepelBladeAction` |  |
| 624 | <img src="../icons/sk_624.png" width="24"> | คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ | モノノフスキル | Attack | `IllusionarySceneAction` |  |
| 1122 | <img src="../icons/sk_1122.png" width="24"> | ทูม | ネクロマンサースキル | Attack | `TombAction` | abnormalPercent |
| 1125 | <img src="../icons/sk_1125.png" width="24"> | สกัลเชคเกอร์ | ネクロマンサースキル | Attack | `SkullShakerAction` | stunPercent |
| 1126 | <img src="../icons/sk_1126.png" width="24"> | บลัดสตีล | ネクロマンサースキル | Special | `BloodSteelAction` |  |
| 1130 | <img src="../icons/sk_1130.png" width="24"> | โซลสตรีม | ネクロマンサースキル | Object | `SoulStreamAction` |  |
| 19 |  | ImperialRayPursuitAction |  |  | `ImperialRayPursuitAction` |  |
| 159 |  | MindimageSenjuAttackAction |  |  | `MindimageSenjuAttackAction` |  |
| 1221 |  | FireStyleAction |  |  | `FireStyleAction` |  |
| 1225 |  | WindStyleAction |  |  | `WindStyleAction` |  |
| 1245 |  | RapidAquaVortexAction |  |  | `RapidAquaVortexAction` |  |
| 944 | <img src="../icons/sk_944.png" width="24"> | สวีปแอคแทค | ペット専用スキル | Attack | `SweepAttack` |  |
| 945 | <img src="../icons/sk_945.png" width="24"> | คลีนฮิต | ペット専用スキル | Attack | `DownBlow` |  |
| 947 | <img src="../icons/sk_947.png" width="24"> | บลายอิ้งแชโดว์ | ペット専用スキル | Attack | `BlindEye` | abnormalPercent |
| 949 | <img src="../icons/sk_949.png" width="24"> | สตันแอคแทค | ペット専用スキル | Attack | `StanAttack` |  |
| 953 | <img src="../icons/sk_953.png" width="24"> | ชีลเบรคเกอร์ | ペット専用スキル | Attack | `SealBreaker` |  |
| 258 | <img src="../icons/sk_258.png" width="24"> | ชีลด์บาช | シールドスキル | Attack | `ShieldBashAction` | stunPercent |
| 260 | <img src="../icons/sk_260.png" width="24"> | ชีลด์แคนนอน | シールドスキル | Attack | `ShieldCannonAction` | stunPercent |
| 266 | <img src="../icons/sk_266.png" width="24"> | ชีลด์อัปเปอร์คัต | シールドスキル | Attack | `ShieldUpperAction` |  |
| 65 | <img src="../icons/sk_065.png" width="24"> | พาวเวอร์ชู้ต | สกิลยิง | Attack | `PowerShootAction` | tumblePercent |
| 67 | <img src="../icons/sk_067.png" width="24"> | มีบาช็อต | สกิลยิง | Attack | `MeebaShotAction` | slowPercent |
| 71 | <img src="../icons/sk_071.png" width="24"> | พาราไลซิสช็อต | สกิลยิง | Attack | `ParalysisShotAction` | paralysisPercent |
| 73 | <img src="../icons/sk_073.png" width="24"> | สไนป์ | สกิลยิง | Attack | `SnipingAction` |  |
| 74 | <img src="../icons/sk_074.png" width="24"> | สโมคดัส | สกิลยิง | Attack | `SmokeDustAction` | blindnessPercent |
| 77 | <img src="../icons/sk_077.png" width="24"> | อาร์มเบรค | สกิลยิง | Attack | `ArmBreakAction` | abnormalPercent |
| 81 | <img src="../icons/sk_081.png" width="24"> | พาราโบลาแคนนอน | สกิลยิง | Attack | `ParabolaCannonAction` |  |
| 89 | <img src="../icons/sk_089.png" width="24"> | ไวด์สเปรด | สกิลยิง | Object | `WideSpreadAction` | abnormalPercent |
| 715 | <img src="../icons/sk_715.png" width="24"> | อิกนิชั่น | スプライトスキル | Attack | `IgnitionAction` |  |
| 716 | <img src="../icons/sk_716.png" width="24"> | อาร์เดดราค | スプライトスキル | Object | `AldedrakAction` |  |
| 1027 | <img src="../icons/sk_1027.png" width="24"> | ไลท์นิ่ง | ウィザードスキル | Object | `LightningAction` |  |
| 1028 | <img src="../icons/sk_1028.png" width="24"> | บลิซซาร์ด | ウィザードスキル | Object | `BlizzardAction` |  |
| 1029 | <img src="../icons/sk_1029.png" width="24"> | เมเทโอสตอร์มสไตร์ค | ウィザードスキル | Object | `MeteorStrikeAction` |  |

## heal / recovery (14)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 898 |  | NpcHealAction | 28 | Heal | `NpcHealAction` |  |
| 1057 | <img src="../icons/sk_1057.png" width="24"> | บลัดดี้ไบท์ | ダークパワースキル | Attack | `BloodBiteAction` |  |
| 1369 |  | 1369 | DebugSkill | Heal | `` |  |
| 1370 |  | 1370 | DebugSkill | Heal | `` |  |
| 22 |  | HolyLightPursuitAction |  |  | `HolyLightPursuitAction` |  |
| 732 |  | LifeExplosionAction |  |  | `LifeExplosionAction` |  |
| 939 | <img src="../icons/sk_939.png" width="24"> | เซอร์เคิลฮีล | ペット専用スキル | Heal | `KreisHeel` |  |
| 943 | <img src="../icons/sk_943.png" width="24"> | ฟื้นฟู | ペット専用スキル | Heal | `PetHealing` |  |
| 836 | <img src="../icons/sk_836.png" width="24"> | โฮลี่ไลท์ | PriestSkill | Attack | `HolyLightActin` |  |
| 708 | <img src="../icons/sk_708.png" width="24"> | ไมโครฮีล | スプライトスキル | Support | `ClineHealAction` |  |
| 228 | <img src="../icons/sk_228.png" width="24"> | มินิฮีล | サポートスキル | Heal | `PutitHealAction` |  |
| 231 | <img src="../icons/sk_231.png" width="24"> | รีคัฟเวอรี่ | サポートスキル | Heal | `RecoveryAction` |  |
| 237 | <img src="../icons/sk_237.png" width="24"> | ฮีล | サポートスキル | Heal | `HealAction` |  |
| 452 | <img src="../icons/sk_452.png" width="24"> | เพ็ทฮีล | テイマースキル | Buffer | `PetHealAction` |  |

## placed object / trap / summon (50)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 1188 |  | 1188 | 37 | Object | `` |  |
| 1061 | <img src="../icons/sk_1061.png" width="24"> | เรดเทีย | ダークパワースキル | Object | `RedTearAction` |  |
| 1064 | <img src="../icons/sk_1064.png" width="24"> | อีเทอนอลไนท์แมร์ | ダークパワースキル | Object | `EternalNightmareAction` |  |
| 1365 |  | 1365 | DebugSkill | Object | `` |  |
| 1366 |  | 1366 | DebugSkill | Object | `` |  |
| 1367 |  | 1367 | DebugSkill | Object | `` |  |
| 1368 |  | 1368 | DebugSkill | Object | `` |  |
| 646 | <img src="../icons/sk_646.png" width="24"> | สปินนิ่งสแลช | デュアルスキル | Object | `AirSlideAction` |  |
| 577 | <img src="../icons/sk_577.png" width="24"> | อัญเชิญโกเล็ม | ゴーレムスキル | Object | `CallGolemAction` |  |
| 587 | <img src="../icons/sk_587.png" width="24"> | บาเรียสกรีน | ゴーレムスキル | Object | `BarrierScreenAction` |  |
| 969 | <img src="../icons/sk_969.png" width="24"> | ไดฟ์อิมแพ็ค | ハルバードスキル | Object | `DiveImpactAction` |  |
| 977 | <img src="../icons/sk_977.png" width="24"> | อินฟิไนท์ไดเมนชัน | ハルバードスキル | Object | `DimensionTillAction` |  |
| 980 | <img src="../icons/sk_980.png" width="24"> | บลิทซ์ไปก์ | ハルバードスキル | Object | `BlitzPikeAction` |  |
| 981 | <img src="../icons/sk_981.png" width="24"> | ไลท์นิ่งเฮล | ハルバードスキル | Object | `LightningHailAction` |  |
| 982 | <img src="../icons/sk_982.png" width="24"> | ธอร์แฮมเมอร์ | ハルバードスキル | Object | `ThorHammerAction` |  |
| 548 | <img src="../icons/sk_548.png" width="24"> | แซทเทิลไลท์แอร์โรว์ | ハンタースキル | Object | `SatelliteArrowAction` |  |
| 549 | <img src="../icons/sk_549.png" width="24"> | กับดักนิทรา | ハンタースキル | Object | `SleepTrapAction` |  |
| 550 | <img src="../icons/sk_550.png" width="24"> | กับดักล่าสัตว์ | ハンタースキル | Object | `SteelTrapAction` |  |
| 551 | <img src="../icons/sk_551.png" width="24"> | ทุ่นระเบิด | ハンタースキル | Object | `ExplossiveAction` |  |
| 552 | <img src="../icons/sk_552.png" width="24"> | กับดักความมืด | ハンタースキル | Object | `BlankTrapAction` |  |
| 554 | <img src="../icons/sk_554.png" width="24"> | โฮมมิ่งช็อต | ハンタースキル | Object | `HomingShotAction` |  |
| 301 | <img src="../icons/sk_301.png" width="24"> | เครซี่แดกเกอร์ | ナイフスキル | Object | `CrazyDaggerAction` |  |
| 527 | <img src="../icons/sk_527.png" width="24"> | ไนท์เพลดจ์ | ナイトスキル | Object | `KnightPledgeAction` |  |
| 97 | <img src="../icons/sk_097.png" width="24"> | เวทมนตร์:แอร์โรว์ / ธนูไฟ / ธนูน้ำ / ธนูลม / ธนูดิน / ธนูแสง / ธนูมืด | マジックスキル | Object | `MagicArrowAction` |  |
| 99 | <img src="../icons/sk_099.png" width="24"> | เวทมนตร์:กำแพง / กำแพงอัคคี / ม่านวารี / กำแพงวายุ / เขตแดนปฐพี / เขตแดนศักดิ์สิทธิ์ / ประตูอสูร | マジックスキル | Object | `MagicWallAction` |  |
| 102 | <img src="../icons/sk_102.png" width="24"> | เวทมนตร์:แลนซ์  / วัลแคน  / ไอซ์ซิเคิล / สลาตัน / ปืนใหญ่ศิลา / แสงสังหาร / สุริยคราส | マジックスキル | Object | `MagicLancerAction` |  |
| 106 | <img src="../icons/sk_106.png" width="24"> | เวทมนตร์:สตรอม / ไฟเออร์สตรอม / โฟรเซนไซโคลน / ธันเดอร์สตรอม / แซนด์สตรอม / ลักซ์วอร์เทคซ์ / อีวิวเทมเพสต์ | マジックスキル | Object | `MagicStormAction` |  |
| 117 | <img src="../icons/sk_117.png" width="24"> | เมจิคไนฟ์ | マジックスキル | Object | `MagicKnifeAction` |  |
| 617 | <img src="../icons/sk_617.png" width="24"> | ฮัซโซฮัปปะ | モノノフスキル | Object | `HassohappaAction` |  |
| 625 | <img src="../icons/sk_625.png" width="24"> | ชาโดว์เลสสแลช | モノノフスキル | Object | `ShadowlessSlashAction` |  |
| 1121 | <img src="../icons/sk_1121.png" width="24"> | เกรฟดิกเกอร์ | ネクロマンサースキル | Object | `GlaiveTiggerAction` |  |
| 1123 | <img src="../icons/sk_1123.png" width="24"> | แฟนทอมมิสไซล์ | ネクロマンサースキル | Object | `PhantomMissileAction` |  |
| 1127 | <img src="../icons/sk_1127.png" width="24"> | ซัมมอนสเกเลตัน | ネクロマンサースキル | Object | `SummonSkeletonAction` |  |
| 1130 | <img src="../icons/sk_1130.png" width="24"> | โซลสตรีม | ネクロマンサースキル | Object | `SoulStreamAction` |  |
| 673 | <img src="../icons/sk_673.png" width="24"> | Lบูมเมอแรง / เลเพจบูมเมอแรง | パルチザンスキル | Object | `L_BoomerangAction` |  |
| 674 | <img src="../icons/sk_674.png" width="24"> | LบูมเมอแรงII / เลเพจบูมเมอแรงII | パルチザンスキル | Object | `L_Boomerang2Action` |  |
| 675 | <img src="../icons/sk_675.png" width="24"> | LบูมเมอแรงIII / เลเพจบูมเมอแรงIII | パルチザンスキル | Object | `L_Boomerang3Action` |  |
| 269 | <img src="../icons/sk_269.png" width="24"> | บาลาเกรุง | シールドスキル | Object | `BeragelungAction` |  |
| 70 | <img src="../icons/sk_070.png" width="24"> | แอร์โรว์เรน | สกิลยิง | Object | `ArrowRainAction` |  |
| 78 | <img src="../icons/sk_078.png" width="24"> | เดคอยชูตเตอร์ | สกิลยิง | Object | `DecoyShooterAction` |  |
| 89 | <img src="../icons/sk_089.png" width="24"> | ไวด์สเปรด | สกิลยิง | Object | `WideSpreadAction` |  |
| 707 | <img src="../icons/sk_707.png" width="24"> | เคาน์เตอร์ฟอร์ส | スプライトスキル | Object | `CounterForceAction` |  |
| 714 | <img src="../icons/sk_714.png" width="24"> | เมจิกวัลแคน | スプライトスキル | Object | `MagicBalkanAction` |  |
| 716 | <img src="../icons/sk_716.png" width="24"> | อาร์เดดราค | スプライトスキル | Object | `AldedrakAction` |  |
| 718 | <img src="../icons/sk_718.png" width="24"> | สแลชรีปเปอร์ | スプライトスキル | Object | `SlashReaperAction` |  |
| 234 | <img src="../icons/sk_234.png" width="24"> | แซงจูรี่ | サポートスキル | Object | `SanctuaryAction` |  |
| 1027 | <img src="../icons/sk_1027.png" width="24"> | ไลท์นิ่ง | ウィザードスキル | Object | `LightningAction` |  |
| 1028 | <img src="../icons/sk_1028.png" width="24"> | บลิซซาร์ด | ウィザードスキル | Object | `BlizzardAction` |  |
| 1029 | <img src="../icons/sk_1029.png" width="24"> | เมเทโอสตอร์มสไตร์ค | ウィザードスキル | Object | `MeteorStrikeAction` |  |
| 1034 | <img src="../icons/sk_1034.png" width="24"> | คริสตัลเลเซอร์ | ウィザードスキル | Object | `CrystalLaserAction` |  |

## circle / song area (19)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 1361 |  | 1361 | DebugSkill | Circle | `` |  |
| 1362 |  | 1362 | DebugSkill | Circle | `` |  |
| 1363 |  | 1363 | DebugSkill | Circle | `` |  |
| 1364 |  | 1364 | DebugSkill | Circle | `` |  |
| 424 |  | ランパート | ファランクススキル | Circle | `` |  |
| 769 | <img src="../icons/sk_769.png" width="24"> | บทเพลงแห่งการเยียวยา | ミンストレル | Circle | `HealingSongAction` |  |
| 770 | <img src="../icons/sk_770.png" width="24"> | บทเพลงแห่งภูตพราย | ミンストレル | Circle | `FairySongAction` |  |
| 771 | <img src="../icons/sk_771.png" width="24"> | บทเพลงแห่งชีวิต | ミンストレル | Circle | `SongOfLifeAction` |  |
| 772 | <img src="../icons/sk_772.png" width="24"> | บทเพลงแห่งมายา | ミンストレル | Circle | `PhantomSongAction` |  |
| 774 | <img src="../icons/sk_774.png" width="24"> | บทเพลงแห่งความเร่าร้อน | ミンストレル | Circle | `EnthusiasticSongAction` |  |
| 775 | <img src="../icons/sk_775.png" width="24"> | บทเพลงแห่งภูมิปัญญา | ミンストレル | Circle | `KnowledgeSongAction` |  |
| 226 | <img src="../icons/sk_226.png" width="24"> | ไลฟ์รีคัฟเวอรี่ | サポートスキル | Circle | `LifeRecoveryAction` |  |
| 227 | <img src="../icons/sk_227.png" width="24"> | มานารีชาร์จ | サポートスキル | Circle | `ManaRechargeAction` |  |
| 229 | <img src="../icons/sk_229.png" width="24"> | เบรฟออร่า | サポートスキル | Circle | `BraveAuraAction` |  |
| 230 | <img src="../icons/sk_230.png" width="24"> | เมจิกบาเรีย | サポートスキル | Circle | `MagicBarrierAction` |  |
| 232 | <img src="../icons/sk_232.png" width="24"> | ไฮไซเคิล | サポートスキル | Circle | `HighCycleAction` |  |
| 233 | <img src="../icons/sk_233.png" width="24"> | อิมมูนิตี้ | サポートスキル | Circle | `DiseasetSealAction` |  |
| 235 | <img src="../icons/sk_235.png" width="24"> | ควิกโมชั่น | サポートスキル | Circle | `QuickMotionAction` |  |
| 236 | <img src="../icons/sk_236.png" width="24"> | ฟาสต์รีเอคชั่น | サポートスキル | Circle | `HighReactionAction` |  |

## attack (deals damage) (243)

| uid | icon | skill | tree | type | class | buff / note |
|---|---|---|---|---|---|---|
| 899 |  | FlashOfTheWarGodAction | 28 | Attack | `FlashOfTheWarGodAction` |  |
| 900 | <img src="../icons/sk_900.png" width="24"> | JudgmentOfTheDarkGodAction | 28 | Attack | `JudgmentOfTheDarkGodAction` |  |
| 993 | <img src="../icons/sk_993.png" width="24"> | แอสแซสซินสแทบ / ฟรอนท์สแทบ / ไซด์สแทบ / แบ็คสแทบ | アサシンスキル | Attack | `AssassinStubAction` |  |
| 997 | <img src="../icons/sk_997.png" width="24"> | ฟูเนวินเด | アサシンスキル | Attack | `FuneVinteAction` |  |
| 1004 | <img src="../icons/sk_1004.png" width="24"> | เดธรีเซฟชัน | アサシンスキル | Attack | `DeathReceptionAction` |  |
| 1281 |  | เอ็กซ์โพชั่น | AvatarSkill_1 | Attack | `ExplosionAction` |  |
| 1282 |  | ไลท์ออฟเซเบอร์ | AvatarSkill_1 | Attack | `LightOfSaberAction` |  |
| 1283 | <img src="../icons/sk_1283.png" width="24"> | Morning Star | AvatarSkill_1 | Attack | `MorningStarAction` |  |
| 1285 |  | ดราก้อนสเลฟ / ดราก้อนสเลฟ | AvatarSkill_1 | Attack | `DragSlaveAction` |  |
| 33 | <img src="../icons/sk_033.png" width="24"> | ฮาร์ดฮิต | สกิลดาบ | Attack | `HardHitAction` |  |
| 34 | <img src="../icons/sk_034.png" width="24"> | แอสทิวท์ | สกิลดาบ | Attack | `AstuteAction` |  |
| 35 | <img src="../icons/sk_035.png" width="24"> | โซนิคเบรด | สกิลดาบ | Attack | `AccelBladeAction` |  |
| 38 | <img src="../icons/sk_038.png" width="24"> | ทริกเกอร์สแลช | สกิลดาบ | Attack | `TriggerSlashAction` |  |
| 39 | <img src="../icons/sk_039.png" width="24"> | สไปรัลแอร์ | สกิลดาบ | Attack | `SpiralAirAction` |  |
| 42 | <img src="../icons/sk_042.png" width="24"> | ซอร์ดเทมเพสต์ | สกิลดาบ | Attack | `SwordTempestAction` |  |
| 44 | <img src="../icons/sk_044.png" width="24"> | เมเทโอเบรคเกอร์ | สกิลดาบ | Attack | `MeteoBreakerAction` |  |
| 45 | <img src="../icons/sk_045.png" width="24"> | บัสตาร์ดเบลด | สกิลดาบ | Attack | `BusterBladeAction` |  |
| 47 | <img src="../icons/sk_047.png" width="24"> | ฟาสต์แอคแทค | สกิลดาบ | Attack | `FastAttackAction` |  |
| 48 | <img src="../icons/sk_048.png" width="24"> | ชัทเอาท์ | สกิลดาบ | Attack | `ShutOutAction` |  |
| 49 | <img src="../icons/sk_049.png" width="24"> | ลูนาร์สแลช | สกิลดาบ | Attack | `MoonSlashAction` |  |
| 50 | <img src="../icons/sk_050.png" width="24"> | ออร่าเบลด | สกิลดาบ | Attack | `AuraBladeAction` |  |
| 52 | <img src="../icons/sk_052.png" width="24"> | แฮมเมอร์สแลม | สกิลดาบ | Attack | `HammerDownAction` |  |
| 53 | <img src="../icons/sk_053.png" width="24"> | คลีฟวิงแอคแทค | สกิลดาบ | Attack | `CleaveAttackAction` |  |
| 54 | <img src="../icons/sk_054.png" width="24"> | สตรอมเบลซ | สกิลดาบ | Attack | `StormBlazerAction` |  |
| 56 | <img src="../icons/sk_056.png" width="24"> | ออร์คสแลช | สกิลดาบ | Attack | `OrgaslashAction` |  |
| 1153 | <img src="../icons/sk_1153.png" width="24"> | กำปั้นผดุงคุณธรรม | クラッシャー | Attack | `ForefistPunchAction` |  |
| 1155 | <img src="../icons/sk_1155.png" width="24"> | กลอเรียเทคชอต | クラッシャー | Attack | `GoliathTakeShotAction` |  |
| 1156 | <img src="../icons/sk_1156.png" width="24"> | ฟลายอิ้งคิก | クラッシャー | Attack | `FloatingKickAction` |  |
| 1157 | <img src="../icons/sk_1157.png" width="24"> | คอมบิเนชั่น | クラッシャー | Attack | `CombinationAction` |  |
| 1158 | <img src="../icons/sk_1158.png" width="24"> | ก็อดแฮนด์ | クラッシャー | Attack | `GodHandAction` |  |
| 1160 | <img src="../icons/sk_1160.png" width="24"> | เทอราบลาสต์ | クラッシャー | Attack | `GeoImpactAction` |  |
| 1162 | <img src="../icons/sk_1162.png" width="24"> | กีย์เซอร์ชู้ต | クラッシャー | Attack | `GazerShootAction` |  |
| 807 | <img src="../icons/sk_807.png" width="24"> | วิจิตรธรรมชาติ | ダンサー | Attack | `BeautiesOfNatureAction` |  |
| 1057 | <img src="../icons/sk_1057.png" width="24"> | บลัดดี้ไบท์ | ダークパワースキル | Attack | `BloodBiteAction` |  |
| 1058 | <img src="../icons/sk_1058.png" width="24"> | แซครีไฟซ์ | ダークパワースキル | Special | `SacrificeAction` |  |
| 1059 | <img src="../icons/sk_1059.png" width="24"> | ดาร์คสตริงเกอร์ | ダークパワースキル | Attack | `DarkStingerAction` |  |
| 1060 | <img src="../icons/sk_1060.png" width="24"> | เดมอนคลอว์ | ダークパワースキル | Attack | `DemonCroweAction` |  |
| 1061 | <img src="../icons/sk_1061.png" width="24"> | เรดเทีย | ダークパワースキル | Object | `RedTearAction` |  |
| 1063 | <img src="../icons/sk_1063.png" width="24"> | โซลฮันเตอร์ / เดธรีปเปอร์ | ダークパワースキル | Attack | `SoulHuntAction` |  |
| 1065 | <img src="../icons/sk_1065.png" width="24"> | เนตรมารข่มขวัญ | ダークパワースキル | Attack | `IntimidatingEvilEyeAction` |  |
| 1066 | <img src="../icons/sk_1066.png" width="24"> | เนตรมารเสน่หา | ダークパワースキル | Attack | `EnchantingEvilEyeAction` |  |
| 1067 | <img src="../icons/sk_1067.png" width="24"> | เนตรมารเพลิงทมิฬ | ダークパワースキル | Attack | `BlackFlameEvilEyeAction` |  |
| 1068 | <img src="../icons/sk_1068.png" width="24"> | เนตรมารโกลาหล | ダークパワースキル | Attack | `ChaosEvilEyeAction` |  |
| 642 | <img src="../icons/sk_642.png" width="24"> | ทวินสแลช | デュアルスキル | Attack | `TwinSlashAction` |  |
| 643 | <img src="../icons/sk_643.png" width="24"> | ครอสแพรี่ | デュアルスキル | Attack | `ParryingSwordAction` |  |
| 646 | <img src="../icons/sk_646.png" width="24"> | สปินนิ่งสแลช | デュアルスキル | Object | `AirSlideAction` |  |
| 647 | <img src="../icons/sk_647.png" width="24"> | ชาร์จจิ้งสแลช | デュアルスキル | Attack | `DragoonSwordAction` |  |
| 649 | <img src="../icons/sk_649.png" width="24"> | แฟนทอมสแลช / แฟนทอมอิคลิพส์ | デュアルスキル | Attack | `PhantomRaveAction` |  |
| 652 | <img src="../icons/sk_652.png" width="24"> | ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส | デュアルスキル | Attack | `ShiningClothAction` |  |
| 653 | <img src="../icons/sk_653.png" width="24"> | สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ | デュアルスキル | Attack | `SturmLeaperAction` |  |
| 655 | <img src="../icons/sk_655.png" width="24"> | ลูนาดิธเธอร์สตาร์ | デュアルスキル | Attack | `LunaDitherStarAction` |  |
| 656 | <img src="../icons/sk_656.png" width="24"> | ทวินบัสตาร์ดเบลด | デュアルスキル | Attack | `TwinBusterBladeAction` |  |
| 658 | <img src="../icons/sk_658.png" width="24"> | แอร์สไลเซอร์ | デュアルスキル | Attack | `AirSlicerAction` |  |
| 659 | <img src="../icons/sk_659.png" width="24"> | เอเลียสลีย์ | デュアルスキル | Special | `ArialSlayAction` |  |
| 660 | <img src="../icons/sk_660.png" width="24"> | ฮอร์ริซอนคัท | デュアルスキル | Attack | `HorizontalCutAction` |  |
| 661 | <img src="../icons/sk_661.png" width="24"> | เบลดสตริงเกอร์ | デュアルスキル | Attack | `BladeStingerAction` |  |
| 1249 | <img src="../icons/sk_1249.png" width="24"> | ท่อเหล็ก | EventSkill | Attack | `IronPipeAction` |  |
| 1250 | <img src="../icons/sk_1250.png" width="24"> | เรโทรโบว์กัน | EventSkill | Attack | `RetroBowgunAction` |  |
| 1251 | <img src="../icons/sk_1251.png" width="24"> | แม็กนั่ม | EventSkill | Attack | `MagnumAction` |  |
| 584 | <img src="../icons/sk_584.png" width="24"> | ระเบิดเวทมนตร์ | ゴーレムスキル | Attack | `MagicGrenadeAction` |  |
| 585 | <img src="../icons/sk_585.png" width="24"> | ระเบิดเยือกแข็ง | ゴーレムスキル | Attack | `FreezeGrenadeAction` |  |
| 586 | <img src="../icons/sk_586.png" width="24"> | ระเบิดแสง | ゴーレムスキル | Attack | `FlashGrenadeAction` |  |
| 961 | <img src="../icons/sk_961.png" width="24"> | เฟลชสเต็ป | ハルバードスキル | Attack | `FlashStubAction` |  |
| 962 | <img src="../icons/sk_962.png" width="24"> | แคนนอนสเปียร์ | ハルバードスキル | Attack | `CannonSpearAction` |  |
| 963 | <img src="../icons/sk_963.png" width="24"> | เดดลี่สเปียร์ | ハルバードスキル | Attack | `DeadlySpearAction` |  |
| 966 | <img src="../icons/sk_966.png" width="24"> | ดราก้อนเทล | ハルバードスキル | Attack | `DragonTailAction` |  |
| 967 | <img src="../icons/sk_967.png" width="24"> | วานิชเรย์ | ハルバードスキル | Attack | `PunishRayAction` |  |
| 969 | <img src="../icons/sk_969.png" width="24"> | ไดฟ์อิมแพ็ค | ハルバードスキル | Object | `DiveImpactAction` |  |
| 970 | <img src="../icons/sk_970.png" width="24"> | สไตร์คสเต็ป | ハルバードスキル | Attack | `StrikeStubAction` |  |
| 972 | <img src="../icons/sk_972.png" width="24"> | ดราก้อนทูธ | ハルバードスキル | Attack | `DragonToothAction` |  |
| 973 | <img src="../icons/sk_973.png" width="24"> | โครนอสไดรฟ์ | ハルバードスキル | Attack | `CronosDriveAction` |  |
| 975 | <img src="../icons/sk_975.png" width="24"> | บัสเตอร์แลนซ์ / แพนิกบัสเตอร์แลนซ์ | ハルバードスキル | Attack | `BusterLanceAction` |  |
| 976 | <img src="../icons/sk_976.png" width="24"> | ดราโกนิกชาร์จ | ハルバードスキル | Attack | `DragonicChargeAction` |  |
| 977 | <img src="../icons/sk_977.png" width="24"> | อินฟิไนท์ไดเมนชัน | ハルバードスキル | Object | `DimensionTillAction` |  |
| 980 | <img src="../icons/sk_980.png" width="24"> | บลิทซ์ไปก์ | ハルバードスキル | Object | `BlitzPikeAction` |  |
| 981 | <img src="../icons/sk_981.png" width="24"> | ไลท์นิ่งเฮล | ハルバードスキル | Object | `LightningHailAction` |  |
| 982 | <img src="../icons/sk_982.png" width="24"> | ธอร์แฮมเมอร์ | ハルバードスキル | Object | `ThorHammerAction` |  |
| 545 | <img src="../icons/sk_545.png" width="24"> | แตะ | ハンタースキル | Attack | `KickBackAction` |  |
| 546 | <img src="../icons/sk_546.png" width="24"> | ซันไรส์แอร์โรว์ | ハンタースキル | Attack | `SunriseArrowAction` |  |
| 548 | <img src="../icons/sk_548.png" width="24"> | แซทเทิลไลท์แอร์โรว์ | ハンタースキル | Object | `SatelliteArrowAction` |  |
| 549 | <img src="../icons/sk_549.png" width="24"> | กับดักนิทรา | ハンタースキル | Object | `SleepTrapAction` |  |
| 550 | <img src="../icons/sk_550.png" width="24"> | กับดักล่าสัตว์ | ハンタースキル | Object | `SteelTrapAction` |  |
| 551 | <img src="../icons/sk_551.png" width="24"> | ทุ่นระเบิด | ハンタースキル | Object | `ExplossiveAction` |  |
| 552 | <img src="../icons/sk_552.png" width="24"> | กับดักความมืด | ハンタースキル | Object | `BlankTrapAction` |  |
| 554 | <img src="../icons/sk_554.png" width="24"> | โฮมมิ่งช็อต | ハンタースキル | Object | `HomingShotAction` |  |
| 555 | <img src="../icons/sk_555.png" width="24"> | เวอร์ติคัลแอร์ | ハンタースキル | Attack | `VerticalAirAction` |  |
| 556 | <img src="../icons/sk_556.png" width="24"> | ไซโคลนแอร์โรว์ | ハンタースキル | Attack | `CycloneArrowAction` |  |
| 558 | <img src="../icons/sk_558.png" width="24"> | มัลติเพิลฮันท์ / วูปสไนเปอร์ / สไนเปอร์วอลเลย์ / วันแฮนด์ช็อต / ชาร์ปชูตเตอร์ | ハンタースキル | Attack | `MultipleHuntAction` |  |
| 290 | <img src="../icons/sk_290.png" width="24"> | สไปก์ดาร์ต | ナイフスキル | Attack | `SpikeDartAction` |  |
| 291 | <img src="../icons/sk_291.png" width="24"> | พอยซั่นแดกเกอร์ | ナイフスキル | Attack | `PoisonDaggerAction` |  |
| 292 | <img src="../icons/sk_292.png" width="24"> | แกตติ้งไนฟ์ | ナイフスキル | Attack | `GatlingKnifeAction` |  |
| 295 | <img src="../icons/sk_295.png" width="24"> | โธร์วไนฟ์ | ナイフスキル | Attack | `ThrowingAction` |  |
| 299 | <img src="../icons/sk_299.png" width="24"> | ไนฟ์คอมแบท | ナイフスキル | Special | `KnifeCombatAction` |  |
| 300 | <img src="../icons/sk_300.png" width="24"> | ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ | ナイフスキル | Attack | `FlinchKnifeAction` |  |
| 301 | <img src="../icons/sk_301.png" width="24"> | เครซี่แดกเกอร์ | ナイフスキル | Object | `CrazyDaggerAction` |  |
| 302 | <img src="../icons/sk_302.png" width="24"> | วีลไบต์ | ナイフスキル | Attack | `WheelBiteAction` |  |
| 513 | <img src="../icons/sk_513.png" width="24"> | แอสเซาต์แอคแทค | ナイトスキル | Attack | `AssaultAttackAction` |  |
| 516 | <img src="../icons/sk_516.png" width="24"> | เรจซอร์ด | ナイトスキル | Attack | `RageSwordAction` |  |
| 518 | <img src="../icons/sk_518.png" width="24"> | ไบด์สไตร์ค | ナイトスキル | Attack | `BindStrikeAction` |  |
| 522 | <img src="../icons/sk_522.png" width="24"> | โซนิคทรัสต์ | ナイトスキル | Attack | `SonicThrustAction` |  |
| 523 | <img src="../icons/sk_523.png" width="24"> | เรเวอเนีย | ナイトスキル | Attack | `LevenirAction` |  |
| 526 | <img src="../icons/sk_526.png" width="24"> | บลิงค์ซอร์ด | ナイトスキル | Attack | `BlinkSwordAction` |  |
| 866 | <img src="../icons/sk_866.png" width="24"> | อีเทอร์แฟลร์ | マジックブレードスキル | Attack | `EtherFlareAction` |  |
| 868 | <img src="../icons/sk_868.png" width="24"> | เอเลเม้นต์สแลช | マジックブレードスキル | Attack | `ElementSlashAction` |  |
| 870 | <img src="../icons/sk_870.png" width="24"> | เอนชานท์ซอร์ด / เอนชานท์บลาสซอร์ด | マジックブレードスキル | Attack | `EnchantedSwordAction` |  |
| 872 | <img src="../icons/sk_872.png" width="24"> | เอนชานท์บลาส / เอนชานท์อกรา | マジックブレードスキル | Attack | `EnchantedBurstAction` |  |
| 874 | <img src="../icons/sk_874.png" width="24"> | ยูเนียนซอร์ด / รียูเนียนซอร์ด | マジックブレードスキル | Attack | `UnionSwordAction` |  |
| 97 | <img src="../icons/sk_097.png" width="24"> | เวทมนตร์:แอร์โรว์ / ธนูไฟ / ธนูน้ำ / ธนูลม / ธนูดิน / ธนูแสง / ธนูมืด | マジックスキル | Object | `MagicArrowAction` |  |
| 98 | <img src="../icons/sk_098.png" width="24"> | เวทมนตร์:แจฟลิน / หอกเพลิง / หอกน้ำแข็ง / หอกวายุ / หอกศิลา / หอกศักดิ์สิทธิ์ / หอกอนธการ | マジックスキル | Attack | `MagicJabelinAction` |  |
| 99 | <img src="../icons/sk_099.png" width="24"> | เวทมนตร์:กำแพง / กำแพงอัคคี / ม่านวารี / กำแพงวายุ / เขตแดนปฐพี / เขตแดนศักดิ์สิทธิ์ / ประตูอสูร | マジックスキル | Object | `MagicWallAction` |  |
| 102 | <img src="../icons/sk_102.png" width="24"> | เวทมนตร์:แลนซ์  / วัลแคน  / ไอซ์ซิเคิล / สลาตัน / ปืนใหญ่ศิลา / แสงสังหาร / สุริยคราส | マジックスキル | Object | `MagicLancerAction` |  |
| 103 | <img src="../icons/sk_103.png" width="24"> | เวทมนตร์:บลาส / เอ็กซ์โพลชั่น  / แอบโซลูทซีโร่ / แอร์โรว์บลาส / จีโออิมแพ็ค / ไชน์นิ่งบลาส / อีวิลบลาส | マジックスキル | Attack | `MagicBlastAction` |  |
| 105 | <img src="../icons/sk_105.png" width="24"> | เวทมนตร์:อิมแพ็ค | マジックスキル | Attack | `MagicImpactAction` |  |
| 106 | <img src="../icons/sk_106.png" width="24"> | เวทมนตร์:สตรอม / ไฟเออร์สตรอม / โฟรเซนไซโคลน / ธันเดอร์สตรอม / แซนด์สตรอม / ลักซ์วอร์เทคซ์ / อีวิวเทมเพสต์ | マジックスキル | Object | `MagicStormAction` |  |
| 108 | <img src="../icons/sk_108.png" width="24"> | เวทมนตร์: ไฟนอล | マジックスキル | Attack | `MagicFinawAction` |  |
| 109 | <img src="../icons/sk_109.png" width="24"> | เวทมนตร์: บลาส / เฮลอินเฟรูโน่ / อีเทอนอลบลิซซาร์ด / ฟอร์สเทมเพสต์ / เทิร์นกราวิตี้ / พันนิชเมนท์ / อีคลิปส์ | マジックスキル | Attack | `MagicBurstAction` |  |
| 112 | <img src="../icons/sk_112.png" width="24"> | เวทมนตร์:เมจิกแคนนอน | マジックスキル | Attack | `MagicCannonAction` |  |
| 113 | <img src="../icons/sk_113.png" width="24"> | เวทมนตร์:แครช / เมเทโอเรน / เฮล / ฟลูกูไรต์ / ร็อคฟอล / เมเทโอไลท์ / คอสมอส | マジックスキル | Attack | `MagicFallAction` |  |
| 117 | <img src="../icons/sk_117.png" width="24"> | เมจิคไนฟ์ | マジックスキル | Object | `MagicKnifeAction` |  |
| 120 | <img src="../icons/sk_120.png" width="24"> | เวทมนตร์:เรเซอร์ | マジックスキル | Attack | `MagicLazerAction` |  |
| 129 | <img src="../icons/sk_129.png" width="24"> | สแมช | マーシャルスキル | Attack | `SmashAction` |  |
| 130 | <img src="../icons/sk_130.png" width="24"> | บาช | マーシャルスキル | Attack | `BashAction` |  |
| 131 | <img src="../icons/sk_131.png" width="24"> | โซนิคเวฟ | マーシャルスキル | Attack | `SonicWaveAction` |  |
| 134 | <img src="../icons/sk_134.png" width="24"> | เชลเบรค | マーシャルスキル | Attack | `ShellBreakAction` |  |
| 135 | <img src="../icons/sk_135.png" width="24"> | เอิร์ธไบด์ | マーシャルスキル | Attack | `EarthBindAction` |  |
| 137 | <img src="../icons/sk_137.png" width="24"> | เฮวี่สแมช | マーシャルスキル | Attack | `HeavySmashAction` |  |
| 138 | <img src="../icons/sk_138.png" width="24"> | ทริปเปิ้ลคิก | マーシャルスキル | Attack | `TryArtsAction` |  |
| 140 | <img src="../icons/sk_140.png" width="24"> | เชอริออต | マーシャルスキル | Attack | `ChariotAction` |  |
| 141 | <img src="../icons/sk_141.png" width="24"> | รัช | マーシャルスキル | Attack | `RushAction` |  |
| 146 | <img src="../icons/sk_146.png" width="24"> | เฟลชบลิงค์ | マーシャルスキル | Attack | `FlashArtsAction` |  |
| 148 | <img src="../icons/sk_148.png" width="24"> | แนบพิงภูเขา | マーシャルスキル | Attack | `ThieshankaiAction` |  |
| 149 | <img src="../icons/sk_149.png" width="24"> | กระทืบพสุธา | マーシャルスキル | Attack | `ShinkyakuAction` |  |
| 150 | <img src="../icons/sk_150.png" width="24"> | หมุนปัด / ขากงจักร | マーシャルスキル | Attack | `SenfutsuAction` |  |
| 776 | <img src="../icons/sk_776.png" width="24"> | บีทบลาสต์ | ミンストレル | Special | `BeatBlastAction` |  |
| 609 | <img src="../icons/sk_609.png" width="24"> | เฟลช | モノノフスキル | Attack | `FlashDrawnSwordAction` |  |
| 610 | <img src="../icons/sk_610.png" width="24"> | ปอมเมลสไตร์ค | モノノフスキル | Attack | `StrikeBackOfSwordAction` |  |
| 611 | <img src="../icons/sk_611.png" width="24"> | พัลส์เบลด / สวิฟต์พัลส์เบลด | モノノフスキル | Attack | `WaveBladeAction` |  |
| 614 | <img src="../icons/sk_614.png" width="24"> | ทริปเปิ้ลทรัสต์ | モノノフスキル | Attack | `ThreeStageThrustAction` |  |
| 615 | <img src="../icons/sk_615.png" width="24"> | มากาดาจิ | モノノフスキル | Special | `CutOffTheDisasterAction` |  |
| 617 | <img src="../icons/sk_617.png" width="24"> | ฮัซโซฮัปปะ | モノノフスキル | Object | `HassohappaAction` |  |
| 618 | <img src="../icons/sk_618.png" width="24"> | ซังเทเซตเท็ตสึ | モノノフスキル | Attack | `ZanteisettetsuAction` |  |
| 620 | <img src="../icons/sk_620.png" width="24"> | เท็นริวรันเซ | モノノフスキル | Attack | `HeavenlyStarAction` |  |
| 621 | <img src="../icons/sk_621.png" width="24"> | การิวเท็นเซ | モノノフスキル | Attack | `FinishingTouchAction` |  |
| 623 | <img src="../icons/sk_623.png" width="24"> | คมดาบมายา | モノノフスキル | Special | `RepelBladeAction` |  |
| 624 | <img src="../icons/sk_624.png" width="24"> | คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ | モノノフスキル | Attack | `IllusionarySceneAction` |  |
| 625 | <img src="../icons/sk_625.png" width="24"> | ชาโดว์เลสสแลช | モノノフスキル | Object | `ShadowlessSlashAction` |  |
| 630 | <img src="../icons/sk_630.png" width="24"> | ลมกรด | モノノフスキル | Attack | `HayateAction` |  |
| 1122 | <img src="../icons/sk_1122.png" width="24"> | ทูม | ネクロマンサースキル | Attack | `TombAction` |  |
| 1123 | <img src="../icons/sk_1123.png" width="24"> | แฟนทอมมิสไซล์ | ネクロマンサースキル | Object | `PhantomMissileAction` |  |
| 1125 | <img src="../icons/sk_1125.png" width="24"> | สกัลเชคเกอร์ | ネクロマンサースキル | Attack | `SkullShakerAction` |  |
| 1127 | <img src="../icons/sk_1127.png" width="24"> | ซัมมอนสเกเลตัน | ネクロマンサースキル | Object | `SummonSkeletonAction` |  |
| 1129 | <img src="../icons/sk_1129.png" width="24"> | เดนเจอร์เชค | ネクロマンサースキル | Attack | `DengerShakeAction` |  |
| 1130 | <img src="../icons/sk_1130.png" width="24"> | โซลสตรีม | ネクロマンサースキル | Object | `SoulStreamAction` |  |
| 0 |  | NormalAttackAction |  |  | `NormalAttackAction` |  |
| 7 |  | PhiloEclailAttackAction |  |  | `PhiloEclailAttackAction` |  |
| 11 |  | PhysicalPursuitAction |  |  | `PhysicalPursuitAction` |  |
| 12 |  | MagicPursuitAction |  |  | `MagicPursuitAction` |  |
| 15 |  | CronosDrivePursuitAction |  |  | `CronosDrivePursuitAction` |  |
| 17 |  | ComboRelfectionAction |  |  | `ComboRelfectionAction` |  |
| 18 |  | MagicEgelAttackAction |  |  | `MagicEgelAttackAction` |  |
| 19 |  | ImperialRayPursuitAction |  |  | `ImperialRayPursuitAction` |  |
| 20 |  | ShadowWalkAttackAction |  |  | `ShadowWalkAttackAction` |  |
| 21 |  | MagicFinawPursuitAction |  |  | `MagicFinawPursuitAction` |  |
| 22 |  | HolyLightPursuitAction |  |  | `HolyLightPursuitAction` |  |
| 25 |  | BonusNormalDamageAction |  |  | `BonusNormalDamageAction` |  |
| 26 |  | BonusPhysicalDamageAction |  |  | `BonusPhysicalDamageAction` |  |
| 27 |  | BonusMagicDamageAction |  |  | `BonusMagicDamageAction` |  |
| 28 |  | BonusNaturalDamageAction |  |  | `BonusNaturalDamageAction` |  |
| 63 |  | MoonSlashPursuitAction |  |  | `MoonSlashPursuitAction` |  |
| 95 |  | JumpbackShotPursuitAction |  |  | `JumpbackShotPursuitAction` |  |
| 157 |  | AshuraAuraAttackAction |  |  | `AshuraAuraAttackAction` |  |
| 159 |  | MindimageSenjuAttackAction |  |  | `MindimageSenjuAttackAction` |  |
| 319 |  | CrazyDaggerPursuitAction |  |  | `CrazyDaggerPursuitAction` |  |
| 637 |  | IchijhinnokazeAttackAction |  |  | `IchijhinnokazeAttackAction` |  |
| 638 |  | TenjhoTengeMusouSwordAction |  |  | `TenjhoTengeMusouSwordAction` |  |
| 671 |  | LunaDitherStarBladeRainAction |  |  | `LunaDitherStarBladeRainAction` |  |
| 732 |  | LifeExplosionAction |  |  | `LifeExplosionAction` |  |
| 734 |  | AstralLanceAttackAction |  |  | `AstralLanceAttackAction` |  |
| 735 |  | CounterForceAttackAction |  |  | `CounterForceAttackAction` |  |
| 797 |  | BattleNotesAttackAction |  |  | `BattleNotesAttackAction` |  |
| 863 |  | HolyGracePursuitAttackAction |  |  | `HolyGracePursuitAttackAction` |  |
| 988 |  | BlitzPikePursuitAction |  |  | `BlitzPikePursuitAction` |  |
| 1219 |  | KunaiThrowingAction |  |  | `KunaiThrowingAction` |  |
| 1220 |  | FumaShurikenAction |  |  | `FumaShurikenAction` |  |
| 1221 |  | FireStyleAction |  |  | `FireStyleAction` |  |
| 1222 |  | ThunderStyleAction |  |  | `ThunderStyleAction` |  |
| 1225 |  | WindStyleAction |  |  | `WindStyleAction` |  |
| 1226 |  | CloningTechniqueAction |  |  | `CloningTechniqueAction` |  |
| 1245 |  | RapidAquaVortexAction |  |  | `RapidAquaVortexAction` |  |
| 1246 |  | EarthStyleAttackAction |  |  | `EarthStyleAttackAction` |  |
| 673 | <img src="../icons/sk_673.png" width="24"> | Lบูมเมอแรง / เลเพจบูมเมอแรง | パルチザンスキル | Object | `L_BoomerangAction` |  |
| 674 | <img src="../icons/sk_674.png" width="24"> | LบูมเมอแรงII / เลเพจบูมเมอแรงII | パルチザンスキル | Object | `L_Boomerang2Action` |  |
| 675 | <img src="../icons/sk_675.png" width="24"> | LบูมเมอแรงIII / เลเพจบูมเมอแรงIII | パルチザンスキル | Object | `L_Boomerang3Action` |  |
| 676 | <img src="../icons/sk_676.png" width="24"> | Nดราก้อนทูธ / นีโน่ดราก้อนทูธ | パルチザンスキル | Attack | `N_DragonToothAction` |  |
| 929 | <img src="../icons/sk_929.png" width="24"> | บาสต์แอคแทค | ペット専用スキル | Attack | `BusterAttack` |  |
| 933 | <img src="../icons/sk_933.png" width="24"> | เมจิกแลนซ์ | ペット専用スキル | Attack | `SorcielLance` |  |
| 935 | <img src="../icons/sk_935.png" width="24"> | เฮวี่แอคแทค | ペット専用スキル | Attack | `HeavyAttack` |  |
| 936 | <img src="../icons/sk_936.png" width="24"> | ลอบโจมตี | ペット専用スキル | Attack | `SneakAttack` |  |
| 937 | <img src="../icons/sk_937.png" width="24"> | เมจิกชอต | ペット専用スキル | Attack | `MagicShot` |  |
| 938 | <img src="../icons/sk_938.png" width="24"> | บลาสต์แฟลร์ | ペット専用スキル | Attack | `BlastFlare` |  |
| 944 | <img src="../icons/sk_944.png" width="24"> | สวีปแอคแทค | ペット専用スキル | Attack | `SweepAttack` |  |
| 945 | <img src="../icons/sk_945.png" width="24"> | คลีนฮิต | ペット専用スキル | Attack | `DownBlow` |  |
| 946 | <img src="../icons/sk_946.png" width="24"> | เรจแอคแทค | ペット専用スキル | Attack | `RageAttack` |  |
| 947 | <img src="../icons/sk_947.png" width="24"> | บลายอิ้งแชโดว์ | ペット専用スキル | Attack | `BlindEye` |  |
| 949 | <img src="../icons/sk_949.png" width="24"> | สตันแอคแทค | ペット専用スキル | Attack | `StanAttack` |  |
| 953 | <img src="../icons/sk_953.png" width="24"> | ชีลเบรคเกอร์ | ペット専用スキル | Attack | `SealBreaker` |  |
| 959 |  | การโจมตีปกติ (เวทมนตร์) | ペット専用スキル | Attack | `PetNormalMagicAction` |  |
| 834 | <img src="../icons/sk_834.png" width="24"> | โฮลี่ฟิสท์ | PriestSkill | Attack | `HolyFistAction` |  |
| 836 | <img src="../icons/sk_836.png" width="24"> | โฮลี่ไลท์ | PriestSkill | Attack | `HolyLightActin` |  |
| 841 | <img src="../icons/sk_841.png" width="24"> | ร็อดสทับ | PriestSkill | Attack | `RodStubAction` |  |
| 842 | <img src="../icons/sk_842.png" width="24"> | เอ็กซอร์ซิสต์ | PriestSkill | Attack | `ExorcismAction` |  |
| 844 | <img src="../icons/sk_844.png" width="24"> | เนเมซิส | PriestSkill | Attack | `NemesisAction` |  |
| 258 | <img src="../icons/sk_258.png" width="24"> | ชีลด์บาช | シールドスキル | Attack | `ShieldBashAction` |  |
| 260 | <img src="../icons/sk_260.png" width="24"> | ชีลด์แคนนอน | シールドスキル | Attack | `ShieldCannonAction` |  |
| 262 | <img src="../icons/sk_262.png" width="24"> | การ์ดสไตร์ค | シールドスキル | Mastery | `GuardStrikeAction` |  |
| 266 | <img src="../icons/sk_266.png" width="24"> | ชีลด์อัปเปอร์คัต | シールドスキル | Attack | `ShieldUpperAction` |  |
| 269 | <img src="../icons/sk_269.png" width="24"> | บาลาเกรุง | シールドスキル | Object | `BeragelungAction` |  |
| 65 | <img src="../icons/sk_065.png" width="24"> | พาวเวอร์ชู้ต | สกิลยิง | Attack | `PowerShootAction` |  |
| 66 | <img src="../icons/sk_066.png" width="24"> | บูลส์อาย | สกิลยิง | Attack | `OneWheelAction` |  |
| 67 | <img src="../icons/sk_067.png" width="24"> | มีบาช็อต | สกิลยิง | Attack | `MeebaShotAction` |  |
| 70 | <img src="../icons/sk_070.png" width="24"> | แอร์โรว์เรน | สกิลยิง | Object | `ArrowRainAction` |  |
| 71 | <img src="../icons/sk_071.png" width="24"> | พาราไลซิสช็อต | สกิลยิง | Attack | `ParalysisShotAction` |  |
| 73 | <img src="../icons/sk_073.png" width="24"> | สไนป์ | สกิลยิง | Attack | `SnipingAction` |  |
| 74 | <img src="../icons/sk_074.png" width="24"> | สโมคดัส | สกิลยิง | Attack | `SmokeDustAction` |  |
| 76 | <img src="../icons/sk_076.png" width="24"> | ครอสสเฟียร์ | สกิลยิง | Attack | `CrossFireAction` |  |
| 77 | <img src="../icons/sk_077.png" width="24"> | อาร์มเบรค | สกิลยิง | Attack | `ArmBreakAction` |  |
| 78 | <img src="../icons/sk_078.png" width="24"> | เดคอยชูตเตอร์ | สกิลยิง | Object | `DecoyShooterAction` |  |
| 79 | <img src="../icons/sk_079.png" width="24"> | เดสทอลก์ช็อต | สกิลยิง | Attack | `DeathTorqueShotAction` |  |
| 80 | <img src="../icons/sk_080.png" width="24"> | รีโทรเกรดชอท | สกิลยิง | Attack | `JumpbackShotAction` |  |
| 81 | <img src="../icons/sk_081.png" width="24"> | พาราโบลาแคนนอน | สกิลยิง | Attack | `ParabolaCannonAction` |  |
| 84 | <img src="../icons/sk_084.png" width="24"> | แวนควิชเชอร์ | สกิลยิง | Attack | `ConquesterAction` |  |
| 88 | <img src="../icons/sk_088.png" width="24"> | เจาะทะลุ | สกิลยิง | Attack | `PenetratorAction` |  |
| 89 | <img src="../icons/sk_089.png" width="24"> | ไวด์สเปรด | สกิลยิง | Object | `WideSpreadAction` |  |
| 714 | <img src="../icons/sk_714.png" width="24"> | เมจิกวัลแคน | スプライトスキル | Object | `MagicBalkanAction` |  |
| 715 | <img src="../icons/sk_715.png" width="24"> | อิกนิชั่น | スプライトスキル | Attack | `IgnitionAction` |  |
| 716 | <img src="../icons/sk_716.png" width="24"> | อาร์เดดราค | スプライトスキル | Object | `AldedrakAction` |  |
| 717 | <img src="../icons/sk_717.png" width="24"> | แฟกทิสอาร์ม | スプライトスキル | Attack | `FacticeArmeAction` |  |
| 718 | <img src="../icons/sk_718.png" width="24"> | สแลชรีปเปอร์ | スプライトスキル | Object | `SlashReaperAction` |  |
| 1027 | <img src="../icons/sk_1027.png" width="24"> | ไลท์นิ่ง | ウィザードスキル | Object | `LightningAction` |  |
| 1028 | <img src="../icons/sk_1028.png" width="24"> | บลิซซาร์ด | ウィザードスキル | Object | `BlizzardAction` |  |
| 1029 | <img src="../icons/sk_1029.png" width="24"> | เมเทโอสตอร์มสไตร์ค | ウィザードスキル | Object | `MeteorStrikeAction` |  |
| 1031 | <img src="../icons/sk_1031.png" width="24"> | อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์ | ウィザードスキル | Attack | `ImperialRayAction` |  |
| 1034 | <img src="../icons/sk_1034.png" width="24"> | คริสตัลเลเซอร์ | ウィザードスキル | Object | `CrystalLaserAction` |  |
