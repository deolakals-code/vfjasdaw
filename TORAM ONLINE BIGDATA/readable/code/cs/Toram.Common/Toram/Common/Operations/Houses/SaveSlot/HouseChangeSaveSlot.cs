// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.SaveSlot
public class HouseChangeSaveSlot : OperationRequestBase // TypeDefIndex: 12208
{
	// Fields
	[CompilerGenerated]
	private byte <SlotNo>k__BackingField; // 0x20

	// Properties
	public byte SlotNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E1088 Offset: 0x35DD088 VA: 0x35E1088
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E1090 Offset: 0x35DD090 VA: 0x35E1090
	public byte get_SlotNo() { }

	[CompilerGenerated]
	// RVA: 0x35E1098 Offset: 0x35DD098 VA: 0x35E1098
	public void set_SlotNo(byte value) { }

	// RVA: 0x35E10A0 Offset: 0x35DD0A0 VA: 0x35E10A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E10A8 Offset: 0x35DD0A8 VA: 0x35E10A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E10B0 Offset: 0x35DD0B0 VA: 0x35E10B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E11D0 Offset: 0x35DD1D0 VA: 0x35E11D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
