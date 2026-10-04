// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseConstruction : OperationRequestBase // TypeDefIndex: 12163
{
	// Fields
	[CompilerGenerated]
	private byte <FloorHeight>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <ItemList>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 251)]
	public byte FloorHeight { get; set; }
	[PacketClass(Code = 148, IsOptional = True)]
	public int[] ItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37936CC Offset: 0x378F6CC VA: 0x37936CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37936D4 Offset: 0x378F6D4 VA: 0x37936D4
	public byte get_FloorHeight() { }

	[CompilerGenerated]
	// RVA: 0x37936DC Offset: 0x378F6DC VA: 0x37936DC
	public void set_FloorHeight(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37936E4 Offset: 0x378F6E4 VA: 0x37936E4
	public int[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x37936EC Offset: 0x378F6EC VA: 0x37936EC
	public void set_ItemList(int[] value) { }

	// RVA: 0x37936F4 Offset: 0x378F6F4 VA: 0x37936F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37936FC Offset: 0x378F6FC VA: 0x37936FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3793704 Offset: 0x378F704 VA: 0x3793704 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3793830 Offset: 0x378F830 VA: 0x3793830 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
