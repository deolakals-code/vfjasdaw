// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetDataManager.PetViewData // TypeDefIndex: 1293
{
	// Fields
	protected PetDataManager.InnerPetInfoData petData; // 0x10
	[CompilerGenerated]
	private PetBreedData <BreedData>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <SeedTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsCandidateStray>k__BackingField; // 0x24

	// Properties
	public PetInfoData PetData { get; }
	public PetBreedData BreedData { get; set; }
	public int SeedTime { get; set; }
	public bool IsCandidateStray { get; set; }

	// Methods

	// RVA: 0x1FB7308 Offset: 0x1FB3308 VA: 0x1FB7308
	public PetInfoData get_PetData() { }

	[CompilerGenerated]
	// RVA: 0x1FB7310 Offset: 0x1FB3310 VA: 0x1FB7310
	public PetBreedData get_BreedData() { }

	[CompilerGenerated]
	// RVA: 0x1FB7318 Offset: 0x1FB3318 VA: 0x1FB7318
	protected void set_BreedData(PetBreedData value) { }

	[CompilerGenerated]
	// RVA: 0x1FB7320 Offset: 0x1FB3320 VA: 0x1FB7320
	public int get_SeedTime() { }

	[CompilerGenerated]
	// RVA: 0x1FB7328 Offset: 0x1FB3328 VA: 0x1FB7328
	public void set_SeedTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FB7330 Offset: 0x1FB3330 VA: 0x1FB7330
	public bool get_IsCandidateStray() { }

	[CompilerGenerated]
	// RVA: 0x1FB7338 Offset: 0x1FB3338 VA: 0x1FB7338
	protected void set_IsCandidateStray(bool value) { }

	// RVA: 0x1FB5284 Offset: 0x1FB1284 VA: 0x1FB5284
	public void .ctor(PetLoginEvent strayData) { }

	// RVA: 0x1FB4D70 Offset: 0x1FB0D70 VA: 0x1FB4D70
	public void .ctor(PetInfoData info) { }

	// RVA: 0x1FB7404 Offset: 0x1FB3404 VA: 0x1FB7404
	public void .ctor(HousePetSaleItemData itemData) { }

	// RVA: 0x1FB7420 Offset: 0x1FB3420 VA: 0x1FB7420
	public void SetName(string name) { }

	// RVA: 0x1FB743C Offset: 0x1FB343C VA: 0x1FB743C
	public void SetSkill(PetSkillData skill) { }

	// RVA: 0x1FB7454 Offset: 0x1FB3454 VA: 0x1FB7454
	public void UpdateSkill(int id, PetSkillData skill) { }

	// RVA: 0x1FB746C Offset: 0x1FB346C VA: 0x1FB746C
	public void SetStatus(PetStatusData status) { }

	// RVA: 0x1FB7488 Offset: 0x1FB3488 VA: 0x1FB7488
	public void SetBreedStatusData(PetBreedStatusData data) { }

	// RVA: 0x1FB74A4 Offset: 0x1FB34A4 VA: 0x1FB74A4
	public void SetPotentialData(PetPotentialData potential) { }

	// RVA: 0x1FB74E8 Offset: 0x1FB34E8 VA: 0x1FB74E8
	public void SetBreedData(PetBreedStatusData data) { }

	// RVA: 0x1FB7344 Offset: 0x1FB3344 VA: 0x1FB7344
	public void SetServerData(PetInfoData info) { }
}
