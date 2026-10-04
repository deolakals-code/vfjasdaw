// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailReceiveDelivery : OperationRequestBase // TypeDefIndex: 12025
{
	// Fields
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public long UniqueId { get; set; }

	// Methods

	// RVA: 0x3778F08 Offset: 0x3774F08 VA: 0x3778F08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3778F10 Offset: 0x3774F10 VA: 0x3778F10 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3778F18 Offset: 0x3774F18 VA: 0x3778F18
	public long get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3778F20 Offset: 0x3774F20 VA: 0x3778F20
	public void set_UniqueId(long value) { }

	// RVA: 0x3778F28 Offset: 0x3774F28 VA: 0x3778F28
	public void .ctor() { }

	// RVA: 0x3778F30 Offset: 0x3774F30 VA: 0x3778F30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3779050 Offset: 0x3775050 VA: 0x3779050 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
