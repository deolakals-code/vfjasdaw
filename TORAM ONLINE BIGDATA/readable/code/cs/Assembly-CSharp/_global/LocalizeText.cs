// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UILabel))]
public class LocalizeText : MonoBehaviour // TypeDefIndex: 5255
{
	// Fields
	[SerializeField]
	private string localizeKeyText; // 0x20
	[SerializeField]
	private string[] localizeKeyArgs; // 0x28
	[SerializeField]
	private LocalizeManager.LocalizeType localizeType; // 0x30
	[CompilerGenerated]
	private string <LocalizedOriginalText>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <LocalizedText>k__BackingField; // 0x40
	private UILabel labelComponent; // 0x48

	// Properties
	[HideInInspector]
	public string LocalizedOriginalText { get; set; }
	[HideInInspector]
	public string LocalizedText { get; set; }
	public UILabel LabelComponent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2619688 Offset: 0x2615688 VA: 0x2619688
	public string get_LocalizedOriginalText() { }

	[CompilerGenerated]
	// RVA: 0x2619690 Offset: 0x2615690 VA: 0x2619690
	private void set_LocalizedOriginalText(string value) { }

	[CompilerGenerated]
	// RVA: 0x2619698 Offset: 0x2615698 VA: 0x2619698
	public string get_LocalizedText() { }

	[CompilerGenerated]
	// RVA: 0x26196A0 Offset: 0x26156A0 VA: 0x26196A0
	private void set_LocalizedText(string value) { }

	// RVA: 0x26196A8 Offset: 0x26156A8 VA: 0x26196A8
	public UILabel get_LabelComponent() { }

	// RVA: 0x2619750 Offset: 0x2615750 VA: 0x2619750
	private void set_LabelComponent(UILabel value) { }

	// RVA: 0x2619758 Offset: 0x2615758 VA: 0x2619758
	private void Awake() { }

	// RVA: 0x26197F8 Offset: 0x26157F8 VA: 0x26197F8
	private void Update() { }

	// RVA: 0x260F424 Offset: 0x260B424 VA: 0x260F424
	public void LoadLocalize() { }

	// RVA: 0x260F2A0 Offset: 0x260B2A0 VA: 0x260F2A0
	public void LoadLocalize(bool focusLoad) { }

	// RVA: 0x261979C Offset: 0x261579C VA: 0x261979C
	public void LoadLocalizeFormat(object[] args) { }

	[IteratorStateMachine(typeof(LocalizeText.<loadLocalize>d__20))]
	// RVA: 0x26197FC Offset: 0x26157FC VA: 0x26197FC
	private IEnumerator loadLocalize(bool focusLoad) { }

	[IteratorStateMachine(typeof(LocalizeText.<loadLocalizeFormat>d__21))]
	// RVA: 0x261987C Offset: 0x261587C VA: 0x261987C
	public IEnumerator loadLocalizeFormat(object[] args) { }

	// RVA: 0x2619954 Offset: 0x2615954 VA: 0x2619954
	public void .ctor() { }
}
