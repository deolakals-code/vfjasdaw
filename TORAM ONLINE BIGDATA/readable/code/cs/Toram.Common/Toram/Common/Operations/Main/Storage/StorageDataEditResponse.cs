// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageDataEditResponse : OperationResponseBase // TypeDefIndex: 12054
{
	// Fields
	[CompilerGenerated]
	private StorageDatav2 <StorageData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 199, IsOptional = True)]
	public StorageDatav2 StorageData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377E7EC Offset: 0x377A7EC VA: 0x377E7EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377E7F4 Offset: 0x377A7F4 VA: 0x377E7F4
	public StorageDatav2 get_StorageData() { }

	[CompilerGenerated]
	// RVA: 0x377E7FC Offset: 0x377A7FC VA: 0x377E7FC
	public void set_StorageData(StorageDatav2 value) { }

	// RVA: 0x377E804 Offset: 0x377A804 VA: 0x377E804
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377E920 Offset: 0x377A920 VA: 0x377E920
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377E99C Offset: 0x377A99C VA: 0x377E99C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377E9A4 Offset: 0x377A9A4 VA: 0x377E9A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377E9AC Offset: 0x377A9AC VA: 0x377E9AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377EA44 Offset: 0x377AA44 VA: 0x377EA44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
