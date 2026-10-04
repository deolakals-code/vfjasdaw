// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildSecedeResponse : PacketBase // TypeDefIndex: 12405
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	[PacketParameter(Code = 70)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3602348 Offset: 0x35FE348 VA: 0x3602348
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3602350 Offset: 0x35FE350 VA: 0x3602350
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3602358 Offset: 0x35FE358 VA: 0x3602358
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3602360 Offset: 0x35FE360 VA: 0x3602360
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3602368 Offset: 0x35FE368 VA: 0x3602368
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3602370 Offset: 0x35FE370 VA: 0x3602370
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3602378 Offset: 0x35FE378 VA: 0x3602378
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x3602380 Offset: 0x35FE380 VA: 0x3602380 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3602388 Offset: 0x35FE388 VA: 0x3602388 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36025D4 Offset: 0x35FE5D4 VA: 0x36025D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
