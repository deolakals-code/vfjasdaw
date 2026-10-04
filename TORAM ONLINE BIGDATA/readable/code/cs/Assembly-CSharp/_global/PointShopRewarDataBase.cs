// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PointShopRewarDataBase // TypeDefIndex: 1847
{
	// Fields
	public readonly short Uid; // 0x10
	public readonly byte ExchangeItemNo; // 0x12
	public readonly int NecessaryPoint; // 0x14
	public readonly short OpenExchange; // 0x18
	public readonly RewardData RewardData; // 0x20
	[CompilerGenerated]
	private byte <ExchType>k__BackingField; // 0x28

	// Properties
	public byte ExchType { get; set; }

	// Methods

	// RVA: 0x20F03B8 Offset: 0x20EC3B8 VA: 0x20F03B8
	public static PointShopRewarDataBase LoadData(BinaryReader reader) { }

	// RVA: 0x20F07EC Offset: 0x20EC7EC VA: 0x20F07EC
	public static string GetRewardName(SystemTextManager systemTextManager, RewardData rewardData) { }

	// RVA: 0x20F0BD0 Offset: 0x20ECBD0 VA: 0x20F0BD0
	public static string GetRewardText(SystemTextManager systemTextManager, RewardData rewardData, int num = 1) { }

	// RVA: 0x20F0DB4 Offset: 0x20ECDB4 VA: 0x20F0DB4
	public static string GetRewardValueText(SystemTextManager systemTextManager, byte rewardType) { }

	// RVA: 0x20F0EAC Offset: 0x20ECEAC VA: 0x20F0EAC
	public static string GetRewardIcon(SystemTextManager systemTextManager, RewardData rewardData) { }

	[CompilerGenerated]
	// RVA: 0x20F0F3C Offset: 0x20ECF3C VA: 0x20F0F3C
	public byte get_ExchType() { }

	[CompilerGenerated]
	// RVA: 0x20F0F44 Offset: 0x20ECF44 VA: 0x20F0F44
	protected void set_ExchType(byte value) { }

	// RVA: 0x20F0F4C Offset: 0x20ECF4C VA: 0x20F0F4C
	public void .ctor(short uid, byte exchangeItemNo, int point, RewardData reward, short openExchange) { }

	// RVA: 0x20F0FB0 Offset: 0x20ECFB0 VA: 0x20F0FB0 Slot: 4
	public virtual Dictionary<byte, int> GetResultCheckData() { }
}
