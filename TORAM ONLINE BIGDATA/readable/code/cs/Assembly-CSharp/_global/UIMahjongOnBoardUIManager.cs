// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongOnBoardUIManager : MonoBehaviour // TypeDefIndex: 5917
{
	// Fields
	[SerializeField]
	private D3GLLabel label; // 0x20
	[SerializeField]
	private D3GLSprite sprite; // 0x28
	[SerializeField]
	private UIAtlas iconAtlas; // 0x30
	private MahjongRoomData roomData; // 0x38
	private D3GLLabel remainingTileCountLabel; // 0x40
	private D3GLLabel roundDataLabel; // 0x48
	private Dictionary<MahjongSeatType, UIMahjongOnBoardUIManager.MahjongOnBoradData> seatOnBoardData; // 0x50
	private readonly Vector3 labelsCenterPos; // 0x58
	private readonly Vector3 labelDefaultRot; // 0x64
	private readonly Vector3 labelDefaultScale; // 0x70
	private readonly Vector3 tileCountLabelDefaultScale; // 0x7C
	private readonly Vector3 scoreLabelDefaultScale; // 0x88
	private readonly Vector3 spriteDefaultScale; // 0x94
	private readonly Color scoreColor; // 0xA0
	private readonly Color eastWindColor; // 0xB0
	private readonly string myTurnSpriteOnSpriteName; // 0xC0
	private readonly string myTurnSpriteOffSpriteName; // 0xC8
	private readonly string waremeSpriteName; // 0xD0
	private static readonly Vector2 myTurnSpriteDefaultSpriteScale; // 0x0
	private const int MaxRoundCount = 16;

	// Methods

	// RVA: 0x184159C Offset: 0x183D59C VA: 0x184159C
	private void OnDestroy() { }

	// RVA: 0x1841870 Offset: 0x183D870 VA: 0x1841870
	public void Initialize(MahjongRoomData roomData, Camera topCamera, GameObject riichiStickResource) { }

	// RVA: 0x1842E60 Offset: 0x183EE60 VA: 0x1842E60
	public bool TryGetOnBoardLabels(MahjongSeatType seatType, out UIMahjongOnBoardUIManager.MahjongOnBoradData labels) { }

	// RVA: 0x18425C8 Offset: 0x183E5C8 VA: 0x18425C8
	public void ChangeScore(MahjongSeatType seatType, int score) { }

	// RVA: 0x184264C Offset: 0x183E64C VA: 0x184264C
	public void ChangeWind(MahjongSeatType seatType, byte wind) { }

	// RVA: 0x184285C Offset: 0x183E85C VA: 0x184285C
	public void ChangeMyTurnSprite(MahjongSeatType seatType, bool isOn) { }

	[IteratorStateMachine(typeof(UIMahjongOnBoardUIManager.<SpriteSizeChecker>d__27))]
	// RVA: 0x1842F28 Offset: 0x183EF28 VA: 0x1842F28
	private IEnumerator SpriteSizeChecker(D3GLSprite sprite, Vector2 size) { }

	// RVA: 0x1842B40 Offset: 0x183EB40 VA: 0x1842B40
	public void ChangeWaremeSprite(MahjongSeatType seatType, bool isOn) { }

	// RVA: 0x1842950 Offset: 0x183E950 VA: 0x1842950
	public void ChangeActiveRiichiStick(MahjongSeatType seatType, bool isActive, bool isPlayAnim = True) { }

	// RVA: 0x1842C44 Offset: 0x183EC44 VA: 0x1842C44
	public void UpdateRemainingTileCount(int count) { }

	// RVA: 0x1842D48 Offset: 0x183ED48 VA: 0x1842D48
	public void UpdateRoundData(byte round) { }

	// RVA: 0x18415A0 Offset: 0x183D5A0 VA: 0x18415A0
	public void Clear() { }

	// RVA: 0x1842FD0 Offset: 0x183EFD0 VA: 0x1842FD0
	public void InstanceTelop(byte round) { }

	// RVA: 0x184314C Offset: 0x183F14C VA: 0x184314C
	public void .ctor() { }

	// RVA: 0x1843248 Offset: 0x183F248 VA: 0x1843248
	private static void .cctor() { }
}
