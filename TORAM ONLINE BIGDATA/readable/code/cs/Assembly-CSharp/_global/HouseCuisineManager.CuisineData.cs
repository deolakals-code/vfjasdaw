// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseCuisineManager.CuisineData // TypeDefIndex: 1968
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x14
	private TimeSpan endTimer; // 0x18
	private DateTime endUpdateTimer; // 0x20

	// Properties
	public int Id { get; set; }
	public byte Level { get; set; }
	public TimeSpan EndTimer { get; }
	internal bool HasData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2117D20 Offset: 0x2113D20 VA: 0x2117D20
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x2117D28 Offset: 0x2113D28 VA: 0x2117D28
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x2117D30 Offset: 0x2113D30 VA: 0x2117D30
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x2117D38 Offset: 0x2113D38 VA: 0x2117D38
	public void set_Level(byte value) { }

	// RVA: 0x2117854 Offset: 0x2113854 VA: 0x2117854
	public TimeSpan get_EndTimer() { }

	// RVA: 0x21166C4 Offset: 0x21126C4 VA: 0x21166C4
	internal bool get_HasData() { }

	// RVA: 0x21155F0 Offset: 0x21115F0 VA: 0x21155F0
	internal void LoadCuisine(int id, byte lv, int end) { }

	// RVA: 0x211558C Offset: 0x211158C VA: 0x211558C
	public void .ctor() { }
}
