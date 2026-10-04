// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPopWindow : MonoBehaviour // TypeDefIndex: 9017
{
	// Fields
	[SerializeField]
	private UIWidget depthBaseObject; // 0x20
	[SerializeField]
	private Transform addObjectParent; // 0x28
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private UILabel messageLabel; // 0x38
	[SerializeField]
	private UISprite titleIcon; // 0x40
	[SerializeField]
	private UILabel okButtonLabel; // 0x48
	[SerializeField]
	private GameObject okButton; // 0x50
	protected Action okButtonAction; // 0x58
	[SerializeField]
	private UILabel yesButtonLabel; // 0x60
	[SerializeField]
	private GameObject yesButton; // 0x68
	private Action yesButtonAction; // 0x70
	[SerializeField]
	private UILabel noButtonLabel; // 0x78
	[SerializeField]
	private GameObject noButton; // 0x80
	private Action noButtonAction; // 0x88
	private Action openedAction; // 0x90
	private UIPopWindow.popupWindowType windowType; // 0x98

	// Methods

	// RVA: 0x1E93358 Offset: 0x1E8F358 VA: 0x1E93358
	private void Awake() { }

	[IteratorStateMachine(typeof(UIPopWindow.<Start>d__18))]
	// RVA: 0x1E933C0 Offset: 0x1E8F3C0 VA: 0x1E933C0
	private IEnumerator Start() { }

	// RVA: 0x1E90F98 Offset: 0x1E8CF98 VA: 0x1E90F98
	public void Initialize(string titleText, string messageText, Action openedCallback) { }

	// RVA: 0x1E93454 Offset: 0x1E8F454 VA: 0x1E93454
	public void SetPopupWindowType(UIPopWindow.popupWindowType type) { }

	// RVA: 0x1E934B8 Offset: 0x1E8F4B8 VA: 0x1E934B8
	public void SetTitleIcon(string spriteName) { }

	// RVA: 0x1E93568 Offset: 0x1E8F568 VA: 0x1E93568
	public void SetOKButton(string labelText, Action okAction) { }

	// RVA: 0x1E935A4 Offset: 0x1E8F5A4 VA: 0x1E935A4 Slot: 4
	protected virtual void OnOKButton() { }

	// RVA: 0x1E935C0 Offset: 0x1E8F5C0 VA: 0x1E935C0
	public void SetYesButton(string labelText, Action yesAction) { }

	// RVA: 0x1E935FC Offset: 0x1E8F5FC VA: 0x1E935FC
	private void OnYesButton() { }

	// RVA: 0x1E93618 Offset: 0x1E8F618 VA: 0x1E93618
	public void SetNoButton(string labelText, Action noAction) { }

	// RVA: 0x1E93654 Offset: 0x1E8F654 VA: 0x1E93654
	private void OnNoButton() { }

	// RVA: 0x1E93670 Offset: 0x1E8F670 VA: 0x1E93670
	public void OnOpened() { }

	// RVA: 0x1E9368C Offset: 0x1E8F68C VA: 0x1E9368C
	public void AddObject(GameObject addObject) { }

	// RVA: 0x1E93970 Offset: 0x1E8F970 VA: 0x1E93970
	public void Close() { }

	// RVA: 0x1E939FC Offset: 0x1E8F9FC VA: 0x1E939FC
	public void SetEnableOKButton(bool isEnabled) { }

	// RVA: 0x1E93A60 Offset: 0x1E8FA60 VA: 0x1E93A60
	public void SetLabelWithIconPos(float x, float y) { }

	[Obsolete("Alpha専用")]
	// RVA: 0x1E93B28 Offset: 0x1E8FB28 VA: 0x1E93B28
	public void AlphaOnlyChangeFontType() { }

	// RVA: 0x1E91160 Offset: 0x1E8D160 VA: 0x1E91160
	public void .ctor() { }
}
