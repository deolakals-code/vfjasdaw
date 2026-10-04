// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSJoinRequest : OperationRequestBase // TypeDefIndex: 12460
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20

	// Properties
	public int GuildId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360B89C Offset: 0x360789C VA: 0x360B89C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360B8A4 Offset: 0x36078A4 VA: 0x360B8A4
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360B8AC Offset: 0x36078AC VA: 0x360B8AC
	public void set_GuildId(int value) { }

	// RVA: 0x360B8B4 Offset: 0x36078B4 VA: 0x360B8B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360B8BC Offset: 0x36078BC VA: 0x360B8BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360B8C4 Offset: 0x36078C4 VA: 0x360B8C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360B9E4 Offset: 0x36079E4 VA: 0x360B9E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
