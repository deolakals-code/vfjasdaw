// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongCallSelectWindowManager : MonoBehaviour // TypeDefIndex: 5876
{
	// Fields
	[SerializeField]
	private GameObject window; // 0x20
	[SerializeField]
	private Transform tileParent; // 0x28
	[SerializeField]
	private Transform tileObject; // 0x30
	[SerializeField]
	private UISprites frame; // 0x38
	[SerializeField]
	private GameObject leftFrame; // 0x40
	[SerializeField]
	private GameObject rightFrame; // 0x48
	[SerializeField]
	private UISprite baseSprite; // 0x50
	private MahjongRoomData mahjongRoomData; // 0x58
	private List<List<MahjongTileData>> candidateTile; // 0x60
	private List<MahjongTileData> _candidateTile; // 0x68
	private int choiceCount; // 0x70
	private List<UIMahjongTileController> tiles; // 0x78
	private Action<int> buttonAction; // 0x80
	private Action cancelAction; // 0x88
	private const float startGenerationPos_Odd = 36.5;
	private const float startGenerationPos_Even = 47;

	// Properties
	private MahjongRoomData roomData { get; }

	// Methods

	// RVA: 0x1814830 Offset: 0x1810830 VA: 0x1814830
	private MahjongRoomData get_roomData() { }

	// RVA: 0x1814920 Offset: 0x1810920 VA: 0x1814920
	private void Awake() { }

	// RVA: 0x1814944 Offset: 0x1810944 VA: 0x1814944
	public bool Initialize(List<List<MahjongTileData>> candidateTile, Action<int> buttonAction, Action cancelAction) { }

	// RVA: 0x1815268 Offset: 0x1811268 VA: 0x1815268
	public void Initialize(MahjongWaitWinningTile[] winningTiles) { }

	// RVA: 0x1815750 Offset: 0x1811750 VA: 0x1815750
	public void Initialize(int[] tileIds) { }

	// RVA: 0x1815BE8 Offset: 0x1811BE8 VA: 0x1815BE8
	public bool Initialize(Action<int> buttonAction, Action cancelAction) { }

	// RVA: 0x1816834 Offset: 0x1812834 VA: 0x1816834
	public void OnClickTileChoice(int index) { }

	// RVA: 0x18168C8 Offset: 0x18128C8 VA: 0x18168C8
	public void OnClickHandTileChoice(int uid) { }

	// RVA: 0x18169B4 Offset: 0x18129B4 VA: 0x18169B4
	public void OnClickCloseMenu() { }

	// RVA: 0x1815114 Offset: 0x1811114 VA: 0x1815114
	private void SetFrame(int choiceCount, float contentCount) { }

	// RVA: 0x18166E0 Offset: 0x18126E0 VA: 0x18166E0
	private void SetFrameNoSpace(int choiceCount, int contentCount) { }

	// RVA: 0x1816A20 Offset: 0x1812A20 VA: 0x1816A20
	public void .ctor() { }
}
