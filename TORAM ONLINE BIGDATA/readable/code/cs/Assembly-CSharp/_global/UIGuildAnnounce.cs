// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildAnnounce : MonoBehaviour, IUIGuild // TypeDefIndex: 7100
{
	// Fields
	[SerializeField]
	private LocalizeText informationLabel; // 0x20
	[SerializeField]
	private LocalizeText lastUpdateTimeLabel; // 0x28
	[SerializeField]
	private LocalizeText lastUpdateUserLabel; // 0x30
	[SerializeField]
	private UIIruna2AnchorSimple windowAnchor; // 0x38
	[SerializeField]
	private UILabel inputLabel; // 0x40
	[SerializeField]
	private GameObject editButton; // 0x48
	[SerializeField]
	private GameObject loginMesPanel; // 0x50
	[SerializeField]
	private UILabel loginMessageLabel; // 0x58
	[SerializeField]
	private GameObject loginEditButton; // 0x60
	[SerializeField]
	private UILabel titleLabel; // 0x68
	[SerializeField]
	private UISprite titleIcon; // 0x70
	[SerializeField]
	private UIInput infoInput; // 0x78
	[SerializeField]
	private UIInput loginInput; // 0x80
	[SerializeField]
	private GameObject resetButtonObj; // 0x88
	[SerializeField]
	private UILabel infoInputLabel; // 0x90
	[SerializeField]
	private UILabel loginInputLabel; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private string informationText; // 0xB0
	private string lastUpdateTime; // 0xB8
	private string lastupdateUser; // 0xC0
	private bool isInfoPanel; // 0xC8
	private string loginText; // 0xD0
	private string lastUpdateLoginTime; // 0xD8
	private string lastUpdateLoginUser; // 0xE0
	private UIPopBaseWindow resetPopWindow; // 0xE8
	private bool isResetWindow; // 0xF0
	[CompilerGenerated]
	private UIBasePanelControl <TopControl>k__BackingField; // 0xF8

	// Properties
	public UIBasePanelControl TopControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A928BC Offset: 0x1A8E8BC VA: 0x1A928BC
	public UIBasePanelControl get_TopControl() { }

	[CompilerGenerated]
	// RVA: 0x1A928C4 Offset: 0x1A8E8C4 VA: 0x1A928C4
	public void set_TopControl(UIBasePanelControl value) { }

	// RVA: 0x1A928CC Offset: 0x1A8E8CC VA: 0x1A928CC
	private void Awake() { }

	[IteratorStateMachine(typeof(UIGuildAnnounce.<Start>d__32))]
	// RVA: 0x1A92AC4 Offset: 0x1A8EAC4 VA: 0x1A92AC4
	private IEnumerator Start() { }

	// RVA: 0x1A92B58 Offset: 0x1A8EB58 VA: 0x1A92B58
	private void Update() { }

	[IteratorStateMachine(typeof(UIGuildAnnounce.<getGuildInformation>d__34))]
	// RVA: 0x1A92E18 Offset: 0x1A8EE18 VA: 0x1A92E18
	private IEnumerator getGuildInformation() { }

	// RVA: 0x1A92EAC Offset: 0x1A8EEAC VA: 0x1A92EAC
	private void resetInformation() { }

	// RVA: 0x1A93150 Offset: 0x1A8F150 VA: 0x1A93150
	public void OnSubmit() { }

	[IteratorStateMachine(typeof(UIGuildAnnounce.<updateGuildInformation>d__37))]
	// RVA: 0x1A931E0 Offset: 0x1A8F1E0 VA: 0x1A931E0
	private IEnumerator updateGuildInformation() { }

	// RVA: 0x1A93274 Offset: 0x1A8F274 VA: 0x1A93274 Slot: 4
	public void OnClose() { }

	// RVA: 0x1A933A4 Offset: 0x1A8F3A4 VA: 0x1A933A4
	public void OnSubmitLoginMessage() { }

	[IteratorStateMachine(typeof(UIGuildAnnounce.<UpdateLoginMessage>d__40))]
	// RVA: 0x1A93434 Offset: 0x1A8F434 VA: 0x1A93434
	private IEnumerator UpdateLoginMessage() { }

	// RVA: 0x1A934C8 Offset: 0x1A8F4C8 VA: 0x1A934C8
	private void ChangeMessagePanel(bool isInfo) { }

	// RVA: 0x1A935E8 Offset: 0x1A8F5E8 VA: 0x1A935E8
	private void OnRightButton() { }

	// RVA: 0x1A93680 Offset: 0x1A8F680 VA: 0x1A93680
	private void OnLeftButton() { }

	// RVA: 0x1A93718 Offset: 0x1A8F718 VA: 0x1A93718
	private void OnReset() { }

	[IteratorStateMachine(typeof(UIGuildAnnounce.<ResetProcess>d__45))]
	// RVA: 0x1A93738 Offset: 0x1A8F738 VA: 0x1A93738
	private IEnumerator ResetProcess() { }

	// RVA: 0x1A937CC Offset: 0x1A8F7CC VA: 0x1A937CC
	public void .ctor() { }
}
