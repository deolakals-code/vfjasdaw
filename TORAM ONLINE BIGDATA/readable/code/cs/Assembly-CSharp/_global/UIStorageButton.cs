// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStorageButton : MonoBehaviour // TypeDefIndex: 8589
{
	// Fields
	[SerializeField]
	private GameObject manager; // 0x20
	private UIStoragePanelManager mainManager; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private UILabel textLabel; // 0x38
	[SerializeField]
	private UILabel stockLabel; // 0x40
	[SerializeField]
	private UISprite iconSprite; // 0x48
	[SerializeField]
	private GameObject moveUpButtonObj; // 0x50
	private int warehouseId; // 0x58
	private bool lockFlag; // 0x5C
	private bool isSwitch; // 0x5D
	private byte sortId; // 0x5E
	private int capacity; // 0x60
	private SystemTextManager systemTManager; // 0x68

	// Properties
	public int WareHouseId { get; }
	public bool LockFlag { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1DB25CC Offset: 0x1DAE5CC VA: 0x1DB25CC
	public int get_WareHouseId() { }

	// RVA: 0x1DB25D4 Offset: 0x1DAE5D4 VA: 0x1DB25D4
	public bool get_LockFlag() { }

	// RVA: 0x1DB25DC Offset: 0x1DAE5DC VA: 0x1DB25DC
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1DB26C8 Offset: 0x1DAE6C8 VA: 0x1DB26C8
	private void Start() { }

	// RVA: 0x1DB2728 Offset: 0x1DAE728 VA: 0x1DB2728
	public void Initialize(int id, string name, string text, int num, int capacity, byte sortId) { }

	// RVA: 0x1DB28C0 Offset: 0x1DAE8C0 VA: 0x1DB28C0
	public void Lock(int id) { }

	// RVA: 0x1DB2A90 Offset: 0x1DAEA90 VA: 0x1DB2A90
	public void ChangeStockLabelPos(bool isRight) { }

	// RVA: 0x1DB2B0C Offset: 0x1DAEB0C VA: 0x1DB2B0C
	public void UpdateStockLabel(int num) { }

	// RVA: 0x1DB2BE8 Offset: 0x1DAEBE8 VA: 0x1DB2BE8
	public void ChangeSwitchButtonEnable(bool isEnable) { }

	// RVA: 0x1DB2C08 Offset: 0x1DAEC08 VA: 0x1DB2C08
	public void SetSortId(byte sortId) { }

	// RVA: 0x1DB2C10 Offset: 0x1DAEC10 VA: 0x1DB2C10
	private void OnClick() { }

	// RVA: 0x1DB35B4 Offset: 0x1DAF5B4 VA: 0x1DB35B4
	private void OnMoveUp() { }

	// RVA: 0x1DB3A28 Offset: 0x1DAFA28 VA: 0x1DB3A28
	public void .ctor() { }
}
