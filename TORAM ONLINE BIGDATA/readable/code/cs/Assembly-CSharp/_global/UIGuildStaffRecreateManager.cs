// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffRecreateManager : UIBasePanelConnection // TypeDefIndex: 6705
{
	// Fields
	[SerializeField]
	private UILabel[] selectPartsName; // 0x30
	[SerializeField]
	private UIIruna2AnchorSimple[] anchor; // 0x38
	[SerializeField]
	private GameObject playerViewPanel; // 0x40
	[SerializeField]
	private GameObject enterButton; // 0x48
	[SerializeField]
	private GameObject[] hairButton; // 0x50
	[SerializeField]
	private UIScrollWindow scrollwindow; // 0x58
	private UICharacterModelBaseManager modelManager; // 0x60
	private UICharacterStyleData styleModelData; // 0x68
	private int[] selectedPartsId; // 0x70
	private int activePanelId; // 0x78
	private NewArchetypeProperties archetypeProperties; // 0x80
	private bool isDefaultEquip; // 0x88
	private bool isUpdate; // 0x89

	// Methods

	[IteratorStateMachine(typeof(UIGuildStaffRecreateManager.<Start>d__15))]
	// RVA: 0x19BEF70 Offset: 0x19BAF70 VA: 0x19BEF70
	private IEnumerator Start() { }

	// RVA: 0x19BF004 Offset: 0x19BB004 VA: 0x19BF004
	private void UpdateSelectPartsData(UIGuildStaffRecreateManager.PartsType parts, int id, string text) { }

	// RVA: 0x19BF118 Offset: 0x19BB118 VA: 0x19BF118
	private int AddChangeId(UIGuildStaffRecreateManager.PartsType parts, int add, int num) { }

	// RVA: 0x19BF1B8 Offset: 0x19BB1B8 VA: 0x19BF1B8
	private void ChangeActiveAnchorPanel(int panelId) { }

	// RVA: 0x19BF4DC Offset: 0x19BB4DC VA: 0x19BF4DC
	private int getDBIndex(int id, int[] list) { }

	// RVA: 0x19BF52C Offset: 0x19BB52C VA: 0x19BF52C
	public void OnClick_Sex(int add) { }

	// RVA: 0x19BF90C Offset: 0x19BB90C VA: 0x19BF90C
	public void OnClick_SkinColor(int add) { }

	// RVA: 0x19BFA04 Offset: 0x19BBA04 VA: 0x19BFA04
	public void OnClick_SkinTexture(int add) { }

	// RVA: 0x19BFAFC Offset: 0x19BBAFC VA: 0x19BFAFC
	public void OnClick_Height(int add) { }

	// RVA: 0x19BFC90 Offset: 0x19BBC90 VA: 0x19BFC90
	public void OnClick_Face(int add) { }

	// RVA: 0x19BFDA8 Offset: 0x19BBDA8 VA: 0x19BFDA8
	public void OnClick_EyeTexture(int add) { }

	// RVA: 0x19BFEC0 Offset: 0x19BBEC0 VA: 0x19BFEC0
	public void OnClick_EyeColor(int add) { }

	// RVA: 0x19BFFD8 Offset: 0x19BBFD8 VA: 0x19BFFD8
	public void OnClick_OddEyeColor(int add) { }

	// RVA: 0x19C00F0 Offset: 0x19BC0F0 VA: 0x19C00F0
	public void OnClick_Hair(int add) { }

	// RVA: 0x19C0208 Offset: 0x19BC208 VA: 0x19C0208
	public void OnClick_HairTail(int add) { }

	// RVA: 0x19C0320 Offset: 0x19BC320 VA: 0x19C0320
	public void OnClick_Head(int add) { }

	// RVA: 0x19C0438 Offset: 0x19BC438 VA: 0x19C0438
	public void OnClick_HairColor(int add) { }

	// RVA: 0x19C0550 Offset: 0x19BC550 VA: 0x19C0550
	public void OnClick_HairStreakColor(int add) { }

	// RVA: 0x19C0638 Offset: 0x19BC638 VA: 0x19C0638
	public void OnClick_ChangePanel(int panelId) { }

	// RVA: 0x19C06B4 Offset: 0x19BC6B4 VA: 0x19C06B4
	public void OnClick_ChangeEquip() { }

	// RVA: 0x19BF64C Offset: 0x19BB64C VA: 0x19BF64C
	private void UpdateChangeEquip(bool isDefault) { }

	// RVA: 0x19C072C Offset: 0x19BC72C VA: 0x19C072C
	private NewStyleData GetCharacterStyle() { }

	// RVA: 0x19C0AD8 Offset: 0x19BCAD8 VA: 0x19C0AD8
	private void OnClick_End() { }

	// RVA: 0x19C0CCC Offset: 0x19BCCCC VA: 0x19C0CCC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19C0F14 Offset: 0x19BCF14 VA: 0x19C0F14 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19C1118 Offset: 0x19BD118 VA: 0x19C1118
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19C11E4 Offset: 0x19BD1E4 VA: 0x19C11E4
	private void <OnClick_End>b__37_1() { }

	[CompilerGenerated]
	// RVA: 0x19C141C Offset: 0x19BD41C VA: 0x19C141C
	private void <OnLeftTopButton>b__38_0(int x) { }

	[CompilerGenerated]
	// RVA: 0x19C1518 Offset: 0x19BD518 VA: 0x19C1518
	private void <OnRightTopButton>b__39_0(int x) { }
}
