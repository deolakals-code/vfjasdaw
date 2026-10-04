// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriend : UIBasePanelControl // TypeDefIndex: 7069
{
	// Fields
	[SerializeField]
	private GameObject buttonObject; // 0x58
	[SerializeField]
	private GameObject friendListObject; // 0x60
	[SerializeField]
	private GameObject friendReserveListObject; // 0x68
	[SerializeField]
	private GameObject friendReserveSubObject; // 0x70
	[SerializeField]
	private GameObject friendActivityObject; // 0x78
	private UIScrollWindow scrollWindow; // 0x80
	private GameObject scrollWindowObject; // 0x88
	private Dictionary<int, string> scrollMessage; // 0x90
	private FriendManager friendManager; // 0x98
	private GameObject createdObject; // 0xA0

	// Properties
	public GameObject CreatedObject { get; }

	// Methods

	// RVA: 0x1A88678 Offset: 0x1A84678 VA: 0x1A88678
	public GameObject get_CreatedObject() { }

	// RVA: 0x1A88680 Offset: 0x1A84680 VA: 0x1A88680
	private void Awake() { }

	// RVA: 0x1A89118 Offset: 0x1A85118 VA: 0x1A89118
	private void Start() { }

	// RVA: 0x1A8911C Offset: 0x1A8511C VA: 0x1A8911C
	private void Update() { }

	// RVA: 0x1A888D4 Offset: 0x1A848D4 VA: 0x1A888D4
	private void InitMenu() { }

	// RVA: 0x1A89194 Offset: 0x1A85194 VA: 0x1A89194
	private GameObject CloneButton(int index, string buttonText, string messageText, string funcitonName) { }

	// RVA: 0x1A8943C Offset: 0x1A8543C VA: 0x1A8943C
	private void updateMessageText(int index) { }

	// RVA: 0x1A89120 Offset: 0x1A85120 VA: 0x1A89120
	private void ClearObject() { }

	// RVA: 0x1A894E4 Offset: 0x1A854E4 VA: 0x1A894E4
	private void OnFriendList() { }

	// RVA: 0x1A89724 Offset: 0x1A85724 VA: 0x1A89724
	public void OnFriendReserve() { }

	// RVA: 0x1A89978 Offset: 0x1A85978 VA: 0x1A89978
	private void OnFriendMercenary() { }

	// RVA: 0x1A89A00 Offset: 0x1A85A00 VA: 0x1A89A00
	private void OnFriendActivity() { }

	// RVA: 0x1A89C40 Offset: 0x1A85C40 VA: 0x1A89C40
	private void CloseFriend() { }

	// RVA: 0x1A89CDC Offset: 0x1A85CDC VA: 0x1A89CDC
	private void ReturnFriendListToMenu() { }

	[IteratorStateMachine(typeof(UIFriend.<CloseFriendList>d__25))]
	// RVA: 0x1A89D90 Offset: 0x1A85D90 VA: 0x1A89D90
	private IEnumerator CloseFriendList() { }

	[IteratorStateMachine(typeof(UIFriend.<ChangeOnlineNotice>d__26))]
	// RVA: 0x1A89D24 Offset: 0x1A85D24 VA: 0x1A89D24
	private IEnumerator ChangeOnlineNotice() { }

	// RVA: 0x1A89E4C Offset: 0x1A85E4C VA: 0x1A89E4C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A89F30 Offset: 0x1A85F30 VA: 0x1A89F30
	public void .ctor() { }
}
