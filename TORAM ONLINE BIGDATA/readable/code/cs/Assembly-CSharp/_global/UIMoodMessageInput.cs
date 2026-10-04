// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMoodMessageInput : MonoBehaviour // TypeDefIndex: 8169
{
	// Fields
	[SerializeField]
	private UIToggle toggle; // 0x20
	[SerializeField]
	private UIInput input; // 0x28
	[SerializeField]
	private UILabel inputLabel; // 0x30
	[SerializeField]
	private TweenAlpha errTweenAlpha; // 0x38
	private string saveLabel; // 0x40
	private bool IsErr; // 0x48

	// Properties
	public string Text { get; }
	public bool IsFocus { get; }

	// Methods

	// RVA: 0x1CE2F04 Offset: 0x1CDEF04 VA: 0x1CE2F04
	public string get_Text() { }

	// RVA: 0x1CE2F34 Offset: 0x1CDEF34 VA: 0x1CE2F34
	public bool get_IsFocus() { }

	// RVA: 0x1CE2F50 Offset: 0x1CDEF50 VA: 0x1CE2F50
	public void Initialize(string baseText, string userText, bool defalutErr) { }

	// RVA: 0x1CE2FCC Offset: 0x1CDEFCC VA: 0x1CE2FCC
	public void OnErrCheck() { }

	// RVA: 0x1CE3010 Offset: 0x1CDF010 VA: 0x1CE3010
	private void ErrText() { }

	// RVA: 0x1CE30A0 Offset: 0x1CDF0A0 VA: 0x1CE30A0
	public void OnSubmitText() { }

	// RVA: 0x1CE3190 Offset: 0x1CDF190 VA: 0x1CE3190
	private void ErrWordCheck(string text) { }

	// RVA: 0x1CE349C Offset: 0x1CDF49C VA: 0x1CE349C
	public void .ctor() { }
}
