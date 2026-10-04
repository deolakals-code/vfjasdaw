// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementBitCheck : NewOptionElementBase // TypeDefIndex: 7477
{
	// Fields
	private int bitParam; // 0x40
	private string[] textList; // 0x48
	private Vector2[] position; // 0x50
	private UIToggle[] checkBox; // 0x58
	private Action<int> retAction; // 0x60

	// Methods

	// RVA: 0x1B65F84 Offset: 0x1B61F84 VA: 0x1B65F84
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, int bitParam, string[] textList, Vector2[] position, Action<int> retAction) { }

	// RVA: 0x1B65FE8 Offset: 0x1B61FE8 VA: 0x1B65FE8 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B66254 Offset: 0x1B62254 VA: 0x1B66254 Slot: 5
	public override void ElementUpdate() { }

	// RVA: 0x1B662D4 Offset: 0x1B622D4 VA: 0x1B662D4
	private int GetBitFlag() { }
}
