// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomJoinReadyResponse : PacketBase // TypeDefIndex: 11752
{
	// Fields
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomSupportResultData <ResultData>k__BackingField; // 0x38

	// Properties
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketClass(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }
	[PacketClass(Code = 84)]
	public RoomSupportResultData ResultData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37422E4 Offset: 0x373E2E4 VA: 0x37422E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37422EC Offset: 0x373E2EC VA: 0x37422EC
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x37422F4 Offset: 0x373E2F4 VA: 0x37422F4
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x37422FC Offset: 0x373E2FC VA: 0x37422FC
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x3742304 Offset: 0x373E304 VA: 0x3742304
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x374230C Offset: 0x373E30C VA: 0x374230C
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3742314 Offset: 0x373E314 VA: 0x3742314
	public void set_Members(RoomGroupMemberStateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x374231C Offset: 0x373E31C VA: 0x374231C
	public RoomSupportResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x3742324 Offset: 0x373E324 VA: 0x3742324
	public void set_ResultData(RoomSupportResultData value) { }

	// RVA: 0x374232C Offset: 0x373E32C VA: 0x374232C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3742648 Offset: 0x373E648 VA: 0x3742648
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3742758 Offset: 0x373E758 VA: 0x3742758 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3742760 Offset: 0x373E760 VA: 0x3742760 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37427F8 Offset: 0x373E7F8 VA: 0x37427F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
