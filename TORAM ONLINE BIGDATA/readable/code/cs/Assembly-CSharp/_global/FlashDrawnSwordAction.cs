// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlashDrawnSwordAction : PlayerAttackBase // TypeDefIndex: 2828
{
	// Fields
	private float[] skillRate; // 0x120
	private int[] fixAddDamage; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x228F0A8 Offset: 0x228B0A8 VA: 0x228F0A8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x228F0B0 Offset: 0x228B0B0 VA: 0x228F0B0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x228F0B8 Offset: 0x228B0B8 VA: 0x228F0B8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x228F0C0 Offset: 0x228B0C0 VA: 0x228F0C0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x228F0C8 Offset: 0x228B0C8 VA: 0x228F0C8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x228F0D0 Offset: 0x228B0D0 VA: 0x228F0D0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x228F0D8 Offset: 0x228B0D8 VA: 0x228F0D8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x228F0E0 Offset: 0x228B0E0 VA: 0x228F0E0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x228F0E8 Offset: 0x228B0E8 VA: 0x228F0E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x228F2F4 Offset: 0x228B2F4 VA: 0x228F2F4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228F3B8 Offset: 0x228B3B8 VA: 0x228F3B8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x228F480 Offset: 0x228B480 VA: 0x228F480 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x228F848 Offset: 0x228B848 VA: 0x228F848
	public void .ctor() { }
}
