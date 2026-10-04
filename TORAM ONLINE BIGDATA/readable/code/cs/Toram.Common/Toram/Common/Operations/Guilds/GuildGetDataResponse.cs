// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildGetDataResponse : PacketBase // TypeDefIndex: 12387
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildLevelData <Level>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Post>k__BackingField; // 0x38
	[CompilerGenerated]
	private GuildDungeonData <Dungeon>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x48

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	[PacketClass(Code = 29, IsOptional = True)]
	public GuildLevelData Level { get; set; }
	[PacketParameter(Code = 43)]
	public byte Post { get; set; }
	[PacketClass(Code = 199, IsOptional = True)]
	public GuildDungeonData Dungeon { get; set; }
	[PacketParameter(Code = 205, IsOptional = True)]
	public int Point { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FFB90 Offset: 0x35FBB90 VA: 0x35FFB90
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FFB98 Offset: 0x35FBB98 VA: 0x35FFB98
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FFBA0 Offset: 0x35FBBA0 VA: 0x35FFBA0
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FFBA8 Offset: 0x35FBBA8 VA: 0x35FFBA8
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x35FFBB0 Offset: 0x35FBBB0 VA: 0x35FFBB0
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x35FFBB8 Offset: 0x35FBBB8 VA: 0x35FFBB8
	public GuildLevelData get_Level() { }

	[CompilerGenerated]
	// RVA: 0x35FFBC0 Offset: 0x35FBBC0 VA: 0x35FFBC0
	public void set_Level(GuildLevelData value) { }

	[CompilerGenerated]
	// RVA: 0x35FFBC8 Offset: 0x35FBBC8 VA: 0x35FFBC8
	public byte get_Post() { }

	[CompilerGenerated]
	// RVA: 0x35FFBD0 Offset: 0x35FBBD0 VA: 0x35FFBD0
	public void set_Post(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35FFBD8 Offset: 0x35FBBD8 VA: 0x35FFBD8
	public GuildDungeonData get_Dungeon() { }

	[CompilerGenerated]
	// RVA: 0x35FFBE0 Offset: 0x35FBBE0 VA: 0x35FFBE0
	public void set_Dungeon(GuildDungeonData value) { }

	[CompilerGenerated]
	// RVA: 0x35FFBE8 Offset: 0x35FBBE8 VA: 0x35FFBE8
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x35FFBF0 Offset: 0x35FBBF0 VA: 0x35FFBF0
	public void set_Point(int value) { }

	// RVA: 0x35FFBF8 Offset: 0x35FBBF8 VA: 0x35FFBF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FFC00 Offset: 0x35FBC00 VA: 0x35FFC00 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FFFC4 Offset: 0x35FBFC4 VA: 0x35FFFC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
