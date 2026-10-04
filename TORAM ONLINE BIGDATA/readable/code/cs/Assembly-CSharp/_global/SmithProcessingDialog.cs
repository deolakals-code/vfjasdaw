// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithProcessingDialog : MonoBehaviour // TypeDefIndex: 8537
{
	// Fields
	[SerializeField]
	public int ItemId; // 0x20
	[SerializeField]
	private LocalizeText ProcessingCountLabel; // 0x28
	[SerializeField]
	private ItemIcon ItemNameLabel; // 0x30
	[SerializeField]
	private UILabel GetPointLabel; // 0x38
	[SerializeField]
	private LocalizeText GetPointTitleLabel; // 0x40
	[SerializeField]
	private ItemIcon GetMaterialIcon; // 0x48
	[SerializeField]
	private UILabel CostPointLabel; // 0x50
	[SerializeField]
	private UILabel TotalLabel; // 0x58
	[SerializeField]
	private UIImageButton ButtonObj; // 0x60
	[SerializeField]
	private GameObject numberArea; // 0x68
	[SerializeField]
	private GameObject multiOriginal; // 0x70
	[SerializeField]
	private SmithProcessingCompleteDialog CompleteDialog; // 0x78
	[SerializeField]
	private GameObject scrollbar; // 0x80
	[SerializeField]
	private GameObject scrollFrame; // 0x88
	private int LimitCount; // 0x90
	private string Name; // 0x98
	private int OneGetPoint; // 0xA0
	private int ProcessingCount; // 0xA4
	private SystemTextManager systemTextManager; // 0xA8
	private UIBasePanelControl topButtonControl; // 0xB0
	private PlayerDataManager playerDataManager; // 0xB8
	private UIScrollWindow scroll; // 0xC0
	private ItemData[] ItemDatas; // 0xC8
	private bool isMultiSelect; // 0xD0
	private int multiCost; // 0xD4
	private int materialId; // 0xD8
	private int materialLv; // 0xDC
	private UIPopWindow popwindow; // 0xE0
	[CompilerGenerated]
	private bool <IsShop>k__BackingField; // 0xE8

	// Properties
	public bool IsShop { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D9EF38 Offset: 0x1D9AF38 VA: 0x1D9EF38
	public bool get_IsShop() { }

	[CompilerGenerated]
	// RVA: 0x1D9EF40 Offset: 0x1D9AF40 VA: 0x1D9EF40
	public void set_IsShop(bool value) { }

	// RVA: 0x1D9EF4C Offset: 0x1D9AF4C VA: 0x1D9EF4C
	private void Awake() { }

	// RVA: 0x1D9F090 Offset: 0x1D9B090 VA: 0x1D9F090
	private void Start() { }

	// RVA: 0x1D9F094 Offset: 0x1D9B094 VA: 0x1D9F094
	private void Update() { }

	// RVA: 0x1D9F098 Offset: 0x1D9B098 VA: 0x1D9F098
	public void Show(ItemData[] items, ItemTextManager itemTextManager, UIBasePanelControl topControl, bool multi) { }

	// RVA: 0x1D9F384 Offset: 0x1D9B384 VA: 0x1D9F384
	private void showMulti(ItemData[] items, ItemTextManager itemTextManager) { }

	// RVA: 0x1D9E158 Offset: 0x1D9A158 VA: 0x1D9E158
	public void Complete(bool isBuy, Action func, string itemName, string typeName, int count, int point, int typeLv) { }

	// RVA: 0x1D9FD74 Offset: 0x1D9BD74 VA: 0x1D9FD74
	public void Close() { }

	// RVA: 0x1D9FF40 Offset: 0x1D9BF40 VA: 0x1D9FF40
	private void SetVisible(bool enable) { }

	// RVA: 0x1D9FFAC Offset: 0x1D9BFAC VA: 0x1D9FFAC
	private void AddCount() { }

	// RVA: 0x1DA003C Offset: 0x1D9C03C VA: 0x1DA003C
	private void AddMaxCount() { }

	// RVA: 0x1DA00C0 Offset: 0x1D9C0C0 VA: 0x1DA00C0
	private void SubCount() { }

	// RVA: 0x1DA0144 Offset: 0x1D9C144 VA: 0x1DA0144
	private void SubMaxCount() { }

	// RVA: 0x1D9F880 Offset: 0x1D9B880 VA: 0x1D9F880
	private void UpdateCount() { }

	// RVA: 0x1DA01BC Offset: 0x1D9C1BC VA: 0x1DA01BC
	private void UpdateGetPoint() { }

	// RVA: 0x1DA0274 Offset: 0x1D9C274 VA: 0x1DA0274
	private void UpdateCost() { }

	// RVA: 0x1D9F998 Offset: 0x1D9B998 VA: 0x1D9F998
	private void UpdateTotal() { }

	// RVA: 0x1DA02E4 Offset: 0x1D9C2E4 VA: 0x1DA02E4
	private void CheckTotal() { }

	// RVA: 0x1DA0790 Offset: 0x1D9C790 VA: 0x1DA0790
	private void OnProcessing() { }

	// RVA: 0x1D9DFE0 Offset: 0x1D99FE0 VA: 0x1D9DFE0
	public short[] GetCounts() { }

	// RVA: 0x1DA0830 Offset: 0x1D9C830 VA: 0x1DA0830
	public short GetCount(int uuid) { }

	// RVA: 0x1DA0764 Offset: 0x1D9C764 VA: 0x1DA0764
	private int getCost() { }

	// RVA: 0x1D9FC64 Offset: 0x1D9BC64 VA: 0x1D9FC64
	private int calcCost(int itemId, int processingCount) { }

	// RVA: 0x1DA0414 Offset: 0x1D9C414 VA: 0x1DA0414
	private void checkOverPointSingle() { }

	// RVA: 0x1DA05E8 Offset: 0x1D9C5E8 VA: 0x1DA05E8
	private void checkOverPointMulti(int addPoint) { }

	// RVA: 0x1DA0928 Offset: 0x1D9C928 VA: 0x1DA0928
	private void checkOverPointCallback() { }

	// RVA: 0x1DA0A38 Offset: 0x1D9CA38 VA: 0x1DA0A38
	public void .ctor() { }
}
