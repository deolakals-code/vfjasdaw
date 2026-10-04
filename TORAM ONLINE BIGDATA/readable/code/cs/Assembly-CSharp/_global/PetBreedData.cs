// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetBreedData : IPetBreedData // TypeDefIndex: 1290
{
	// Fields
	private PetTamedCalculator tamedCalclator; // 0x10
	private PetStaminaCalculator staminaCalclator; // 0x18
	private PetFoodEffectCalculator foodEffectCalculator; // 0x20
	[CompilerGenerated]
	private short <Train>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <NotLimitUp>k__BackingField; // 0x2A

	// Properties
	public PetHungerType Hunger { get; }
	public int Stamina { get; }
	public int Affinity { get; }
	public byte FeedEffect { get; }
	public short Train { get; set; }
	public bool IsGroggy { get; }
	public bool NotLimitUp { get; set; }

	// Methods

	// RVA: 0x1FB374C Offset: 0x1FAF74C VA: 0x1FB374C Slot: 6
	public PetHungerType get_Hunger() { }

	// RVA: 0x1FB3768 Offset: 0x1FAF768 VA: 0x1FB3768 Slot: 5
	public int get_Stamina() { }

	// RVA: 0x1FB3834 Offset: 0x1FAF834 VA: 0x1FB3834 Slot: 4
	public int get_Affinity() { }

	// RVA: 0x1FB3850 Offset: 0x1FAF850 VA: 0x1FB3850 Slot: 8
	public byte get_FeedEffect() { }

	[CompilerGenerated]
	// RVA: 0x1FB386C Offset: 0x1FAF86C VA: 0x1FB386C Slot: 9
	public short get_Train() { }

	[CompilerGenerated]
	// RVA: 0x1FB3874 Offset: 0x1FAF874 VA: 0x1FB3874
	private void set_Train(short value) { }

	// RVA: 0x1FB387C Offset: 0x1FAF87C VA: 0x1FB387C Slot: 7
	public bool get_IsGroggy() { }

	[CompilerGenerated]
	// RVA: 0x1FB38B0 Offset: 0x1FAF8B0 VA: 0x1FB38B0 Slot: 10
	public bool get_NotLimitUp() { }

	[CompilerGenerated]
	// RVA: 0x1FB38B8 Offset: 0x1FAF8B8 VA: 0x1FB38B8
	public void set_NotLimitUp(bool value) { }

	// RVA: 0x1FB38C4 Offset: 0x1FAF8C4 VA: 0x1FB38C4
	public void .ctor() { }

	// RVA: 0x1FB39F0 Offset: 0x1FAF9F0 VA: 0x1FB39F0
	public void .ctor(PetBreedStatusData breedStatus) { }

	// RVA: 0x1FB3B1C Offset: 0x1FAFB1C VA: 0x1FB3B1C
	public void Update(float deltaTime) { }

	// RVA: 0x1FB3A18 Offset: 0x1FAFA18 VA: 0x1FB3A18 Slot: 11
	public void SetServerData(PetBreedStatusData breed) { }

	// RVA: 0x1FB3F04 Offset: 0x1FAFF04 VA: 0x1FB3F04
	public void SetNonedata() { }
}
