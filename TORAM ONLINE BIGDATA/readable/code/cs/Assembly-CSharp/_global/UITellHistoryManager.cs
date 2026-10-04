// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITellHistoryManager : UIBasePanel // TypeDefIndex: 8215
{
	// Fields
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject windowPanelObj; // 0x38
	[SerializeField]
	private GameObject tellElement; // 0x40
	[SerializeField]
	private GameObject optionElement; // 0x48
	[SerializeField]
	private GameObject deleteOptionElement; // 0x50
	private ChatManager chatManager; // 0x58
	private int lineCountData; // 0x60
	private const int lineCountOptionMax = 4;
	private UILabel lineCountOptionLabel; // 0x68
	private Dictionary<int, TellHistoryData> tellHistoryOpenDataList; // 0x70
	private bool isShortcutOpen; // 0x78
	private int deleteTimeData; // 0x7C
	private const int deleteTimeOptionMax = 3;
	private UILabel deleteOptionLabel; // 0x80

	// Methods

	// RVA: 0x1CF8430 Offset: 0x1CF4430 VA: 0x1CF8430
	public void ReturnHistoryWindow() { }

	// RVA: 0x1CF85DC Offset: 0x1CF45DC VA: 0x1CF85DC
	private void Start() { }

	// RVA: 0x1CF8844 Offset: 0x1CF4844 VA: 0x1CF8844
	private void Update() { }

	// RVA: 0x1CF8848 Offset: 0x1CF4848 VA: 0x1CF8848
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UITellHistoryManager.<CreateScrollWindow>d__18))]
	// RVA: 0x1CF87D8 Offset: 0x1CF47D8 VA: 0x1CF87D8
	private IEnumerator CreateScrollWindow() { }

	// RVA: 0x1CF88B0 Offset: 0x1CF48B0 VA: 0x1CF88B0
	private void UpdateOptionText() { }

	// RVA: 0x1CF8994 Offset: 0x1CF4994 VA: 0x1CF8994
	private void UpdateDeleteOptionText() { }

	// RVA: 0x1CF84CC Offset: 0x1CF44CC VA: 0x1CF84CC
	private void DestroyShortcutPanel() { }

	// RVA: 0x1CF8A78 Offset: 0x1CF4A78 VA: 0x1CF8A78
	private void OnSelectTellName(int id) { }

	// RVA: 0x1CF8CE8 Offset: 0x1CF4CE8 VA: 0x1CF8CE8
	private void OnLeftOption() { }

	// RVA: 0x1CF8D04 Offset: 0x1CF4D04 VA: 0x1CF8D04
	private void OnRightOption() { }

	// RVA: 0x1CF8D1C Offset: 0x1CF4D1C VA: 0x1CF8D1C
	private void OnDeleteHistory(int id) { }

	// RVA: 0x1CF8D54 Offset: 0x1CF4D54 VA: 0x1CF8D54
	private void OnLeftDeleteOption() { }

	// RVA: 0x1CF8D70 Offset: 0x1CF4D70 VA: 0x1CF8D70
	private void OnRightDeleteOption() { }

	// RVA: 0x1CF8D88 Offset: 0x1CF4D88 VA: 0x1CF8D88 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CF8E54 Offset: 0x1CF4E54 VA: 0x1CF8E54 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CF8EC4 Offset: 0x1CF4EC4 VA: 0x1CF8EC4
	public void .ctor() { }
}
