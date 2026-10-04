// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutListManager : UIBasePanel // TypeDefIndex: 6571
{
	// Fields
	private static readonly int PageNum; // 0x0
	private static readonly int ListButtonNum; // 0x4
	[SerializeField]
	private GameObject shortcutButtonObject; // 0x30
	[SerializeField]
	private GameObject listAnchorObject; // 0x38
	private UIIruna2Anchor listAnchor; // 0x40
	[SerializeField]
	private UILabel slotLabel; // 0x48
	private string[] slotText; // 0x50
	[SerializeField]
	private GameObject backListAnchorObject; // 0x58
	private UIIruna2Anchor backListAnchor; // 0x60
	[SerializeField]
	private UILabel backLabel; // 0x68
	[SerializeField]
	private UISprite leftArrow; // 0x70
	public Dictionary<int, List<UIShortcutListButton>> switchEmotionIconList; // 0x78
	private ShortcutData[] shortcutData; // 0x80
	private float checkDist; // 0x88
	private Vector2 moveVector; // 0x8C
	private int pageId; // 0x94
	private UIShortcutListButton[] listButtons; // 0x98
	private Transform[] backListButtonPosition; // 0xA0
	private bool selectClose; // 0xA8
	private bool touchFlag; // 0xA9
	private bool mainPanelCheck; // 0xAA
	private ShortcutManager.ShortcutListType activeType; // 0xAC
	[CompilerGenerated]
	private UnityAction <CloseAction>k__BackingField; // 0xB0

	// Properties
	public UnityAction CloseAction { get; set; }
	public ShortcutManager.ShortcutListType ActiveType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1988C1C Offset: 0x1984C1C VA: 0x1988C1C
	public UnityAction get_CloseAction() { }

	[CompilerGenerated]
	// RVA: 0x1988C24 Offset: 0x1984C24 VA: 0x1988C24
	public void set_CloseAction(UnityAction value) { }

	// RVA: 0x1988C2C Offset: 0x1984C2C VA: 0x1988C2C
	public ShortcutManager.ShortcutListType get_ActiveType() { }

	// RVA: 0x1988C34 Offset: 0x1984C34 VA: 0x1988C34
	private void Start() { }

	// RVA: 0x1988C38 Offset: 0x1984C38 VA: 0x1988C38
	private void OnDestroy() { }

	// RVA: 0x1988C90 Offset: 0x1984C90 VA: 0x1988C90
	private void LateUpdate() { }

	// RVA: 0x1988F30 Offset: 0x1984F30 VA: 0x1988F30
	public void Initialize(ShortcutManager.ShortcutListType type, bool mainPanel, ShortcutData[] shortcutList, string[] slotTextList, int openPageId, bool close) { }

	// RVA: 0x19892AC Offset: 0x19852AC VA: 0x19892AC
	public void ListButtonUpdate(ShortcutData[] shortcutList) { }

	// RVA: 0x19897CC Offset: 0x19857CC VA: 0x19897CC
	public void ListSkillButtonLabelUpdate() { }

	// RVA: 0x19898D4 Offset: 0x19858D4 VA: 0x19898D4
	public void PanelUpdate() { }

	// RVA: 0x19890C4 Offset: 0x19850C4 VA: 0x19890C4
	private void PanelClose() { }

	// RVA: 0x19898EC Offset: 0x19858EC VA: 0x19898EC
	private void ResetPanel() { }

	// RVA: 0x19891DC Offset: 0x19851DC VA: 0x19891DC
	private void PanelOpen(int page) { }

	// RVA: 0x1989C04 Offset: 0x1985C04 VA: 0x1989C04
	private void CreatePanel() { }

	// RVA: 0x19893C4 Offset: 0x19853C4 VA: 0x19893C4
	private void SetShortcutButton(UIShortcutListButton button, int index) { }

	// RVA: 0x198A060 Offset: 0x1986060 VA: 0x198A060
	private void ShortcutClose() { }

	// RVA: 0x198A480 Offset: 0x1986480 VA: 0x198A480
	public void WaitingChatShortcutClose() { }

	// RVA: 0x198A5FC Offset: 0x19865FC VA: 0x198A5FC
	public void OnFlick(Vector2 flick) { }

	// RVA: 0x198A690 Offset: 0x1986690 VA: 0x198A690
	private void NextPage() { }

	// RVA: 0x198A764 Offset: 0x1986764 VA: 0x198A764
	public void ShortcutClick(int id) { }

	// RVA: 0x198A918 Offset: 0x1986918 VA: 0x198A918
	private void OnPress(bool pressed) { }

	// RVA: 0x198A9B0 Offset: 0x19869B0 VA: 0x198A9B0
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x198AA30 Offset: 0x1986A30 VA: 0x198AA30 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x198AA9C Offset: 0x1986A9C VA: 0x198AA9C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x198AB08 Offset: 0x1986B08 VA: 0x198AB08 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x198ABA4 Offset: 0x1986BA4 VA: 0x198ABA4
	public void .ctor() { }

	// RVA: 0x198ACD0 Offset: 0x1986CD0 VA: 0x198ACD0
	private static void .cctor() { }
}
