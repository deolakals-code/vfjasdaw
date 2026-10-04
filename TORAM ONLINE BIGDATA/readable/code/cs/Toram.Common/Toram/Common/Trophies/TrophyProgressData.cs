// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Trophies
public class TrophyProgressData : BinaryBase // TypeDefIndex: 11073
{
	// Fields
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <TrophyType>k__BackingField; // 0x20
	[CompilerGenerated]
	private TrophyProgressData.ProgressData[] <ProgressList>k__BackingField; // 0x28

	// Properties
	public int TrophyId { get; set; }
	public byte TrophyType { get; set; }
	public TrophyProgressData.ProgressData[] ProgressList { get; set; }

	// Methods

	// RVA: 0x35B25F8 Offset: 0x35AE5F8 VA: 0x35B25F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35B2600 Offset: 0x35AE600 VA: 0x35B2600
	public int get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x35B2608 Offset: 0x35AE608 VA: 0x35B2608
	public void set_TrophyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B2610 Offset: 0x35AE610 VA: 0x35B2610
	public byte get_TrophyType() { }

	[CompilerGenerated]
	// RVA: 0x35B2618 Offset: 0x35AE618 VA: 0x35B2618
	public void set_TrophyType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B2620 Offset: 0x35AE620 VA: 0x35B2620
	public TrophyProgressData.ProgressData[] get_ProgressList() { }

	[CompilerGenerated]
	// RVA: 0x35B2628 Offset: 0x35AE628 VA: 0x35B2628
	public void set_ProgressList(TrophyProgressData.ProgressData[] value) { }

	// RVA: 0x35B2630 Offset: 0x35AE630 VA: 0x35B2630 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B26B4 Offset: 0x35AE6B4 VA: 0x35B26B4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
