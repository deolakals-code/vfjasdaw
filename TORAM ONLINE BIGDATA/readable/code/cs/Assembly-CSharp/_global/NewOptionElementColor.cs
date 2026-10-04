// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementColor : NewOptionElementBase // TypeDefIndex: 7478
{
	// Fields
	private Color baseColor; // 0x40
	private Color changeColor; // 0x50
	private Color defaultColor; // 0x60
	private Action<Color> retAction; // 0x70
	private bool isTextColorUpdate; // 0x78
	private UISlider colorRSlider; // 0x80
	private UISlider colorGSlider; // 0x88
	private UISlider colorBSlider; // 0x90
	private UILabel colorRLabel; // 0x98
	private UILabel colorGLabel; // 0xA0
	private UILabel colorBLabel; // 0xA8
	private SystemTextManager systemTextManager; // 0xB0

	// Methods

	// RVA: 0x1B6634C Offset: 0x1B6234C VA: 0x1B6634C
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction, Color baseColor, Color defaultColor, bool isTextColorUpdate, Action<Color> retAction) { }

	// RVA: 0x1B66400 Offset: 0x1B62400 VA: 0x1B66400 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1B66F14 Offset: 0x1B62F14 VA: 0x1B66F14 Slot: 5
	public override void ElementUpdate() { }

	// RVA: 0x1B66E74 Offset: 0x1B62E74 VA: 0x1B66E74
	private void UpdateTextColor() { }

	// RVA: 0x1B67124 Offset: 0x1B63124 VA: 0x1B67124
	public void SetDefaultColor() { }
}
