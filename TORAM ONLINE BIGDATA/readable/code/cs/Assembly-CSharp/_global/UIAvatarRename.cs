// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIAvatarRename : MonoBehaviour // TypeDefIndex: 8856
{
	// Fields
	[SerializeField]
	private UILabel playerNameLabel; // 0x20
	[SerializeField]
	private UIInput playerNameInput; // 0x28
	[SerializeField]
	private TweenAlpha playerNameTweenAlpha; // 0x30
	[SerializeField]
	private GameObject keybordOptionSettingButton; // 0x38
	[SerializeField]
	private UILabel keybordOptionSettingButtonLabel; // 0x40
	[SerializeField]
	private GameObject keybordOptionSettingButtonIcon; // 0x48
	[SerializeField]
	private Camera uiMainCamera; // 0x50
	[SerializeField]
	private UIIruna2AnchorSimple namePanel; // 0x58
	[SerializeField]
	private UIIruna2AnchorSimple keybordButton; // 0x60
	[SerializeField]
	private UILabel inputContentLabel; // 0x68
	private string playerName; // 0x70
	private SystemTextManager systemTextManager; // 0x78
	private AvatarRenameManager avatarRenameManager; // 0x80
	private bool isPopupOptionWindow; // 0x88
	private GameObject loadingModel; // 0x90

	// Methods

	// RVA: 0x1E385E0 Offset: 0x1E345E0 VA: 0x1E385E0
	private void Awake() { }

	// RVA: 0x1E38630 Offset: 0x1E34630 VA: 0x1E38630
	public void Initialize(AvatarRenameManager manager) { }

	[IteratorStateMachine(typeof(UIAvatarRename.<UIInit>d__17))]
	// RVA: 0x1E3865C Offset: 0x1E3465C VA: 0x1E3865C
	private IEnumerator UIInit() { }

	[IteratorStateMachine(typeof(UIAvatarRename.<InitializeLocalize>d__18))]
	// RVA: 0x1E386F0 Offset: 0x1E346F0 VA: 0x1E386F0
	private IEnumerator InitializeLocalize() { }

	// RVA: 0x1E38784 Offset: 0x1E34784 VA: 0x1E38784
	private void getPlayerName() { }

	// RVA: 0x1E38D64 Offset: 0x1E34D64 VA: 0x1E38D64
	private void RenameResult(GameReturnCode code) { }

	[IteratorStateMachine(typeof(UIAvatarRename.<CreateSuccess>d__21))]
	// RVA: 0x1E38F54 Offset: 0x1E34F54 VA: 0x1E38F54
	private IEnumerator CreateSuccess() { }

	// RVA: 0x1E38FE8 Offset: 0x1E34FE8 VA: 0x1E38FE8
	private void OnPress() { }

	// RVA: 0x1E39004 Offset: 0x1E35004 VA: 0x1E39004
	public void OnPopOptionWindow() { }

	[IteratorStateMachine(typeof(UIAvatarRename.<popOptionWindow>d__24))]
	// RVA: 0x1E39034 Offset: 0x1E35034 VA: 0x1E39034
	private IEnumerator popOptionWindow() { }

	// RVA: 0x1E390A8 Offset: 0x1E350A8 VA: 0x1E390A8
	private void OnChangeKeybordOption() { }

	// RVA: 0x1E391E0 Offset: 0x1E351E0 VA: 0x1E391E0
	public void .ctor() { }
}
