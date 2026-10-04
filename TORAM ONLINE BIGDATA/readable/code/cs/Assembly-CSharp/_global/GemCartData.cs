// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GemCartData // TypeDefIndex: 2289
{
	// Fields
	[CompilerGenerated]
	private short <GemNo>k__BackingField; // 0x10
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x18
	[CompilerGenerated]
	private short <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x24

	// Properties
	public short GemNo { get; set; }
	public long Uuid { get; set; }
	public short Id { get; set; }
	public short Lv { get; set; }
	public byte Flag { get; set; }
	public bool IsLock { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x217C518 Offset: 0x2178518 VA: 0x217C518
	public short get_GemNo() { }

	[CompilerGenerated]
	// RVA: 0x217C520 Offset: 0x2178520 VA: 0x217C520
	private void set_GemNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x217C528 Offset: 0x2178528 VA: 0x217C528
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x217C530 Offset: 0x2178530 VA: 0x217C530
	private void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x217C538 Offset: 0x2178538 VA: 0x217C538
	public short get_Id() { }

	[CompilerGenerated]
	// RVA: 0x217C540 Offset: 0x2178540 VA: 0x217C540
	private void set_Id(short value) { }

	[CompilerGenerated]
	// RVA: 0x217C548 Offset: 0x2178548 VA: 0x217C548
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x217C550 Offset: 0x2178550 VA: 0x217C550
	private void set_Lv(short value) { }

	[CompilerGenerated]
	// RVA: 0x217C558 Offset: 0x2178558 VA: 0x217C558
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x217C560 Offset: 0x2178560 VA: 0x217C560
	private void set_Flag(byte value) { }

	// RVA: 0x217C568 Offset: 0x2178568 VA: 0x217C568
	public bool get_IsLock() { }

	// RVA: 0x2179834 Offset: 0x2175834 VA: 0x2179834
	public void .ctor(short no, long uuid, short skillId, byte skillLv, byte flag) { }

	// RVA: 0x2179C90 Offset: 0x2175C90 VA: 0x2179C90
	public void .ctor(GemCartData gemCart) { }

	// RVA: 0x217C574 Offset: 0x2178574 VA: 0x217C574
	public void .ctor(GemCartData gemCart) { }

	// RVA: 0x217C5C8 Offset: 0x21785C8 VA: 0x217C5C8
	public void ChangeFlag(GemCartFlag flag) { }
}
