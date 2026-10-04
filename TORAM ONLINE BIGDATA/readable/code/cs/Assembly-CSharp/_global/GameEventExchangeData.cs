// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GameEventExchangeData : IGameEventExchangeData // TypeDefIndex: 1851
{
	// Fields
	private readonly short pointEventShopId; // 0x10
	private bool isInit; // 0x12
	private Dictionary<byte, Dictionary<byte, int>> pointList; // 0x18
	private RewardData resultExchangeRunRewardData; // 0x20
	private Dictionary<short, byte> rewardDataList; // 0x28

	// Properties
	public short PointEventShopId { get; }
	public bool IsInit { get; }
	public short InitErrCode { get; }
	public bool IsExchangeRunConnect { get; }
	public short ExchangeRunErrCode { get; }
	public RewardData ExchangeRunRewardData { get; }

	// Methods

	// RVA: 0x20F1288 Offset: 0x20ED288 VA: 0x20F1288 Slot: 4
	public short get_PointEventShopId() { }

	// RVA: 0x20F1290 Offset: 0x20ED290 VA: 0x20F1290 Slot: 5
	public bool get_IsInit() { }

	// RVA: 0x20F1308 Offset: 0x20ED308 VA: 0x20F1308 Slot: 6
	public short get_InitErrCode() { }

	// RVA: 0x20F1378 Offset: 0x20ED378 VA: 0x20F1378 Slot: 7
	public bool get_IsExchangeRunConnect() { }

	// RVA: 0x20F13D0 Offset: 0x20ED3D0 VA: 0x20F13D0 Slot: 8
	public short get_ExchangeRunErrCode() { }

	// RVA: 0x20F1440 Offset: 0x20ED440 VA: 0x20F1440 Slot: 9
	public RewardData get_ExchangeRunRewardData() { }

	// RVA: 0x20ED794 Offset: 0x20E9794 VA: 0x20ED794
	public void .ctor(short eventShopId) { }

	// RVA: 0x20ED734 Offset: 0x20E9734 VA: 0x20ED734
	public void InitConnect() { }

	// RVA: 0x20F1448 Offset: 0x20ED448 VA: 0x20F1448
	public void ReceiveInitData(ExchangeGetMyDataResponse response) { }

	// RVA: 0x20F1678 Offset: 0x20ED678 VA: 0x20F1678 Slot: 10
	public void ExchangeRun(byte wxchType, int nowNum, PointShopRewarDataBase rewardMaster, int getCount) { }

	// RVA: 0x20F1708 Offset: 0x20ED708 VA: 0x20F1708
	public bool ReceiveRewardData(ExchangeRunResponse response) { }

	// RVA: 0x20F1B38 Offset: 0x20EDB38 VA: 0x20F1B38 Slot: 11
	public bool GetRewardTypePoint(ExchangeType type, ExchangeMethod method, out int point) { }

	// RVA: 0x20F1BF4 Offset: 0x20EDBF4 VA: 0x20F1BF4 Slot: 12
	public int GetRewardNum(short rewardId) { }

	// RVA: 0x20F1BFC Offset: 0x20EDBFC VA: 0x20F1BFC Slot: 13
	public int GetRewardNum(PointShopRewarDataBase.IGetRewardMaster getMaster, short rewardId) { }
}
