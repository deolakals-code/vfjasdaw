// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRecruitItemResponsePanel : UIBasePanel // TypeDefIndex: 9021
{
	// Fields
	private UIRecruitItemResponsePanel.PanelState panelState; // 0x2C
	[SerializeField]
	private GameObject windowPanel; // 0x30
	[SerializeField]
	private GameObject titleObj; // 0x38
	private UISprite titleIcon; // 0x40
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private UILabel mainLabel; // 0x50
	[SerializeField]
	private GameObject goldObj; // 0x58
	[SerializeField]
	private UILabel goldLabel; // 0x60
	[SerializeField]
	private GameObject inputGoldObj; // 0x68
	[SerializeField]
	private UILabel inputGoldLabel; // 0x70
	[SerializeField]
	private UISlider loadSlider; // 0x78
	[SerializeField]
	private GameObject attentionObj; // 0x80
	[SerializeField]
	private UILabel attentionLabel; // 0x88
	[SerializeField]
	private UIImageButton buttonObj; // 0x90
	private UILabel buttonLabel; // 0x98
	private UIButtonColor buttonColor; // 0xA0
	private UISprite buttonSprite; // 0xA8
	private PlayerDataManager playerDataManager; // 0xB0
	private OtherPlayer targetOtherPlayer; // 0xB8
	private ArchetypeUid targetArchetypeUid; // 0xC0
	private SignboardPropertyData boardData; // 0xC8
	private int needItemId; // 0xD0
	private int rewardGold; // 0xD4
	private ItemTextManager itemTextManager; // 0xD8
	private string inputGold; // 0xE0
	private Regex numRegex; // 0xE8
	private Coroutine loadCoroutine; // 0xF0
	private UIPopWindow popWindow; // 0xF8

	// Methods

	// RVA: 0x1E93D18 Offset: 0x1E8FD18 VA: 0x1E93D18
	public void Initialize(GameObject targetObj) { }

	// RVA: 0x1E94804 Offset: 0x1E90804 VA: 0x1E94804
	private void Update() { }

	// RVA: 0x1E94F08 Offset: 0x1E90F08 VA: 0x1E94F08
	private void OnDestroy() { }

	// RVA: 0x1E94F0C Offset: 0x1E90F0C VA: 0x1E94F0C
	private void ClosePopWindow() { }

	// RVA: 0x1E94E78 Offset: 0x1E90E78 VA: 0x1E94E78
	private bool IsNumber(string text) { }

	// RVA: 0x1E94F90 Offset: 0x1E90F90 VA: 0x1E94F90
	private void OpenInputWindow() { }

	// RVA: 0x1E952CC Offset: 0x1E912CC VA: 0x1E952CC
	private void OpenWaitWindow() { }

	// RVA: 0x1E95618 Offset: 0x1E91618 VA: 0x1E95618
	private void OpenEndWindow() { }

	// RVA: 0x1E94B94 Offset: 0x1E90B94 VA: 0x1E94B94
	private void OpenStopWindow(string addErrText = "") { }

	// RVA: 0x1E944C0 Offset: 0x1E904C0 VA: 0x1E944C0
	private void SetTitle(string text, string spriteName) { }

	// RVA: 0x1E94600 Offset: 0x1E90600 VA: 0x1E94600
	private void SetButton(string text, bool green) { }

	// RVA: 0x1E958BC Offset: 0x1E918BC VA: 0x1E958BC
	private void onClick() { }

	[IteratorStateMachine(typeof(UIRecruitItemResponsePanel.<LoadBar>d__41))]
	// RVA: 0x1E9559C Offset: 0x1E9159C VA: 0x1E9559C
	private IEnumerator LoadBar(float seconds) { }

	[IteratorStateMachine(typeof(UIRecruitItemResponsePanel.<ExecuteSignBoard>d__42))]
	// RVA: 0x1E959BC Offset: 0x1E919BC VA: 0x1E959BC
	private IEnumerator ExecuteSignBoard() { }

	// RVA: 0x1E95A50 Offset: 0x1E91A50 VA: 0x1E95A50 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1E95AFC Offset: 0x1E91AFC VA: 0x1E95AFC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1E95BA0 Offset: 0x1E91BA0 VA: 0x1E95BA0
	public void .ctor() { }
}
