// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.TermEvents
public class FishingTermEventData : TermEventData // TypeDefIndex: 11255
{
	// Fields
	[CompilerGenerated]
	private int <HitInterval>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ProcessRate>k__BackingField; // 0x34

	// Properties
	public override int EventId { get; }
	public int HitInterval { get; set; }
	public int ProcessRate { get; set; }

	// Methods

	// RVA: 0x36D02A4 Offset: 0x36CC2A4 VA: 0x36D02A4
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36D02AC Offset: 0x36CC2AC VA: 0x36D02AC Slot: 8
	public override int get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x36D02B4 Offset: 0x36CC2B4 VA: 0x36D02B4
	public int get_HitInterval() { }

	[CompilerGenerated]
	// RVA: 0x36D02BC Offset: 0x36CC2BC VA: 0x36D02BC
	private void set_HitInterval(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D02C4 Offset: 0x36CC2C4 VA: 0x36D02C4
	public int get_ProcessRate() { }

	[CompilerGenerated]
	// RVA: 0x36D02CC Offset: 0x36CC2CC VA: 0x36D02CC
	private void set_ProcessRate(int value) { }

	// RVA: 0x36D02D4 Offset: 0x36CC2D4 VA: 0x36D02D4 Slot: 9
	protected override void GetBinaryParams(MemoryStream ms) { }

	// RVA: 0x36D0310 Offset: 0x36CC310 VA: 0x36D0310 Slot: 10
	protected override void SetValueParams(MemoryStream ms) { }
}
