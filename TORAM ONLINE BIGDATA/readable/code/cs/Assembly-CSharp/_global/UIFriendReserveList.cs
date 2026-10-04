// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriendReserveList : MonoBehaviour // TypeDefIndex: 7089
{
	// Fields
	[SerializeField]
	private GameObject reserveElementObject; // 0x20
	[SerializeField]
	private float elementHeight; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[CompilerGenerated]
	private UIBasePanelControl <TopControl>k__BackingField; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private FriendManager friendManager; // 0x48
	private IList<FriendManager.FriendReserveState> reserveList; // 0x50
	private List<UIFriendReserveElement> elementList; // 0x58
	private int selectedIndex; // 0x60
	private bool isClose; // 0x64
	private UIPopWindow popWindow; // 0x68

	// Properties
	public UIBasePanelControl TopControl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A9128C Offset: 0x1A8D28C VA: 0x1A9128C
	public UIBasePanelControl get_TopControl() { }

	[CompilerGenerated]
	// RVA: 0x1A91294 Offset: 0x1A8D294 VA: 0x1A91294
	public void set_TopControl(UIBasePanelControl value) { }

	// RVA: 0x1A9129C Offset: 0x1A8D29C VA: 0x1A9129C
	private void Awake() { }

	// RVA: 0x1A913B0 Offset: 0x1A8D3B0 VA: 0x1A913B0
	private void Start() { }

	// RVA: 0x1A913B4 Offset: 0x1A8D3B4 VA: 0x1A913B4
	public void updateReserveList() { }

	// RVA: 0x1A91A0C Offset: 0x1A8DA0C VA: 0x1A91A0C
	private void onSelected(int index) { }

	// RVA: 0x1A91AAC Offset: 0x1A8DAAC VA: 0x1A91AAC
	private void onReject() { }

	// RVA: 0x1A91D04 Offset: 0x1A8DD04 VA: 0x1A91D04
	private void onAccept() { }

	[IteratorStateMachine(typeof(UIFriendReserveList.<ConnectWait>d__20))]
	// RVA: 0x1A91C88 Offset: 0x1A8DC88 VA: 0x1A91C88
	private IEnumerator ConnectWait(OperationCode code) { }

	// RVA: 0x1A91F08 Offset: 0x1A8DF08 VA: 0x1A91F08
	private void OnDestroy() { }

	// RVA: 0x1A91F24 Offset: 0x1A8DF24 VA: 0x1A91F24
	public void OnBlock() { }

	[IteratorStateMachine(typeof(UIFriendReserveList.<BlockWindow>d__23))]
	// RVA: 0x1A91F44 Offset: 0x1A8DF44 VA: 0x1A91F44
	private IEnumerator BlockWindow() { }

	// RVA: 0x1A91FD8 Offset: 0x1A8DFD8 VA: 0x1A91FD8
	public void .ctor() { }
}
