// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithManufactureCompleteDialog : MonoBehaviour // TypeDefIndex: 8526
{
	// Fields
	[SerializeField]
	private UILabel[] UsedItemLabel; // 0x20
	[SerializeField]
	private ItemIcon ItemNameLabel; // 0x28
	[SerializeField]
	private UILabel ItemNameSubLabel; // 0x30
	[SerializeField]
	private LocalizeText costLabel; // 0x38
	[SerializeField]
	private UISprite rankIcon; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private ItemTextManager itemTextManager; // 0x50
	private PlayerDataManager playerDataManager; // 0x58

	// Methods

	// RVA: 0x1D9B4A8 Offset: 0x1D974A8 VA: 0x1D9B4A8
	private void Awake() { }

	// RVA: 0x1D9B660 Offset: 0x1D97660 VA: 0x1D9B660
	private void Start() { }

	// RVA: 0x1D9B664 Offset: 0x1D97664 VA: 0x1D9B664
	private void Update() { }

	// RVA: 0x1D97AB0 Offset: 0x1D93AB0 VA: 0x1D97AB0
	public void SetUsedItem(int gold, int smithExp, int syntheticExp, bool isGettableExp, Trio<int, int, byte>[] names) { }

	// RVA: 0x1D985C0 Offset: 0x1D945C0 VA: 0x1D985C0
	public void SetItemName(int id) { }

	// RVA: 0x1D9B668 Offset: 0x1D97668 VA: 0x1D9B668
	public void SetItemNameSub(string str, int itemUuid, bool isShop) { }

	// RVA: 0x1D97A24 Offset: 0x1D93A24 VA: 0x1D97A24
	public void SetItemNameSub(int itemUuid, bool isSmith) { }

	// RVA: 0x1D9B788 Offset: 0x1D97788 VA: 0x1D9B788
	private string BuildItemSubStats(int itemUuid, bool isSmith) { }

	// RVA: 0x1D9BDC4 Offset: 0x1D97DC4 VA: 0x1D9BDC4
	public void Close() { }

	// RVA: 0x1D97A00 Offset: 0x1D93A00 VA: 0x1D97A00
	public void Open() { }

	// RVA: 0x1D9BDE8 Offset: 0x1D97DE8 VA: 0x1D9BDE8
	public void .ctor() { }
}
