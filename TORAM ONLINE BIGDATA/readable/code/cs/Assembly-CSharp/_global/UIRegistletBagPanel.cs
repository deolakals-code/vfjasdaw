// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRegistletBagPanel : MonoBehaviour, UIRegistletBasePanel // TypeDefIndex: 7899
{
	// Fields
	[SerializeField]
	private UILabel gemPowderNumLabel; // 0x20
	[SerializeField]
	private UILabel gemCartNumLabel; // 0x28
	[SerializeField]
	private GameObject notProssessionMessageObj; // 0x30
	[SerializeField]
	private GameObject actButtonsParentObj; // 0x38
	[SerializeField]
	private GameObject[] actButtonObjs; // 0x40
	private UIRegistletMainManager manager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private RegistletTextManager registletTextManager; // 0x58
	private PlayerDataManager playerDataManager; // 0x60
	private GemCartData selectedGemCartData; // 0x68
	private int selectListButtonId; // 0x70
	private List<UIRegistletListButton> listButtonList; // 0x78

	// Methods

	// RVA: 0x1C5C588 Offset: 0x1C58588 VA: 0x1C5C588 Slot: 4
	public void Initialize(UIRegistletMainManager manager, SystemTextManager systemTextManager, RegistletTextManager registletTextManager) { }

	// RVA: 0x1C5C604 Offset: 0x1C58604 VA: 0x1C5C604 Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C5C6B0 Offset: 0x1C586B0 VA: 0x1C5C6B0 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C5C6D4 Offset: 0x1C586D4 VA: 0x1C5C6D4 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C5C6DC Offset: 0x1C586DC VA: 0x1C5C6DC Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C5D2DC Offset: 0x1C592DC VA: 0x1C5D2DC Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C5D2E4 Offset: 0x1C592E4 VA: 0x1C5D2E4
	public void OnClickListButton(int param) { }

	[IteratorStateMachine(typeof(UIRegistletBagPanel.<SetEquip>d__20))]
	// RVA: 0x1C5C644 Offset: 0x1C58644 VA: 0x1C5C644
	private IEnumerator SetEquip() { }

	// RVA: 0x1C5DBC8 Offset: 0x1C59BC8 VA: 0x1C5DBC8
	private void InitUI() { }

	// RVA: 0x1C5DEDC Offset: 0x1C59EDC VA: 0x1C5DEDC
	private void UpdateGemCount() { }

	// RVA: 0x1C5CCE4 Offset: 0x1C58CE4 VA: 0x1C5CCE4
	private void UpdatePanel() { }

	// RVA: 0x1C5E0E8 Offset: 0x1C5A0E8 VA: 0x1C5E0E8
	public void OnClickReinforcementButton() { }

	// RVA: 0x1C5E2E4 Offset: 0x1C5A2E4 VA: 0x1C5E2E4
	public void OnClickDetailButton() { }

	// RVA: 0x1C5E3B4 Offset: 0x1C5A3B4 VA: 0x1C5E3B4
	public void OnClickDisassemblyButton() { }

	// RVA: 0x1C5E558 Offset: 0x1C5A558 VA: 0x1C5E558
	public void OnClickMultiDisassemblyButton() { }

	// RVA: 0x1C5E584 Offset: 0x1C5A584 VA: 0x1C5E584
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C5E644 Offset: 0x1C5A644 VA: 0x1C5E644
	private bool <OnClickListButton>b__19_0(GemCartEquipData x) { }

	[CompilerGenerated]
	// RVA: 0x1C5E670 Offset: 0x1C5A670 VA: 0x1C5E670
	private void <SetEquip>b__20_0() { }

	[CompilerGenerated]
	// RVA: 0x1C5E68C Offset: 0x1C5A68C VA: 0x1C5E68C
	private bool <UpdatePanel>b__23_0(GemCartEquipData x) { }

	[CompilerGenerated]
	// RVA: 0x1C5E6B8 Offset: 0x1C5A6B8 VA: 0x1C5E6B8
	private void <OnClickDetailButton>b__25_0() { }
}
