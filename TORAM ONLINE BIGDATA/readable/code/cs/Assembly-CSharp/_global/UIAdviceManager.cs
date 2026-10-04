// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIAdviceManager : MonoBehaviour // TypeDefIndex: 8134
{
	// Fields
	protected SystemTextManager systemTextManager; // 0x20
	private string adviceMessageText; // 0x28
	private bool cancelCheck; // 0x30
	private UnityAction popupButtonEvent; // 0x38
	private string adviceTitleText; // 0x40
	private string adviceWindowMessageText; // 0x48
	private string adviceButtonText; // 0x50
	private bool initializeFlag; // 0x58

	// Methods

	// RVA: 0x1CD3C60 Offset: 0x1CCFC60 VA: 0x1CD3C60
	protected void Start() { }

	// RVA: 0x1CD3E38 Offset: 0x1CCFE38 VA: 0x1CD3E38
	public void Initialize(UnityAction action) { }

	// RVA: 0x1CD3F68 Offset: 0x1CCFF68 VA: 0x1CD3F68
	public void ChangeCancelFlag(bool flag) { }

	// RVA: 0x1CD3F74 Offset: 0x1CCFF74 VA: 0x1CD3F74
	public void OnAdviceMessageButton() { }

	[IteratorStateMachine(typeof(UIAdviceManager.<PopUpAdviceMessage>d__12))]
	// RVA: 0x1CD3FFC Offset: 0x1CCFFFC VA: 0x1CD3FFC
	private IEnumerator PopUpAdviceMessage() { }

	// RVA: 0x1CD4090 Offset: 0x1CD0090 VA: 0x1CD4090 Slot: 4
	public virtual void SetAdviceText(string title, string message, string buttonMessage) { }

	// RVA: 0x1CD4128 Offset: 0x1CD0128 VA: 0x1CD4128
	public PopUpMessageWindow CreateAdviceMessageWindow() { }

	// RVA: 0x1CD424C Offset: 0x1CD024C VA: 0x1CD424C
	public void .ctor() { }
}
