// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCreate : PacketBase // TypeDefIndex: 12383
{
	// Fields
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x20

	// Properties
	public string GuildName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FEF40 Offset: 0x35FAF40 VA: 0x35FEF40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FEF48 Offset: 0x35FAF48 VA: 0x35FEF48
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x35FEF50 Offset: 0x35FAF50 VA: 0x35FEF50
	public void set_GuildName(string value) { }

	// RVA: 0x35FEF58 Offset: 0x35FAF58 VA: 0x35FEF58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FEF60 Offset: 0x35FAF60 VA: 0x35FEF60 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FF080 Offset: 0x35FB080 VA: 0x35FF080 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
