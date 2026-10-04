// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailCheckResponse : OperationResponseBase // TypeDefIndex: 12022
{
	// Fields
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ExchangeCount>k__BackingField; // 0x28

	// Properties
	public int[] MailCounts { get; set; }
	public int ExchangeCount { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3778A9C Offset: 0x3774A9C VA: 0x3778A9C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3778AA4 Offset: 0x3774AA4 VA: 0x3778AA4
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x3778AAC Offset: 0x3774AAC VA: 0x3778AAC
	public void set_MailCounts(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3778AB4 Offset: 0x3774AB4 VA: 0x3778AB4
	public int get_ExchangeCount() { }

	[CompilerGenerated]
	// RVA: 0x3778ABC Offset: 0x3774ABC VA: 0x3778ABC
	public void set_ExchangeCount(int value) { }

	// RVA: 0x3778AC4 Offset: 0x3774AC4 VA: 0x3778AC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3778ACC Offset: 0x3774ACC VA: 0x3778ACC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3778AD4 Offset: 0x3774AD4 VA: 0x3778AD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3778CAC Offset: 0x3774CAC VA: 0x3778CAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
