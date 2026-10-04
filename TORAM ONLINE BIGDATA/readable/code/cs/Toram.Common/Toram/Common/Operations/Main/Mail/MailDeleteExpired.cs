// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailDeleteExpired : OperationRequestBase // TypeDefIndex: 12011
{
	// Fields
	[CompilerGenerated]
	private long[] <DeleteMails>k__BackingField; // 0x20

	// Properties
	public long[] DeleteMails { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3776B78 Offset: 0x3772B78 VA: 0x3776B78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3776B80 Offset: 0x3772B80 VA: 0x3776B80
	public long[] get_DeleteMails() { }

	[CompilerGenerated]
	// RVA: 0x3776B88 Offset: 0x3772B88 VA: 0x3776B88
	public void set_DeleteMails(long[] value) { }

	// RVA: 0x3776B90 Offset: 0x3772B90 VA: 0x3776B90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3776B98 Offset: 0x3772B98 VA: 0x3776B98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3776BA0 Offset: 0x3772BA0 VA: 0x3776BA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3776C14 Offset: 0x3772C14 VA: 0x3776C14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
