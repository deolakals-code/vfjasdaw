// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarItemPlate : MonoBehaviour // TypeDefIndex: 8285
{
	// Fields
	private int id; // 0x20
	private Action<int> callback; // 0x28
	[SerializeField]
	private GameObject editButton; // 0x30
	[SerializeField]
	private GameObject registerButton; // 0x38
	[SerializeField]
	private GameObject itemData; // 0x40
	[SerializeField]
	private ItemIcon itemIcon; // 0x48
	[SerializeField]
	private UIIcon[] crystaIcon; // 0x50
	[SerializeField]
	private UISprite[] itemColor; // 0x58
	[SerializeField]
	private UILabel stockNumLabel; // 0x60
	[SerializeField]
	private UILabel priceLabel; // 0x68
	[SerializeField]
	private GameObject soldOutLabel; // 0x70

	// Properties
	public int ID { get; }

	// Methods

	// RVA: 0x1D12D1C Offset: 0x1D0ED1C VA: 0x1D12D1C
	public int get_ID() { }

	// RVA: 0x1D12D24 Offset: 0x1D0ED24 VA: 0x1D12D24
	private void Init() { }

	// RVA: 0x1D12E98 Offset: 0x1D0EE98 VA: 0x1D12E98
	public void Initialize(int id, BazaarItemData data, Action<int> callback) { }

	// RVA: 0x1D13500 Offset: 0x1D0F500 VA: 0x1D13500
	public void Initialize(BazaarItemData data) { }

	// RVA: 0x1D13A38 Offset: 0x1D0FA38 VA: 0x1D13A38
	private bool IsStackItem(int itemId) { }

	// RVA: 0x1D13AA4 Offset: 0x1D0FAA4 VA: 0x1D13AA4
	public void OnEdit() { }

	// RVA: 0x1D13AC4 Offset: 0x1D0FAC4 VA: 0x1D13AC4
	public void .ctor() { }
}
