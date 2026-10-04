// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class DebuffBonusDataBase : ReflectionBonusParameter // TypeDefIndex: 1744
{
	// Fields
	[CompilerGenerated]
	private float <EffectTime>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x20

	// Properties
	public float EffectTime { get; set; }
	public bool IsEnd { get; set; }

	// Methods

	// RVA: 0x20C0DC4 Offset: 0x20BCDC4 VA: 0x20C0DC4
	protected void .ctor(BonusType type, int val, bool instant) { }

	[CompilerGenerated]
	// RVA: 0x20C0E04 Offset: 0x20BCE04 VA: 0x20C0E04
	public float get_EffectTime() { }

	[CompilerGenerated]
	// RVA: 0x20C0E0C Offset: 0x20BCE0C VA: 0x20C0E0C
	protected void set_EffectTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x20C0E14 Offset: 0x20BCE14 VA: 0x20C0E14
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x20C0E1C Offset: 0x20BCE1C VA: 0x20C0E1C
	private void set_IsEnd(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update();

	// RVA: 0x20C0E28 Offset: 0x20BCE28 VA: 0x20C0E28
	public void End() { }
}
