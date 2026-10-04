// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCandidacyMasterPostResponse : OperationResponseBase // TypeDefIndex: 12380
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SenderPost>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <TargetPost>k__BackingField; // 0x38

	// Properties
	public int SenderId { get; set; }
	public byte SenderPost { get; set; }
	public int TargetId { get; set; }
	public string TargetName { get; set; }
	public byte TargetPost { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FE3F0 Offset: 0x35FA3F0 VA: 0x35FE3F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FE3F8 Offset: 0x35FA3F8 VA: 0x35FE3F8
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x35FE400 Offset: 0x35FA400 VA: 0x35FE400
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FE408 Offset: 0x35FA408 VA: 0x35FE408
	public byte get_SenderPost() { }

	[CompilerGenerated]
	// RVA: 0x35FE410 Offset: 0x35FA410 VA: 0x35FE410
	public void set_SenderPost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FE418 Offset: 0x35FA418 VA: 0x35FE418
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x35FE420 Offset: 0x35FA420 VA: 0x35FE420
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FE428 Offset: 0x35FA428 VA: 0x35FE428
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x35FE430 Offset: 0x35FA430 VA: 0x35FE430
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FE438 Offset: 0x35FA438 VA: 0x35FE438
	public byte get_TargetPost() { }

	[CompilerGenerated]
	// RVA: 0x35FE440 Offset: 0x35FA440 VA: 0x35FE440
	public void set_TargetPost(byte value) { }

	// RVA: 0x35FE448 Offset: 0x35FA448 VA: 0x35FE448 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FE450 Offset: 0x35FA450 VA: 0x35FE450 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FE458 Offset: 0x35FA458 VA: 0x35FE458 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FE6B8 Offset: 0x35FA6B8 VA: 0x35FE6B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
