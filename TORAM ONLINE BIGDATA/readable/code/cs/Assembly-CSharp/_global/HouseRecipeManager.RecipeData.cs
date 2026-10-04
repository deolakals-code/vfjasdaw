// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct HouseRecipeManager.RecipeData // TypeDefIndex: 1986
{
	// Fields
	public readonly int ItemId; // 0x0
	public readonly int SortId; // 0x4
	public readonly byte EnvironmentType; // 0x8
	public readonly short ItemType; // 0xA
	public readonly int ModelId; // 0xC
	public readonly byte MaxStack; // 0x10
	public readonly int CreateOrbNum; // 0x14
	public readonly int Flag; // 0x18
	public readonly byte PurchaseFlag; // 0x1C
	public HouseRecipeManager.RecipeData.RecipeMaterialData[] Recipe; // 0x20

	// Properties
	public bool IsPickUpItem { get; }
	public bool IsSystemItem { get; }

	// Methods

	// RVA: 0x2129398 Offset: 0x2125398 VA: 0x2129398
	public void .ctor(BinaryReader reader) { }

	// RVA: 0x212A3CC Offset: 0x21263CC VA: 0x212A3CC
	public void .ctor(int itemId, int sortId, byte environmentType, short itemType, int modelId, byte stack, int flag) { }

	// RVA: 0x212A418 Offset: 0x2126418 VA: 0x212A418
	public bool CheckCreateState(HouseRecipeManager.RecipeData.CreateState state) { }

	// RVA: 0x212A050 Offset: 0x2126050 VA: 0x212A050
	public bool get_IsPickUpItem() { }

	// RVA: 0x212A05C Offset: 0x212605C VA: 0x212A05C
	public bool get_IsSystemItem() { }
}
