// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackScoreDataBase : BinaryBase // TypeDefIndex: 11266
{
	// Fields
	[CompilerGenerated]
	private long <Point>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MainWeaponType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SubWeaponType>k__BackingField; // 0x29
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x2A

	// Properties
	public long Point { get; set; }
	public byte MainWeaponType { get; set; }
	public byte SubWeaponType { get; set; }
	public short Level { get; set; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x36D39CC Offset: 0x36CF9CC VA: 0x36D39CC
	public void .ctor() { }

	// RVA: 0x36D39D4 Offset: 0x36CF9D4 VA: 0x36D39D4
	public void .ctor(byte[] binary) { }

	// RVA: 0x36D39DC Offset: 0x36CF9DC VA: 0x36D39DC
	public void .ctor(long point, byte mainWeapon, byte subWeapon, short lv) { }

	[CompilerGenerated]
	// RVA: 0x36D3A24 Offset: 0x36CFA24 VA: 0x36D3A24
	public long get_Point() { }

	[CompilerGenerated]
	// RVA: 0x36D3A2C Offset: 0x36CFA2C VA: 0x36D3A2C
	public void set_Point(long value) { }

	[CompilerGenerated]
	// RVA: 0x36D3A34 Offset: 0x36CFA34 VA: 0x36D3A34
	public byte get_MainWeaponType() { }

	[CompilerGenerated]
	// RVA: 0x36D3A3C Offset: 0x36CFA3C VA: 0x36D3A3C
	public void set_MainWeaponType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D3A44 Offset: 0x36CFA44 VA: 0x36D3A44
	public byte get_SubWeaponType() { }

	[CompilerGenerated]
	// RVA: 0x36D3A4C Offset: 0x36CFA4C VA: 0x36D3A4C
	public void set_SubWeaponType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D3A54 Offset: 0x36CFA54 VA: 0x36D3A54
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36D3A5C Offset: 0x36CFA5C VA: 0x36D3A5C
	public void set_Level(short value) { }

	// RVA: 0x36D3A64 Offset: 0x36CFA64 VA: 0x36D3A64
	public bool get_IsEmpty() { }

	// RVA: 0x36D3A74 Offset: 0x36CFA74 VA: 0x36D3A74 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D3AD0 Offset: 0x36CFAD0 VA: 0x36D3AD0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
