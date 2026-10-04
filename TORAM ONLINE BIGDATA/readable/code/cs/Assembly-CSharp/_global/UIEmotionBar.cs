// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEmotionBar : MonoBehaviour // TypeDefIndex: 6505
{
	// Fields
	private static readonly int maxDispEmotion; // 0x0
	private static readonly float defaultScrollX; // 0x4
	private static readonly float referenceButtonPosition; // 0x8
	private static readonly float buttonSpace; // 0xC
	private static readonly float differenceButtonPosition; // 0x10
	private static readonly int maxBarWidth; // 0x14
	private static readonly int minBarWidth; // 0x18
	[SerializeField]
	private GameObject emotionBarObj; // 0x20
	[SerializeField]
	private Transform emotionParent; // 0x28
	[SerializeField]
	private GameObject scrollObject; // 0x30
	[SerializeField]
	private GameObject switchButton; // 0x38
	[SerializeField]
	private UISprite chatBackSprite; // 0x40
	[SerializeField]
	private UILabel textLabel; // 0x48
	[SerializeField]
	private GameObject emotionButton; // 0x50
	[SerializeField]
	private UISprite emotionBack; // 0x58
	private SystemTextManager systemTextManager; // 0x60
	private PlayerDataManager playerDataManager; // 0x68
	private List<GameObject> emotionButtonList; // 0x70
	private UISprite switchIcon; // 0x78
	private List<UIWidget> widgetList; // 0x80
	private Dictionary<int, UIIcon> switchEmotionIconList; // 0x88
	private float scroll; // 0x90
	private int offset; // 0x94
	private float chatDefaultHeight; // 0x98
	private float startTime; // 0x9C
	private UIEmotionBar.EmotionBarFlag emotionFlag; // 0xA0
	private Coroutine barOpenAndClose; // 0xA8
	private Coroutine dragOver; // 0xB0
	private byte lastOpenButtonNum; // 0xB8

	// Methods

	// RVA: 0x196056C Offset: 0x195C56C VA: 0x196056C
	private void Start() { }

	// RVA: 0x1961158 Offset: 0x195D158 VA: 0x1961158
	public List<EmotionPlayer.EmotionType> GetEmotionBarData() { }

	// RVA: 0x19612CC Offset: 0x195D2CC VA: 0x19612CC
	private void Update() { }

	// RVA: 0x1960918 Offset: 0x195C918 VA: 0x1960918
	public void SetWidget(GameObject obj) { }

	// RVA: 0x19619F4 Offset: 0x195D9F4 VA: 0x19619F4
	public void AddAlpha() { }

	// RVA: 0x1961C14 Offset: 0x195DC14 VA: 0x1961C14
	public void SubAlpha() { }

	// RVA: 0x1961A40 Offset: 0x195DA40 VA: 0x1961A40
	private void ChangeWidgetAlpha(float alpha) { }

	// RVA: 0x1961C5C Offset: 0x195DC5C VA: 0x1961C5C
	private void UpdateAlpha(bool isFadeIn) { }

	[IteratorStateMachine(typeof(UIEmotionBar.<FadeBattle>d__38))]
	// RVA: 0x1961900 Offset: 0x195D900 VA: 0x1961900
	private IEnumerator FadeBattle(bool isFadeIn) { }

	// RVA: 0x1961988 Offset: 0x195D988 VA: 0x1961988
	private void FadeEmotionBar(bool isFadeIn) { }

	// RVA: 0x1960998 Offset: 0x195C998 VA: 0x1960998
	private void CreateButton() { }

	// RVA: 0x1961D0C Offset: 0x195DD0C VA: 0x1961D0C
	private void SetEmotionButton(GameObject button, int id) { }

	// RVA: 0x1962168 Offset: 0x195E168 VA: 0x1962168
	private void UpdateEmotionBar() { }

	// RVA: 0x1962868 Offset: 0x195E868 VA: 0x1962868
	private void UpdateScroll() { }

	// RVA: 0x19629FC Offset: 0x195E9FC VA: 0x19629FC
	public void UpdateFavoriteEmotion(EmotionPlayer.EmotionType[] idList) { }

	// RVA: 0x1962C0C Offset: 0x195EC0C VA: 0x1962C0C
	public void Fade(bool isFadeOut) { }

	// RVA: 0x1962D48 Offset: 0x195ED48 VA: 0x1962D48
	private void SetDefaultHeight() { }

	[IteratorStateMachine(typeof(UIEmotionBar.<OpenEmotionBar>d__47))]
	// RVA: 0x1962E60 Offset: 0x195EE60 VA: 0x1962E60
	private IEnumerator OpenEmotionBar(bool isOpen) { }

	[IteratorStateMachine(typeof(UIEmotionBar.<DragOverScroll>d__48))]
	// RVA: 0x1962EE8 Offset: 0x195EEE8 VA: 0x1962EE8
	private IEnumerator DragOverScroll(float destX) { }

	// RVA: 0x1962748 Offset: 0x195E748 VA: 0x1962748
	private float MaxDispRange() { }

	// RVA: 0x196087C Offset: 0x195C87C VA: 0x196087C
	private float StartScrollX() { }

	// RVA: 0x1961C68 Offset: 0x195DC68 VA: 0x1961C68
	private int DispButtonCount() { }

	// RVA: 0x1960DD0 Offset: 0x195CDD0 VA: 0x1960DD0
	public void SetEmotionBarPosition(bool isOpen) { }

	// RVA: 0x1962804 Offset: 0x195E804 VA: 0x1962804
	private void ChangeEmotionColliderEnabled(GameObject button, bool isEnabled) { }

	// RVA: 0x1962F6C Offset: 0x195EF6C VA: 0x1962F6C
	private void ChangeEmotionBarColliderEnabled(bool isEnabled) { }

	// RVA: 0x1963084 Offset: 0x195F084 VA: 0x1963084
	public void SwitchEmotionIcon() { }

	// RVA: 0x19632C0 Offset: 0x195F2C0 VA: 0x19632C0
	private void OnRelease() { }

	// RVA: 0x19633F4 Offset: 0x195F3F4 VA: 0x19633F4
	private void OnSwitchButton() { }

	// RVA: 0x196353C Offset: 0x195F53C VA: 0x196353C
	private void OnClickButton(int id) { }

	// RVA: 0x1963604 Offset: 0x195F604 VA: 0x1963604
	private void OnScroll(float val) { }

	// RVA: 0x1963690 Offset: 0x195F690 VA: 0x1963690
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x19636A0 Offset: 0x195F6A0 VA: 0x19636A0
	public void .ctor() { }

	// RVA: 0x19637D0 Offset: 0x195F7D0 VA: 0x19637D0
	private static void .cctor() { }
}
