// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.SaveSlot
public class HouseUpdateSaveSlotData : OperationRequestBase // TypeDefIndex: 12207
{
	// Fields
	[CompilerGenerated]
	private byte <SlotNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Memo>k__BackingField; // 0x28

	// Properties
	public byte SlotNo { get; set; }
	public string Memo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E0E24 Offset: 0x35DCE24 VA: 0x35E0E24
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E0E2C Offset: 0x35DCE2C VA: 0x35E0E2C
	public byte get_SlotNo() { }

	[CompilerGenerated]
	// RVA: 0x35E0E34 Offset: 0x35DCE34 VA: 0x35E0E34
	public void set_SlotNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E0E3C Offset: 0x35DCE3C VA: 0x35E0E3C
	public string get_Memo() { }

	[CompilerGenerated]
	// RVA: 0x35E0E44 Offset: 0x35DCE44 VA: 0x35E0E44
	public void set_Memo(string value) { }

	// RVA: 0x35E0E4C Offset: 0x35DCE4C VA: 0x35E0E4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E0E54 Offset: 0x35DCE54 VA: 0x35E0E54 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E0E5C Offset: 0x35DCE5C VA: 0x35E0E5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0FD4 Offset: 0x35DCFD4 VA: 0x35E0FD4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
