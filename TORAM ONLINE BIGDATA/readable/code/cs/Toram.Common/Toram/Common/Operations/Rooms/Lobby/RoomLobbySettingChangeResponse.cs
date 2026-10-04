// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbySettingChangeResponse : OperationResponseBase // TypeDefIndex: 11778
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20

	// Properties
	public RoomLobbySetting Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3748B88 Offset: 0x3744B88 VA: 0x3748B88
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3748B90 Offset: 0x3744B90 VA: 0x3748B90
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3748B98 Offset: 0x3744B98 VA: 0x3748B98
	public void set_Setting(RoomLobbySetting value) { }

	// RVA: 0x3748BA0 Offset: 0x3744BA0 VA: 0x3748BA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3748BA8 Offset: 0x3744BA8 VA: 0x3748BA8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3748BB0 Offset: 0x3744BB0 VA: 0x3748BB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3748D44 Offset: 0x3744D44 VA: 0x3748D44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
