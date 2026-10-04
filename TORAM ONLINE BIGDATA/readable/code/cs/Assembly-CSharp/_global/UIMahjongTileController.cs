// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongTileController : MonoBehaviour // TypeDefIndex: 5960
{
	// Fields
	[SerializeField]
	private UITexture tilePattern; // 0x20
	[SerializeField]
	private UISprite tileFrame; // 0x28
	[SerializeField]
	private UISprite disablePanel; // 0x30
	[SerializeField]
	private UILabel tileNumberLabel; // 0x38
	[SerializeField]
	private TweenColor tweenColor; // 0x40
	[SerializeField]
	private Color doraPickupColorFrom; // 0x48
	[SerializeField]
	private Color doraPickupColorTo; // 0x58
	private MahjongRoomData room; // 0x68
	private UIMahjongGameManager gameManager; // 0x70
	private MahjongTileData tileData; // 0x78
	private byte index; // 0x80
	private byte beforeIndex; // 0x81
	private bool isUpMove; // 0x82
	private const float upTilePos = 20;
	private BoxCollider boxCollider; // 0x88
	private bool isDrag; // 0x90
	private float dragTime; // 0x94
	private TweenPosition xMoveTween; // 0x98
	private float duration; // 0xA0
	private const float discardHeightPos = 165;
	private TweenPosition yMoveTween; // 0xA8
	private bool isEnable; // 0xB0
	private bool isDora; // 0xB1
	private Coroutine autoDiscardCoroutine; // 0xB8
	private readonly Rect defaultUVRect; // 0xC0
	private readonly Vector2 changeUVRectPos; // 0xD0
	private const float redTileUVPos = 0.9;
	private const int sameKindTileCount = 9;
	private readonly Color tileReverseSideColor; // 0xD8
	private readonly Vector3 tileNumberLabelPos; // 0xE8
	private readonly Vector3 tileNumberLabelScale; // 0xF4

	// Properties
	private float PosX { get; }
	private float PosY { get; }
	public byte Index { get; }
	public MahjongTileData TileData { get; }
	public int TileId { get; }
	public int TileUid { get; }
	public bool IsDrag { get; }
	public bool IsActive { get; }
	public bool IsEnable { get; }
	public bool IsUpMove { get; }

	// Methods

	// RVA: 0x18536D8 Offset: 0x184F6D8 VA: 0x18536D8
	private float get_PosX() { }

	// RVA: 0x1853704 Offset: 0x184F704 VA: 0x1853704
	private float get_PosY() { }

	// RVA: 0x1853738 Offset: 0x184F738 VA: 0x1853738
	public byte get_Index() { }

	// RVA: 0x1853740 Offset: 0x184F740 VA: 0x1853740
	public MahjongTileData get_TileData() { }

	// RVA: 0x1853748 Offset: 0x184F748 VA: 0x1853748
	public int get_TileId() { }

	// RVA: 0x1853760 Offset: 0x184F760 VA: 0x1853760
	public int get_TileUid() { }

	// RVA: 0x1853778 Offset: 0x184F778 VA: 0x1853778
	public bool get_IsDrag() { }

	// RVA: 0x1853780 Offset: 0x184F780 VA: 0x1853780
	public bool get_IsActive() { }

	// RVA: 0x18537A0 Offset: 0x184F7A0 VA: 0x18537A0
	public bool get_IsEnable() { }

	// RVA: 0x18537A8 Offset: 0x184F7A8 VA: 0x18537A8
	public bool get_IsUpMove() { }

	// RVA: 0x18537B0 Offset: 0x184F7B0 VA: 0x18537B0
	private void Start() { }

	// RVA: 0x1853808 Offset: 0x184F808 VA: 0x1853808
	private void Update() { }

	// RVA: 0x1853DEC Offset: 0x184FDEC VA: 0x1853DEC
	public void Initialize(MahjongRoomData roomData, byte index, MahjongTileData tileData, bool isDora, UIMahjongGameManager gameManager) { }

	// RVA: 0x18546A4 Offset: 0x18506A4 VA: 0x18546A4
	public void Initialize(MahjongRoomData roomData, int tileId, bool isRed) { }

	// RVA: 0x1854788 Offset: 0x1850788 VA: 0x1854788
	public void SetIndex(int index) { }

	// RVA: 0x1854794 Offset: 0x1850794 VA: 0x1854794
	public void ChangeDragFlag(bool flag) { }

	// RVA: 0x18547A0 Offset: 0x18507A0 VA: 0x18547A0
	public void OnClickButton() { }

	// RVA: 0x1854AA4 Offset: 0x1850AA4 VA: 0x1854AA4
	public void OnPressButton() { }

	// RVA: 0x1854B74 Offset: 0x1850B74 VA: 0x1854B74
	public void OnReleaseButton() { }

	// RVA: 0x1854CB0 Offset: 0x1850CB0 VA: 0x1854CB0
	public void OnMouseOverButton() { }

	// RVA: 0x1854CE4 Offset: 0x1850CE4 VA: 0x1854CE4
	public void OnMouseOutButton() { }

	// RVA: 0x1854D20 Offset: 0x1850D20 VA: 0x1854D20
	public void DrawTileAnim() { }

	// RVA: 0x1854658 Offset: 0x1850658 VA: 0x1854658
	public void ChangeEnable(bool isEnable, bool isChangePanel) { }

	// RVA: 0x18548A8 Offset: 0x18508A8 VA: 0x18548A8
	public void DiscardTile() { }

	// RVA: 0x185501C Offset: 0x185101C VA: 0x185501C
	public void AutoDiscardTile() { }

	// RVA: 0x18551A8 Offset: 0x18511A8 VA: 0x18551A8
	public void ActiveDoraPickupTweenColor() { }

	// RVA: 0x18551FC Offset: 0x18511FC VA: 0x18551FC
	public void StartDoraPickupTweenLoop() { }

	// RVA: 0x1855268 Offset: 0x1851268 VA: 0x1855268
	public void StopTweenColor() { }

	// RVA: 0x1854998 Offset: 0x1850998 VA: 0x1854998
	public void ChangeTileHeightMove(bool flag) { }

	// RVA: 0x1854024 Offset: 0x1850024 VA: 0x1854024
	private void ChangeTilePattern(int tileId, bool isRed) { }

	// RVA: 0x18541A0 Offset: 0x18501A0 VA: 0x18541A0
	private void SetTileNumberLabel(int tileId) { }

	// RVA: 0x18545D4 Offset: 0x18505D4 VA: 0x18545D4
	private void ChangeDepth() { }

	[IteratorStateMachine(typeof(UIMahjongTileController.<AutoDiscard>d__73))]
	// RVA: 0x185513C Offset: 0x185113C VA: 0x185513C
	private IEnumerator AutoDiscard() { }

	// RVA: 0x1853A28 Offset: 0x184FA28 VA: 0x1853A28
	private void MoveTileY(bool isUp) { }

	// RVA: 0x1853BFC Offset: 0x184FBFC VA: 0x1853BFC
	private void MoveTileX() { }

	// RVA: 0x18552B0 Offset: 0x18512B0 VA: 0x18552B0
	public void .ctor() { }
}
