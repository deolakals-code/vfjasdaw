// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseStartEditModeResponse : OperationResponseBase // TypeDefIndex: 12190
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

	// RVA: 0x35DE1C8 Offset: 0x35DA1C8 VA: 0x35DE1C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DE1D0 Offset: 0x35DA1D0 VA: 0x35DE1D0
	public byte get_EditMode() { }

	[CompilerGenerated]
	// RVA: 0x35DE1D8 Offset: 0x35DA1D8 VA: 0x35DE1D8
	public void set_EditMode(byte value) { }

	// RVA: 0x35DE1E0 Offset: 0x35DA1E0 VA: 0x35DE1E0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DE1E4 Offset: 0x35DA1E4 VA: 0x35DE1E4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DE1E8 Offset: 0x35DA1E8 VA: 0x35DE1E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DE1F0 Offset: 0x35DA1F0 VA: 0x35DE1F0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DE1F8 Offset: 0x35DA1F8 VA: 0x35DE1F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DE318 Offset: 0x35DA318 VA: 0x35DE318 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
