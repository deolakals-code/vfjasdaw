// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BlackKnightAbnormalManager.AbnormalData // TypeDefIndex: 4145
{
	// Fields
	[CompilerGenerated]
	private AbnormalType <AbnormalType>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <EffectTime>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <ResistTime>k__BackingField; // 0x18
	private Action callBack; // 0x20

	// Properties
	public AbnormalType AbnormalType { get; set; }
	public float EffectTime { get; set; }
	public float ResistTime { get; set; }
	public bool IsEffectEnd { get; }
	public bool IsEnd { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2491994 Offset: 0x248D994 VA: 0x2491994
	public AbnormalType get_AbnormalType() { }

	[CompilerGenerated]
	// RVA: 0x249199C Offset: 0x248D99C VA: 0x249199C
	private void set_AbnormalType(AbnormalType value) { }

	[CompilerGenerated]
	// RVA: 0x24919A4 Offset: 0x248D9A4 VA: 0x24919A4
	public float get_EffectTime() { }

	[CompilerGenerated]
	// RVA: 0x24919AC Offset: 0x248D9AC VA: 0x24919AC
	private void set_EffectTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x24919B4 Offset: 0x248D9B4 VA: 0x24919B4
	public float get_ResistTime() { }

	[CompilerGenerated]
	// RVA: 0x24919BC Offset: 0x248D9BC VA: 0x24919BC
	private void set_ResistTime(float value) { }

	// RVA: 0x24918C8 Offset: 0x248D8C8 VA: 0x24918C8
	public bool get_IsEffectEnd() { }

	// RVA: 0x24915DC Offset: 0x248D5DC VA: 0x24915DC
	public bool get_IsEnd() { }

	// RVA: 0x24917B0 Offset: 0x248D7B0 VA: 0x24917B0
	public void .ctor(AbnormalType type, float effectTime, float resistTime, Action callBack) { }

	// RVA: 0x2491568 Offset: 0x248D568 VA: 0x2491568
	public void Update() { }

	// RVA: 0x2491954 Offset: 0x248D954 VA: 0x2491954
	public void EffectEnd() { }
}
