// Assembly: Assembly-CSharp.dll
// Namespace: 
private class SyntheticMedicine.CreateMedicine : CreateMedicineExplain, IReconnectionSubData, IReconnectionReceiveResponse // TypeDefIndex: 8718
{
	// Fields
	private SyntheticMedicine manager; // 0x30

	// Methods

	// RVA: 0x1DF6878 Offset: 0x1DF2878 VA: 0x1DF6878
	public void .ctor(SyntheticMedicine manager, int shopId, short[] position, int recipeId, short createNum) { }

	// RVA: 0x1DF68D4 Offset: 0x1DF28D4 VA: 0x1DF68D4
	public void .ctor(SyntheticMedicine manager, int recipeId, short createNum) { }

	// RVA: 0x1DF6928 Offset: 0x1DF2928 VA: 0x1DF6928 Slot: 11
	protected override void OnFailure(short returnCode) { }

	// RVA: 0x1DF692C Offset: 0x1DF292C VA: 0x1DF692C Slot: 10
	protected override void OnSuccess(CreateMedicineResponse response) { }
}
