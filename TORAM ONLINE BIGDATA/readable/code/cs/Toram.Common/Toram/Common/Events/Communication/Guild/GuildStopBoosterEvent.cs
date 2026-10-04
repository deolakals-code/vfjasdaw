// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildStopBoosterEvent : PacketBase // TypeDefIndex: 12925
{
	// Fields
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28

	// Properties
	public int Point { get; set; }
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3679C30 Offset: 0x3675C30 VA: 0x3679C30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3679C38 Offset: 0x3675C38 VA: 0x3679C38
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x3679C40 Offset: 0x3675C40 VA: 0x3679C40
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679C48 Offset: 0x3675C48 VA: 0x3679C48
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3679C50 Offset: 0x3675C50 VA: 0x3679C50
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x3679C58 Offset: 0x3675C58 VA: 0x3679C58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3679C60 Offset: 0x3675C60 VA: 0x3679C60 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3679E54 Offset: 0x3675E54 VA: 0x3679E54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
