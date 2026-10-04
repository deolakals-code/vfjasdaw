// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NpcHealAction : PlayerAttackBase // TypeDefIndex: 3715
{
	// Fields
	private int hpHeal; // 0x120

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

	// RVA: 0x23D215C Offset: 0x23CE15C VA: 0x23D215C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D2164 Offset: 0x23CE164 VA: 0x23D2164 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D216C Offset: 0x23CE16C VA: 0x23D216C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D2174 Offset: 0x23CE174 VA: 0x23D2174 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D217C Offset: 0x23CE17C VA: 0x23D217C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D2184 Offset: 0x23CE184 VA: 0x23D2184 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D218C Offset: 0x23CE18C VA: 0x23D218C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D2194 Offset: 0x23CE194 VA: 0x23D2194 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D219C Offset: 0x23CE19C VA: 0x23D219C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D21A4 Offset: 0x23CE1A4 VA: 0x23D21A4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D2414 Offset: 0x23CE414 VA: 0x23D2414 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D2500 Offset: 0x23CE500 VA: 0x23D2500 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D25D0 Offset: 0x23CE5D0 VA: 0x23D25D0
	public void .ctor() { }
}
