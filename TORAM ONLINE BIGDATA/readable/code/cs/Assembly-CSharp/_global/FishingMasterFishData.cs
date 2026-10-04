// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FishingMasterFishData // TypeDefIndex: 4344
{
	// Fields
	private int minSize; // 0x10
	private int stdSize; // 0x14
	private int maxSize; // 0x18
	private readonly int foodPoint; // 0x1C
	[CompilerGenerated]
	private int <FishId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Color1>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Color2>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Color3>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <RareFlag>k__BackingField; // 0x34

	// Properties
	public int FishId { get; set; }
	public int MinSize { get; set; }
	public int StdSize { get; set; }
	public int MaxSize { get; set; }
	public int ModelId { get; set; }
	public int Color1 { get; set; }
	public int Color2 { get; set; }
	public int Color3 { get; set; }
	public bool RareFlag { get; set; }

	// Methods

	// RVA: 0x24D2DA8 Offset: 0x24CEDA8 VA: 0x24D2DA8
	public static Dictionary<int, FishingMasterFishData> LoadMasterData(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x24D66DC Offset: 0x24D26DC VA: 0x24D66DC
	public int get_FishId() { }

	[CompilerGenerated]
	// RVA: 0x24D66E4 Offset: 0x24D26E4 VA: 0x24D66E4
	private void set_FishId(int value) { }

	// RVA: 0x24D66EC Offset: 0x24D26EC VA: 0x24D66EC
	public int get_MinSize() { }

	// RVA: 0x24D66FC Offset: 0x24D26FC VA: 0x24D66FC
	private void set_MinSize(int value) { }

	// RVA: 0x24D6704 Offset: 0x24D2704 VA: 0x24D6704
	public int get_StdSize() { }

	// RVA: 0x24D6714 Offset: 0x24D2714 VA: 0x24D6714
	private void set_StdSize(int value) { }

	// RVA: 0x24D671C Offset: 0x24D271C VA: 0x24D671C
	public int get_MaxSize() { }

	// RVA: 0x24D672C Offset: 0x24D272C VA: 0x24D672C
	private void set_MaxSize(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D6734 Offset: 0x24D2734 VA: 0x24D6734
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x24D673C Offset: 0x24D273C VA: 0x24D673C
	private void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D6744 Offset: 0x24D2744 VA: 0x24D6744
	public int get_Color1() { }

	[CompilerGenerated]
	// RVA: 0x24D674C Offset: 0x24D274C VA: 0x24D674C
	private void set_Color1(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D6754 Offset: 0x24D2754 VA: 0x24D6754
	public int get_Color2() { }

	[CompilerGenerated]
	// RVA: 0x24D675C Offset: 0x24D275C VA: 0x24D675C
	private void set_Color2(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D6764 Offset: 0x24D2764 VA: 0x24D6764
	public int get_Color3() { }

	[CompilerGenerated]
	// RVA: 0x24D676C Offset: 0x24D276C VA: 0x24D676C
	private void set_Color3(int value) { }

	[CompilerGenerated]
	// RVA: 0x24D6774 Offset: 0x24D2774 VA: 0x24D6774
	public bool get_RareFlag() { }

	[CompilerGenerated]
	// RVA: 0x24D677C Offset: 0x24D277C VA: 0x24D677C
	private void set_RareFlag(bool value) { }

	// RVA: 0x24D6788 Offset: 0x24D2788 VA: 0x24D6788
	private void .ctor(int fishId, int minSize, int stdSize, int maxSize, int foodPoint, int modelId, int color1, int color2, int color3, bool rareFlag) { }

	// RVA: 0x24D65C0 Offset: 0x24D25C0 VA: 0x24D65C0
	private void .ctor(int version, BinaryReader read) { }

	// RVA: 0x24D680C Offset: 0x24D280C VA: 0x24D680C
	public int GetFoodPoint(int size) { }

	// RVA: 0x24D68B4 Offset: 0x24D28B4 VA: 0x24D68B4
	public bool CheckBigSize(int size) { }

	// RVA: 0x24D68F4 Offset: 0x24D28F4 VA: 0x24D68F4
	public bool CheckMinSize(int size) { }
}
