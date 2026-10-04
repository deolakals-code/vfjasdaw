// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStockColorMainManager : UIBasePanelConnection // TypeDefIndex: 6767
{
	// Fields
	[SerializeField]
	private GameObject selectPanel; // 0x30
	[SerializeField]
	private GameObject[] panelObjs; // 0x38
	[CompilerGenerated]
	private List<ItemType> <ColorItemTypeList>k__BackingField; // 0x40
	[CompilerGenerated]
	private Dictionary<ItemType, PaletteData> <PaletteDataList>k__BackingField; // 0x48
	private UIStockColorMainManager.PanelState panelState; // 0x50
	private ItemTextManager itemTextManager; // 0x58
	private PlayerDataManager playerDataManager; // 0x60
	private IUIStockColor[] panels; // 0x68

	// Properties
	public List<ItemType> ColorItemTypeList { get; set; }
	public Dictionary<ItemType, PaletteData> PaletteDataList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19F39E4 Offset: 0x19EF9E4 VA: 0x19F39E4
	public List<ItemType> get_ColorItemTypeList() { }

	[CompilerGenerated]
	// RVA: 0x19F39EC Offset: 0x19EF9EC VA: 0x19F39EC
	private void set_ColorItemTypeList(List<ItemType> value) { }

	[CompilerGenerated]
	// RVA: 0x19F39F4 Offset: 0x19EF9F4 VA: 0x19F39F4
	public Dictionary<ItemType, PaletteData> get_PaletteDataList() { }

	[CompilerGenerated]
	// RVA: 0x19F39FC Offset: 0x19EF9FC VA: 0x19F39FC
	private void set_PaletteDataList(Dictionary<ItemType, PaletteData> value) { }

	// RVA: 0x19F3A04 Offset: 0x19EFA04 VA: 0x19F3A04
	private void Start() { }

	// RVA: 0x19F1E78 Offset: 0x19EDE78 VA: 0x19F1E78
	public void ChangePanelState(UIStockColorMainManager.PanelState state) { }

	// RVA: 0x19F1484 Offset: 0x19ED484 VA: 0x19F1484
	public string[] GetColorText(byte[] colorIds) { }

	// RVA: 0x19F4410 Offset: 0x19F0410 VA: 0x19F4410
	public byte GetStockColorNum(ItemType type, byte part, byte colorId) { }

	// RVA: 0x19F16D0 Offset: 0x19ED6D0 VA: 0x19F16D0
	public bool CheckOpenLimitWindow() { }

	// RVA: 0x19F42A0 Offset: 0x19F02A0 VA: 0x19F42A0
	public void GetServerPaletteData() { }

	// RVA: 0x19F45A0 Offset: 0x19F05A0 VA: 0x19F45A0
	public void SaveServerStockColor(int[] itemUuids) { }

	// RVA: 0x19F17D8 Offset: 0x19ED7D8 VA: 0x19F17D8
	public void CreateColorEquip(short itemType, byte[] color) { }

	// RVA: 0x19F4784 Offset: 0x19F0784 VA: 0x19F4784
	private void OpenErrorWindow(string title, string mes) { }

	// RVA: 0x19F4830 Offset: 0x19F0830 VA: 0x19F4830
	private void ReturnExSkillMenu() { }

	// RVA: 0x19F491C Offset: 0x19F091C VA: 0x19F491C
	public void OnStock() { }

	// RVA: 0x19F4984 Offset: 0x19F0984 VA: 0x19F4984
	public void OnPop() { }

	// RVA: 0x19F49EC Offset: 0x19F09EC VA: 0x19F49EC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19F4B2C Offset: 0x19F0B2C VA: 0x19F4B2C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19F4BB8 Offset: 0x19F0BB8 VA: 0x19F4BB8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19F4C54 Offset: 0x19F0C54 VA: 0x19F4C54
	private void <OpenErrorWindow>b__26_0() { }
}
