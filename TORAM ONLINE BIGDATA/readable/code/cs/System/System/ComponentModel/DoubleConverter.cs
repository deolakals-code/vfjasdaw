// Assembly: System.dll
// Namespace: System.ComponentModel
public class DoubleConverter : BaseNumberConverter // TypeDefIndex: 14199
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x34A8308 Offset: 0x34A4308 VA: 0x34A8308 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x34A8310 Offset: 0x34A4310 VA: 0x34A8310 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x34A837C Offset: 0x34A437C VA: 0x34A837C Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x34A843C Offset: 0x34A443C VA: 0x34A843C Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34A84AC Offset: 0x34A44AC VA: 0x34A84AC Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34A855C Offset: 0x34A455C VA: 0x34A855C
	public void .ctor() { }
}
