// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.GuildRaid
public class CheckGuildRaidRoomResponse : OperationResponseBase // TypeDefIndex: 11791
{
	// Fields
	private byte flag; // 0x20
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x30

	// Properties
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public bool IsAlreadyBattle { get; }
	public bool IsMaxParty { get; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374C2A8 Offset: 0x37482A8 VA: 0x374C2A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374C2B0 Offset: 0x37482B0 VA: 0x374C2B0
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x374C2B8 Offset: 0x37482B8 VA: 0x374C2B8
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x374C2C0 Offset: 0x37482C0 VA: 0x374C2C0
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374C2C8 Offset: 0x37482C8 VA: 0x374C2C8
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x374C2D0 Offset: 0x37482D0 VA: 0x374C2D0
	public bool get_IsAlreadyBattle() { }

	// RVA: 0x374C2EC Offset: 0x37482EC VA: 0x374C2EC
	public bool get_IsMaxParty() { }

	// RVA: 0x374C2DC Offset: 0x37482DC VA: 0x374C2DC
	private bool HasFlag(byte type) { }

	// RVA: 0x374C2F8 Offset: 0x37482F8 VA: 0x374C2F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374C300 Offset: 0x3748300 VA: 0x374C300 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374C308 Offset: 0x3748308 VA: 0x374C308 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374C418 Offset: 0x3748418 VA: 0x374C418 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
