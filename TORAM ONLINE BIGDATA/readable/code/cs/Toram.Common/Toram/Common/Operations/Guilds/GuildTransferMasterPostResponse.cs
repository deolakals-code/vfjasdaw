// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildTransferMasterPostResponse : OperationResponseBase // TypeDefIndex: 12407
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

	// RVA: 0x36028CC Offset: 0x35FE8CC VA: 0x36028CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36028D4 Offset: 0x35FE8D4 VA: 0x36028D4
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x36028DC Offset: 0x35FE8DC VA: 0x36028DC
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36028E4 Offset: 0x35FE8E4 VA: 0x36028E4
	public byte get_SenderPost() { }

	[CompilerGenerated]
	// RVA: 0x36028EC Offset: 0x35FE8EC VA: 0x36028EC
	public void set_SenderPost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36028F4 Offset: 0x35FE8F4 VA: 0x36028F4
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x36028FC Offset: 0x35FE8FC VA: 0x36028FC
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3602904 Offset: 0x35FE904 VA: 0x3602904
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x360290C Offset: 0x35FE90C VA: 0x360290C
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3602914 Offset: 0x35FE914 VA: 0x3602914
	public byte get_TargetPost() { }

	[CompilerGenerated]
	// RVA: 0x360291C Offset: 0x35FE91C VA: 0x360291C
	public void set_TargetPost(byte value) { }

	// RVA: 0x3602924 Offset: 0x35FE924 VA: 0x3602924 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360292C Offset: 0x35FE92C VA: 0x360292C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3602934 Offset: 0x35FE934 VA: 0x3602934 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3602B94 Offset: 0x35FEB94 VA: 0x3602B94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
