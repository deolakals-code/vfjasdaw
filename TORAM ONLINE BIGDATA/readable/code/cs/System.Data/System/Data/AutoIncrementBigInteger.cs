// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 14646
{
	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x31C511C Offset: 0x31C111C VA: 0x31C511C Slot: 4
	internal override object get_Current() { }

	// RVA: 0x31C5178 Offset: 0x31C1178 VA: 0x31C5178 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x31C51F8 Offset: 0x31C11F8 VA: 0x31C51F8 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x31C5264 Offset: 0x31C1264 VA: 0x31C5264 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x31C526C Offset: 0x31C126C VA: 0x31C526C Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x31C5488 Offset: 0x31C1488 VA: 0x31C5488 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x31C54E8 Offset: 0x31C14E8 VA: 0x31C54E8 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x31C5694 Offset: 0x31C1694 VA: 0x31C5694 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x31C5728 Offset: 0x31C1728 VA: 0x31C5728 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x31C5758 Offset: 0x31C1758 VA: 0x31C5758 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x31C5360 Offset: 0x31C1360 VA: 0x31C5360
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x31BFC1C Offset: 0x31BBC1C VA: 0x31BFC1C
	public void .ctor() { }
}
