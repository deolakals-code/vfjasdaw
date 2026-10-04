// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Fishing
public class FishingFishData : BinaryBase // TypeDefIndex: 11193
{
	// Fields
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <FishId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Size>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <FishingDate>k__BackingField; // 0x28

	// Properties
	public short Index { get; set; }
	public int FishId { get; set; }
	public int Size { get; set; }
	public DateTime FishingDate { get; set; }

	// Methods

	// RVA: 0x35D5DCC Offset: 0x35D1DCC VA: 0x35D5DCC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35D5DD4 Offset: 0x35D1DD4 VA: 0x35D5DD4
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35D5DDC Offset: 0x35D1DDC VA: 0x35D5DDC
	public void set_Index(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D5DE4 Offset: 0x35D1DE4 VA: 0x35D5DE4
	public int get_FishId() { }

	[CompilerGenerated]
	// RVA: 0x35D5DEC Offset: 0x35D1DEC VA: 0x35D5DEC
	public void set_FishId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D5DF4 Offset: 0x35D1DF4 VA: 0x35D5DF4
	public int get_Size() { }

	[CompilerGenerated]
	// RVA: 0x35D5DFC Offset: 0x35D1DFC VA: 0x35D5DFC
	public void set_Size(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D5E04 Offset: 0x35D1E04 VA: 0x35D5E04
	public DateTime get_FishingDate() { }

	[CompilerGenerated]
	// RVA: 0x35D5E0C Offset: 0x35D1E0C VA: 0x35D5E0C
	public void set_FishingDate(DateTime value) { }

	// RVA: 0x35D5E14 Offset: 0x35D1E14 VA: 0x35D5E14 Slot: 3
	public override string ToString() { }

	// RVA: 0x35D6018 Offset: 0x35D2018 VA: 0x35D6018 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D6074 Offset: 0x35D2074 VA: 0x35D6074 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
