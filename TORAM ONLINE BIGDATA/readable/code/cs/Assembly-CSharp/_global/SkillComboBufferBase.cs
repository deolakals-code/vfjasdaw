// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SkillComboBufferBase // TypeDefIndex: 3576
{
	// Fields
	[CompilerGenerated]
	private float <LeftTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x14

	// Properties
	public abstract SkillComboType Type { get; }
	public float LeftTime { get; set; }
	public bool IsEnd { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SkillComboType get_Type();

	[CompilerGenerated]
	// RVA: 0x238F5FC Offset: 0x238B5FC VA: 0x238F5FC
	public float get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x238F604 Offset: 0x238B604 VA: 0x238F604
	protected void set_LeftTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x238F60C Offset: 0x238B60C VA: 0x238F60C
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x238F614 Offset: 0x238B614 VA: 0x238F614
	protected void set_IsEnd(bool value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Update();

	// RVA: 0x238F5A4 Offset: 0x238B5A4 VA: 0x238F5A4
	protected void .ctor() { }
}
