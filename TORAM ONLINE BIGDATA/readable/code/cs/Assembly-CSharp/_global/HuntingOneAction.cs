// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneAction : PlayerAttackBase // TypeDefIndex: 3682
{
	// Fields
	private int mp; // 0x120

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

	// RVA: 0x23C4570 Offset: 0x23C0570 VA: 0x23C4570 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C4578 Offset: 0x23C0578 VA: 0x23C4578 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C4580 Offset: 0x23C0580 VA: 0x23C4580 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C4588 Offset: 0x23C0588 VA: 0x23C4588 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C4590 Offset: 0x23C0590 VA: 0x23C4590 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C4598 Offset: 0x23C0598 VA: 0x23C4598 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C45A0 Offset: 0x23C05A0 VA: 0x23C45A0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C45A8 Offset: 0x23C05A8 VA: 0x23C45A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C45B0 Offset: 0x23C05B0 VA: 0x23C45B0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C45B8 Offset: 0x23C05B8 VA: 0x23C45B8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C4718 Offset: 0x23C0718 VA: 0x23C4718
	public static Vector3 CenterShiftPos(Transform transform) { }

	// RVA: 0x23C4A5C Offset: 0x23C0A5C VA: 0x23C4A5C
	public static void UpdateHuntingOneBuf(PlayerActionManagerBase actorActionManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x23C4C88 Offset: 0x23C0C88 VA: 0x23C4C88 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C4D18 Offset: 0x23C0D18 VA: 0x23C4D18
	public void .ctor() { }
}
