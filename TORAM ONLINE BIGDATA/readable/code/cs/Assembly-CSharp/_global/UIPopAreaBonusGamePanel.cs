// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPopAreaBonusGamePanel : UIBasePanel // TypeDefIndex: 6178
{
	// Fields
	[SerializeField]
	private UILabel bonusLabel; // 0x30
	private TweenPosition bonusTPos; // 0x38
	private TweenAlpha bonusTAlpha; // 0x40
	private readonly UIMainManager.UIElicitFlag gameElicitFlag; // 0x48
	private readonly UIMainManager.UIElicitFlag gameResultFlag; // 0x4C
	private UIPopBaseWindow popUpWindow; // 0x50
	private InactiveTimer popUpWindowInactiveTimer; // 0x58
	private bool cancelCheck; // 0x60
	private int defMask; // 0x64
	private IBonusGameEventObservable eventSender; // 0x68
	private IBonusEventController eventController; // 0x70
	private bool isUninit; // 0x78

	// Methods

	// RVA: 0x18B19D4 Offset: 0x18AD9D4 VA: 0x18B19D4
	private void Start() { }

	// RVA: 0x18B1E90 Offset: 0x18ADE90 VA: 0x18B1E90
	private void OnDestroy() { }

	// RVA: 0x18B20D4 Offset: 0x18AE0D4 VA: 0x18B20D4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18B20E4 Offset: 0x18AE0E4 VA: 0x18B20E4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18B1D14 Offset: 0x18ADD14 VA: 0x18B1D14
	private void BonusGameStart() { }

	// RVA: 0x18B21C8 Offset: 0x18AE1C8 VA: 0x18B21C8
	private void BonusGameRewardEventMethod(RewardResponseDatav2 reward) { }

	// RVA: 0x18B2684 Offset: 0x18AE684 VA: 0x18B2684
	private void CloseReward() { }

	// RVA: 0x18B1FD8 Offset: 0x18ADFD8 VA: 0x18B1FD8
	private void Uninit() { }

	[IteratorStateMachine(typeof(UIPopAreaBonusGamePanel.<PopUpWindow>d__20))]
	// RVA: 0x18B25FC Offset: 0x18AE5FC VA: 0x18B25FC
	private IEnumerator PopUpWindow(Action callBack) { }

	// RVA: 0x18B20F4 Offset: 0x18AE0F4 VA: 0x18B20F4
	private void StartLabel() { }

	// RVA: 0x18B2744 Offset: 0x18AE744 VA: 0x18B2744
	public void .ctor() { }
}
