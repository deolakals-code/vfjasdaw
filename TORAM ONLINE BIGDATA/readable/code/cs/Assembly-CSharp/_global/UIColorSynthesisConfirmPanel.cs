// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisConfirmPanel : MonoBehaviour, IUIColorSynthesisPanel // TypeDefIndex: 6720
{
	// Fields
	private const float StartButtonLockSeconds = 1;
	[SerializeField]
	private LabelWithIcon item; // 0x20
	[SerializeField]
	private LabelWithIcon cost; // 0x28
	[SerializeField]
	private UILabel successRateLabel; // 0x30
	[SerializeField]
	private UIColorSynthesisGemListElement originColor; // 0x38
	[SerializeField]
	private UIScrollPanel scrollPanel; // 0x40
	[SerializeField]
	private UIImageButton startButton; // 0x48
	[SerializeField]
	private GameObject WaitPanelTitle; // 0x50
	[SerializeField]
	private GameObject WaitPanelMessage; // 0x58
	private UIColorSynthesisMainManager manager; // 0x60
	private PlayerDataManager playerDataManager; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private ItemTextManager itemTextManager; // 0x78
	private bool isLocked; // 0x80
	private bool isProcessing; // 0x81
	private List<UIColorSynthesisGemListElement> condidateColorIcons; // 0x88
	private const float ProgressSeconds = 3;
	private UIPopBaseWindow waitWindow; // 0x90

	// Methods

	// RVA: 0x19C5CF4 Offset: 0x19C1CF4 VA: 0x19C5CF4 Slot: 4
	public void Initialize(UIColorSynthesisMainManager manager, PlayerDataManager playerDataManager, SystemTextManager systemTextManager, ItemTextManager itemTextManager) { }

	// RVA: 0x19C5D54 Offset: 0x19C1D54 VA: 0x19C5D54 Slot: 5
	public void Open() { }

	// RVA: 0x19C6884 Offset: 0x19C2884 VA: 0x19C6884 Slot: 6
	public bool Close() { }

	// RVA: 0x19C5E18 Offset: 0x19C1E18 VA: 0x19C5E18
	private void RefreshInfo() { }

	[IteratorStateMachine(typeof(UIColorSynthesisConfirmPanel.<UnlockStartButton>d__22))]
	// RVA: 0x19C6818 Offset: 0x19C2818 VA: 0x19C6818
	private IEnumerator UnlockStartButton() { }

	// RVA: 0x19C6EB8 Offset: 0x19C2EB8 VA: 0x19C6EB8
	public void OnStart() { }

	[IteratorStateMachine(typeof(UIColorSynthesisConfirmPanel.<RefiningProgress>d__24))]
	// RVA: 0x19C6F8C Offset: 0x19C2F8C VA: 0x19C6F8C
	private IEnumerator RefiningProgress() { }

	// RVA: 0x19C7020 Offset: 0x19C3020 VA: 0x19C7020
	public void .ctor() { }
}
