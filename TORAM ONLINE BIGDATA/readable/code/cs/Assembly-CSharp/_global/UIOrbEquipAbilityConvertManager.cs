// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbEquipAbilityConvertManager : UIBasePanelConnection // TypeDefIndex: 7569
{
	// Fields
	[SerializeField]
	private GameObject selectedPanel; // 0x30
	[SerializeField]
	private GameObject popErrLabel; // 0x38
	[SerializeField]
	private UICharacterModelBaseManager[] characterModelBaseManager; // 0x40
	[SerializeField]
	private UIIruna2AnchorSimple equipSwitchAnchor; // 0x48
	[SerializeField]
	private GameObject selectButton; // 0x50
	private UIImageButton selectButtonImage; // 0x58
	[SerializeField]
	private GameObject resultPanel; // 0x60
	[SerializeField]
	private UICharacterModelBaseManager characterModelBaseManagerResult; // 0x68
	[SerializeField]
	private UISlider waitSlider; // 0x70
	[SerializeField]
	private GameObject[] popCancelButton; // 0x78
	[SerializeField]
	private GameObject[] popOKButton; // 0x80
	[SerializeField]
	private UILabel popSilderLabel; // 0x88
	private bool isEquipOption; // 0x90
	private short abilityPlayer; // 0x92
	private int optionModelId; // 0x94
	private int optionModelColor; // 0x98
	private int decoModelId; // 0x9C
	private int decoModelColor; // 0xA0
	private byte selectedEquipAbility; // 0xA4
	private ItemData bodyItemData; // 0xA8

	// Methods

	// RVA: 0x1BAE580 Offset: 0x1BAA580 VA: 0x1BAE580
	private void Start() { }

	// RVA: 0x1BAEB50 Offset: 0x1BAAB50 VA: 0x1BAEB50
	private void SetOption(int modelId, int color) { }

	// RVA: 0x1BAEBDC Offset: 0x1BAABDC VA: 0x1BAEBDC
	private void SetDeco(int modelId, int color) { }

	[IteratorStateMachine(typeof(UIOrbEquipAbilityConvertManager.<ItemUsedWaitPopUp>d__23))]
	// RVA: 0x1BAEC68 Offset: 0x1BAAC68 VA: 0x1BAEC68
	private IEnumerator ItemUsedWaitPopUp() { }

	// RVA: 0x1BAECFC Offset: 0x1BAACFC VA: 0x1BAECFC
	public void OnClick_ChangeEquip() { }

	// RVA: 0x1BAED7C Offset: 0x1BAAD7C VA: 0x1BAED7C
	public void OnClick_SelectAbility(int ability) { }

	// RVA: 0x1BAEF94 Offset: 0x1BAAF94 VA: 0x1BAEF94
	public void OnClick_UsedItem() { }

	// RVA: 0x1BAF244 Offset: 0x1BAB244 VA: 0x1BAF244
	public void OnClick_PopUpItemUsedCancel() { }

	// RVA: 0x1BAF2D8 Offset: 0x1BAB2D8 VA: 0x1BAF2D8
	public void OnClick_PopUpItemUsedOK() { }

	// RVA: 0x1BAF36C Offset: 0x1BAB36C VA: 0x1BAF36C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1BAF464 Offset: 0x1BAB464 VA: 0x1BAF464 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1BAF514 Offset: 0x1BAB514 VA: 0x1BAF514
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1BAF5CC Offset: 0x1BAB5CC VA: 0x1BAF5CC
	private void <ItemUsedWaitPopUp>b__23_0() { }
}
