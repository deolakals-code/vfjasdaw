// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletMultiDisassemblyPanel : MonoBehaviour, UIRegistletBasePanel // TypeDefIndex: 7931
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	[SerializeField]
	private GameObject[] windowPanelObjs; // 0x28
	[SerializeField]
	private UILabel buttonLabel; // 0x30
	[SerializeField]
	private UIImageButton breakButton; // 0x38
	[SerializeField]
	private UILabel gemPowderNumLabel; // 0x40
	[SerializeField]
	private UILabel gemCartNumLabel; // 0x48
	[SerializeField]
	private UILabel getPowderNumLabel; // 0x50
	[SerializeField]
	private UILabel resultGetPowderNumLabel; // 0x58
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x60
	[SerializeField]
	private UIRegistletElement element; // 0x68
	[SerializeField]
	private UISlider delaySlider; // 0x70
	private UIRegistletMainManager manager; // 0x78
	private SystemTextManager systemTextManager; // 0x80
	private RegistletTextManager registletTextManager; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private List<GemCartData> selectDataList; // 0x98
	private List<UIRegistletListButton> listButtonList; // 0xA0
	private UIRegistletMultiDisassemblyPanel.WindowPanelType nowPanelType; // 0xA8
	private bool isFirstOpen; // 0xAC

	// Methods

	// RVA: 0x1C66918 Offset: 0x1C62918 VA: 0x1C66918
	private void Update() { }

	// RVA: 0x1C66BE0 Offset: 0x1C62BE0 VA: 0x1C66BE0 Slot: 4
	public void Initialize(UIRegistletMainManager manager, SystemTextManager systemTextManager, RegistletTextManager registletTextManager) { }

	// RVA: 0x1C66C60 Offset: 0x1C62C60 VA: 0x1C66C60 Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C67210 Offset: 0x1C63210 VA: 0x1C67210 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C67234 Offset: 0x1C63234 VA: 0x1C67234 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C6723C Offset: 0x1C6323C VA: 0x1C6723C Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C6739C Offset: 0x1C6339C VA: 0x1C6739C Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C671B0 Offset: 0x1C631B0 VA: 0x1C671B0
	private void UpdateGemCount() { }

	// RVA: 0x1C6708C Offset: 0x1C6308C VA: 0x1C6708C
	private void UpdateGetGemCount() { }

	// RVA: 0x1C66EA8 Offset: 0x1C62EA8 VA: 0x1C66EA8
	private void OpenPanelState(bool isOpen, UIRegistletMultiDisassemblyPanel.WindowPanelType type) { }

	// RVA: 0x1C673A4 Offset: 0x1C633A4 VA: 0x1C673A4
	private void CreateCheckList() { }

	// RVA: 0x1C66950 Offset: 0x1C62950 VA: 0x1C66950
	private void UpdateScrollElementActive() { }

	// RVA: 0x1C67750 Offset: 0x1C63750 VA: 0x1C67750
	public void OnClickListButton(int param) { }

	// RVA: 0x1C67304 Offset: 0x1C63304 VA: 0x1C67304
	public void OnClickWindowButton() { }

	// RVA: 0x1C67CC0 Offset: 0x1C63CC0 VA: 0x1C67CC0
	public void OnClickDisButton() { }

	[IteratorStateMachine(typeof(UIRegistletMultiDisassemblyPanel.<DelaySliderToResult>d__35))]
	// RVA: 0x1C676E4 Offset: 0x1C636E4 VA: 0x1C676E4
	private IEnumerator DelaySliderToResult() { }

	[IteratorStateMachine(typeof(UIRegistletMultiDisassemblyPanel.<Break>d__36))]
	// RVA: 0x1C67CF4 Offset: 0x1C63CF4 VA: 0x1C67CF4
	private IEnumerator Break() { }

	// RVA: 0x1C67D88 Offset: 0x1C63D88 VA: 0x1C67D88
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C67E94 Offset: 0x1C63E94 VA: 0x1C67E94
	private void <Break>b__36_1() { }
}
