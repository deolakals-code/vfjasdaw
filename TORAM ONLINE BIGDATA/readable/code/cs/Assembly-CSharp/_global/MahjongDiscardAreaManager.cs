// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongDiscardAreaManager : MonoBehaviour // TypeDefIndex: 4415
{
	// Fields
	private MahjongSeatType seatType; // 0x20
	private Vector3 startPos; // 0x24
	private List<int> discardTileUids; // 0x30
	private Dictionary<int, MahjongTileData> discardTileDatas; // 0x38
	private Vector3 instancePos; // 0x40
	private bool isRiichi; // 0x4C
	private int riichiTileUid; // 0x50
	private MahjongTilesRenderer tilesRenderer; // 0x58
	private GameObject tileInstantPosSupporter; // 0x60
	private readonly Vector3 sourceTileScale; // 0x68
	private readonly int riichiDefaultTileUid; // 0x74

	// Properties
	public int DiscardTileCount { get; }

	// Methods

	// RVA: 0x24EC62C Offset: 0x24E862C VA: 0x24EC62C
	public int get_DiscardTileCount() { }

	// RVA: 0x24EC678 Offset: 0x24E8678 VA: 0x24EC678
	public void Initialize(MahjongTilesRenderer tilesRenderer, MahjongSeatType seatType) { }

	// RVA: 0x24EC77C Offset: 0x24E877C VA: 0x24EC77C
	public void AddDiscardTile(MahjongTileData tileData, bool isRiichi, bool isPlayAnim = True) { }

	// RVA: 0x24ED00C Offset: 0x24E900C VA: 0x24ED00C
	public void StealTile() { }

	// RVA: 0x24ED1A0 Offset: 0x24E91A0 VA: 0x24ED1A0
	public void AllClear() { }

	// RVA: 0x24ED39C Offset: 0x24E939C VA: 0x24ED39C
	public void PickUpLastTile(bool flag) { }

	// RVA: 0x24ED5D4 Offset: 0x24E95D4 VA: 0x24ED5D4
	public void ReplaceDiscardTile(MahjongTileData beforeTileUid, MahjongTileData afterTileData) { }

	// RVA: 0x24ED924 Offset: 0x24E9924 VA: 0x24ED924
	public void .ctor() { }
}
