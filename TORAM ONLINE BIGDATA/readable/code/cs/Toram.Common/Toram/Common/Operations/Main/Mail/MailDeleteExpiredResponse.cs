// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailDeleteExpiredResponse : OperationResponseBase // TypeDefIndex: 12012
{
	// Fields
	[CompilerGenerated]
	private int[] <MailCounts>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<long, byte> <UpdateMailStates>k__BackingField; // 0x28

	// Properties
	public int[] MailCounts { get; set; }
	public Dictionary<long, byte> UpdateMailStates { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3776D6C Offset: 0x3772D6C VA: 0x3776D6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3776D74 Offset: 0x3772D74 VA: 0x3776D74
	public int[] get_MailCounts() { }

	[CompilerGenerated]
	// RVA: 0x3776D7C Offset: 0x3772D7C VA: 0x3776D7C
	public void set_MailCounts(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3776D84 Offset: 0x3772D84 VA: 0x3776D84
	public Dictionary<long, byte> get_UpdateMailStates() { }

	[CompilerGenerated]
	// RVA: 0x3776D8C Offset: 0x3772D8C VA: 0x3776D8C
	public void set_UpdateMailStates(Dictionary<long, byte> value) { }

	// RVA: 0x3776D94 Offset: 0x3772D94 VA: 0x3776D94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3776D9C Offset: 0x3772D9C VA: 0x3776D9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3776DA4 Offset: 0x3772DA4 VA: 0x3776DA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3776E34 Offset: 0x3772E34 VA: 0x3776E34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
