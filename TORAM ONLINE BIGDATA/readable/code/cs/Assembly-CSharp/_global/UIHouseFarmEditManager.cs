// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseFarmEditManager : UIBasePanel // TypeDefIndex: 7242
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
	private Vector3 modelPosition; // 0x8C
	private Vector3 chipSize; // 0x98
	private Vector4 chipArea; // 0xA4
	private int[] chipIdList; // 0xB8
	private float h; // 0xC0
	private float selectH; // 0xC4
	private short point; // 0xC8
	private byte bonus; // 0xCA
	private byte itemType; // 0xCB
	private bool cancelCheck; // 0xCC

	// Methods

	// RVA: 0x1AEA188 Offset: 0x1AE6188 VA: 0x1AEA188 Slot: 7
	protected virtual void Start() { }

	// RVA: 0x1AEA2A0 Offset: 0x1AE62A0 VA: 0x1AEA2A0
	private void Initialize() { }

	// RVA: 0x1AEA9B4 Offset: 0x1AE69B4 VA: 0x1AEA9B4
	private void OnDestroy() { }

	// RVA: 0x1AEA9E8 Offset: 0x1AE69E8 VA: 0x1AEA9E8
	private void Clear() { }

	// RVA: 0x1AE3548 Offset: 0x1ADF548 VA: 0x1AE3548
	public void PutItem(int itemId, short point, byte bonus) { }

	// RVA: 0x1AEAADC Offset: 0x1AE6ADC VA: 0x1AEAADC
	private void InitializeItem(bool remove, int itemUid, int itemId) { }

	// RVA: 0x1AEAC70 Offset: 0x1AE6C70 VA: 0x1AEAC70
	private Vector3 TargetPosition() { }

	// RVA: 0x1AEAE30 Offset: 0x1AE6E30 VA: 0x1AEAE30
	private bool CheckCoordinateChip(Vector3 pos) { }

	// RVA: 0x1AEAEA4 Offset: 0x1AE6EA4 VA: 0x1AEAEA4
	private void Update() { }

	[IteratorStateMachine(typeof(UIHouseFarmEditManager.<LoadData>d__32))]
	// RVA: 0x1AEABEC Offset: 0x1AE6BEC VA: 0x1AEABEC
	private IEnumerator LoadData(int itemId, int modelIndex) { }

	// RVA: 0x1AEB18C Offset: 0x1AE718C VA: 0x1AEB18C
	private void EnabledCollider(GameObject model) { }

	// RVA: 0x1AEB264 Offset: 0x1AE7264 VA: 0x1AEB264
	private void OnAction() { }

	[IteratorStateMachine(typeof(UIHouseFarmEditManager.<Connection>d__35))]
	// RVA: 0x1AEB4F4 Offset: 0x1AE74F4 VA: 0x1AEB4F4
	private IEnumerator Connection() { }

	// RVA: 0x1AEB588 Offset: 0x1AE7588 VA: 0x1AEB588 Slot: 8
	protected virtual void OnObjInvisible() { }

	// RVA: 0x1AEB624 Offset: 0x1AE7624 VA: 0x1AEB624 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AEB7D4 Offset: 0x1AE77D4 VA: 0x1AEB7D4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AEB88C Offset: 0x1AE788C VA: 0x1AEB88C
	public void .ctor() { }
}
