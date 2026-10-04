// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailGetBodyResponse : OperationResponseBase // TypeDefIndex: 12014
{
	// Fields
	[CompilerGenerated]
	private MailBodyData <MailBody>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <ServerTime>k__BackingField; // 0x28

	// Properties
	public MailBodyData MailBody { get; set; }
	public DateTime ServerTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3777210 Offset: 0x3773210 VA: 0x3777210
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3777218 Offset: 0x3773218 VA: 0x3777218
	public MailBodyData get_MailBody() { }

	[CompilerGenerated]
	// RVA: 0x3777220 Offset: 0x3773220 VA: 0x3777220
	public void set_MailBody(MailBodyData value) { }

	[CompilerGenerated]
	// RVA: 0x3777228 Offset: 0x3773228 VA: 0x3777228
	public DateTime get_ServerTime() { }

	[CompilerGenerated]
	// RVA: 0x3777230 Offset: 0x3773230 VA: 0x3777230
	public void set_ServerTime(DateTime value) { }

	// RVA: 0x3777238 Offset: 0x3773238 VA: 0x3777238 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3777240 Offset: 0x3773240 VA: 0x3777240 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3777248 Offset: 0x3773248 VA: 0x3777248 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3777464 Offset: 0x3773464 VA: 0x3777464 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
