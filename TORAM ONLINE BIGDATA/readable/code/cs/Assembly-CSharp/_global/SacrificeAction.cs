// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SacrificeAction : PlayerAttackBase // TypeDefIndex: 2610
{
	// Fields
	private float skillRate; // 0x120
	private int stable; // 0x124
	private int consumptionHp; // 0x128
	private int consumptionHpRate; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPayHp { get; }

	// Methods

	// RVA: 0x220F630 Offset: 0x220B630 VA: 0x220F630 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220F638 Offset: 0x220B638 VA: 0x220F638 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x220F640 Offset: 0x220B640 VA: 0x220F640 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220F648 Offset: 0x220B648 VA: 0x220F648 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220F650 Offset: 0x220B650 VA: 0x220F650 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220F658 Offset: 0x220B658 VA: 0x220F658 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x220F660 Offset: 0x220B660 VA: 0x220F660 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x220F668 Offset: 0x220B668 VA: 0x220F668 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x220F670 Offset: 0x220B670 VA: 0x220F670 Slot: 26
	public override bool get_IsPayHp() { }

	// RVA: 0x220F678 Offset: 0x220B678 VA: 0x220F678 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220F8E4 Offset: 0x220B8E4 VA: 0x220F8E4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220FA58 Offset: 0x220BA58 VA: 0x220FA58 Slot: 61
	public override bool CheckPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220FD58 Offset: 0x220BD58 VA: 0x220FD58 Slot: 62
	public override void StrengthPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220FF30 Offset: 0x220BF30 VA: 0x220FF30 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220FFF4 Offset: 0x220BFF4 VA: 0x220FFF4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22105CC Offset: 0x220C5CC VA: 0x22105CC
	public void .ctor() { }
}
