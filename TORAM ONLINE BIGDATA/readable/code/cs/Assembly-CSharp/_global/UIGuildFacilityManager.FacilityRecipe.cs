// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIGuildFacilityManager.FacilityRecipe // TypeDefIndex: 6636
{
	// Fields
	public readonly byte Id; // 0x10
	public readonly byte Category; // 0x11
	public readonly byte SortId; // 0x12
	private Dictionary<short, List<UIGuildFacilityManager.FacilityRecipe.FacilityRecipeData>> recipeData; // 0x18

	// Methods

	// RVA: 0x19A3380 Offset: 0x199F380 VA: 0x19A3380
	public void .ctor(byte id, byte category, byte sortId) { }

	// RVA: 0x19A3468 Offset: 0x199F468 VA: 0x19A3468
	public void AddRecipeData(short level, UIGuildFacilityManager.FacilityRecipe.FacilityRecipeData recipe) { }

	// RVA: 0x19A4CF0 Offset: 0x19A0CF0 VA: 0x19A4CF0
	public List<UIGuildFacilityManager.FacilityRecipe.FacilityRecipeData> GetLevelUpRecipe(short level) { }

	// RVA: 0x19A3BE4 Offset: 0x199FBE4 VA: 0x19A3BE4
	public bool CheckLevelUp(short level, GuildManager guild) { }
}
