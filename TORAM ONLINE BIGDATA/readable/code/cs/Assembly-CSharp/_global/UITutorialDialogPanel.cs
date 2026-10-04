// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITutorialDialogPanel : MonoBehaviour // TypeDefIndex: 9056
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[SerializeField]
	private GameObject systemWindow; // 0x28
	private InactiveTimer systemWindowInactiveTimer; // 0x30
	[SerializeField]
	private GameObject backPanel; // 0x38
	private InactiveTimer backPanelInactiveTimer; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private UILabel messageLabel; // 0x50
	[SerializeField]
	private UILabel onButtonTextLabel; // 0x58
	[SerializeField]
	private GameObject okButton; // 0x60
	[SerializeField]
	private UILabel okButtonLabel; // 0x68
	private Action okAction; // 0x70
	private Action closeAction; // 0x78
	private SystemTextManager systemTextManager; // 0x80

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EA3CEC Offset: 0x1E9FCEC VA: 0x1EA3CEC
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1EA3CF4 Offset: 0x1E9FCF4 VA: 0x1EA3CF4
	private void set_IsOpen(bool value) { }

	// RVA: 0x1EA3D00 Offset: 0x1E9FD00 VA: 0x1EA3D00
	private void Awake() { }

	// RVA: 0x1EA3D08 Offset: 0x1E9FD08 VA: 0x1EA3D08
	public void OpenParameterTutorialDialog() { }

	// RVA: 0x1EA417C Offset: 0x1EA017C VA: 0x1EA417C
	private void ChangeParameterChangePanel() { }

	// RVA: 0x1EA3E94 Offset: 0x1E9FE94 VA: 0x1EA3E94
	public void Initialize(string titleKey, string messageKey, string onButtonTextKey, string buttonTextKey, Action okAction, Action closeAction) { }

	// RVA: 0x1EA4248 Offset: 0x1EA0248 VA: 0x1EA4248
	private void OnPushButton(int param) { }

	// RVA: 0x1EA4278 Offset: 0x1EA0278 VA: 0x1EA4278
	public void Close(bool isDestroy) { }

	[IteratorStateMachine(typeof(UITutorialDialogPanel.<CloseWindow>d__22))]
	// RVA: 0x1EA42C4 Offset: 0x1EA02C4 VA: 0x1EA42C4
	private IEnumerator CloseWindow(bool isDestroy) { }

	// RVA: 0x1EA436C Offset: 0x1EA036C VA: 0x1EA436C
	public void .ctor() { }
}
