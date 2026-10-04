// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions
public class CompanionStatusDataBase : BinaryBase // TypeDefIndex: 12943
{
	// Fields
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <MaxHp>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Atk>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Matk>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Def>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Mdef>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Hit>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Flee>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Aspd>k__BackingField; // 0x38

	// Properties
	public short Lv { get; set; }
	public int MaxHp { get; set; }
	public int Atk { get; set; }
	public int Matk { get; set; }
	public int Def { get; set; }
	public int Mdef { get; set; }
	public int Hit { get; set; }
	public int Flee { get; set; }
	public int Aspd { get; set; }

	// Methods

	// RVA: 0x367E01C Offset: 0x367A01C VA: 0x367E01C
	public void .ctor() { }

	// RVA: 0x367E024 Offset: 0x367A024 VA: 0x367E024
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x367E02C Offset: 0x367A02C VA: 0x367E02C
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x367E034 Offset: 0x367A034 VA: 0x367E034
	protected void set_Lv(short value) { }

	[CompilerGenerated]
	// RVA: 0x367E03C Offset: 0x367A03C VA: 0x367E03C
	public int get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x367E044 Offset: 0x367A044 VA: 0x367E044
	protected void set_MaxHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E04C Offset: 0x367A04C VA: 0x367E04C
	public int get_Atk() { }

	[CompilerGenerated]
	// RVA: 0x367E054 Offset: 0x367A054 VA: 0x367E054
	protected void set_Atk(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E05C Offset: 0x367A05C VA: 0x367E05C
	public int get_Matk() { }

	[CompilerGenerated]
	// RVA: 0x367E064 Offset: 0x367A064 VA: 0x367E064
	protected void set_Matk(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E06C Offset: 0x367A06C VA: 0x367E06C
	public int get_Def() { }

	[CompilerGenerated]
	// RVA: 0x367E074 Offset: 0x367A074 VA: 0x367E074
	protected void set_Def(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E07C Offset: 0x367A07C VA: 0x367E07C
	public int get_Mdef() { }

	[CompilerGenerated]
	// RVA: 0x367E084 Offset: 0x367A084 VA: 0x367E084
	protected void set_Mdef(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E08C Offset: 0x367A08C VA: 0x367E08C
	public int get_Hit() { }

	[CompilerGenerated]
	// RVA: 0x367E094 Offset: 0x367A094 VA: 0x367E094
	protected void set_Hit(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E09C Offset: 0x367A09C VA: 0x367E09C
	public int get_Flee() { }

	[CompilerGenerated]
	// RVA: 0x367E0A4 Offset: 0x367A0A4 VA: 0x367E0A4
	protected void set_Flee(int value) { }

	[CompilerGenerated]
	// RVA: 0x367E0AC Offset: 0x367A0AC VA: 0x367E0AC
	public int get_Aspd() { }

	[CompilerGenerated]
	// RVA: 0x367E0B4 Offset: 0x367A0B4 VA: 0x367E0B4
	protected void set_Aspd(int value) { }

	// RVA: 0x367E0BC Offset: 0x367A0BC VA: 0x367E0BC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x367E254 Offset: 0x367A254 VA: 0x367E254 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x367E300 Offset: 0x367A300 VA: 0x367E300
	public static Dictionary<short, byte> GetSkills(byte[] skillBin) { }
}
