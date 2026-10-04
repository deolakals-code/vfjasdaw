// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpBitCheckBoxWindow : PopBaseWindow // TypeDefIndex: 8778
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private int baseParam; // 0x30
	private string[] selectCheckBoxText; // 0x38
	private UIToggle[] checkBox; // 0x40
	private Vector2[] checkBoxPosition; // 0x48
	private Action<int> retAction; // 0x50
	private GameObject checkBoxBase; // 0x58
	private int messageAction; // 0x60

	// Methods

	// RVA: 0x1E09FC4 Offset: 0x1E05FC4 VA: 0x1E09FC4
	public void .ctor(string title, string message, int baseParam, Action<int> retAction, string[] selectCheckBox, Vector2[] checkBoxPos, GameObject checkBox) { }

	// RVA: 0x1E09FF0 Offset: 0x1E05FF0 VA: 0x1E09FF0
	public void .ctor(string title, string message, int baseParam, Action<int> retAction, string[] selectCheckBox, Vector2[] checkBoxPos) { }

	// RVA: 0x1E0A11C Offset: 0x1E0611C VA: 0x1E0A11C Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0A564 Offset: 0x1E06564 VA: 0x1E0A564 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0A630 Offset: 0x1E06630 VA: 0x1E0A630
	public int GetBitFlag() { }

	// RVA: 0x1E0A6A8 Offset: 0x1E066A8 VA: 0x1E0A6A8 Slot: 7
	public override int MessageCheck() { }
}
