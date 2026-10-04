// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemReinforcementPanel : MonoBehaviour, UIStarGemBasePanel // TypeDefIndex: 8032
{
	// Fields
	private static readonly int skillMaxLevel; // 0x0
	[SerializeField]
	private UIStarGemElement[] starGemElements; // 0x20
	[SerializeField]
	private GameObject reinforceObj; // 0x28
	[SerializeField]
	private GameObject notProssessionMessageObj; // 0x30
	[SerializeField]
	private GameObject resultObj; // 0x38
	[SerializeField]
	private UIIruna2Anchor leftAnchor; // 0x40
	private UIStarGemMainManager manager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private SkillTextManager skillTextManager; // 0x58
	private PlayerDataManager playerDataManager; // 0x60
	private List<UIStarGemListButton> materialButtonList; // 0x68
	private UIPopBaseWindow popWindow; // 0x70
	private bool isPopWindowOpen; // 0x78
	private UIStarGemReinforcementPanel.PanelState state; // 0x7C
	private int selectMaterialNo; // 0x80
	[CompilerGenerated]
	private StarGemData <BaseStarGem>k__BackingField; // 0x88

	// Properties
	public StarGemData BaseStarGem { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CA3A44 Offset: 0x1C9FA44 VA: 0x1CA3A44
	public StarGemData get_BaseStarGem() { }

	[CompilerGenerated]
	// RVA: 0x1CA3A4C Offset: 0x1C9FA4C VA: 0x1CA3A4C
	public void set_BaseStarGem(StarGemData value) { }

	// RVA: 0x1CA3A54 Offset: 0x1C9FA54 VA: 0x1CA3A54 Slot: 4
	public void Initialize(UIStarGemMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1CA3BF8 Offset: 0x1C9FBF8 VA: 0x1CA3BF8 Slot: 8
	public void FadeIn() { }

	// RVA: 0x1CA3DB0 Offset: 0x1C9FDB0 VA: 0x1CA3DB0 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1CA3DD4 Offset: 0x1C9FDD4 VA: 0x1CA3DD4 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1CA3DDC Offset: 0x1C9FDDC VA: 0x1CA3DDC Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1CA3E6C Offset: 0x1C9FE6C VA: 0x1CA3E6C Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x1CA3E74 Offset: 0x1C9FE74 VA: 0x1CA3E74
	public void SetMaterialStarGemData(StarGemData data) { }

	[IteratorStateMachine(typeof(UIStarGemReinforcementPanel.<SetMaterialList>d__28))]
	// RVA: 0x1CA3D44 Offset: 0x1C9FD44 VA: 0x1CA3D44
	private IEnumerator SetMaterialList() { }

	// RVA: 0x1CA3EF8 Offset: 0x1C9FEF8 VA: 0x1CA3EF8
	private void SetResultData() { }

	[IteratorStateMachine(typeof(UIStarGemReinforcementPanel.<StarGemReinforcement>d__30))]
	// RVA: 0x1CA4080 Offset: 0x1CA0080 VA: 0x1CA4080
	private IEnumerator StarGemReinforcement() { }

	// RVA: 0x1CA4114 Offset: 0x1CA0114 VA: 0x1CA4114
	private void OnClickReinforcementPanelGemListButton(int gemNo) { }

	// RVA: 0x1CA43F4 Offset: 0x1CA03F4 VA: 0x1CA43F4
	private void OnClickReinforcementExecute() { }

	// RVA: 0x1CA4414 Offset: 0x1CA0414 VA: 0x1CA4414
	public void .ctor() { }

	// RVA: 0x1CA4424 Offset: 0x1CA0424 VA: 0x1CA4424
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1CA4470 Offset: 0x1CA0470 VA: 0x1CA4470
	private bool <SetMaterialList>b__28_0(StarGemData gem) { }

	[CompilerGenerated]
	// RVA: 0x1CA44BC Offset: 0x1CA04BC VA: 0x1CA44BC
	private bool <StarGemReinforcement>b__30_0(StarGemData g) { }

	[CompilerGenerated]
	// RVA: 0x1CA44E8 Offset: 0x1CA04E8 VA: 0x1CA44E8
	private void <StarGemReinforcement>b__30_1() { }
}
