// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScriptPopTimerWindow : UIBasePanel // TypeDefIndex: 6413
{
	// Fields
	[SerializeField]
	private GameObject panelObject; // 0x30
	[SerializeField]
	private GameObject panelWindow; // 0x38
	private UIForwardEvents panelWindowEvent; // 0x40
	[SerializeField]
	private UILabel titleLabel; // 0x48
	[SerializeField]
	private UILabel messageLabel; // 0x50
	[SerializeField]
	private UILabel leftButtonLabel; // 0x58
	[SerializeField]
	private UILabel rightButtonLabel; // 0x60
	[SerializeField]
	private UISprite timerBar; // 0x68
	[SerializeField]
	private UISprite reverseTimerBar; // 0x70
	[SerializeField]
	private UISprite backColor; // 0x78
	private int endSCEvent; // 0x80
	private int leftSCEvent; // 0x84
	private int rightSCEvent; // 0x88
	private int bitFlag; // 0x8C
	private float timerValue; // 0x90
	private int addTimerValue; // 0x94
	private int maxTimerValue; // 0x98
	private bool isEndEvent; // 0x9C

	// Properties
	public int TimerValue { get; set; }
	public bool IsCameraControl { get; }

	// Methods

	// RVA: 0x192A2E8 Offset: 0x19262E8 VA: 0x192A2E8
	public void set_TimerValue(int value) { }

	// RVA: 0x192A39C Offset: 0x192639C VA: 0x192A39C
	public int get_TimerValue() { }

	// RVA: 0x192A3BC Offset: 0x19263BC VA: 0x192A3BC
	public bool get_IsCameraControl() { }

	// RVA: 0x192A3C8 Offset: 0x19263C8 VA: 0x192A3C8
	public void Initialize(int addTimerValue, int maxTimerValue, string title, string message, string leftButtonText, string rightButtonText, int leftButtonEvent, int rightButtonEvent, int endEvent, byte alpha, int flag) { }

	// RVA: 0x192A5D4 Offset: 0x19265D4 VA: 0x192A5D4
	private void Update() { }

	// RVA: 0x192A314 Offset: 0x1926314 VA: 0x192A314
	private void UpdateTimerBar() { }

	// RVA: 0x192A648 Offset: 0x1926648 VA: 0x192A648
	private void OnWindowButton(int param) { }

	// RVA: 0x192A6E4 Offset: 0x19266E4 VA: 0x192A6E4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x192A6E8 Offset: 0x19266E8 VA: 0x192A6E8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x192A6EC Offset: 0x19266EC VA: 0x192A6EC
	public void .ctor() { }
}
