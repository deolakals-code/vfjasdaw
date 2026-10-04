// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongOpenTileAreaManager : MonoBehaviour // TypeDefIndex: 4429
{
	// Fields
	private MahjongSeatType seatType; // 0x20
	private readonly Vector3 startPos; // 0x24
	private readonly Vector3 northTileStartPos; // 0x30
	private GameObject tileInstantPosSupporter; // 0x40
	private const float tileWidthSize = 0.11;
	private const float tileHeightSize = 0.155;
	private MahjongTilesRenderer tilesRenderer; // 0x48
	private List<int> tileUids; // 0x50
	private int northTileCount; // 0x58
	private List<MahjongOpenTileAreaManager.FuroDataBase> furoDatas; // 0x60

	// Properties
	public int FuroDataCount { get; }

	// Methods

	// RVA: 0x24F1730 Offset: 0x24ED730 VA: 0x24F1730
	public int get_FuroDataCount() { }

	// RVA: 0x24F177C Offset: 0x24ED77C VA: 0x24F177C
	public void Initialize(MahjongTilesRenderer tilesRenderer, MahjongSeatType seatType) { }

	// RVA: 0x24F17AC Offset: 0x24ED7AC VA: 0x24F17AC
	public void AddMentsu(MahjongMentsuData mentsuData, MahjongSeatType discardPlayer, MahjongCallType callType, int stealTileUid, bool isPlayAnim = True) { }

	// RVA: 0x24F289C Offset: 0x24EE89C VA: 0x24F289C
	private List<MahjongTilesRenderer.TileTrans> AddOpenTile(MahjongMentsuData mentsuData, MahjongSeatType discardPlayer, int stealTileUid, bool isAnkan, bool isPlayAnim) { }

	// RVA: 0x24F3910 Offset: 0x24EF910 VA: 0x24F3910
	public void AllClear() { }

	// RVA: 0x24F3AE4 Offset: 0x24EFAE4 VA: 0x24F3AE4
	public void .ctor() { }
}
