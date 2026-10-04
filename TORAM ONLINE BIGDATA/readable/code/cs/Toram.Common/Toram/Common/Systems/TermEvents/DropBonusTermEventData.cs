// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.TermEvents
public class DropBonusTermEventData : TermEventData // TypeDefIndex: 11253
{
	// Fields
	[CompilerGenerated]
	private int <DropBonus>k__BackingField; // 0x30

	// Properties
	public override int EventId { get; }
	public int DropBonus { get; set; }

	// Methods

	// RVA: 0x36D0170 Offset: 0x36CC170 VA: 0x36D0170
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36D0180 Offset: 0x36CC180 VA: 0x36D0180 Slot: 8
	public override int get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x36D0188 Offset: 0x36CC188 VA: 0x36D0188
	public int get_DropBonus() { }

	[CompilerGenerated]
	// RVA: 0x36D0190 Offset: 0x36CC190 VA: 0x36D0190
	private void set_DropBonus(int value) { }

	// RVA: 0x36D0198 Offset: 0x36CC198 VA: 0x36D0198 Slot: 9
	protected override void GetBinaryParams(MemoryStream ms) { }

	// RVA: 0x36D01AC Offset: 0x36CC1AC VA: 0x36D01AC Slot: 10
	protected override void SetValueParams(MemoryStream ms) { }
}
