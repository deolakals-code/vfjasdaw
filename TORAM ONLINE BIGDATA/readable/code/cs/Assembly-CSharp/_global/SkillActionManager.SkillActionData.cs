// Assembly: Assembly-CSharp.dll
// Namespace: 
protected class SkillActionManager.SkillActionData // TypeDefIndex: 1521
{
	// Fields
	private List<SkillActionManager.SkillActionData> children; // 0x10
	private List<SkillActionManager.DelayData> delayDataList; // 0x18
	[CompilerGenerated]
	private SkillActionManager.SkillActionData <Parent>k__BackingField; // 0x20
	[CompilerGenerated]
	private SkillActionManager.PlaceSkillData <PlaceSkillData>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PlayId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TakeId>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <HitTakeId>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <CriticalHitTakeId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <ExtensionHitTakeId>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsPlace>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x45
	[CompilerGenerated]
	private bool <IsForceEnd>k__BackingField; // 0x46
	[CompilerGenerated]
	private bool <IsTakeOver>k__BackingField; // 0x47
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x48
	[CompilerGenerated]
	private SkillActionBase <SkillAction>k__BackingField; // 0x50
	[CompilerGenerated]
	private SkillLinkedTake <SkillTake>k__BackingField; // 0x58
	[CompilerGenerated]
	private SkillDamageData <HitDamageData>k__BackingField; // 0x60

	// Properties
	public SkillActionManager.SkillActionData Parent { get; set; }
	public SkillActionManager.PlaceSkillData PlaceSkillData { get; set; }
	public int PlayId { get; set; }
	public int TakeId { get; set; }
	public int HitTakeId { get; set; }
	public int CriticalHitTakeId { get; set; }
	public int ExtensionHitTakeId { get; set; }
	public bool IsPlace { get; set; }
	public bool IsEnd { get; set; }
	public bool IsForceEnd { get; set; }
	public bool IsParentEnd { get; }
	public bool IsTakeOver { get; set; }
	public GameObject Target { get; set; }
	public SkillActionBase SkillAction { get; set; }
	public SkillLinkedTake SkillTake { get; set; }
	public SkillDamageData HitDamageData { get; set; }
	public int EndTakeId { get; }
	public List<SkillActionManager.SkillActionData> Children { get; }
	public IList<SkillActionManager.SkillActionData> ChildrenAsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2083CB8 Offset: 0x207FCB8 VA: 0x2083CB8
	public SkillActionManager.SkillActionData get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x2083CC0 Offset: 0x207FCC0 VA: 0x2083CC0
	private void set_Parent(SkillActionManager.SkillActionData value) { }

	[CompilerGenerated]
	// RVA: 0x2083CC8 Offset: 0x207FCC8 VA: 0x2083CC8
	public SkillActionManager.PlaceSkillData get_PlaceSkillData() { }

	[CompilerGenerated]
	// RVA: 0x2083CD0 Offset: 0x207FCD0 VA: 0x2083CD0
	private void set_PlaceSkillData(SkillActionManager.PlaceSkillData value) { }

	[CompilerGenerated]
	// RVA: 0x2083CD8 Offset: 0x207FCD8 VA: 0x2083CD8
	public int get_PlayId() { }

	[CompilerGenerated]
	// RVA: 0x2083CE0 Offset: 0x207FCE0 VA: 0x2083CE0
	private void set_PlayId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2083CE8 Offset: 0x207FCE8 VA: 0x2083CE8
	public int get_TakeId() { }

	[CompilerGenerated]
	// RVA: 0x2083CF0 Offset: 0x207FCF0 VA: 0x2083CF0
	private void set_TakeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2083CF8 Offset: 0x207FCF8 VA: 0x2083CF8
	public int get_HitTakeId() { }

	[CompilerGenerated]
	// RVA: 0x2083D00 Offset: 0x207FD00 VA: 0x2083D00
	public void set_HitTakeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2083D08 Offset: 0x207FD08 VA: 0x2083D08
	public int get_CriticalHitTakeId() { }

	[CompilerGenerated]
	// RVA: 0x2083D10 Offset: 0x207FD10 VA: 0x2083D10
	public void set_CriticalHitTakeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2083D18 Offset: 0x207FD18 VA: 0x2083D18
	public int get_ExtensionHitTakeId() { }

	[CompilerGenerated]
	// RVA: 0x2083D20 Offset: 0x207FD20 VA: 0x2083D20
	public void set_ExtensionHitTakeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2083D28 Offset: 0x207FD28 VA: 0x2083D28
	public bool get_IsPlace() { }

	[CompilerGenerated]
	// RVA: 0x2083D30 Offset: 0x207FD30 VA: 0x2083D30
	private void set_IsPlace(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2083D3C Offset: 0x207FD3C VA: 0x2083D3C
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x2083D44 Offset: 0x207FD44 VA: 0x2083D44
	private void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2083D50 Offset: 0x207FD50 VA: 0x2083D50
	public bool get_IsForceEnd() { }

	[CompilerGenerated]
	// RVA: 0x2083D58 Offset: 0x207FD58 VA: 0x2083D58
	private void set_IsForceEnd(bool value) { }

	// RVA: 0x2083D64 Offset: 0x207FD64 VA: 0x2083D64
	public bool get_IsParentEnd() { }

	[CompilerGenerated]
	// RVA: 0x2083D80 Offset: 0x207FD80 VA: 0x2083D80
	public bool get_IsTakeOver() { }

	[CompilerGenerated]
	// RVA: 0x2083D88 Offset: 0x207FD88 VA: 0x2083D88
	private void set_IsTakeOver(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2083D94 Offset: 0x207FD94 VA: 0x2083D94
	public GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x2083D9C Offset: 0x207FD9C VA: 0x2083D9C
	private void set_Target(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2083DA4 Offset: 0x207FDA4 VA: 0x2083DA4
	public SkillActionBase get_SkillAction() { }

	[CompilerGenerated]
	// RVA: 0x2083DAC Offset: 0x207FDAC VA: 0x2083DAC
	private void set_SkillAction(SkillActionBase value) { }

	[CompilerGenerated]
	// RVA: 0x2083DB4 Offset: 0x207FDB4 VA: 0x2083DB4
	public SkillLinkedTake get_SkillTake() { }

	[CompilerGenerated]
	// RVA: 0x2083DBC Offset: 0x207FDBC VA: 0x2083DBC
	private void set_SkillTake(SkillLinkedTake value) { }

	[CompilerGenerated]
	// RVA: 0x2083DC4 Offset: 0x207FDC4 VA: 0x2083DC4
	public SkillDamageData get_HitDamageData() { }

	[CompilerGenerated]
	// RVA: 0x2083DCC Offset: 0x207FDCC VA: 0x2083DCC
	private void set_HitDamageData(SkillDamageData value) { }

	// RVA: 0x2083DD4 Offset: 0x207FDD4 VA: 0x2083DD4
	public int get_EndTakeId() { }

	// RVA: 0x2083DEC Offset: 0x207FDEC VA: 0x2083DEC
	public List<SkillActionManager.SkillActionData> get_Children() { }

	// RVA: 0x2083DF4 Offset: 0x207FDF4 VA: 0x2083DF4
	public IList<SkillActionManager.SkillActionData> get_ChildrenAsReadOnly() { }

	// RVA: 0x2083E44 Offset: 0x207FE44 VA: 0x2083E44
	public void .ctor(int playId, int takeId, GameObject target, SkillActionBase skill, SkillLinkedTake skillTake) { }

	// RVA: 0x2083F24 Offset: 0x207FF24 VA: 0x2083F24
	public void .ctor(int playid, int takeid, GameObject target, SkillActionBase skill, SkillLinkedTake skillTake, bool isPlace, Vector3 placePos) { }

	// RVA: 0x208412C Offset: 0x208012C VA: 0x208412C
	public void End() { }

	// RVA: 0x2084138 Offset: 0x2080138 VA: 0x2084138
	public void ForceEnd() { }

	// RVA: 0x2084144 Offset: 0x2080144 VA: 0x2084144
	public void TakeOver(SkillActionManager.SkillActionData skillData) { }

	// RVA: 0x20845F0 Offset: 0x20805F0 VA: 0x20845F0
	public bool NextSkillTake() { }

	// RVA: 0x208462C Offset: 0x208062C VA: 0x208462C
	public void AddChild(SkillActionManager.SkillActionData child) { }

	// RVA: 0x2084700 Offset: 0x2080700 VA: 0x2084700
	public void RemoveChild(SkillActionManager.SkillActionData child) { }

	// RVA: 0x208476C Offset: 0x208076C VA: 0x208476C
	public void AddDelayData(SkillActionManager.DelayData delayData) { }

	// RVA: 0x2084884 Offset: 0x2080884 VA: 0x2084884
	public void RemoveDelayData(SkillActionManager.DelayData delayData) { }

	// RVA: 0x20848F8 Offset: 0x20808F8 VA: 0x20848F8
	public void ClearDelayData() { }

	// RVA: 0x2084AC4 Offset: 0x2080AC4 VA: 0x2084AC4
	public void SetHitDamage(SkillDamageData damageData) { }

	// RVA: 0x2084ACC Offset: 0x2080ACC VA: 0x2084ACC
	public bool CheckSameSkill(SkillActionBase comparisonSkill) { }
}
