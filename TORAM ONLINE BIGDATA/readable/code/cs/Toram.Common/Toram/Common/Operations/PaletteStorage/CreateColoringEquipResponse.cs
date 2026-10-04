// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.PaletteStorage
public class CreateColoringEquipResponse : OperationResponseBase // TypeDefIndex: 11524
{
	// Fields
	[CompilerGenerated]
	private byte <ColoringResult>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2 <UpdateItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private PaletteData <UpdatePalette>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 41)]
	public byte ColoringResult { get; set; }
	[PacketParameter(Code = 29)]
	public ItemDatav2 UpdateItem { get; set; }
	[PacketParameter(Code = 30)]
	public PaletteData UpdatePalette { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3715F58 Offset: 0x3711F58 VA: 0x3715F58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3715F60 Offset: 0x3711F60 VA: 0x3715F60
	public byte get_ColoringResult() { }

	[CompilerGenerated]
	// RVA: 0x3715F68 Offset: 0x3711F68 VA: 0x3715F68
	public void set_ColoringResult(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3715F70 Offset: 0x3711F70 VA: 0x3715F70
	public ItemDatav2 get_UpdateItem() { }

	[CompilerGenerated]
	// RVA: 0x3715F78 Offset: 0x3711F78 VA: 0x3715F78
	public void set_UpdateItem(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3715F80 Offset: 0x3711F80 VA: 0x3715F80
	public PaletteData get_UpdatePalette() { }

	[CompilerGenerated]
	// RVA: 0x3715F88 Offset: 0x3711F88 VA: 0x3715F88
	public void set_UpdatePalette(PaletteData value) { }

	// RVA: 0x3715F90 Offset: 0x3711F90 VA: 0x3715F90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3715F98 Offset: 0x3711F98 VA: 0x3715F98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3715FA0 Offset: 0x3711FA0 VA: 0x3715FA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3716090 Offset: 0x3712090 VA: 0x3716090 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
