// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementSlider : NewOptionElementBase // TypeDefIndex: 7482
{
	// Fields
	protected int baseParam; // 0x40
	protected int changeParam; // 0x44
	protected int startPercent; // 0x48
	protected float percentPower; // 0x4C
	protected Action<int> retAction; // 0x50
	protected UISlider slider; // 0x58
	protected UILabel sliderLabel; // 0x60

	// Methods

	// RVA: 0x1B67F54 Offset: 0x1B63F54 VA: 0x1B67F54
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, int baseParam, int startPercent, float percentPower, Action<int> retAction) { }

	// RVA: 0x1B67FB0 Offset: 0x1B63FB0 VA: 0x1B67FB0 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B68270 Offset: 0x1B64270 VA: 0x1B68270 Slot: 5
	public override void ElementUpdate() { }
}
