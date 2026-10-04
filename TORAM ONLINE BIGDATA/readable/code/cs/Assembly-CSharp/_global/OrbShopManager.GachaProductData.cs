// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopManager.GachaProductData // TypeDefIndex: 2166
{
	// Fields
	public readonly int GachaId; // 0x10
	public readonly string UseGachaTicket; // 0x18
	public readonly OrbShopManager.GachaType GachaType; // 0x20
	[CompilerGenerated]
	private bool <IsDiscount>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsFree>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <IsSoldOut>k__BackingField; // 0x26
	[CompilerGenerated]
	private int <Free_Remaining>k__BackingField; // 0x28
	private List<OrbShopManager.GachaProductData.GachaData> setList; // 0x30
	private List<OrbShopManager.GachaDetailData> detailList; // 0x38
	private List<OrbShopManager.GachaRareRateData> rareRateList; // 0x40
	[CompilerGenerated]
	private bool <IsConnectDetailList>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsAvatar>k__BackingField; // 0x49

	// Properties
	public bool IsDiscount { get; set; }
	public bool IsFree { get; set; }
	public bool IsSoldOut { get; set; }
	public int Free_Remaining { get; set; }
	public bool IsConnectDetailList { get; set; }
	public OrbShopManager.GachaProductData.GachaData[] GetSetList { get; }
	public OrbShopManager.GachaDetailData[] GetDetailList { get; }
	public bool IsAvatar { get; set; }
	public OrbShopManager.GachaRareRateData[] GetRareRateDataList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2154468 Offset: 0x2150468 VA: 0x2154468
	public bool get_IsDiscount() { }

	[CompilerGenerated]
	// RVA: 0x2154470 Offset: 0x2150470 VA: 0x2154470
	private void set_IsDiscount(bool value) { }

	[CompilerGenerated]
	// RVA: 0x215447C Offset: 0x215047C VA: 0x215447C
	public bool get_IsFree() { }

	[CompilerGenerated]
	// RVA: 0x2154484 Offset: 0x2150484 VA: 0x2154484
	private void set_IsFree(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2154490 Offset: 0x2150490 VA: 0x2154490
	public bool get_IsSoldOut() { }

	[CompilerGenerated]
	// RVA: 0x2154498 Offset: 0x2150498 VA: 0x2154498
	private void set_IsSoldOut(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21544A4 Offset: 0x21504A4 VA: 0x21544A4
	public int get_Free_Remaining() { }

	[CompilerGenerated]
	// RVA: 0x21544AC Offset: 0x21504AC VA: 0x21544AC
	private void set_Free_Remaining(int value) { }

	[CompilerGenerated]
	// RVA: 0x21544B4 Offset: 0x21504B4 VA: 0x21544B4
	public bool get_IsConnectDetailList() { }

	[CompilerGenerated]
	// RVA: 0x21544BC Offset: 0x21504BC VA: 0x21544BC
	private void set_IsConnectDetailList(bool value) { }

	// RVA: 0x21532D0 Offset: 0x214F2D0 VA: 0x21532D0
	public OrbShopManager.GachaProductData.GachaData[] get_GetSetList() { }

	// RVA: 0x21544C8 Offset: 0x21504C8 VA: 0x21544C8
	public OrbShopManager.GachaDetailData[] get_GetDetailList() { }

	[CompilerGenerated]
	// RVA: 0x2154518 Offset: 0x2150518 VA: 0x2154518
	public bool get_IsAvatar() { }

	[CompilerGenerated]
	// RVA: 0x2154520 Offset: 0x2150520 VA: 0x2154520
	private void set_IsAvatar(bool value) { }

	// RVA: 0x215452C Offset: 0x215052C VA: 0x215452C
	public OrbShopManager.GachaRareRateData[] get_GetRareRateDataList() { }

	// RVA: 0x215457C Offset: 0x215057C VA: 0x215457C
	public void .ctor(int gachaId, int free_Remaining) { }

	// RVA: 0x215470C Offset: 0x215070C VA: 0x215470C
	public void .ctor(int gachaId, string useGachaTicket) { }

	// RVA: 0x2154880 Offset: 0x2150880 VA: 0x2154880
	public void .ctor(int gachaId) { }

	// RVA: 0x2152DB4 Offset: 0x214EDB4 VA: 0x2152DB4
	public void AddSetData(int setId, int stack, int price, int disPrice, string campaignCode) { }

	// RVA: 0x215302C Offset: 0x214F02C VA: 0x215302C
	public void SetDetailData(bool isAvatar, OrbShopManager.GachaDetailData[] itemList, OrbShopManager.GachaRareRateData[] rate) { }

	// RVA: 0x21535E0 Offset: 0x214F5E0 VA: 0x21535E0
	public int GetItemRareData(int itemId) { }

	// RVA: 0x2154A68 Offset: 0x2150A68 VA: 0x2154A68
	public bool FindDetailItemData(int productId, out OrbShopManager.GachaDetailData data) { }
}
