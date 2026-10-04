// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MindimageSenjuSupportAction : MindimageSenjuSkillBase // TypeDefIndex: 3713
{
	// Fields
	[CompilerGenerated]
	private bool <SendSupport>k__BackingField; // 0x130
	private SkillBufferDataBase addBuf; // 0x138
	private float supportRange; // 0x140
	private Vector3 checkPos; // 0x144

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
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
	public override bool IsNoMotionTake { get; }
	public bool SendSupport { get; set; }

	// Methods

	// RVA: 0x23CF0E0 Offset: 0x23CB0E0 VA: 0x23CF0E0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23CF0E8 Offset: 0x23CB0E8 VA: 0x23CF0E8 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x23CF0F0 Offset: 0x23CB0F0 VA: 0x23CF0F0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CF0F8 Offset: 0x23CB0F8 VA: 0x23CF0F8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CF100 Offset: 0x23CB100 VA: 0x23CF100 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CF108 Offset: 0x23CB108 VA: 0x23CF108 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CF110 Offset: 0x23CB110 VA: 0x23CF110 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CF118 Offset: 0x23CB118 VA: 0x23CF118 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CF120 Offset: 0x23CB120 VA: 0x23CF120 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CF128 Offset: 0x23CB128 VA: 0x23CF128 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CF130 Offset: 0x23CB130 VA: 0x23CF130 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CF138 Offset: 0x23CB138 VA: 0x23CF138 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23CF140 Offset: 0x23CB140 VA: 0x23CF140 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x23CF148 Offset: 0x23CB148 VA: 0x23CF148 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x23CF150 Offset: 0x23CB150 VA: 0x23CF150 Slot: 31
	public override bool get_IsNoMotionTake() { }

	[CompilerGenerated]
	// RVA: 0x23CF158 Offset: 0x23CB158 VA: 0x23CF158
	public bool get_SendSupport() { }

	[CompilerGenerated]
	// RVA: 0x23CF160 Offset: 0x23CB160 VA: 0x23CF160
	private void set_SendSupport(bool value) { }

	// RVA: 0x23CF16C Offset: 0x23CB16C VA: 0x23CF16C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CF438 Offset: 0x23CB438 VA: 0x23CF438
	private void InitializeWarCry(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CF4E0 Offset: 0x23CB4E0 VA: 0x23CF4E0
	private void InitializeHideAttack(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CF548 Offset: 0x23CB548 VA: 0x23CF548
	private void InitializeCharging(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CF800 Offset: 0x23CB800 VA: 0x23CF800
	private void InitializePhiloEclair(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CF8DC Offset: 0x23CB8DC VA: 0x23CF8DC
	private void InitializeStepReactor(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CF9B8 Offset: 0x23CB9B8 VA: 0x23CF9B8
	private void InitializeQuickAura(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CFC20 Offset: 0x23CBC20 VA: 0x23CFC20
	private void InitializeAdversityRoar(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23CFD84 Offset: 0x23CBD84 VA: 0x23CFD84
	private void InitializeHandlingerOfGodspeed(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D0068 Offset: 0x23CC068 VA: 0x23D0068
	private void InitializeGodSpearHandling(PlayerActionManagerBase playerAction, int skillId, byte skillLv) { }

	// RVA: 0x23D021C Offset: 0x23CC21C VA: 0x23D021C
	private void InitializeClearAndSerene(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D02F8 Offset: 0x23CC2F8 VA: 0x23D02F8
	private void InitializeWeirdnessOfGod(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D03D4 Offset: 0x23CC3D4 VA: 0x23D03D4
	private void InitializeGuardian(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D055C Offset: 0x23CC55C VA: 0x23D055C
	private void InitializeHolyBible(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D0638 Offset: 0x23CC638 VA: 0x23D0638
	private void InitializeChakra(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D06E0 Offset: 0x23CC6E0 VA: 0x23D06E0
	private void InitializeBreathingMethod(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D0748 Offset: 0x23CC748 VA: 0x23D0748
	private void InitializeDestroyer(PlayerActionManagerBase playerAction, byte skillLv) { }

	// RVA: 0x23D07B0 Offset: 0x23CC7B0 VA: 0x23D07B0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D07C4 Offset: 0x23CC7C4 VA: 0x23D07C4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D0B1C Offset: 0x23CCB1C VA: 0x23D0B1C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D0BD8 Offset: 0x23CCBD8 VA: 0x23D0BD8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D0DEC Offset: 0x23CCDEC VA: 0x23D0DEC Slot: 84
	public override void RecalcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23D0DF0 Offset: 0x23CCDF0 VA: 0x23D0DF0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D1994 Offset: 0x23CD994 VA: 0x23D1994 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23D1BF0 Offset: 0x23CDBF0 VA: 0x23D1BF0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23D1CBC Offset: 0x23CDCBC VA: 0x23D1CBC Slot: 51
	public override bool ActionSkillEventCheckPlaySE(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D1CC4 Offset: 0x23CDCC4 VA: 0x23D1CC4 Slot: 91
	protected override void OnInheritance() { }

	// RVA: 0x23D1CD4 Offset: 0x23CDCD4 VA: 0x23D1CD4
	public void .ctor() { }
}
