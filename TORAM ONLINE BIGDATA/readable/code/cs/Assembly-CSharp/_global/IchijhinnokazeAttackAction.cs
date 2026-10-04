// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IchijhinnokazeAttackAction : PlayerAttackBase // TypeDefIndex: 2847
{
	// Fields
	[CompilerGenerated]
	private bool <IsAvoid>k__BackingField; // 0x120
	public const int NagiTakeId = 201227000;
	public const int NagiCutoffTakeId = 201228000;
	public const int KariwatashiTakeId = 201229000;
	public const int KariwatashiChangeTakeId = 201229001;
	public const int HibariTakeId = 201230000;
	public const int HibariChangeTakeId = 201230001;
	public const int IbukiTakeId = 201231000;
	public const int IbukiChangeTakeId = 201231001;
	public const int ArahaeTakeId = 201232000;
	public const int ArahaeChangeTakeId = 201232001;
	public const int SetsunakenranKariwatashiTakeId = 201229002;
	public const int SetsunakenranIbukiTakeId = 201231002;
	public const int SetsunakenranArahaeTakeId = 201232002;
	public const int SetsunakenranHibariTakeId = 201230002;
	private float[] skillRates; // 0x128
	private int constantDamage; // 0x130
	private SkillAttackType attackType; // 0x134
	private bool isRange; // 0x138
	private float attackRange; // 0x13C
	private float attackWidth; // 0x140
	private Vector3 attackDir; // 0x144
	private IchijhinnokazeAttackAction.ActiveSkill activeSkill; // 0x150
	private IchijhinnokazeAttackAction.ActiveSkill nextSkill; // 0x154
	private IchijhinnokazeAttackAction.ActiveSkill setsunakenranActiveSkill; // 0x158
	private int shukuchiLevel; // 0x15C
	private int weirdnessOfGodLevel; // 0x160
	private bool activeNagiCutoff; // 0x164
	private PlayerActionManagerBase actorAction; // 0x168
	private GameObject attackTarget; // 0x170
	private float attackTargetSize; // 0x178
	private float attackTargetDistance; // 0x17C
	private bool forceMiss; // 0x180
	private bool isInflexibilityCountUp; // 0x181
	private byte setsunakenranDamageCount; // 0x182
	private bool changeNagiTake; // 0x183
	private SkillLinkedTake currentSetsunakenranTake; // 0x188
	private bool isSetsunaConnect; // 0x190
	private bool isMotionEndFinishingTouchBuf; // 0x191

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsEventIgnoreOther { get; }
	public override string LocalizeKey { get; }
	public IchijhinnokazeAttackAction.ActiveSkill NowActiveSkill { get; }
	public bool IsAvoid { get; set; }

	// Methods

	// RVA: 0x2292E78 Offset: 0x228EE78 VA: 0x2292E78 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2292E80 Offset: 0x228EE80 VA: 0x2292E80 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2292E88 Offset: 0x228EE88 VA: 0x2292E88 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2292E90 Offset: 0x228EE90 VA: 0x2292E90 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2292E98 Offset: 0x228EE98 VA: 0x2292E98 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2292EA0 Offset: 0x228EEA0 VA: 0x2292EA0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2292EA8 Offset: 0x228EEA8 VA: 0x2292EA8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2292EB0 Offset: 0x228EEB0 VA: 0x2292EB0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2292EB8 Offset: 0x228EEB8 VA: 0x2292EB8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2292EC0 Offset: 0x228EEC0 VA: 0x2292EC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2292EC8 Offset: 0x228EEC8 VA: 0x2292EC8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2292ED0 Offset: 0x228EED0 VA: 0x2292ED0 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2292ED8 Offset: 0x228EED8 VA: 0x2292ED8 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2292EE0 Offset: 0x228EEE0 VA: 0x2292EE0 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x2292F88 Offset: 0x228EF88 VA: 0x2292F88
	public IchijhinnokazeAttackAction.ActiveSkill get_NowActiveSkill() { }

	[CompilerGenerated]
	// RVA: 0x2292F90 Offset: 0x228EF90 VA: 0x2292F90
	public bool get_IsAvoid() { }

	[CompilerGenerated]
	// RVA: 0x2292F98 Offset: 0x228EF98 VA: 0x2292F98
	private void set_IsAvoid(bool value) { }

	// RVA: 0x2292FA4 Offset: 0x228EFA4 VA: 0x2292FA4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2293088 Offset: 0x228F088 VA: 0x2293088 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2294F04 Offset: 0x2290F04 VA: 0x2294F04 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22950F4 Offset: 0x22910F4 VA: 0x22950F4 Slot: 65
	public override void PopSkillNameLabel() { }

	// RVA: 0x229516C Offset: 0x229116C VA: 0x229516C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2295248 Offset: 0x2291248 VA: 0x2295248
	private void SkillEventNagi(CharacterActionManagerBase actorAction, int param) { }

	// RVA: 0x2295D48 Offset: 0x2291D48 VA: 0x2295D48
	private void SkillEventKariwatashi(CharacterActionManagerBase actorAction, int param) { }

	// RVA: 0x2296058 Offset: 0x2292058 VA: 0x2296058
	private void SkillEventHibari(CharacterActionManagerBase actorAction, int param) { }

	// RVA: 0x22964DC Offset: 0x22924DC VA: 0x22964DC
	private void SkillEventIbuki(CharacterActionManagerBase actorAction, int param) { }

	// RVA: 0x22968FC Offset: 0x22928FC VA: 0x22968FC
	private void SkillEventArahae(CharacterActionManagerBase actorAction, int param) { }

	// RVA: 0x2296D38 Offset: 0x2292D38 VA: 0x2296D38
	private void SkillEventSetsunakenran(CharacterActionManagerBase actorAction, int param) { }

	// RVA: 0x22979BC Offset: 0x22939BC VA: 0x22979BC Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22979EC Offset: 0x22939EC VA: 0x22979EC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2297BA4 Offset: 0x2293BA4 VA: 0x2297BA4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2297D00 Offset: 0x2293D00 VA: 0x2297D00 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2297D7C Offset: 0x2293D7C VA: 0x2297D7C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2299988 Offset: 0x2295988 VA: 0x2299988 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22999B0 Offset: 0x22959B0 VA: 0x22999B0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22999D8 Offset: 0x22959D8 VA: 0x22999D8 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2299E10 Offset: 0x2295E10 VA: 0x2299E10 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2299FB0 Offset: 0x2295FB0 VA: 0x2299FB0
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x229A148 Offset: 0x2296148 VA: 0x229A148
	public static bool CheckAvoid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x229A210 Offset: 0x2296210 VA: 0x229A210
	public static bool CheckAvoid(PlayerActionManagerBase playerAction, MobAttackBase mobAttack) { }

	// RVA: 0x2294D4C Offset: 0x2290D4C VA: 0x2294D4C
	private void InitializeNagi(PlayerActionManagerBase actorAction) { }

	// RVA: 0x22940EC Offset: 0x22900EC VA: 0x22940EC
	private void InitializeKariwatashi(PlayerActionManagerBase actorAction) { }

	// RVA: 0x2294290 Offset: 0x2290290 VA: 0x2294290
	private void InitializeHibari(PlayerActionManagerBase actorAction) { }

	// RVA: 0x229461C Offset: 0x229061C VA: 0x229461C
	private void InitializeIbuki(PlayerActionManagerBase actorAction) { }

	// RVA: 0x22949A8 Offset: 0x22909A8 VA: 0x22949A8
	private void InitializeArahae(PlayerActionManagerBase actorAction) { }

	// RVA: 0x2293C64 Offset: 0x228FC64 VA: 0x2293C64
	private void InitializeSetunakenran(PlayerActionManagerBase actorAction) { }

	// RVA: 0x22941E8 Offset: 0x22901E8 VA: 0x22941E8
	private SkillLinkedTake CreateKariwatashiTake() { }

	// RVA: 0x2294718 Offset: 0x2290718 VA: 0x2294718
	private SkillLinkedTake CreateIbukiTake() { }

	// RVA: 0x2294ABC Offset: 0x2290ABC VA: 0x2294ABC
	private SkillLinkedTake CreateArahaeTake() { }

	// RVA: 0x229438C Offset: 0x229038C VA: 0x229438C
	private SkillLinkedTake CreateHibariTake() { }

	// RVA: 0x2297DC4 Offset: 0x2293DC4 VA: 0x2297DC4
	private void CalcNagiDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22980C0 Offset: 0x22940C0 VA: 0x22980C0
	private void CalcKariwatashiDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2298434 Offset: 0x2294434 VA: 0x2298434
	private void CalcHibariDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2298760 Offset: 0x2294760 VA: 0x2298760
	private void CalcIbukiDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2298AB4 Offset: 0x2294AB4 VA: 0x2298AB4
	private void CalcArahaeDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2298DE0 Offset: 0x2294DE0 VA: 0x2298DE0
	private void CalcSetsunakenranDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x229A2F8 Offset: 0x22962F8 VA: 0x229A2F8
	private byte CreateSendSetsunakenranDamageFlag(IchijhinnokazeAttackAction.ActiveSkill activeSkill, bool hit, bool critical, bool glaze) { }

	// RVA: 0x2293928 Offset: 0x228F928 VA: 0x2293928
	private bool CheckSetunakenran(PlayerActionManagerBase actorAction) { }

	// RVA: 0x2293E28 Offset: 0x228FE28 VA: 0x2293E28
	private IchijhinnokazeAttackAction.InputDirect GetInputDirect(out float angle) { }

	// RVA: 0x2294FCC Offset: 0x2290FCC VA: 0x2294FCC
	private void AddMotionEndFinishingTouchBuf(PlayerActionManagerBase playerAction) { }

	// RVA: 0x229A328 Offset: 0x2296328 VA: 0x229A328
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x229A444 Offset: 0x2296444 VA: 0x229A444
	private void <SkillEventHibari>b__82_1() { }

	[CompilerGenerated]
	// RVA: 0x229A44C Offset: 0x229644C VA: 0x229A44C
	private void <ActionStartOthers>b__93_0(bool cancel) { }

	[CompilerGenerated]
	// RVA: 0x229A490 Offset: 0x2296490 VA: 0x229A490
	private void <InitializeSetunakenran>b__103_0(bool cancel) { }
}
