// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.SaveSlot
public class HouseGetSaveSlotDataResponse : OperationResponseBase // TypeDefIndex: 12211
{
	// Fields
	[CompilerGenerated]
	private byte <NowSlotNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private HouseSlotData[] <SaveSlotList>k__BackingField; // 0x28

	// Properties
	public byte NowSlotNo { get; set; }
	[PacketParameter(Code = 213)]
	public HouseSlotData[] SaveSlotList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E15A0 Offset: 0x35DD5A0 VA: 0x35E15A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E15A8 Offset: 0x35DD5A8 VA: 0x35E15A8
	public byte get_NowSlotNo() { }

	[CompilerGenerated]
	// RVA: 0x35E15B0 Offset: 0x35DD5B0 VA: 0x35E15B0
	public void set_NowSlotNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E15B8 Offset: 0x35DD5B8 VA: 0x35E15B8
	public HouseSlotData[] get_SaveSlotList() { }

	[CompilerGenerated]
	// RVA: 0x35E15C0 Offset: 0x35DD5C0 VA: 0x35E15C0
	public void set_SaveSlotList(HouseSlotData[] value) { }

	// RVA: 0x35E15C8 Offset: 0x35DD5C8 VA: 0x35E15C8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E16C8 Offset: 0x35DD6C8 VA: 0x35E16C8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E175C Offset: 0x35DD75C VA: 0x35E175C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E1764 Offset: 0x35DD764 VA: 0x35E1764 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E176C Offset: 0x35DD76C VA: 0x35E176C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E189C Offset: 0x35DD89C VA: 0x35E189C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
