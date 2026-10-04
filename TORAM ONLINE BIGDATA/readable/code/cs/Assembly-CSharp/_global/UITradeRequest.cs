// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITradeRequest : UITargetMenuBase // TypeDefIndex: 8104
{
	// Fields
	private bool isRequestSuccess; // 0x89
	private int targetId; // 0x8C
	private string targetName; // 0x90
	private bool isTimeUp; // 0x98
	private bool isRequestError; // 0x99
	private TradeManager tradeManager; // 0xA0

	// Methods

	// RVA: 0x1CC853C Offset: 0x1CC453C VA: 0x1CC853C
	private void Awake() { }

	// RVA: 0x1CC8708 Offset: 0x1CC4708 VA: 0x1CC8708
	private void Start() { }

	// RVA: 0x1CC8BD4 Offset: 0x1CC4BD4 VA: 0x1CC8BD4
	private void OnDestroy() { }

	// RVA: 0x1CC8C34 Offset: 0x1CC4C34 VA: 0x1CC8C34
	private void onRequest() { }

	[IteratorStateMachine(typeof(UITradeRequest.<RequestWait>d__10))]
	// RVA: 0x1CC8CE4 Offset: 0x1CC4CE4 VA: 0x1CC8CE4
	private IEnumerator RequestWait() { }

	[IteratorStateMachine(typeof(UITradeRequest.<responseWait>d__11))]
	// RVA: 0x1CC8D78 Offset: 0x1CC4D78 VA: 0x1CC8D78
	private IEnumerator responseWait() { }

	[IteratorStateMachine(typeof(UITradeRequest.<requestError>d__12))]
	// RVA: 0x1CC8E0C Offset: 0x1CC4E0C VA: 0x1CC8E0C
	private IEnumerator requestError(float time) { }

	// RVA: 0x1CC8EB0 Offset: 0x1CC4EB0 VA: 0x1CC8EB0
	public void OnRequestError() { }

	// RVA: 0x1CC9178 Offset: 0x1CC5178 VA: 0x1CC9178
	public void onAlreadyTrade() { }

	// RVA: 0x1CC943C Offset: 0x1CC543C VA: 0x1CC943C
	public void onWarrantyExistsTrade() { }

	// RVA: 0x1CC9700 Offset: 0x1CC5700 VA: 0x1CC9700
	public void onOtherError() { }

	// RVA: 0x1CC9904 Offset: 0x1CC5904 VA: 0x1CC9904
	private void onCancel() { }

	[IteratorStateMachine(typeof(UITradeRequest.<WaitRequestCancel>d__18))]
	// RVA: 0x1CC9948 Offset: 0x1CC5948 VA: 0x1CC9948
	private IEnumerator WaitRequestCancel() { }

	// RVA: 0x1CC99DC Offset: 0x1CC59DC VA: 0x1CC99DC
	public void OnCancel() { }

	// RVA: 0x1CC9BDC Offset: 0x1CC5BDC VA: 0x1CC9BDC
	private void onTrade() { }

	// RVA: 0x1CC9BE0 Offset: 0x1CC5BE0 VA: 0x1CC9BE0
	public void .ctor() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1CC9C44 Offset: 0x1CC5C44 VA: 0x1CC9C44
	private void <>n__0(Action pushFunction) { }
}
