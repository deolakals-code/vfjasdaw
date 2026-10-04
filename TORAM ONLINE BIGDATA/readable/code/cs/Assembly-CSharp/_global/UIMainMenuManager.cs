// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMainMenuManager : UIBasePanel // TypeDefIndex: 8168
{
	// Fields
	[SerializeField]
	private GameObject newsNew; // 0x30
	[SerializeField]
	private UIImageButton[] buttonList; // 0x38
	[SerializeField]
	private UISprite[] iconList; // 0x40
	[SerializeField]
	private GameObject[] buttonObjectList; // 0x48
	[SerializeField]
	private GameObject popBanner; // 0x50
	[SerializeField]
	private UITexture popBannerLTexture; // 0x58
	[SerializeField]
	private UITexture popBannerRTexture; // 0x60
	[SerializeField]
	private GameObject popButton; // 0x68
	[SerializeField]
	private GameObject popSelectButton; // 0x70
	private float popUpdateTime; // 0x78
	private Texture2D[] saveTexture; // 0x80
	private int selectedBanner; // 0x88
	private bool initPopBanner; // 0x8C
	private PopBannerBase[] bannerData; // 0x90
	private bool pushBanner; // 0x98
	private bool dragBanner; // 0x99
	[SerializeField]
	private UIIruna2Anchor messageAnchor; // 0xA0
	[SerializeField]
	private UILabel messageTitle; // 0xA8
	[SerializeField]
	private UILabel messageName; // 0xB0
	[SerializeField]
	private UILabel messageLabel; // 0xB8
	[SerializeField]
	private UISprite[] messageIcon; // 0xC0
	[SerializeField]
	private UILabel coinNewLabel; // 0xC8
	private HouseManager houseManager; // 0xD0
	private bool cancelCheck; // 0xD8
	private int panelId; // 0xDC

	// Methods

	// RVA: 0x1CDF86C Offset: 0x1CDB86C VA: 0x1CDF86C
	private void Start() { }

	// RVA: 0x1CE0BD8 Offset: 0x1CDCBD8 VA: 0x1CE0BD8
	private void OnDestroy() { }

	// RVA: 0x1CE0668 Offset: 0x1CDC668 VA: 0x1CE0668
	private void ActiveButton(UIMainMenuManager.MenuType[] types) { }

	// RVA: 0x1CE0C54 Offset: 0x1CDCC54 VA: 0x1CE0C54
	public void ChangePanel() { }

	// RVA: 0x1CE0D50 Offset: 0x1CDCD50 VA: 0x1CE0D50
	private void Update() { }

	// RVA: 0x1CE0D60 Offset: 0x1CDCD60 VA: 0x1CE0D60
	private void UpdateBanner() { }

	// RVA: 0x1CE0800 Offset: 0x1CDC800 VA: 0x1CE0800
	private void LoadPopBannerTexture() { }

	// RVA: 0x1CE0DEC Offset: 0x1CDCDEC VA: 0x1CE0DEC
	private Vector3 PageButtonPos(int index) { }

	// RVA: 0x1CE0EBC Offset: 0x1CDCEBC VA: 0x1CE0EBC
	private int SelectData(int add, int select) { }

	// RVA: 0x1CE0F84 Offset: 0x1CDCF84 VA: 0x1CE0F84
	private void BannerMove(UITexture before, UITexture next, int nextSelect) { }

	// RVA: 0x1CE0DB0 Offset: 0x1CDCDB0 VA: 0x1CE0DB0
	private void BannerRightMove() { }

	// RVA: 0x1CE1158 Offset: 0x1CDD158 VA: 0x1CE1158
	private void BannerLeftMove() { }

	// RVA: 0x1CE11A4 Offset: 0x1CDD1A4 VA: 0x1CE11A4
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1CE1218 Offset: 0x1CDD218 VA: 0x1CE1218
	private void OnPress(bool pressed) { }

	// RVA: 0x1CE122C Offset: 0x1CDD22C VA: 0x1CE122C
	private void OnClick() { }

	// RVA: 0x1CE128C Offset: 0x1CDD28C VA: 0x1CE128C
	private void OnClickChangeEdit() { }

	[IteratorStateMachine(typeof(UIMainMenuManager.<PopUpChangeEditWindow>d__42))]
	// RVA: 0x1CE158C Offset: 0x1CDD58C VA: 0x1CE158C
	private IEnumerator PopUpChangeEditWindow(string title, string button, string messageText, int editType, Action callback) { }

	[IteratorStateMachine(typeof(UIMainMenuManager.<PopUpGMUserHouseAnchortWindow>d__43))]
	// RVA: 0x1CE14FC Offset: 0x1CDD4FC VA: 0x1CE14FC
	private IEnumerator PopUpGMUserHouseAnchortWindow(Action callback) { }

	// RVA: 0x1CE1670 Offset: 0x1CDD670 VA: 0x1CE1670
	public void OnChangeUIPanel(int param) { }

	[IteratorStateMachine(typeof(UIMainMenuManager.<connectWait>d__45))]
	// RVA: 0x1CE19B4 Offset: 0x1CDD9B4 VA: 0x1CE19B4
	private IEnumerator connectWait(Func<bool> check, Action callback) { }

	// RVA: 0x1CE1A58 Offset: 0x1CDDA58 VA: 0x1CE1A58 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CE1B14 Offset: 0x1CDDB14 VA: 0x1CE1B14 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CE1B98 Offset: 0x1CDDB98 VA: 0x1CE1B98
	public void .ctor() { }
}
