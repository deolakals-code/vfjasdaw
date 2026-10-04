// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticResultPanel : MonoBehaviour, IUIPetSynthetic // TypeDefIndex: 7759
{
	// Fields
	[SerializeField]
	private GameObject leftPropPanel; // 0x20
	[SerializeField]
	private GameObject rightPropPanel; // 0x28
	[SerializeField]
	private GameObject[] typeElement; // 0x30
	[SerializeField]
	private GameObject[] skillElement; // 0x38
	[SerializeField]
	private UILabel statusLabel; // 0x40
	[SerializeField]
	private UILabel[] potentialLabel; // 0x48
	[SerializeField]
	private GameObject otherPropPanel; // 0x50
	[SerializeField]
	private UILabel limitLvLabel; // 0x58
	[SerializeField]
	private UILabel weaponAtkLabel; // 0x60
	[SerializeField]
	private GameObject chanceLabel; // 0x68
	[SerializeField]
	private UILabel weaponInAktLabel; // 0x70
	[SerializeField]
	private UILabel[] titleLabels; // 0x78
	private int selectFormParam; // 0x80
	private PetDataManager.SyntheticSelectData[] petData; // 0x88
	private PetSynthesisData synthesisData; // 0x90
	private int sumAtk; // 0x98
	private int bonusAtk; // 0x9C
	private SystemTextManager systemTextManager; // 0xA0
	private SkillTextManager skillTextManager; // 0xA8
	private SkillTextManagerData skillTextManagerData; // 0xB0
	private Coroutine endCoroutine; // 0xB8
	private UIPetSyntheticManager.PanelType panelType; // 0xC0

	// Methods

	// RVA: 0x1C04E48 Offset: 0x1C00E48 VA: 0x1C04E48
	public void Initialize(UIPetSyntheticManager.PanelType panelType, int selectFormParam, PetDataManager.SyntheticSelectData[] petData, PetSynthesisData data) { }

	// RVA: 0x1C06CA0 Offset: 0x1C02CA0 VA: 0x1C06CA0 Slot: 5
	public void ClosePanel() { }

	[IteratorStateMachine(typeof(UIPetSyntheticResultPanel.<CloseAndDisnablePanel>d__24))]
	// RVA: 0x1C06CD0 Offset: 0x1C02CD0 VA: 0x1C06CD0
	private IEnumerator CloseAndDisnablePanel() { }

	// RVA: 0x1C06D64 Offset: 0x1C02D64 VA: 0x1C06D64 Slot: 6
	public void ResetElementPos() { }

	// RVA: 0x1C06DE0 Offset: 0x1C02DE0 VA: 0x1C06DE0
	public void SetResultTypeDatas(PetDataManager.SyntheticSelectData petData) { }

	// RVA: 0x1C051CC Offset: 0x1C011CC VA: 0x1C051CC
	private void InitSkillObj(int[] skillId, int[] skillLv) { }

	// RVA: 0x1C06118 Offset: 0x1C02118 VA: 0x1C06118
	private void InitSkillNoChangeData() { }

	// RVA: 0x1C054B8 Offset: 0x1C014B8 VA: 0x1C054B8
	private void InitTypeObj(int petParam, PetSynthesisType selectType) { }

	// RVA: 0x1C06290 Offset: 0x1C02290 VA: 0x1C06290
	private void InitTypeNoChangeData() { }

	// RVA: 0x1C05938 Offset: 0x1C01938 VA: 0x1C05938
	private void InitStatusLabel(PetInfoData data1, PetInfoData data2, short atk1, short atk2) { }

	// RVA: 0x1C06694 Offset: 0x1C02694 VA: 0x1C06694
	private void InitStatusNoChangeData() { }

	// RVA: 0x1C06B20 Offset: 0x1C02B20 VA: 0x1C06B20
	private void UpdateTitle() { }

	// RVA: 0x1C0747C Offset: 0x1C0347C VA: 0x1C0747C Slot: 4
	public void InitMainButton(UIImageButton mainButton) { }

	// RVA: 0x1C074B4 Offset: 0x1C034B4 VA: 0x1C074B4
	public void .ctor() { }
}
