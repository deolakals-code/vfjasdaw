// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementSelectBar : NewOptionElementBase // TypeDefIndex: 7481
{
	// Fields
	private int baseParam; // 0x40
	private Action<int> retAction; // 0x48
	private string[] selectList; // 0x50
	private int addParam; // 0x58
	private int defaultParam; // 0x5C
	private UINewOptionSelectBar selectBar; // 0x60

	// Methods

	// RVA: 0x1B67C90 Offset: 0x1B63C90 VA: 0x1B67C90
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, int baseParam, int addParam, int defaultParam, string[] selectList, Action<int> retAction) { }

	// RVA: 0x1B67D08 Offset: 0x1B63D08 VA: 0x1B67D08 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B67E78 Offset: 0x1B63E78 VA: 0x1B67E78 Slot: 5
	public override void ElementUpdate() { }
}
