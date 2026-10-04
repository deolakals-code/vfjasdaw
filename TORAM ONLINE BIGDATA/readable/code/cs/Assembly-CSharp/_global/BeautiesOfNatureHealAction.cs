// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BeautiesOfNatureHealAction : PlayerAttackBase // TypeDefIndex: 3620
{
	// Fields
	private float healRange; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x23AFF30 Offset: 0x23ABF30 VA: 0x23AFF30 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23AFF38 Offset: 0x23ABF38 VA: 0x23AFF38 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23AFF40 Offset: 0x23ABF40 VA: 0x23AFF40 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x23AFF48 Offset: 0x23ABF48 VA: 0x23AFF48 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23AFF50 Offset: 0x23ABF50 VA: 0x23AFF50 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23AFF58 Offset: 0x23ABF58 VA: 0x23AFF58 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23AFF60 Offset: 0x23ABF60 VA: 0x23AFF60 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23AFF68 Offset: 0x23ABF68 VA: 0x23AFF68 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23AFF70 Offset: 0x23ABF70 VA: 0x23AFF70 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23AFF78 Offset: 0x23ABF78 VA: 0x23AFF78 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23AFF80 Offset: 0x23ABF80 VA: 0x23AFF80 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23AFF88 Offset: 0x23ABF88 VA: 0x23AFF88 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23AFF90 Offset: 0x23ABF90 VA: 0x23AFF90 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x23AFF98 Offset: 0x23ABF98 VA: 0x23AFF98 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B0038 Offset: 0x23AC038 VA: 0x23B0038 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B0764 Offset: 0x23AC764 VA: 0x23B0764 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B0768 Offset: 0x23AC768 VA: 0x23B0768 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B0774 Offset: 0x23AC774 VA: 0x23B0774 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23B0800 Offset: 0x23AC800 VA: 0x23B0800
	public void .ctor() { }
}
