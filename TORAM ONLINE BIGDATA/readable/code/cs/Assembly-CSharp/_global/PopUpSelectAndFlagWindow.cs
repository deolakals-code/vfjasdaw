// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpSelectAndFlagWindow : PopBaseWindow // TypeDefIndex: 8812
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private string checkBoxText; // 0x30
	private int baseParam; // 0x38
	private Action<int, bool> retAction; // 0x40
	private string[] selectList; // 0x48
	private int addParam; // 0x50
	private bool checkBoxFlag; // 0x54
	private int messageAction; // 0x58
	private UISelectButton selectButton; // 0x60
	private UIToggle checkBox; // 0x68

	// Methods

	// RVA: 0x1E12F08 Offset: 0x1E0EF08 VA: 0x1E12F08
	public void .ctor(string title, string message, int baseParam, int add, string[] selectList, string checkBoxText, bool checkBoxFlag, Action<int, bool> retAction) { }

	// RVA: 0x1E13040 Offset: 0x1E0F040 VA: 0x1E13040 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E134A0 Offset: 0x1E0F4A0 VA: 0x1E134A0 Slot: 5
	public override void Update() { }

	// RVA: 0x1E134A4 Offset: 0x1E0F4A4 VA: 0x1E134A4 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E13584 Offset: 0x1E0F584 VA: 0x1E13584 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E1358C Offset: 0x1E0F58C VA: 0x1E1358C Slot: 8
	public override void Close() { }
}
