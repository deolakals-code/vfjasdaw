// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildDissolutionResponse : PacketBase // TypeDefIndex: 12385
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 70)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FF4A0 Offset: 0x35FB4A0 VA: 0x35FF4A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FF4A8 Offset: 0x35FB4A8 VA: 0x35FF4A8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FF4B0 Offset: 0x35FB4B0 VA: 0x35FF4B0
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FF4B8 Offset: 0x35FB4B8 VA: 0x35FF4B8
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x35FF4C0 Offset: 0x35FB4C0 VA: 0x35FF4C0
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x35FF4C8 Offset: 0x35FB4C8 VA: 0x35FF4C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FF4D0 Offset: 0x35FB4D0 VA: 0x35FF4D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FF6C4 Offset: 0x35FB6C4 VA: 0x35FF6C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
