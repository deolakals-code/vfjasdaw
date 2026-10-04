// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetStaminaCalculator // TypeDefIndex: 1302
{
	// Fields
	private const int healPoint = 20;
	private int defaultStamina; // 0x10
	private float diffTime; // 0x14
	private PetBreedStateType state; // 0x18

	// Properties
	public int StaminaValue { get; }
	private int Minutes { get; }
	public bool IsGroggy { get; }

	// Methods

	// RVA: 0x1FB37D8 Offset: 0x1FAF7D8 VA: 0x1FB37D8
	public int get_StaminaValue() { }

	// RVA: 0x1FB79C8 Offset: 0x1FB39C8 VA: 0x1FB79C8
	private int get_Minutes() { }

	// RVA: 0x1FB38A0 Offset: 0x1FAF8A0 VA: 0x1FB38A0
	public bool get_IsGroggy() { }

	// RVA: 0x1FB3C78 Offset: 0x1FAFC78 VA: 0x1FB3C78
	public void Update(float deltaTime) { }

	// RVA: 0x1FB3DE0 Offset: 0x1FAFDE0 VA: 0x1FB3DE0
	public void SetServerData(int sraminaValue, TimeSpan diffTime, PetBreedStateType state) { }

	// RVA: 0x1FB39E0 Offset: 0x1FAF9E0 VA: 0x1FB39E0
	public void .ctor() { }
}
