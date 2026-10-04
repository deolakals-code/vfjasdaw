// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlashOfTheWarGodAction : PlayerAttackBase // TypeDefIndex: 2932
{
	// Fields
	private float skillRate; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x22D7BB0 Offset: 0x22D3BB0 VA: 0x22D7BB0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D7BB8 Offset: 0x22D3BB8 VA: 0x22D7BB8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D7BC0 Offset: 0x22D3BC0 VA: 0x22D7BC0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D7BC8 Offset: 0x22D3BC8 VA: 0x22D7BC8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D7BD0 Offset: 0x22D3BD0 VA: 0x22D7BD0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D7BD8 Offset: 0x22D3BD8 VA: 0x22D7BD8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D7BE0 Offset: 0x22D3BE0 VA: 0x22D7BE0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D7BE8 Offset: 0x22D3BE8 VA: 0x22D7BE8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D7BF0 Offset: 0x22D3BF0 VA: 0x22D7BF0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D7D28 Offset: 0x22D3D28 VA: 0x22D7D28 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D7DE4 Offset: 0x22D3DE4 VA: 0x22D7DE4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22D818C Offset: 0x22D418C VA: 0x22D818C
	public void .ctor() { }
}
