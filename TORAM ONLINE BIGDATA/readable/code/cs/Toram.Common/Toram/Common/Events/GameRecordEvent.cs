// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class GameRecordEvent : PacketBase // TypeDefIndex: 12627
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameRecordData <Record>k__BackingField; // 0x28
	[CompilerGenerated]
	private TimeData <ContinuousTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private TimeData <TotalTime>k__BackingField; // 0x38
	[CompilerGenerated]
	private TimeData <DailyTime>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 197, IsOptional = True)]
	public GameRecordData Record { get; set; }
	[PacketClass(Code = 191, IsOptional = True)]
	public TimeData ContinuousTime { get; set; }
	[PacketClass(Code = 192, IsOptional = True)]
	public TimeData TotalTime { get; set; }
	[PacketClass(Code = 196, IsOptional = True)]
	public TimeData DailyTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3634290 Offset: 0x3630290 VA: 0x3634290
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3634298 Offset: 0x3630298 VA: 0x3634298
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36342A0 Offset: 0x36302A0 VA: 0x36342A0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36342A8 Offset: 0x36302A8 VA: 0x36342A8
	public GameRecordData get_Record() { }

	[CompilerGenerated]
	// RVA: 0x36342B0 Offset: 0x36302B0 VA: 0x36342B0
	public void set_Record(GameRecordData value) { }

	[CompilerGenerated]
	// RVA: 0x36342B8 Offset: 0x36302B8 VA: 0x36342B8
	public TimeData get_ContinuousTime() { }

	[CompilerGenerated]
	// RVA: 0x36342C0 Offset: 0x36302C0 VA: 0x36342C0
	public void set_ContinuousTime(TimeData value) { }

	[CompilerGenerated]
	// RVA: 0x36342C8 Offset: 0x36302C8 VA: 0x36342C8
	public TimeData get_TotalTime() { }

	[CompilerGenerated]
	// RVA: 0x36342D0 Offset: 0x36302D0 VA: 0x36342D0
	public void set_TotalTime(TimeData value) { }

	[CompilerGenerated]
	// RVA: 0x36342D8 Offset: 0x36302D8 VA: 0x36342D8
	public TimeData get_DailyTime() { }

	[CompilerGenerated]
	// RVA: 0x36342E0 Offset: 0x36302E0 VA: 0x36342E0
	public void set_DailyTime(TimeData value) { }

	// RVA: 0x36342E8 Offset: 0x36302E8 VA: 0x36342E8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3634608 Offset: 0x3630608 VA: 0x3634608
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3634708 Offset: 0x3630708 VA: 0x3634708 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3634710 Offset: 0x3630710 VA: 0x3634710 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3634840 Offset: 0x3630840 VA: 0x3634840 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
