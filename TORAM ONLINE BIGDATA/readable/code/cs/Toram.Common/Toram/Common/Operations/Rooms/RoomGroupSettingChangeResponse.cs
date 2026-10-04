// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomGroupSettingChangeResponse : PacketBase // TypeDefIndex: 11747
{
	// Fields
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3741798 Offset: 0x373D798 VA: 0x3741798
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37417A0 Offset: 0x373D7A0 VA: 0x37417A0
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x37417A8 Offset: 0x373D7A8 VA: 0x37417A8
	public void set_GroupSetting(RoomGroupSetting value) { }

	// RVA: 0x37417B0 Offset: 0x373D7B0 VA: 0x37417B0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37418D0 Offset: 0x373D8D0 VA: 0x37418D0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374194C Offset: 0x373D94C VA: 0x374194C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3741954 Offset: 0x373D954 VA: 0x3741954 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37419EC Offset: 0x373D9EC VA: 0x37419EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
