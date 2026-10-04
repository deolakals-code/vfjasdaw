// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISpecialStorageUesExpDrinkPanel : MonoBehaviour, IUISpecialStoragePanel // TypeDefIndex: 7978
{
	// Fields
	[SerializeField]
	private GameObject[] activePanel; // 0x20
	[SerializeField]
	private UILabel selectItemLabel; // 0x28
	[SerializeField]
	private UILabel selectItemNumLabel; // 0x30
	[SerializeField]
	private UILabel selectItemParameterLabel; // 0x38
	[SerializeField]
	private GameObject selectItemWarningLabel; // 0x40
	[SerializeField]
	private UIImageButton selectItembuttonImage; // 0x48
	[SerializeField]
	private UILabel loadingItemLabel; // 0x50
	[SerializeField]
	private UILabel loadingWaitTimerLabel; // 0x58
	[SerializeField]
	private UILabel resultItemLabel; // 0x60
	[SerializeField]
	private UILabel resultParamNameLabel; // 0x68
	[SerializeField]
	private UILabel nowParamLevelLabel; // 0x70
	[SerializeField]
	private UILabel resultParamLevelLabel; // 0x78
	private UISpecialStorageUesExpDrinkPanel.PanelType activePanelType; // 0x80
	private UISpecialStorageManager manager; // 0x88
	private SystemTextManager systemTextManager; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private string paramName; // 0xA0
	private BankPotionData[] expPotiionList; // 0xA8
	private int selectId; // 0xB0
	private float waitTimer; // 0xB4

	// Methods

	// RVA: 0x1C895EC Offset: 0x1C855EC VA: 0x1C895EC Slot: 4
	public int GetMainPanelFlag() { }

	// RVA: 0x1C895F4 Offset: 0x1C855F4 VA: 0x1C895F4 Slot: 5
	public void Initialize(UISpecialStorageManager manager) { }

	// RVA: 0x1C89778 Offset: 0x1C85778 VA: 0x1C89778 Slot: 6
	public bool ChangeActivate() { }

	// RVA: 0x1C89838 Offset: 0x1C85838 VA: 0x1C89838
	private void ActiveSelectItemPanel() { }

	// RVA: 0x1C89DE0 Offset: 0x1C85DE0 VA: 0x1C89DE0
	private void ActiveResultItemPanel(int resultLevel, int resultExp) { }

	// RVA: 0x1C899E4 Offset: 0x1C859E4 VA: 0x1C899E4
	private void SetActivePanel(UISpecialStorageUesExpDrinkPanel.PanelType acitive) { }

	// RVA: 0x1C89D88 Offset: 0x1C85D88 VA: 0x1C89D88
	private bool IsCheckHaveUseItem() { }

	// RVA: 0x1C8A34C Offset: 0x1C8634C VA: 0x1C8A34C Slot: 7
	public void OnClickAsobimoMarket() { }

	// RVA: 0x1C8A3A4 Offset: 0x1C863A4 VA: 0x1C8A3A4
	public void OnClickUseCheck() { }

	// RVA: 0x1C89A54 Offset: 0x1C85A54 VA: 0x1C89A54
	public void OnChangeSelectItem(int add) { }

	[IteratorStateMachine(typeof(UISpecialStorageUesExpDrinkPanel.<UseCheckConnect>d__31))]
	// RVA: 0x1C8A664 Offset: 0x1C86664 VA: 0x1C8A664
	private IEnumerator UseCheckConnect() { }

	// RVA: 0x1C8A6F8 Offset: 0x1C866F8 VA: 0x1C8A6F8
	private void WaitTimerCountUp() { }

	// RVA: 0x1C8A7E8 Offset: 0x1C867E8 VA: 0x1C8A7E8
	public void OnClickResult() { }

	[IteratorStateMachine(typeof(UISpecialStorageUesExpDrinkPanel.<UseExpDrinkConnect>d__34))]
	// RVA: 0x1C8A888 Offset: 0x1C86888 VA: 0x1C8A888
	private IEnumerator UseExpDrinkConnect() { }

	// RVA: 0x1C8A91C Offset: 0x1C8691C VA: 0x1C8A91C Slot: 8
	public bool OnLeftTopButton() { }

	// RVA: 0x1C8AA34 Offset: 0x1C86A34 VA: 0x1C8AA34
	public void .ctor() { }
}
