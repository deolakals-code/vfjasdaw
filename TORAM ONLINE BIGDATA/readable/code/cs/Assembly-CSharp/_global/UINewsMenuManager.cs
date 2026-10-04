// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewsMenuManager : UIBaseMenuPanel // TypeDefIndex: 8188
{
	// Fields
	[SerializeField]
	private GameObject emptyMessageObject; // 0x80
	private bool Lock; // 0x88
	private Action backAction; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private readonly Dictionary<AnnouncementType, UINewsMenuManager.newsInfoData> typeKey; // 0xA0
	private List<int> buttonKeyParam; // 0xA8
	private Dictionary<int, CommunityURLManager.CommunityURLData> urlData; // 0xB0
	private Dictionary<int, OrbShopManager.NewsData> orbShopData; // 0xB8
	private UIPopWindow popWindow; // 0xC0
	[SerializeField]
	private GameObject popBanner; // 0xC8
	private PopBannerBase[] bannerData; // 0xD0
	[CompilerGenerated]
	private bool <IsOpenTradeWindow>k__BackingField; // 0xD8

	// Properties
	public bool IsOpenTradeWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CE3D10 Offset: 0x1CDFD10 VA: 0x1CE3D10
	public bool get_IsOpenTradeWindow() { }

	[CompilerGenerated]
	// RVA: 0x1CE3D18 Offset: 0x1CDFD18 VA: 0x1CE3D18
	private void set_IsOpenTradeWindow(bool value) { }

	// RVA: 0x1CE3D24 Offset: 0x1CDFD24 VA: 0x1CE3D24
	private void Awake() { }

	// RVA: 0x1CE4FC4 Offset: 0x1CE0FC4 VA: 0x1CE4FC4 Slot: 7
	protected override void Start() { }

	// RVA: 0x1CE5AE8 Offset: 0x1CE1AE8 VA: 0x1CE5AE8 Slot: 11
	protected override void OnClickButton(int index) { }

	// RVA: 0x1CE6684 Offset: 0x1CE2684 VA: 0x1CE6684
	private void closePopWindow() { }

	[IteratorStateMachine(typeof(UINewsMenuManager.<asobimoAccountAction>d__20))]
	// RVA: 0x1CE6618 Offset: 0x1CE2618 VA: 0x1CE6618
	private IEnumerator asobimoAccountAction() { }

	[IteratorStateMachine(typeof(UINewsMenuManager.<reviewInductionAction>d__21))]
	// RVA: 0x1CE65AC Offset: 0x1CE25AC VA: 0x1CE65AC
	private IEnumerator reviewInductionAction() { }

	[IteratorStateMachine(typeof(UINewsMenuManager.<functionLimitAction>d__22))]
	// RVA: 0x1CE6540 Offset: 0x1CE2540 VA: 0x1CE6540
	private IEnumerator functionLimitAction() { }

	[IteratorStateMachine(typeof(UINewsMenuManager.<tradeAction>d__23))]
	// RVA: 0x1CE64D4 Offset: 0x1CE24D4 VA: 0x1CE64D4
	private IEnumerator tradeAction() { }

	[IteratorStateMachine(typeof(UINewsMenuManager.<backFromTradeAnswer>d__24))]
	// RVA: 0x1CE680C Offset: 0x1CE280C VA: 0x1CE680C
	private IEnumerator backFromTradeAnswer(float waitTime) { }

	[IteratorStateMachine(typeof(UINewsMenuManager.<showWebAnnounce>d__25))]
	// RVA: 0x1CE63F4 Offset: 0x1CE23F4 VA: 0x1CE63F4
	private IEnumerator showWebAnnounce() { }

	// RVA: 0x1CE68D8 Offset: 0x1CE28D8 VA: 0x1CE68D8
	private void onClickParty(int partyId) { }

	// RVA: 0x1CE57D8 Offset: 0x1CE17D8 VA: 0x1CE57D8
	protected void SetButton(string text, float y, int id, string iconSpriteName) { }

	// RVA: 0x1CE68DC Offset: 0x1CE28DC VA: 0x1CE68DC
	private void OnHoverButton(int id) { }

	// RVA: 0x1CE4C68 Offset: 0x1CE0C68 VA: 0x1CE4C68
	private void LoadPopBannerTexture() { }

	// RVA: 0x1CE6ABC Offset: 0x1CE2ABC VA: 0x1CE6ABC
	private void OnClickBanner(int selectedBanner) { }

	// RVA: 0x1CE6B04 Offset: 0x1CE2B04 VA: 0x1CE6B04 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CE6B54 Offset: 0x1CE2B54 VA: 0x1CE6B54 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CE6B68 Offset: 0x1CE2B68 VA: 0x1CE6B68
	private void OnDestroy() { }

	// RVA: 0x1CE6BC8 Offset: 0x1CE2BC8 VA: 0x1CE6BC8
	public void .ctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1CE7698 Offset: 0x1CE3698 VA: 0x1CE7698
	private void <>n__0() { }
}
