// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILoadingBar : MonoBehaviour // TypeDefIndex: 6541
{
	// Fields
	private GameObject[] mobObj; // 0x20
	private float radian; // 0x28
	private GameObject charaObj; // 0x30
	[SerializeField]
	private Transform mobParent; // 0x38
	[SerializeField]
	private GameObject[] BarObject; // 0x40
	[SerializeField]
	private UIScrollBar downloadScrollBar; // 0x48
	[SerializeField]
	private UIScrollBar scrollBar; // 0x50
	[SerializeField]
	private UILabel loadingLabel; // 0x58
	[SerializeField]
	private UITips Tips; // 0x60
	[CompilerGenerated]
	private bool <IsFakeAdvance>k__BackingField; // 0x68
	private int stepMax; // 0x6C
	private int stepCount; // 0x70
	private ResourceManager resource; // 0x78
	private UIPanel controlPanel; // 0x80
	private readonly float horizontalOffset; // 0x88
	private bool isLastDownload; // 0x8C
	private SystemTextManager systemTextManager; // 0x90
	public bool IsAppDownload; // 0x98

	// Properties
	public bool IsActive { get; }
	public float PanelAlpha { get; }
	public float Rate { get; }
	public int Step { get; }
	public bool IsFakeAdvance { get; set; }
	public bool IsShowCharacter { get; }

	// Methods

	// RVA: 0x19717CC Offset: 0x196D7CC VA: 0x19717CC
	public bool get_IsActive() { }

	// RVA: 0x19717EC Offset: 0x196D7EC VA: 0x19717EC
	public float get_PanelAlpha() { }

	// RVA: 0x1971808 Offset: 0x196D808 VA: 0x1971808
	public float get_Rate() { }

	// RVA: 0x1971824 Offset: 0x196D824 VA: 0x1971824
	public int get_Step() { }

	[CompilerGenerated]
	// RVA: 0x197182C Offset: 0x196D82C VA: 0x197182C
	public bool get_IsFakeAdvance() { }

	[CompilerGenerated]
	// RVA: 0x1971834 Offset: 0x196D834 VA: 0x1971834
	public void set_IsFakeAdvance(bool value) { }

	// RVA: 0x1971840 Offset: 0x196D840 VA: 0x1971840
	public bool get_IsShowCharacter() { }

	// RVA: 0x19718D4 Offset: 0x196D8D4 VA: 0x19718D4
	private void Awake() { }

	// RVA: 0x1971B48 Offset: 0x196DB48 VA: 0x1971B48
	private void Start() { }

	// RVA: 0x1972284 Offset: 0x196E284 VA: 0x1972284
	private void Update() { }

	// RVA: 0x1971B6C Offset: 0x196DB6C VA: 0x1971B6C
	private void initialize() { }

	// RVA: 0x1972AC8 Offset: 0x196EAC8 VA: 0x1972AC8
	private void resetBar() { }

	// RVA: 0x1972B14 Offset: 0x196EB14 VA: 0x1972B14
	public void Reset() { }

	// RVA: 0x197207C Offset: 0x196E07C VA: 0x197207C
	public void SetActive(bool isActive) { }

	// RVA: 0x1972C98 Offset: 0x196EC98 VA: 0x1972C98
	public void SetShowBar(bool isShow) { }

	// RVA: 0x1972D00 Offset: 0x196ED00 VA: 0x1972D00
	public void SetRate(int rate) { }

	// RVA: 0x19724B0 Offset: 0x196E4B0 VA: 0x19724B0
	public void SetRate(float rate) { }

	// RVA: 0x1972D14 Offset: 0x196ED14 VA: 0x1972D14
	public void SetStepMax(int stepMax) { }

	// RVA: 0x1972D78 Offset: 0x196ED78 VA: 0x1972D78
	public void SetStep(int step) { }

	// RVA: 0x1972DF4 Offset: 0x196EDF4 VA: 0x1972DF4
	public void NextStep() { }

	// RVA: 0x1972E04 Offset: 0x196EE04 VA: 0x1972E04
	public void ResetStep() { }

	// RVA: 0x1972D80 Offset: 0x196ED80 VA: 0x1972D80
	private void updateStep() { }

	// RVA: 0x1971CD8 Offset: 0x196DCD8 VA: 0x1971CD8
	private void loadResource() { }

	// RVA: 0x1968F8C Offset: 0x1964F8C VA: 0x1968F8C
	public void SetShowCharacter(bool isShow) { }

	// RVA: 0x1972B34 Offset: 0x196EB34 VA: 0x1972B34
	public void SetShowMob(bool isShow) { }

	// RVA: 0x1972E8C Offset: 0x196EE8C VA: 0x1972E8C
	public void SetShowBackground(bool isShow) { }

	[IteratorStateMachine(typeof(UILoadingBar.<checkShow>d__50))]
	// RVA: 0x1972E0C Offset: 0x196EE0C VA: 0x1972E0C
	private IEnumerator checkShow(bool isShow) { }

	[IteratorStateMachine(typeof(UILoadingBar.<alphaControl>d__51))]
	// RVA: 0x1972F7C Offset: 0x196EF7C VA: 0x1972F7C
	private IEnumerator alphaControl(float from, float to, float time) { }

	// RVA: 0x197282C Offset: 0x196E82C VA: 0x197282C
	private void showMob() { }

	// RVA: 0x19724E0 Offset: 0x196E4E0 VA: 0x19724E0
	private void addShowHorizontalMob() { }

	[IteratorStateMachine(typeof(UILoadingBar.<moveHorizontalTo>d__54))]
	// RVA: 0x1973034 Offset: 0x196F034 VA: 0x1973034
	private IEnumerator moveHorizontalTo(GameObject go, float ep) { }

	// RVA: 0x19730D8 Offset: 0x196F0D8 VA: 0x19730D8
	public void InitializeTips() { }

	// RVA: 0x197315C Offset: 0x196F15C VA: 0x197315C
	public void ShowTips(bool isShow) { }

	// RVA: 0x1973204 Offset: 0x196F204 VA: 0x1973204
	public void ShowTips(bool isShow, int tipsNo) { }

	// RVA: 0x196F3C4 Offset: 0x196B3C4 VA: 0x196F3C4
	public static GameObject GetLoadingModel(Transform parent) { }

	// RVA: 0x19732B8 Offset: 0x196F2B8 VA: 0x19732B8
	public static GameObject GetLoadingModel(Transform parent, bool missTap) { }

	// RVA: 0x1973360 Offset: 0x196F360 VA: 0x1973360
	public void .ctor() { }
}
