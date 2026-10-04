// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOptionButton : MonoBehaviour // TypeDefIndex: 7516
{
	// Fields
	[SerializeField]
	private UILabel optionName; // 0x20
	[SerializeField]
	private UILabel optionText; // 0x28
	[SerializeField]
	private UILabel optionSelect; // 0x30
	[SerializeField]
	private UISprite crystalSprite; // 0x38
	[SerializeField]
	private GameObject settingObject; // 0x40
	[SerializeField]
	private UISprite openIcon; // 0x48
	[SerializeField]
	private UISprite colorSprite; // 0x50
	private UIOptionButton.OptionButtonType type; // 0x58
	private int optionParameter; // 0x5C
	private int optionId; // 0x60
	private int startParameter; // 0x64
	private float parameterPower; // 0x68
	private UIOptionBaseManager optionBaseManager; // 0x70
	private string[] selectTextList; // 0x78
	private string[] selectTextExList; // 0x80
	private Vector2[] position; // 0x88
	private bool bitFlash; // 0x90
	private bool selectAndFlag; // 0x91
	private string checkBoxText; // 0x98
	private int parameterNum; // 0xA0
	private Action callBackButton; // 0xA8
	private int defaultParam; // 0xB0
	private SpringPosition springPosition; // 0xB8
	private bool isForceClick; // 0xC0
	[CompilerGenerated]
	private int <IndexId>k__BackingField; // 0xC4
	[CompilerGenerated]
	private float <Height>k__BackingField; // 0xC8
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0xCC
	[CompilerGenerated]
	private bool <IsCreateSettingObj>k__BackingField; // 0xCD
	[CompilerGenerated]
	private bool <IsTextColorUpdate>k__BackingField; // 0xCE
	[CompilerGenerated]
	private Color32 <DefaultColor>k__BackingField; // 0xD0
	[CompilerGenerated]
	private string <ContentText>k__BackingField; // 0xD8
	[CompilerGenerated]
	private bool <IsFlagDouble>k__BackingField; // 0xE0
	[CompilerGenerated]
	private string <FlagText>k__BackingField; // 0xE8

	// Properties
	public int IndexId { get; set; }
	public float Height { get; set; }
	public bool IsOpen { get; set; }
	public bool IsCreateSettingObj { get; set; }
	public GameObject SettingObject { get; }
	public bool IsTextColorUpdate { get; set; }
	public Color32 DefaultColor { get; set; }
	public string ContentText { get; set; }
	public bool IsFlagDouble { get; set; }
	public string FlagText { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B82310 Offset: 0x1B7E310 VA: 0x1B82310
	public int get_IndexId() { }

	[CompilerGenerated]
	// RVA: 0x1B82318 Offset: 0x1B7E318 VA: 0x1B82318
	private void set_IndexId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B82320 Offset: 0x1B7E320 VA: 0x1B82320
	public float get_Height() { }

	[CompilerGenerated]
	// RVA: 0x1B82328 Offset: 0x1B7E328 VA: 0x1B82328
	private void set_Height(float value) { }

	[CompilerGenerated]
	// RVA: 0x1B82330 Offset: 0x1B7E330 VA: 0x1B82330
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1B82338 Offset: 0x1B7E338 VA: 0x1B82338
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B82344 Offset: 0x1B7E344 VA: 0x1B82344
	public bool get_IsCreateSettingObj() { }

	[CompilerGenerated]
	// RVA: 0x1B8234C Offset: 0x1B7E34C VA: 0x1B8234C
	private void set_IsCreateSettingObj(bool value) { }

	// RVA: 0x1B82358 Offset: 0x1B7E358 VA: 0x1B82358
	public GameObject get_SettingObject() { }

	[CompilerGenerated]
	// RVA: 0x1B82360 Offset: 0x1B7E360 VA: 0x1B82360
	public bool get_IsTextColorUpdate() { }

	[CompilerGenerated]
	// RVA: 0x1B82368 Offset: 0x1B7E368 VA: 0x1B82368
	private void set_IsTextColorUpdate(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B82374 Offset: 0x1B7E374 VA: 0x1B82374
	public Color32 get_DefaultColor() { }

	[CompilerGenerated]
	// RVA: 0x1B8237C Offset: 0x1B7E37C VA: 0x1B8237C
	private void set_DefaultColor(Color32 value) { }

	[CompilerGenerated]
	// RVA: 0x1B82384 Offset: 0x1B7E384 VA: 0x1B82384
	public string get_ContentText() { }

	[CompilerGenerated]
	// RVA: 0x1B8238C Offset: 0x1B7E38C VA: 0x1B8238C
	private void set_ContentText(string value) { }

	[CompilerGenerated]
	// RVA: 0x1B82394 Offset: 0x1B7E394 VA: 0x1B82394
	public bool get_IsFlagDouble() { }

	[CompilerGenerated]
	// RVA: 0x1B8239C Offset: 0x1B7E39C VA: 0x1B8239C
	private void set_IsFlagDouble(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B823A8 Offset: 0x1B7E3A8 VA: 0x1B823A8
	public string get_FlagText() { }

	[CompilerGenerated]
	// RVA: 0x1B823B0 Offset: 0x1B7E3B0 VA: 0x1B823B0
	private void set_FlagText(string value) { }

	// RVA: 0x1B7D840 Offset: 0x1B79840 VA: 0x1B7D840
	public void Initialize(string name, string text, int id, UIOptionBaseManager manager) { }

	// RVA: 0x1B82474 Offset: 0x1B7E474 VA: 0x1B82474
	public void SetOptionText(string text) { }

	// RVA: 0x1B7D8D8 Offset: 0x1B798D8 VA: 0x1B7D8D8
	public void SetIndexId(int indexId) { }

	// RVA: 0x1B7E4C8 Offset: 0x1B7A4C8 VA: 0x1B7E4C8
	public void SetHeight(float height) { }

	// RVA: 0x1B8247C Offset: 0x1B7E47C VA: 0x1B8247C
	public void SetDefaultParam(int defaultParam) { }

	// RVA: 0x1B7DE58 Offset: 0x1B79E58 VA: 0x1B7DE58
	public void SetTextColorUpdateFlag(bool isTextColorUpdate) { }

	// RVA: 0x1B7DE64 Offset: 0x1B79E64 VA: 0x1B7DE64
	public void SetDefaultColor(Color32 defaultColor) { }

	// RVA: 0x1B7BE60 Offset: 0x1B77E60 VA: 0x1B7BE60
	public void SetSelectText(string[] selectTypeText) { }

	// RVA: 0x1B7C49C Offset: 0x1B7849C VA: 0x1B7C49C
	public void SetSelectText(string[] selectTypeText, string[] selectTypeTextEx) { }

	// RVA: 0x1B7FF64 Offset: 0x1B7BF64 VA: 0x1B7FF64
	public string GetSelectText(int id) { }

	// RVA: 0x1B7C0F8 Offset: 0x1B780F8 VA: 0x1B7C0F8
	public void ColorButton(Color32 setColor) { }

	// RVA: 0x1B7BE84 Offset: 0x1B77E84 VA: 0x1B7BE84
	public void FlagButton(bool check, bool isFlagDouble = False, string flagText) { }

	// RVA: 0x1B7C0DC Offset: 0x1B780DC VA: 0x1B7C0DC
	public void WarningFlagButton(bool check) { }

	// RVA: 0x1B82484 Offset: 0x1B7E484 VA: 0x1B82484
	private void SetFlagButton(bool check) { }

	// RVA: 0x1B7F1B0 Offset: 0x1B7B1B0 VA: 0x1B7F1B0
	public void PercentButton(int percent) { }

	// RVA: 0x1B7C0EC Offset: 0x1B780EC VA: 0x1B7C0EC
	public void PercentButton(int percent, int start, float power) { }

	// RVA: 0x1B7C464 Offset: 0x1B78464 VA: 0x1B7C464
	public void SelectButton(int select) { }

	// RVA: 0x1B7CF44 Offset: 0x1B78F44 VA: 0x1B7CF44
	public void SelectAndFlag(int select, bool flag, string checkBoxText) { }

	// RVA: 0x1B7F6B0 Offset: 0x1B7B6B0 VA: 0x1B7F6B0
	public void SelectButtonUpdate(int select) { }

	// RVA: 0x1B7F7F0 Offset: 0x1B7B7F0 VA: 0x1B7F7F0
	public void SelectAndFlagButtonUpdate(int select, bool flag) { }

	// RVA: 0x1B7C480 Offset: 0x1B78480 VA: 0x1B7C480
	public void SelectButtonReverse(int select) { }

	// RVA: 0x1B7CB44 Offset: 0x1B78B44 VA: 0x1B7CB44
	public void SetBitCheckBox(string[] selectTypeText, Vector2[] selectPos, bool bitFlash) { }

	// RVA: 0x1B7CB80 Offset: 0x1B78B80 VA: 0x1B7CB80
	public void SelectBitCheckBoxButton(int bitBox) { }

	// RVA: 0x1B82520 Offset: 0x1B7E520 VA: 0x1B82520
	private void FlashBitCheckBoxButton() { }

	// RVA: 0x1B7CFEC Offset: 0x1B78FEC VA: 0x1B7CFEC
	public void SelectBitCheckBoxAndFlagButton(int bitBox) { }

	// RVA: 0x1B7D5F4 Offset: 0x1B795F4 VA: 0x1B7D5F4
	public void SelectSwitchButton(int param, int paramNum) { }

	// RVA: 0x1B80FB4 Offset: 0x1B7CFB4 VA: 0x1B80FB4
	public void NewSwitchButtonUpdate(int select) { }

	// RVA: 0x1B7E0B4 Offset: 0x1B7A0B4 VA: 0x1B7E0B4
	public void NewSwitchButton(int select) { }

	// RVA: 0x1B79834 Offset: 0x1B75834 VA: 0x1B79834
	public void CallBackButton(Action callbackAction) { }

	// RVA: 0x1B8257C Offset: 0x1B7E57C VA: 0x1B8257C
	public void SetEnableSelectText(bool isEnable) { }

	// RVA: 0x1B8259C Offset: 0x1B7E59C VA: 0x1B8259C
	public void SetSelectText(string text) { }

	// RVA: 0x1B825B8 Offset: 0x1B7E5B8 VA: 0x1B825B8
	public void SetTitleText(string text) { }

	// RVA: 0x1B825D4 Offset: 0x1B7E5D4 VA: 0x1B825D4
	public void SetMesText(string text) { }

	// RVA: 0x1B825F0 Offset: 0x1B7E5F0 VA: 0x1B825F0
	public void SetSelectTextExList(string[] exList) { }

	// RVA: 0x1B82640 Offset: 0x1B7E640 VA: 0x1B82640
	public void OnClick() { }

	// RVA: 0x1B7BB5C Offset: 0x1B77B5C VA: 0x1B7BB5C
	public void ForceOnClick() { }

	// RVA: 0x1B7FFDC Offset: 0x1B7BFDC VA: 0x1B7FFDC
	public void SetCreateSettingObjFlag(bool isCreate) { }

	// RVA: 0x1B7FFE8 Offset: 0x1B7BFE8 VA: 0x1B7FFE8
	public void ChangeSettingObjActive(bool isActive) { }

	// RVA: 0x1B823B8 Offset: 0x1B7E3B8 VA: 0x1B823B8
	private void UpdateOpenIcon() { }

	// RVA: 0x1B82B64 Offset: 0x1B7EB64 VA: 0x1B82B64
	public void .ctor() { }
}
