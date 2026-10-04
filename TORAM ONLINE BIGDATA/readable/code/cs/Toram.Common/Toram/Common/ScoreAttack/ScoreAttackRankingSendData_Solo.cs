// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackRankingSendData_Solo : ScoreAttackScoreData_Solo // TypeDefIndex: 11272
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x36D4FF0 Offset: 0x36D0FF0 VA: 0x36D4FF0
	public void .ctor() { }

	// RVA: 0x36D4FF8 Offset: 0x36D0FF8 VA: 0x36D4FF8
	public void .ctor(string name, long point, byte mainWeapon, byte subWeapon, short lv, byte[] cBinary) { }

	[CompilerGenerated]
	// RVA: 0x36D5038 Offset: 0x36D1038 VA: 0x36D5038
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36D5040 Offset: 0x36D1040 VA: 0x36D5040
	public void set_Name(string value) { }

	// RVA: 0x36D5048 Offset: 0x36D1048 VA: 0x36D5048 Slot: 3
	public override string ToString() { }

	// RVA: 0x36D5510 Offset: 0x36D1510 VA: 0x36D5510 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D5550 Offset: 0x36D1550 VA: 0x36D5550 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
