// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildChangeNameWindow : MonoBehaviour // TypeDefIndex: 7104
{
	// Fields
	[SerializeField]
	private UILabel inputLabel; // 0x20
	[SerializeField]
	private TweenColor inputBackTween; // 0x28
	[SerializeField]
	private GameObject inputObject; // 0x30
	[SerializeField]
	private UIImageButton buttonImage; // 0x38
	[SerializeField]
	private UILabel buttonLabel; // 0x40
	[SerializeField]
	private UILabel mainLabel; // 0x48
	[SerializeField]
	private UILabel errorLabel; // 0x50
	[SerializeField]
	private UISlider progressSlider; // 0x58
	[SerializeField]
	private GameObject checkObject; // 0x60
	[SerializeField]
	private UIIruna2AnchorSimple guildNameAnchor; // 0x68
	[SerializeField]
	private UILabel progressTextLabel; // 0x70
	[SerializeField]
	private UILabel cancelButtonLabel; // 0x78
	[SerializeField]
	private UILabel printLabel; // 0x80
	private Action<string> callback; // 0x88
	private Action<string> inputCallback; // 0x90
	private UIBasePanelControl TopControl; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	private bool isSpinaOK; // 0xA8
	private bool isEnabledButton; // 0xA9
	private PlayerDataManager playerDataManager; // 0xB0
	private UIInput uiInput; // 0xB8

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1A95BA0 Offset: 0x1A91BA0 VA: 0x1A95BA0
	public bool get_IsActive() { }

	// RVA: 0x1A95BC0 Offset: 0x1A91BC0 VA: 0x1A95BC0
	private void Awake() { }

	// RVA: 0x1A95CC8 Offset: 0x1A91CC8 VA: 0x1A95CC8
	public void InitializeGuildName() { }

	// RVA: 0x1A95D18 Offset: 0x1A91D18 VA: 0x1A95D18
	public void InitializeGuildName(string defaultName) { }

	// RVA: 0x1A95D54 Offset: 0x1A91D54 VA: 0x1A95D54
	public void Open(Action<string> inputCallback, Action<string> callback, UIBasePanelControl topControl) { }

	// RVA: 0x1A95F78 Offset: 0x1A91F78 VA: 0x1A95F78
	public void OnSubmit() { }

	// RVA: 0x1A96148 Offset: 0x1A92148 VA: 0x1A96148
	public void SetEnableButton(bool isUsable) { }

	// RVA: 0x1A9628C Offset: 0x1A9228C VA: 0x1A9628C
	public void SetSpinaEnableButton(bool isEnable) { }

	// RVA: 0x1A9637C Offset: 0x1A9237C VA: 0x1A9637C
	private void onCheckRename() { }

	// RVA: 0x1A963F8 Offset: 0x1A923F8 VA: 0x1A963F8
	public void OnClose() { }

	[IteratorStateMachine(typeof(UIGuildChangeNameWindow.<StartProgress>d__32))]
	// RVA: 0x1A9641C Offset: 0x1A9241C VA: 0x1A9641C
	public IEnumerator StartProgress(string newName, Action<string> callback) { }

	// RVA: 0x1A964E0 Offset: 0x1A924E0 VA: 0x1A964E0
	public void FinishRename() { }

	// RVA: 0x1A965B0 Offset: 0x1A925B0 VA: 0x1A965B0
	public void OnRenameCancel() { }

	// RVA: 0x1A965B4 Offset: 0x1A925B4 VA: 0x1A965B4
	public void .ctor() { }
}
