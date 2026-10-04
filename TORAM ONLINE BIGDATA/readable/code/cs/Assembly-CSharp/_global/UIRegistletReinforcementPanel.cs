// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletReinforcementPanel : MonoBehaviour, UIRegistletBasePanel // TypeDefIndex: 7940
{
	// Fields
	[SerializeField]
	private UIRegistletElement[] registletElements; // 0x20
	[SerializeField]
	private GameObject reinforceObj; // 0x28
	[SerializeField]
	private GameObject notProssessionMessageObj; // 0x30
	[SerializeField]
	private GameObject resultObj; // 0x38
	[SerializeField]
	private UIIruna2Anchor leftAnchor; // 0x40
	[SerializeField]
	private GameObject completeWindow; // 0x48
	[SerializeField]
	private UILabel completeLabel; // 0x50
	[SerializeField]
	private GameObject completeBackIconObj; // 0x58
	[SerializeField]
	private UIRegistletElement completeElement; // 0x60
	[SerializeField]
	private UILabel completeBottomLabel; // 0x68
	[SerializeField]
	private UILabel needGemPowderLabel; // 0x70
	[SerializeField]
	private UIImageButton executeButton; // 0x78
	[SerializeField]
	private UILabel executeButtonLabel; // 0x80
	[SerializeField]
	private GameObject attentionLabel; // 0x88
	[SerializeField]
	private GameObject attentionWindowObj; // 0x90
	[SerializeField]
	private GameObject attentionItemNameElement; // 0x98
	[CompilerGenerated]
	private GemCartData <BaseGemCartData>k__BackingField; // 0xA0
	private UIRegistletMainManager manager; // 0xA8
	private SystemTextManager systemTextManager; // 0xB0
	private RegistletTextManager registletTextManager; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	private UIRegistletReinforcementPanel.PanelState state; // 0xC8
	private bool isPopWindowOpen; // 0xCC
	private List<UIRegistletListButton> materialButtonList; // 0xD0
	private List<GemCartData> materialGemCartDataList; // 0xD8
	private UIPopBaseWindow popWindow; // 0xE0
	private int needGemPowder; // 0xE8
	private int updateLevel; // 0xEC
	private bool isLvMax; // 0xF0
	private bool isHoldScroll; // 0xF1
	private bool isMultiSelect; // 0xF2
	private readonly int MaxMultiSelectNum; // 0xF4
	private UIScrollWindow attentionScrollWindow; // 0xF8

	// Properties
	public GemCartData BaseGemCartData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C6868C Offset: 0x1C6468C VA: 0x1C6868C
	public GemCartData get_BaseGemCartData() { }

	[CompilerGenerated]
	// RVA: 0x1C68694 Offset: 0x1C64694 VA: 0x1C68694
	private void set_BaseGemCartData(GemCartData value) { }

	// RVA: 0x1C6869C Offset: 0x1C6469C VA: 0x1C6869C Slot: 4
	public void Initialize(UIRegistletMainManager manager, SystemTextManager systemTextManager, RegistletTextManager registletTextManager) { }

	// RVA: 0x1C68724 Offset: 0x1C64724 VA: 0x1C68724 Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C6886C Offset: 0x1C6486C VA: 0x1C6886C Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C6889C Offset: 0x1C6489C VA: 0x1C6889C Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C688A4 Offset: 0x1C648A4 VA: 0x1C688A4 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C689C4 Offset: 0x1C649C4 VA: 0x1C689C4 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C689CC Offset: 0x1C649CC VA: 0x1C689CC
	private void Update() { }

	// RVA: 0x1C5E2DC Offset: 0x1C5A2DC VA: 0x1C5E2DC
	public void SetBaseGemCartData(GemCartData data) { }

	// RVA: 0x1C68A18 Offset: 0x1C64A18 VA: 0x1C68A18
	public void OnClickSelectMaterialGem(int param) { }

	// RVA: 0x1C6A00C Offset: 0x1C6600C VA: 0x1C6A00C
	public void OnClickReinforcementExecute() { }

	// RVA: 0x1C6A5F8 Offset: 0x1C665F8 VA: 0x1C6A5F8
	public void OnClickCloseComplete() { }

	// RVA: 0x1C6A5FC Offset: 0x1C665FC VA: 0x1C6A5FC
	public void OnAttention() { }

	// RVA: 0x1C6A648 Offset: 0x1C66648 VA: 0x1C6A648
	public void OnClickMultiSelect() { }

	[IteratorStateMachine(typeof(UIRegistletReinforcementPanel.<CreateGemCartList>d__51))]
	// RVA: 0x1C687F8 Offset: 0x1C647F8 VA: 0x1C687F8
	private IEnumerator CreateGemCartList() { }

	[IteratorStateMachine(typeof(UIRegistletReinforcementPanel.<Reinforcement>d__52))]
	// RVA: 0x1C6A584 Offset: 0x1C66584 VA: 0x1C6A584
	private IEnumerator Reinforcement() { }

	// RVA: 0x1C6A7CC Offset: 0x1C667CC VA: 0x1C6A7CC
	private void UpdateMultiSelectButtonIcon() { }

	// RVA: 0x1C6A8FC Offset: 0x1C668FC VA: 0x1C6A8FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C6AA10 Offset: 0x1C66A10 VA: 0x1C6AA10
	private bool <CreateGemCartList>b__51_0(GemCartData gem) { }
}
