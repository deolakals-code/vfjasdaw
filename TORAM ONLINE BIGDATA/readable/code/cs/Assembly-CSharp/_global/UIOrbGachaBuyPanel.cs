// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbGachaBuyPanel : MonoBehaviour // TypeDefIndex: 7571
{
	// Fields
	[SerializeField]
	private Transform mainPanel; // 0x20
	[SerializeField]
	private Transform orbMainIcon; // 0x28
	[SerializeField]
	private UISprite orbMainIconSprite; // 0x30
	[SerializeField]
	private UILabel orbMainText; // 0x38
	[SerializeField]
	private GameObject orbMainWarringText; // 0x40
	private UILabel orbMainWarringTextLabel; // 0x48
	[SerializeField]
	private TweenAlpha tweenAlphaButton; // 0x50
	[SerializeField]
	private TweenColor tweenColorButton; // 0x58
	[SerializeField]
	private GameObject orbMainButton; // 0x60
	[SerializeField]
	private UILabel buttonText; // 0x68
	[SerializeField]
	private GameObject buttonBleuObj; // 0x70
	[SerializeField]
	private BoxCollider boxCollider; // 0x78
	[SerializeField]
	private GameObject rightButton; // 0x80
	private UILabel rightButtonLabel; // 0x88
	[SerializeField]
	private GameObject leftButton; // 0x90
	private UILabel leftButtonLabel; // 0x98
	[SerializeField]
	private GameObject stackButton; // 0xA0
	[SerializeField]
	private Transform freeMainPanel; // 0xA8
	[SerializeField]
	private TweenAlpha tweenAlphaFreeButton; // 0xB0
	[SerializeField]
	private TweenColor tweenColorFreeButton; // 0xB8
	[SerializeField]
	private Transform subPanel; // 0xC0
	[SerializeField]
	private Transform orbSubIcon; // 0xC8
	[SerializeField]
	private UISprite orbSubIconSprite; // 0xD0
	[SerializeField]
	private UILabel orbSubText; // 0xD8
	[SerializeField]
	private GameObject orbSubButton; // 0xE0
	[SerializeField]
	private GameObject orbSubWarringText; // 0xE8
	private UILabel orbSubWarringTextLabel; // 0xF0
	private UIOrbShopBuyPanel parentPanel; // 0xF8
	private Dictionary<int, OrbShopManager.GachaProductData.GachaData> gachaDataList; // 0x100
	private OrbShopManager.GachaProductData gachaProductData; // 0x108
	private List<int> gachaTicketIdList; // 0x110
	private int selectId; // 0x118
	private bool buyCheck; // 0x11C
	private bool buyLock; // 0x11D
	private bool isSelectLcok; // 0x11E
	private bool ticketBuy; // 0x11F
	private bool isPaidOrbOnly; // 0x120
	private int selectPrice; // 0x124
	private float moveTimerLock; // 0x128
	private List<GameObject> selectButton; // 0x130
	private SystemTextManager systemManager; // 0x138

	// Properties
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1BB04F4 Offset: 0x1BAC4F4 VA: 0x1BB04F4
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1BB05E4 Offset: 0x1BAC5E4 VA: 0x1BB05E4
	private void Awake() { }

	// RVA: 0x1BB0668 Offset: 0x1BAC668 VA: 0x1BB0668
	public void Initialize(bool isPaidOrb, UIOrbShopBuyPanel panel, OrbShopManager.GachaProductData gachaProductData) { }

	// RVA: 0x1BB1E28 Offset: 0x1BADE28 VA: 0x1BB1E28
	private UIOrbGachaButtonText CreateButton(Vector3 position, int id, OrbShopManager.GachaProductData.GachaData gachaData) { }

	// RVA: 0x1BB2214 Offset: 0x1BAE214 VA: 0x1BB2214
	public void AddButton(int add) { }

	// RVA: 0x1BB22AC Offset: 0x1BAE2AC VA: 0x1BB22AC
	public void SetSelectButton(int selectedId) { }

	// RVA: 0x1BB11E0 Offset: 0x1BAD1E0 VA: 0x1BB11E0
	private void SetButton(int selectedId) { }

	// RVA: 0x1BB24F0 Offset: 0x1BAE4F0 VA: 0x1BB24F0
	private void Update() { }

	// RVA: 0x1BB2580 Offset: 0x1BAE580 VA: 0x1BB2580
	public void OnUIClickBuyButton() { }

	// RVA: 0x1BB2660 Offset: 0x1BAE660 VA: 0x1BB2660
	public void OnClickBuyButton() { }

	// RVA: 0x1BB2830 Offset: 0x1BAE830 VA: 0x1BB2830
	public void .ctor() { }
}
