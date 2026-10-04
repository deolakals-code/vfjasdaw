// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpSliderWindow : PopBaseWindow // TypeDefIndex: 8819
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private int baseParam; // 0x30
	private int changeParam; // 0x34
	private int startPercent; // 0x38
	private float percentPower; // 0x3C
	private Action<int> retAction; // 0x40
	private int messageAction; // 0x48
	private UISlider slider; // 0x50
	private UILabel sliderLabel; // 0x58

	// Methods

	// RVA: 0x1E143B8 Offset: 0x1E103B8 VA: 0x1E143B8
	public void .ctor(string title, string message, int baseParam, int startPercent, float percentPower, Action<int> retAction) { }

	// RVA: 0x1E144A4 Offset: 0x1E104A4 VA: 0x1E144A4 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E148CC Offset: 0x1E108CC VA: 0x1E148CC Slot: 5
	public override void Update() { }

	// RVA: 0x1E149C8 Offset: 0x1E109C8 VA: 0x1E149C8 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E14A7C Offset: 0x1E10A7C VA: 0x1E14A7C Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E14A84 Offset: 0x1E10A84 VA: 0x1E14A84 Slot: 8
	public override void Close() { }
}
