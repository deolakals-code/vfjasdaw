// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailChangeStateResponse : OperationResponseBase // TypeDefIndex: 12020
{
	// Fields
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<long, byte> <UpdateMailStates>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int[] MailCounts { get; set; }
	public Dictionary<long, byte> UpdateMailStates { get; set; }

	// Methods

	// RVA: 0x37787C8 Offset: 0x37747C8 VA: 0x37787C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37787D0 Offset: 0x37747D0 VA: 0x37787D0 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x37787D8 Offset: 0x37747D8 VA: 0x37787D8
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x37787E0 Offset: 0x37747E0 VA: 0x37787E0
	public void set_MailCounts(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x37787E8 Offset: 0x37747E8 VA: 0x37787E8
	public Dictionary<long, byte> get_UpdateMailStates() { }

	[CompilerGenerated]
	// RVA: 0x37787F0 Offset: 0x37747F0 VA: 0x37787F0
	public void set_UpdateMailStates(Dictionary<long, byte> value) { }

	// RVA: 0x37787F8 Offset: 0x37747F8 VA: 0x37787F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3778800 Offset: 0x3774800 VA: 0x3778800 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37789F4 Offset: 0x37749F4 VA: 0x37789F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
