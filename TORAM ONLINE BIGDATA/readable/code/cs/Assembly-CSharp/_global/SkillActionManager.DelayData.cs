// Assembly: Assembly-CSharp.dll
// Namespace: 
protected class SkillActionManager.DelayData // TypeDefIndex: 1522
{
	// Fields
	[CompilerGenerated]
	private SkillActionManager.SkillActionData <ParentSkillData>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <HitTakeId>k__BackingField; // 0x18
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private SkillDamageData <HitDamageData>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <Interval>k__BackingField; // 0x30
	public float intervalTime; // 0x34

	// Properties
	public SkillActionManager.SkillActionData ParentSkillData { get; set; }
	public int HitTakeId { get; set; }
	public GameObject Target { get; set; }
	public SkillDamageData HitDamageData { get; set; }
	public float Interval { get; set; }
	public bool IsRange { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2084B68 Offset: 0x2080B68 VA: 0x2084B68
	public SkillActionManager.SkillActionData get_ParentSkillData() { }

	[CompilerGenerated]
	// RVA: 0x2084B70 Offset: 0x2080B70 VA: 0x2084B70
	private void set_ParentSkillData(SkillActionManager.SkillActionData value) { }

	[CompilerGenerated]
	// RVA: 0x2084B78 Offset: 0x2080B78 VA: 0x2084B78
	public int get_HitTakeId() { }

	[CompilerGenerated]
	// RVA: 0x2084B80 Offset: 0x2080B80 VA: 0x2084B80
	private void set_HitTakeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2084B88 Offset: 0x2080B88 VA: 0x2084B88
	public GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x2084B90 Offset: 0x2080B90 VA: 0x2084B90
	private void set_Target(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2084B98 Offset: 0x2080B98 VA: 0x2084B98
	public SkillDamageData get_HitDamageData() { }

	[CompilerGenerated]
	// RVA: 0x2084BA0 Offset: 0x2080BA0 VA: 0x2084BA0
	private void set_HitDamageData(SkillDamageData value) { }

	[CompilerGenerated]
	// RVA: 0x2084BA8 Offset: 0x2080BA8 VA: 0x2084BA8
	public float get_Interval() { }

	[CompilerGenerated]
	// RVA: 0x2084BB0 Offset: 0x2080BB0 VA: 0x2084BB0
	private void set_Interval(float value) { }

	// RVA: 0x2084BB8 Offset: 0x2080BB8 VA: 0x2084BB8
	public bool get_IsRange() { }

	// RVA: 0x2084BE4 Offset: 0x2080BE4 VA: 0x2084BE4
	public void .ctor(SkillActionManager.SkillActionData parentSkillData, int hitTakeId, float interval, GameObject target, SkillDamageData damageData) { }

	// RVA: 0x20845E0 Offset: 0x20805E0 VA: 0x20845E0
	public void OnTakeOver(SkillActionManager.SkillActionData skillData) { }

	// RVA: 0x2084A88 Offset: 0x2080A88 VA: 0x2084A88
	public void ClearParent() { }

	// RVA: 0x2084C60 Offset: 0x2080C60 VA: 0x2084C60
	public bool ForwardInterval() { }

	// RVA: 0x2084CA8 Offset: 0x2080CA8 VA: 0x2084CA8
	public bool NextDamage() { }
}
