// Assembly: Assembly-CSharp.dll
// Namespace: 
public class P_DeffenceAction : PlayerAttackBase // TypeDefIndex: 3729
{
	// Fields
	private bool isCancel; // 0x120
	private bool isPop; // 0x121

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override string LocalizeKey { get; }
	protected override bool IsMotionSpeedVariable { get; }

	// Methods

	// RVA: 0x23D632C Offset: 0x23D232C VA: 0x23D632C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D6334 Offset: 0x23D2334 VA: 0x23D6334 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D633C Offset: 0x23D233C VA: 0x23D633C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D6344 Offset: 0x23D2344 VA: 0x23D6344 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D634C Offset: 0x23D234C VA: 0x23D634C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D6354 Offset: 0x23D2354 VA: 0x23D6354 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D635C Offset: 0x23D235C VA: 0x23D635C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D6364 Offset: 0x23D2364 VA: 0x23D6364 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D636C Offset: 0x23D236C VA: 0x23D636C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D6374 Offset: 0x23D2374 VA: 0x23D6374 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x23D63E0 Offset: 0x23D23E0 VA: 0x23D63E0 Slot: 74
	protected override bool get_IsMotionSpeedVariable() { }

	// RVA: 0x23D63E8 Offset: 0x23D23E8 VA: 0x23D63E8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D647C Offset: 0x23D247C VA: 0x23D647C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D6510 Offset: 0x23D2510 VA: 0x23D6510 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D6A50 Offset: 0x23D2A50 VA: 0x23D6A50 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D6B30 Offset: 0x23D2B30 VA: 0x23D6B30 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23D6CAC Offset: 0x23D2CAC VA: 0x23D6CAC Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D6DD4 Offset: 0x23D2DD4 VA: 0x23D6DD4
	public void .ctor() { }
}
