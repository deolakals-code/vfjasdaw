// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildNameCheck : PacketBase // TypeDefIndex: 12392
{
	// Fields
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3600C20 Offset: 0x35FCC20 VA: 0x3600C20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3600C28 Offset: 0x35FCC28 VA: 0x3600C28
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3600C30 Offset: 0x35FCC30 VA: 0x3600C30
	public void set_GuildName(string value) { }

	// RVA: 0x3600C38 Offset: 0x35FCC38 VA: 0x3600C38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3600C40 Offset: 0x35FCC40 VA: 0x3600C40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3600D60 Offset: 0x35FCD60 VA: 0x3600D60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
