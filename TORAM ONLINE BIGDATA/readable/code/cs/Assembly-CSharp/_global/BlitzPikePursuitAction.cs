// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlitzPikePursuitAction : PlayerAttackBase // TypeDefIndex: 2664
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private bool isAlreadyHit; // 0x128

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsSupport { get; }
	public override bool IsNoMotionTake { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public bool IsAlreadyHit { get; set; }

	// Methods

	// RVA: 0x22275DC Offset: 0x22235DC VA: 0x22275DC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x22275E4 Offset: 0x22235E4 VA: 0x22275E4 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22275EC Offset: 0x22235EC VA: 0x22275EC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22275F4 Offset: 0x22235F4 VA: 0x22275F4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22275FC Offset: 0x22235FC VA: 0x22275FC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2227604 Offset: 0x2223604 VA: 0x2227604 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x222760C Offset: 0x222360C VA: 0x222760C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2227614 Offset: 0x2223614 VA: 0x2227614 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x222761C Offset: 0x222361C VA: 0x222761C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2227624 Offset: 0x2223624 VA: 0x2227624 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x222762C Offset: 0x222362C VA: 0x222762C Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2227634 Offset: 0x2223634 VA: 0x2227634 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x222763C Offset: 0x222363C VA: 0x222763C Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2227644 Offset: 0x2223644 VA: 0x2227644 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x222764C Offset: 0x222364C VA: 0x222764C Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2227654 Offset: 0x2223654 VA: 0x2227654
	public bool get_IsAlreadyHit() { }

	// RVA: 0x222765C Offset: 0x222365C VA: 0x222765C
	public void set_IsAlreadyHit(bool value) { }

	// RVA: 0x222766C Offset: 0x222366C VA: 0x222766C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22278BC Offset: 0x22238BC VA: 0x22278BC
	public void SetEffectPos(Vector3 pos) { }

	// RVA: 0x22279D8 Offset: 0x22239D8 VA: 0x22279D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2227A9C Offset: 0x2223A9C VA: 0x2227A9C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2227C24 Offset: 0x2223C24 VA: 0x2227C24 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2227EEC Offset: 0x2223EEC VA: 0x2227EEC
	public void .ctor() { }
}
