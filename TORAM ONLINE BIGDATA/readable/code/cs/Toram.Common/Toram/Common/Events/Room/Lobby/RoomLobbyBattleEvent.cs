// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Lobby
public class RoomLobbyBattleEvent : EventSubBase // TypeDefIndex: 12770
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public RoomLobbySetting Setting { get; set; }

	// Methods

	// RVA: 0x3655290 Offset: 0x3651290 VA: 0x3655290
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3655298 Offset: 0x3651298 VA: 0x3655298 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36552A0 Offset: 0x36512A0 VA: 0x36552A0 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36552A8 Offset: 0x36512A8 VA: 0x36552A8
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36552B0 Offset: 0x36512B0 VA: 0x36552B0
	public void set_Setting(RoomLobbySetting value) { }

	// RVA: 0x36552B8 Offset: 0x36512B8 VA: 0x36552B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365544C Offset: 0x365144C VA: 0x365544C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
