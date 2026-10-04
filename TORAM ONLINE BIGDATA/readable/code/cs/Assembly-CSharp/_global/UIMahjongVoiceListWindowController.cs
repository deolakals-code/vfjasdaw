// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongVoiceListWindowController : MonoBehaviour // TypeDefIndex: 5969
{
	// Fields
	[SerializeField]
	private UILabel titleLabel; // 0x20
	[SerializeField]
	private UILabel voiceCountLabel; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private UIMahjongVoiceListContentManager baseContent; // 0x38
	[SerializeField]
	private GameObject[] exclamationMarks; // 0x40
	[SerializeField]
	private AnimationCurve newLabelAlphaCurve; // 0x48
	[SerializeField]
	private AnimationCurve newLabelPosCurve; // 0x50
	private MahjongRoomData roomData; // 0x58
	private UIMahjongMainManager main; // 0x60
	private List<UIMahjongVoiceListContentManager> voiceList; // 0x68
	private MahjongVoicePattern selectedPattern; // 0x70
	private const float contentHeight = 100;
	private float animationTimer; // 0x74
	private Vector3 newLabelDefaultPos; // 0x78
	private const float newLabelUpRange = 8;

	// Properties
	public bool InputLock { get; }

	// Methods

	// RVA: 0x1856E20 Offset: 0x1852E20 VA: 0x1856E20
	public bool get_InputLock() { }

	// RVA: 0x1856EC4 Offset: 0x1852EC4 VA: 0x1856EC4
	private void Update() { }

	// RVA: 0x18570C8 Offset: 0x18530C8 VA: 0x18570C8
	public void Initialize(MahjongRoomData roomData, UIMahjongMainManager mainManager) { }

	// RVA: 0x18579C0 Offset: 0x18539C0 VA: 0x18579C0
	public void OnClickChangeVoicePattern(int pattern) { }

	// RVA: 0x1857A04 Offset: 0x1853A04 VA: 0x1857A04
	public bool IsHaveNewVoice(MahjongRoomData roomData) { }

	// RVA: 0x1857B04 Offset: 0x1853B04 VA: 0x1857B04
	public void OnClickCloseButton() { }

	// RVA: 0x1857200 Offset: 0x1853200 VA: 0x1857200
	private void ChangeVoicePattern(MahjongVoicePattern pattern) { }

	// RVA: 0x185792C Offset: 0x185392C VA: 0x185792C
	private bool GetVoiceFlag(long[] flags, int type) { }

	// RVA: 0x1857B50 Offset: 0x1853B50 VA: 0x1857B50
	private void ActiveVoiceFlag(long[] flags, int type) { }

	// RVA: 0x1857BA4 Offset: 0x1853BA4 VA: 0x1857BA4
	private void UpdateVoiceFlag(int type) { }

	// RVA: 0x1857980 Offset: 0x1853980 VA: 0x1857980
	private void ChangeVoicePatternButoonExclamationMarkActive(int pattern, bool isActive) { }

	// RVA: 0x1857D40 Offset: 0x1853D40 VA: 0x1857D40
	public void .ctor() { }
}
