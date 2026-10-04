// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlowerData : ProduceDataBase // TypeDefIndex: 1975
{
	// Fields
	private const int waterTime = 43200;

	// Properties
	public override byte Type { get; }
	public override byte GrowthPercent { get; }
	public override bool IsHarvest { get; }
	public override int WaterLostTime { get; }

	// Methods

	// RVA: 0x2118068 Offset: 0x2114068 VA: 0x2118068
	public void .ctor(CultivationSendData data) { }

	// RVA: 0x2118090 Offset: 0x2114090 VA: 0x2118090
	public void .ctor(short index, int produceId, int growthParam, byte waterParam) { }

	// RVA: 0x2118098 Offset: 0x2114098 VA: 0x2118098 Slot: 4
	public override byte get_Type() { }

	// RVA: 0x21180A0 Offset: 0x21140A0 VA: 0x21180A0 Slot: 8
	public override byte get_GrowthPercent() { }

	// RVA: 0x21180CC Offset: 0x21140CC VA: 0x21180CC Slot: 9
	public override bool get_IsHarvest() { }

	// RVA: 0x21180DC Offset: 0x21140DC VA: 0x21180DC Slot: 5
	public override int get_WaterLostTime() { }
}
