// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Game
public class MahjongStartRoundEvent : EventSubBase // TypeDefIndex: 12842
{
	// Fields
	[CompilerGenerated]
	private MahjongRoundSituationData <RoundSituation>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TileCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongPlayerData[] <PlayerList>k__BackingField; // 0x30

	// Properties
	public MahjongRoundSituationData RoundSituation { get; set; }
	public byte TileCount { get; set; }
	public MahjongPlayerData[] PlayerList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3666EEC Offset: 0x3662EEC VA: 0x3666EEC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3666EF4 Offset: 0x3662EF4 VA: 0x3666EF4
	public MahjongRoundSituationData get_RoundSituation() { }

	[CompilerGenerated]
	// RVA: 0x3666EFC Offset: 0x3662EFC VA: 0x3666EFC
	public void set_RoundSituation(MahjongRoundSituationData value) { }

	[CompilerGenerated]
	// RVA: 0x3666F04 Offset: 0x3662F04 VA: 0x3666F04
	public byte get_TileCount() { }

	[CompilerGenerated]
	// RVA: 0x3666F0C Offset: 0x3662F0C VA: 0x3666F0C
	public void set_TileCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3666F14 Offset: 0x3662F14 VA: 0x3666F14
	public MahjongPlayerData[] get_PlayerList() { }

	[CompilerGenerated]
	// RVA: 0x3666F1C Offset: 0x3662F1C VA: 0x3666F1C
	public void set_PlayerList(MahjongPlayerData[] value) { }

	// RVA: 0x3666F24 Offset: 0x3662F24 VA: 0x3666F24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3666F2C Offset: 0x3662F2C VA: 0x3666F2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3666F34 Offset: 0x3662F34 VA: 0x3666F34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366703C Offset: 0x366303C VA: 0x366703C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
