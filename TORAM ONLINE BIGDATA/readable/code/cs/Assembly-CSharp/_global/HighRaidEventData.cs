// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighRaidEventData // TypeDefIndex: 1858
{
	// Fields
	[CompilerGenerated]
	private List<byte> <HighRaidList>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<byte> <HighRaidExchangeList>k__BackingField; // 0x18
	private Dictionary<short, IGameEventExchangeData> highRaidExchangeDataList; // 0x20
	private List<HighRaidBossMasterData> highRaidBossMasterList; // 0x28
	private List<HighRaidExchangeMasterData> highRaidExchangeMasterList; // 0x30
	private List<HighRaidRewardData> highRaidRewardDataList; // 0x38
	private List<HighRaidMaterialMasterData> highRaidMaterialMasterList; // 0x40
	private List<HighRaidTrophyMasterData> highRaidTrophyMasterList; // 0x48
	private Dictionary<byte, Dictionary<byte, byte>> trophyDataList; // 0x50

	// Properties
	public List<byte> HighRaidList { get; set; }
	public List<byte> HighRaidExchangeList { get; set; }
	public bool IsBossMasterNoData { get; }
	public bool IsMaterialMasterNoData { get; }
	public bool IsTrophyMasterNoData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20F1C74 Offset: 0x20EDC74 VA: 0x20F1C74
	public List<byte> get_HighRaidList() { }

	[CompilerGenerated]
	// RVA: 0x20F1C7C Offset: 0x20EDC7C VA: 0x20F1C7C
	private void set_HighRaidList(List<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x20F1C84 Offset: 0x20EDC84 VA: 0x20F1C84
	public List<byte> get_HighRaidExchangeList() { }

	[CompilerGenerated]
	// RVA: 0x20F1C8C Offset: 0x20EDC8C VA: 0x20F1C8C
	private void set_HighRaidExchangeList(List<byte> value) { }

	// RVA: 0x20F1C94 Offset: 0x20EDC94 VA: 0x20F1C94
	public bool get_IsBossMasterNoData() { }

	// RVA: 0x20F1CE4 Offset: 0x20EDCE4 VA: 0x20F1CE4
	public bool get_IsMaterialMasterNoData() { }

	// RVA: 0x20F1D34 Offset: 0x20EDD34 VA: 0x20F1D34
	public bool get_IsTrophyMasterNoData() { }

	// RVA: 0x20EE258 Offset: 0x20EA258 VA: 0x20EE258
	public void Clear() { }

	// RVA: 0x20F1D84 Offset: 0x20EDD84 VA: 0x20F1D84
	public void SetHighRaidList(byte[] list) { }

	// RVA: 0x20F1DE8 Offset: 0x20EDDE8 VA: 0x20F1DE8
	public void SetHighRaidExchangeList(byte[] list) { }

	// RVA: 0x20EEDF0 Offset: 0x20EADF0 VA: 0x20EEDF0
	public void LoadBossMaster(byte[] binary) { }

	// RVA: 0x20F2078 Offset: 0x20EE078 VA: 0x20F2078
	public HighRaidBossMasterData GetBossMasterData(byte no) { }

	// RVA: 0x20F2154 Offset: 0x20EE154 VA: 0x20F2154
	public List<HighRaidRewardData> GetHighRaidRewardData(byte no) { }

	// RVA: 0x20F224C Offset: 0x20EE24C VA: 0x20F224C
	public HighRaidExchangeMasterData GetExchangeMasterData(byte no) { }

	// RVA: 0x20EF768 Offset: 0x20EB768 VA: 0x20EF768
	public void LoadMaterialMaster(byte[] binary) { }

	// RVA: 0x20F2328 Offset: 0x20EE328 VA: 0x20F2328
	public List<HighRaidMaterialMasterData> GetMaterialMasterDataList(byte index) { }

	// RVA: 0x20EFE50 Offset: 0x20EBE50 VA: 0x20EFE50
	public void LoadTrophyMaster(byte[] binary) { }

	// RVA: 0x20F2420 Offset: 0x20EE420 VA: 0x20F2420
	public List<HighRaidTrophyMasterData> GetTrophyMasterDataList(byte no) { }

	// RVA: 0x20F2518 Offset: 0x20EE518 VA: 0x20F2518
	public void SetTrophyData(byte highRaidNo, Dictionary<byte, byte> trophys) { }

	// RVA: 0x20F25E4 Offset: 0x20EE5E4 VA: 0x20F25E4
	public void SetTrophyRewardData(byte highRaidNo, byte trophyId, byte state) { }

	// RVA: 0x20F26EC Offset: 0x20EE6EC VA: 0x20F26EC
	public bool ContainsTrophyData(byte no) { }

	// RVA: 0x20F2744 Offset: 0x20EE744 VA: 0x20F2744
	public bool TrygetTrophyData(byte no, out Dictionary<byte, byte> datas) { }

	// RVA: 0x20F2828 Offset: 0x20EE828 VA: 0x20F2828
	public bool ContainsClearedTrophy(bool isOld) { }

	// RVA: 0x20EE65C Offset: 0x20EA65C VA: 0x20EE65C
	public void .ctor() { }
}
