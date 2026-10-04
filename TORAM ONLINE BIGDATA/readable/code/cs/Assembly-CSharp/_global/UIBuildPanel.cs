// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBuildPanel : UIStatusBasePanel // TypeDefIndex: 8042
{
	// Fields
	public static readonly int DefaultMaxPoint; // 0x0
	public static readonly int LimitBreakMaxPoint; // 0x4
	public static readonly int StatusLimitBreakPoint; // 0x8
	private int[] orbItemId; // 0x20
	[SerializeField]
	private GameObject[] statusBarObject; // 0x28
	private UIStatusBar[] statusBar; // 0x30
	private UIStatusBar selectedBar; // 0x38
	private int[] buildStatusPoint; // 0x40
	[SerializeField]
	private GameObject rightSelectButton; // 0x48
	[SerializeField]
	private GameObject leftSelectButton; // 0x50
	[SerializeField]
	private GameObject personalityActive; // 0x58
	[SerializeField]
	private GameObject personalityNoActive; // 0x60
	[SerializeField]
	private UILabel personalityLabel; // 0x68
	private const int primaryLevel = 40;
	private int selectedPersonality; // 0x70
	[SerializeField]
	private UILabel statusPoint; // 0x78
	[SerializeField]
	private UILabel[] parametarLabel; // 0x80
	[SerializeField]
	private GameObject parametarPanel; // 0x88
	[SerializeField]
	private GameObject equipMessagePanel; // 0x90
	[SerializeField]
	private UILabel equipMessageTitle; // 0x98
	[SerializeField]
	private UILabel equipMessageText; // 0xA0
	[SerializeField]
	private UIIcon equipMessageIcon; // 0xA8
	[SerializeField]
	private GameObject[] adviceSwitchButton; // 0xB0
	[SerializeField]
	private GameObject bufferIconObject; // 0xB8
	[SerializeField]
	private GameObject limitBreakWindowObject; // 0xC0
	[SerializeField]
	private UILabel[] limitBreakWindowLabels; // 0xC8
	private PlayerDataManager playerDataManager; // 0xD0
	private PlayerStatusBase playerBuildStatue; // 0xD8
	private int recyclePoint; // 0xE0
	private byte activeMessagePanel; // 0xE4
	private bool buildCheck; // 0xE5
	[SerializeField]
	private GameObject coinItemStatusButton; // 0xE8
	[SerializeField]
	private GameObject coinItemPrimaryButton; // 0xF0
	private int selectItemId; // 0xF8
	private bool orbInitConnect; // 0xFC
	private int freeResetCount; // 0x100
	[SerializeField]
	private UIIruna2Anchor pointLabelAnchor; // 0x108
	[SerializeField]
	private UIIruna2Anchor primaryStatusLabelAnchor; // 0x110
	[SerializeField]
	private UIIruna2Anchor buildSettingAnchor; // 0x118
	[SerializeField]
	private UIIruna2Anchor buildReSetAnchor; // 0x120
	[SerializeField]
	private UIIruna2Anchor secondaryStutusAnchor; // 0x128
	private SystemTextManager systemTextManager; // 0x130
	private UIStatusMainManager statusMainManager; // 0x138
	private bool cancelCheck; // 0x140
	private bool inputLock; // 0x141
	private ItemTextManager itemTManager; // 0x148
	private UIPopWindow errPopWindow; // 0x150
	private bool isLimitBreak; // 0x158

	// Properties
	private ItemTextManager itemTextManager { get; }

	// Methods

	// RVA: 0x1CA532C Offset: 0x1CA132C VA: 0x1CA532C
	private ItemTextManager get_itemTextManager() { }

	// RVA: 0x1CA541C Offset: 0x1CA141C VA: 0x1CA541C Slot: 4
	public override void Initialize(PlayerDataManager playerDataManager, SystemTextManager systemTextManager, UIStatusMainManager manager) { }

	// RVA: 0x1CA716C Offset: 0x1CA316C VA: 0x1CA716C Slot: 5
	public override void Open() { }

	// RVA: 0x1CA7410 Offset: 0x1CA3410 VA: 0x1CA7410 Slot: 6
	public override void Close() { }

	// RVA: 0x1CA75C8 Offset: 0x1CA35C8 VA: 0x1CA75C8 Slot: 7
	public override bool PushLeftTopButton() { }

	[IteratorStateMachine(typeof(UIBuildPanel.<ConnectWait>d__56))]
	// RVA: 0x1CA7978 Offset: 0x1CA3978 VA: 0x1CA7978
	private IEnumerator ConnectWait(Func<bool> connectionCheck, Action resultAction) { }

	// RVA: 0x1CA7A3C Offset: 0x1CA3A3C VA: 0x1CA7A3C
	private void OnChangeStatusPanel() { }

	// RVA: 0x1CA6F78 Offset: 0x1CA2F78 VA: 0x1CA6F78
	private void UpdatePlayerStatus() { }

	// RVA: 0x1CA6850 Offset: 0x1CA2850 VA: 0x1CA6850
	private PrimaryStatusData GetBuildPrimaryStatus() { }

	// RVA: 0x1CA6D84 Offset: 0x1CA2D84 VA: 0x1CA6D84
	private void SetBuildStatus(PlayerPrimaryStatus primaryStatus) { }

	// RVA: 0x1CA8404 Offset: 0x1CA4404 VA: 0x1CA8404
	private void SetStatusBar(string text, int param) { }

	// RVA: 0x1CA83BC Offset: 0x1CA43BC VA: 0x1CA83BC
	private void SetStatusBar(int type, int param) { }

	// RVA: 0x1CA5BC8 Offset: 0x1CA1BC8 VA: 0x1CA5BC8
	private void DrawBuildSecondaryStutus(IPlayerStatusCalculator buildSecondaryStutus) { }

	// RVA: 0x1CA85C4 Offset: 0x1CA45C4 VA: 0x1CA85C4
	private void SetParamLabel(UIBuildPanel.Parametar type, int param, bool flag) { }

	// RVA: 0x1CA8688 Offset: 0x1CA4688 VA: 0x1CA8688
	public void AddStatusPointCheck(int addPoint, int selectType) { }

	// RVA: 0x1CA8F14 Offset: 0x1CA4F14 VA: 0x1CA8F14
	private void OnBuildSettlePush() { }

	// RVA: 0x1CA7BB4 Offset: 0x1CA3BB4 VA: 0x1CA7BB4
	private void SetStatusPointLabel() { }

	// RVA: 0x1CA7D8C Offset: 0x1CA3D8C VA: 0x1CA7D8C
	private void OpenLimitBreakWindow() { }

	// RVA: 0x1CA7AF0 Offset: 0x1CA3AF0 VA: 0x1CA7AF0
	private int GetOverBuildPoint() { }

	// RVA: 0x1CA76A8 Offset: 0x1CA36A8 VA: 0x1CA76A8
	private void CloseLimitBreakWindow() { }

	// RVA: 0x1CA9430 Offset: 0x1CA5430 VA: 0x1CA9430
	private void OnSelectPersonality() { }

	[IteratorStateMachine(typeof(UIBuildPanel.<SelectPersonality>d__72))]
	// RVA: 0x1CA9450 Offset: 0x1CA5450 VA: 0x1CA9450
	private IEnumerator SelectPersonality() { }

	// RVA: 0x1CA94E4 Offset: 0x1CA54E4 VA: 0x1CA94E4
	private void SetDeterminePersonality(PersonalityType type) { }

	// RVA: 0x1CA9644 Offset: 0x1CA5644 VA: 0x1CA9644
	private void OnStatusReset() { }

	[IteratorStateMachine(typeof(UIBuildPanel.<SelectResetItemWindow>d__75))]
	// RVA: 0x1CA9664 Offset: 0x1CA5664 VA: 0x1CA9664
	private IEnumerator SelectResetItemWindow() { }

	[IteratorStateMachine(typeof(UIBuildPanel.<CheckOrbConnection>d__76))]
	// RVA: 0x1CA73A4 Offset: 0x1CA33A4 VA: 0x1CA73A4
	private IEnumerator CheckOrbConnection() { }

	// RVA: 0x1CA9720 Offset: 0x1CA5720 VA: 0x1CA9720
	private void OnSelectCoinItem(int id) { }

	// RVA: 0x1CA9728 Offset: 0x1CA5728 VA: 0x1CA9728
	private PopBaseWindow ServicePopUpWindow(int servicePrice, bool paramCheck, string labelText, string messageText) { }

	// RVA: 0x1CA99D4 Offset: 0x1CA59D4 VA: 0x1CA99D4
	private PopBaseWindow ItemPopUpWindow(int orbItemId, int orbItemNum, bool paramCheck, string labelText, string messageText) { }

	// RVA: 0x1CA9C84 Offset: 0x1CA5C84 VA: 0x1CA9C84
	public void .ctor() { }

	// RVA: 0x1CA9DFC Offset: 0x1CA5DFC VA: 0x1CA9DFC
	private static void .cctor() { }
}
