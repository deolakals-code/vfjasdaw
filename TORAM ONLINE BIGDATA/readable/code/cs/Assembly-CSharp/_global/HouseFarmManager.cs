// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseFarmManager // TypeDefIndex: 1976
{
	// Fields
	private Dictionary<short, ProduceDataBase> produceData; // 0x10
	private Dictionary<short, GameObject> produceModel; // 0x18
	private Dictionary<short, EventArea> produceEventArea; // 0x20
	private Dictionary<int, short> priceList; // 0x28
	private byte[] produceCostData; // 0x30
	public RewardData[] HarvestRewardData; // 0x38
	private bool isInitDataFlag; // 0x40
	private List<short> areaFieldIndex; // 0x48
	private bool isNeedWater; // 0x50

	// Properties
	public ProduceDataBase[] ProduceData { get; }

	// Methods

	// RVA: 0x21181B0 Offset: 0x21141B0 VA: 0x21181B0
	public ProduceDataBase[] get_ProduceData() { }

	// RVA: 0x211821C Offset: 0x211421C VA: 0x211821C
	public void LoadProduce(CultivationSendData[] cultivationSendData) { }

	// RVA: 0x21185D0 Offset: 0x21145D0 VA: 0x21185D0
	public void EnterGardenWater(bool isNeedWater) { }

	// RVA: 0x21185DC Offset: 0x21145DC VA: 0x21185DC
	public bool TryGetProduce(short index, out ProduceDataBase data) { }

	// RVA: 0x2118654 Offset: 0x2114654 VA: 0x2118654
	public void GetProduce() { }

	// RVA: 0x21186BC Offset: 0x21146BC VA: 0x21186BC
	public ProduceDataBase AddProduce(byte type, short index, int produceId, int growthParam, byte waterParam) { }

	// RVA: 0x2118434 Offset: 0x2114434 VA: 0x2118434
	private bool AddProduceDataArea(short index, byte type, ProduceDataBase produceDataBase) { }

	// RVA: 0x21187D8 Offset: 0x21147D8 VA: 0x21187D8
	public void RemoveProduce(short index) { }

	// RVA: 0x2118B4C Offset: 0x2114B4C VA: 0x2118B4C
	public bool AddProduceModel(ProduceDataBase updateData, GameObject model) { }

	// RVA: 0x2118F60 Offset: 0x2114F60 VA: 0x2118F60
	public bool UpdateProduceModel(ProduceDataBase updateData) { }

	// RVA: 0x2118E00 Offset: 0x2114E00 VA: 0x2118E00
	private bool UpdateProduceModel(ProduceDataBase updateData, GameObject model) { }

	// RVA: 0x2118FE8 Offset: 0x2114FE8 VA: 0x2118FE8
	public bool IsAllWaterMax() { }

	// RVA: 0x21191B0 Offset: 0x21151B0 VA: 0x21191B0
	public int GetCultivationCreatePoint(int produceId) { }

	// RVA: 0x2119228 Offset: 0x2115228 VA: 0x2119228
	public void ReceiveCultivationCreatePoint(Dictionary<int, short> priceList) { }

	// RVA: 0x2119230 Offset: 0x2115230 VA: 0x2119230
	public bool CultivationHarvest(short index) { }

	// RVA: 0x211930C Offset: 0x211530C VA: 0x211930C
	public void ReceiveCultivationHarvest(CultivationHarvestResponse res) { }

	// RVA: 0x21193B4 Offset: 0x21153B4 VA: 0x21193B4
	public void ReceiveCultivationWatering(CultivationWateringResponse res) { }

	// RVA: 0x2119584 Offset: 0x2115584 VA: 0x2119584
	public bool CheckFieldIndex(short index, byte type) { }

	// RVA: 0x2119798 Offset: 0x2115798 VA: 0x2119798
	public int CheckItemTypeCost(byte type) { }

	// RVA: 0x2119824 Offset: 0x2115824 VA: 0x2119824
	public bool StartEdit() { }

	// RVA: 0x2119ABC Offset: 0x2115ABC VA: 0x2119ABC
	public void EnabledProduceItemEditEvent(bool flag) { }

	// RVA: 0x2119C88 Offset: 0x2115C88 VA: 0x2119C88
	public void OnEnter() { }

	// RVA: 0x2119F20 Offset: 0x2115F20 VA: 0x2119F20
	public void OnLeave() { }

	// RVA: 0x211A378 Offset: 0x2116378 VA: 0x211A378
	public void .ctor() { }
}
