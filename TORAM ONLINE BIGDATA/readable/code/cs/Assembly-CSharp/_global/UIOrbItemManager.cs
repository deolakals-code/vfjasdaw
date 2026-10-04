// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbItemManager : UIBasePanel // TypeDefIndex: 7597
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x30
	private int selectItemId; // 0x38
	[SerializeField]
	private GameObject scroll; // 0x40
	private UIScrollWindow scrollWindow; // 0x48
	[SerializeField]
	private UIIruna2Anchor useButtonAnchor; // 0x50
	[SerializeField]
	private UIIruna2Anchor itemStatusAnchor; // 0x58
	[SerializeField]
	private GameObject listButton; // 0x60
	[SerializeField]
	private UILabel itemNameLabel; // 0x68
	[SerializeField]
	private UILabel itemNumLabel; // 0x70
	[SerializeField]
	private GameObject nonItemLabel; // 0x78
	[SerializeField]
	private GameObject orbItemPanelObject; // 0x80
	private UIOrbItemPanel orbItemPanel; // 0x88
	[SerializeField]
	private UILabel itemStatusTextLabel; // 0x90
	private bool popActiveWindow; // 0x98
	private bool inputLock; // 0x99
	[SerializeField]
	private GameObject orbItemPopPanelObject; // 0xA0
	private UIOrbItemPanel orbItemPopPanel; // 0xA8
	private ItemTextManager itemTextManager; // 0xB0
	private ItemTextManagerData selectItemTextManagerData; // 0xB8
	private UIPopBaseWindow popWindow; // 0xC0
	private OrbItemManager orbItemManager; // 0xC8
	private OrbBufferManager orbBufferManager; // 0xD0

	// Methods

	// RVA: 0x1BBA924 Offset: 0x1BB6924 VA: 0x1BBA924
	private void Start() { }

	// RVA: 0x1BBAD0C Offset: 0x1BB6D0C VA: 0x1BBAD0C
	private void ItemListCreate() { }

	// RVA: 0x1BBB03C Offset: 0x1BB703C VA: 0x1BBB03C
	private void AddButton(string name, int num, float y, int id) { }

	// RVA: 0x1BBB1B4 Offset: 0x1BB71B4 VA: 0x1BBB1B4
	private void SelectItemClear() { }

	// RVA: 0x1BBB300 Offset: 0x1BB7300 VA: 0x1BBB300
	private bool UseOrbItemCheck(int itemId) { }

	// RVA: 0x1BBB3F0 Offset: 0x1BB73F0 VA: 0x1BBB3F0
	private void SelectItemPanelOpen(int id) { }

	// RVA: 0x1BBB6BC Offset: 0x1BB76BC VA: 0x1BBB6BC
	public void OnUseItemPopUp() { }

	[IteratorStateMachine(typeof(UIOrbItemManager.<OrbItemUseThread>d__29))]
	// RVA: 0x1BBB764 Offset: 0x1BB7764 VA: 0x1BBB764
	private IEnumerator OrbItemUseThread() { }

	[IteratorStateMachine(typeof(UIOrbItemManager.<PopUpWindowThread>d__30))]
	// RVA: 0x1BBB7F8 Offset: 0x1BB77F8 VA: 0x1BBB7F8
	private IEnumerator PopUpWindowThread(Action<int> callBack) { }

	[IteratorStateMachine(typeof(UIOrbItemManager.<ConnectWait>d__31))]
	// RVA: 0x1BBB8A8 Offset: 0x1BB78A8 VA: 0x1BBB8A8
	private IEnumerator ConnectWait(OrbManager.ConnectFlag flag) { }

	// RVA: 0x1BBB94C Offset: 0x1BB794C VA: 0x1BBB94C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BBBA34 Offset: 0x1BB7A34 VA: 0x1BBBA34 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BBBAB8 Offset: 0x1BB7AB8 VA: 0x1BBBAB8
	public void .ctor() { }
}
