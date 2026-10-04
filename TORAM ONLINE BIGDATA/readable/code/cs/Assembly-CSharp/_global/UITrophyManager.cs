// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITrophyManager : UIBasePanelConnection // TypeDefIndex: 6897
{
	// Fields
	private UIScrollWindow scrollWindow; // 0x30
	private UIIruna2Anchor scrollWindowAnchor; // 0x38
	private InactiveTimer scrollWindowInactiveTimer; // 0x40
	[SerializeField]
	private GameObject scrollWindowButton; // 0x48
	private UIScrollWindow scrollListWindow; // 0x50
	private InactiveTimer scrollListWindowInactiveTimer; // 0x58
	[SerializeField]
	private GameObject listButton; // 0x60
	private byte menuState; // 0x68
	private PlayerDataManager playerDataManager; // 0x70
	private UITrophyButton selectButton; // 0x78
	[SerializeField]
	private GameObject okButton; // 0x80
	private UIIruna2Anchor okButtonAnchor; // 0x88
	private GameObject rewardPopUp; // 0x90
	private GameObject loadingModel; // 0x98
	private bool cancelCheck; // 0xA0
	private bool LockTop; // 0xA1
	private bool fromNews; // 0xA2
	private Vector3 scrollWindowCameraPosition; // 0xA4
	private Dictionary<byte, TrophyManager.TrophyData[]> currentDataList; // 0xB0
	private bool rewardTrophy; // 0xB8

	// Methods

	// RVA: 0x1A3BFA8 Offset: 0x1A37FA8 VA: 0x1A3BFA8
	private void Awake() { }

	// RVA: 0x1A3C108 Offset: 0x1A38108 VA: 0x1A3C108
	private void Start() { }

	[IteratorStateMachine(typeof(UITrophyManager.<initializeTrophyUI>d__21))]
	// RVA: 0x1A3C1A4 Offset: 0x1A381A4 VA: 0x1A3C1A4
	private IEnumerator initializeTrophyUI(Action callBack) { }

	// RVA: 0x1A3C254 Offset: 0x1A38254 VA: 0x1A3C254
	public void ToCompleteTrophyList() { }

	// RVA: 0x1A3C2EC Offset: 0x1A382EC VA: 0x1A3C2EC
	private void OnDestroy() { }

	// RVA: 0x1A3C314 Offset: 0x1A38314 VA: 0x1A3C314
	private void TrophyMenu() { }

	// RVA: 0x1A3C750 Offset: 0x1A38750 VA: 0x1A3C750
	private void SetButton(string text, float y, int id) { }

	// RVA: 0x1A3C99C Offset: 0x1A3899C VA: 0x1A3C99C
	private void OnClickButton(int id) { }

	// RVA: 0x1A3D62C Offset: 0x1A3962C VA: 0x1A3D62C
	private void OnHoverButton(int id) { }

	// RVA: 0x1A3CE90 Offset: 0x1A38E90 VA: 0x1A3CE90
	private void ListCreate(TrophyManager.TrophyData[] list) { }

	// RVA: 0x1A3BD64 Offset: 0x1A37D64 VA: 0x1A3BD64
	public void TrophyCheckReward(UITrophyButton select) { }

	[IteratorStateMachine(typeof(UITrophyManager.<ConnectWait>d__31))]
	// RVA: 0x1A3D71C Offset: 0x1A3971C VA: 0x1A3D71C
	private IEnumerator ConnectWait(Action nextAction) { }

	// RVA: 0x1A3D7CC Offset: 0x1A397CC VA: 0x1A3D7CC
	public void OnTrophyCheckReward() { }

	// RVA: 0x1A3D8F4 Offset: 0x1A398F4 VA: 0x1A3D8F4
	private void onFinishRewardEffect() { }

	// RVA: 0x1A3D884 Offset: 0x1A39884 VA: 0x1A3D884
	private void onStartRewardEffect() { }

	// RVA: 0x1A3DC9C Offset: 0x1A39C9C VA: 0x1A3DC9C
	private void onFinishReward() { }

	// RVA: 0x1A3DF48 Offset: 0x1A39F48 VA: 0x1A3DF48 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A3E048 Offset: 0x1A3A048 VA: 0x1A3E048 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A3E120 Offset: 0x1A3A120 VA: 0x1A3E120
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A3E1FC Offset: 0x1A3A1FC VA: 0x1A3E1FC
	private void <ToCompleteTrophyList>b__22_0() { }
}
