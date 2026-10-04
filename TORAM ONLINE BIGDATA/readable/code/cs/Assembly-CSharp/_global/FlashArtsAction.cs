// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlashArtsAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 2801
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int maxAttackCount; // 0x12C
	private GameObject target; // 0x130
	private Vector3 attackDir; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsInheritance { get; set; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x227AFD4 Offset: 0x2276FD4 VA: 0x227AFD4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x227AFDC Offset: 0x2276FDC VA: 0x227AFDC Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x227AFE4 Offset: 0x2276FE4 VA: 0x227AFE4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x227AFEC Offset: 0x2276FEC VA: 0x227AFEC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x227AFF4 Offset: 0x2276FF4 VA: 0x227AFF4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x227AFFC Offset: 0x2276FFC VA: 0x227AFFC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x227B004 Offset: 0x2277004 VA: 0x227B004 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x227B00C Offset: 0x227700C VA: 0x227B00C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x227B014 Offset: 0x2277014 VA: 0x227B014 Slot: 23
	public override int get_BaseMp() { }

	[CompilerGenerated]
	// RVA: 0x227B01C Offset: 0x227701C VA: 0x227B01C Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x227B024 Offset: 0x2277024 VA: 0x227B024
	private void set_IsInheritance(bool value) { }

	// RVA: 0x227B030 Offset: 0x2277030 VA: 0x227B030 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x227B038 Offset: 0x2277038 VA: 0x227B038 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x227B040 Offset: 0x2277040 VA: 0x227B040 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x227B570 Offset: 0x2277570 VA: 0x227B570 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x227B880 Offset: 0x2277880 VA: 0x227B880 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x227BBA4 Offset: 0x2277BA4 VA: 0x227BBA4 Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x227BD9C Offset: 0x2277D9C VA: 0x227BD9C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x227C03C Offset: 0x227803C VA: 0x227C03C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x227B6F8 Offset: 0x22776F8 VA: 0x227B6F8
	private void UpdateAttackDirection(Transform actar) { }

	// RVA: 0x227C380 Offset: 0x2278380 VA: 0x227C380 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x227C38C Offset: 0x227838C VA: 0x227C38C
	public void .ctor() { }
}
