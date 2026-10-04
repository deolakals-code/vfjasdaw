// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackMyRankData_Roll : ScoreAttackScoreData_Roll // TypeDefIndex: 11270
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

	// RVA: 0x36D4A24 Offset: 0x36D0A24 VA: 0x36D4A24
	public void .ctor() { }

	// RVA: 0x36D4A2C Offset: 0x36D0A2C VA: 0x36D4A2C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36D4A34 Offset: 0x36D0A34 VA: 0x36D4A34
	public int get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x36D4A3C Offset: 0x36D0A3C VA: 0x36D4A3C
	public void set_Rank(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D4A44 Offset: 0x36D0A44 VA: 0x36D4A44
	public byte get_Tier() { }

	[CompilerGenerated]
	// RVA: 0x36D4A4C Offset: 0x36D0A4C VA: 0x36D4A4C
	public void set_Tier(byte value) { }

	// RVA: 0x36D4A54 Offset: 0x36D0A54 VA: 0x36D4A54 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D4AB0 Offset: 0x36D0AB0 VA: 0x36D4AB0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
