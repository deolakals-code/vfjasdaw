// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailGetBody : OperationRequestBase // TypeDefIndex: 12013
{
	// Fields
	[CompilerGenerated]
	private long <MailUniqueId>k__BackingField; // 0x20

	// Properties
	public long MailUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3777028 Offset: 0x3773028 VA: 0x3777028
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3777030 Offset: 0x3773030 VA: 0x3777030
	public long get_MailUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3777038 Offset: 0x3773038 VA: 0x3777038
	public void set_MailUniqueId(long value) { }

	// RVA: 0x3777040 Offset: 0x3773040 VA: 0x3777040 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3777048 Offset: 0x3773048 VA: 0x3777048 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3777050 Offset: 0x3773050 VA: 0x3777050 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3777170 Offset: 0x3773170 VA: 0x3777170 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
