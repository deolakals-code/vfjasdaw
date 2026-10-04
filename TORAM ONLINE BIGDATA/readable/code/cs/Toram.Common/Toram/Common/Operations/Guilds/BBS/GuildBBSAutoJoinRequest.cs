// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSAutoJoinRequest : OperationRequestBase // TypeDefIndex: 12457
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20

	// Properties
	public int GuildId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360AAD0 Offset: 0x3606AD0 VA: 0x360AAD0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360AAD8 Offset: 0x3606AD8 VA: 0x360AAD8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360AAE0 Offset: 0x3606AE0 VA: 0x360AAE0
	public void set_GuildId(int value) { }

	// RVA: 0x360AAE8 Offset: 0x3606AE8 VA: 0x360AAE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360AAF0 Offset: 0x3606AF0 VA: 0x360AAF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360AAF8 Offset: 0x3606AF8 VA: 0x360AAF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360AC18 Offset: 0x3606C18 VA: 0x360AC18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
