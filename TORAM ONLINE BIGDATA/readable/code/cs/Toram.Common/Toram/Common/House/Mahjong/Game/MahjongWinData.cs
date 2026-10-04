// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongWinData : BinaryBase // TypeDefIndex: 12587
{
	// Fields
	[CompilerGenerated]
	private bool <IsTsumo>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <LastTileUid>k__BackingField; // 0x1C
	[CompilerGenerated]
	private MahjongYakuData[] <YakuList>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Fu>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <YakuTotalScore>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <HarvestDanceTileId>k__BackingField; // 0x30

	// Properties
	public bool IsTsumo { get; set; }
	public int LastTileUid { get; set; }
	public MahjongYakuData[] YakuList { get; set; }
	public byte Fu { get; set; }
	public int YakuTotalScore { get; set; }
	public int HarvestDanceTileId { get; set; }

	// Methods

	// RVA: 0x36282D8 Offset: 0x36242D8 VA: 0x36282D8
	public void .ctor() { }

	// RVA: 0x36282D0 Offset: 0x36242D0 VA: 0x36282D0
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36282E0 Offset: 0x36242E0 VA: 0x36282E0
	public bool get_IsTsumo() { }

	[CompilerGenerated]
	// RVA: 0x36282E8 Offset: 0x36242E8 VA: 0x36282E8
	public void set_IsTsumo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36282F4 Offset: 0x36242F4 VA: 0x36282F4
	public int get_LastTileUid() { }

	[CompilerGenerated]
	// RVA: 0x36282FC Offset: 0x36242FC VA: 0x36282FC
	public void set_LastTileUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3628304 Offset: 0x3624304 VA: 0x3628304
	public MahjongYakuData[] get_YakuList() { }

	[CompilerGenerated]
	// RVA: 0x362830C Offset: 0x362430C VA: 0x362830C
	public void set_YakuList(MahjongYakuData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3628314 Offset: 0x3624314 VA: 0x3628314
	public byte get_Fu() { }

	[CompilerGenerated]
	// RVA: 0x362831C Offset: 0x362431C VA: 0x362831C
	public void set_Fu(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3628324 Offset: 0x3624324 VA: 0x3628324
	public int get_YakuTotalScore() { }

	[CompilerGenerated]
	// RVA: 0x362832C Offset: 0x362432C VA: 0x362832C
	public void set_YakuTotalScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x3628334 Offset: 0x3624334 VA: 0x3628334
	public int get_HarvestDanceTileId() { }

	[CompilerGenerated]
	// RVA: 0x362833C Offset: 0x362433C VA: 0x362833C
	public void set_HarvestDanceTileId(int value) { }

	// RVA: 0x3628344 Offset: 0x3624344 VA: 0x3628344 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36283F8 Offset: 0x36243F8 VA: 0x36283F8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
