// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DivingInfoPanel : UIBasePanel // TypeDefIndex: 6297
{
	// Fields
	[SerializeField]
	private StaminaController stamina_controller; // 0x30
	[SerializeField]
	private UILabel timer_label; // 0x38
	[SerializeField]
	private StockUIControllerLabel[] item_stoks; // 0x40
	[SerializeField]
	private UILabel point_label; // 0x48
	[SerializeField]
	private GameObject popPanel; // 0x50
	[SerializeField]
	private GameObject staminaPanel; // 0x58
	[SerializeField]
	private GameObject seaPointPanel; // 0x60
	[SerializeField]
	private GameObject bossPanel; // 0x68
	[SerializeField]
	private GameObject bossTimerPanel; // 0x70
	[SerializeField]
	private UILabel bossTimerLabel; // 0x78
	[SerializeField]
	private GameObject bossBattlePanel; // 0x80
	private string staminaTimerLocalize; // 0x88
	private string bossTimerLocalize; // 0x90
	private bool isCheckBossResult; // 0x98
	private SummerEventData _event_data; // 0xA0
	private float updateTimer; // 0xA8
	private int returnCode; // 0xAC
	private bool isConnectWait; // 0xB0
	private bool isRewardPop; // 0xB1
	private bool isInit; // 0xB2

	// Methods

	// RVA: 0x18E03A4 Offset: 0x18DC3A4 VA: 0x18E03A4
	private void Awake() { }

	[IteratorStateMachine(typeof(DivingInfoPanel.<Start>d__21))]
	// RVA: 0x18E048C Offset: 0x18DC48C VA: 0x18E048C
	private IEnumerator Start() { }

	// RVA: 0x18E0520 Offset: 0x18DC520 VA: 0x18E0520
	private void Update() { }

	// RVA: 0x18E06E4 Offset: 0x18DC6E4 VA: 0x18E06E4
	public void OnBossChangeButton() { }

	// RVA: 0x18E071C Offset: 0x18DC71C VA: 0x18E071C
	public void OnStaminaChangeButton() { }

	// RVA: 0x18E0754 Offset: 0x18DC754 VA: 0x18E0754
	public void PopRewardWindow(int code) { }

	// RVA: 0x18E07E8 Offset: 0x18DC7E8 VA: 0x18E07E8
	private void ReceiveGetEventGetEvent(int code) { }

	[IteratorStateMachine(typeof(DivingInfoPanel.<ConnectWait>d__27))]
	// RVA: 0x18E07F4 Offset: 0x18DC7F4 VA: 0x18E07F4
	private IEnumerator ConnectWait() { }

	// RVA: 0x18E0888 Offset: 0x18DC888 VA: 0x18E0888 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18E0928 Offset: 0x18DC928 VA: 0x18E0928 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18E09AC Offset: 0x18DC9AC VA: 0x18E09AC
	public void .ctor() { }
}
