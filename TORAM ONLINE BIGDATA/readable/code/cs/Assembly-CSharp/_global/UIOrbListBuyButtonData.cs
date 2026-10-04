// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbListBuyButtonData : UIOrbListButtonDataBase // TypeDefIndex: 7609
{
	// Fields
	[CompilerGenerated]
	private int <ProductId>k__BackingField; // 0x40
	[CompilerGenerated]
	private UIOrbListBuyButtonData.OrbItemTypes <OrbItemType>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <TextPosition>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <SaveKey>k__BackingField; // 0x50

	// Properties
	public int ProductId { get; set; }
	public UIOrbListBuyButtonData.OrbItemTypes OrbItemType { get; set; }
	public byte TextPosition { get; set; }
	public string SaveKey { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BBEA58 Offset: 0x1BBAA58 VA: 0x1BBEA58
	public int get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x1BBEA60 Offset: 0x1BBAA60 VA: 0x1BBEA60
	private void set_ProductId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1BBEA68 Offset: 0x1BBAA68 VA: 0x1BBEA68
	public UIOrbListBuyButtonData.OrbItemTypes get_OrbItemType() { }

	[CompilerGenerated]
	// RVA: 0x1BBEA70 Offset: 0x1BBAA70 VA: 0x1BBEA70
	private void set_OrbItemType(UIOrbListBuyButtonData.OrbItemTypes value) { }

	[CompilerGenerated]
	// RVA: 0x1BBEA78 Offset: 0x1BBAA78 VA: 0x1BBEA78
	public byte get_TextPosition() { }

	[CompilerGenerated]
	// RVA: 0x1BBEA80 Offset: 0x1BBAA80 VA: 0x1BBEA80
	private void set_TextPosition(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1BBEA88 Offset: 0x1BBAA88 VA: 0x1BBEA88
	public string get_SaveKey() { }

	[CompilerGenerated]
	// RVA: 0x1BBEA90 Offset: 0x1BBAA90 VA: 0x1BBEA90
	private void set_SaveKey(string value) { }

	// RVA: 0x1BBEA98 Offset: 0x1BBAA98 VA: 0x1BBEA98
	public void .ctor(int buttonId, string panelFolderName, string panelName, byte index, byte size, byte orbItemType, int productId, byte position) { }

	// RVA: 0x1BBEAD8 Offset: 0x1BBAAD8 VA: 0x1BBEAD8
	public void .ctor(UIOrbListButtonDataBase copy) { }

	// RVA: 0x1BBEAE0 Offset: 0x1BBAAE0 VA: 0x1BBEAE0
	public void .ctor(UIOrbListButtonDataBase copy, byte orbItemType, int productId, byte position) { }

	// RVA: 0x1BBEB20 Offset: 0x1BBAB20 VA: 0x1BBEB20
	public void .ctor(int buttonId, byte index, UIOrbListBuyButtonData copy) { }

	// RVA: 0x1BBEB68 Offset: 0x1BBAB68 VA: 0x1BBEB68
	public void SetSaveKey(string saveKey) { }

	// RVA: 0x1BBEB70 Offset: 0x1BBAB70 VA: 0x1BBEB70
	public bool IsSaleProductId(OrbShopManager manager) { }
}
