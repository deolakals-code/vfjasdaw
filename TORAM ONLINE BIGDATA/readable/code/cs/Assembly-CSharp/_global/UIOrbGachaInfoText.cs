// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbGachaInfoText : MonoBehaviour // TypeDefIndex: 7572
{
	// Fields
	[SerializeField]
	private GameObject itemNameObject; // 0x20
	private UILabel itemNameLabel; // 0x28
	[SerializeField]
	private GameObject rareObject; // 0x30
	[SerializeField]
	private UILabel buttonTextLabel; // 0x38
	[SerializeField]
	private UILabel buttonSubTextLabel; // 0x40
	[SerializeField]
	private GameObject buttonObject; // 0x48
	[SerializeField]
	private GameObject backPanel; // 0x50
	private List<GameObject> rareList; // 0x58
	private int itemId; // 0x60
	private UIOrbShopBuyPanel parentPanel; // 0x68
	private bool initUpdate; // 0x70
	private float areaSize; // 0x74

	// Methods

	// RVA: 0x1BB296C Offset: 0x1BAE96C VA: 0x1BB296C
	public void Initialize(int itemId, string buttonLabel, string itemName, int rare, string reteText, float rate, UIOrbShopBuyPanel panel, float areaSize = 580) { }

	// RVA: 0x1BB2AD4 Offset: 0x1BAEAD4 VA: 0x1BB2AD4
	public void Initialize(int itemId, string buttonLabel, string itemName, int rare, UIOrbShopBuyPanel panel) { }

	// RVA: 0x1BB2FC0 Offset: 0x1BAEFC0 VA: 0x1BB2FC0
	public void Initialize(byte rare, string rateText) { }

	// RVA: 0x1BB3288 Offset: 0x1BAF288 VA: 0x1BB3288
	public void OpenBackPanel(int num) { }

	// RVA: 0x1BB2D98 Offset: 0x1BAED98 VA: 0x1BB2D98
	private void AddStar(string spriteName, float scale, Vector3 pos) { }

	// RVA: 0x1BB3334 Offset: 0x1BAF334 VA: 0x1BB3334
	public void OnClickButton() { }

	// RVA: 0x1BB3364 Offset: 0x1BAF364 VA: 0x1BB3364
	private void Update() { }

	// RVA: 0x1BB375C Offset: 0x1BAF75C VA: 0x1BB375C
	public void .ctor() { }
}
