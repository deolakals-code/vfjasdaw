// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ArrowSharpeningAction : PlayerAttackBase // TypeDefIndex: 2935
{
	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x22D9124 Offset: 0x22D5124 VA: 0x22D9124 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22D912C Offset: 0x22D512C VA: 0x22D912C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D9134 Offset: 0x22D5134 VA: 0x22D9134 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D913C Offset: 0x22D513C VA: 0x22D913C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D9144 Offset: 0x22D5144 VA: 0x22D9144 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D914C Offset: 0x22D514C VA: 0x22D914C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D9154 Offset: 0x22D5154 VA: 0x22D9154 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D915C Offset: 0x22D515C VA: 0x22D915C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D9164 Offset: 0x22D5164 VA: 0x22D9164 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D916C Offset: 0x22D516C VA: 0x22D916C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D928C Offset: 0x22D528C VA: 0x22D928C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D9344 Offset: 0x22D5344 VA: 0x22D9344 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D949C Offset: 0x22D549C VA: 0x22D949C
	public void .ctor() { }
}
