// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPlayerStatus : MonoBehaviour, IUIEventSceceIconResponse // TypeDefIndex: 6556
{
	// Fields
	private readonly float newsScalingTime; // 0x20
	private PlayerDataManager playerDataManager; // 0x28
	[SerializeField]
	private Vector3 fadeInMove; // 0x30
	[SerializeField]
	private GameObject playerNameObject; // 0x40
	[SerializeField]
	private UILabel playerNameLabel; // 0x48
	[SerializeField]
	private UILabel playerLevelLabel; // 0x50
	private int level; // 0x58
	private TweenAlpha[] playerNameTweeAlpha; // 0x60
	[SerializeField]
	private UISprite background; // 0x68
	[SerializeField]
	private Transform rightEndPosition; // 0x70
	[SerializeField]
	private GameObject newsBaseIcon; // 0x78
	[SerializeField]
	private Transform newsParent; // 0x80
	[SerializeField]
	private GameObject lifeGauge; // 0x88
	private UIPlayerLifeGauge playerLifeGauge; // 0x90
	[SerializeField]
	private GameObject autoItemObject; // 0x98
	private UIIcon autoItemIcon; // 0xA0
	private TweenAlpha[] autoItemObjectTweeAlpha; // 0xA8
	[SerializeField]
	private GameObject autoItemIconObject; // 0xB0
	[SerializeField]
	private UILabel autoItemLabel; // 0xB8
	[SerializeField]
	private NguiDynamicFont dynamicFont; // 0xC0
	[SerializeField]
	private Camera viewCamera; // 0xC8
	private float dynamicFontCheckTimer; // 0xD0
	private int fontLayerId; // 0xD4
	private UIIruna2Anchor anchor; // 0xD8
	private UIPlayTween tween; // 0xE0
	private Dictionary<UIPlayerStatus.NewsFlag, GameObject> newsListS; // 0xE8
	private Dictionary<UIPlayerStatus.NewsFlag, float> newsTimeList; // 0xF0
	private int checkAutoItemId; // 0xF8
	private bool hasWarrantyItem; // 0xFC
	private List<UIEventSceneIcon> iconList; // 0x100
	private UIPlayerStatus.NewIconData[] iconDataList; // 0x108
	private bool isRender; // 0x110
	private Material iconMaterial; // 0x118
	private GameObject baseScriptIcon; // 0x120

	// Properties
	private UIIruna2Anchor Anchor { get; }

	// Methods

	// RVA: 0x197CD70 Offset: 0x1978D70 VA: 0x197CD70
	private UIIruna2Anchor get_Anchor() { }

	// RVA: 0x197CE28 Offset: 0x1978E28 VA: 0x197CE28
	private void Start() { }

	// RVA: 0x197D82C Offset: 0x197982C VA: 0x197D82C
	private void Update() { }

	// RVA: 0x197DA34 Offset: 0x1979A34 VA: 0x197DA34
	private void SetLevelName(string name, int level) { }

	// RVA: 0x197E54C Offset: 0x197A54C VA: 0x197E54C
	public void Fade(bool flag) { }

	// RVA: 0x197E634 Offset: 0x197A634 VA: 0x197E634
	private void OnClick() { }

	// RVA: 0x197E7C0 Offset: 0x197A7C0 VA: 0x197E7C0
	private void onAutoItem() { }

	// RVA: 0x197CF98 Offset: 0x1978F98 VA: 0x197CF98
	private void Initialize() { }

	// RVA: 0x197E490 Offset: 0x197A490 VA: 0x197E490
	private void UpdateIcon() { }

	// RVA: 0x197E110 Offset: 0x197A110 VA: 0x197E110
	private bool NewsCheck(UIPlayerStatus.NewsFlag flag, string spriteName, bool check) { }

	// RVA: 0x197EC40 Offset: 0x197AC40 VA: 0x197EC40
	private bool ItemMaxNewsCheck() { }

	// RVA: 0x197ED94 Offset: 0x197AD94 VA: 0x197ED94
	public void AddScriptIcon(int uuid, int iconType, int iconid, string title, string message) { }

	// RVA: 0x197EFEC Offset: 0x197AFEC VA: 0x197EFEC
	public void RemoveScriptIcon(int uuid) { }

	// RVA: 0x197F3F8 Offset: 0x197B3F8 VA: 0x197F3F8
	public void ClearScriptIcon() { }

	// RVA: 0x197F19C Offset: 0x197B19C VA: 0x197F19C
	private void UpdateScriptIcon() { }

	// RVA: 0x197F5F0 Offset: 0x197B5F0 VA: 0x197F5F0 Slot: 4
	public void OnOpenEventScenePopUp(int uid) { }

	// RVA: 0x197F864 Offset: 0x197B864 VA: 0x197F864
	public void OnRenderObject() { }

	// RVA: 0x197FBF0 Offset: 0x197BBF0 VA: 0x197FBF0
	public void .ctor() { }
}
