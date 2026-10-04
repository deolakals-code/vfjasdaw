// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildNameChangeResponse : PacketBase // TypeDefIndex: 12391
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	[PacketParameter(Code = 28)]
	public int Gold { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x360090C Offset: 0x35FC90C VA: 0x360090C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3600914 Offset: 0x35FC914 VA: 0x3600914
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x360091C Offset: 0x35FC91C VA: 0x360091C
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3600924 Offset: 0x35FC924 VA: 0x3600924
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x360092C Offset: 0x35FC92C VA: 0x360092C
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3600934 Offset: 0x35FC934 VA: 0x3600934
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x360093C Offset: 0x35FC93C VA: 0x360093C
	public void set_Gold(int value) { }

	// RVA: 0x3600944 Offset: 0x35FC944 VA: 0x3600944 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360094C Offset: 0x35FC94C VA: 0x360094C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3600B10 Offset: 0x35FCB10 VA: 0x3600B10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
