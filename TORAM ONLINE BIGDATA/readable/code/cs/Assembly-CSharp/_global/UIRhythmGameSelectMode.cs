// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameSelectMode : MonoBehaviour // TypeDefIndex: 6222
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	[SerializeField]
	private UIImageButton soloButton; // 0x28
	[SerializeField]
	private UIImageButton multiButton; // 0x30
	[SerializeField]
	private GameObject mainPanel; // 0x38
	[SerializeField]
	private GameObject howToPanel; // 0x40
	[SerializeField]
	private GameObject timingEffectObj; // 0x48
	[SerializeField]
	private GameObject timingIconObj; // 0x50
	[SerializeField]
	private UISprite flickArrowObj; // 0x58
	[SerializeField]
	private GameObject mainTitleObj; // 0x60
	[SerializeField]
	private GameObject optionTitleObj; // 0x68
	[SerializeField]
	private GameObject howToButton; // 0x70
	[SerializeField]
	private GameObject optionPanel; // 0x78
	[SerializeField]
	private GameObject bgmPlayButtonIcon; // 0x80
	[SerializeField]
	private UILabel bgmPlayButtonLabel; // 0x88
	[SerializeField]
	private UILabel[] bgmVolumeLabes; // 0x90
	[SerializeField]
	private GameObject[] bgmVolumeButtons; // 0x98
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0xA0
	private UIRhythmGameSelectMode.PanelState panelState; // 0xA4
	private SystemTextManager systemTextManager; // 0xA8
	private bool isMulti; // 0xB0
	private bool isBgmPlay; // 0xB1
	private byte bgmVolume; // 0xB2

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18BC8E8 Offset: 0x18B88E8 VA: 0x18BC8E8
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x18BC8F0 Offset: 0x18B88F0 VA: 0x18BC8F0
	private void set_IsOpen(bool value) { }

	// RVA: 0x18BC8FC Offset: 0x18B88FC VA: 0x18BC8FC
	public void OpenWindow() { }

	// RVA: 0x18BCC08 Offset: 0x18B8C08 VA: 0x18BCC08
	public void Return() { }

	// RVA: 0x18BCCE0 Offset: 0x18B8CE0 VA: 0x18BCCE0
	private void Awake() { }

	// RVA: 0x18BCDCC Offset: 0x18B8DCC VA: 0x18BCDCC
	private void OnHowTo() { }

	// RVA: 0x18BCE68 Offset: 0x18B8E68 VA: 0x18BCE68
	private void onClick(int param) { }

	// RVA: 0x18BCFC4 Offset: 0x18B8FC4 VA: 0x18BCFC4
	private void OnOptionBgmPlay() { }

	// RVA: 0x18BD194 Offset: 0x18B9194 VA: 0x18BD194
	private void OnOptionBgmVolume(int param) { }

	// RVA: 0x18BD328 Offset: 0x18B9328 VA: 0x18BD328
	private void OnStart() { }

	// RVA: 0x18BD080 Offset: 0x18B9080 VA: 0x18BD080
	private void UpdateOptionBgmPlay() { }

	// RVA: 0x18BD278 Offset: 0x18B9278 VA: 0x18BD278
	private void UpdateOptionBgmVolume() { }

	// RVA: 0x18BCADC Offset: 0x18B8ADC VA: 0x18BCADC
	private void ChangePanel(UIRhythmGameSelectMode.PanelState panelState) { }

	[IteratorStateMachine(typeof(UIRhythmGameSelectMode.<HowToTiming>d__38))]
	// RVA: 0x18BD3CC Offset: 0x18B93CC VA: 0x18BD3CC
	private IEnumerator HowToTiming() { }

	[IteratorStateMachine(typeof(UIRhythmGameSelectMode.<HowToFlick>d__39))]
	// RVA: 0x18BD438 Offset: 0x18B9438 VA: 0x18BD438
	private IEnumerator HowToFlick() { }

	[IteratorStateMachine(typeof(UIRhythmGameSelectMode.<EnterWait>d__40))]
	// RVA: 0x18BCF58 Offset: 0x18B8F58 VA: 0x18BCF58
	private IEnumerator EnterWait() { }

	// RVA: 0x18BD51C Offset: 0x18B951C VA: 0x18BD51C
	public void .ctor() { }
}
