// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILibrary : UIBasePanelControl, IShop // TypeDefIndex: 8347
{
	// Fields
	[SerializeField]
	private UIIruna2AnchorSimple battleSkillAnchor; // 0x58
	[SerializeField]
	private UIIruna2AnchorSimple lifeSkillAnchor; // 0x60
	[SerializeField]
	private UIIruna2AnchorSimple[] battleSkillAnchors; // 0x68
	[SerializeField]
	private UIIruna2AnchorSimple[] messageAnchors; // 0x70
	[SerializeField]
	private UILibraryList libraryList; // 0x78
	[SerializeField]
	private UILabel messageLabel; // 0x80
	[SerializeField]
	private UIStretch messageBack; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private string shopName; // 0x98
	private int shopId; // 0xA0
	private bool isClosed; // 0xA4

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1D29FF4 Offset: 0x1D25FF4 VA: 0x1D29FF4
	private void Awake() { }

	// RVA: 0x1D2A21C Offset: 0x1D2621C VA: 0x1D2A21C
	private void Start() { }

	// RVA: 0x1D2A410 Offset: 0x1D26410 VA: 0x1D2A410
	private void initializeFirst() { }

	// RVA: 0x1D2A7A4 Offset: 0x1D267A4 VA: 0x1D2A7A4
	private void initializeSecond() { }

	// RVA: 0x1D2A6AC Offset: 0x1D266AC VA: 0x1D2A6AC
	private void setShowFirst(bool isShow) { }

	// RVA: 0x1D2A6FC Offset: 0x1D266FC VA: 0x1D2A6FC
	private void setShowSecond(bool isShow) { }

	// RVA: 0x1D2A81C Offset: 0x1D2681C VA: 0x1D2A81C
	private void onLifeSkill() { }

	// RVA: 0x1D2AAF0 Offset: 0x1D26AF0 VA: 0x1D2AAF0
	private void onBattleSkillList() { }

	// RVA: 0x1D2ABE4 Offset: 0x1D26BE4 VA: 0x1D2ABE4
	private void onWeaponSkill() { }

	// RVA: 0x1D2AD6C Offset: 0x1D26D6C VA: 0x1D2AD6C
	private void onSubWeaponSkill() { }

	// RVA: 0x1D2AEF4 Offset: 0x1D26EF4 VA: 0x1D2AEF4
	private void onSupportSkill() { }

	// RVA: 0x1D2B07C Offset: 0x1D2707C VA: 0x1D2B07C
	private void onClose() { }

	// RVA: 0x1D2B088 Offset: 0x1D27088 VA: 0x1D2B088 Slot: 14
	public int get_ShopId() { }

	// RVA: 0x1D2B090 Offset: 0x1D27090 VA: 0x1D2B090 Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x1D2B098 Offset: 0x1D27098 VA: 0x1D2B098 Slot: 16
	public string get_ShopName() { }

	// RVA: 0x1D2B0A0 Offset: 0x1D270A0 VA: 0x1D2B0A0 Slot: 17
	public void set_ShopName(string value) { }

	// RVA: 0x1D2B0A8 Offset: 0x1D270A8 VA: 0x1D2B0A8 Slot: 18
	public bool get_IsClosed() { }

	// RVA: 0x1D2B0B0 Offset: 0x1D270B0 VA: 0x1D2B0B0 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x1D2B0BC Offset: 0x1D270BC VA: 0x1D2B0BC
	public void .ctor() { }
}
