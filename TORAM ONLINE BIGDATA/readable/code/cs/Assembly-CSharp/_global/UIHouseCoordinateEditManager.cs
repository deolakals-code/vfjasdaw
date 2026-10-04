// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCoordinateEditManager : UIBasePanel // TypeDefIndex: 7210
{
	// Fields
	[SerializeField]
	private GameObject selectPanelObject; // 0x30
	[SerializeField]
	private GameObject removeButton; // 0x38
	[SerializeField]
	private UIImageButton setImageButton; // 0x40
	[SerializeField]
	private GameObject errPopTextLabel; // 0x48
	private Material selectPanelMaterial; // 0x50
	protected GameObject selectedItem; // 0x58
	private Transform mainCamera; // 0x60
	private int itemUid; // 0x68
	private int itemId; // 0x6C
	private bool initFlag; // 0x70
	private PlayerDataManager playerDataManager; // 0x78
	private HouseManager houseManager; // 0x80
	private int index; // 0x88
	private int rot; // 0x8C
	private Vector3 chipSize; // 0x90
	private Vector4 chipArea; // 0x9C
	private int[] chipIdList; // 0xB0
	private float h; // 0xB8
	private float selectH; // 0xBC
	private bool isChild; // 0xC0
	private bool isParentInfluence; // 0xC1

	// Properties
	protected bool isSetErr { get; }

	// Methods

	// RVA: 0x1AD8B20 Offset: 0x1AD4B20 VA: 0x1AD8B20
	protected bool get_isSetErr() { }

	// RVA: 0x1AD8B3C Offset: 0x1AD4B3C VA: 0x1AD8B3C Slot: 7
	protected virtual void Start() { }

	// RVA: 0x1AD8C3C Offset: 0x1AD4C3C VA: 0x1AD8C3C
	private void Initialize() { }

	// RVA: 0x1AD8F28 Offset: 0x1AD4F28 VA: 0x1AD8F28
	private void OnDestroy() { }

	// RVA: 0x1AD8F5C Offset: 0x1AD4F5C VA: 0x1AD8F5C
	private void Clear() { }

	// RVA: 0x1AD9048 Offset: 0x1AD5048 VA: 0x1AD9048
	public void SelectedItem(int itemUid, int itemId) { }

	// RVA: 0x1AD99A4 Offset: 0x1AD59A4 VA: 0x1AD99A4
	public void PutItem(int itemId) { }

	// RVA: 0x1AD9690 Offset: 0x1AD5690 VA: 0x1AD9690
	private void InitializeItem(bool remove, int itemUid, int itemId) { }

	// RVA: 0x1AD99EC Offset: 0x1AD59EC VA: 0x1AD99EC
	private Vector3 TargetPosition() { }

	// RVA: 0x1AD9B3C Offset: 0x1AD5B3C VA: 0x1AD9B3C
	private bool CheckCoordinateChip(Vector3 pos) { }

	// RVA: 0x1AD9D98 Offset: 0x1AD5D98 VA: 0x1AD9D98 Slot: 8
	protected virtual void Update() { }

	[IteratorStateMachine(typeof(UIHouseCoordinateEditManager.<LoadData>d__33))]
	// RVA: 0x1AD97B4 Offset: 0x1AD57B4 VA: 0x1AD97B4
	private IEnumerator LoadData(int itemId, int modelIndex) { }

	// RVA: 0x1AD9838 Offset: 0x1AD5838 VA: 0x1AD9838
	private void EnabledCollider(GameObject model) { }

	// RVA: 0x1AD9910 Offset: 0x1AD5910 VA: 0x1AD9910
	private void UpdateArea() { }

	// RVA: 0x1ADA0BC Offset: 0x1AD60BC VA: 0x1ADA0BC
	private void OnAction() { }

	// RVA: 0x1ADA3C0 Offset: 0x1AD63C0 VA: 0x1ADA3C0
	private void OnRemove() { }

	[IteratorStateMachine(typeof(UIHouseCoordinateEditManager.<Connection>d__38))]
	// RVA: 0x1ADA354 Offset: 0x1AD6354 VA: 0x1ADA354
	private IEnumerator Connection() { }

	// RVA: 0x1ADA4C4 Offset: 0x1AD64C4 VA: 0x1ADA4C4
	private void OnObjTurn(int turn) { }

	// RVA: 0x1ADA5D4 Offset: 0x1AD65D4 VA: 0x1ADA5D4 Slot: 9
	protected virtual void OnObjInvisible() { }

	// RVA: 0x1ADA670 Offset: 0x1AD6670 VA: 0x1ADA670
	private void ClearEdit() { }

	// RVA: 0x1ADA7D4 Offset: 0x1AD67D4 VA: 0x1ADA7D4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1ADA85C Offset: 0x1AD685C VA: 0x1ADA85C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1ADA930 Offset: 0x1AD6930 VA: 0x1ADA930
	public void .ctor() { }
}
