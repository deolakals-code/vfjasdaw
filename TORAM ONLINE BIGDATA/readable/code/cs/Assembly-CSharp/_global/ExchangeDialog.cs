// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExchangeDialog : MonoBehaviour // TypeDefIndex: 6306
{
	// Fields
	[SerializeField]
	private UISprite ItemSprite; // 0x20
	[SerializeField]
	private UILabel BaseLabel; // 0x28
	[SerializeField]
	private UILabel UseLabel; // 0x30
	[SerializeField]
	private UILabel AfterLabel; // 0x38
	[SerializeField]
	private UILabel ItemName; // 0x40
	[SerializeField]
	private UILabel ItemVolume; // 0x48
	[SerializeField]
	private UILabel ProsessionPointLabel; // 0x50
	[SerializeField]
	private UILabel HaveTotalLabel; // 0x58
	[SerializeField]
	private UILabel AfterShoppingLabel; // 0x60
	[SerializeField]
	private UILabel warningMessageLabel; // 0x68
	[SerializeField]
	private GameObject[] currentButtons; // 0x70
	private Action<int> action; // 0x78
	private int limitCount; // 0x80
	private int currentCount; // 0x84
	private int have_total; // 0x88
	private int procession_point; // 0x8C
	private string value_unit; // 0x90
	private int item_volume; // 0x98

	// Methods

	// RVA: 0x18E3A78 Offset: 0x18DFA78 VA: 0x18E3A78
	public void SetInfomation(int _procession_point, int _have_total, Action<int> _action) { }

	// RVA: 0x18E3CB4 Offset: 0x18DFCB4 VA: 0x18E3CB4
	public void SetInfomation(int _have_total, int _procession_point, int _limitCount, string baseLabel, string afterLabel, string useLabel, string warningMessage, Action<int> _action) { }

	// RVA: 0x18E3F14 Offset: 0x18DFF14 VA: 0x18E3F14
	public void SetItemInfomation(string _sprite_name, string _item_name, int _item_volume, string _value_unit) { }

	// RVA: 0x18E3FB4 Offset: 0x18DFFB4 VA: 0x18E3FB4
	private void OnExchangeDecide() { }

	// RVA: 0x18E3D88 Offset: 0x18DFD88 VA: 0x18E3D88
	private void updateCurrentCountView() { }

	// RVA: 0x18E3FD4 Offset: 0x18DFFD4 VA: 0x18E3FD4
	public void OnClick_UpdateCurrentCount(int add) { }

	// RVA: 0x18E4004 Offset: 0x18E0004 VA: 0x18E4004
	public void .ctor() { }
}
