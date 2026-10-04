// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.GuildBBS
public class GuildBBSJoinRequestEvent : EventSubBase // TypeDefIndex: 12931
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <RequesterId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <RequesterName>k__BackingField; // 0x28

	// Properties
	public int GuildId { get; set; }
	public int RequesterId { get; set; }
	public string RequesterName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367AB78 Offset: 0x3676B78 VA: 0x367AB78
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367AB80 Offset: 0x3676B80 VA: 0x367AB80
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x367AB88 Offset: 0x3676B88 VA: 0x367AB88
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367AB90 Offset: 0x3676B90 VA: 0x367AB90
	public int get_RequesterId() { }

	[CompilerGenerated]
	// RVA: 0x367AB98 Offset: 0x3676B98 VA: 0x367AB98
	public void set_RequesterId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367ABA0 Offset: 0x3676BA0 VA: 0x367ABA0
	public string get_RequesterName() { }

	[CompilerGenerated]
	// RVA: 0x367ABA8 Offset: 0x3676BA8 VA: 0x367ABA8
	public void set_RequesterName(string value) { }

	// RVA: 0x367ABB0 Offset: 0x3676BB0 VA: 0x367ABB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367ABB8 Offset: 0x3676BB8 VA: 0x367ABB8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367ABC0 Offset: 0x3676BC0 VA: 0x367ABC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x367AD84 Offset: 0x3676D84 VA: 0x367AD84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
