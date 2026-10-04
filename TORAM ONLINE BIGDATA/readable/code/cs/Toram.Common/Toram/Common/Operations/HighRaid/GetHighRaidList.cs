// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidList : OperationRequestBase // TypeDefIndex: 11557
{
	// Fields
	[CompilerGenerated]
	private byte <HeldType>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 43)]
	public byte HeldType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3719E84 Offset: 0x3715E84 VA: 0x3719E84
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3719E8C Offset: 0x3715E8C VA: 0x3719E8C
	public byte get_HeldType() { }

	[CompilerGenerated]
	// RVA: 0x3719E94 Offset: 0x3715E94 VA: 0x3719E94
	public void set_HeldType(byte value) { }

	// RVA: 0x3719E9C Offset: 0x3715E9C VA: 0x3719E9C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719EA0 Offset: 0x3715EA0 VA: 0x3719EA0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719EA4 Offset: 0x3715EA4 VA: 0x3719EA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3719EAC Offset: 0x3715EAC VA: 0x3719EAC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3719EB4 Offset: 0x3715EB4 VA: 0x3719EB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3719F54 Offset: 0x3715F54 VA: 0x3719F54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
