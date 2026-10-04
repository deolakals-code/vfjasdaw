// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetChargeAction : PlayerAttackBase // TypeDefIndex: 3720
{
	// Fields
	private int mpRecovery; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23D360C Offset: 0x23CF60C VA: 0x23D360C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D3614 Offset: 0x23CF614 VA: 0x23D3614 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D361C Offset: 0x23CF61C VA: 0x23D361C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D3624 Offset: 0x23CF624 VA: 0x23D3624 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D362C Offset: 0x23CF62C VA: 0x23D362C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D3634 Offset: 0x23CF634 VA: 0x23D3634 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D363C Offset: 0x23CF63C VA: 0x23D363C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D3644 Offset: 0x23CF644 VA: 0x23D3644 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D364C Offset: 0x23CF64C VA: 0x23D364C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D3654 Offset: 0x23CF654 VA: 0x23D3654 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D381C Offset: 0x23CF81C VA: 0x23D381C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D38EC Offset: 0x23CF8EC VA: 0x23D38EC
	public void .ctor() { }
}
