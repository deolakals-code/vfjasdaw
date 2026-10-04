// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class ActionCommand // TypeDefIndex: 15124
{
	// Fields
	private static int actionRevision; // 0x0

	// Methods

	// RVA: 0x3584E50 Offset: 0x3580E50 VA: 0x3584E50
	public static short GetNextRevision() { }

	// RVA: 0x3584EA0 Offset: 0x3580EA0 VA: 0x3584EA0
	internal static void Check(Game game, ActionData action) { }

	// RVA: 0x3584F40 Offset: 0x3580F40 VA: 0x3584F40
	public static void Move(Game game, short[] position, short rotation, short speed) { }

	// RVA: 0x3584FF8 Offset: 0x3580FF8 VA: 0x3584FF8
	public static void MoodMessage(Game game, string moodMessage, bool isLog) { }

	// RVA: 0x35850DC Offset: 0x35810DC VA: 0x35850DC
	public static void Emotion(Game game, byte type, byte emotionId) { }

	// RVA: 0x35850E8 Offset: 0x35810E8 VA: 0x35850E8
	public static void Emotion(Game game, byte type, byte emotionId, short[] pos, short rot) { }

	// RVA: 0x35851E0 Offset: 0x35811E0 VA: 0x35851E0
	public static void EmotionSitDown(Game game, byte emotionId, short[] pos, short rot) { }

	// RVA: 0x35852D0 Offset: 0x35812D0 VA: 0x35852D0
	public static void EmotionCancel(Game game) { }

	// RVA: 0x3585390 Offset: 0x3581390 VA: 0x3585390
	public static void AttackStart(Game game, AttackStartData attackData) { }

	// RVA: 0x3585428 Offset: 0x3581428 VA: 0x3585428
	public static void Attack(Game game, short skillId, byte localId, byte damageId, List<MobDamageData> targetList, int param, byte attackCount, short[] position, short rotation, short attackRotation) { }

	// RVA: 0x3585598 Offset: 0x3581598 VA: 0x3585598
	public static void AttackEnd(Game game, short skillId, byte localId) { }

	// RVA: 0x358566C Offset: 0x358166C VA: 0x358566C
	public static void PartsAttack(Game game, MobSendData sendData, byte partId, int damage) { }

	// RVA: 0x358575C Offset: 0x358175C VA: 0x358575C
	public static void ComboEnd(Game game) { }

	// RVA: 0x35857D0 Offset: 0x35817D0 VA: 0x35857D0
	public static int SupportStart(Game game, SupportStartData supportData) { }

	// RVA: 0x358588C Offset: 0x358188C VA: 0x358588C
	public static int Support(Game game, SupportData supportData) { }

	// RVA: 0x3585948 Offset: 0x3581948 VA: 0x3585948
	public static void SupportEnd(Game game, short skillId, byte localId) { }

	// RVA: 0x3585A1C Offset: 0x3581A1C VA: 0x3585A1C
	public static void SupportDelay(Game game, SupportDelayData delayData) { }

	// RVA: 0x3585AB4 Offset: 0x3581AB4 VA: 0x3585AB4
	public static void SkillCancel(Game game, short skillId, byte localId) { }

	// RVA: 0x3585B88 Offset: 0x3581B88 VA: 0x3585B88
	public static void SkillMotionEnd(Game game, SkillMotionEndData motionEndData) { }

	// RVA: 0x3585C20 Offset: 0x3581C20 VA: 0x3585C20
	public static void BattleEndCheck(Game game) { }

	// RVA: 0x3585CDC Offset: 0x3581CDC VA: 0x3585CDC
	public static void SkillEvent(Game game, SkillEventData skillEvent) { }

	// RVA: 0x3585D74 Offset: 0x3581D74 VA: 0x3585D74
	public static void SkillSummons(Game game, short skillId, byte localId, short[] position, short rotaion) { }

	// RVA: 0x3585E6C Offset: 0x3581E6C VA: 0x3585E6C
	public static void SkillSummonsRemove(Game game, SkillSummonsRemoveData removeData) { }

	// RVA: 0x3585F04 Offset: 0x3581F04 VA: 0x3585F04
	public static void GuardAndAvoid(Game game, byte type, int param, int[] clientParam) { }

	// RVA: 0x3585FF4 Offset: 0x3581FF4 VA: 0x3585FF4
	public static void RemoveSkillBuffer(Game game, short[] skillIds) { }

	// RVA: 0x35860CC Offset: 0x35820CC VA: 0x35860CC
	public static void MobCreate(Game game, MobSendData sendData) { }

	// RVA: 0x3586164 Offset: 0x3582164 VA: 0x3586164
	public static void MobRelease(Game game, MobIdData sendData) { }

	// RVA: 0x35861FC Offset: 0x35821FC VA: 0x35861FC
	public static void MobCheck(Game game, MobIdData sendData) { }

	// RVA: 0x3586294 Offset: 0x3582294 VA: 0x3586294
	public static void MobHateCheck(Game game) { }

	// RVA: 0x3586308 Offset: 0x3582308 VA: 0x3586308
	public static void MobMove(Game game, List<MobSendData> mobData, bool isReliable) { }

	// RVA: 0x3586408 Offset: 0x3582408 VA: 0x3586408
	public static void MobMove(Game game, List<MobSendDataLight> mobData) { }

	// RVA: 0x35864CC Offset: 0x35824CC VA: 0x35864CC
	public static void MobActionStart(Game game, MobActionStartData sendData) { }

	// RVA: 0x3586564 Offset: 0x3582564 VA: 0x3586564
	public static void MobAttack(Game game, MobAttackData sendData) { }

	// RVA: 0x35865FC Offset: 0x35825FC VA: 0x35865FC
	public static void MobAttackToMob(Game game, MobAttackData sendData) { }

	// RVA: 0x3586694 Offset: 0x3582694 VA: 0x3586694
	public static void MobSupport(Game game, MobAttackData sendData) { }

	// RVA: 0x358672C Offset: 0x358272C VA: 0x358672C
	public static void MobEventAttack(Game game, MobEventAttackData attackData) { }

	// RVA: 0x35867C4 Offset: 0x35827C4 VA: 0x35867C4
	public static void HousePetMove(Game game, List<PetSendData> petData, bool isReliable) { }

	// RVA: 0x35868C4 Offset: 0x35828C4 VA: 0x35868C4
	public static void ItemUse(Game game, int itemUuid, bool isSavingTechnique = False) { }

	// RVA: 0x358699C Offset: 0x358299C VA: 0x358699C
	public static void ItemDurationInvoke(Game game, short durationType) { }

	// RVA: 0x3586A68 Offset: 0x3582A68 VA: 0x3586A68
	public static void SetEquip(Game game, EquipData sendData) { }

	// RVA: 0x3586B00 Offset: 0x3582B00 VA: 0x3586B00
	public static void DeadEquipCheck(Game game) { }

	// RVA: 0x3586B74 Offset: 0x3582B74 VA: 0x3586B74
	public static void DungeonTrapActive(Game game, DungeonTrapDamageData sendData) { }

	// RVA: 0x3586C0C Offset: 0x3582C0C VA: 0x3586C0C
	public static void DungeonTrapAttack(Game game, DungeonTrapData sendData) { }

	// RVA: 0x3586CA4 Offset: 0x3582CA4 VA: 0x3586CA4
	public static void ItemBoxOpen(Game game, byte itemBoxId, short floorDepth) { }

	// RVA: 0x3586D78 Offset: 0x3582D78 VA: 0x3586D78
	public static void EventAbnormal(Game game, byte abnormalState, float effectTime, float resistTime, int value, byte localId, bool isForce) { }

	// RVA: 0x3586EE8 Offset: 0x3582EE8 VA: 0x3586EE8
	public static void EventDamage(Game game, int damage, byte damageId, byte state, byte flag) { }

	// RVA: 0x3586FD4 Offset: 0x3582FD4 VA: 0x3586FD4
	public static void EventMonsterDamage(Game game, EventMonsterDamageData sendData) { }

	// RVA: 0x358706C Offset: 0x358306C VA: 0x358706C
	public static void SnowballFightThrow(Game game, byte power, short angle, short height, short motionSpeed, byte ballNum) { }

	// RVA: 0x3587170 Offset: 0x3583170 VA: 0x3587170
	public static void SnowballFightReload(Game game, short reloadTime, short[] pos, byte ballNum) { }

	// RVA: 0x3587268 Offset: 0x3583268 VA: 0x3587268
	public static void SnowballFightCreate(Game game, short[] pos, byte ballNum) { }

	// RVA: 0x3587350 Offset: 0x3583350 VA: 0x3587350
	public static void SnowballFightDodge(Game game, short angle, short[] pos, byte ballNum) { }

	// RVA: 0x3587448 Offset: 0x3583448 VA: 0x3587448
	public static void SnowballFightAttack(Game game, int ballNo, int otherArchetypeId, byte ballFlag) { }

	// RVA: 0x3587528 Offset: 0x3583528 VA: 0x3587528
	public static void SnowballFightSkillAttack(Game game, int ballNo, int[] otherArchetypeIds) { }

	// RVA: 0x3587608 Offset: 0x3583608 VA: 0x3587608
	public static void SnowballFightDamage(Game game, int ballNo, int throwAvatarUuid, int damageAvatarUuid, byte flag, short[] pos) { }

	// RVA: 0x358770C Offset: 0x358370C VA: 0x358770C
	public static void SnowballFightDead(Game game, int otherArchetypeId) { }

	// RVA: 0x35877E4 Offset: 0x35837E4 VA: 0x35877E4
	public static void SnowballFightResurrection(Game game) { }

	// RVA: 0x35878B0 Offset: 0x35838B0 VA: 0x35878B0
	public static void SnowballFightGetItem(Game game, byte itemUid) { }

	// RVA: 0x358798C Offset: 0x358398C VA: 0x358798C
	public static void SnowballFightUseItem(Game game, byte itemUid) { }

	// RVA: 0x3587A68 Offset: 0x3583A68 VA: 0x3587A68
	public static void SummerThrow(Game game, byte weaponId, int harpoonNo, short[] pos, short rot) { }

	// RVA: 0x3587B78 Offset: 0x3583B78 VA: 0x3587B78
	public static void SummerAttack(Game game, byte weaponId, int harpoonNo, MobSendData targetFish) { }

	// RVA: 0x3587C80 Offset: 0x3583C80 VA: 0x3587C80
	public static void RhythmAttack(Game game, short critical, short hit, short graze, short miss) { }

	// RVA: 0x3587D6C Offset: 0x3583D6C VA: 0x3587D6C
	public static void DeadlyPoisonCheck(Game game, MobSendData mobData) { }

	// RVA: 0x3587E44 Offset: 0x3583E44 VA: 0x3587E44
	public static void CatarabomosDebuffCheck(Game game, MobSendData mobData) { }
}
