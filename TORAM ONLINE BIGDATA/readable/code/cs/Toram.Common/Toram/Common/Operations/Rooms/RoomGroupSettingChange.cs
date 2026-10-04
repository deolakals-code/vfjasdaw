// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomGroupSettingChange : PacketBase // TypeDefIndex: 11746
{
	// Fields
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37414C4 Offset: 0x373D4C4 VA: 0x37414C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37414CC Offset: 0x373D4CC VA: 0x37414CC
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x37414D4 Offset: 0x373D4D4 VA: 0x37414D4
	public void set_GroupSetting(RoomGroupSetting value) { }

	// RVA: 0x37414DC Offset: 0x373D4DC VA: 0x37414DC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37415FC Offset: 0x373D5FC VA: 0x37415FC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3741678 Offset: 0x373D678 VA: 0x3741678 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3741680 Offset: 0x373D680 VA: 0x3741680 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3741718 Offset: 0x373D718 VA: 0x3741718 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
