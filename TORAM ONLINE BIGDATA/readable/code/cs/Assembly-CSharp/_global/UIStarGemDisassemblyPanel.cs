// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemDisassemblyPanel : MonoBehaviour, UIStarGemBasePanel // TypeDefIndex: 8009
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	[SerializeField]
	private GameObject starGemObj; // 0x28
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
	private UIStarGemMainManager manager; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private SkillTextManager skillTextManager; // 0x78
	private PlayerDataManager playerDataManager; // 0x80
	private UIIruna2Anchor anchor; // 0x88
	private UILabel[] starGemLabels; // 0x90
	private UIIcon starGemSkillIcon; // 0x98
	private UILabel[] disItemLabels; // 0xA0
	private StarGemData selectedStarGemData; // 0xA8
	private const int baseMagicPoint = 300;
	private const int getStarGemShard = 50;
	private UISprite buttonBase; // 0xB0
	private BoxCollider buttonCol; // 0xB8
	private byte eventFlag; // 0xC0

	// Properties
	private bool isCanStarGem { get; }
	private bool isCanMagic { get; }
	private bool isCanDo { get; }

	// Methods

	// RVA: 0x1C97940 Offset: 0x1C93940 VA: 0x1C97940
	private bool get_isCanStarGem() { }

	// RVA: 0x1C979B0 Offset: 0x1C939B0 VA: 0x1C979B0
	private bool get_isCanMagic() { }

	// RVA: 0x1C979F4 Offset: 0x1C939F4 VA: 0x1C979F4
	private bool get_isCanDo() { }

	// RVA: 0x1C97A1C Offset: 0x1C93A1C VA: 0x1C97A1C Slot: 4
	public void Initialize(UIStarGemMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1C97CAC Offset: 0x1C93CAC VA: 0x1C97CAC Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C983DC Offset: 0x1C943DC VA: 0x1C983DC Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C98468 Offset: 0x1C94468 VA: 0x1C98468 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C984DC Offset: 0x1C944DC VA: 0x1C984DC Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C984E4 Offset: 0x1C944E4 VA: 0x1C984E4 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C92AEC Offset: 0x1C8EAEC VA: 0x1C92AEC
	public void SetSelectedStarGem(StarGemData data) { }

	// RVA: 0x1C984EC Offset: 0x1C944EC VA: 0x1C984EC
	private void OnWindowButton() { }

	// RVA: 0x1C97DB4 Offset: 0x1C93DB4 VA: 0x1C97DB4
	private void ChangePanel(UIStarGemDisassemblyPanel.PanelState state) { }

	// RVA: 0x1C9860C Offset: 0x1C9460C VA: 0x1C9860C
	private void ChangeDelayPanel() { }

	[IteratorStateMachine(typeof(UIStarGemDisassemblyPanel.<DelaySliderToResult>d__40))]
	// RVA: 0x1C985A0 Offset: 0x1C945A0 VA: 0x1C985A0
	private IEnumerator DelaySliderToResult() { }

	[IteratorStateMachine(typeof(UIStarGemDisassemblyPanel.<StarGemBreak>d__41))]
	// RVA: 0x1C9863C Offset: 0x1C9463C VA: 0x1C9863C
	private IEnumerator StarGemBreak() { }

	[IteratorStateMachine(typeof(UIStarGemDisassemblyPanel.<FadeOutCoroutine>d__42))]
	// RVA: 0x1C983FC Offset: 0x1C943FC VA: 0x1C983FC
	private IEnumerator FadeOutCoroutine() { }

	// RVA: 0x1C986F8 Offset: 0x1C946F8 VA: 0x1C986F8
	private void ChangeBagPanel() { }

	// RVA: 0x1C98714 Offset: 0x1C94714 VA: 0x1C98714
	public void .ctor() { }
}
