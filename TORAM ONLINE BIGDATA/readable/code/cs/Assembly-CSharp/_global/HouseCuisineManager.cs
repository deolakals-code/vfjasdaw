// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseCuisineManager // TypeDefIndex: 1971
{
	// Fields
	private Dictionary<int, int> recipeExpList; // 0x10
	private HouseCuisineManager.CuisineRecipeData[] recipeData; // 0x18
	private bool isInitRecipe; // 0x20
	private bool isInitBonus; // 0x21
	private Dictionary<int, byte> bonusDataList; // 0x28
	private TimeSpan endTimer; // 0x30
	private DateTime endUpdateTimer; // 0x38
	private BonusParameter[] readBonusList; // 0x40
	[CompilerGenerated]
	private readonly Dictionary<HouseCuisineManager.CuisineType, HouseCuisineManager.CuisineData> <Cuisines>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsMyCooking>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <CookingResultId>k__BackingField; // 0x54
	[CompilerGenerated]
	private byte <CookingResultLevel>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <CookingResultState>k__BackingField; // 0x59

	// Properties
	public bool HasUserRecipe { get; }
	public HouseCuisineManager.CuisineRecipeData[] RecipeData { get; }
	public BonusParameter[] ReadBonusList { get; }
	public Dictionary<HouseCuisineManager.CuisineType, HouseCuisineManager.CuisineData> Cuisines { get; }
	public bool IsMyCooking { get; set; }
	public bool IsMaxBouns { get; }
	public TimeSpan CookingEndTimer { get; }
	private bool isEndBonus { get; }
	public int CookingResultId { get; set; }
	public byte CookingResultLevel { get; set; }
	public byte CookingResultState { get; set; }

	// Methods

	// RVA: 0x2114F4C Offset: 0x2110F4C VA: 0x2114F4C
	public bool get_HasUserRecipe() { }

	// RVA: 0x21150FC Offset: 0x21110FC VA: 0x21150FC
	public HouseCuisineManager.CuisineRecipeData[] get_RecipeData() { }

	// RVA: 0x2115104 Offset: 0x2111104 VA: 0x2115104
	public BonusParameter[] get_ReadBonusList() { }

	[CompilerGenerated]
	// RVA: 0x211510C Offset: 0x211110C VA: 0x211510C
	public Dictionary<HouseCuisineManager.CuisineType, HouseCuisineManager.CuisineData> get_Cuisines() { }

	[CompilerGenerated]
	// RVA: 0x2115114 Offset: 0x2111114 VA: 0x2115114
	public bool get_IsMyCooking() { }

	[CompilerGenerated]
	// RVA: 0x211511C Offset: 0x211111C VA: 0x211511C
	private void set_IsMyCooking(bool value) { }

	// RVA: 0x2115128 Offset: 0x2111128 VA: 0x2115128
	public bool get_IsMaxBouns() { }

	// RVA: 0x2115190 Offset: 0x2111190 VA: 0x2115190
	public TimeSpan get_CookingEndTimer() { }

	// RVA: 0x2115230 Offset: 0x2111230 VA: 0x2115230
	private bool get_isEndBonus() { }

	// RVA: 0x2115320 Offset: 0x2111320 VA: 0x2115320
	public void LoadHouseCuisine(List<CuisineSendData> cuisines) { }

	// RVA: 0x211549C Offset: 0x211149C VA: 0x211549C
	public void LoadHouseCuisine(HouseCuisineManager.CuisineType type, int id, byte lv, int end) { }

	[CompilerGenerated]
	// RVA: 0x21156E0 Offset: 0x21116E0 VA: 0x21156E0
	public int get_CookingResultId() { }

	[CompilerGenerated]
	// RVA: 0x21156E8 Offset: 0x21116E8 VA: 0x21156E8
	private void set_CookingResultId(int value) { }

	[CompilerGenerated]
	// RVA: 0x21156F0 Offset: 0x21116F0 VA: 0x21156F0
	public byte get_CookingResultLevel() { }

	[CompilerGenerated]
	// RVA: 0x21156F8 Offset: 0x21116F8 VA: 0x21156F8
	private void set_CookingResultLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2115700 Offset: 0x2111700 VA: 0x2115700
	public byte get_CookingResultState() { }

	[CompilerGenerated]
	// RVA: 0x2115708 Offset: 0x2111708 VA: 0x2115708
	private void set_CookingResultState(byte value) { }

	// RVA: 0x2115710 Offset: 0x2111710 VA: 0x2115710
	public void LoadCuisineRecipeData(byte[] binary) { }

	// RVA: 0x2115FA8 Offset: 0x2111FA8 VA: 0x2115FA8
	public bool TryGetRecipeData(int cuisineId, out HouseCuisineManager.CuisineRecipeData recipe) { }

	// RVA: 0x21160D0 Offset: 0x21120D0 VA: 0x21160D0
	public bool TryGetRecipeExp(int cuisineId, out int exp) { }

	// RVA: 0x211613C Offset: 0x211213C VA: 0x211613C
	public void GetUserRecipe() { }

	// RVA: 0x21161B8 Offset: 0x21121B8 VA: 0x21161B8
	public void ReceiveGetUserRecipe(CuisineRecipeSendData[] recipeList) { }

	// RVA: 0x2116288 Offset: 0x2112288 VA: 0x2116288
	public bool CuisineCooking(HouseCuisineManager.CuisineType type, int id) { }

	// RVA: 0x2116378 Offset: 0x2112378 VA: 0x2116378
	public void ReceiveCuisineCooking(HouseCuisineManager.CuisineType type, int id, int exp = 0) { }

	// RVA: 0x21168C4 Offset: 0x21128C4 VA: 0x21168C4
	public bool ChangeTypeMyCuisineBuff(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x211695C Offset: 0x211295C VA: 0x211695C
	public void OnCuisineChangeType() { }

	// RVA: 0x2116B74 Offset: 0x2112B74 VA: 0x2116B74
	public bool CuisineDineOut(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x2116CB4 Offset: 0x2112CB4 VA: 0x2116CB4
	public bool HasCuisine(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x2116D3C Offset: 0x2112D3C VA: 0x2116D3C
	public bool IsDineOut(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x2116E2C Offset: 0x2112E2C VA: 0x2116E2C
	public void ReceiveCuisineBonus(bool myCooking, int time, Dictionary<int, byte> bonus) { }

	// RVA: 0x2116828 Offset: 0x2112828 VA: 0x2116828
	public void GetEatingList() { }

	// RVA: 0x211674C Offset: 0x211274C VA: 0x211674C
	private void UpdateBonusDataList(bool isMyCooking, TimeSpan timer, Dictionary<int, byte> bonus) { }

	// RVA: 0x2116ED0 Offset: 0x2112ED0 VA: 0x2116ED0
	public List<BonusParameter> GetBounsProperty(int removeId) { }

	// RVA: 0x21172E8 Offset: 0x21132E8 VA: 0x21172E8
	public List<BonusParameter> GetBonusParameter(int id) { }

	// RVA: 0x2117660 Offset: 0x2113660 VA: 0x2117660
	public void UpdateCuisineBonusTimer(int time) { }

	// RVA: 0x2117244 Offset: 0x2113244 VA: 0x2117244
	public void UpdateUICookingBouns(BonusParameter[] list) { }

	// RVA: 0x2117738 Offset: 0x2113738 VA: 0x2117738
	public TimeSpan GetBonusTimer(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x21178F4 Offset: 0x21138F4 VA: 0x21178F4
	public TimeSpan GetEndTimer(HouseCuisineManager.CuisineType type) { }

	// RVA: 0x21179C0 Offset: 0x21139C0 VA: 0x21179C0
	public void Clear() { }

	// RVA: 0x2117A70 Offset: 0x2113A70 VA: 0x2117A70
	public void OnLeave() { }

	// RVA: 0x2117AC0 Offset: 0x2113AC0 VA: 0x2117AC0
	public void OnEnter() { }

	// RVA: 0x2117B2C Offset: 0x2113B2C VA: 0x2117B2C
	public void .ctor() { }
}
