// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongOpenTileManager // TypeDefIndex: 4431
{
	// Fields
	private List<MahjongTileData> tiles; // 0x10
	private List<int> stealTileUIds; // 0x18
	private MahjongOpenTileManager.OpenType openType; // 0x20
	private MahjongSeatType discardPlayer; // 0x24

	// Properties
	public MahjongTileData[] Tiles { get; }
	public int[] StealTileUIds { get; }
	public MahjongOpenTileManager.OpenType TileOpenType { get; }
	public MahjongSeatType TileDiscardPlayer { get; }

	// Methods

	// RVA: 0x24F3C24 Offset: 0x24EFC24 VA: 0x24F3C24
	public MahjongTileData[] get_Tiles() { }

	// RVA: 0x24F3C74 Offset: 0x24EFC74 VA: 0x24F3C74
	public int[] get_StealTileUIds() { }

	// RVA: 0x24F3CC4 Offset: 0x24EFCC4 VA: 0x24F3CC4
	public MahjongOpenTileManager.OpenType get_TileOpenType() { }

	// RVA: 0x24F3CCC Offset: 0x24EFCCC VA: 0x24F3CCC
	public MahjongSeatType get_TileDiscardPlayer() { }

	// RVA: 0x24F3CD4 Offset: 0x24EFCD4 VA: 0x24F3CD4
	public void .ctor(List<MahjongTileData> tiles, MahjongOpenTileManager.OpenType openType, MahjongSeatType discardPlayer, int stealTileUId = -1) { }

	// RVA: 0x24F3E24 Offset: 0x24EFE24 VA: 0x24F3E24
	public void LateKan(MahjongTileData addTile) { }
}
