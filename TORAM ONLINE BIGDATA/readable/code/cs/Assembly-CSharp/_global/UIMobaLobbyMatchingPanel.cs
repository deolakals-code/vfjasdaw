// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaLobbyMatchingPanel : MonoBehaviour // TypeDefIndex: 6086
{
	// Fields
	[SerializeField]
	private UIIruna2AnchorSimple anchor; // 0x20
	[SerializeField]
	private GameObject[] panelObjs; // 0x28
	[SerializeField]
	private GameObject[] closeObjs; // 0x30
	[SerializeField]
	private GameObject[] openObjs; // 0x38
	[SerializeField]
	private UILabel matchingButtonLabel; // 0x40
	[SerializeField]
	private GameObject[] matchingButtonIcons; // 0x48
	[SerializeField]
	private UILabel[] matchingSelectCloseButtonLabels; // 0x50
	[SerializeField]
	private UILabel[] matchingSelectOpenButtonLabels; // 0x58
	[SerializeField]
	private GameObject[] matchingSelectObjs; // 0x60
	[SerializeField]
	private UILabel matchingRankingPointLabel; // 0x68
	[SerializeField]
	private GameObject matchingWaitObj; // 0x70
	[SerializeField]
	private UISprite matchingWaitIcon; // 0x78
	[SerializeField]
	private UILabel matchingWaitLabel; // 0x80
	[SerializeField]
	private GameObject partyMesObj; // 0x88
	[SerializeField]
	private UILabel partyMesLabel; // 0x90
	private UIMobaLobbyMatchingPanel.BattleType selectBatttleType; // 0x98
	private UIMobaLobbyMatchingPanel.PanelState nowPanelState; // 0x9C
	private MobaDataManager mobaDataManager; // 0xA0
	private UIPopBaseWindow cancelgPopWindow; // 0xA8
	private bool cancelCheck; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8
	private bool isParty; // 0xC0
	private bool isPartyLeader; // 0xC1
	private bool isPartyPending; // 0xC2
	private UIPopBaseWindow errorPopWindow; // 0xC8
	private bool errorlCheck; // 0xD0
	private readonly string whiteColor; // 0xD8
	private readonly string grayColor; // 0xE0
	private DateTime updatePartyGameTime; // 0xE8
	private readonly string[] ruleIconList; // 0xF0

	// Properties
	public bool IsActive { get; }
	public UIMobaLobbyMatchingPanel.PanelState NowPanelState { get; }
	private bool isSelector { get; }

	// Methods

	// RVA: 0x188040C Offset: 0x187C40C VA: 0x188040C
	public bool get_IsActive() { }

	// RVA: 0x1880434 Offset: 0x187C434 VA: 0x1880434
	public UIMobaLobbyMatchingPanel.PanelState get_NowPanelState() { }

	// RVA: 0x188043C Offset: 0x187C43C VA: 0x188043C
	private bool get_isSelector() { }

	// RVA: 0x1880460 Offset: 0x187C460 VA: 0x1880460
	private void Start() { }

	// RVA: 0x1880A88 Offset: 0x187CA88 VA: 0x1880A88
	private void Update() { }

	// RVA: 0x188058C Offset: 0x187C58C VA: 0x188058C
	public void ChangePanelState(UIMobaLobbyMatchingPanel.PanelState panelState) { }

	// RVA: 0x1880FC0 Offset: 0x187CFC0 VA: 0x1880FC0
	public void UpdateWaitNumLabel(int casual, int one, int four) { }

	// RVA: 0x1881488 Offset: 0x187D488 VA: 0x1881488
	public void UpdateMatchingWaitNumLabel(MobaGameData game) { }

	// RVA: 0x188160C Offset: 0x187D60C VA: 0x188160C
	public void UpdateNowPanel() { }

	// RVA: 0x1881614 Offset: 0x187D614 VA: 0x1881614
	public void OpenDefaultErrorWindow() { }

	// RVA: 0x18816FC Offset: 0x187D6FC VA: 0x18816FC
	public void OpenErrorWindow(string mesLocalizeKey) { }

	// RVA: 0x1880CC8 Offset: 0x187CCC8 VA: 0x1880CC8
	public void DestroyPanel() { }

	// RVA: 0x188171C Offset: 0x187D71C VA: 0x188171C
	public void InitNextPartyGameNow() { }

	// RVA: 0x1881778 Offset: 0x187D778 VA: 0x1881778
	public void OnTopButton() { }

	// RVA: 0x1881970 Offset: 0x187D970 VA: 0x1881970
	public void OnSelectBattle(int param) { }

	// RVA: 0x1880D44 Offset: 0x187CD44 VA: 0x1880D44
	private void FadeCommand(bool fade) { }

	// RVA: 0x1880DD4 Offset: 0x187CDD4 VA: 0x1880DD4
	private void ChangeMatchingPanel(bool isOpen) { }

	// RVA: 0x1880FA4 Offset: 0x187CFA4 VA: 0x1880FA4
	private void ChangeMatchinButtonLabel(string text) { }

	// RVA: 0x1880E94 Offset: 0x187CE94 VA: 0x1880E94
	private void ChangeMatchingButtonSearchIcon(bool isSearch) { }

	// RVA: 0x1880F04 Offset: 0x187CF04 VA: 0x1880F04
	private void ChangeMatchingButtonBatsuIcon(bool isActive) { }

	// RVA: 0x1880F3C Offset: 0x187CF3C VA: 0x1880F3C
	private void ChangeBattlegSelectObj(bool isActive) { }

	[IteratorStateMachine(typeof(UIMobaLobbyMatchingPanel.<CancelWindow>d__56))]
	// RVA: 0x18818FC Offset: 0x187D8FC VA: 0x18818FC
	private IEnumerator CancelWindow() { }

	[IteratorStateMachine(typeof(UIMobaLobbyMatchingPanel.<ErrorWindow>d__57))]
	// RVA: 0x188166C Offset: 0x187D66C VA: 0x188166C
	private IEnumerator ErrorWindow(string mes) { }

	// RVA: 0x18813F0 Offset: 0x187D3F0 VA: 0x18813F0
	private string GetBattleLocalizeKey(MobaRuleType type) { }

	// RVA: 0x1880DD0 Offset: 0x187CDD0 VA: 0x1880DD0
	private void UpdateNextPartyGameTime() { }

	// RVA: 0x1881B04 Offset: 0x187DB04 VA: 0x1881B04
	public void .ctor() { }
}
