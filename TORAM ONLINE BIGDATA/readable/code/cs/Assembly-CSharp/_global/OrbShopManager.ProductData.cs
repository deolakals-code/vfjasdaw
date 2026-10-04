// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopManager.ProductData // TypeDefIndex: 2161
{
	// Fields
	public readonly int ProductId; // 0x10
	public readonly int Stack; // 0x14
	public readonly int ItemId; // 0x18
	public readonly int Price; // 0x1C
	public readonly int DiscountPrice; // 0x20
	public readonly OrbShopManager.ProductObtainState ObtainState; // 0x24
	public readonly string CampaignCode; // 0x28

	// Methods

	// RVA: 0x2152174 Offset: 0x214E174 VA: 0x2152174
	public void .ctor(int productId, int stack, int itemId, int price, int disPrice, string obtainCode, string campaignCode) { }

	// RVA: 0x215438C Offset: 0x215038C VA: 0x215438C
	public void .ctor(int productId, int stack, int itemId, int price, int disPrice, OrbShopManager.ProductObtainState obtainState, string campaignCode) { }

	// RVA: 0x21543F8 Offset: 0x21503F8 VA: 0x21543F8
	public void .ctor() { }

	// RVA: 0x21542A0 Offset: 0x21502A0 VA: 0x21542A0
	public static OrbShopManager.ProductObtainState GetObtainState(string obtainStateString) { }
}
