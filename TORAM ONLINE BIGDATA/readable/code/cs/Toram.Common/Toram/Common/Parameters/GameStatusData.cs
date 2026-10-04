// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class GameStatusData : UnityHashBase // TypeDefIndex: 11117
{
	// Fields
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x26
	[CompilerGenerated]
	private int <ExpI>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <ExpL>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ComboExp>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 25, IsOptional = True)]
	public int Hp { get; set; }
	[UnityHash(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[UnityHash(Code = 26, IsOptional = True)]
	public short Mp { get; set; }
	[UnityHash(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }
	[UnityHash(Code = 27, IsOptional = True)]
	public int ExpI { get; set; }
	[UnityHash(Code = 192, IsOptional = True)]
	public long ExpL { get; set; }
	public long Exp { get; }
	[UnityHash(Code = 222, IsOptional = True)]
	public int ComboExp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35BED40 Offset: 0x35BAD40 VA: 0x35BED40
	public void .ctor() { }

	// RVA: 0x35BED48 Offset: 0x35BAD48 VA: 0x35BED48
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35BED50 Offset: 0x35BAD50 VA: 0x35BED50
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x35BED58 Offset: 0x35BAD58 VA: 0x35BED58
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BED60 Offset: 0x35BAD60 VA: 0x35BED60
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x35BED68 Offset: 0x35BAD68 VA: 0x35BED68
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BED70 Offset: 0x35BAD70 VA: 0x35BED70
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x35BED78 Offset: 0x35BAD78 VA: 0x35BED78
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x35BED80 Offset: 0x35BAD80 VA: 0x35BED80
	public short get_ExMp() { }

	[CompilerGenerated]
	// RVA: 0x35BED88 Offset: 0x35BAD88 VA: 0x35BED88
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x35BED90 Offset: 0x35BAD90 VA: 0x35BED90
	public int get_ExpI() { }

	[CompilerGenerated]
	// RVA: 0x35BED98 Offset: 0x35BAD98 VA: 0x35BED98
	public void set_ExpI(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BEDA0 Offset: 0x35BADA0 VA: 0x35BEDA0
	public long get_ExpL() { }

	[CompilerGenerated]
	// RVA: 0x35BEDA8 Offset: 0x35BADA8 VA: 0x35BEDA8
	public void set_ExpL(long value) { }

	// RVA: 0x35BEDB0 Offset: 0x35BADB0 VA: 0x35BEDB0
	public long get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x35BEDB8 Offset: 0x35BADB8 VA: 0x35BEDB8
	public int get_ComboExp() { }

	[CompilerGenerated]
	// RVA: 0x35BEDC0 Offset: 0x35BADC0 VA: 0x35BEDC0
	public void set_ComboExp(int value) { }

	// RVA: 0x35BEDC8 Offset: 0x35BADC8 VA: 0x35BEDC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35BEDD0 Offset: 0x35BADD0 VA: 0x35BEDD0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35BF32C Offset: 0x35BB32C VA: 0x35BF32C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
