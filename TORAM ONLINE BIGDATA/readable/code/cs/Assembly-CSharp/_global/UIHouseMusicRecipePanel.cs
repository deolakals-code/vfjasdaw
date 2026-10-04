// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseMusicRecipePanel : MonoBehaviour // TypeDefIndex: 7279
{
	// Fields
	[SerializeField]
	private UILabel musicLabel; // 0x20
	[SerializeField]
	private UIImageButton buyButton; // 0x28
	[SerializeField]
	private GameObject playButton; // 0x30
	[SerializeField]
	private GameObject[] itemPanel; // 0x38
	[SerializeField]
	private UIIcon[] itemIcon; // 0x40
	[SerializeField]
	private UILabel[] itemNameLabel; // 0x48
	[SerializeField]
	private UILabel[] itemNumLabel; // 0x50
	private PlayerDataManager playerData; // 0x58
	private HouseItemTextManager houseTextDataManager; // 0x60
	private ItemTextManager itemTextDataManager; // 0x68
	private SystemTextManager systemTextDataManager; // 0x70
	private bool isNoItem; // 0x78

	// Properties
	private PlayerDataManager playerDataManager { get; }
	private HouseItemTextManager houseTextManager { get; }
	private ItemTextManager itemTextManager { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1AFDA5C Offset: 0x1AF9A5C VA: 0x1AFDA5C
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1AFDAE0 Offset: 0x1AF9AE0 VA: 0x1AFDAE0
	private HouseItemTextManager get_houseTextManager() { }

	// RVA: 0x1AFDBCC Offset: 0x1AF9BCC VA: 0x1AFDBCC
	private ItemTextManager get_itemTextManager() { }

	// RVA: 0x1AFDCB8 Offset: 0x1AF9CB8 VA: 0x1AFDCB8
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1AF9B24 Offset: 0x1AF5B24 VA: 0x1AF9B24
	public void SetMusicRecipe(HouseRecipeManager.RecipeData recipeData) { }

	// RVA: 0x1AFDDA4 Offset: 0x1AF9DA4 VA: 0x1AFDDA4
	private string CheckVal(int useVal, int haveVal) { }

	// RVA: 0x1AFDE58 Offset: 0x1AF9E58 VA: 0x1AFDE58
	public void .ctor() { }
}
