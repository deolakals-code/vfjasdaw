// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Defence
public class CheckDefenceRoomResponse : PacketBase // TypeDefIndex: 11762
{
	// Fields
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <TrialPoint>k__BackingField; // 0x38
	[CompilerGenerated]
	private TimeSpan <ResetTimer>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <BestScore>k__BackingField; // 0x48
	[CompilerGenerated]
	private TimeSpan <BestTime>k__BackingField; // 0x50

	// Properties
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketClass(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }
	[PacketClass(Code = 205, IsOptional = True)]
	public byte TrialPoint { get; set; }
	[PacketClass(Code = 190, IsOptional = True)]
	public TimeSpan ResetTimer { get; set; }
	[PacketClass(Code = 133, IsOptional = True)]
	public int BestScore { get; set; }
	[PacketClass(Code = 189, IsOptional = True)]
	public TimeSpan BestTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3744608 Offset: 0x3740608 VA: 0x3744608
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3744610 Offset: 0x3740610 VA: 0x3744610
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x3744618 Offset: 0x3740618 VA: 0x3744618
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3744620 Offset: 0x3740620 VA: 0x3744620
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x3744628 Offset: 0x3740628 VA: 0x3744628
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3744630 Offset: 0x3740630 VA: 0x3744630
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3744638 Offset: 0x3740638 VA: 0x3744638
	public void set_Members(RoomGroupMemberStateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3744640 Offset: 0x3740640 VA: 0x3744640
	public byte get_TrialPoint() { }

	[CompilerGenerated]
	// RVA: 0x3744648 Offset: 0x3740648 VA: 0x3744648
	public void set_TrialPoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3744650 Offset: 0x3740650 VA: 0x3744650
	public TimeSpan get_ResetTimer() { }

	[CompilerGenerated]
	// RVA: 0x3744658 Offset: 0x3740658 VA: 0x3744658
	public void set_ResetTimer(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x3744660 Offset: 0x3740660 VA: 0x3744660
	public int get_BestScore() { }

	[CompilerGenerated]
	// RVA: 0x3744668 Offset: 0x3740668 VA: 0x3744668
	public void set_BestScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x3744670 Offset: 0x3740670 VA: 0x3744670
	public TimeSpan get_BestTime() { }

	[CompilerGenerated]
	// RVA: 0x3744678 Offset: 0x3740678 VA: 0x3744678
	public void set_BestTime(TimeSpan value) { }

	// RVA: 0x3744680 Offset: 0x3740680 VA: 0x3744680
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37449A0 Offset: 0x37409A0 VA: 0x37449A0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3744B44 Offset: 0x3740B44 VA: 0x3744B44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3744B4C Offset: 0x3740B4C VA: 0x3744B4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3744D14 Offset: 0x3740D14 VA: 0x3744D14 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
