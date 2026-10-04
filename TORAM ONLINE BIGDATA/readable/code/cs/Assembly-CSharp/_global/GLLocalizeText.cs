// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UIGLLabel))]
public class GLLocalizeText : MonoBehaviour // TypeDefIndex: 5230
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
	private UIGLLabel labelComponent; // 0x48

	// Properties
	[HideInInspector]
	public string LocalizedOriginalText { get; set; }
	[HideInInspector]
	public string LocalizedText { get; set; }
	public UIGLLabel LabelComponent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x261100C Offset: 0x260D00C VA: 0x261100C
	public string get_LocalizedOriginalText() { }

	[CompilerGenerated]
	// RVA: 0x2611014 Offset: 0x260D014 VA: 0x2611014
	private void set_LocalizedOriginalText(string value) { }

	[CompilerGenerated]
	// RVA: 0x261101C Offset: 0x260D01C VA: 0x261101C
	public string get_LocalizedText() { }

	[CompilerGenerated]
	// RVA: 0x2611024 Offset: 0x260D024 VA: 0x2611024
	private void set_LocalizedText(string value) { }

	// RVA: 0x261102C Offset: 0x260D02C VA: 0x261102C
	public UIGLLabel get_LabelComponent() { }

	// RVA: 0x26110D4 Offset: 0x260D0D4 VA: 0x26110D4
	private void set_LabelComponent(UIGLLabel value) { }

	// RVA: 0x26110DC Offset: 0x260D0DC VA: 0x26110DC
	private void Awake() { }

	// RVA: 0x26111A0 Offset: 0x260D1A0 VA: 0x26111A0
	private void Update() { }

	// RVA: 0x2611120 Offset: 0x260D120 VA: 0x2611120
	public void LoadLocalize() { }

	// RVA: 0x26111A4 Offset: 0x260D1A4 VA: 0x26111A4
	public void LoadLocalize(bool focusLoad) { }

	// RVA: 0x2611144 Offset: 0x260D144 VA: 0x2611144
	public void LoadLocalizeFormat(object[] args) { }

	[IteratorStateMachine(typeof(GLLocalizeText.<loadLocalize>d__20))]
	// RVA: 0x26111C8 Offset: 0x260D1C8 VA: 0x26111C8
	private IEnumerator loadLocalize(bool focusLoad) { }

	[IteratorStateMachine(typeof(GLLocalizeText.<loadLocalizeFormat>d__21))]
	// RVA: 0x2611248 Offset: 0x260D248 VA: 0x2611248
	public IEnumerator loadLocalizeFormat(object[] args) { }

	// RVA: 0x2611320 Offset: 0x260D320 VA: 0x2611320
	public void .ctor() { }
}
