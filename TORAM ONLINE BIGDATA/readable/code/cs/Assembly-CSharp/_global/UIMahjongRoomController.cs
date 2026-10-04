// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongRoomController : MonoBehaviour // TypeDefIndex: 5942
{
	// Fields
	[SerializeField]
	private GameObject[] panels; // 0x20
	[SerializeField]
	private GameObject titleBack; // 0x28
	[SerializeField]
	private GameObject[] mainPanelContents; // 0x30
	[SerializeField]
	private UIMahjongRoomSettingManager roomSettingManager; // 0x38
	[SerializeField]
	private UIImageButton readyOrStartButton; // 0x40
	[SerializeField]
	private UILabel readyOrStartButtonLabel; // 0x48
	[SerializeField]
	private GameObject allReadyIcon; // 0x50
	[SerializeField]
	private UIMahjongRoomMemberContentManager[] memberContents; // 0x58
	[SerializeField]
	private UIMahjongPsiChangeWindowManager psiChangeWindowManager; // 0x60
	[SerializeField]
	private UIMahjongRoomSettingChangeWindowManager settingWindowController; // 0x68
	[SerializeField]
	private GameObject gmButton; // 0x70
	[SerializeField]
	private AnimationCurve readyLabelAnimCurnve; // 0x78
	private MahjongRoomData roomData; // 0x80
	private UIMahjongMainManager main; // 0x88
	private PlayerDataManager pData; // 0x90
	private MahjongPsiType playerPsiType; // 0x98
	private UIMahjongRoomController.PanelState panelState; // 0x9C
	private Dictionary<int, UIMahjongRoomMemberContentManager> roomMemberContents; // 0xA0
	private UIButtonCallAction readyOrStartButtonCallAction; // 0xA8
	private bool isUseAutoMatching; // 0xB0
	private bool isMatchingNow; // 0xB1
	private float readyLabelTweenTime; // 0xB4
	private const float readyLabelPosYMax = 10;
	private const int readyLabelWidth = 485;

	// Properties
	public bool InputLock { get; }
	public UIMahjongRoomController.PanelState ActivePanel { get; }
	public bool IsUseAutoMatching { get; }
	public bool IsMatchingNow { get; }

	// Methods

	// RVA: 0x184D7DC Offset: 0x18497DC VA: 0x184D7DC
	public bool get_InputLock() { }

	// RVA: 0x184D880 Offset: 0x1849880 VA: 0x184D880
	public UIMahjongRoomController.PanelState get_ActivePanel() { }

	// RVA: 0x184D888 Offset: 0x1849888 VA: 0x184D888
	public bool get_IsUseAutoMatching() { }

	// RVA: 0x184D890 Offset: 0x1849890 VA: 0x184D890
	public bool get_IsMatchingNow() { }

	// RVA: 0x184D898 Offset: 0x1849898 VA: 0x184D898
	private void Update() { }

	// RVA: 0x184DB14 Offset: 0x1849B14 VA: 0x184DB14
	public void Initialize() { }

	// RVA: 0x184DB58 Offset: 0x1849B58 VA: 0x184DB58
	public void Initialize(MahjongRoomData roomData, UIMahjongMainManager mainManager) { }

	// RVA: 0x184E48C Offset: 0x184A48C VA: 0x184E48C
	public void ChangePanel(UIMahjongRoomController.PanelState state) { }

	// RVA: 0x184F1BC Offset: 0x184B1BC VA: 0x184F1BC
	public void OnClickCloseButton() { }

	// RVA: 0x184F28C Offset: 0x184B28C VA: 0x184F28C
	public void ChangeMatchingFlag(bool flag) { }

	// RVA: 0x184F298 Offset: 0x184B298 VA: 0x184F298
	public void ChangeUseAutoMatchingFlag(bool flag) { }

	// RVA: 0x184F19C Offset: 0x184B19C VA: 0x184F19C
	public void ChangeRoomSetting() { }

	// RVA: 0x184F3B4 Offset: 0x184B3B4 VA: 0x184F3B4
	public void OnClickPsiChangeButton() { }

	// RVA: 0x184F430 Offset: 0x184B430 VA: 0x184F430
	public void OnClickRoomSettingChangeButton() { }

	// RVA: 0x184EE3C Offset: 0x184AE3C VA: 0x184EE3C
	private void ChangeReadyButton(bool isOn) { }

	// RVA: 0x184E8A4 Offset: 0x184A8A4 VA: 0x184E8A4
	private void ChangeStartButton() { }

	// RVA: 0x184FA14 Offset: 0x184BA14 VA: 0x184FA14
	private void OnClickGameStart() { }

	// RVA: 0x184FA4C Offset: 0x184BA4C VA: 0x184FA4C
	private void OnClickRoomReady() { }

	// RVA: 0x184FAA0 Offset: 0x184BAA0 VA: 0x184FAA0
	private void OnClickRoomReadyCancel() { }

	// RVA: 0x184FAF4 Offset: 0x184BAF4 VA: 0x184FAF4
	private void OnClickMatchingStart() { }

	// RVA: 0x184F230 Offset: 0x184B230 VA: 0x184F230
	private void OnClickMatchingCancel() { }

	// RVA: 0x184FB50 Offset: 0x184BB50 VA: 0x184FB50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x184FB58 Offset: 0x184BB58 VA: 0x184FB58
	private void <ChangeReadyButton>b__43_0() { }

	[CompilerGenerated]
	// RVA: 0x184FB5C Offset: 0x184BB5C VA: 0x184FB5C
	private void <ChangeReadyButton>b__43_1() { }

	[CompilerGenerated]
	// RVA: 0x184FB60 Offset: 0x184BB60 VA: 0x184FB60
	private void <ChangeReadyButton>b__43_2() { }

	[CompilerGenerated]
	// RVA: 0x184FB64 Offset: 0x184BB64 VA: 0x184FB64
	private void <ChangeStartButton>b__44_1() { }

	[CompilerGenerated]
	// RVA: 0x184FB68 Offset: 0x184BB68 VA: 0x184FB68
	private void <ChangeStartButton>b__44_3() { }
}
