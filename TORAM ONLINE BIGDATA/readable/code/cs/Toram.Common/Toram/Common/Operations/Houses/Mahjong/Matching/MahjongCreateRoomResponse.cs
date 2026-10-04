// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongCreateRoomResponse : OperationResponseBase // TypeDefIndex: 12349
{
	// Fields
	[CompilerGenerated]
	private int <RoomId>k__BackingField; // 0x20
	[CompilerGenerated]
	private MahjongMemberData[] <MemberList>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongRoomSettingData <Setting>k__BackingField; // 0x30

	// Properties
	public int RoomId { get; set; }
	public MahjongMemberData[] MemberList { get; set; }
	public MahjongRoomSettingData Setting { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F8CC8 Offset: 0x35F4CC8 VA: 0x35F8CC8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F8CD0 Offset: 0x35F4CD0 VA: 0x35F8CD0
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35F8CD8 Offset: 0x35F4CD8 VA: 0x35F8CD8
	public void set_RoomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F8CE0 Offset: 0x35F4CE0 VA: 0x35F8CE0
	public MahjongMemberData[] get_MemberList() { }

	[CompilerGenerated]
	// RVA: 0x35F8CE8 Offset: 0x35F4CE8 VA: 0x35F8CE8
	public void set_MemberList(MahjongMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F8CF0 Offset: 0x35F4CF0 VA: 0x35F8CF0
	public MahjongRoomSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35F8CF8 Offset: 0x35F4CF8 VA: 0x35F8CF8
	public void set_Setting(MahjongRoomSettingData value) { }

	// RVA: 0x35F8D00 Offset: 0x35F4D00 VA: 0x35F8D00 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F8D08 Offset: 0x35F4D08 VA: 0x35F8D08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F8D10 Offset: 0x35F4D10 VA: 0x35F8D10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F8E0C Offset: 0x35F4E0C VA: 0x35F8E0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
