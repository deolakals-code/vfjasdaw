// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UITrade.TradeHistoryData // TypeDefIndex: 8081
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Dictionary<int, short> <MyItemList>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<long> <MyStarGemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <MyGold>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<int, short> <TargetItemList>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<long> <TargetStarGemList>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <TargetGold>k__BackingField; // 0x40

	// Properties
	public int TargetId { get; set; }
	public Dictionary<int, short> MyItemList { get; set; }
	public List<long> MyStarGemList { get; set; }
	public int MyGold { get; set; }
	public Dictionary<int, short> TargetItemList { get; set; }
	public List<long> TargetStarGemList { get; set; }
	public int TargetGold { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CC50C4 Offset: 0x1CC10C4 VA: 0x1CC50C4
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x1CC50CC Offset: 0x1CC10CC VA: 0x1CC50CC
	private void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1CC50D4 Offset: 0x1CC10D4 VA: 0x1CC50D4
	public Dictionary<int, short> get_MyItemList() { }

	[CompilerGenerated]
	// RVA: 0x1CC50DC Offset: 0x1CC10DC VA: 0x1CC50DC
	private void set_MyItemList(Dictionary<int, short> value) { }

	[CompilerGenerated]
	// RVA: 0x1CC50E4 Offset: 0x1CC10E4 VA: 0x1CC50E4
	public List<long> get_MyStarGemList() { }

	[CompilerGenerated]
	// RVA: 0x1CC50EC Offset: 0x1CC10EC VA: 0x1CC50EC
	private void set_MyStarGemList(List<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1CC50F4 Offset: 0x1CC10F4 VA: 0x1CC50F4
	public int get_MyGold() { }

	[CompilerGenerated]
	// RVA: 0x1CC50FC Offset: 0x1CC10FC VA: 0x1CC50FC
	private void set_MyGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x1CC5104 Offset: 0x1CC1104 VA: 0x1CC5104
	public Dictionary<int, short> get_TargetItemList() { }

	[CompilerGenerated]
	// RVA: 0x1CC510C Offset: 0x1CC110C VA: 0x1CC510C
	private void set_TargetItemList(Dictionary<int, short> value) { }

	[CompilerGenerated]
	// RVA: 0x1CC5114 Offset: 0x1CC1114 VA: 0x1CC5114
	public List<long> get_TargetStarGemList() { }

	[CompilerGenerated]
	// RVA: 0x1CC511C Offset: 0x1CC111C VA: 0x1CC511C
	private void set_TargetStarGemList(List<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1CC5124 Offset: 0x1CC1124 VA: 0x1CC5124
	public int get_TargetGold() { }

	[CompilerGenerated]
	// RVA: 0x1CC512C Offset: 0x1CC112C VA: 0x1CC512C
	private void set_TargetGold(int value) { }

	// RVA: 0x1CC5134 Offset: 0x1CC1134 VA: 0x1CC5134
	public void .ctor() { }

	// RVA: 0x1CC4144 Offset: 0x1CC0144 VA: 0x1CC4144
	public void .ctor(int targetUuid, Dictionary<int, short> myItemList, int myGold, Dictionary<int, short> targetItemList, int targetGold) { }

	// RVA: 0x1CC4240 Offset: 0x1CC0240 VA: 0x1CC4240
	public void SetStarGemData(List<long> myStarGemList, List<long> targetStarGemList) { }

	// RVA: 0x1CC526C Offset: 0x1CC126C VA: 0x1CC526C
	public bool CheckHistoryData(int targetUuid, Dictionary<int, short> myItemList, List<long> myStarGemList, int myGold, Dictionary<int, short> targetItemList, List<long> targetStarGemList, int targetGold) { }
}
