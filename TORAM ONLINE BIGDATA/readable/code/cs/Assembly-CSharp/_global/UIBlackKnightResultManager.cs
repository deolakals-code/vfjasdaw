// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightResultManager : UIBasePanelConnection // TypeDefIndex: 5854
{
	// Fields
	[SerializeField]
	private UIIruna2Anchor rightPanelAnchor; // 0x30
	[SerializeField]
	private UILabel totalScoreTitleLabel; // 0x38
	[SerializeField]
	private UILabel totalScoreLabel; // 0x40
	[SerializeField]
	private GameObject highScoreLabel; // 0x48
	[SerializeField]
	private GameObject nowStageScoreObj; // 0x50
	[SerializeField]
	private UILabel[] nowStageScoreLabels; // 0x58
	[SerializeField]
	private GameObject allStageScoreObj; // 0x60
	[SerializeField]
	private UILabel[] allStageScoreLabels; // 0x68
	[SerializeField]
	private UISprite buttonIcon; // 0x70
	[SerializeField]
	private UILabel buttonLabel; // 0x78
	[SerializeField]
	private GameObject allStageClearObj; // 0x80
	[SerializeField]
	private GameObject allStageClearEffect; // 0x88
	[SerializeField]
	private GameObject endWindowObj; // 0x90
	[SerializeField]
	private UIIruna2Anchor spinaPanelAnchor; // 0x98
	[SerializeField]
	private UILabel spinaLabel; // 0xA0
	[SerializeField]
	private UILabel subSpinaLabel; // 0xA8
	private BlackKnightRoomData roomData; // 0xB0
	private bool isAllStageClear; // 0xB8
	private int totalScore; // 0xBC

	// Methods

	[IteratorStateMachine(typeof(UIBlackKnightResultManager.<Start>d__19))]
	// RVA: 0x1809A4C Offset: 0x1805A4C VA: 0x1809A4C
	private IEnumerator Start() { }

	// RVA: 0x1809AE0 Offset: 0x1805AE0 VA: 0x1809AE0
	private void Update() { }

	// RVA: 0x1809B8C Offset: 0x1805B8C VA: 0x1809B8C
	public void OnClick(int param) { }

	[IteratorStateMachine(typeof(UIBlackKnightResultManager.<AllStageClearEffect>d__22))]
	// RVA: 0x180A51C Offset: 0x180651C VA: 0x180A51C
	private IEnumerator AllStageClearEffect() { }

	// RVA: 0x180A0D8 Offset: 0x18060D8 VA: 0x180A0D8
	private void UpdateAllStageScorePanel() { }

	[IteratorStateMachine(typeof(UIBlackKnightResultManager.<ChangePanelMainGame>d__24))]
	// RVA: 0x180A5B8 Offset: 0x18065B8 VA: 0x180A5B8
	private IEnumerator ChangePanelMainGame() { }

	// RVA: 0x180A638 Offset: 0x1806638 VA: 0x180A638 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x180A85C Offset: 0x180685C VA: 0x180A85C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x180AC4C Offset: 0x1806C4C VA: 0x180AC4C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x180ACCC Offset: 0x1806CCC VA: 0x180ACCC
	private void <OnClick>b__21_3() { }

	[CompilerGenerated]
	// RVA: 0x180ACEC Offset: 0x1806CEC VA: 0x180ACEC
	private void <OnClick>b__21_5() { }

	[CompilerGenerated]
	// RVA: 0x180AD0C Offset: 0x1806D0C VA: 0x180AD0C
	private void <OnClick>b__21_7() { }

	[CompilerGenerated]
	// RVA: 0x180AD2C Offset: 0x1806D2C VA: 0x180AD2C
	private void <OnClick>b__21_9() { }

	[CompilerGenerated]
	// RVA: 0x180AD4C Offset: 0x1806D4C VA: 0x180AD4C
	private void <OnClick>b__21_1() { }
}
