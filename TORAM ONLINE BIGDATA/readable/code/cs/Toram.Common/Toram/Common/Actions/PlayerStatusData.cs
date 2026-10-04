// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class PlayerStatusData : UnityHashBase // TypeDefIndex: 13189
{
	// Fields
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <AbnomalDamage>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ComboExp>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 12)]
	public int Hp { get; set; }
	[UnityHash(Code = 13)]
	public short Mp { get; set; }
	[UnityHash(Code = 14, IsOptional = True)]
	public int ExHp { get; set; }
	[UnityHash(Code = 15, IsOptional = True)]
	public short ExMp { get; set; }
	[UnityHash(Code = 49, IsOptional = True)]
	public int AbnomalDamage { get; set; }
	[UnityHash(Code = 16, IsOptional = True)]
	public int ComboExp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C3540 Offset: 0x36BF540 VA: 0x36C3540
	public void .ctor() { }

	// RVA: 0x36B25C8 Offset: 0x36AE5C8 VA: 0x36B25C8
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C3548 Offset: 0x36BF548 VA: 0x36C3548
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36C3550 Offset: 0x36BF550 VA: 0x36C3550
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C3558 Offset: 0x36BF558 VA: 0x36C3558
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x36C3560 Offset: 0x36BF560 VA: 0x36C3560
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C3568 Offset: 0x36BF568 VA: 0x36C3568
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x36C3570 Offset: 0x36BF570 VA: 0x36C3570
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C3578 Offset: 0x36BF578 VA: 0x36C3578
	public short get_ExMp() { }

	[CompilerGenerated]
	// RVA: 0x36C3580 Offset: 0x36BF580 VA: 0x36C3580
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C3588 Offset: 0x36BF588 VA: 0x36C3588
	public int get_AbnomalDamage() { }

	[CompilerGenerated]
	// RVA: 0x36C3590 Offset: 0x36BF590 VA: 0x36C3590
	public void set_AbnomalDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C3598 Offset: 0x36BF598 VA: 0x36C3598
	public int get_ComboExp() { }

	[CompilerGenerated]
	// RVA: 0x36C35A0 Offset: 0x36BF5A0 VA: 0x36C35A0
	public void set_ComboExp(int value) { }

	// RVA: 0x36C35A8 Offset: 0x36BF5A8 VA: 0x36C35A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C35B0 Offset: 0x36BF5B0 VA: 0x36C35B0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C39C4 Offset: 0x36BF9C4 VA: 0x36C39C4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
