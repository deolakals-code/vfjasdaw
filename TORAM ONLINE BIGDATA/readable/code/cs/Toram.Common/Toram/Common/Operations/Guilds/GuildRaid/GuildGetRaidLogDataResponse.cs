// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class GuildGetRaidLogDataResponse : OperationResponseBase // TypeDefIndex: 12433
{
	// Fields
	[CompilerGenerated]
	private GuildRaidLogData[] <LogList>k__BackingField; // 0x20

	// Properties
	public GuildRaidLogData[] LogList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3606DB4 Offset: 0x3602DB4 VA: 0x3606DB4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3606DBC Offset: 0x3602DBC VA: 0x3606DBC
	public GuildRaidLogData[] get_LogList() { }

	[CompilerGenerated]
	// RVA: 0x3606DC4 Offset: 0x3602DC4 VA: 0x3606DC4
	public void set_LogList(GuildRaidLogData[] value) { }

	// RVA: 0x3606DCC Offset: 0x3602DCC VA: 0x3606DCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3606DD4 Offset: 0x3602DD4 VA: 0x3606DD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3606DDC Offset: 0x3602DDC VA: 0x3606DDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3606F54 Offset: 0x3602F54 VA: 0x3606F54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
