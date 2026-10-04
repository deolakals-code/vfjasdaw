// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DualBringerAction : PlayerAttackBase // TypeDefIndex: 3639
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23B6144 Offset: 0x23B2144 VA: 0x23B6144 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B614C Offset: 0x23B214C VA: 0x23B614C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B6154 Offset: 0x23B2154 VA: 0x23B6154 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B615C Offset: 0x23B215C VA: 0x23B615C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B6164 Offset: 0x23B2164 VA: 0x23B6164 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B616C Offset: 0x23B216C VA: 0x23B616C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B6174 Offset: 0x23B2174 VA: 0x23B6174 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B617C Offset: 0x23B217C VA: 0x23B617C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B6184 Offset: 0x23B2184 VA: 0x23B6184 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B618C Offset: 0x23B218C VA: 0x23B618C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B62D0 Offset: 0x23B22D0 VA: 0x23B62D0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B6440 Offset: 0x23B2440 VA: 0x23B6440 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B6508 Offset: 0x23B2508 VA: 0x23B6508
	public static bool TryGetElemntType(PlayerStatusBase status, out ElementType elementType) { }

	// RVA: 0x23B65B4 Offset: 0x23B25B4 VA: 0x23B65B4
	public void .ctor() { }
}
