// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetTamedCalculator // TypeDefIndex: 1303
{
	// Fields
	private const int hungerHour = 4;
	private const int tamedHour = 8;
	private const int tamedSubValue = 250;
	private float diffTime; // 0x10
	private int defaultTamedValue; // 0x14
	private long oldHour; // 0x18
	[CompilerGenerated]
	private int <TamedValue>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetHungerType <Hunger>k__BackingField; // 0x24

	// Properties
	public int TamedValue { get; set; }
	public PetHungerType Hunger { get; set; }
	private long Minutes { get; }
	private long Hour { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FB7A08 Offset: 0x1FB3A08 VA: 0x1FB7A08
	public int get_TamedValue() { }

	[CompilerGenerated]
	// RVA: 0x1FB7A10 Offset: 0x1FB3A10 VA: 0x1FB7A10
	private void set_TamedValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FB7A18 Offset: 0x1FB3A18 VA: 0x1FB7A18
	public PetHungerType get_Hunger() { }

	[CompilerGenerated]
	// RVA: 0x1FB7A20 Offset: 0x1FB3A20 VA: 0x1FB7A20
	private void set_Hunger(PetHungerType value) { }

	// RVA: 0x1FB7A28 Offset: 0x1FB3A28 VA: 0x1FB7A28
	private long get_Minutes() { }

	// RVA: 0x1FB7A6C Offset: 0x1FB3A6C VA: 0x1FB7A6C
	private long get_Hour() { }

	// RVA: 0x1FB39B4 Offset: 0x1FAF9B4 VA: 0x1FB39B4
	public void .ctor() { }

	// RVA: 0x1FB3D50 Offset: 0x1FAFD50 VA: 0x1FB3D50
	public void SetServerData(int tamedValue, TimeSpan diffTime) { }

	// RVA: 0x1FB3BCC Offset: 0x1FAFBCC VA: 0x1FB3BCC
	public void Update(float deltaTime) { }
}
