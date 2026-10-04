// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Matching
public class MahjongJoinRoomEvent : EventSubBase // TypeDefIndex: 12848
{
	// Fields
	[CompilerGenerated]
	private MahjongMemberData <Member>k__BackingField; // 0x20

	// Properties
	public MahjongMemberData Member { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36683B0 Offset: 0x36643B0 VA: 0x36683B0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36683B8 Offset: 0x36643B8 VA: 0x36683B8
	public MahjongMemberData get_Member() { }

	[CompilerGenerated]
	// RVA: 0x36683C0 Offset: 0x36643C0 VA: 0x36683C0
	public void set_Member(MahjongMemberData value) { }

	// RVA: 0x36683C8 Offset: 0x36643C8 VA: 0x36683C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36683D0 Offset: 0x36643D0 VA: 0x36683D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36683D8 Offset: 0x36643D8 VA: 0x36683D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3668460 Offset: 0x3664460 VA: 0x3668460 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
