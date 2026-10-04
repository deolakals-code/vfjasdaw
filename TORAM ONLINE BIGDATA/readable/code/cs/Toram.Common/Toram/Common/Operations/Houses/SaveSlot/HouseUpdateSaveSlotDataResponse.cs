// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.SaveSlot
public class HouseUpdateSaveSlotDataResponse : OperationResponseBase // TypeDefIndex: 12209
{
	// Fields
	[CompilerGenerated]
	private byte <SlotNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Memo>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ObjectNum>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 210)]
	public byte SlotNo { get; set; }
	[PacketParameter(Code = 98)]
	public string Memo { get; set; }
	[PacketParameter(Code = 92)]
	public short ObjectNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E1270 Offset: 0x35DD270 VA: 0x35E1270
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E1278 Offset: 0x35DD278 VA: 0x35E1278
	public byte get_SlotNo() { }

	[CompilerGenerated]
	// RVA: 0x35E1280 Offset: 0x35DD280 VA: 0x35E1280
	public void set_SlotNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E1288 Offset: 0x35DD288 VA: 0x35E1288
	public string get_Memo() { }

	[CompilerGenerated]
	// RVA: 0x35E1290 Offset: 0x35DD290 VA: 0x35E1290
	public void set_Memo(string value) { }

	[CompilerGenerated]
	// RVA: 0x35E1298 Offset: 0x35DD298 VA: 0x35E1298
	public short get_ObjectNum() { }

	[CompilerGenerated]
	// RVA: 0x35E12A0 Offset: 0x35DD2A0 VA: 0x35E12A0
	public void set_ObjectNum(short value) { }

	// RVA: 0x35E12A8 Offset: 0x35DD2A8 VA: 0x35E12A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E12B0 Offset: 0x35DD2B0 VA: 0x35E12B0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E12B8 Offset: 0x35DD2B8 VA: 0x35E12B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E1488 Offset: 0x35DD488 VA: 0x35E1488 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
