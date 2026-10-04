// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.PaletteStorage
public class GetPaletteResponse : OperationResponseBase // TypeDefIndex: 11527
{
	// Fields
	[CompilerGenerated]
	private PaletteData[] <PaletteList>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public PaletteData[] PaletteList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37167DC Offset: 0x37127DC VA: 0x37167DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37167E4 Offset: 0x37127E4 VA: 0x37167E4
	public PaletteData[] get_PaletteList() { }

	[CompilerGenerated]
	// RVA: 0x37167EC Offset: 0x37127EC VA: 0x37167EC
	public void set_PaletteList(PaletteData[] value) { }

	// RVA: 0x37167F4 Offset: 0x37127F4 VA: 0x37167F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37167FC Offset: 0x37127FC VA: 0x37167FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3716804 Offset: 0x3712804 VA: 0x3716804 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3716898 Offset: 0x3712898 VA: 0x3716898 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
