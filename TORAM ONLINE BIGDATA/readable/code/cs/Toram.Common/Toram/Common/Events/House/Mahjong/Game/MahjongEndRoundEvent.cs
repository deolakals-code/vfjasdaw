// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongEndRoundEvent : EventSubBase // TypeDefIndex: 12841
{
	// Fields
	[CompilerGenerated]
	private byte <EndType>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsGameEnd>k__BackingField; // 0x21
	[CompilerGenerated]
	private MahjongPlayerRoundResultData[] <PlayerResultList>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongTileData[] <UraDoraList>k__BackingField; // 0x30

	// Properties
	public byte EndType { get; set; }
	public bool IsGameEnd { get; set; }
	public MahjongPlayerRoundResultData[] PlayerResultList { get; set; }
	public MahjongTileData[] UraDoraList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3666AA4 Offset: 0x3662AA4 VA: 0x3666AA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3666AAC Offset: 0x3662AAC VA: 0x3666AAC
	public byte get_EndType() { }

	[CompilerGenerated]
	// RVA: 0x3666AB4 Offset: 0x3662AB4 VA: 0x3666AB4
	public void set_EndType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3666ABC Offset: 0x3662ABC VA: 0x3666ABC
	public bool get_IsGameEnd() { }

	[CompilerGenerated]
	// RVA: 0x3666AC4 Offset: 0x3662AC4 VA: 0x3666AC4
	public void set_IsGameEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3666AD0 Offset: 0x3662AD0 VA: 0x3666AD0
	public MahjongPlayerRoundResultData[] get_PlayerResultList() { }

	[CompilerGenerated]
	// RVA: 0x3666AD8 Offset: 0x3662AD8 VA: 0x3666AD8
	public void set_PlayerResultList(MahjongPlayerRoundResultData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3666AE0 Offset: 0x3662AE0 VA: 0x3666AE0
	public MahjongTileData[] get_UraDoraList() { }

	[CompilerGenerated]
	// RVA: 0x3666AE8 Offset: 0x3662AE8 VA: 0x3666AE8
	public void set_UraDoraList(MahjongTileData[] value) { }

	// RVA: 0x3666AF0 Offset: 0x3662AF0 VA: 0x3666AF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3666AF8 Offset: 0x3662AF8 VA: 0x3666AF8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3666B00 Offset: 0x3662B00 VA: 0x3666B00 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3666C54 Offset: 0x3662C54 VA: 0x3666C54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
