// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseRecipeLabel : MonoBehaviour // TypeDefIndex: 7322
{
	// Fields
	[SerializeField]
	private UILabel recipeLabel; // 0x20
	[SerializeField]
	private GameObject recipeIcon; // 0x28
	private List<GameObject> iconList; // 0x30
	private PlayerDataManager playerData; // 0x38
	private HouseItemTextManager houseTextDataManager; // 0x40
	private ItemTextManager itemTextDataManager; // 0x48
	private SystemTextManager systemTextDataManager; // 0x50

	// Properties
	private PlayerDataManager playerDataManager { get; }
	private HouseItemTextManager houseTextManager { get; }
	private ItemTextManager itemTextManager { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1B10878 Offset: 0x1B0C878 VA: 0x1B10878
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1B108FC Offset: 0x1B0C8FC VA: 0x1B108FC
	private HouseItemTextManager get_houseTextManager() { }

	// RVA: 0x1B109E8 Offset: 0x1B0C9E8 VA: 0x1B109E8
	private ItemTextManager get_itemTextManager() { }

	// RVA: 0x1B10AD4 Offset: 0x1B0CAD4 VA: 0x1B10AD4
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1B0DFA0 Offset: 0x1B09FA0 VA: 0x1B0DFA0
	public void Clear() { }

	// RVA: 0x1B10BC0 Offset: 0x1B0CBC0 VA: 0x1B10BC0
	private string CheckVal(int useVal, int haveVal) { }

	// RVA: 0x1B10C6C Offset: 0x1B0CC6C VA: 0x1B10C6C
	public bool SetHouseRecipe(int houseRecipeId, bool first) { }

	// RVA: 0x1B0E190 Offset: 0x1B0A190 VA: 0x1B0E190
	public bool SetHouseRecipe(HouseRecipeManager.RecipeData recipeData, bool first) { }

	// RVA: 0x1B10F80 Offset: 0x1B0CF80 VA: 0x1B10F80
	private void Update() { }

	// RVA: 0x1B10D28 Offset: 0x1B0CD28 VA: 0x1B10D28
	private UIIcon CreateIconDate(int y) { }

	// RVA: 0x1B11180 Offset: 0x1B0D180 VA: 0x1B11180
	public void .ctor() { }
}
