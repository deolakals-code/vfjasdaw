// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios
public class RandomRewardData : BinaryBase // TypeDefIndex: 11086
{
	// Fields
	[CompilerGenerated]
	private int <RandomId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <RewardType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x28

	// Properties
	[BinaryParameter]
	public int RandomId { get; set; }
	[BinaryParameter]
	public byte RewardType { get; set; }
	[BinaryParameter]
	public int Value { get; set; }
	[BinaryParameter]
	public int Num { get; set; }

	// Methods

	// RVA: 0x35B56F0 Offset: 0x35B16F0 VA: 0x35B56F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35B56F8 Offset: 0x35B16F8 VA: 0x35B56F8
	public int get_RandomId() { }

	[CompilerGenerated]
	// RVA: 0x35B5700 Offset: 0x35B1700 VA: 0x35B5700
	public void set_RandomId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B5708 Offset: 0x35B1708 VA: 0x35B5708
	public byte get_RewardType() { }

	[CompilerGenerated]
	// RVA: 0x35B5710 Offset: 0x35B1710 VA: 0x35B5710
	public void set_RewardType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B5718 Offset: 0x35B1718 VA: 0x35B5718
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x35B5720 Offset: 0x35B1720 VA: 0x35B5720
	public void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B5728 Offset: 0x35B1728 VA: 0x35B5728
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x35B5730 Offset: 0x35B1730 VA: 0x35B5730
	public void set_Num(int value) { }

	// RVA: 0x35B5738 Offset: 0x35B1738 VA: 0x35B5738 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B586C Offset: 0x35B186C VA: 0x35B586C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
