// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class NemesisAction : PlayerAttackBase, IInheritMindimageSenju, IDualElementSkill // TypeDefIndex: 2958
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsValidDualElement>k__BackingField; // 0x121
	private float targetSkillRate; // 0x124
	private float placeSkillRate; // 0x128
	private float fixAddDamage; // 0x12C
	private float placeFixDamage; // 0x130
	private bool isFirst; // 0x134
	private Transform mainTarget; // 0x138
	private bool isInstallation; // 0x140
	private float rad; // 0x144
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x148
	private int criticalAttackCount; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsFirst { get; }
	public bool IsInheritance { get; set; }
	public bool IsValidDualElement { get; set; }

	// Methods

	// RVA: 0x22E5C38 Offset: 0x22E1C38 VA: 0x22E5C38 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E5C4C Offset: 0x22E1C4C VA: 0x22E5C4C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E5C54 Offset: 0x22E1C54 VA: 0x22E5C54 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E5C5C Offset: 0x22E1C5C VA: 0x22E5C5C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E5C64 Offset: 0x22E1C64 VA: 0x22E5C64 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E5C6C Offset: 0x22E1C6C VA: 0x22E5C6C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E5C74 Offset: 0x22E1C74 VA: 0x22E5C74 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E5C7C Offset: 0x22E1C7C VA: 0x22E5C7C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E5C84 Offset: 0x22E1C84 VA: 0x22E5C84
	public bool get_IsFirst() { }

	[CompilerGenerated]
	// RVA: 0x22E5C8C Offset: 0x22E1C8C VA: 0x22E5C8C Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x22E5C94 Offset: 0x22E1C94 VA: 0x22E5C94
	private void set_IsInheritance(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22E5CA0 Offset: 0x22E1CA0 VA: 0x22E5CA0 Slot: 93
	public bool get_IsValidDualElement() { }

	[CompilerGenerated]
	// RVA: 0x22E5CA8 Offset: 0x22E1CA8 VA: 0x22E5CA8
	private void set_IsValidDualElement(bool value) { }

	// RVA: 0x22E5CB4 Offset: 0x22E1CB4 VA: 0x22E5CB4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E5E00 Offset: 0x22E1E00 VA: 0x22E5E00 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E5ED8 Offset: 0x22E1ED8 VA: 0x22E5ED8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22E6044 Offset: 0x22E2044 VA: 0x22E6044 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E63D4 Offset: 0x22E23D4 VA: 0x22E63D4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E6598 Offset: 0x22E2598 VA: 0x22E6598 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E6BE8 Offset: 0x22E2BE8 VA: 0x22E6BE8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22E6D20 Offset: 0x22E2D20 VA: 0x22E6D20 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22E6D8C Offset: 0x22E2D8C VA: 0x22E6D8C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E6F80 Offset: 0x22E2F80 VA: 0x22E6F80 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22E6384 Offset: 0x22E2384 VA: 0x22E6384
	private bool CheckNemesisBuf(PlayerActionManagerBase playerAction, out SkillBufferDataBase buf) { }

	// RVA: 0x22E5F24 Offset: 0x22E1F24 VA: 0x22E5F24
	private void CreateCurrentTake() { }

	// RVA: 0x22E7148 Offset: 0x22E3148 VA: 0x22E7148 Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22E7154 Offset: 0x22E3154 VA: 0x22E7154
	public static void Damaged(PlayerActionManagerBase playerAction, GameObject target, SkillDamageData damageData) { }

	// RVA: 0x22E7254 Offset: 0x22E3254 VA: 0x22E7254
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x22E72FC Offset: 0x22E32FC VA: 0x22E72FC
	private bool <ActionHit>b__44_0(SkillActionBase.DamageData x) { }
}
