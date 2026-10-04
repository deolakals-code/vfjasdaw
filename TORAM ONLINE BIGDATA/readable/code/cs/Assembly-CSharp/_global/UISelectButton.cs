// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISelectButton : MonoBehaviour // TypeDefIndex: 9032
{
	// Fields
	[SerializeField]
	private UILabel selectLabel; // 0x20
	[SerializeField]
	private UISprite selectIcon; // 0x28
	private string[] iconList; // 0x30
	private Dictionary<int, string> sortIconList; // 0x38
	private int selectNum; // 0x40
	[CompilerGenerated]
	private int <SelectParam>k__BackingField; // 0x44
	[CompilerGenerated]
	private Action <EventValueChanged>k__BackingField; // 0x48
	private string[] selectList; // 0x50
	private int addParam; // 0x58
	private bool isReverse; // 0x5C
	private bool isPressButton; // 0x5D
	private Coroutine holdDownCoroutine; // 0x60
	private UISelectButton.SelectType selectType; // 0x68
	private int[] sortList; // 0x70
	private Dictionary<int, string> sortTextList; // 0x78

	// Properties
	public int SelectParam { get; set; }
	public Action EventValueChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9A550 Offset: 0x1E96550 VA: 0x1E9A550
	private void set_SelectParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x1E9A558 Offset: 0x1E96558 VA: 0x1E9A558
	public int get_SelectParam() { }

	[CompilerGenerated]
	// RVA: 0x1E9A560 Offset: 0x1E96560 VA: 0x1E9A560
	public Action get_EventValueChanged() { }

	[CompilerGenerated]
	// RVA: 0x1E9A568 Offset: 0x1E96568 VA: 0x1E9A568
	private void set_EventValueChanged(Action value) { }

	// RVA: 0x1E9A570 Offset: 0x1E96570 VA: 0x1E9A570
	public void Initialize(int selectParam, int add, string[] list, Action eventValueChanged) { }

	// RVA: 0x1E9A7D4 Offset: 0x1E967D4 VA: 0x1E9A7D4
	public void Initialize(int selectParam, int add, string[] list, bool isReverse) { }

	// RVA: 0x1E9A7E4 Offset: 0x1E967E4 VA: 0x1E9A7E4
	public void Initialize(int selectParam, int add, int[] sortList, Dictionary<int, string> sortTextList) { }

	// RVA: 0x1E9A83C Offset: 0x1E9683C VA: 0x1E9A83C
	public void Initialize(int selectParam, int add, string[] list, string[] iconList, Action eventValueChanged) { }

	// RVA: 0x1E9A88C Offset: 0x1E9688C VA: 0x1E9A88C
	public void Initialize(int selectParam, int add, int[] sortList, Dictionary<int, string> sortTextList, Dictionary<int, string> sortIconList) { }

	// RVA: 0x1E9A8DC Offset: 0x1E968DC VA: 0x1E9A8DC
	private void AddButton() { }

	// RVA: 0x1E9A9F0 Offset: 0x1E969F0 VA: 0x1E9A9F0
	private void SubButton() { }

	// RVA: 0x1E9A658 Offset: 0x1E96658 VA: 0x1E9A658
	private void UpdateText() { }

	// RVA: 0x1E9AB04 Offset: 0x1E96B04 VA: 0x1E9AB04
	private void UpdateIcon() { }

	// RVA: 0x1E9AC64 Offset: 0x1E96C64 VA: 0x1E9AC64
	public UILabel GetSelectLabel() { }

	// RVA: 0x1E9AC6C Offset: 0x1E96C6C VA: 0x1E9AC6C
	private void PressAddButton() { }

	// RVA: 0x1E9ADAC Offset: 0x1E96DAC VA: 0x1E9ADAC
	private void PressSubButton() { }

	// RVA: 0x1E9AE64 Offset: 0x1E96E64 VA: 0x1E9AE64
	private void ReleaseButton() { }

	[IteratorStateMachine(typeof(UISelectButton.<HoldDownButtonAction>d__35))]
	// RVA: 0x1E9AD24 Offset: 0x1E96D24 VA: 0x1E9AD24
	private IEnumerator HoldDownButtonAction(Action action) { }

	// RVA: 0x1E9AEC8 Offset: 0x1E96EC8 VA: 0x1E9AEC8
	public void .ctor() { }
}
