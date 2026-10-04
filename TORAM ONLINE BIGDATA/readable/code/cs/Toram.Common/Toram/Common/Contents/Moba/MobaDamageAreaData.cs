// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaDamageAreaData : BinaryBase // TypeDefIndex: 11211
{
	// Fields
	[CompilerGenerated]
	private short[] <DamageLeftTop>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <DamageRightBottom>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <EnableLeftTop>k__BackingField; // 0x30
	[CompilerGenerated]
	private short[] <EnableRightBottom>k__BackingField; // 0x38
	[CompilerGenerated]
	private TimeSpan <ElapsedTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <DamageSec>k__BackingField; // 0x48

	// Properties
	public short[] DamageLeftTop { get; set; }
	public short[] DamageRightBottom { get; set; }
	public short[] EnableLeftTop { get; set; }
	public short[] EnableRightBottom { get; set; }
	public TimeSpan ElapsedTime { get; set; }
	public short DamageSec { get; set; }

	// Methods

	// RVA: 0x35DA4F8 Offset: 0x35D64F8 VA: 0x35DA4F8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35DA500 Offset: 0x35D6500 VA: 0x35DA500
	public short[] get_DamageLeftTop() { }

	[CompilerGenerated]
	// RVA: 0x35DA508 Offset: 0x35D6508 VA: 0x35DA508
	public void set_DamageLeftTop(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA510 Offset: 0x35D6510 VA: 0x35DA510
	public short[] get_DamageRightBottom() { }

	[CompilerGenerated]
	// RVA: 0x35DA518 Offset: 0x35D6518 VA: 0x35DA518
	public void set_DamageRightBottom(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA520 Offset: 0x35D6520 VA: 0x35DA520
	public short[] get_EnableLeftTop() { }

	[CompilerGenerated]
	// RVA: 0x35DA528 Offset: 0x35D6528 VA: 0x35DA528
	public void set_EnableLeftTop(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA530 Offset: 0x35D6530 VA: 0x35DA530
	public short[] get_EnableRightBottom() { }

	[CompilerGenerated]
	// RVA: 0x35DA538 Offset: 0x35D6538 VA: 0x35DA538
	public void set_EnableRightBottom(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DA540 Offset: 0x35D6540 VA: 0x35DA540
	public TimeSpan get_ElapsedTime() { }

	[CompilerGenerated]
	// RVA: 0x35DA548 Offset: 0x35D6548 VA: 0x35DA548
	public void set_ElapsedTime(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x35DA550 Offset: 0x35D6550 VA: 0x35DA550
	public short get_DamageSec() { }

	[CompilerGenerated]
	// RVA: 0x35DA558 Offset: 0x35D6558 VA: 0x35DA558
	public void set_DamageSec(short value) { }

	// RVA: 0x35DA560 Offset: 0x35D6560 VA: 0x35DA560 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35DA61C Offset: 0x35D661C VA: 0x35DA61C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
