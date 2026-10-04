// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Fishing
public class FishingData : BinaryBase // TypeDefIndex: 11192
{
	// Fields
	[CompilerGenerated]
	private short <BagCapacity>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <EquipRodIndex>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ChummingFieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ChummingCount>k__BackingField; // 0x24
	[CompilerGenerated]
	private FishingRodData[] <Rods>k__BackingField; // 0x28
	[CompilerGenerated]
	private FishingFishData[] <Fishes>k__BackingField; // 0x30

	// Properties
	public short BagCapacity { get; set; }
	public byte EquipRodIndex { get; set; }
	public int ChummingFieldId { get; set; }
	public byte ChummingCount { get; set; }
	public FishingRodData[] Rods { get; set; }
	public FishingFishData[] Fishes { get; set; }

	// Methods

	// RVA: 0x35D5A24 Offset: 0x35D1A24 VA: 0x35D5A24
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35D5A2C Offset: 0x35D1A2C VA: 0x35D5A2C
	public short get_BagCapacity() { }

	[CompilerGenerated]
	// RVA: 0x35D5A34 Offset: 0x35D1A34 VA: 0x35D5A34
	public void set_BagCapacity(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D5A3C Offset: 0x35D1A3C VA: 0x35D5A3C
	public byte get_EquipRodIndex() { }

	[CompilerGenerated]
	// RVA: 0x35D5A44 Offset: 0x35D1A44 VA: 0x35D5A44
	public void set_EquipRodIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D5A4C Offset: 0x35D1A4C VA: 0x35D5A4C
	public int get_ChummingFieldId() { }

	[CompilerGenerated]
	// RVA: 0x35D5A54 Offset: 0x35D1A54 VA: 0x35D5A54
	public void set_ChummingFieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D5A5C Offset: 0x35D1A5C VA: 0x35D5A5C
	public byte get_ChummingCount() { }

	[CompilerGenerated]
	// RVA: 0x35D5A64 Offset: 0x35D1A64 VA: 0x35D5A64
	public void set_ChummingCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D5A6C Offset: 0x35D1A6C VA: 0x35D5A6C
	public FishingRodData[] get_Rods() { }

	[CompilerGenerated]
	// RVA: 0x35D5A74 Offset: 0x35D1A74 VA: 0x35D5A74
	public void set_Rods(FishingRodData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D5A7C Offset: 0x35D1A7C VA: 0x35D5A7C
	public FishingFishData[] get_Fishes() { }

	[CompilerGenerated]
	// RVA: 0x35D5A84 Offset: 0x35D1A84 VA: 0x35D5A84
	public void set_Fishes(FishingFishData[] value) { }

	// RVA: 0x35D5A8C Offset: 0x35D1A8C VA: 0x35D5A8C Slot: 3
	public override string ToString() { }

	// RVA: 0x35D5B80 Offset: 0x35D1B80 VA: 0x35D5B80 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D5C54 Offset: 0x35D1C54 VA: 0x35D5C54 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
