// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameTurnEndLastChanceEvent : EventSubBase // TypeDefIndex: 12834
{
	// Fields
	[CompilerGenerated]
	private CardGameTurnCardData[] <AllTurnData>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <LastChanceSelector>k__BackingField; // 0x28
	[CompilerGenerated]
	private CardGameTurnTableData <TableData>k__BackingField; // 0x30

	// Properties
	public CardGameTurnCardData[] AllTurnData { get; set; }
	public bool LastChanceSelector { get; set; }
	public CardGameTurnTableData TableData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36648F0 Offset: 0x36608F0 VA: 0x36648F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36648F8 Offset: 0x36608F8 VA: 0x36648F8
	public CardGameTurnCardData[] get_AllTurnData() { }

	[CompilerGenerated]
	// RVA: 0x3664900 Offset: 0x3660900 VA: 0x3664900
	public void set_AllTurnData(CardGameTurnCardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3664908 Offset: 0x3660908 VA: 0x3664908
	public bool get_LastChanceSelector() { }

	[CompilerGenerated]
	// RVA: 0x3664910 Offset: 0x3660910 VA: 0x3664910
	public void set_LastChanceSelector(bool value) { }

	[CompilerGenerated]
	// RVA: 0x366491C Offset: 0x366091C VA: 0x366491C
	public CardGameTurnTableData get_TableData() { }

	[CompilerGenerated]
	// RVA: 0x3664924 Offset: 0x3660924 VA: 0x3664924
	public void set_TableData(CardGameTurnTableData value) { }

	// RVA: 0x366492C Offset: 0x366092C VA: 0x366492C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3664934 Offset: 0x3660934 VA: 0x3664934 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366493C Offset: 0x366093C VA: 0x366493C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3664BC8 Offset: 0x3660BC8 VA: 0x3664BC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
