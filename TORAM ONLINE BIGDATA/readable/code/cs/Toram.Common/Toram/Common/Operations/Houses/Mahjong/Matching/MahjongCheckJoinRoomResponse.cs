// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongCheckJoinRoomResponse : OperationResponseBase // TypeDefIndex: 12347
{
	// Fields
	[CompilerGenerated]
	private int <RoomId>k__BackingField; // 0x20
	[CompilerGenerated]
	private MahjongMemberData[] <MemberList>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongRoomSettingData <RoomSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x38
	[CompilerGenerated]
	private MahjongRecordData <Record>k__BackingField; // 0x40

	// Properties
	public int RoomId { get; set; }
	public MahjongMemberData[] MemberList { get; set; }
	public MahjongRoomSettingData RoomSetting { get; set; }
	public bool IsPlaying { get; set; }
	[CLSCompliant(False)]
	public MahjongRecordData Record { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F8528 Offset: 0x35F4528 VA: 0x35F8528
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F8530 Offset: 0x35F4530 VA: 0x35F8530
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35F8538 Offset: 0x35F4538 VA: 0x35F8538
	public void set_RoomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F8540 Offset: 0x35F4540 VA: 0x35F8540
	public MahjongMemberData[] get_MemberList() { }

	[CompilerGenerated]
	// RVA: 0x35F8548 Offset: 0x35F4548 VA: 0x35F8548
	public void set_MemberList(MahjongMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F8550 Offset: 0x35F4550 VA: 0x35F8550
	public MahjongRoomSettingData get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x35F8558 Offset: 0x35F4558 VA: 0x35F8558
	public void set_RoomSetting(MahjongRoomSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x35F8560 Offset: 0x35F4560 VA: 0x35F8560
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x35F8568 Offset: 0x35F4568 VA: 0x35F8568
	public void set_IsPlaying(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35F8574 Offset: 0x35F4574 VA: 0x35F8574
	public MahjongRecordData get_Record() { }

	[CompilerGenerated]
	// RVA: 0x35F857C Offset: 0x35F457C VA: 0x35F857C
	public void set_Record(MahjongRecordData value) { }

	// RVA: 0x35F8584 Offset: 0x35F4584 VA: 0x35F8584 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F858C Offset: 0x35F458C VA: 0x35F858C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F8594 Offset: 0x35F4594 VA: 0x35F8594 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F870C Offset: 0x35F470C VA: 0x35F870C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
