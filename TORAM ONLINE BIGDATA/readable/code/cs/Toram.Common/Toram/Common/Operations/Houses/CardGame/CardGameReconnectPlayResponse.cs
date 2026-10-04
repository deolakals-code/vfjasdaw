// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameReconnectPlayResponse : OperationResponseBase // TypeDefIndex: 12274
{
	// Fields
	[CompilerGenerated]
	private CardGameTurnTableData <TableData>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RemainingTiime>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsLastChance>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <LastChanceSelector>k__BackingField; // 0x2D

	// Properties
	public CardGameTurnTableData TableData { get; set; }
	public int RemainingTiime { get; set; }
	public bool IsLastChance { get; set; }
	public bool LastChanceSelector { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EAA34 Offset: 0x35E6A34 VA: 0x35EAA34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EAA3C Offset: 0x35E6A3C VA: 0x35EAA3C
	public CardGameTurnTableData get_TableData() { }

	[CompilerGenerated]
	// RVA: 0x35EAA44 Offset: 0x35E6A44 VA: 0x35EAA44
	public void set_TableData(CardGameTurnTableData value) { }

	[CompilerGenerated]
	// RVA: 0x35EAA4C Offset: 0x35E6A4C VA: 0x35EAA4C
	public int get_RemainingTiime() { }

	[CompilerGenerated]
	// RVA: 0x35EAA54 Offset: 0x35E6A54 VA: 0x35EAA54
	public void set_RemainingTiime(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EAA5C Offset: 0x35E6A5C VA: 0x35EAA5C
	public bool get_IsLastChance() { }

	[CompilerGenerated]
	// RVA: 0x35EAA64 Offset: 0x35E6A64 VA: 0x35EAA64
	public void set_IsLastChance(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35EAA70 Offset: 0x35E6A70 VA: 0x35EAA70
	public bool get_LastChanceSelector() { }

	[CompilerGenerated]
	// RVA: 0x35EAA78 Offset: 0x35E6A78 VA: 0x35EAA78
	public void set_LastChanceSelector(bool value) { }

	// RVA: 0x35EAA84 Offset: 0x35E6A84 VA: 0x35EAA84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EAA8C Offset: 0x35E6A8C VA: 0x35EAA8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EAA94 Offset: 0x35E6A94 VA: 0x35EAA94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EAD34 Offset: 0x35E6D34 VA: 0x35EAD34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
