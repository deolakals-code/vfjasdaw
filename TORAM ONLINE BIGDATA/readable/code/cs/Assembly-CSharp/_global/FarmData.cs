// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FarmData : ProduceDataBase // TypeDefIndex: 1974
{
	// Fields
	private const int waterTime = 10800;

	// Properties
	public override byte Type { get; }
	public override byte GrowthPercent { get; }
	public override bool IsHarvest { get; }
	public override int WaterLostTime { get; }

	// Methods

	// RVA: 0x2117F44 Offset: 0x2113F44 VA: 0x2117F44
	public void .ctor(CultivationSendData data) { }

	// RVA: 0x2117F6C Offset: 0x2113F6C VA: 0x2117F6C
	public void .ctor(short index, int produceId, int growParam, byte waterParam) { }

	// RVA: 0x2117F74 Offset: 0x2113F74 VA: 0x2117F74 Slot: 4
	public override byte get_Type() { }

	// RVA: 0x2117F7C Offset: 0x2113F7C VA: 0x2117F7C Slot: 8
	public override byte get_GrowthPercent() { }

	// RVA: 0x2117F84 Offset: 0x2113F84 VA: 0x2117F84 Slot: 9
	public override bool get_IsHarvest() { }

	// RVA: 0x2117F94 Offset: 0x2113F94 VA: 0x2117F94 Slot: 5
	public override int get_WaterLostTime() { }
}
