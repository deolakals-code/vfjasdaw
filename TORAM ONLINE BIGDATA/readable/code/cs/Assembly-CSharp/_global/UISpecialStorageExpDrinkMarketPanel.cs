// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageExpDrinkMarketPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7953
{
	// Fields
	[SerializeField]
	private UILabel selectItemLabel; // 0x20
	[SerializeField]
	private UILabel selectItemNumLabel; // 0x28
	[SerializeField]
	private GameObject selectItemWarningLabel; // 0x30
	[SerializeField]
	private UIImageButton selectItembuttonImage; // 0x38
	private UISpecialStorageManager manager; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private BankPotionData[] expPotiionList; // 0x58
	private int selectId; // 0x60

	// Methods

	// RVA: 0x1C827C4 Offset: 0x1C7E7C4 VA: 0x1C827C4 Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C827CC Offset: 0x1C7E7CC VA: 0x1C827CC Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C828E0 Offset: 0x1C7E8E0 VA: 0x1C828E0
	private bool IsCheckHaveUseItem() { }

	// RVA: 0x1C82938 Offset: 0x1C7E938 VA: 0x1C82938 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C82A90 Offset: 0x1C7EA90 VA: 0x1C82A90
	public void OnChangeSelectItem(int add) { }

	// RVA: 0x1C82DD0 Offset: 0x1C7EDD0 VA: 0x1C82DD0
	public void OnClickResult() { }

	[IteratorStateMachine(typeof(UISpecialStorageExpDrinkMarketPanel.<CreateExpDrinkConnect>d__15))]
	// RVA: 0x1C82E70 Offset: 0x1C7EE70 VA: 0x1C82E70
	private IEnumerator CreateExpDrinkConnect() { }

	// RVA: 0x1C82F04 Offset: 0x1C7EF04 VA: 0x1C82F04 Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C82FF4 Offset: 0x1C7EFF4 VA: 0x1C82FF4 Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C8304C Offset: 0x1C7F04C VA: 0x1C8304C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C8305C Offset: 0x1C7F05C VA: 0x1C8305C
	private void <CreateExpDrinkConnect>b__15_0() { }
}
