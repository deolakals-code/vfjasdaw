// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackMyRankData_Solo : ScoreAttackScoreData_Solo // TypeDefIndex: 11269
{
	// Fields
	[CompilerGenerated]
	private int <Rank>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <Tier>k__BackingField; // 0x3C

	// Properties
	public int Rank { get; set; }
	public byte Tier { get; set; }

	// Methods

	// RVA: 0x36D48D0 Offset: 0x36D08D0 VA: 0x36D48D0
	public void .ctor() { }

	// RVA: 0x36D48D8 Offset: 0x36D08D8 VA: 0x36D48D8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36D48E0 Offset: 0x36D08E0 VA: 0x36D48E0
	public int get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x36D48E8 Offset: 0x36D08E8 VA: 0x36D48E8
	public void set_Rank(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D48F0 Offset: 0x36D08F0 VA: 0x36D48F0
	public byte get_Tier() { }

	[CompilerGenerated]
	// RVA: 0x36D48F8 Offset: 0x36D08F8 VA: 0x36D48F8
	public void set_Tier(byte value) { }

	// RVA: 0x36D4900 Offset: 0x36D0900 VA: 0x36D4900 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D4950 Offset: 0x36D0950 VA: 0x36D4950 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
