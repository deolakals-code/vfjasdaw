// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CollectQigongAction : PlayerAttackBase // TypeDefIndex: 3630
{
	// Fields
	private int mp; // 0x120

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
	public override bool IsOverMp { get; }

	// Methods

	// RVA: 0x23B3B10 Offset: 0x23AFB10 VA: 0x23B3B10 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B3B18 Offset: 0x23AFB18 VA: 0x23B3B18 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B3B20 Offset: 0x23AFB20 VA: 0x23B3B20 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B3B28 Offset: 0x23AFB28 VA: 0x23B3B28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B3B30 Offset: 0x23AFB30 VA: 0x23B3B30 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B3B38 Offset: 0x23AFB38 VA: 0x23B3B38 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B3B40 Offset: 0x23AFB40 VA: 0x23B3B40 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B3B48 Offset: 0x23AFB48 VA: 0x23B3B48 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B3B50 Offset: 0x23AFB50 VA: 0x23B3B50 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B3B58 Offset: 0x23AFB58 VA: 0x23B3B58 Slot: 24
	public override bool get_IsOverMp() { }

	// RVA: 0x23B3B60 Offset: 0x23AFB60 VA: 0x23B3B60 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B3D9C Offset: 0x23AFD9C VA: 0x23B3D9C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B3CBC Offset: 0x23AFCBC VA: 0x23B3CBC
	private void calcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23B3E6C Offset: 0x23AFE6C VA: 0x23B3E6C
	public void .ctor() { }
}
