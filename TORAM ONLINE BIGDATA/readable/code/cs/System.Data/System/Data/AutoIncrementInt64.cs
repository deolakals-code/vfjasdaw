// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 14645
{
	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x31C4BBC Offset: 0x31C0BBC VA: 0x31C4BBC Slot: 4
	internal override object get_Current() { }

	// RVA: 0x31C4C18 Offset: 0x31C0C18 VA: 0x31C4C18 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x31C4C90 Offset: 0x31C0C90 VA: 0x31C4C90 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x31C4CFC Offset: 0x31C0CFC VA: 0x31C4CFC Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x31C4D04 Offset: 0x31C0D04 VA: 0x31C4D04 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x31C4E64 Offset: 0x31C0E64 VA: 0x31C4E64 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x31C4E6C Offset: 0x31C0E6C VA: 0x31C4E6C Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x31C4F2C Offset: 0x31C0F2C VA: 0x31C4F2C Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x31C4F40 Offset: 0x31C0F40 VA: 0x31C4F40 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x31C4FB4 Offset: 0x31C0FB4 VA: 0x31C4FB4 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x31C4D94 Offset: 0x31C0D94 VA: 0x31C4D94
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x31BFC0C Offset: 0x31BBC0C VA: 0x31BFC0C
	public void .ctor() { }
}
