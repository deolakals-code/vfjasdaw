// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackScoreData_Roll : ScoreAttackScoreDataBase // TypeDefIndex: 11268
{
	// Fields
	[CompilerGenerated]
	private long <RollPoint>k__BackingField; // 0x30

	// Properties
	public long RollPoint { get; set; }

	// Methods

	// RVA: 0x36D4510 Offset: 0x36D0510 VA: 0x36D4510
	public void .ctor() { }

	// RVA: 0x36D4518 Offset: 0x36D0518 VA: 0x36D4518
	public void .ctor(byte[] binary) { }

	// RVA: 0x36D4520 Offset: 0x36D0520 VA: 0x36D4520
	public void .ctor(long rPoint, long point, byte mainWeapon, byte subWeapon, short lv) { }

	[CompilerGenerated]
	// RVA: 0x36D4578 Offset: 0x36D0578 VA: 0x36D4578
	public long get_RollPoint() { }

	[CompilerGenerated]
	// RVA: 0x36D4580 Offset: 0x36D0580 VA: 0x36D4580
	public void set_RollPoint(long value) { }

	// RVA: 0x36D4588 Offset: 0x36D0588 VA: 0x36D4588 Slot: 3
	public override string ToString() { }

	// RVA: 0x36D47D8 Offset: 0x36D07D8 VA: 0x36D47D8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D4814 Offset: 0x36D0814 VA: 0x36D4814 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
