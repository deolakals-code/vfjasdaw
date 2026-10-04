// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShoppingBuyController : SummerEventPanelBase // TypeDefIndex: 6325
{
	// Fields
	private readonly float WAIT_TIME; // 0x30
	[SerializeField]
	private UISprite ItemSprite; // 0x38
	[SerializeField]
	private UILabel ItemName; // 0x40
	[SerializeField]
	private UILabel ItemMes; // 0x48
	[SerializeField]
	private StockUIControllerLabel StokLabel; // 0x50
	[SerializeField]
	private UILabel ValuedRot; // 0x58
	[SerializeField]
	private GameObject SummaryPlusButtonRoot; // 0x60
	[SerializeField]
	private UILabel HaveSpina; // 0x68
	[SerializeField]
	private UILabel UseSpina; // 0x70
	[SerializeField]
	private UIImageButton BuyButton; // 0x78
	[SerializeField]
	private UILabel BuyButtonLabel; // 0x80
	[SerializeField]
	private SummerEventPanelBase DialogDisplay; // 0x88
	private int cost; // 0x90
	private int have_spina; // 0x94
	private ShoppingPanel.ShoppingPanelState display_state; // 0x98
	private SummerEventData event_data; // 0xA0
	private SystemTextManager systemTextManager; // 0xA8
	private GameObject loading_model; // 0xB0
	private float latency; // 0xB8
	private bool is_waiting_recv; // 0xBC
	private int minimumBuy; // 0xC0
	private DecStockUIController decStockUIController; // 0xC8

	// Methods

	// RVA: 0x18E834C Offset: 0x18E434C VA: 0x18E834C Slot: 4
	public override void ChangeState() { }

	// RVA: 0x18E8350 Offset: 0x18E4350 VA: 0x18E8350 Slot: 5
	public override void Open(Action<int> _change_state_callback) { }

	// RVA: 0x18E8354 Offset: 0x18E4354 VA: 0x18E8354 Slot: 6
	public override void Open(Action<int> _change_state_callback, int _add_info) { }

	// RVA: 0x18E88D8 Offset: 0x18E48D8 VA: 0x18E88D8
	private void onClickBuyButton() { }

	// RVA: 0x18E88DC Offset: 0x18E48DC VA: 0x18E88DC
	private void send_data() { }

	[IteratorStateMachine(typeof(ShoppingBuyController.<recv_timer>d__27))]
	// RVA: 0x18E8B04 Offset: 0x18E4B04 VA: 0x18E8B04
	private IEnumerator recv_timer() { }

	// RVA: 0x18E8B98 Offset: 0x18E4B98 VA: 0x18E8B98
	private void recv_buydata(int _result) { }

	// RVA: 0x18E8E70 Offset: 0x18E4E70 VA: 0x18E8E70
	private string get_buy_item_name() { }

	// RVA: 0x18E8F94 Offset: 0x18E4F94 VA: 0x18E8F94
	private string item_unit_name() { }

	// RVA: 0x18E9068 Offset: 0x18E5068 VA: 0x18E9068
	private void close_dialog(int _no_data) { }

	// RVA: 0x18E8634 Offset: 0x18E4634 VA: 0x18E8634
	private void InitalizeSetting() { }

	// RVA: 0x18E90A8 Offset: 0x18E50A8 VA: 0x18E90A8
	private void setting_arrow_display(int _item_num) { }

	// RVA: 0x18E9284 Offset: 0x18E5284 VA: 0x18E9284
	private void setting_drink_display(int _item_num) { }

	// RVA: 0x18E943C Offset: 0x18E543C VA: 0x18E943C
	private void setting_kick_display(int _item_num) { }

	// RVA: 0x18E95F4 Offset: 0x18E55F4 VA: 0x18E95F4
	private void setting_mascle_display(int _item_num) { }

	// RVA: 0x18E97AC Offset: 0x18E57AC VA: 0x18E97AC
	private void setting_common_display() { }

	// RVA: 0x18E8740 Offset: 0x18E4740 VA: 0x18E8740
	private void change_button_diplay() { }

	// RVA: 0x18E9814 Offset: 0x18E5814 VA: 0x18E9814
	private string AddInfomationCanma(int _num) { }

	// RVA: 0x18E9894 Offset: 0x18E5894 VA: 0x18E9894
	private void OnClickOneIncrement() { }

	// RVA: 0x18E98BC Offset: 0x18E58BC VA: 0x18E98BC
	private void OnClickOneDecrement() { }

	// RVA: 0x18E98E4 Offset: 0x18E58E4 VA: 0x18E98E4
	private void OnClickMaxIncrement() { }

	// RVA: 0x18E8814 Offset: 0x18E4814 VA: 0x18E8814
	private void updateChangeTextValue() { }

	// RVA: 0x18E990C Offset: 0x18E590C VA: 0x18E990C Slot: 9
	public override void OnLeftTopButtonPush() { }

	// RVA: 0x18E9954 Offset: 0x18E5954 VA: 0x18E9954
	public void .ctor() { }
}
