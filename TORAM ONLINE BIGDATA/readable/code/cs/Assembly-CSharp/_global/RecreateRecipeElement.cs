// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecreateRecipeElement : MonoBehaviour // TypeDefIndex: 8633
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel spinaLabel; // 0x28
	[SerializeField]
	private GameObject itemLabelOriginal; // 0x30
	private RecreateType recipeType; // 0x38
	private List<GameObject> addedLabels; // 0x40
	private RecipeDBData addedRecipes; // 0x48
	private PlayerDataManager playerDataManager; // 0x50
	private SystemTextManager systemTextManager; // 0x58

	// Properties
	public int Height { get; }
	public RecreateType RecipeType { get; }
	public int DefaultHeight { get; }

	// Methods

	// RVA: 0x1DC567C Offset: 0x1DC167C VA: 0x1DC567C
	public int get_Height() { }

	// RVA: 0x1DC56D8 Offset: 0x1DC16D8 VA: 0x1DC56D8
	public RecreateType get_RecipeType() { }

	// RVA: 0x1DC56E0 Offset: 0x1DC16E0 VA: 0x1DC56E0
	public int get_DefaultHeight() { }

	// RVA: 0x1DC56E8 Offset: 0x1DC16E8 VA: 0x1DC56E8
	private void Awake() { }

	// RVA: 0x1DC57E8 Offset: 0x1DC17E8 VA: 0x1DC57E8
	public void SetRecipe(RecipeDBData recipe) { }

	// RVA: 0x1DC5CF0 Offset: 0x1DC1CF0 VA: 0x1DC5CF0
	private void setSpina(long spina) { }

	// RVA: 0x1DC5DBC Offset: 0x1DC1DBC VA: 0x1DC5DBC
	private void setTypeName(RecreateType type) { }

	// RVA: 0x1DC58A8 Offset: 0x1DC18A8 VA: 0x1DC58A8
	private void addLabel(RecipeDBData.RecipeMaterialData material) { }

	// RVA: 0x1DC5E88 Offset: 0x1DC1E88 VA: 0x1DC5E88
	public void ResetRecipe() { }

	// RVA: 0x1DC6064 Offset: 0x1DC2064 VA: 0x1DC6064
	public void .ctor() { }
}
