// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementFlag : NewOptionElementBase // TypeDefIndex: 7479
{
	// Fields
	private int baseParam; // 0x40
	private string onText; // 0x48
	private string offText; // 0x50
	private Action<int> retAction; // 0x58
	private UIToggle checkBox; // 0x60
	private bool isSwitch; // 0x68
	private UICheckBoxSwitchButton leftCheckBox; // 0x70

	// Methods

	// RVA: 0x1B67170 Offset: 0x1B63170 VA: 0x1B67170
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, int baseParam, string onText, string offText, Action<int> retAction) { }

	// RVA: 0x1B67270 Offset: 0x1B63270 VA: 0x1B67270 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B675DC Offset: 0x1B635DC VA: 0x1B675DC Slot: 5
	public override void ElementUpdate() { }
}
