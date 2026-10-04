// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStarGemEvolutionPanel : MonoBehaviour, UIStarGemBasePanel // TypeDefIndex: 8017
{
	// Fields
	[SerializeField]
	private UIStarGemElement baseSkill; // 0x20
	[SerializeField]
	private GameObject costIcon; // 0x28
	[SerializeField]
	private Transform skillParent; // 0x30
	[SerializeField]
	private GameObject baseGemArea; // 0x38
	private UIStarGemMainManager manager; // 0x40
	private SystemTextManager systemTextManager; // 0x48
	private SkillTextManager skillTextManager; // 0x50
	private PlayerDataManager playerDataManager; // 0x58
	private GameObject nextSkillObj; // 0x60
	private GameObject spriteObj; // 0x68
	private SkillMasterData[] nextSkillList; // 0x70
	private int baseSkillCost; // 0x78
	private UIPopBaseWindow popWindow; // 0x80
	private bool isPopWindowOpen; // 0x88
	private UIStarGemEvolutionPanel.PanelState state; // 0x8C
	private Action complateAction; // 0x90
	[CompilerGenerated]
	private StarGemData <BaseStarGem>k__BackingField; // 0x98

	// Properties
	public StarGemData BaseStarGem { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C9CA50 Offset: 0x1C98A50 VA: 0x1C9CA50
	public StarGemData get_BaseStarGem() { }

	[CompilerGenerated]
	// RVA: 0x1C9CA58 Offset: 0x1C98A58 VA: 0x1C9CA58
	public void set_BaseStarGem(StarGemData value) { }

	// RVA: 0x1C9CA60 Offset: 0x1C98A60 VA: 0x1C9CA60 Slot: 4
	public void Initialize(UIStarGemMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1C9CCCC Offset: 0x1C98CCC VA: 0x1C9CCCC Slot: 8
	public void FadeIn() { }

	// RVA: 0x1C9D108 Offset: 0x1C99108 VA: 0x1C9D108 Slot: 9
	public void FadeOut() { }

	// RVA: 0x1C9D140 Offset: 0x1C99140 VA: 0x1C9D140 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x1C9D148 Offset: 0x1C99148 VA: 0x1C9D148 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x1C9D228 Offset: 0x1C99228 VA: 0x1C9D228 Slot: 6
	public bool PushRightTopButton() { }

	[IteratorStateMachine(typeof(UIStarGemEvolutionPanel.<SetEvolutionList>d__27))]
	// RVA: 0x1C9D09C Offset: 0x1C9909C VA: 0x1C9D09C
	private IEnumerator SetEvolutionList() { }

	// RVA: 0x1C9D258 Offset: 0x1C99258 VA: 0x1C9D258
	private void CreateNextSkillList() { }

	// RVA: 0x1C9D370 Offset: 0x1C99370 VA: 0x1C9D370
	private void CreateNextSkillButton(SkillMasterData data, Vector3 pos, int index) { }

	// RVA: 0x1C9E218 Offset: 0x1C9A218 VA: 0x1C9E218
	private void CreateNotTargetList() { }

	// RVA: 0x1C9DBD4 Offset: 0x1C99BD4 VA: 0x1C9DBD4
	private void SetStarGemLine(int skillNum) { }

	// RVA: 0x1C9E570 Offset: 0x1C9A570 VA: 0x1C9E570
	private void CreateLine(Vector3 pos, int width, int height, int depth, string spriteName) { }

	// RVA: 0x1C9E748 Offset: 0x1C9A748 VA: 0x1C9E748
	private void StarGemEvolution(string waitMessage, int index) { }

	[IteratorStateMachine(typeof(UIStarGemEvolutionPanel.<starGemEvolution>d__34))]
	// RVA: 0x1C9E768 Offset: 0x1C9A768 VA: 0x1C9E768
	private IEnumerator starGemEvolution(string waitMessage, int index) { }

	// RVA: 0x1C9E820 Offset: 0x1C9A820 VA: 0x1C9E820
	private void OnClickNextSkillButton(int index) { }

	// RVA: 0x1C9EB54 Offset: 0x1C9AB54 VA: 0x1C9EB54
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1C9EB5C Offset: 0x1C9AB5C VA: 0x1C9EB5C
	private bool <starGemEvolution>b__34_0(StarGemData g) { }

	[CompilerGenerated]
	// RVA: 0x1C9EB88 Offset: 0x1C9AB88 VA: 0x1C9EB88
	private void <starGemEvolution>b__34_1() { }

	[CompilerGenerated]
	// RVA: 0x1C9EC54 Offset: 0x1C9AC54 VA: 0x1C9EC54
	private void <starGemEvolution>b__34_2() { }
}
