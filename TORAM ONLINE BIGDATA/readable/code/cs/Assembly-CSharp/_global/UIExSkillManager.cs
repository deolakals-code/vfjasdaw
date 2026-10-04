// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIExSkillManager : UIBasePanelControl // TypeDefIndex: 6876
{
	// Fields
	[SerializeField]
	private GameObject skillTreeButton; // 0x58
	[SerializeField]
	private GameObject skillExButton; // 0x60
	[SerializeField]
	private GameObject smithPointObject; // 0x68
	[SerializeField]
	private UILabel smithPoint; // 0x70
	[SerializeField]
	private UISprite smithBar; // 0x78
	[SerializeField]
	private GameObject alchemyPointObject; // 0x80
	[SerializeField]
	private UILabel alchemyPoint; // 0x88
	[SerializeField]
	private UISprite alchemyBar; // 0x90
	[SerializeField]
	private Transform skillTreeButtonParent; // 0x98
	[SerializeField]
	private Transform skillExButtonParent; // 0xA0
	[SerializeField]
	private Camera dragCamera; // 0xA8
	private UIIruna2Viewport dragViewport; // 0xB0
	private UISkillTreeDraggableCamera draggableCamera; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	private SkillTextManager skillTextManager; // 0xC8
	private SmithUIMaterialBase smithUIMaterialBase; // 0xD0
	private SyntheticMedicine syntheticMedicine; // 0xD8
	[SerializeField]
	private GameObject windowPanel; // 0xE0
	[SerializeField]
	private GameObject dragPanel; // 0xE8
	private List<Vector3> positionList; // 0xF0
	private List<GameObject> exSkillList; // 0xF8
	[SerializeField]
	private UILabel errorLabel; // 0x100
	private TweenAlpha errorTweenAlpha; // 0x108
	[SerializeField]
	private UILabel attentionLabel; // 0x110
	private TweenScale attenTweenScale; // 0x118
	private bool selectedSkillTree; // 0x120
	private bool isOpenAlchemySkill; // 0x121

	// Properties
	public SmithUIMaterialBase SmithUIMaterialBasePanel { get; }
	public SyntheticMedicine SyntheticMedicinePanel { get; }
	private bool isBattleActive { get; }

	// Methods

	// RVA: 0x1A2C870 Offset: 0x1A28870 VA: 0x1A2C870
	public SmithUIMaterialBase get_SmithUIMaterialBasePanel() { }

	// RVA: 0x1A2C878 Offset: 0x1A28878 VA: 0x1A2C878
	public SyntheticMedicine get_SyntheticMedicinePanel() { }

	// RVA: 0x1A2C880 Offset: 0x1A28880 VA: 0x1A2C880
	private bool get_isBattleActive() { }

	// RVA: 0x1A2C95C Offset: 0x1A2895C VA: 0x1A2C95C
	public bool IsSyntheticMedicineActive() { }

	// RVA: 0x1A2C9BC Offset: 0x1A289BC VA: 0x1A2C9BC
	public SmithUIMaterialBase GetActiveBasePanel() { }

	// RVA: 0x1A2C9D4 Offset: 0x1A289D4 VA: 0x1A2C9D4
	public void OpenAlchemySkillPanel() { }

	// RVA: 0x1A2C9E0 Offset: 0x1A289E0 VA: 0x1A2C9E0
	private void Start() { }

	// RVA: 0x1A2DD54 Offset: 0x1A29D54 VA: 0x1A2DD54
	private void Update() { }

	// RVA: 0x1A2DE30 Offset: 0x1A29E30 VA: 0x1A2DE30
	public void SkillPanelOpen() { }

	// RVA: 0x1A2CE90 Offset: 0x1A28E90 VA: 0x1A2CE90
	private void ExSkillList() { }

	// RVA: 0x1A2DEBC Offset: 0x1A29EBC VA: 0x1A2DEBC
	private void ExSkillTreePop() { }

	// RVA: 0x1A2D8B0 Offset: 0x1A298B0 VA: 0x1A2D8B0
	private void AlchemySkillList() { }

	// RVA: 0x1A2EE98 Offset: 0x1A2AE98 VA: 0x1A2EE98
	public void WizardSkillList() { }

	// RVA: 0x1A2EF90 Offset: 0x1A2AF90 VA: 0x1A2EF90
	public void NinjaSkillList() { }

	// RVA: 0x1A2F088 Offset: 0x1A2B088 VA: 0x1A2F088
	public void BareHandSkillList() { }

	// RVA: 0x1A2F178 Offset: 0x1A2B178 VA: 0x1A2F178
	public void MagicBladeSkillList() { }

	// RVA: 0x1A2F270 Offset: 0x1A2B270 VA: 0x1A2F270
	public void MagicSkillList() { }

	// RVA: 0x1A2F368 Offset: 0x1A2B368 VA: 0x1A2F368
	public void ShootSkillList() { }

	// RVA: 0x1A2F460 Offset: 0x1A2B460 VA: 0x1A2F460
	public void NecromancerSkillList() { }

	// RVA: 0x1A2F558 Offset: 0x1A2B558 VA: 0x1A2F558
	public void MinstrelList() { }

	// RVA: 0x1A2F650 Offset: 0x1A2B650 VA: 0x1A2F650
	public void GolemSkillList() { }

	// RVA: 0x1A2F748 Offset: 0x1A2B748 VA: 0x1A2F748
	private void SmithSkillList() { }

	// RVA: 0x1A2E374 Offset: 0x1A2A374 VA: 0x1A2E374
	private void ExSkillButton(int index, SkillId skillId, string message, string iconSprite, bool lcok, string printText = "") { }

	// RVA: 0x1A2EA94 Offset: 0x1A2AA94 VA: 0x1A2EA94
	private void ExSkillPop() { }

	// RVA: 0x1A2FB54 Offset: 0x1A2BB54 VA: 0x1A2FB54
	private void CloseMenu() { }

	// RVA: 0x1A2FB98 Offset: 0x1A2BB98 VA: 0x1A2FB98
	private void LosdExSkill(string path, Action<GameObject> callBack) { }

	// RVA: 0x1A2FF14 Offset: 0x1A2BF14 VA: 0x1A2FF14
	private void SmithSet(GameObject obj) { }

	// RVA: 0x1A2FFA4 Offset: 0x1A2BFA4 VA: 0x1A2FFA4
	private void SyntheticMedicineSet(GameObject obj) { }

	// RVA: 0x1A30034 Offset: 0x1A2C034 VA: 0x1A30034
	private void SyntheticEquipmentSet(GameObject obj) { }

	// RVA: 0x1A300C4 Offset: 0x1A2C0C4 VA: 0x1A300C4
	public void CloseNowObject() { }

	// RVA: 0x1A301B4 Offset: 0x1A2C1B4 VA: 0x1A301B4
	public void ToProcessing() { }

	// RVA: 0x1A3024C Offset: 0x1A2C24C VA: 0x1A3024C
	public void ToManufacture() { }

	// RVA: 0x1A302E4 Offset: 0x1A2C2E4 VA: 0x1A302E4
	public void ToStrengthening() { }

	// RVA: 0x1A3037C Offset: 0x1A2C37C VA: 0x1A3037C
	public void ToReconstruction() { }

	// RVA: 0x1A30414 Offset: 0x1A2C414 VA: 0x1A30414
	public void ToGrant() { }

	// RVA: 0x1A304AC Offset: 0x1A2C4AC VA: 0x1A304AC
	private void ToMedicine() { }

	// RVA: 0x1A30544 Offset: 0x1A2C544 VA: 0x1A30544
	private void ToSyntheticEquipment() { }

	// RVA: 0x1A305DC Offset: 0x1A2C5DC VA: 0x1A305DC
	private void ToStockColor() { }

	// RVA: 0x1A306B8 Offset: 0x1A2C6B8 VA: 0x1A306B8
	private void ToColorSynthesis() { }

	// RVA: 0x1A30794 Offset: 0x1A2C794 VA: 0x1A30794
	public void .ctor() { }
}
