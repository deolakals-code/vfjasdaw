// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseEndEditModeResponse : OperationResponseBase // TypeDefIndex: 12172
{
	// Fields
	[CompilerGenerated]
	private byte <EditMode>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 44)]
	public byte EditMode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37953A0 Offset: 0x37913A0 VA: 0x37953A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37953A8 Offset: 0x37913A8 VA: 0x37953A8
	public byte get_EditMode() { }

	[CompilerGenerated]
	// RVA: 0x37953B0 Offset: 0x37913B0 VA: 0x37953B0
	public void set_EditMode(byte value) { }

	// RVA: 0x37953B8 Offset: 0x37913B8 VA: 0x37953B8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37953BC Offset: 0x37913BC VA: 0x37953BC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37953C0 Offset: 0x37913C0 VA: 0x37953C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37953C8 Offset: 0x37913C8 VA: 0x37953C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37953D0 Offset: 0x37913D0 VA: 0x37953D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37954F0 Offset: 0x37914F0 VA: 0x37954F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
