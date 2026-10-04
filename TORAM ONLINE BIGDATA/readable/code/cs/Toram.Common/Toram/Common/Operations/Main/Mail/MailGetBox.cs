// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailGetBox : OperationRequestBase // TypeDefIndex: 12015
{
	// Fields
	[CompilerGenerated]
	private byte <MailCountType>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <MailUniqueId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Page>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<long, byte> <UpdateStates>k__BackingField; // 0x38

	// Properties
	public byte MailCountType { get; set; }
	public long MailUniqueId { get; set; }
	public int Page { get; set; }
	public Dictionary<long, byte> UpdateStates { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3777570 Offset: 0x3773570 VA: 0x3777570
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3777578 Offset: 0x3773578 VA: 0x3777578
	public byte get_MailCountType() { }

	[CompilerGenerated]
	// RVA: 0x3777580 Offset: 0x3773580 VA: 0x3777580
	public void set_MailCountType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3777588 Offset: 0x3773588 VA: 0x3777588
	public long get_MailUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3777590 Offset: 0x3773590 VA: 0x3777590
	public void set_MailUniqueId(long value) { }

	[CompilerGenerated]
	// RVA: 0x3777598 Offset: 0x3773598 VA: 0x3777598
	public int get_Page() { }

	[CompilerGenerated]
	// RVA: 0x37775A0 Offset: 0x37735A0 VA: 0x37775A0
	public void set_Page(int value) { }

	[CompilerGenerated]
	// RVA: 0x37775A8 Offset: 0x37735A8 VA: 0x37775A8
	public Dictionary<long, byte> get_UpdateStates() { }

	[CompilerGenerated]
	// RVA: 0x37775B0 Offset: 0x37735B0 VA: 0x37775B0
	public void set_UpdateStates(Dictionary<long, byte> value) { }

	// RVA: 0x37775B8 Offset: 0x37735B8 VA: 0x37775B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37775C0 Offset: 0x37735C0 VA: 0x37775C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37775C8 Offset: 0x37735C8 VA: 0x37775C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3777838 Offset: 0x3773838 VA: 0x3777838 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
