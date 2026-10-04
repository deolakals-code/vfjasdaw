// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Wave
public class CheckWaveRoomResponse : OperationRequestBase // TypeDefIndex: 11797
{
	// Fields
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[UnityHash(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[UnityHash(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[UnityHash(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }

	// Methods

	// RVA: 0x374D740 Offset: 0x3749740 VA: 0x374D740 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374D748 Offset: 0x3749748 VA: 0x374D748 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x374D750 Offset: 0x3749750 VA: 0x374D750
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x374D758 Offset: 0x3749758 VA: 0x374D758
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x374D760 Offset: 0x3749760 VA: 0x374D760
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x374D768 Offset: 0x3749768 VA: 0x374D768
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x374D770 Offset: 0x3749770 VA: 0x374D770
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374D778 Offset: 0x3749778 VA: 0x374D778
	public void set_Members(RoomGroupMemberStateData[] value) { }

	// RVA: 0x374D780 Offset: 0x3749780 VA: 0x374D780
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x374D788 Offset: 0x3749788 VA: 0x374D788
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374D9F0 Offset: 0x37499F0 VA: 0x374D9F0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374DAD4 Offset: 0x3749AD4 VA: 0x374DAD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374DB6C Offset: 0x3749B6C VA: 0x374DB6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
