// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FireStyleAction : NinjaSkillBase // TypeDefIndex: 2910
{
	// Fields
	private int baseMp; // 0x124
	private float targetSkillRate; // 0x128
	private float rangeSkillRate; // 0x12C
	private int fixAddDamage; // 0x130
	private float range; // 0x134
	private bool change; // 0x138
	private int percent; // 0x13C
	private MobActionManagerBase mainTarget; // 0x140
	private int targetExpRegister; // 0x148
	private bool isFirstAttack; // 0x14C
	private Vector3 attackPos; // 0x150
	private int magicResistBreaker; // 0x15C
	private AbnormalData playerAbnormalData; // 0x160

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override string LocalizeKey { get; }
	public bool IsFirst { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22CC784 Offset: 0x22C8784 VA: 0x22CC784 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22CC78C Offset: 0x22C878C VA: 0x22CC78C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22CC794 Offset: 0x22C8794 VA: 0x22CC794 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22CC79C Offset: 0x22C879C VA: 0x22CC79C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22CC7A4 Offset: 0x22C87A4 VA: 0x22CC7A4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22CC7AC Offset: 0x22C87AC VA: 0x22CC7AC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22CC7B4 Offset: 0x22C87B4 VA: 0x22CC7B4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22CC7BC Offset: 0x22C87BC VA: 0x22CC7BC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22CC7C4 Offset: 0x22C87C4 VA: 0x22CC7C4 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22CC830 Offset: 0x22C8830 VA: 0x22CC830
	public bool get_IsFirst() { }

	// RVA: 0x22CC838 Offset: 0x22C8838 VA: 0x22CC838 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22CC840 Offset: 0x22C8840 VA: 0x22CC840 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CC9E8 Offset: 0x22C89E8 VA: 0x22CC9E8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22CCA00 Offset: 0x22C8A00 VA: 0x22CCA00 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22CCB84 Offset: 0x22C8B84 VA: 0x22CCB84 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CCFBC Offset: 0x22C8FBC VA: 0x22CCFBC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22CD120 Offset: 0x22C9120 VA: 0x22CD120 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22CD18C Offset: 0x22C918C VA: 0x22CD18C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22CD270 Offset: 0x22C9270 VA: 0x22CD270 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22CD870 Offset: 0x22C9870 VA: 0x22CD870
	public bool CheckRemoveIgnition(MobActionManagerBase target) { }

	// RVA: 0x22CCA2C Offset: 0x22C8A2C VA: 0x22CCA2C
	private void CreateTake() { }

	// RVA: 0x22CD8A0 Offset: 0x22C98A0 VA: 0x22CD8A0
	public void .ctor() { }
}
