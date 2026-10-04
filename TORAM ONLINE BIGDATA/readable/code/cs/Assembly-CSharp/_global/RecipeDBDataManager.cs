// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecipeDBDataManager // TypeDefIndex: 8525
{
	// Fields
	public readonly byte[] SkipCategory; // 0x10
	public readonly byte[] LabelSizeControlCategory; // 0x18
	private RecipeDBData[] RecipeDatas; // 0x20
	private Dictionary<int, List<RecipeDBData>> RecipeTypeData; // 0x28
	private PlayerDataManager _status; // 0x30

	// Properties
	private PlayerDataManager Status { get; }

	// Methods

	// RVA: 0x1D9A3B4 Offset: 0x1D963B4 VA: 0x1D9A3B4
	private PlayerDataManager get_Status() { }

	// RVA: 0x1D99444 Offset: 0x1D95444 VA: 0x1D99444
	public bool LoadData(byte[] binary, RecipeDBData.recipeType recipeType) { }

	// RVA: 0x1D9A438 Offset: 0x1D96438 VA: 0x1D9A438
	public void ClearData() { }

	// RVA: 0x1D9A4C4 Offset: 0x1D964C4 VA: 0x1D9A4C4
	public RecipeDBData[] GetData() { }

	// RVA: 0x1D9A51C Offset: 0x1D9651C VA: 0x1D9A51C
	private RecipeDBData[] getData(RecipeDBData[] datas, int proficiency, bool isShop, bool isSmith) { }

	// RVA: 0x1D9ABF0 Offset: 0x1D96BF0 VA: 0x1D9ABF0
	public RecipeDBData[] GetData(int category, int proficiency, bool isShop, bool isSmith) { }

	// RVA: 0x1D9ACE8 Offset: 0x1D96CE8 VA: 0x1D9ACE8
	public bool AddRecipeExist(int current, int end) { }

	// RVA: 0x1D9ADC8 Offset: 0x1D96DC8 VA: 0x1D9ADC8
	public int GetNextRecipeDataLevel(int category, int lastLv) { }

	// RVA: 0x1D99434 Offset: 0x1D95434 VA: 0x1D99434
	public bool IsLoaded() { }

	// RVA: 0x1D9B058 Offset: 0x1D97058 VA: 0x1D9B058
	public int GetAlphaParameter(int proficiency) { }

	// RVA: 0x1D9B26C Offset: 0x1D9726C VA: 0x1D9B26C
	public bool CheckLabelSizeControl(byte category) { }

	// RVA: 0x1D9B2C4 Offset: 0x1D972C4 VA: 0x1D9B2C4
	public void .ctor() { }
}
