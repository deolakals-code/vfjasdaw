// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameTurnEndEvent : EventSubBase // TypeDefIndex: 12837
{
	// Fields
	[CompilerGenerated]
	private CardGameTurnCardData[] <AllTurnData>k__BackingField; // 0x20
	[CompilerGenerated]
	private CardGameTurnTableData <TableData>k__BackingField; // 0x28

	// Properties
	public CardGameTurnCardData[] AllTurnData { get; set; }
	public CardGameTurnTableData TableData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3665448 Offset: 0x3661448 VA: 0x3665448
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3665450 Offset: 0x3661450 VA: 0x3665450
	public CardGameTurnCardData[] get_AllTurnData() { }

	[CompilerGenerated]
	// RVA: 0x3665458 Offset: 0x3661458 VA: 0x3665458
	public void set_AllTurnData(CardGameTurnCardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3665460 Offset: 0x3661460 VA: 0x3665460
	public CardGameTurnTableData get_TableData() { }

	[CompilerGenerated]
	// RVA: 0x3665468 Offset: 0x3661468 VA: 0x3665468
	public void set_TableData(CardGameTurnTableData value) { }

	// RVA: 0x3665470 Offset: 0x3661470 VA: 0x3665470 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3665478 Offset: 0x3661478 VA: 0x3665478 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3665480 Offset: 0x3661480 VA: 0x3665480 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36656AC Offset: 0x36616AC VA: 0x36656AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
