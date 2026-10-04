// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailGetMessageResponse : OperationResponseBase // TypeDefIndex: 12017
{
	// Fields
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x20

	// Properties
	public int[] MailCounts { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3777EE8 Offset: 0x3773EE8 VA: 0x3777EE8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3777EF0 Offset: 0x3773EF0 VA: 0x3777EF0
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x3777EF8 Offset: 0x3773EF8 VA: 0x3777EF8
	public void set_MailCounts(int[] value) { }

	// RVA: 0x3777F00 Offset: 0x3773F00 VA: 0x3777F00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3777F08 Offset: 0x3773F08 VA: 0x3777F08 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3777F10 Offset: 0x3773F10 VA: 0x3777F10 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3778068 Offset: 0x3774068 VA: 0x3778068 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
