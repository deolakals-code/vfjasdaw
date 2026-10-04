// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailReceiveDeliveryResponse : OperationResponseBase // TypeDefIndex: 12026
{
	// Fields
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x20
	[CompilerGenerated]
	private MailBodyData <Mail>k__BackingField; // 0x28
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int[] MailCounts { get; set; }
	public MailBodyData Mail { get; set; }
	public RewardResponseDatav2 RewardData { get; set; }

	// Methods

	// RVA: 0x37790F0 Offset: 0x37750F0 VA: 0x37790F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37790F8 Offset: 0x37750F8 VA: 0x37790F8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3779100 Offset: 0x3775100 VA: 0x3779100
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x3779108 Offset: 0x3775108 VA: 0x3779108
	public void set_MailCounts(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3779110 Offset: 0x3775110 VA: 0x3779110
	public MailBodyData get_Mail() { }

	[CompilerGenerated]
	// RVA: 0x3779118 Offset: 0x3775118 VA: 0x3779118
	public void set_Mail(MailBodyData value) { }

	[CompilerGenerated]
	// RVA: 0x3779120 Offset: 0x3775120 VA: 0x3779120
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x3779128 Offset: 0x3775128 VA: 0x3779128
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x3779130 Offset: 0x3775130 VA: 0x3779130
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3779138 Offset: 0x3775138 VA: 0x3779138 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377941C Offset: 0x377541C VA: 0x377941C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
