// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCheckCookingItemResponse : OperationRequestBase // TypeDefIndex: 12156
{
	// Fields
	[CompilerGenerated]
	private int[] <ErrorMainList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <ErrorSubList>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 148, IsOptional = True)]
	public int[] ErrorMainList { get; set; }
	[PacketClass(Code = 237, IsOptional = True)]
	public int[] ErrorSubList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3792AEC Offset: 0x378EAEC VA: 0x3792AEC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3792AF4 Offset: 0x378EAF4 VA: 0x3792AF4
	public int[] get_ErrorMainList() { }

	[CompilerGenerated]
	// RVA: 0x3792AFC Offset: 0x378EAFC VA: 0x3792AFC
	public void set_ErrorMainList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3792B04 Offset: 0x378EB04 VA: 0x3792B04
	public int[] get_ErrorSubList() { }

	[CompilerGenerated]
	// RVA: 0x3792B0C Offset: 0x378EB0C VA: 0x3792B0C
	public void set_ErrorSubList(int[] value) { }

	// RVA: 0x3792B14 Offset: 0x378EB14 VA: 0x3792B14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3792B1C Offset: 0x378EB1C VA: 0x3792B1C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3792B24 Offset: 0x378EB24 VA: 0x3792B24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3792CFC Offset: 0x378ECFC VA: 0x3792CFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
