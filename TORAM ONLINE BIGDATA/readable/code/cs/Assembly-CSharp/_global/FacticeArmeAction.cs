// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class FacticeArmeAction : PlayerAttackBase // TypeDefIndex: 3034
{
	// Fields
	private float skillRate; // 0x120
	private int constantDamage; // 0x124
	private FacticeArmeAction.TYPE type; // 0x128
	private PlayerActionManagerBase playerAction; // 0x130
	private Transform mainTarget; // 0x138
	private bool canBackStep; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x230BBC0 Offset: 0x2307BC0 VA: 0x230BBC0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230BBC8 Offset: 0x2307BC8 VA: 0x230BBC8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230BBD0 Offset: 0x2307BD0 VA: 0x230BBD0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230BBD8 Offset: 0x2307BD8 VA: 0x230BBD8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230BBE0 Offset: 0x2307BE0 VA: 0x230BBE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230BBE8 Offset: 0x2307BE8 VA: 0x230BBE8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230BBF0 Offset: 0x2307BF0 VA: 0x230BBF0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230BBF8 Offset: 0x2307BF8 VA: 0x230BBF8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230BC00 Offset: 0x2307C00 VA: 0x230BC00 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230BED8 Offset: 0x2307ED8 VA: 0x230BED8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230BEF0 Offset: 0x2307EF0 VA: 0x230BEF0 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x230C698 Offset: 0x2308698 VA: 0x230C698 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x230C6CC Offset: 0x23086CC VA: 0x230C6CC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x230BF14 Offset: 0x2307F14 VA: 0x230BF14
	private void CreateTake(GameObject target) { }

	// RVA: 0x230C718 Offset: 0x2308718 VA: 0x230C718 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230D058 Offset: 0x2309058 VA: 0x230D058 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x230D248 Offset: 0x2309248 VA: 0x230D248 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230D6EC Offset: 0x23096EC VA: 0x230D6EC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x230D6FC Offset: 0x23096FC VA: 0x230D6FC
	private void <CreateTake>b__29_0(bool cancel) { }

	[CompilerGenerated]
	// RVA: 0x230D740 Offset: 0x2309740 VA: 0x230D740
	private void <CreateTake>b__29_1() { }

	[CompilerGenerated]
	// RVA: 0x230D784 Offset: 0x2309784 VA: 0x230D784
	private void <CreateTake>b__29_2() { }

	[CompilerGenerated]
	// RVA: 0x230D7C8 Offset: 0x23097C8 VA: 0x230D7C8
	private void <CreateTake>b__29_3(bool cancel) { }
}
