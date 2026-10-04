// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpColorWindow : PopBaseWindow // TypeDefIndex: 8782
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private Color baseColor; // 0x30
	private Color changeColor; // 0x40
	private Action<Color> retAction; // 0x50
	private int messageAction; // 0x58
	private UISlider colorRSlider; // 0x60
	private UISlider colorGSlider; // 0x68
	private UISlider colorBSlider; // 0x70

	// Methods

	// RVA: 0x1E0AB08 Offset: 0x1E06B08 VA: 0x1E0AB08
	public void .ctor(string title, string message, Color baseColor, Action<Color> retAction) { }

	// RVA: 0x1E0ABFC Offset: 0x1E06BFC VA: 0x1E0ABFC Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0B008 Offset: 0x1E07008 VA: 0x1E0B008 Slot: 5
	public override void Update() { }

	// RVA: 0x1E0B058 Offset: 0x1E07058 VA: 0x1E0B058 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0B114 Offset: 0x1E07114 VA: 0x1E0B114 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E0B11C Offset: 0x1E0711C VA: 0x1E0B11C Slot: 8
	public override void Close() { }
}
