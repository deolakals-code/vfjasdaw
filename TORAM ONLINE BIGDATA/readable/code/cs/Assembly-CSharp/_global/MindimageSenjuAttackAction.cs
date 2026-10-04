// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MindimageSenjuAttackAction : MindimageSenjuSkillBase, IAbnormalStateSkill // TypeDefIndex: 2806
{
	// Fields
	private SkillAttackType attackType; // 0x130
	private SkillAttackType expType; // 0x134
	private bool isRange; // 0x138
	private float[] skillRate; // 0x140
	private int[] fixAddDamage; // 0x148
	private int addResist; // 0x150
	private float attackRange; // 0x154
	private float width; // 0x158
	private AbnormalType abnormalType; // 0x15C
	private int percent; // 0x160
	private int maxAttackCount; // 0x164
	private GameObject target; // 0x168
	private int value; // 0x170
	private bool isRangeEquipBonus; // 0x174
	private bool isRangeSkillBonus; // 0x175
	private bool isExpDefFluctuate; // 0x176
	private bool isNemesisBuf; // 0x177
	private bool isInstallation; // 0x178
	private Vector3 attackPos; // 0x17C
	private bool isFirst; // 0x188
	private Dictionary<CharacterActionManagerBase, int> targetExpList; // 0x190
	private int criticalAttackCount; // 0x198

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
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
	public override bool NoCost { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x227CEA8 Offset: 0x2278EA8 VA: 0x227CEA8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x227CEB0 Offset: 0x2278EB0 VA: 0x227CEB0 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x227CF58 Offset: 0x2278F58 VA: 0x227CF58 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x227CF60 Offset: 0x2278F60 VA: 0x227CF60 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x227CF68 Offset: 0x2278F68 VA: 0x227CF68 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x227CF70 Offset: 0x2278F70 VA: 0x227CF70 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x227CF78 Offset: 0x2278F78 VA: 0x227CF78 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x227CF80 Offset: 0x2278F80 VA: 0x227CF80 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x227CF88 Offset: 0x2278F88 VA: 0x227CF88 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x227CF90 Offset: 0x2278F90 VA: 0x227CF90 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x227CF98 Offset: 0x2278F98 VA: 0x227CF98 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x227CFA0 Offset: 0x2278FA0 VA: 0x227CFA0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x227CFA8 Offset: 0x2278FA8 VA: 0x227CFA8 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x227CFB0 Offset: 0x2278FB0 VA: 0x227CFB0 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x227CFB8 Offset: 0x2278FB8 VA: 0x227CFB8 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x227CFC0 Offset: 0x2278FC0 VA: 0x227CFC0 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x227CFC8 Offset: 0x2278FC8 VA: 0x227CFC8 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x227CFD0 Offset: 0x2278FD0 VA: 0x227CFD0 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x227CFD8 Offset: 0x2278FD8 VA: 0x227CFD8 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x227CFE0 Offset: 0x2278FE0 VA: 0x227CFE0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x227D28C Offset: 0x227928C VA: 0x227D28C
	private void InitializeSmash(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227D338 Offset: 0x2279338 VA: 0x227D338
	private void InitializeBash(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227D3E4 Offset: 0x22793E4 VA: 0x227D3E4
	private void InitializeSonicWave(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227D51C Offset: 0x227951C VA: 0x227D51C
	private void InitializeShellBreak(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227D5C8 Offset: 0x22795C8 VA: 0x227D5C8
	private void InitializeEarthBind(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227D974 Offset: 0x2279974 VA: 0x227D974
	private void InitializeHeavySmash(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227DA64 Offset: 0x2279A64 VA: 0x227DA64
	private void InitializeTryArts(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227DB08 Offset: 0x2279B08 VA: 0x227DB08
	private void InitializeChariot(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227DEC0 Offset: 0x2279EC0 VA: 0x227DEC0
	private void InitializeRush(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227DF64 Offset: 0x2279F64 VA: 0x227DF64
	private void InitializeFlashArts(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227E248 Offset: 0x227A248 VA: 0x227E248
	private void InitializeForefistPunch(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227E2EC Offset: 0x227A2EC VA: 0x227E2EC
	private void InitializeCombination(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227E390 Offset: 0x227A390 VA: 0x227E390
	private void InitializeGodHand(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227E434 Offset: 0x227A434 VA: 0x227E434
	private void InitializeProvoke(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227E49C Offset: 0x227A49C VA: 0x227E49C
	private void InitializeHolyFist(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227E504 Offset: 0x227A504 VA: 0x227E504
	private void InitializeExorcism(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227EA68 Offset: 0x227AA68 VA: 0x227EA68
	private void InitializeNemesis(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227F050 Offset: 0x227B050 VA: 0x227F050
	private void InitializeGeoImpact(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x227F2B0 Offset: 0x227B2B0 VA: 0x227F2B0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x227F2CC Offset: 0x227B2CC VA: 0x227F2CC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x227F5D8 Offset: 0x227B5D8 VA: 0x227F5D8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x227F97C Offset: 0x227B97C VA: 0x227F97C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x227FE50 Offset: 0x227BE50 VA: 0x227FE50 Slot: 84
	public override void RecalcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x227FE54 Offset: 0x227BE54 VA: 0x227FE54 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2280244 Offset: 0x227C244 VA: 0x2280244 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22802BC Offset: 0x227C2BC VA: 0x22802BC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22806A4 Offset: 0x227C6A4 VA: 0x22806A4
	private void CalcDamageChariot(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2280A2C Offset: 0x227CA2C VA: 0x2280A2C
	private void CalcDamageExorcism(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2280E88 Offset: 0x227CE88 VA: 0x2280E88
	private void CalcDamageNemesis(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2281468 Offset: 0x227D468 VA: 0x2281468
	private void CalcDamageGeoImpact(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22817D0 Offset: 0x227D7D0 VA: 0x22817D0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22819F0 Offset: 0x227D9F0 VA: 0x22819F0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2281EC8 Offset: 0x227DEC8 VA: 0x2281EC8 Slot: 89
	public override void CheckAbnormalSubEffect(AbnormalType abnormalType, GameObject actor) { }

	// RVA: 0x2281FE8 Offset: 0x227DFE8 VA: 0x2281FE8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2282074 Offset: 0x227E074 VA: 0x2282074 Slot: 51
	public override bool ActionSkillEventCheckPlaySE(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228207C Offset: 0x227E07C VA: 0x228207C Slot: 91
	protected override void OnInheritance() { }

	// RVA: 0x2282484 Offset: 0x227E484 VA: 0x2282484
	public bool CheckExpDefFluctuate(CharacterActionManagerBase target) { }

	// RVA: 0x22824F4 Offset: 0x227E4F4 VA: 0x22824F4
	public SkillId GetBaseSkillId() { }

	// RVA: 0x2282538 Offset: 0x227E538 VA: 0x2282538
	public void Attacked(PlayerActionManagerBase playerAction) { }

	// RVA: 0x22827A8 Offset: 0x227E7A8 VA: 0x22827A8
	public static void ReceiveAttackResult(byte localId) { }

	// RVA: 0x228297C Offset: 0x227E97C VA: 0x228297C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2282A0C Offset: 0x227EA0C VA: 0x2282A0C
	private bool <ActionHit>b__92_0(SkillActionBase.DamageData x) { }
}
