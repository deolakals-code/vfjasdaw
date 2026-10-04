// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackRankingSendData_Roll : ScoreAttackScoreData_Roll // TypeDefIndex: 11271
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x36D4B84 Offset: 0x36D0B84 VA: 0x36D4B84
	public void .ctor() { }

	// RVA: 0x36D4B8C Offset: 0x36D0B8C VA: 0x36D4B8C
	public void .ctor(string name, long rPoint, long point, byte mainWeapon, byte subWeapon, short lv) { }

	[CompilerGenerated]
	// RVA: 0x36D4BF4 Offset: 0x36D0BF4 VA: 0x36D4BF4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36D4BFC Offset: 0x36D0BFC VA: 0x36D4BFC
	public void set_Name(string value) { }

	// RVA: 0x36D4C04 Offset: 0x36D0C04 VA: 0x36D4C04 Slot: 3
	public override string ToString() { }

	// RVA: 0x36D4ED8 Offset: 0x36D0ED8 VA: 0x36D4ED8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D4F24 Offset: 0x36D0F24 VA: 0x36D4F24 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
