// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralStoreDialog : MonoBehaviour // TypeDefIndex: 8331
{
	// Fields
	[SerializeField]
	public int ItemId; // 0x20
	private ItemData[] ItemDatas; // 0x28
	[SerializeField]
	private ItemIcon ItemNameLabel; // 0x30
	[SerializeField]
	private UILabel BuyCountLabel; // 0x38
	[SerializeField]
	private UILabel PossessionSpinaLabel; // 0x40
	[SerializeField]
	private UILabel TotalLabel; // 0x48
	[SerializeField]
	private GeneralStoreCompleteDialog CompleteDialog; // 0x50
	[SerializeField]
	private UILabel ButtonLabel; // 0x58
	[SerializeField]
	private GameObject multiFrame; // 0x60
	[SerializeField]
	private GameObject multiScrollBar; // 0x68
	[SerializeField]
	private UIScrollWindow multiScrollWindow; // 0x70
	[SerializeField]
	private GameObject buttons; // 0x78
	[SerializeField]
	private GameObject multiOriginal; // 0x80
	private int LimitCount; // 0x88
	private int Price; // 0x8C
	private string Name; // 0x90
	private int Possession; // 0x98
	private int Id; // 0x9C
	private int BuyCount; // 0xA0
	private string ButtonLabelOrigin; // 0xA8
	private bool EnableCheckSpina; // 0xB0
	private bool EnableCheckBag; // 0xB1
	private Action callBack; // 0xB8
	private TextManagerBase systemTextManager; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8
	private UIPopWindow popwindow; // 0xD0
	private UIBasePanelControl topControl; // 0xD8

	// Properties
	private bool isSell { get; }
	public bool IsCompleteActive { get; }

	// Methods

	// RVA: 0x1D23324 Offset: 0x1D1F324 VA: 0x1D23324
	private bool get_isSell() { }

	// RVA: 0x1D23384 Offset: 0x1D1F384 VA: 0x1D23384
	public bool get_IsCompleteActive() { }

	// RVA: 0x1D233AC Offset: 0x1D1F3AC VA: 0x1D233AC
	private void Awake() { }

	// RVA: 0x1D2342C Offset: 0x1D1F42C VA: 0x1D2342C
	public void Show(int id, byte ability, string name, int price, int possession, int limitCount, UIBasePanelControl control) { }

	// RVA: 0x1D23818 Offset: 0x1D1F818 VA: 0x1D23818
	public void Show(ItemData[] items, ItemTextManager itemTextManager, int possession, bool multi, UIBasePanelControl control) { }

	// RVA: 0x1D242BC Offset: 0x1D202BC VA: 0x1D242BC
	public void Complete(bool isBuy, Action func, UIBasePanelControl topControl) { }

	// RVA: 0x1D243F4 Offset: 0x1D203F4 VA: 0x1D243F4
	public void Close() { }

	// RVA: 0x1D2445C Offset: 0x1D2045C VA: 0x1D2445C
	private void AddCount() { }

	// RVA: 0x1D244EC Offset: 0x1D204EC VA: 0x1D244EC
	private void AddMaxCount() { }

	// RVA: 0x1D24570 Offset: 0x1D20570 VA: 0x1D24570
	private void SubCount() { }

	// RVA: 0x1D245F4 Offset: 0x1D205F4 VA: 0x1D245F4
	private void SubMaxCount() { }

	// RVA: 0x1D235F0 Offset: 0x1D1F5F0 VA: 0x1D235F0
	private void UpdateCount() { }

	// RVA: 0x1D23774 Offset: 0x1D1F774 VA: 0x1D23774
	private void UpdateTotal() { }

	// RVA: 0x1D2466C Offset: 0x1D2066C VA: 0x1D2466C
	private void CheckSpina() { }

	// RVA: 0x1D247F0 Offset: 0x1D207F0 VA: 0x1D247F0
	private void CheckBag() { }

	// RVA: 0x1D24B64 Offset: 0x1D20B64 VA: 0x1D24B64
	public int GetCount() { }

	// RVA: 0x1D24B6C Offset: 0x1D20B6C VA: 0x1D24B6C
	public int GetId() { }

	// RVA: 0x1D24B74 Offset: 0x1D20B74 VA: 0x1D24B74
	public void SetEnableCheckSpina(bool enabled) { }

	// RVA: 0x1D24B80 Offset: 0x1D20B80 VA: 0x1D24B80
	public void SetEnableCheckBag(bool enabled) { }

	// RVA: 0x1D249AC Offset: 0x1D209AC VA: 0x1D249AC
	private void checkOverSpinaSingle() { }

	// RVA: 0x1D24138 Offset: 0x1D20138 VA: 0x1D24138
	private void checkOverSpinaMulti(long spina) { }

	// RVA: 0x1D24B8C Offset: 0x1D20B8C VA: 0x1D24B8C
	private void overSpinaCallback() { }

	// RVA: 0x1D24C9C Offset: 0x1D20C9C VA: 0x1D24C9C
	public void .ctor() { }
}
