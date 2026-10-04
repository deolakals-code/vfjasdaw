// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HealAction : PlayerAttackBase // TypeDefIndex: 3670
{
	// Fields
	private int hpHeal; // 0x120
	private int baseMp; // 0x124

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

	// RVA: 0x23BF9E4 Offset: 0x23BB9E4 VA: 0x23BF9E4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BF9EC Offset: 0x23BB9EC VA: 0x23BF9EC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BF9F4 Offset: 0x23BB9F4 VA: 0x23BF9F4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BF9FC Offset: 0x23BB9FC VA: 0x23BF9FC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BFA04 Offset: 0x23BBA04 VA: 0x23BFA04 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BFA0C Offset: 0x23BBA0C VA: 0x23BFA0C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BFA14 Offset: 0x23BBA14 VA: 0x23BFA14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BFA1C Offset: 0x23BBA1C VA: 0x23BFA1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BFA24 Offset: 0x23BBA24 VA: 0x23BFA24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BFA2C Offset: 0x23BBA2C VA: 0x23BFA2C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C0058 Offset: 0x23BC058 VA: 0x23C0058 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C01B4 Offset: 0x23BC1B4 VA: 0x23C01B4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C02A0 Offset: 0x23BC2A0 VA: 0x23C02A0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C0370 Offset: 0x23BC370 VA: 0x23C0370
	public void CheckHealStock() { }

	// RVA: 0x23C0384 Offset: 0x23BC384 VA: 0x23C0384
	public void .ctor() { }
}
