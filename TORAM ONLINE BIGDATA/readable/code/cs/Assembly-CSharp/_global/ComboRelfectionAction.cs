// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ComboRelfectionAction : NormalAttackAction // TypeDefIndex: 1488
{
	// Fields
	private readonly int maxDamageCount; // 0x190
	private ItemDBData.ItemType subWeaponType; // 0x194

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsChatLog { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x205CF70 Offset: 0x2058F70 VA: 0x205CF70 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x205CF78 Offset: 0x2058F78 VA: 0x205CF78 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x205CF80 Offset: 0x2058F80 VA: 0x205CF80 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x205CF88 Offset: 0x2058F88 VA: 0x205CF88 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x205CF90 Offset: 0x2058F90 VA: 0x205CF90 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x205CF98 Offset: 0x2058F98 VA: 0x205CF98 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x205CFA0 Offset: 0x2058FA0 VA: 0x205CFA0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x205CFA8 Offset: 0x2058FA8 VA: 0x205CFA8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x205CFB0 Offset: 0x2058FB0 VA: 0x205CFB0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x205CFB8 Offset: 0x2058FB8 VA: 0x205CFB8 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x205CFC0 Offset: 0x2058FC0 VA: 0x205CFC0 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x205CFC8 Offset: 0x2058FC8 VA: 0x205CFC8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x205CFD0 Offset: 0x2058FD0 VA: 0x205CFD0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205D120 Offset: 0x2059120 VA: 0x205D120 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x205D124 Offset: 0x2059124 VA: 0x205D124 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205DFF0 Offset: 0x2059FF0 VA: 0x205DFF0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205E0EC Offset: 0x205A0EC VA: 0x205E0EC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205E294 Offset: 0x205A294 VA: 0x205E294 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x205E2A0 Offset: 0x205A2A0 VA: 0x205E2A0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20604B0 Offset: 0x205C4B0 VA: 0x20604B0
	public void .ctor() { }
}
