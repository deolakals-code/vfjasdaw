// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpSliderWindow_AutoItem : PopBaseWindow // TypeDefIndex: 8821
{
	// Fields
	private string iconName; // 0x20
	private string titleText; // 0x28
	private string messageText; // 0x30
	private string messageText2; // 0x38
	private int baseParam; // 0x40
	private int changeParam; // 0x44
	private int startPercent; // 0x48
	private float percentPower; // 0x4C
	private Action<int> retAction; // 0x50
	private PlayerStatusBase playerStatus; // 0x58
	private PlayerDataManager playerDataManager; // 0x60
	private int messageAction; // 0x68
	private UISlider slider; // 0x70
	private UILabel sliderLabel; // 0x78
	private UILabel useHpLabel; // 0x80

	// Methods

	// RVA: 0x1E14A88 Offset: 0x1E10A88 VA: 0x1E14A88
	public void .ctor(string iconName, string title, string message, string message2, int baseParam, int startPercent, float percentPower, Action<int> retAction) { }

	// RVA: 0x1E14BD0 Offset: 0x1E10BD0 VA: 0x1E14BD0 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E152D0 Offset: 0x1E112D0 VA: 0x1E152D0 Slot: 5
	public override void Update() { }

	// RVA: 0x1E154B4 Offset: 0x1E114B4 VA: 0x1E154B4 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E15568 Offset: 0x1E11568 VA: 0x1E15568 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E15570 Offset: 0x1E11570 VA: 0x1E15570 Slot: 8
	public override void Close() { }
}
