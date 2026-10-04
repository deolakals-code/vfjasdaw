// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class PrimaryStatusData : UnityHashBase, IPrimaryStatus // TypeDefIndex: 11126
{
	// Fields
	public const short StatusValueLimit = 255;
	public const short OverStatusValueLimit = 510;
	public const short OverStatusAvailablePoint = 500;
	[CLSCompliant(False)]
	protected short _str; // 0x1A
	[CLSCompliant(False)]
	protected short _int; // 0x1C
	[CLSCompliant(False)]
	protected short _vit; // 0x1E
	[CLSCompliant(False)]
	protected short _agi; // 0x20
	[CLSCompliant(False)]
	protected short _dex; // 0x22
	[CLSCompliant(False)]
	protected short _crt; // 0x24
	[CLSCompliant(False)]
	protected short _luk; // 0x26
	[CLSCompliant(False)]
	protected short _men; // 0x28
	[CLSCompliant(False)]
	protected short _tec; // 0x2A
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <StatusPoint>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <SkillPoint>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Personality>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <ComboPoint>k__BackingField; // 0x33

	// Properties
	public short Lv { get; set; }
	public virtual short Str { get; }
	public virtual short Int { get; }
	public virtual short Vit { get; }
	public virtual short Agi { get; }
	public virtual short Dex { get; }
	public virtual short Crt { get; }
	public virtual short Luk { get; }
	public virtual short Men { get; }
	public virtual short Tec { get; }
	public short StatusPoint { get; set; }
	public short SkillPoint { get; set; }
	public byte Personality { get; set; }
	public byte ComboPoint { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C1E88 Offset: 0x35BDE88 VA: 0x35C1E88
	public void .ctor() { }

	// RVA: 0x35C1E90 Offset: 0x35BDE90 VA: 0x35C1E90
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35C1E98 Offset: 0x35BDE98 VA: 0x35C1E98 Slot: 7
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x35C1EA0 Offset: 0x35BDEA0 VA: 0x35C1EA0
	public void set_Lv(short value) { }

	// RVA: 0x35C1EA8 Offset: 0x35BDEA8 VA: 0x35C1EA8 Slot: 17
	public virtual short get_Str() { }

	// RVA: 0x35C1EB0 Offset: 0x35BDEB0 VA: 0x35C1EB0 Slot: 18
	public virtual short get_Int() { }

	// RVA: 0x35C1EB8 Offset: 0x35BDEB8 VA: 0x35C1EB8 Slot: 19
	public virtual short get_Vit() { }

	// RVA: 0x35C1EC0 Offset: 0x35BDEC0 VA: 0x35C1EC0 Slot: 20
	public virtual short get_Agi() { }

	// RVA: 0x35C1EC8 Offset: 0x35BDEC8 VA: 0x35C1EC8 Slot: 21
	public virtual short get_Dex() { }

	// RVA: 0x35C1ED0 Offset: 0x35BDED0 VA: 0x35C1ED0 Slot: 22
	public virtual short get_Crt() { }

	// RVA: 0x35C1ED8 Offset: 0x35BDED8 VA: 0x35C1ED8 Slot: 23
	public virtual short get_Luk() { }

	// RVA: 0x35C1EE0 Offset: 0x35BDEE0 VA: 0x35C1EE0 Slot: 24
	public virtual short get_Men() { }

	// RVA: 0x35C1EE8 Offset: 0x35BDEE8 VA: 0x35C1EE8 Slot: 25
	public virtual short get_Tec() { }

	[CompilerGenerated]
	// RVA: 0x35C1EF0 Offset: 0x35BDEF0 VA: 0x35C1EF0
	public short get_StatusPoint() { }

	[CompilerGenerated]
	// RVA: 0x35C1EF8 Offset: 0x35BDEF8 VA: 0x35C1EF8
	public void set_StatusPoint(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C1F00 Offset: 0x35BDF00 VA: 0x35C1F00
	public short get_SkillPoint() { }

	[CompilerGenerated]
	// RVA: 0x35C1F08 Offset: 0x35BDF08 VA: 0x35C1F08
	public void set_SkillPoint(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C1F10 Offset: 0x35BDF10 VA: 0x35C1F10
	public byte get_Personality() { }

	[CompilerGenerated]
	// RVA: 0x35C1F18 Offset: 0x35BDF18 VA: 0x35C1F18
	public void set_Personality(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C1F20 Offset: 0x35BDF20 VA: 0x35C1F20
	public byte get_ComboPoint() { }

	[CompilerGenerated]
	// RVA: 0x35C1F28 Offset: 0x35BDF28 VA: 0x35C1F28
	public void set_ComboPoint(byte value) { }

	// RVA: 0x35C1F30 Offset: 0x35BDF30 VA: 0x35C1F30 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C2288 Offset: 0x35BE288 VA: 0x35C2288
	public bool IsOverStatus() { }

	// RVA: 0x35C23F0 Offset: 0x35BE3F0 VA: 0x35C23F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C23F8 Offset: 0x35BE3F8 VA: 0x35C23F8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C2D68 Offset: 0x35BED68 VA: 0x35C2D68 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
