// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.TreasureHunt
public class CheckTreasureHuntRoomResponse : OperationResponseBase // TypeDefIndex: 11786
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <TrialPoint>k__BackingField; // 0x30
	[CompilerGenerated]
	private TimeSpan <ResetTimer>k__BackingField; // 0x38
	[CompilerGenerated]
	private TreasureHuntRewardData <ItemData>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 29, IsOptional = True)]
	public RoomLobbySetting Setting { get; set; }
	[PacketParameter(Code = 5, IsOptional = True)]
	public RoomMemberData[] Members { get; set; }
	[PacketParameter(Code = 30, IsOptional = True)]
	public byte TrialPoint { get; set; }
	[PacketParameter(Code = 42, IsOptional = True)]
	public TimeSpan ResetTimer { get; set; }
	[PacketParameter(Code = 31, IsOptional = True)]
	public TreasureHuntRewardData ItemData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374AD94 Offset: 0x3746D94 VA: 0x374AD94
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374AD9C Offset: 0x3746D9C VA: 0x374AD9C
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x374ADA4 Offset: 0x3746DA4 VA: 0x374ADA4
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x374ADAC Offset: 0x3746DAC VA: 0x374ADAC
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374ADB4 Offset: 0x3746DB4 VA: 0x374ADB4
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x374ADBC Offset: 0x3746DBC VA: 0x374ADBC
	public byte get_TrialPoint() { }

	[CompilerGenerated]
	// RVA: 0x374ADC4 Offset: 0x3746DC4 VA: 0x374ADC4
	public void set_TrialPoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374ADCC Offset: 0x3746DCC VA: 0x374ADCC
	public TimeSpan get_ResetTimer() { }

	[CompilerGenerated]
	// RVA: 0x374ADD4 Offset: 0x3746DD4 VA: 0x374ADD4
	public void set_ResetTimer(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x374ADDC Offset: 0x3746DDC VA: 0x374ADDC
	public TreasureHuntRewardData get_ItemData() { }

	[CompilerGenerated]
	// RVA: 0x374ADE4 Offset: 0x3746DE4 VA: 0x374ADE4
	public void set_ItemData(TreasureHuntRewardData value) { }

	// RVA: 0x374ADEC Offset: 0x3746DEC VA: 0x374ADEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374ADF4 Offset: 0x3746DF4 VA: 0x374ADF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374ADFC Offset: 0x3746DFC VA: 0x374ADFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374B1EC Offset: 0x37471EC VA: 0x374B1EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
