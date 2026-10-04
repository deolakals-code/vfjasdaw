// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ProduceDataBase // TypeDefIndex: 1972
{
	// Fields
	public readonly short Index; // 0x10
	public readonly int ProduceId; // 0x14
	protected int growthParam; // 0x18
	protected DateTime updateTimer; // 0x20
	protected int nextGropUpTime; // 0x28
	[CompilerGenerated]
	private byte <WaterParam>k__BackingField; // 0x2C

	// Properties
	public virtual byte Type { get; }
	public byte WaterParam { get; set; }
	public virtual int WaterLostTime { get; }
	public virtual bool IsWaterMax { get; }
	public virtual int GrowthParam { get; }
	public virtual byte GrowthPercent { get; }
	public virtual bool IsHarvest { get; }

	// Methods

	// RVA: 0x2117D54 Offset: 0x2113D54 VA: 0x2117D54 Slot: 4
	public virtual byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x2117D5C Offset: 0x2113D5C VA: 0x2117D5C
	public byte get_WaterParam() { }

	[CompilerGenerated]
	// RVA: 0x2117D64 Offset: 0x2113D64 VA: 0x2117D64
	private void set_WaterParam(byte value) { }

	// RVA: 0x2117D6C Offset: 0x2113D6C VA: 0x2117D6C Slot: 5
	public virtual int get_WaterLostTime() { }

	// RVA: 0x2117D74 Offset: 0x2113D74 VA: 0x2117D74 Slot: 6
	public virtual bool get_IsWaterMax() { }

	// RVA: 0x2117D84 Offset: 0x2113D84 VA: 0x2117D84 Slot: 7
	public virtual int get_GrowthParam() { }

	// RVA: 0x2117D8C Offset: 0x2113D8C VA: 0x2117D8C Slot: 8
	public virtual byte get_GrowthPercent() { }

	// RVA: 0x2117D94 Offset: 0x2113D94 VA: 0x2117D94 Slot: 9
	public virtual bool get_IsHarvest() { }

	// RVA: 0x2117D9C Offset: 0x2113D9C VA: 0x2117D9C
	public void .ctor(short index, int produceId, int growthParam, byte waterParam, int nextGropUpTime) { }

	// RVA: 0x2117EBC Offset: 0x2113EBC VA: 0x2117EBC
	public void UpdateWaterData(byte waterParam) { }

	// RVA: 0x2117E48 Offset: 0x2113E48 VA: 0x2117E48
	public void UpdateGrowData(int growParam, int nextGropUpTime) { }
}
