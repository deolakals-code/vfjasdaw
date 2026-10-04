// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private class SmithGrant.RequireData // TypeDefIndex: 8479
{
	// Fields
	private SmithGrant.RequireData.requireData[] requireDatas; // 0x10
	private int currentSlot; // 0x18

	// Methods

	// RVA: 0x1D797F0 Offset: 0x1D757F0 VA: 0x1D797F0
	public void .ctor() { }

	// RVA: 0x1D7BC2C Offset: 0x1D77C2C VA: 0x1D7BC2C
	public SmithGrant.RequireData.requireData GetRequireData(int slot) { }

	// RVA: 0x1D7C6BC Offset: 0x1D786BC VA: 0x1D7C6BC
	public SmithGrant.RequireData.requireData GetRequireData() { }

	// RVA: 0x1D80144 Offset: 0x1D7C144 VA: 0x1D80144
	public SmithGrant.RequireData.requireData[] GetRequireDatas() { }

	// RVA: 0x1D8014C Offset: 0x1D7C14C VA: 0x1D8014C
	public int GetAllPotential(PlayerDataManager playerData) { }

	// RVA: 0x1D8090C Offset: 0x1D7C90C VA: 0x1D8090C
	public int GetAllPotential(PlayerDataManager playerData, BonusType exclusionType) { }

	// RVA: 0x1D7D74C Offset: 0x1D7974C VA: 0x1D7D74C
	public bool SetCurrentSlot(int slot) { }

	// RVA: 0x1D7BC90 Offset: 0x1D77C90 VA: 0x1D7BC90
	public int[] GetMaterialDatas() { }

	// RVA: 0x1D7E024 Offset: 0x1D7A024 VA: 0x1D7E024
	public bool CheckMaterial(PlayerDataManager pdata) { }

	// RVA: 0x1D803F0 Offset: 0x1D7C3F0 VA: 0x1D803F0
	public float GetPotentialRate(BonusType[] exclusionType) { }

	// RVA: 0x1D79F18 Offset: 0x1D75F18 VA: 0x1D79F18
	public bool SetEnhance(bool isFixed, Pair<int, int>[] enhance) { }

	// RVA: 0x1D7ED44 Offset: 0x1D7AD44 VA: 0x1D7ED44
	public short[] GetEnhanceTypeProperties() { }

	// RVA: 0x1D7EE64 Offset: 0x1D7AE64 VA: 0x1D7EE64
	public short[] GetEnhanceValueProperties() { }
}
