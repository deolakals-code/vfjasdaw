// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPlayerMenuManager : UIBaseMenuPanel // TypeDefIndex: 8208
{
	// Fields
	[SerializeField]
	private GameObject cookingBufferButton; // 0x80
	[SerializeField]
	private UILabel cookingBufferLabel; // 0x88
	private float cookingBufferTimer; // 0x90
	private string cookingBufferTimerLocalize; // 0x98
	[SerializeField]
	private GameObject cookingBufferWindowPanel; // 0xA0
	[SerializeField]
	private UILabel popupWindowCookingBufferTimerLabel; // 0xA8
	[SerializeField]
	private UILabel popupWindowCookingBufferEffectLabel; // 0xB0
	private int styleButtonId; // 0xB8
	private int fishButtonId; // 0xBC

	// Methods

	// RVA: 0x1CF30C4 Offset: 0x1CEF0C4 VA: 0x1CF30C4
	private void Awake() { }

	// RVA: 0x1CF374C Offset: 0x1CEF74C VA: 0x1CF374C Slot: 7
	protected override void Start() { }

	// RVA: 0x1CF38D0 Offset: 0x1CEF8D0 VA: 0x1CF38D0
	private void Update() { }

	// RVA: 0x1CF39C4 Offset: 0x1CEF9C4 VA: 0x1CF39C4 Slot: 10
	protected override GameObject SetButton(string text, float y, int id, UIBaseMenuPanel.SystemLockType lockFlag) { }

	// RVA: 0x1CF3A10 Offset: 0x1CEFA10 VA: 0x1CF3A10 Slot: 13
	protected override PopUpMessageWindow AdviceMessageData() { }

	// RVA: 0x1CF3DE0 Offset: 0x1CEFDE0 VA: 0x1CF3DE0 Slot: 14
	protected override void AdviceMessageButton() { }

	// RVA: 0x1CF3E4C Offset: 0x1CEFE4C VA: 0x1CF3E4C Slot: 11
	protected override void OnClickButton(int id) { }

	[IteratorStateMachine(typeof(UIPlayerMenuManager.<OnRecreate>d__17))]
	// RVA: 0x1CF3F8C Offset: 0x1CEFF8C VA: 0x1CF3F8C
	private IEnumerator OnRecreate() { }

	// RVA: 0x1CF3644 Offset: 0x1CEF644 VA: 0x1CF3644
	private bool CheckPartnerAdvice(PlayerDataManager playerData) { }

	// RVA: 0x1CF4020 Offset: 0x1CF0020 VA: 0x1CF4020
	public void OnCookingBuffer() { }

	[IteratorStateMachine(typeof(UIPlayerMenuManager.<PopUpCookingBufferMessage>d__20))]
	// RVA: 0x1CF40DC Offset: 0x1CF00DC VA: 0x1CF40DC
	private IEnumerator PopUpCookingBufferMessage() { }

	// RVA: 0x1CF4170 Offset: 0x1CF0170 VA: 0x1CF4170
	public void .ctor() { }
}
