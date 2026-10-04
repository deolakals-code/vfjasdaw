// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemBagPanel : MonoBehaviour, UIStarGemBasePanel // TypeDefIndex: 7999
{
	// Fields
	[SerializeField]
	private UILabel starGemBagLabel; // 0x20
	[SerializeField]
	private GameObject notProssessionMessageObj; // 0x28
	[SerializeField]
	private GameObject actButtonsParentObj; // 0x30
	[SerializeField]
	private GameObject[] actButtonObjs; // 0x38
	[SerializeField]
	private UILabel reinforcementLabel; // 0x40
	private UIStarGemMainManager manager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private PlayerDataManager playerDataManager; // 0x58
	private int selectGemListButtonId; // 0x60
	private UIStarGemListButton[] listButtonCache; // 0x68
	private StarGemData selectStarGem; // 0x70
	private bool isSkillWindow; // 0x78

	// Methods

	// RVA: 0x1C91294 Offset: 0x1C8D294 VA: 0x1C91294 Slot: 4
	public void Initialize(UIStarGemMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1C912FC Offset: 0x1C8D2FC VA: 0x1C912FC Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C91460 Offset: 0x1C8D460 VA: 0x1C91460 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C91484 Offset: 0x1C8D484 VA: 0x1C91484 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C9177C Offset: 0x1C8D77C VA: 0x1C9177C Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C91784 Offset: 0x1C8D784 VA: 0x1C91784 Slot: 7
	public GameObject Panel() { }

	[IteratorStateMachine(typeof(UIStarGemBagPanel.<SetEquip>d__19))]
	// RVA: 0x1C913F4 Offset: 0x1C8D3F4 VA: 0x1C913F4
	private IEnumerator SetEquip() { }

	// RVA: 0x1C917B4 Offset: 0x1C8D7B4 VA: 0x1C917B4
	private void InitUI() { }

	// RVA: 0x1C92288 Offset: 0x1C8E288 VA: 0x1C92288
	private void ChangeEditPanel() { }

	// RVA: 0x1C922A4 Offset: 0x1C8E2A4 VA: 0x1C922A4
	private void OnClickCheckPanelGemListButton(int no) { }

	// RVA: 0x1C925E4 Offset: 0x1C8E5E4 VA: 0x1C925E4
	public void ChangeReinforcementButton(bool isEvolution, string text) { }

	// RVA: 0x1C92690 Offset: 0x1C8E690 VA: 0x1C92690
	private void OnClickReinforcementButton() { }

	// RVA: 0x1C928B8 Offset: 0x1C8E8B8 VA: 0x1C928B8
	private void OnClickDetailButton() { }

	// RVA: 0x1C92A10 Offset: 0x1C8EA10 VA: 0x1C92A10
	private void OnClickDisassemblyButton() { }

	// RVA: 0x1C91538 Offset: 0x1C8D538 VA: 0x1C91538
	private void CloseSkillWindow() { }

	// RVA: 0x1C92F70 Offset: 0x1C8EF70 VA: 0x1C92F70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C92F78 Offset: 0x1C8EF78 VA: 0x1C92F78
	private void <OnClickDetailButton>b__25_0() { }
}
