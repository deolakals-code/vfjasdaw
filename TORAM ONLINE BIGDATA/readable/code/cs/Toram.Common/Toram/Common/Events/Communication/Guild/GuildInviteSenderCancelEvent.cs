// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildInviteSenderCancelEvent : PacketBase // TypeDefIndex: 12916
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3677850 Offset: 0x3673850 VA: 0x3677850
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3677858 Offset: 0x3673858 VA: 0x3677858
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3677860 Offset: 0x3673860 VA: 0x3677860
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677868 Offset: 0x3673868 VA: 0x3677868
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3677870 Offset: 0x3673870 VA: 0x3677870
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677878 Offset: 0x3673878 VA: 0x3677878
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3677880 Offset: 0x3673880 VA: 0x3677880
	public void set_GuildName(string value) { }

	// RVA: 0x3677888 Offset: 0x3673888 VA: 0x3677888 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3677890 Offset: 0x3673890 VA: 0x3677890 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3677A54 Offset: 0x3673A54 VA: 0x3677A54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
