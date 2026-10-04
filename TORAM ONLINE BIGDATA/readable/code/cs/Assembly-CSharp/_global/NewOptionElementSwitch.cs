// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementSwitch : NewOptionElementBase // TypeDefIndex: 7484
{
	// Fields
	protected int baseParam; // 0x40
	protected Action<int> retAction; // 0x48
	protected string[] selectList; // 0x50
	protected int addParam; // 0x58
	protected UISelectButton selectButton; // 0x60

	// Methods

	// RVA: 0x1B68978 Offset: 0x1B64978 VA: 0x1B68978
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, int baseParam, int add, string[] selectList, Action<int> retAction) { }

	// RVA: 0x1B689D8 Offset: 0x1B649D8 VA: 0x1B689D8 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B68B74 Offset: 0x1B64B74 VA: 0x1B68B74 Slot: 5
	public override void ElementUpdate() { }
}
