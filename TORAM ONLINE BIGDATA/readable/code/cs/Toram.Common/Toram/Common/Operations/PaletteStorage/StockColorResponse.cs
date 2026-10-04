// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.PaletteStorage
public class StockColorResponse : OperationResponseBase // TypeDefIndex: 11525
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <UpdateItems>k__BackingField; // 0x20
	[CompilerGenerated]
	private PaletteData[] <UpdatePalettes>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 15)]
	public ItemDatav2[] UpdateItems { get; set; }
	[PacketParameter(Code = 16)]
	public PaletteData[] UpdatePalettes { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3716324 Offset: 0x3712324 VA: 0x3716324
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371632C Offset: 0x371232C VA: 0x371632C
	public ItemDatav2[] get_UpdateItems() { }

	[CompilerGenerated]
	// RVA: 0x3716334 Offset: 0x3712334 VA: 0x3716334
	public void set_UpdateItems(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x371633C Offset: 0x371233C VA: 0x371633C
	public PaletteData[] get_UpdatePalettes() { }

	[CompilerGenerated]
	// RVA: 0x3716344 Offset: 0x3712344 VA: 0x3716344
	public void set_UpdatePalettes(PaletteData[] value) { }

	// RVA: 0x371634C Offset: 0x371234C VA: 0x371634C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3716354 Offset: 0x3712354 VA: 0x3716354 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371635C Offset: 0x371235C VA: 0x371635C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3716440 Offset: 0x3712440 VA: 0x3716440 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
