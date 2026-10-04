// Assembly: System.Data.dll
// Namespace: System.Data
internal abstract class AutoIncrementValue // TypeDefIndex: 14644
{
	// Fields
	[CompilerGenerated]
	private bool <Auto>k__BackingField; // 0x10

	// Properties
	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x31C4BA0 Offset: 0x31C0BA0 VA: 0x31C4BA0
	internal bool get_Auto() { }

	[CompilerGenerated]
	// RVA: 0x31C4BA8 Offset: 0x31C0BA8 VA: 0x31C4BA8
	internal void set_Auto(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void set_Current(object value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract long get_Seed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void set_Seed(long value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract long get_Step();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void set_Step(long value);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Type get_DataType();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void SetCurrentAndIncrement(object value);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void MoveAfter();

	// RVA: 0x31C3C48 Offset: 0x31BFC48 VA: 0x31C3C48
	internal AutoIncrementValue Clone() { }

	// RVA: 0x31C4BB4 Offset: 0x31C0BB4 VA: 0x31C4BB4
	protected void .ctor() { }
}
