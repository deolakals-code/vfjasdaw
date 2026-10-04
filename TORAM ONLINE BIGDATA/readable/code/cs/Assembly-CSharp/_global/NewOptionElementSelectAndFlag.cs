// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementSelectAndFlag : NewOptionElementBase // TypeDefIndex: 7480
{
	// Fields
	private string checkBoxText; // 0x40
	private int baseParam; // 0x48
	private Action<int, bool> retAction; // 0x50
	private string[] selectList; // 0x58
	private int addParam; // 0x60
	private bool checkBoxFlag; // 0x64
	private int defaultParam; // 0x68
	private UIToggle checkBox; // 0x70
	private UINewOptionSelectBar selectBar; // 0x78

	// Methods

	// RVA: 0x1B676E4 Offset: 0x1B636E4 VA: 0x1B676E4
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, int baseParam, int defaultParam, int add, string[] selectList, string checkBoxText, bool checkBoxFlag, Action<int, bool> retAction) { }

	// RVA: 0x1B677F4 Offset: 0x1B637F4 VA: 0x1B677F4 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B67B88 Offset: 0x1B63B88 VA: 0x1B67B88 Slot: 5
	public override void ElementUpdate() { }
}
