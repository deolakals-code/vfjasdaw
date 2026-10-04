// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AirSlideAction : PlayerAttackBase, IAbnormalStateSkill, IDualElementSkill // TypeDefIndex: 2618
{
	// Fields
	private int damageCount; // 0x120
	private float rad; // 0x124
	private float skillRateFirst; // 0x128
	private float skillRate; // 0x12C
	private Vector3 attackPosition; // 0x130
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x140
	private int fixAddDamage; // 0x148
	private int actionCount; // 0x14C
	private int blindPercent; // 0x150
	private bool isEquipCompressionGemCart; // 0x154

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsValidDualElement { get; }

	// Methods

	// RVA: 0x2213514 Offset: 0x220F514 VA: 0x2213514 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x221351C Offset: 0x220F51C VA: 0x221351C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2213524 Offset: 0x220F524 VA: 0x2213524 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x221352C Offset: 0x220F52C VA: 0x221352C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2213534 Offset: 0x220F534 VA: 0x2213534 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x221353C Offset: 0x220F53C VA: 0x221353C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2213544 Offset: 0x220F544 VA: 0x2213544 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x221354C Offset: 0x220F54C VA: 0x221354C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2213554 Offset: 0x220F554 VA: 0x2213554 Slot: 92
	public bool get_IsValidDualElement() { }

	// RVA: 0x221355C Offset: 0x220F55C VA: 0x221355C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22139F0 Offset: 0x220F9F0 VA: 0x22139F0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2213A08 Offset: 0x220FA08 VA: 0x2213A08 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2213C88 Offset: 0x220FC88 VA: 0x2213C88 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2213C9C Offset: 0x220FC9C VA: 0x2213C9C
	private void calcFirstDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22142C4 Offset: 0x22102C4 VA: 0x22142C4
	private void calcAnyDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2214834 Offset: 0x2210834 VA: 0x2214834 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2214884 Offset: 0x2210884 VA: 0x2214884 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2214984 Offset: 0x2210984 VA: 0x2214984 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2214A00 Offset: 0x2210A00 VA: 0x2214A00 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2214A64 Offset: 0x2210A64 VA: 0x2214A64
	public void .ctor() { }
}
