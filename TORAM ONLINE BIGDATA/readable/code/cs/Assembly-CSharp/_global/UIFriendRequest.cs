// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriendRequest : UITargetMenuBase // TypeDefIndex: 8069
{
	// Fields
	[SerializeField]
	private GameObject inputMessageObject; // 0x90
	[SerializeField]
	private UILabel inputLabel; // 0x98
	[SerializeField]
	private TweenColor tweenColor; // 0xA0
	private FriendManager friendManager; // 0xA8
	private PlayerDataManager playerDataManager; // 0xB0
	private bool isRequestSuccess; // 0xB8
	private bool isError; // 0xB9

	// Methods

	// RVA: 0x1CB87CC Offset: 0x1CB47CC VA: 0x1CB87CC
	public void OperationFailure(GameReturnCode code) { }

	// RVA: 0x1CB89A4 Offset: 0x1CB49A4 VA: 0x1CB89A4
	private void Awake() { }

	// RVA: 0x1CB8C10 Offset: 0x1CB4C10 VA: 0x1CB8C10
	private void Start() { }

	// RVA: 0x1CB8EC8 Offset: 0x1CB4EC8 VA: 0x1CB8EC8
	private void OnWindowOpen() { }

	// RVA: 0x1CB8EE8 Offset: 0x1CB4EE8 VA: 0x1CB8EE8
	public void OnSubmit() { }

	// RVA: 0x1CB8FDC Offset: 0x1CB4FDC VA: 0x1CB8FDC
	private void OnRequest() { }

	[IteratorStateMachine(typeof(UIFriendRequest.<responseWait>d__13))]
	// RVA: 0x1CB9628 Offset: 0x1CB5628 VA: 0x1CB9628
	private IEnumerator responseWait() { }

	// RVA: 0x1CB9464 Offset: 0x1CB5464 VA: 0x1CB9464
	private void setRequestError() { }

	// RVA: 0x1CB96BC Offset: 0x1CB56BC VA: 0x1CB96BC
	private void setRequestTimeout() { }

	// RVA: 0x1CB9880 Offset: 0x1CB5880 VA: 0x1CB9880
	private void onSuccessRequest() { }

	// RVA: 0x1CB9B08 Offset: 0x1CB5B08 VA: 0x1CB9B08
	private void OnDestroy() { }

	// RVA: 0x1CB8B8C Offset: 0x1CB4B8C VA: 0x1CB8B8C
	private void changeUI() { }

	// RVA: 0x1CB9B24 Offset: 0x1CB5B24 VA: 0x1CB9B24
	private void OnClose() { }

	// RVA: 0x1CB9C30 Offset: 0x1CB5C30 VA: 0x1CB9C30 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CB9CB0 Offset: 0x1CB5CB0 VA: 0x1CB9CB0
	public void .ctor() { }
}
