// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameLastChanceEndEvent : EventSubBase // TypeDefIndex: 12833
{
	// Fields
	[CompilerGenerated]
	private CardGameTurnTableData <TableData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <LastChanceOption>k__BackingField; // 0x28

	// Properties
	public CardGameTurnTableData TableData { get; set; }
	public byte LastChanceOption { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36645F4 Offset: 0x36605F4 VA: 0x36645F4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36645FC Offset: 0x36605FC VA: 0x36645FC
	public CardGameTurnTableData get_TableData() { }

	[CompilerGenerated]
	// RVA: 0x3664604 Offset: 0x3660604 VA: 0x3664604
	public void set_TableData(CardGameTurnTableData value) { }

	[CompilerGenerated]
	// RVA: 0x366460C Offset: 0x366060C VA: 0x366460C
	public byte get_LastChanceOption() { }

	[CompilerGenerated]
	// RVA: 0x3664614 Offset: 0x3660614 VA: 0x3664614
	public void set_LastChanceOption(byte value) { }

	// RVA: 0x366461C Offset: 0x366061C VA: 0x366461C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3664624 Offset: 0x3660624 VA: 0x3664624 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366462C Offset: 0x366062C VA: 0x366462C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3664820 Offset: 0x3660820 VA: 0x3664820 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
