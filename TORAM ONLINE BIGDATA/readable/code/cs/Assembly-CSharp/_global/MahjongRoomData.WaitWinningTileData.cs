// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongRoomData.WaitWinningTileData // TypeDefIndex: 2352
{
	// Fields
	private MahjongWaitWinningTile[] winTileIds; // 0x10
	private ValueTuple<int, MahjongWaitWinningTile[]>[] handTileWinTileIds; // 0x18

	// Properties
	public ValueTuple<int, MahjongWaitWinningTile[]> handTileWinTileIdFirst { get; }

	// Methods

	// RVA: 0x219CE04 Offset: 0x2198E04 VA: 0x219CE04
	public ValueTuple<int, MahjongWaitWinningTile[]> get_handTileWinTileIdFirst() { }

	// RVA: 0x2198FC8 Offset: 0x2194FC8 VA: 0x2198FC8
	public void UpdateWinTileIds(MahjongWaitWinningTile[] winTileIds) { }

	// RVA: 0x219A5CC Offset: 0x21965CC VA: 0x219A5CC
	public void UpdateHandTileWinTileIds(ValueTuple<int, MahjongWaitWinningTile[]>[] handTileWinIds) { }

	// RVA: 0x219CE88 Offset: 0x2198E88 VA: 0x219CE88
	public bool TryGetWinTileIds(out MahjongWaitWinningTile[] winTileIds) { }

	// RVA: 0x219CF08 Offset: 0x2198F08 VA: 0x219CF08
	public bool TryGetHandTileWinTileIds(int uid, out MahjongWaitWinningTile[] ids) { }

	// RVA: 0x219B548 Offset: 0x2197548 VA: 0x219B548
	public bool TryGetHandTileWinTileIds(out ValueTuple<int, MahjongWaitWinningTile[]>[] winTiles) { }

	// RVA: 0x219A5F0 Offset: 0x21965F0 VA: 0x219A5F0
	public bool IsForkingWinTileIds() { }

	// RVA: 0x219CFE0 Offset: 0x2198FE0 VA: 0x219CFE0
	public bool TryGetHandTileWinTileUids(out int[] ids) { }

	// RVA: 0x2198FC0 Offset: 0x2194FC0 VA: 0x2198FC0
	public void .ctor() { }
}
