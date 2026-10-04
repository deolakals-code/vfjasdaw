// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.PaletteStorage
public class CreateColoringEquip : OperationRequestBase // TypeDefIndex: 11523
{
	// Fields
	[CompilerGenerated]
	private short <ItemType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <Color>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public short ItemType { get; set; }
	[PacketParameter(Code = 15)]
	public byte[] Color { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3715CE8 Offset: 0x3711CE8 VA: 0x3715CE8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3715CF0 Offset: 0x3711CF0 VA: 0x3715CF0
	public short get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x3715CF8 Offset: 0x3711CF8 VA: 0x3715CF8
	public void set_ItemType(short value) { }

	[CompilerGenerated]
	// RVA: 0x3715D00 Offset: 0x3711D00 VA: 0x3715D00
	public byte[] get_Color() { }

	[CompilerGenerated]
	// RVA: 0x3715D08 Offset: 0x3711D08 VA: 0x3715D08
	public void set_Color(byte[] value) { }

	// RVA: 0x3715D10 Offset: 0x3711D10 VA: 0x3715D10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3715D18 Offset: 0x3711D18 VA: 0x3715D18 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3715D20 Offset: 0x3711D20 VA: 0x3715D20 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3715DD4 Offset: 0x3711DD4 VA: 0x3715DD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
