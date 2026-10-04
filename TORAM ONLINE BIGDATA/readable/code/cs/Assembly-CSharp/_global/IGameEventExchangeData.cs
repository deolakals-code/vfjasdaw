// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IGameEventExchangeData // TypeDefIndex: 1844
{
	// Properties
	public abstract short PointEventShopId { get; }
	public abstract bool IsInit { get; }
	public abstract short InitErrCode { get; }
	public abstract bool IsExchangeRunConnect { get; }
	public abstract short ExchangeRunErrCode { get; }
	public abstract RewardData ExchangeRunRewardData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract short get_PointEventShopId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsInit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract short get_InitErrCode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsExchangeRunConnect();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract short get_ExchangeRunErrCode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract RewardData get_ExchangeRunRewardData();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ExchangeRun(byte wxchType, int nowNum, PointShopRewarDataBase rewardMaster, int getCount);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool GetRewardTypePoint(ExchangeType type, ExchangeMethod method, out int point);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetRewardNum(short rewardId);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int GetRewardNum(PointShopRewarDataBase.IGetRewardMaster getMaster, short rewardId);
}
