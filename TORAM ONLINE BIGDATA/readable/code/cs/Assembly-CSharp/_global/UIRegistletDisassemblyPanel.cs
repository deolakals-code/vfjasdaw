// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletDisassemblyPanel : MonoBehaviour, UIRegistletBasePanel // TypeDefIndex: 7903
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	[SerializeField]
	private UIRegistletElement registletElement; // 0x28
	[SerializeField]
	private GameObject itemObj; // 0x30
	[SerializeField]
	private GameObject checkPanel; // 0x38
	[SerializeField]
	private GameObject delayPanel; // 0x40
	[SerializeField]
	private GameObject resultPanel; // 0x48
	[SerializeField]
	private UIImageButton imageButton; // 0x50
	[SerializeField]
	private UILabel buttonLabel; // 0x58
	[SerializeField]
	private UISlider delaySlider; // 0x60
	private UIRegistletMainManager manager; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private RegistletTextManager registletTextManager; // 0x78
	private PlayerDataManager playerDataManager; // 0x80
	private GemCartData selectedGemCartData; // 0x88
	private UIRegistletElement itemElement; // 0x90
	private UISprite buttonBase; // 0x98
	private BoxCollider buttonCol; // 0xA0

	// Methods

	// RVA: 0x1C5EDC4 Offset: 0x1C5ADC4 VA: 0x1C5EDC4 Slot: 4
	public void Initialize(UIRegistletMainManager manager, SystemTextManager systemTextManager, RegistletTextManager registletTextManager) { }

	// RVA: 0x1C5EF0C Offset: 0x1C5AF0C VA: 0x1C5EF0C Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C5F3F4 Offset: 0x1C5B3F4 VA: 0x1C5F3F4 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C5F418 Offset: 0x1C5B418 VA: 0x1C5F418 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C5F420 Offset: 0x1C5B420 VA: 0x1C5F420 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C5F494 Offset: 0x1C5B494 VA: 0x1C5F494 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C5E490 Offset: 0x1C5A490 VA: 0x1C5E490
	public void SetSelectedGemCart(GemCartData data) { }

	// RVA: 0x1C5EF4C Offset: 0x1C5AF4C VA: 0x1C5EF4C
	private void ChangePanel(UIRegistletDisassemblyPanel.PanelState state) { }

	[IteratorStateMachine(typeof(UIRegistletDisassemblyPanel.<DelaySliderToResult>d__26))]
	// RVA: 0x1C5F5A4 Offset: 0x1C5B5A4 VA: 0x1C5F5A4
	private IEnumerator DelaySliderToResult() { }

	[IteratorStateMachine(typeof(UIRegistletDisassemblyPanel.<StarGemBreak>d__27))]
	// RVA: 0x1C5F638 Offset: 0x1C5B638 VA: 0x1C5F638
	private IEnumerator StarGemBreak() { }

	// RVA: 0x1C5F6CC Offset: 0x1C5B6CC VA: 0x1C5F6CC
	public void OnWindowButton() { }

	// RVA: 0x1C5F780 Offset: 0x1C5B780 VA: 0x1C5F780
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C5F788 Offset: 0x1C5B788 VA: 0x1C5F788
	private void <StarGemBreak>b__27_0() { }
}
