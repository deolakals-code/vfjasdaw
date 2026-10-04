// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticSelectForm : MonoBehaviour, IUIPetSynthetic // TypeDefIndex: 7764
{
	// Fields
	[SerializeField]
	private UILabel[] bonusLabel; // 0x20
	private Action<int> getAction; // 0x28
	private SystemTextManager systemTextManager; // 0x30
	private Coroutine endCoroutine; // 0x38

	// Methods

	// RVA: 0x1C092D0 Offset: 0x1C052D0 VA: 0x1C092D0
	public void Initialize(byte refine1, byte refine2, Action<int> getAction) { }

	// RVA: 0x1C095C8 Offset: 0x1C055C8 VA: 0x1C095C8 Slot: 5
	public void ClosePanel() { }

	[IteratorStateMachine(typeof(UIPetSyntheticSelectForm.<CloseAndDisnablePanel>d__6))]
	// RVA: 0x1C09620 Offset: 0x1C05620 VA: 0x1C09620
	private IEnumerator CloseAndDisnablePanel() { }

	// RVA: 0x1C096B4 Offset: 0x1C056B4 VA: 0x1C096B4 Slot: 6
	public void ResetElementPos() { }

	// RVA: 0x1C09728 Offset: 0x1C05728 VA: 0x1C09728
	private void onSelect(int param) { }

	// RVA: 0x1C097AC Offset: 0x1C057AC VA: 0x1C097AC Slot: 4
	public void InitMainButton(UIImageButton mainButton) { }

	// RVA: 0x1C097E4 Offset: 0x1C057E4 VA: 0x1C097E4
	public void .ctor() { }
}
