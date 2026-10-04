// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Matching
public class MahjongUpdateRoomStateEvent : EventSubBase // TypeDefIndex: 12849
{
	// Fields
	[CompilerGenerated]
	private MahjongMemberData[] <Members>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsMatched>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; // 0x29

	// Properties
	public MahjongMemberData[] Members { get; set; }
	public bool IsMatched { get; set; }
	public bool IsPlaying { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36685EC Offset: 0x36645EC VA: 0x36685EC
	public void .ctor() { }

	// RVA: 0x36685F4 Offset: 0x36645F4 VA: 0x36685F4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36685FC Offset: 0x36645FC VA: 0x36685FC
	public MahjongMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3668604 Offset: 0x3664604 VA: 0x3668604
	public void set_Members(MahjongMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x366860C Offset: 0x366460C VA: 0x366860C
	public bool get_IsMatched() { }

	[CompilerGenerated]
	// RVA: 0x3668614 Offset: 0x3664614 VA: 0x3668614
	public void set_IsMatched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3668620 Offset: 0x3664620 VA: 0x3668620
	public bool get_IsPlaying() { }

	[CompilerGenerated]
	// RVA: 0x3668628 Offset: 0x3664628 VA: 0x3668628
	public void set_IsPlaying(bool value) { }

	// RVA: 0x3668634 Offset: 0x3664634 VA: 0x3668634 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366863C Offset: 0x366463C VA: 0x366863C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3668644 Offset: 0x3664644 VA: 0x3668644 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3668760 Offset: 0x3664760 VA: 0x3668760 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
