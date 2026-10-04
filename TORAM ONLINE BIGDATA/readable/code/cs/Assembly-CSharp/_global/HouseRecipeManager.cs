// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseRecipeManager // TypeDefIndex: 1991
{
	// Fields
	public static readonly short PickupCategoryId; // 0x0
	public static readonly short SystemCategoryId; // 0x2
	[CompilerGenerated]
	private bool <IsLoadRecipeData>k__BackingField; // 0x10
	private Dictionary<int, HouseRecipeManager.RecipeData> recipDBData; // 0x18

	// Properties
	public bool IsLoadRecipeData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2128DD4 Offset: 0x2124DD4 VA: 0x2128DD4
	public bool get_IsLoadRecipeData() { }

	[CompilerGenerated]
	// RVA: 0x2128DDC Offset: 0x2124DDC VA: 0x2128DDC
	private void set_IsLoadRecipeData(bool value) { }

	// RVA: 0x2128DE8 Offset: 0x2124DE8 VA: 0x2128DE8
	public void .ctor() { }

	// RVA: 0x2128E78 Offset: 0x2124E78 VA: 0x2128E78
	public void Clear() { }

	// RVA: 0x2128ECC Offset: 0x2124ECC VA: 0x2128ECC
	public bool LoadHouseRecipeData(byte[] binary) { }

	// RVA: 0x2129560 Offset: 0x2125560 VA: 0x2129560
	public int GetModelData(int itemId) { }

	// RVA: 0x2129600 Offset: 0x2125600 VA: 0x2129600
	public List<HouseRecipeManager.RecipeData> GetCategoryItemRecipeData(byte e, short type) { }

	// RVA: 0x2129810 Offset: 0x2125810 VA: 0x2129810
	public List<HouseRecipeManager.RecipeData> GetPickupItemRecipeData(byte e) { }

	// RVA: 0x2129A18 Offset: 0x2125A18 VA: 0x2129A18
	public List<HouseRecipeManager.RecipeData> GetSystemItemRecipeData(byte e) { }

	// RVA: 0x2129C20 Offset: 0x2125C20 VA: 0x2129C20
	public bool GetItemRecipeData(int itemId, out HouseRecipeManager.RecipeData data) { }

	// RVA: 0x2129C88 Offset: 0x2125C88 VA: 0x2129C88
	public List<short> GetCategoryRecipeDataType(byte e) { }

	// RVA: 0x212A068 Offset: 0x2126068 VA: 0x212A068
	public bool CheckConstructionType(List<int> item) { }

	// RVA: 0x212A2D4 Offset: 0x21262D4 VA: 0x212A2D4
	public void OnEnter() { }

	// RVA: 0x212A2D8 Offset: 0x21262D8 VA: 0x212A2D8
	private static void .cctor() { }
}
