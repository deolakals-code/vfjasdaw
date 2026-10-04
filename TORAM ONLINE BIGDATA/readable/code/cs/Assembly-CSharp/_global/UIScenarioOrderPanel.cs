// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScenarioOrderPanel : UIBasePanelControl, IShop // TypeDefIndex: 8362
{
	// Fields
	[SerializeField]
	private UILabel TitleLabel; // 0x58
	[SerializeField]
	private UILabel ItemNumLabel; // 0x60
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x68
	[SerializeField]
	private GameObject scrollTopLeft; // 0x70
	[SerializeField]
	private GameObject scenarioButtonObject; // 0x78
	[SerializeField]
	private UILabel storyTitleLabel; // 0x80
	[SerializeField]
	private UILabel orderLabel; // 0x88
	[SerializeField]
	private UIImageButton resetButton; // 0x90
	[SerializeField]
	private UISlider waitTimeSlidr; // 0x98
	[SerializeField]
	private GameObject orderParent; // 0xA0
	[SerializeField]
	private GameObject waitingParent; // 0xA8
	[SerializeField]
	private UIImageButton orderButton; // 0xB0
	[SerializeField]
	private GameObject orderErrLabelObject; // 0xB8
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0xC0
	[CompilerGenerated]
	private string <ShopName>k__BackingField; // 0xC8
	[CompilerGenerated]
	private bool <IsClosed>k__BackingField; // 0xD0
	private static readonly float WaitTime; // 0x0
	private static readonly float ButtonSpace; // 0x4
	private static readonly Vector3 BaseButtonPosition; // 0x8
	private static readonly Vector3[] TopLeftPosition; // 0x18
	private SystemTextManager systemTextManager; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private List<string> chapterList; // 0xE8
	private Dictionary<string, List<UIScenarioOrderPanel.MissionData>> missionDataList; // 0xF0
	private UIScenarioOrderPanel.Phase currentPhase; // 0xF8
	private int ItemNum; // 0xFC
	private int lastScenarioId; // 0x100
	private int selectChapterId; // 0x104
	private int selectStoryId; // 0x108

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D2E834 Offset: 0x1D2A834 VA: 0x1D2E834 Slot: 14
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x1D2E83C Offset: 0x1D2A83C VA: 0x1D2E83C Slot: 15
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D2E844 Offset: 0x1D2A844 VA: 0x1D2E844 Slot: 16
	public string get_ShopName() { }

	[CompilerGenerated]
	// RVA: 0x1D2E84C Offset: 0x1D2A84C VA: 0x1D2E84C Slot: 17
	public void set_ShopName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1D2E854 Offset: 0x1D2A854 VA: 0x1D2E854 Slot: 18
	public bool get_IsClosed() { }

	[CompilerGenerated]
	// RVA: 0x1D2E85C Offset: 0x1D2A85C VA: 0x1D2E85C Slot: 19
	public void set_IsClosed(bool value) { }

	[IteratorStateMachine(typeof(UIScenarioOrderPanel.<Start>d__40))]
	// RVA: 0x1D2E868 Offset: 0x1D2A868 VA: 0x1D2E868
	private IEnumerator Start() { }

	// RVA: 0x1D2E8DC Offset: 0x1D2A8DC VA: 0x1D2E8DC
	private void OpenChapterPanel() { }

	// RVA: 0x1D2EC14 Offset: 0x1D2AC14 VA: 0x1D2EC14
	private void OpenStoryPanel() { }

	// RVA: 0x1D2F0C8 Offset: 0x1D2B0C8 VA: 0x1D2F0C8
	private void AddMissionList() { }

	// RVA: 0x1D2E92C Offset: 0x1D2A92C VA: 0x1D2E92C
	private void ChapterListCreate() { }

	// RVA: 0x1D2EC24 Offset: 0x1D2AC24 VA: 0x1D2EC24
	private void StoryListCreate(int chapterId) { }

	// RVA: 0x1D2F518 Offset: 0x1D2B518 VA: 0x1D2F518
	private void CreateMissionButton(Vector3 pos, int id, string text, bool isEnabled = True) { }

	// RVA: 0x1D2F68C Offset: 0x1D2B68C VA: 0x1D2F68C
	private void OnClickScrollButton(int id) { }

	// RVA: 0x1D2F914 Offset: 0x1D2B914 VA: 0x1D2F914
	private void OpenMissionOrderPane() { }

	// RVA: 0x1D2FA20 Offset: 0x1D2BA20 VA: 0x1D2FA20
	private void OpenWaitingPanel() { }

	[IteratorStateMachine(typeof(UIScenarioOrderPanel.<MissionOrderWaiting>d__50))]
	// RVA: 0x1D2FAD0 Offset: 0x1D2BAD0 VA: 0x1D2FAD0
	private IEnumerator MissionOrderWaiting() { }

	// RVA: 0x1D2FB64 Offset: 0x1D2BB64 VA: 0x1D2FB64
	private void OnOrderButton() { }

	// RVA: 0x1D2FB8C Offset: 0x1D2BB8C VA: 0x1D2FB8C
	private void OnOrderCancelButton() { }

	// RVA: 0x1D2FB98 Offset: 0x1D2BB98 VA: 0x1D2FB98
	public void .ctor() { }

	// RVA: 0x1D2FC74 Offset: 0x1D2BC74 VA: 0x1D2FC74
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1D2FD34 Offset: 0x1D2BD34 VA: 0x1D2FD34
	private void <Start>b__40_0() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1D2FDD0 Offset: 0x1D2BDD0 VA: 0x1D2FDD0
	private void <>n__0(Action pushFunction) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1D2FDD8 Offset: 0x1D2BDD8 VA: 0x1D2FDD8
	private Action <>n__1() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1D2FDE0 Offset: 0x1D2BDE0 VA: 0x1D2FDE0
	private void <>n__2(Action targetAction) { }
}
