// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongJoinRoomResponse : OperationResponseBase // TypeDefIndex: 12350
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

	// RVA: 0x35F9050 Offset: 0x35F5050 VA: 0x35F9050
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F9058 Offset: 0x35F5058 VA: 0x35F9058
	public int get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35F9060 Offset: 0x35F5060 VA: 0x35F9060
	public void set_RoomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F9068 Offset: 0x35F5068 VA: 0x35F9068
	public MahjongMemberData[] get_MemberList() { }

	[CompilerGenerated]
	// RVA: 0x35F9070 Offset: 0x35F5070 VA: 0x35F9070
	public void set_MemberList(MahjongMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F9078 Offset: 0x35F5078 VA: 0x35F9078
	public MahjongRoomSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35F9080 Offset: 0x35F5080 VA: 0x35F9080
	public void set_Setting(MahjongRoomSettingData value) { }

	// RVA: 0x35F9088 Offset: 0x35F5088 VA: 0x35F9088 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F9090 Offset: 0x35F5090 VA: 0x35F9090 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F9098 Offset: 0x35F5098 VA: 0x35F9098 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F9194 Offset: 0x35F5194 VA: 0x35F9194 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
