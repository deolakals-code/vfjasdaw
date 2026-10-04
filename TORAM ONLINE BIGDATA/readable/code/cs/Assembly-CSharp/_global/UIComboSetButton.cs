// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIComboSetButton : MonoBehaviour // TypeDefIndex: 6869
{
	// Fields
	[SerializeField]
	private UILabel comboNameLabel; // 0x20
	[SerializeField]
	private UIImageButton comboButton; // 0x28
	[SerializeField]
	private UILabel baseSkillNameLabel; // 0x30
	[SerializeField]
	private UIIcon baseSkillIcon; // 0x38
	[SerializeField]
	private GameObject deriveSkillIconObject; // 0x40
	[SerializeField]
	private GameObject equipUnusableLabelObject; // 0x48
	[SerializeField]
	private UIToggle comboFlagToggle; // 0x50
	[SerializeField]
	private UILabel comboFlagLabel; // 0x58
	[SerializeField]
	private UIInput input; // 0x60
	[SerializeField]
	private UILabel memoLabel; // 0x68
	[SerializeField]
	private GameObject releaseButtonObject; // 0x70
	private static readonly float DeriveSkillIconBasePositionX; // 0x0
	private static readonly float DeriveSkillIconSpace; // 0x4
	private UIComboPanelManager manager; // 0x78
	private SystemTextManager systemTextManager; // 0x80
	private int comboId; // 0x88
	private bool comboEnable; // 0x8C
	private List<UIIcon> deriveSkillIconList; // 0x90
	private bool isReleased; // 0x98
	private bool isComboNG; // 0x99

	// Properties
	public bool IsComboNG { get; }

	// Methods

	// RVA: 0x1A25CD8 Offset: 0x1A21CD8 VA: 0x1A25CD8
	public bool get_IsComboNG() { }

	// RVA: 0x1A226A0 Offset: 0x1A1E6A0 VA: 0x1A226A0
	public void Initialize(UIComboPanelManager manager, int id, short[] skillIdList, bool ngCheck, bool enable) { }

	// RVA: 0x1A2187C Offset: 0x1A1D87C VA: 0x1A2187C
	public void Initialize(UIComboPanelManager manager, int id, bool canRelease) { }

	// RVA: 0x1A25CE0 Offset: 0x1A21CE0 VA: 0x1A25CE0
	private void SetDeriveSkillIcon(short[] idList) { }

	// RVA: 0x1A215EC Offset: 0x1A1D5EC VA: 0x1A215EC
	public void SwitchEnabledComboButton(bool idEnabled) { }

	// RVA: 0x1A231C8 Offset: 0x1A1F1C8 VA: 0x1A231C8
	public void SwitchEnabledFlagButton(bool idEnabled) { }

	// RVA: 0x1A2616C Offset: 0x1A2216C VA: 0x1A2616C
	private void OnClickSwitchButton() { }

	// RVA: 0x1A261A0 Offset: 0x1A221A0 VA: 0x1A261A0
	private void OnButtonSelect() { }

	// RVA: 0x1A261C0 Offset: 0x1A221C0 VA: 0x1A261C0
	public void OnSubmitText() { }

	// RVA: 0x1A263C4 Offset: 0x1A223C4 VA: 0x1A263C4
	private void OnReleaseButton() { }

	// RVA: 0x1A263F4 Offset: 0x1A223F4 VA: 0x1A263F4
	public void .ctor() { }

	// RVA: 0x1A26484 Offset: 0x1A22484 VA: 0x1A26484
	private static void .cctor() { }
}
