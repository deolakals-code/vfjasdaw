// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseAddressManager : UIBasePanelConnection // TypeDefIndex: 7196
{
	// Fields
	private UIHouseAddressManager.STATE state; // 0x2C
	private UIHouseAddressManager.STATE previousState; // 0x30
	[SerializeField]
	private LabelWithIcon title; // 0x38
	[SerializeField]
	private GameObject messageIcon; // 0x40
	[SerializeField]
	private GameObject messageLabel; // 0x48
	[SerializeField]
	private GameObject messageSubLabel; // 0x50
	[SerializeField]
	private GameObject simpleCodeLabel; // 0x58
	[SerializeField]
	private GameObject inputHelpLabel; // 0x60
	[SerializeField]
	private GameObject selectTownButton; // 0x68
	[SerializeField]
	private GameObject selectSectionButton; // 0x70
	[SerializeField]
	private GameObject inputNumberPlate; // 0x78
	[SerializeField]
	private GameObject addressPlate; // 0x80
	[SerializeField]
	private GameObject copyButton; // 0x88
	[SerializeField]
	private GameObject searchAddressButton; // 0x90
	[SerializeField]
	private GameObject searchSimpleCodeButton; // 0x98
	[SerializeField]
	private GameObject progressBar; // 0xA0
	[SerializeField]
	private GameObject okButton; // 0xA8
	[SerializeField]
	private GameObject separateBar; // 0xB0
	[SerializeField]
	private GameObject simpleRegisterButton; // 0xB8
	[SerializeField]
	private GameObject deleteAddressButton; // 0xC0
	[CompilerGenerated]
	private int <CurrentAddress>k__BackingField; // 0xC8
	[CompilerGenerated]
	private int <SendAddress>k__BackingField; // 0xCC
	private readonly IReadOnlyCollection<UIHouseAddressManager.Town> towns; // 0xD0
	private readonly Dictionary<string, UIHouseAddressManager.Town> townData; // 0xD8
	private readonly List<string> registerTownList; // 0xE0
	private readonly List<string> searchTownList; // 0xE8
	private readonly List<string> easyRegisterTownList; // 0xF0
	private readonly List<byte> enableEasyRegisterTownCodeList; // 0xF8
	private UISelectButton uiSelectTown; // 0x100
	private UISelectButton uiSelectSection; // 0x108
	private UIInput uiInputNumber; // 0x110
	private UIAtlas iconAtlas; // 0x118
	private UIAtlas systemIconAtlas; // 0x120
	private bool isConnect; // 0x128
	private bool isClose; // 0x129

	// Properties
	private byte SelectTownCode { get; }
	private byte SelectSectionCode { get; }
	private int InputNumber { get; }
	private int SelectAddress { get; }
	public int CurrentAddress { get; set; }
	private int SendAddress { get; set; }

	// Methods

	// RVA: 0x1ACEFD4 Offset: 0x1ACAFD4 VA: 0x1ACEFD4
	private byte get_SelectTownCode() { }

	// RVA: 0x1ACF050 Offset: 0x1ACB050 VA: 0x1ACF050
	private byte get_SelectSectionCode() { }

	// RVA: 0x1ACF070 Offset: 0x1ACB070 VA: 0x1ACF070
	private int get_InputNumber() { }

	// RVA: 0x1ACF094 Offset: 0x1ACB094 VA: 0x1ACF094
	private int get_SelectAddress() { }

	[CompilerGenerated]
	// RVA: 0x1ACF110 Offset: 0x1ACB110 VA: 0x1ACF110
	public int get_CurrentAddress() { }

	[CompilerGenerated]
	// RVA: 0x1ACF118 Offset: 0x1ACB118 VA: 0x1ACF118
	private void set_CurrentAddress(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ACF120 Offset: 0x1ACB120 VA: 0x1ACF120
	private int get_SendAddress() { }

	[CompilerGenerated]
	// RVA: 0x1ACF128 Offset: 0x1ACB128 VA: 0x1ACF128
	private void set_SendAddress(int value) { }

	// RVA: 0x1ACF130 Offset: 0x1ACB130 VA: 0x1ACF130
	private void Awake() { }

	// RVA: 0x1ACFB04 Offset: 0x1ACBB04 VA: 0x1ACFB04
	private void Start() { }

	// RVA: 0x1ACF39C Offset: 0x1ACB39C VA: 0x1ACF39C
	private void CreateList() { }

	// RVA: 0x1ACFBFC Offset: 0x1ACBBFC VA: 0x1ACFBFC
	private void SetLayout(UIHouseAddressManager.STATE state, string message = "") { }

	// RVA: 0x1AD1698 Offset: 0x1ACD698 VA: 0x1AD1698
	private void SetConnection(IReconnectionSubData data) { }

	[IteratorStateMachine(typeof(UIHouseAddressManager.<RetryEasyRegister>d__61))]
	// RVA: 0x1AD1A4C Offset: 0x1ACDA4C VA: 0x1AD1A4C
	private IEnumerator RetryEasyRegister() { }

	[IteratorStateMachine(typeof(UIHouseAddressManager.<ProgressStart>d__62))]
	// RVA: 0x1AD19D0 Offset: 0x1ACD9D0 VA: 0x1AD19D0
	private IEnumerator ProgressStart(float waitTime) { }

	// RVA: 0x1AD1B08 Offset: 0x1ACDB08 VA: 0x1AD1B08
	private string GetAddressText(int address) { }

	// RVA: 0x1AD18C0 Offset: 0x1ACD8C0 VA: 0x1AD18C0
	private void SetAddressPlate(int address) { }

	// RVA: 0x1AD1898 Offset: 0x1ACD898 VA: 0x1AD1898
	public void OnSelectValueChanged() { }

	// RVA: 0x1AD1DA8 Offset: 0x1ACDDA8 VA: 0x1AD1DA8
	public void OnAddressNumberInput() { }

	// RVA: 0x1AD1F18 Offset: 0x1ACDF18 VA: 0x1AD1F18
	private bool CheckInputNumber() { }

	// RVA: 0x1AD1D34 Offset: 0x1ACDD34 VA: 0x1AD1D34
	private bool CheckSelectAddress() { }

	// RVA: 0x1AD1FD0 Offset: 0x1ACDFD0 VA: 0x1AD1FD0
	private byte GetEasyRegisterSendTownCode() { }

	// RVA: 0x1AD20B8 Offset: 0x1ACE0B8 VA: 0x1AD20B8
	public void OnOkButton() { }

	// RVA: 0x1AD2738 Offset: 0x1ACE738 VA: 0x1AD2738
	public void OnCopyButton() { }

	// RVA: 0x1AD284C Offset: 0x1ACE84C VA: 0x1AD284C
	public void OnSimpleRegisterButton() { }

	// RVA: 0x1AD28CC Offset: 0x1ACE8CC VA: 0x1AD28CC
	public void OnDeleteAddressButton() { }

	// RVA: 0x1AD294C Offset: 0x1ACE94C VA: 0x1AD294C
	public void OnSelectGoToAddressButton() { }

	// RVA: 0x1AD29CC Offset: 0x1ACE9CC VA: 0x1AD29CC
	public void OnInputGoToSimpleAddressButton() { }

	// RVA: 0x1AD2A4C Offset: 0x1ACEA4C VA: 0x1AD2A4C
	public void OnSearchAddressButton() { }

	// RVA: 0x1AD2ACC Offset: 0x1ACEACC VA: 0x1AD2ACC
	public void OnSuccessSearch(int id) { }

	// RVA: 0x1AD2BD8 Offset: 0x1ACEBD8 VA: 0x1AD2BD8
	public void OnFailedEnter(short returnCode) { }

	// RVA: 0x1AD2C24 Offset: 0x1ACEC24 VA: 0x1AD2C24
	private void OnFailureConnection(string key, string[] list) { }

	// RVA: 0x1AD2C80 Offset: 0x1ACEC80 VA: 0x1AD2C80 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AD2DFC Offset: 0x1ACEDFC VA: 0x1AD2DFC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AD2EAC Offset: 0x1ACEEAC VA: 0x1AD2EAC
	public void .ctor() { }
}
