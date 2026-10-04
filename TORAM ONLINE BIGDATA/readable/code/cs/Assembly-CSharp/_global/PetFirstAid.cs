// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetFirstAid : PetSkillActionBase // TypeDefIndex: 3546
{
	// Fields
	private int cost; // 0x150

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool UseSkillEffect { get; }
	protected override int EffectTake { get; }
	protected override int HitTakeId { get; }

	// Methods

	// RVA: 0x2368D30 Offset: 0x2364D30 VA: 0x2368D30 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2368D38 Offset: 0x2364D38 VA: 0x2368D38 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2368D40 Offset: 0x2364D40 VA: 0x2368D40 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2368D48 Offset: 0x2364D48 VA: 0x2368D48 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2368D50 Offset: 0x2364D50 VA: 0x2368D50 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2368D58 Offset: 0x2364D58 VA: 0x2368D58 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2368D60 Offset: 0x2364D60 VA: 0x2368D60 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2368D68 Offset: 0x2364D68 VA: 0x2368D68 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2368D70 Offset: 0x2364D70 VA: 0x2368D70 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2368D78 Offset: 0x2364D78 VA: 0x2368D78 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2368D80 Offset: 0x2364D80 VA: 0x2368D80 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2368D88 Offset: 0x2364D88 VA: 0x2368D88 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2368D90 Offset: 0x2364D90 VA: 0x2368D90 Slot: 93
	protected override int get_EffectTake() { }

	// RVA: 0x2368D9C Offset: 0x2364D9C VA: 0x2368D9C Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2368DA4 Offset: 0x2364DA4 VA: 0x2368DA4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2368F24 Offset: 0x2364F24 VA: 0x2368F24 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2368FB8 Offset: 0x2364FB8 VA: 0x2368FB8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23691C8 Offset: 0x23651C8 VA: 0x23691C8
	public void .ctor() { }
}
