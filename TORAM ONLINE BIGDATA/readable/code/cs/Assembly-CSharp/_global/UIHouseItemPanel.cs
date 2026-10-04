// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseItemPanel : MonoBehaviour // TypeDefIndex: 7259
{
	// Fields
	[SerializeField]
	private Transform parentTopPanel; // 0x20
	[SerializeField]
	private UIScrollWindow uiScrollList; // 0x28
	[SerializeField]
	private Transform d3ViewParent; // 0x30
	[SerializeField]
	private Transform d3ViewRotParent; // 0x38
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x40
	private float modelAngle; // 0x48
	private bool rotModelLock; // 0x4C
	[SerializeField]
	private GameObject pop3DObject; // 0x50
	[SerializeField]
	private Transform pop3DParentObject; // 0x58
	[SerializeField]
	private GameObject recipePopLabel; // 0x60
	private UIHouseRecipeLabel uiRecipePopLabel; // 0x68
	[SerializeField]
	private GameObject orbWindow; // 0x70
	private UIIruna2Anchor orbWindowAnchor; // 0x78
	[SerializeField]
	private UILabel orbWindowLabel; // 0x80
	[SerializeField]
	private UILabel orbPopLabel; // 0x88
	[SerializeField]
	private GameObject orbPopIconObject; // 0x90
	private GameObject pop3DClone; // 0x98
	private GameObject manager; // 0xA0
	[SerializeField]
	private GameObject popWindowSizePanel; // 0xA8
	[SerializeField]
	private UILabel popWindowSizeLabel; // 0xB0
	[SerializeField]
	private GameObject popWindowHeightPanel; // 0xB8
	[SerializeField]
	private GameObject popWindowTopHeightPanel; // 0xC0
	[SerializeField]
	private GameObject popWindowBottomHeightPanel; // 0xC8
	[SerializeField]
	private UILabel popWindowHeightLabel; // 0xD0
	private Dictionary<HousePartsModelType, int> myHomeCreateId; // 0xD8
	private Dictionary<HousePartsModelType, GameObject> myHomeCreateModel; // 0xE0
	private List<GameObject> topButtonList; // 0xE8
	private int selectItemUid; // 0xF0
	private int selectItemNum; // 0xF4
	private bool cancelCheck; // 0xF8
	private bool updatePopAutoRot; // 0xF9
	private Color backColor; // 0xFC
	private UIIHouseItemPanelResponse uiIHouseItemPanelResponse; // 0x110
	private SystemTextManager systemtextManager; // 0x118
	private HouseItemTextManager houseItemTextManager; // 0x120
	private List<GameObject> popSizePanelList; // 0x128

	// Properties
	public bool IsPopUpWindow { get; }

	// Methods

	// RVA: 0x1AF274C Offset: 0x1AEE74C VA: 0x1AF274C
	public bool get_IsPopUpWindow() { }

	// RVA: 0x1AE4A78 Offset: 0x1AE0A78 VA: 0x1AE4A78
	public void Initialize(GameObject manager, Vector3 d3ViewOffset, bool rotModelLock, UIIHouseItemPanelResponse responsePanel) { }

	// RVA: 0x1AF2754 Offset: 0x1AEE754 VA: 0x1AF2754
	private void Update() { }

	// RVA: 0x1AE304C Offset: 0x1ADF04C VA: 0x1AE304C
	public void ScrollItemListClaer() { }

	// RVA: 0x1AE31FC Offset: 0x1ADF1FC VA: 0x1AE31FC
	public void AddScrollItemList(GameObject button, int index, int id) { }

	// RVA: 0x1AF0BF0 Offset: 0x1AECBF0 VA: 0x1AF0BF0
	public void InvisibleScrollList() { }

	// RVA: 0x1AE2E30 Offset: 0x1ADEE30 VA: 0x1AE2E30
	public void ActiveScrollList() { }

	// RVA: 0x1AF28B0 Offset: 0x1AEE8B0 VA: 0x1AF28B0
	public void SelectItemListClaer() { }

	// RVA: 0x1AE4D48 Offset: 0x1AE0D48 VA: 0x1AE4D48
	public void AddSelectItemList(GameObject addButton, Vector3 pos) { }

	// RVA: 0x1AE2E5C Offset: 0x1ADEE5C VA: 0x1AE2E5C
	public void Clear() { }

	// RVA: 0x1AE4CE4 Offset: 0x1AE0CE4 VA: 0x1AE4CE4
	public void ViewRotation(Quaternion rot) { }

	// RVA: 0x1AF2A80 Offset: 0x1AEEA80 VA: 0x1AF2A80
	public void ViewPos(Vector3 pos) { }

	// RVA: 0x1AF2ADC Offset: 0x1AEEADC VA: 0x1AF2ADC Slot: 4
	protected virtual void UpdateRotation() { }

	// RVA: 0x1AEE234 Offset: 0x1AEA234 VA: 0x1AEE234
	public static void GetViewModelSize(GameObject model, out Vector3 center, out Vector3 size) { }

	// RVA: 0x1AEFA58 Offset: 0x1AEBA58 VA: 0x1AEFA58
	public void UpdatePartsModelData(HousePartsModelType type, int id, int modelId) { }

	// RVA: 0x1AE283C Offset: 0x1ADE83C VA: 0x1AE283C
	public void UpdatePartsModelData(HousePartsModelType type, int id, int modelId, Vector3 size, string assetPath, string filePath) { }

	[IteratorStateMachine(typeof(UIHouseItemPanel.<UpdatePartsModelDataLoad>d__53))]
	// RVA: 0x1AF2BE0 Offset: 0x1AEEBE0 VA: 0x1AF2BE0
	private IEnumerator UpdatePartsModelDataLoad(HousePartsModelType type, int modelId, int itemId, Vector3 size, string assetPath, string filePath) { }

	// RVA: 0x1AF2CCC Offset: 0x1AEECCC VA: 0x1AF2CCC
	private void UpdatePartsModel(HousePartsModelType type, int id, Transform model, Vector3 pos, float rot) { }

	// RVA: 0x1AF2DBC Offset: 0x1AEEDBC VA: 0x1AF2DBC
	private void UpdatePartsModel(HousePartsModelType type, int id, GameObject model, Vector3 pos, float rot) { }

	// RVA: 0x1AF30F8 Offset: 0x1AEF0F8 VA: 0x1AF30F8
	private Texture GetMaskTexture(HousePartsModelType type) { }

	// RVA: 0x1AF31E4 Offset: 0x1AEF1E4 VA: 0x1AF31E4
	private void SetMaskTexture(HousePartsModelType type, Texture maskTexture, string objName) { }

	// RVA: 0x1AF0E3C Offset: 0x1AECE3C VA: 0x1AF0E3C
	public bool SetModelColor(HousePartsModelType modelType, byte[] colorIndex) { }

	// RVA: 0x1AE3824 Offset: 0x1ADF824 VA: 0x1AE3824
	public int GetModelFlag(HousePartsModelType modelType) { }

	// RVA: 0x1AE2834 Offset: 0x1ADE834 VA: 0x1AE2834
	public void CreatePopItem(int itemUid, int itemNum) { }

	// RVA: 0x1AF33D4 Offset: 0x1AEF3D4 VA: 0x1AF33D4
	private bool PopItemModel(HousePartsModelType type) { }

	// RVA: 0x1AEFDD8 Offset: 0x1AEBDD8 VA: 0x1AEFDD8
	public bool OnCreateItemUseOrb(HousePartsModelType type) { }

	// RVA: 0x1AF0368 Offset: 0x1AEC368 VA: 0x1AF0368
	public bool OnCreateItemUsePoint(HousePartsModelType type) { }

	[IteratorStateMachine(typeof(UIHouseItemPanel.<PopUpCreteItemMessage>d__64))]
	// RVA: 0x1AF4000 Offset: 0x1AF0000 VA: 0x1AF4000
	private IEnumerator PopUpCreteItemMessage(PopUpMessageWindow messageWindow, bool direct, bool orbNumCheck, int useOrbNum) { }

	// RVA: 0x1AE3A78 Offset: 0x1ADFA78 VA: 0x1AE3A78
	public bool CreateItemPopCancel() { }

	// RVA: 0x1AF3A5C Offset: 0x1AEFA5C VA: 0x1AF3A5C
	private void PopSizeBoxPanel(int x, int y, int z, int flag) { }

	// RVA: 0x1AE2D34 Offset: 0x1ADED34 VA: 0x1AE2D34
	public void OnPopWindow(PopBaseWindow messageWindow, GameObject[] panel) { }

	[IteratorStateMachine(typeof(UIHouseItemPanel.<PopUpWindowThread>d__68))]
	// RVA: 0x1AF40B8 Offset: 0x1AF00B8 VA: 0x1AF40B8
	private IEnumerator PopUpWindowThread(PopBaseWindow messageWindow, GameObject[] panel) { }

	// RVA: 0x1AF415C Offset: 0x1AF015C VA: 0x1AF415C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AF42C4 Offset: 0x1AF02C4 VA: 0x1AF42C4
	private void <PopUpCreteItemMessage>b__64_0() { }
}
