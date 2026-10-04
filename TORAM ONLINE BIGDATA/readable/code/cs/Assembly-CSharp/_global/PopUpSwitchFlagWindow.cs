// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpSwitchFlagWindow : PopBaseWindow // TypeDefIndex: 8823
{
	// Fields
	private int baseParam; // 0x20
	private string titleText; // 0x28
	private string[] messageTexts; // 0x30
	private string[] itemTexts; // 0x38
	private int paramNum; // 0x40
	private UnityAction<int, int> retAction; // 0x48
	private List<UICheckBoxSwitchButton> checkBoxes; // 0x50
	private int messageAction; // 0x58

	// Methods

	// RVA: 0x1E15574 Offset: 0x1E11574 VA: 0x1E15574
	public void .ctor(int baseParam, string title, string[] texts, string[] itemTexts, int paramNum, UnityAction<int, int> retAction) { }

	// RVA: 0x1E15674 Offset: 0x1E11674 VA: 0x1E15674 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E15D90 Offset: 0x1E11D90 VA: 0x1E15D90 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E15E64 Offset: 0x1E11E64 VA: 0x1E15E64
	private int GetFlagValues() { }

	// RVA: 0x1E15EF4 Offset: 0x1E11EF4 VA: 0x1E15EF4 Slot: 7
	public override int MessageCheck() { }
}
