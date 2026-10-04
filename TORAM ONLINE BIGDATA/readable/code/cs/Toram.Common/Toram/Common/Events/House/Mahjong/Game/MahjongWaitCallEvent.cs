// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongWaitCallEvent : EventSubBase // TypeDefIndex: 12843
{
	// Fields
	[CompilerGenerated]
	private MahjongTileData <Discard>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsOnlyRon>k__BackingField; // 0x28

	// Properties
	public MahjongTileData Discard { get; set; }
	public bool IsOnlyRon { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366729C Offset: 0x366329C VA: 0x366729C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36672A4 Offset: 0x36632A4 VA: 0x36672A4
	public MahjongTileData get_Discard() { }

	[CompilerGenerated]
	// RVA: 0x36672AC Offset: 0x36632AC VA: 0x36672AC
	public void set_Discard(MahjongTileData value) { }

	[CompilerGenerated]
	// RVA: 0x36672B4 Offset: 0x36632B4 VA: 0x36672B4
	public bool get_IsOnlyRon() { }

	[CompilerGenerated]
	// RVA: 0x36672BC Offset: 0x36632BC VA: 0x36672BC
	public void set_IsOnlyRon(bool value) { }

	// RVA: 0x36672C8 Offset: 0x36632C8 VA: 0x36672C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36672D0 Offset: 0x36632D0 VA: 0x36672D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36672D8 Offset: 0x36632D8 VA: 0x36672D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36673AC Offset: 0x36633AC VA: 0x36673AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
