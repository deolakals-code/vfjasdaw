// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticSelectType : MonoBehaviour, IUIPetSynthetic // TypeDefIndex: 7768
{
	// Fields
	[SerializeField]
	private GameObject leftTypePanel; // 0x20
	[SerializeField]
	private GameObject rightTypePanel; // 0x28
	[SerializeField]
	private GameObject[] leftTypeObj; // 0x30
	[SerializeField]
	private GameObject[] rightTypeObj; // 0x38
	private PetBattleStatusData leftTypeData; // 0x40
	private PetBattleStatusData rightTypeData; // 0x48
	private int selectPetParam; // 0x50
	private PetSynthesisType selectedType; // 0x54
	private Action<PetSynthesisType, int> getAction; // 0x58
	private SystemTextManager systemTextManager; // 0x60
	private UIImageButton mainButton; // 0x68
	private Coroutine endCoroutine; // 0x70

	// Methods

	// RVA: 0x1C0B060 Offset: 0x1C07060 VA: 0x1C0B060
	public void Initialize(int petParam, PetSynthesisType selectedType, PetBattleStatusData data1, PetBattleStatusData data2, Action<PetSynthesisType, int> getAction) { }

	// RVA: 0x1C0BACC Offset: 0x1C07ACC VA: 0x1C0BACC Slot: 4
	public void InitMainButton(UIImageButton mainButton) { }

	// RVA: 0x1C0BAE8 Offset: 0x1C07AE8 VA: 0x1C0BAE8
	private void SetMainButton() { }

	// RVA: 0x1C0BBC8 Offset: 0x1C07BC8 VA: 0x1C0BBC8 Slot: 5
	public void ClosePanel() { }

	[IteratorStateMachine(typeof(UIPetSyntheticSelectType.<CloseAndDisnablePanel>d__16))]
	// RVA: 0x1C0BBF8 Offset: 0x1C07BF8 VA: 0x1C0BBF8
	private IEnumerator CloseAndDisnablePanel() { }

	// RVA: 0x1C0BC8C Offset: 0x1C07C8C VA: 0x1C0BC8C Slot: 6
	public void ResetElementPos() { }

	// RVA: 0x1C0BCF4 Offset: 0x1C07CF4 VA: 0x1C0BCF4
	private void onLeftSelectType(int param) { }

	// RVA: 0x1C0BD7C Offset: 0x1C07D7C VA: 0x1C0BD7C
	private void onRightSelectType(int param) { }

	// RVA: 0x1C0BE08 Offset: 0x1C07E08 VA: 0x1C0BE08
	private void onNext() { }

	// RVA: 0x1C0B27C Offset: 0x1C0727C VA: 0x1C0B27C
	private void SetLeftType() { }

	// RVA: 0x1C0B684 Offset: 0x1C07684 VA: 0x1C0B684
	private void SetRightType() { }

	// RVA: 0x1C0BE30 Offset: 0x1C07E30 VA: 0x1C0BE30
	public void .ctor() { }
}
