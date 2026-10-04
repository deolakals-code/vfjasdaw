// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPlayerLifeGauge : MonoBehaviour // TypeDefIndex: 6550
{
	// Fields
	protected UIIruna2Anchor anchor; // 0x20
	private PlayerStatusBase playerStatus; // 0x28
	private bool closeCheck; // 0x30
	private float closeTimer; // 0x34
	private PlayerDataManager playerDataManager; // 0x38
	[CompilerGenerated]
	private bool <IsActiveGauge>k__BackingField; // 0x40
	[SerializeField]
	private GameObject bufferIconObject; // 0x48
	private UIBufferIcon bufferIcon; // 0x50
	private SystemTextManager systemTManager; // 0x58
	[SerializeField]
	public Vector3 AddBaseAnchor; // 0x60
	[SerializeField]
	private UIWidget[] hpGauge; // 0x70
	private float hpPercent; // 0x78
	[SerializeField]
	private UIWidget[] hpDamageGauge; // 0x80
	private float hpDamagePercent; // 0x88
	[SerializeField]
	private UILabel hpGaugeLabel; // 0x90
	[SerializeField]
	private TweenColor hpGaugeTweenColor; // 0x98
	[SerializeField]
	private UIWidget mpGaugeBack; // 0xA0
	[SerializeField]
	private GameObject[] mpBaseGauge; // 0xA8
	private UISprite[] mpGaugeList; // 0xB0
	private TweenColor[] mpGaugeTweenList; // 0xB8
	private UISprite[] mpExGaugeList; // 0xC0
	private TweenColor[] mpExGaugeTweenList; // 0xC8
	private float baseMpBar; // 0xD0
	private float exMpBar; // 0xD4
	private float effectTimer; // 0xD8
	private bool systemLockCheck; // 0xDC

	// Properties
	public bool IsActiveGauge { get; set; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x197B390 Offset: 0x1977390 VA: 0x197B390
	private void set_IsActiveGauge(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197B39C Offset: 0x197739C VA: 0x197B39C
	public bool get_IsActiveGauge() { }

	// RVA: 0x197B3A4 Offset: 0x19773A4 VA: 0x197B3A4
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x197B49C Offset: 0x197749C VA: 0x197B49C Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x197B53C Offset: 0x197753C VA: 0x197B53C
	private void Start() { }

	// RVA: 0x197B934 Offset: 0x1977934 VA: 0x197B934 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x197C550 Offset: 0x1978550 VA: 0x197C550
	public void Fade(bool fadeIn, bool check) { }

	// RVA: 0x197BB08 Offset: 0x1977B08 VA: 0x197BB08
	private bool HpBarUpdate() { }

	// RVA: 0x197B7B4 Offset: 0x19777B4 VA: 0x197B7B4
	private UISprite CreateMpGauge(GameObject baseObject, int i) { }

	// RVA: 0x197C1E0 Offset: 0x19781E0 VA: 0x197C1E0
	private bool MpBarUpdate() { }

	// RVA: 0x197C6E4 Offset: 0x19786E4 VA: 0x197C6E4
	private float MpBarDraw(float mpbar, int mpPoint, int maxMp, UISprite[] gaugeList, TweenColor[] tweenList) { }

	// RVA: 0x197CA7C Offset: 0x1978A7C VA: 0x197CA7C Slot: 6
	protected virtual void FadeInOutAnimation(bool isFadeIn, float time) { }

	// RVA: 0x197CBFC Offset: 0x1978BFC VA: 0x197CBFC
	public void .ctor() { }
}
