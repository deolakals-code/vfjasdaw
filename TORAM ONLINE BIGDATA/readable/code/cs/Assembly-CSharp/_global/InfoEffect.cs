// Assembly: Assembly-CSharp.dll
// Namespace: 
public class InfoEffect : MonoBehaviour // TypeDefIndex: 4822
{
	// Fields
	[SerializeField]
	private UILabel infoText; // 0x20
	private TweenScale infoTextTweenScale; // 0x28
	[SerializeField]
	private UISprite infoIcon; // 0x30
	[SerializeField]
	private GameObject[] infoEffect; // 0x38
	private List<UITweener> infoEffectTween; // 0x40
	private bool effectPlay; // 0x48
	private bool isActive; // 0x49
	private bool changeFlag; // 0x4A
	private string changeText; // 0x50
	private string changeIcon; // 0x58
	private float timer; // 0x60
	private UIIruna2AnchorSimple anchorSimple; // 0x68
	private InactiveTimer inactiveTimer; // 0x70
	[SerializeField]
	private Vector3 effectScale; // 0x78
	private int modelId; // 0x84
	private int motionId; // 0x88
	private GameObject effectModel; // 0x90

	// Properties
	public bool IsActive { get; set; }

	// Methods

	// RVA: 0x25E2078 Offset: 0x25DE078 VA: 0x25E2078
	private void Start() { }

	// RVA: 0x25E18C4 Offset: 0x25DD8C4 VA: 0x25E18C4
	public void set_IsActive(bool value) { }

	// RVA: 0x25E2324 Offset: 0x25DE324 VA: 0x25E2324
	public bool get_IsActive() { }

	// RVA: 0x25E1640 Offset: 0x25DD640 VA: 0x25E1640
	public void SetInfo(string text, string iconName) { }

	// RVA: 0x25E232C Offset: 0x25DE32C VA: 0x25E232C
	private void ChangeInfo() { }

	// RVA: 0x25E23EC Offset: 0x25DE3EC VA: 0x25E23EC
	private void EffectPlay() { }

	// RVA: 0x25E2790 Offset: 0x25DE790 VA: 0x25E2790
	private void Update() { }

	// RVA: 0x25E2198 Offset: 0x25DE198 VA: 0x25E2198
	public void LoadEffect(int effectId) { }

	[IteratorStateMachine(typeof(InfoEffect.<LoadModel>d__26))]
	// RVA: 0x25E2988 Offset: 0x25DE988 VA: 0x25E2988
	private IEnumerator LoadModel(string assetPath, string filePath) { }

	// RVA: 0x25E2A4C Offset: 0x25DEA4C VA: 0x25E2A4C
	private void SetModel(GameObject modelObject) { }

	// RVA: 0x25E2FF4 Offset: 0x25DEFF4 VA: 0x25E2FF4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x25E30F8 Offset: 0x25DF0F8 VA: 0x25E30F8
	private void <LoadEffect>b__25_0(bool s, GameObject x) { }
}
