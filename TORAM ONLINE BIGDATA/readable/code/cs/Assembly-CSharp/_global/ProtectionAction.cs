// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ProtectionAction : PlayerAttackBase // TypeDefIndex: 3726
{
	// Fields
	private int mp; // 0x120

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23D5320 Offset: 0x23D1320 VA: 0x23D5320 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D5328 Offset: 0x23D1328 VA: 0x23D5328 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D5330 Offset: 0x23D1330 VA: 0x23D5330 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D5338 Offset: 0x23D1338 VA: 0x23D5338 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D5340 Offset: 0x23D1340 VA: 0x23D5340 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D5348 Offset: 0x23D1348 VA: 0x23D5348 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D5350 Offset: 0x23D1350 VA: 0x23D5350 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D5358 Offset: 0x23D1358 VA: 0x23D5358 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D5360 Offset: 0x23D1360 VA: 0x23D5360 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D5368 Offset: 0x23D1368 VA: 0x23D5368 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D5598 Offset: 0x23D1598 VA: 0x23D5598 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D5668 Offset: 0x23D1668 VA: 0x23D5668 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D5858 Offset: 0x23D1858 VA: 0x23D5858
	public void .ctor() { }
}
