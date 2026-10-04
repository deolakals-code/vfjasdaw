// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestBoardSkipWindow : MonoBehaviour // TypeDefIndex: 7880
{
	// Fields
	[SerializeField]
	private UILabel[] exLabel; // 0x20
	[SerializeField]
	private GameObject needGoldObj; // 0x28
	[SerializeField]
	private UILabel needGoldLabel; // 0x30
	[SerializeField]
	private GameObject haveGoldObj; // 0x38
	[SerializeField]
	private UILabel haveGoldLabel; // 0x40
	[SerializeField]
	private GameObject waitGoldObj; // 0x48
	[SerializeField]
	private UILabel waitGoldLabel; // 0x50
	[SerializeField]
	private UISlider waitSlider; // 0x58
	[SerializeField]
	private UIImageButton button; // 0x60
	[SerializeField]
	private UILabel buttonLabel; // 0x68
	[CompilerGenerated]
	private bool <IsSkipped>k__BackingField; // 0x70
	private UIQuestBoardSkipWindow.PanelState nowPanelState; // 0x74
	private Action cancelAction; // 0x78
	private Action closeAction; // 0x80
	private Coroutine waitCoroutine; // 0x88
	private string titleText; // 0x90
	private string nextTitleText; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private int needGold; // 0xA8
	private PlayerDataManager playerDataManager; // 0xB0
	private int selectMissionId; // 0xB8
	private short prevReturnCode; // 0xBC
	private InactiveTimer inactiveTimer; // 0xC0

	// Properties
	public bool IsSkipped { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C4D2D4 Offset: 0x1C492D4 VA: 0x1C4D2D4
	public bool get_IsSkipped() { }

	[CompilerGenerated]
	// RVA: 0x1C4D2DC Offset: 0x1C492DC VA: 0x1C4D2DC
	private void set_IsSkipped(bool value) { }

	// RVA: 0x1C4D2E8 Offset: 0x1C492E8 VA: 0x1C4D2E8
	public void Open(int missionId, string title, string nextTitle, int gold, Action cancelAction, Action closeAction) { }

	// RVA: 0x1C4E3A4 Offset: 0x1C4A3A4 VA: 0x1C4E3A4
	public bool Close() { }

	// RVA: 0x1C4E4A8 Offset: 0x1C4A4A8 VA: 0x1C4E4A8
	public void OnWindowButton() { }

	// RVA: 0x1C4D604 Offset: 0x1C49604 VA: 0x1C4D604
	private void ChangePanelState(UIQuestBoardSkipWindow.PanelState panelState) { }

	[IteratorStateMachine(typeof(UIQuestBoardSkipWindow.<WaitProcess>d__31))]
	// RVA: 0x1C4E564 Offset: 0x1C4A564 VA: 0x1C4E564
	private IEnumerator WaitProcess() { }

	// RVA: 0x1C4E418 Offset: 0x1C4A418 VA: 0x1C4E418
	private void ActiveFalse() { }

	// RVA: 0x1C4E5F8 Offset: 0x1C4A5F8 VA: 0x1C4E5F8
	public void .ctor() { }
}
