// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemEditPanel : MonoBehaviour, UIStarGemBasePanel // TypeDefIndex: 8011
{
	// Fields
	[SerializeField]
	private UILabel pieceNumLabels; // 0x20
	[SerializeField]
	private UILabel costLabel; // 0x28
	[SerializeField]
	private GameObject costOverObj; // 0x30
	[SerializeField]
	private UILabel starGemNumLabel; // 0x38
	[SerializeField]
	private GameObject leftAnchorGameObject; // 0x40
	[SerializeField]
	private UICamera uiCamera; // 0x48
	[SerializeField]
	private GameObject rightAnchorGameObject; // 0x50
	[SerializeField]
	private GameObject actionLabel; // 0x58
	[SerializeField]
	private UIImageButton createButton; // 0x60
	[SerializeField]
	private UIImageButton bagButton; // 0x68
	private UIStarGemMainManager manager; // 0x70
	private SystemTextManager systemTextManager; // 0x78
	private UIIruna2Anchor leftAnchor; // 0x80
	private UIScrollWindow equipStarGemListWindow; // 0x88
	private UIIruna2Anchor rightAnchor; // 0x90
	private List<UIStarGemElement> equipList; // 0x98
	private PlayerDataManager playerDataManager; // 0xA0
	private MasterSkillDataManager masterSkillManager; // 0xA8
	private SkillTextManager skillTextManager; // 0xB0
	private GameObject equipButtonObj; // 0xB8
	private StarGemData selectStarGem; // 0xC0
	private int selectEquipButtonId; // 0xC8
	private Action returnCall; // 0xD0
	private IList<StarGemData> starGemBag; // 0xD8
	private int starGemBagCapacity; // 0xE0
	private bool isAction; // 0xE4

	// Methods

	// RVA: 0x1C98E58 Offset: 0x1C94E58 VA: 0x1C98E58 Slot: 4
	public void Initialize(UIStarGemMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1C990C8 Offset: 0x1C950C8 VA: 0x1C990C8 Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C997E4 Offset: 0x1C957E4 VA: 0x1C997E4 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C998B8 Offset: 0x1C958B8 VA: 0x1C998B8 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C99984 Offset: 0x1C95984 VA: 0x1C99984 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1C9998C Offset: 0x1C9598C VA: 0x1C9998C Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C99994 Offset: 0x1C95994 VA: 0x1C99994
	private void Update() { }

	// RVA: 0x1C99B3C Offset: 0x1C95B3C VA: 0x1C99B3C
	private void SetCostLabel() { }

	// RVA: 0x1C9948C Offset: 0x1C9548C VA: 0x1C9948C
	private void SetEquipList() { }

	// RVA: 0x1C99C98 Offset: 0x1C95C98 VA: 0x1C99C98
	private GameObject CreateEquipGemButton(Vector3 pos, StarGemData gem) { }

	// RVA: 0x1C99FA8 Offset: 0x1C95FA8 VA: 0x1C99FA8
	private void SetStarGemElementButton(UIStarGemElement element, StarGemData gem) { }

	// RVA: 0x1C99A64 Offset: 0x1C95A64 VA: 0x1C99A64
	private void SetEnableEquipStarGemListWindow(bool enabled) { }

	// RVA: 0x1C9A304 Offset: 0x1C96304 VA: 0x1C9A304
	private void ResetClickEquipButton() { }

	// RVA: 0x1C9A30C Offset: 0x1C9630C VA: 0x1C9A30C
	private void OnClickAlreadyEquipButton(int index) { }

	// RVA: 0x1C9A854 Offset: 0x1C96854 VA: 0x1C9A854
	private void OnClickDoEquipButton(int index) { }

	// RVA: 0x1C9B2C4 Offset: 0x1C972C4 VA: 0x1C9B2C4
	private void OnClickResetSkill() { }

	// RVA: 0x1C9A580 Offset: 0x1C96580 VA: 0x1C9A580
	private void EquipSkillInfo(int gemNo) { }

	// RVA: 0x1C9B5F4 Offset: 0x1C975F4 VA: 0x1C9B5F4
	private void CreateBagStarGemList() { }

	// RVA: 0x1C9BB14 Offset: 0x1C97B14 VA: 0x1C9BB14
	private void OnClickSelectEquipSkill(int gemNo) { }

	// RVA: 0x1C9BF48 Offset: 0x1C97F48 VA: 0x1C9BF48
	private void OnClickSkillWindowEquipButton() { }

	// RVA: 0x1C9C1DC Offset: 0x1C981DC VA: 0x1C9C1DC
	private void OnClickCreatePanelButton() { }

	// RVA: 0x1C9C248 Offset: 0x1C98248 VA: 0x1C9C248
	private void OnClickCheckPanelButton() { }

	// RVA: 0x1C9C2B4 Offset: 0x1C982B4 VA: 0x1C9C2B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C9C344 Offset: 0x1C98344 VA: 0x1C9C344
	private bool <OnClickDoEquipButton>b__40_0(StarGemData gem) { }

	[CompilerGenerated]
	// RVA: 0x1C9C57C Offset: 0x1C9857C VA: 0x1C9C57C
	private bool <CreateBagStarGemList>b__43_0(StarGemData gem) { }
}
