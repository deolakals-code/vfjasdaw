// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbMenuManager : UIBaseMenuPanel // TypeDefIndex: 7615
{
	// Fields
	private OrbManager orbManager; // 0x80
	[SerializeField]
	private GameObject bufferIcon; // 0x88
	private Dictionary<int, UIOrbMenuManager.IconObject> orbBuffer; // 0x90
	private ItemTextManager itemTextManager; // 0x98
	private ItemPropertyTextManager itemPropertyTextManager; // 0xA0
	[SerializeField]
	private GameObject scrollWindowObject; // 0xA8
	[SerializeField]
	private GameObject newLabelObject; // 0xB0
	[SerializeField]
	private GameObject newShopLabelObject; // 0xB8
	[SerializeField]
	private GameObject newBonusLabelObject; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8

	// Methods

	// RVA: 0x1BBEE8C Offset: 0x1BBAE8C VA: 0x1BBEE8C
	private void Awake() { }

	// RVA: 0x1BBF514 Offset: 0x1BBB514 VA: 0x1BBF514 Slot: 7
	protected override void Start() { }

	// RVA: 0x1BBF560 Offset: 0x1BBB560 VA: 0x1BBF560 Slot: 8
	protected override void LoadScrollWindos() { }

	// RVA: 0x1BBF5C0 Offset: 0x1BBB5C0 VA: 0x1BBF5C0 Slot: 10
	protected override GameObject SetButton(string text, float y, int id, UIBaseMenuPanel.SystemLockType lockFlag) { }

	// RVA: 0x1BBFB54 Offset: 0x1BBBB54 VA: 0x1BBFB54
	private void Update() { }

	// RVA: 0x1BC0500 Offset: 0x1BBC500 VA: 0x1BC0500
	private UIOrbMenuManager.IconObject CreateIconObject(string name, int itemId, Vector3 pos) { }

	// RVA: 0x1BC0DF8 Offset: 0x1BBCDF8 VA: 0x1BC0DF8 Slot: 11
	protected override void OnClickButton(int id) { }

	// RVA: 0x1BC1140 Offset: 0x1BBD140 VA: 0x1BC1140
	public void .ctor() { }
}
