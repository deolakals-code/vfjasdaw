// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetFoodEffectCalculator // TypeDefIndex: 1304
{
	// Fields
	private float diffTime; // 0x10
	private PetFoodEffectId defaultFoodId; // 0x14
	private bool isChanged; // 0x18
	[CompilerGenerated]
	private PetFoodEffectId <FoodEffectId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private Action EoodEffectChangeEvent; // 0x20

	// Properties
	public PetFoodEffectId FoodEffectId { get; set; }
	public float FoodEffectValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FB7AB0 Offset: 0x1FB3AB0 VA: 0x1FB7AB0
	public PetFoodEffectId get_FoodEffectId() { }

	[CompilerGenerated]
	// RVA: 0x1FB7AB8 Offset: 0x1FB3AB8 VA: 0x1FB7AB8
	private void set_FoodEffectId(PetFoodEffectId value) { }

	// RVA: 0x1FB7AC0 Offset: 0x1FB3AC0 VA: 0x1FB7AC0
	public float get_FoodEffectValue() { }

	[CompilerGenerated]
	// RVA: 0x1FB7AF0 Offset: 0x1FB3AF0 VA: 0x1FB7AF0
	public void add_EoodEffectChangeEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1FB7B8C Offset: 0x1FB3B8C VA: 0x1FB7B8C
	public void remove_EoodEffectChangeEvent(Action value) { }

	// RVA: 0x1FB3E74 Offset: 0x1FAFE74 VA: 0x1FB3E74
	public void SetServerData(byte foodEffectId, TimeSpan time) { }

	// RVA: 0x1FB3CEC Offset: 0x1FAFCEC VA: 0x1FB3CEC
	public void Update(float deltaTime) { }

	// RVA: 0x1FB39E8 Offset: 0x1FAF9E8 VA: 0x1FB39E8
	public void .ctor() { }
}
