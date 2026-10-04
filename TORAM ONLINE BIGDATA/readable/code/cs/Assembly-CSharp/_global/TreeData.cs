// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreeData : ProduceDataBase // TypeDefIndex: 1973
{
	// Fields
	private const int waterTime = 86400;

	// Properties
	public override byte Type { get; }
	public override byte GrowthPercent { get; }
	public override bool IsWaterMax { get; }
	public override bool IsHarvest { get; }

	// Methods

	// RVA: 0x2117EC4 Offset: 0x2113EC4 VA: 0x2117EC4
	public void .ctor(CultivationSendData data) { }

	// RVA: 0x2117EEC Offset: 0x2113EEC VA: 0x2117EEC
	public void .ctor(short index, int produceId, int growthParam, byte waterParam) { }

	// RVA: 0x2117EF8 Offset: 0x2113EF8 VA: 0x2117EF8 Slot: 4
	public override byte get_Type() { }

	// RVA: 0x2117F00 Offset: 0x2113F00 VA: 0x2117F00 Slot: 8
	public override byte get_GrowthPercent() { }

	// RVA: 0x2117F2C Offset: 0x2113F2C VA: 0x2117F2C Slot: 6
	public override bool get_IsWaterMax() { }

	// RVA: 0x2117F34 Offset: 0x2113F34 VA: 0x2117F34 Slot: 9
	public override bool get_IsHarvest() { }
}
