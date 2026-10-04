// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightEquipCristaPanel : MonoBehaviour // TypeDefIndex: 5838
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor equipPanelAnchor; // 0x20
	[SerializeField]
	private GameObject equipElement; // 0x28
	[SerializeField]
	private UIScrollWindow equipScrollWindow; // 0x30
	[SerializeField]
	private UILabel noEquipLabel; // 0x38
	[SerializeField]
	private MeshRenderer fadeMeshRenderer; // 0x40
	[SerializeField]
	private UIIruna2Anchor listPanelAnchor; // 0x48
	[SerializeField]
	private UIBlackKnightEquipListElement listElement; // 0x50
	[SerializeField]
	private UIScrollWindow listScrollWindow; // 0x58
	[SerializeField]
	private UILabel propertyButtonLabel; // 0x60
	[SerializeField]
	private UILabel printButtonLabel; // 0x68
	[SerializeField]
	private UILabel noHaveCristaLabel; // 0x70
	[SerializeField]
	private UIIruna2Anchor propertyPanelAnchor; // 0x78
	[SerializeField]
	private UISprite propIcon; // 0x80
	[SerializeField]
	private UILabel propItemNameLabel; // 0x88
	[SerializeField]
	private UILabel propCostLabel; // 0x90
	[SerializeField]
	private UILabel propPropertyLabel; // 0x98
	private bool isActive; // 0xA0
	private BlackKnightSaveData saveData; // 0xA8
	private long crista; // 0xB0
	private Dictionary<byte, UIBlackKnightEquipListElement> listObjList; // 0xB8
	private bool isCanEquipList; // 0xC0
	private bool isPropEnable; // 0xC1
	private List<byte> equipDataList; // 0xC8
	private byte selectedId; // 0xD0
	private SystemTextManager systemTextManager; // 0xD8
	private const float elementHeight = 80;

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1803CFC Offset: 0x17FFCFC VA: 0x1803CFC
	public bool get_IsActive() { }

	// RVA: 0x1803D04 Offset: 0x17FFD04 VA: 0x1803D04
	private void Update() { }

	// RVA: 0x17FFA14 Offset: 0x17FBA14 VA: 0x17FFA14
	public void Open(BlackKnightSaveData saveData) { }

	// RVA: 0x1800B98 Offset: 0x17FCB98 VA: 0x1800B98
	public bool Close(out byte[] equipData) { }

	// RVA: 0x1804BF4 Offset: 0x1800BF4 VA: 0x1804BF4
	public void OnClick(int param) { }

	// RVA: 0x1804D60 Offset: 0x1800D60 VA: 0x1804D60
	public void OnListElement(int param) { }

	// RVA: 0x18050B8 Offset: 0x18010B8 VA: 0x18050B8
	public void OnListEnableElement(int param) { }

	// RVA: 0x18040E8 Offset: 0x18000E8 VA: 0x18040E8
	private void CreateEquipWindow() { }

	// RVA: 0x18044A4 Offset: 0x18004A4 VA: 0x18044A4
	private void CreateListWindow(byte scrollPosParam) { }

	// RVA: 0x1805404 Offset: 0x1801404 VA: 0x1805404
	private void UpdateListWindow(byte param) { }

	// RVA: 0x1803FFC Offset: 0x17FFFFC VA: 0x1803FFC
	private void UpdateButtonLabel() { }

	// RVA: 0x18052E8 Offset: 0x18012E8 VA: 0x18052E8
	private int UseCost() { }

	// RVA: 0x1803D08 Offset: 0x17FFD08 VA: 0x1803D08
	private void UpdateElementActive() { }

	// RVA: 0x1805DAC Offset: 0x1801DAC VA: 0x1805DAC
	public void .ctor() { }
}
