// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseOtherListResponse : OperationResponseBase // TypeDefIndex: 12183
{
	// Fields
	[CompilerGenerated]
	private byte <EnterType>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsCompress>k__BackingField; // 0x21
	[CompilerGenerated]
	private HouseEntryData[] <HouseList>k__BackingField; // 0x28

	// Properties
	public byte EnterType { get; set; }
	public bool IsCompress { get; set; }
	public HouseEntryData[] HouseList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3796B18 Offset: 0x3792B18 VA: 0x3796B18
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3796B20 Offset: 0x3792B20 VA: 0x3796B20
	public byte get_EnterType() { }

	[CompilerGenerated]
	// RVA: 0x3796B28 Offset: 0x3792B28 VA: 0x3796B28
	public void set_EnterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3796B30 Offset: 0x3792B30 VA: 0x3796B30
	public bool get_IsCompress() { }

	[CompilerGenerated]
	// RVA: 0x3796B38 Offset: 0x3792B38 VA: 0x3796B38
	public void set_IsCompress(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3796B44 Offset: 0x3792B44 VA: 0x3796B44
	public HouseEntryData[] get_HouseList() { }

	[CompilerGenerated]
	// RVA: 0x3796B4C Offset: 0x3792B4C VA: 0x3796B4C
	public void set_HouseList(HouseEntryData[] value) { }

	// RVA: 0x3796B54 Offset: 0x3792B54 VA: 0x3796B54
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3796CE8 Offset: 0x3792CE8 VA: 0x3796CE8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3796E24 Offset: 0x3792E24 VA: 0x3796E24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3796E2C Offset: 0x3792E2C VA: 0x3796E2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3796E34 Offset: 0x3792E34 VA: 0x3796E34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3796F64 Offset: 0x3792F64 VA: 0x3796F64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
