// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameLobbyPanelManager : MonoBehaviour, IUICardGamePanel // TypeDefIndex: 5679
{
	// Fields
	[SerializeField]
	private UIImageButton startButton; // 0x20
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x28
	[SerializeField]
	private GameObject partyPanel; // 0x30
	[SerializeField]
	private UISprite enterPanelBase; // 0x38
	[SerializeField]
	private GameObject mainSetting; // 0x40
	[SerializeField]
	private UILabel[] mainSettingLabels; // 0x48
	[SerializeField]
	private UICardGameSettingElement settingBase; // 0x50
	[SerializeField]
	private UISprite settingButton; // 0x58
	[SerializeField]
	private UILabel mainSettingDataTitle; // 0x60
	[SerializeField]
	private GameObject recordPanel; // 0x68
	[SerializeField]
	private GameObject selectRecordPanel; // 0x70
	[SerializeField]
	private GameObject userRecordPanel; // 0x78
	[SerializeField]
	private UILabel userRecordTitleLabel; // 0x80
	[SerializeField]
	private UILabel userRecordLabel; // 0x88
	[SerializeField]
	private GameObject lastResultPanel; // 0x90
	[SerializeField]
	private UILabel lastResultTitle; // 0x98
	[SerializeField]
	private GameObject resultElement; // 0xA0
	private CardGameManager gameManager; // 0xA8
	private UICardGameBasePanel cardGameEnterPanel; // 0xB0
	private SystemTextManager systemTextManager; // 0xB8
	private float updateTimer; // 0xC0
	private Dictionary<int, short> lastResultData; // 0xC8
	private List<GameObject> lastResultUI; // 0xD0
	private int battleCount; // 0xD8
	private Dictionary<int, short> battleTotalData; // 0xE0
	private Dictionary<int, string> userNameList; // 0xE8
	private int userRecordScore; // 0xF0
	private int userRecordData; // 0xF4
	private int selectedRecordPanelId; // 0xF8

	// Methods

	// RVA: 0x17C5E70 Offset: 0x17C1E70 VA: 0x17C5E70
	private void Update() { }

	// RVA: 0x17C5EFC Offset: 0x17C1EFC VA: 0x17C5EFC Slot: 4
	public void Initialize(UICardGameManager uiManager, CardGameManager gameManager) { }

	// RVA: 0x17C6190 Offset: 0x17C2190 VA: 0x17C6190 Slot: 7
	public bool OnLeftTop() { }

	// RVA: 0x17C6224 Offset: 0x17C2224 VA: 0x17C6224 Slot: 8
	public bool OnRightTop() { }

	// RVA: 0x17C622C Offset: 0x17C222C VA: 0x17C622C Slot: 5
	public void PanelDisable() { }

	// RVA: 0x17C641C Offset: 0x17C241C VA: 0x17C641C Slot: 6
	public void PanelEnable() { }

	// RVA: 0x17C6568 Offset: 0x17C2568 VA: 0x17C6568
	private bool ActiveRecordPanel() { }

	// RVA: 0x17C6680 Offset: 0x17C2680 VA: 0x17C6680
	private void UpdateRecordPanel() { }

	// RVA: 0x17C64D0 Offset: 0x17C24D0 VA: 0x17C64D0
	private bool AcitveLastResultPanel() { }

	// RVA: 0x17C7120 Offset: 0x17C3120 VA: 0x17C7120
	private bool AcitveTotalResultPanel() { }

	// RVA: 0x17C688C Offset: 0x17C288C VA: 0x17C688C
	private void AcitveResultPanel(string title, Dictionary<int, short> viewDatas) { }

	// RVA: 0x17C71E4 Offset: 0x17C31E4 VA: 0x17C71E4
	public void JoinGame() { }

	// RVA: 0x17C7304 Offset: 0x17C3304 VA: 0x17C7304
	public void UpdateGameSetting(CardGameSettingData setting) { }

	// RVA: 0x17C731C Offset: 0x17C331C VA: 0x17C731C
	public void SetBeforeResultData(byte accumulationCount, Dictionary<int, string> userName, Dictionary<int, short> gameScore, Dictionary<int, short> roomScore) { }

	// RVA: 0x17C736C Offset: 0x17C336C VA: 0x17C736C
	public void OnClick_RecordWindowButton() { }

	// RVA: 0x17C73C8 Offset: 0x17C33C8 VA: 0x17C73C8
	public void OnClick_AddPopSelectRecordPanel(int add) { }

	// RVA: 0x17C746C Offset: 0x17C346C VA: 0x17C746C
	public void OnOpenGameSettingPanel() { }

	// RVA: 0x17C75B0 Offset: 0x17C35B0 VA: 0x17C75B0
	public void OpenSetting() { }

	// RVA: 0x17C7510 Offset: 0x17C3510 VA: 0x17C7510
	public void CloseSetting() { }

	// RVA: 0x17C7648 Offset: 0x17C3648 VA: 0x17C7648
	public void OnClickStart() { }

	// RVA: 0x17C7720 Offset: 0x17C3720 VA: 0x17C7720
	public void .ctor() { }
}
