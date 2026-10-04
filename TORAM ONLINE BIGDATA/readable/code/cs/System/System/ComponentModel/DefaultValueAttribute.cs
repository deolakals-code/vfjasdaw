// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 14159
{
	// Fields
	private object _value; // 0x10

	// Properties
	public virtual object Value { get; }

	// Methods

	// RVA: 0x349CF38 Offset: 0x3498F38 VA: 0x349CF38
	public void .ctor(int value) { }

	// RVA: 0x349CFB0 Offset: 0x3498FB0 VA: 0x349CFB0
	public void .ctor(long value) { }

	// RVA: 0x349D028 Offset: 0x3499028 VA: 0x349D028
	public void .ctor(bool value) { }

	// RVA: 0x349D0A4 Offset: 0x34990A4 VA: 0x349D0A4
	public void .ctor(string value) { }

	// RVA: 0x349D0D4 Offset: 0x34990D4 VA: 0x349D0D4
	public void .ctor(object value) { }

	// RVA: 0x349D104 Offset: 0x3499104 VA: 0x349D104 Slot: 7
	public virtual object get_Value() { }

	// RVA: 0x349D10C Offset: 0x349910C VA: 0x349D10C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x349D218 Offset: 0x3499218 VA: 0x349D218 Slot: 2
	public override int GetHashCode() { }
}
