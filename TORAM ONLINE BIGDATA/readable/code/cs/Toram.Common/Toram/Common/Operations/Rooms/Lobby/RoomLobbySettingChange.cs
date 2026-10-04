// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbySettingChange : OperationRequestBase // TypeDefIndex: 11777
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20

	// Properties
	public RoomLobbySetting Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3748944 Offset: 0x3744944 VA: 0x3748944
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374894C Offset: 0x374494C VA: 0x374894C
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3748954 Offset: 0x3744954 VA: 0x3748954
	public void set_Setting(RoomLobbySetting value) { }

	// RVA: 0x374895C Offset: 0x374495C VA: 0x374895C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3748964 Offset: 0x3744964 VA: 0x3748964 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374896C Offset: 0x374496C VA: 0x374896C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3748B00 Offset: 0x3744B00 VA: 0x3748B00 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
