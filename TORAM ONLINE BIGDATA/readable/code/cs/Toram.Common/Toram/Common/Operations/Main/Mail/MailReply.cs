// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailReply : OperationRequestBase // TypeDefIndex: 12018
{
	// Fields
	[CompilerGenerated]
	private int <ToAvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MailType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <TitleText>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <BodyText>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <ReplyMailId>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <ToAvatarName>k__BackingField; // 0x40

	// Properties
	public int ToAvatarUuid { get; set; }
	public byte MailType { get; set; }
	public string TitleText { get; set; }
	public string BodyText { get; set; }
	public long ReplyMailId { get; set; }
	public string ToAvatarName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37780DC Offset: 0x37740DC VA: 0x37780DC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37780E4 Offset: 0x37740E4 VA: 0x37780E4
	public int get_ToAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37780EC Offset: 0x37740EC VA: 0x37780EC
	public void set_ToAvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37780F4 Offset: 0x37740F4 VA: 0x37780F4
	public byte get_MailType() { }

	[CompilerGenerated]
	// RVA: 0x37780FC Offset: 0x37740FC VA: 0x37780FC
	public void set_MailType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3778104 Offset: 0x3774104 VA: 0x3778104
	public string get_TitleText() { }

	[CompilerGenerated]
	// RVA: 0x377810C Offset: 0x377410C VA: 0x377810C
	public void set_TitleText(string value) { }

	[CompilerGenerated]
	// RVA: 0x3778114 Offset: 0x3774114 VA: 0x3778114
	public string get_BodyText() { }

	[CompilerGenerated]
	// RVA: 0x377811C Offset: 0x377411C VA: 0x377811C
	public void set_BodyText(string value) { }

	[CompilerGenerated]
	// RVA: 0x3778124 Offset: 0x3774124 VA: 0x3778124
	public long get_ReplyMailId() { }

	[CompilerGenerated]
	// RVA: 0x377812C Offset: 0x377412C VA: 0x377812C
	public void set_ReplyMailId(long value) { }

	[CompilerGenerated]
	// RVA: 0x3778134 Offset: 0x3774134 VA: 0x3778134
	public string get_ToAvatarName() { }

	[CompilerGenerated]
	// RVA: 0x377813C Offset: 0x377413C VA: 0x377813C
	public void set_ToAvatarName(string value) { }

	// RVA: 0x3778144 Offset: 0x3774144 VA: 0x3778144 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377814C Offset: 0x377414C VA: 0x377814C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3778154 Offset: 0x3774154 VA: 0x3778154 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37782E0 Offset: 0x37742E0 VA: 0x37782E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
