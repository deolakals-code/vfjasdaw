// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRequest : UITargetMenuBase // TypeDefIndex: 8078
{
	// Fields
	[SerializeField]
	private GameObject inputMessageObject; // 0x90
	[SerializeField]
	private UILabel inputLabel; // 0x98
	[SerializeField]
	private TweenColor tweenColor; // 0xA0
	private PlayerDataManager playerDataManager; // 0xA8
	private bool isRequestSuccess; // 0xB0
	private int targetId; // 0xB4
	private string targetName; // 0xB8
	private bool isRecruitErr; // 0xC0

	// Methods

	// RVA: 0x1CBD00C Offset: 0x1CB900C VA: 0x1CBD00C
	private void Awake() { }

	// RVA: 0x1CBD3B8 Offset: 0x1CB93B8 VA: 0x1CBD3B8
	private void Start() { }

	// RVA: 0x1CBD5FC Offset: 0x1CB95FC VA: 0x1CBD5FC
	private void OnWindowOpen() { }

	// RVA: 0x1CBD61C Offset: 0x1CB961C VA: 0x1CBD61C
	public void OnSubmit() { }

	// RVA: 0x1CBD710 Offset: 0x1CB9710 VA: 0x1CBD710
	private void OnRequest() { }

	[IteratorStateMachine(typeof(UIPartyRequest.<responseWait>d__13))]
	// RVA: 0x1CBDC04 Offset: 0x1CB9C04 VA: 0x1CBDC04
	private IEnumerator responseWait() { }

	// RVA: 0x1CBDA18 Offset: 0x1CB9A18 VA: 0x1CBDA18
	private void setRequestError() { }

	// RVA: 0x1CBDC98 Offset: 0x1CB9C98 VA: 0x1CBDC98
	private void setAlreadyOtherParty() { }

	// RVA: 0x1CBDE98 Offset: 0x1CB9E98 VA: 0x1CBDE98
	private void setNotReceiveError() { }

	// RVA: 0x1CBE098 Offset: 0x1CBA098 VA: 0x1CBE098
	private void AlreadyRunningError() { }

	// RVA: 0x1CBE278 Offset: 0x1CBA278 VA: 0x1CBE278
	private void onSuccessRequest() { }

	// RVA: 0x1CBD334 Offset: 0x1CB9334 VA: 0x1CBD334
	private void changeUI() { }

	// RVA: 0x1CBE27C Offset: 0x1CBA27C VA: 0x1CBE27C
	private void OnClose() { }

	// RVA: 0x1CBE388 Offset: 0x1CBA388 VA: 0x1CBE388 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CBE408 Offset: 0x1CBA408 VA: 0x1CBE408
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1CBE46C Offset: 0x1CBA46C VA: 0x1CBE46C
	private void <OnRequest>b__12_0() { }
}
