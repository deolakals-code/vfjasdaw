// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICreateNinjutsuScrollManager : UIBasePanel // TypeDefIndex: 6788
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	[SerializeField]
	private GameObject[] panelObjs; // 0x38
	[SerializeField]
	private UIIcon[] equipItemIcon; // 0x40
	[SerializeField]
	private UIImageButton createButton; // 0x48
	[SerializeField]
	private UILabel createButtonLabel; // 0x50
	[SerializeField]
	private UILabel createItemLabel; // 0x58
	[SerializeField]
	private GameObject createItemIcon; // 0x60
	[SerializeField]
	private UILabel createWarningLabel; // 0x68
	[SerializeField]
	private UISlider loadSlider; // 0x70
	[SerializeField]
	private UILabel resultItemNameLabel; // 0x78
	[SerializeField]
	private GameObject resultSkillIconObj; // 0x80
	private UICreateNinjutsuScrollManager.PanelState panelState; // 0x88
	private ItemSelector itemSelector; // 0x90
	private ItemData[] selectItemDataList; // 0x98
	private const int selectNumMax = 3;
	private PlayerDataManager playerDataManager; // 0xA0
	private int selectParam; // 0xA8
	private static int[] scrollItemIdList; // 0x0
	private ItemTextManager itemTextManager; // 0xB0
	private Coroutine loadCoroutine; // 0xB8
	private ItemDatav2 resultItemData; // 0xC0
	private short[] resultRandomSkillList; // 0xC8
	private List<GameObject> resultSkillIconList; // 0xD0
	private static Dictionary<int, byte> NinjutsuEquipValueListAB; // 0x8
	private static Dictionary<int, byte> NinjutsuEquipValueListC; // 0x10
	private static List<int> NinjutsuScrollSkillList; // 0x18
	private static Dictionary<int, int> NinjutsuScrollItemIdList; // 0x20

	// Methods

	// RVA: 0x19FEC10 Offset: 0x19FAC10 VA: 0x19FEC10
	private void Start() { }

	// RVA: 0x19FF534 Offset: 0x19FB534 VA: 0x19FF534
	private void OnDestroy() { }

	// RVA: 0x19FF788 Offset: 0x19FB788 VA: 0x19FF788
	public void Result(ItemDatav2 createItem, short[] randomSkillList) { }

	// RVA: 0x19FEEF8 Offset: 0x19FAEF8 VA: 0x19FEEF8
	private void ChangePanelState(UICreateNinjutsuScrollManager.PanelState panelState) { }

	// RVA: 0x19FF820 Offset: 0x19FB820 VA: 0x19FF820
	private void UpdateCreatePanel() { }

	// RVA: 0x1A00430 Offset: 0x19FC430 VA: 0x1A00430
	private void OnSelectItemData(ItemData itemData, int count) { }

	// RVA: 0x1A0056C Offset: 0x19FC56C VA: 0x1A0056C
	private bool CheckSelectItemType(int type, int param) { }

	// RVA: 0x19FF5D8 Offset: 0x19FB5D8 VA: 0x19FF5D8
	private void DestoryResultSkillIcon() { }

	// RVA: 0x19FFED0 Offset: 0x19FBED0 VA: 0x19FFED0
	private int[] GetSelectedScrollItemIds() { }

	[IteratorStateMachine(typeof(UICreateNinjutsuScrollManager.<CreateLoadingBar>d__37))]
	// RVA: 0x19FFE5C Offset: 0x19FBE5C VA: 0x19FFE5C
	private IEnumerator CreateLoadingBar() { }

	[IteratorStateMachine(typeof(UICreateNinjutsuScrollManager.<Create>d__38))]
	// RVA: 0x1A005E8 Offset: 0x19FC5E8 VA: 0x1A005E8
	private IEnumerator Create() { }

	// RVA: 0x1A0065C Offset: 0x19FC65C VA: 0x1A0065C
	public void OnSelectEquip(int param) { }

	// RVA: 0x1A0087C Offset: 0x19FC87C VA: 0x1A0087C
	public void OnCreate() { }

	// RVA: 0x1A008E4 Offset: 0x19FC8E4 VA: 0x1A008E4
	public void OnCancel() { }

	// RVA: 0x1A00970 Offset: 0x19FC970 VA: 0x1A00970
	public void OnOk() { }

	// RVA: 0x1A009D4 Offset: 0x19FC9D4 VA: 0x1A009D4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A00B44 Offset: 0x19FCB44 VA: 0x1A00B44 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A00BD0 Offset: 0x19FCBD0 VA: 0x1A00BD0
	public void .ctor() { }

	// RVA: 0x1A00CF8 Offset: 0x19FCCF8 VA: 0x1A00CF8
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1A016E8 Offset: 0x19FD6E8 VA: 0x1A016E8
	private bool <OnSelectEquip>b__39_0(ItemData item) { }
}
