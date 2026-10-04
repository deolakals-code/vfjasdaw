// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffMainManager : UIBasePanelConnection // TypeDefIndex: 6693
{
	// Fields
	[SerializeField]
	private UISprite[] titleIcon; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private GameObject menuPanel; // 0x40
	[SerializeField]
	private GameObject guildFundsObj; // 0x48
	[SerializeField]
	private UILabel guildFundsLabel; // 0x50
	[SerializeField]
	private GameObject guildMedalObj; // 0x58
	[SerializeField]
	private UILabel guildFundsMedalLabel; // 0x60
	[SerializeField]
	private GameObject menuButtonElement; // 0x68
	[SerializeField]
	private UIScrollWindow menuScrollWindow; // 0x70
	[SerializeField]
	private UIIruna2Anchor orbPanelAnchor; // 0x78
	[SerializeField]
	private UILabel orbNumLabel; // 0x80
	[SerializeField]
	private GameObject playerViewPanel; // 0x88
	[SerializeField]
	private GameObject[] backPanel; // 0x90
	private UIGuildStaffBasePanel[] panels; // 0x98
	private UIGuildStaffMainManager.PanelState panelState; // 0xA0
	private const int dungeonMenuScriptId = 4;
	private PlayerDataManager playerDataManager; // 0xA8
	private UICharacterModelBaseManager modelManager; // 0xB0
	private NewArchetypeProperties archetypeProperties; // 0xB8
	private int motionId; // 0xC0
	private UILabel waitActionButtonLabel; // 0xC8
	private bool isMyGuildStaff; // 0xD0

	// Properties
	public GameObject ActivePanel { get; }
	public float GuildFundsObjBasePosY { get; }

	// Methods

	// RVA: 0x19B9A88 Offset: 0x19B5A88 VA: 0x19B9A88
	public GameObject get_ActivePanel() { }

	// RVA: 0x19B9B5C Offset: 0x19B5B5C VA: 0x19B9B5C
	public float get_GuildFundsObjBasePosY() { }

	// RVA: 0x19B9B68 Offset: 0x19B5B68 VA: 0x19B9B68
	private void Start() { }

	// RVA: 0x19AF3F8 Offset: 0x19AB3F8 VA: 0x19AF3F8
	public void ChangePanelState(UIGuildStaffMainManager.PanelState change) { }

	[IteratorStateMachine(typeof(UIGuildStaffMainManager.<FadeOutThread>d__29))]
	// RVA: 0x19BAE14 Offset: 0x19B6E14 VA: 0x19BAE14
	private IEnumerator FadeOutThread(UIGuildStaffMainManager.PanelState change) { }

	// RVA: 0x19AF328 Offset: 0x19AB328 VA: 0x19AF328
	public void ChangeTitleLabel(string icon, string title) { }

	// RVA: 0x19BAEB8 Offset: 0x19B6EB8 VA: 0x19BAEB8
	public void ChangeTitleLabel(bool isSystem, string icon, string title) { }

	// RVA: 0x19BAFE8 Offset: 0x19B6FE8 VA: 0x19BAFE8
	public void ChangeOrbPanelEnable(bool isEnable) { }

	// RVA: 0x19BB074 Offset: 0x19B7074 VA: 0x19BB074
	public void UpdateOrbNum() { }

	// RVA: 0x19AF274 Offset: 0x19AB274 VA: 0x19AF274
	public void ChangeGuildFundsObjEnable(bool isEnable) { }

	// RVA: 0x19BB134 Offset: 0x19B7134 VA: 0x19BB134
	public void ChangeGuildFundsObjEnable(bool isEnable, bool isMedalEnable) { }

	// RVA: 0x19BB2B4 Offset: 0x19B72B4 VA: 0x19BB2B4
	public void ChangeGuildFundsObjPosY(float posY) { }

	// RVA: 0x19AF280 Offset: 0x19AB280 VA: 0x19AF280
	public void ChangeStaffViewEnable(bool isEnable) { }

	// RVA: 0x19BB31C Offset: 0x19B731C VA: 0x19BB31C
	public void ReceiveContrihuteGold(int contrihuteGold) { }

	[IteratorStateMachine(typeof(UIGuildStaffMainManager.<PopWindow>d__39))]
	// RVA: 0x19BB400 Offset: 0x19B7400 VA: 0x19BB400
	public IEnumerator PopWindow(string title, string message, Action callback) { }

	[IteratorStateMachine(typeof(UIGuildStaffMainManager.<PopWindowResponse>d__40))]
	// RVA: 0x19BB4E0 Offset: 0x19B74E0 VA: 0x19BB4E0
	public IEnumerator PopWindowResponse(string title, string message, Action<int> callback) { }

	[IteratorStateMachine(typeof(UIGuildStaffMainManager.<ConnectWait>d__41))]
	// RVA: 0x19BB5C0 Offset: 0x19B75C0 VA: 0x19BB5C0
	public IEnumerator ConnectWait(Func<bool> connectCheck, Action callback) { }

	[IteratorStateMachine(typeof(UIGuildStaffMainManager.<ConnectResultCheck>d__42))]
	// RVA: 0x19BB684 Offset: 0x19B7684 VA: 0x19BB684
	public IEnumerator ConnectResultCheck(OperationCode code, byte type, string title, string text) { }

	// RVA: 0x19BA3A8 Offset: 0x19B63A8 VA: 0x19BA3A8
	private UIGuildStaffBasePanel LoadPanel(string path) { }

	// RVA: 0x19BA5D8 Offset: 0x19B65D8 VA: 0x19BA5D8
	private void InitMainMenu() { }

	// RVA: 0x19BB760 Offset: 0x19B7760 VA: 0x19BB760
	private GameObject AddMenuButton(UIGuildStaffMainManager.PanelState type, bool isSystem, string spriteName, Vector3 pos) { }

	// RVA: 0x19BB9FC Offset: 0x19B79FC VA: 0x19BB9FC
	public void OnSelectMenu(int param) { }

	[IteratorStateMachine(typeof(UIGuildStaffMainManager.<ConnectionGuildRaidData>d__47))]
	// RVA: 0x19BC2E4 Offset: 0x19B82E4 VA: 0x19BC2E4
	private IEnumerator ConnectionGuildRaidData() { }

	// RVA: 0x19BC378 Offset: 0x19B8378 VA: 0x19BC378 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19BC4F0 Offset: 0x19B84F0 VA: 0x19BC4F0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19BC644 Offset: 0x19B8644 VA: 0x19BC644
	public void .ctor() { }
}
