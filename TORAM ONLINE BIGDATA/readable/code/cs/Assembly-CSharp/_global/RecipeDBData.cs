// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class RecipeDBData // TypeDefIndex: 8521
{
	// Fields
	public int RecipeId; // 0x10
	public byte Type; // 0x14
	public short ReleaseLv; // 0x16
	public int Price; // 0x18
	public short Difficulty; // 0x1C
	public int CreateId; // 0x20
	public short CreateVal; // 0x24
	public byte Category; // 0x26
	public bool CanCreate; // 0x27
	public RecipeDBData.RecipeMaterialData[] MaterialData; // 0x28

	// Methods

	// RVA: 0x1D99FFC Offset: 0x1D95FFC VA: 0x1D99FFC
	public void .ctor() { }

	// RVA: 0x1D9A004 Offset: 0x1D96004 VA: 0x1D9A004
	public void .ctor(int recipeId, byte type, short releaseLv, int price, short difficulty, int createId, short createVal, byte category, RecipeDBData.RecipeMaterialData[] materialDatas) { }

	// RVA: 0x1D9A0F8 Offset: 0x1D960F8 VA: 0x1D9A0F8
	public void .ctor(int recipeId, byte type, short releaseLv, int price, short difficulty, int createId, short createVal, byte category) { }

	// RVA: 0x1D9A178 Offset: 0x1D96178 VA: 0x1D9A178
	public void SetMaterialData(RecipeDBData.RecipeMaterialData[] data) { }

	// RVA: 0x1D9A1F4 Offset: 0x1D961F4 VA: 0x1D9A1F4
	public RecipeDBData Clone() { }
}
