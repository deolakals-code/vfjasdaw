// Assembly: System.dll
// Namespace: System.ComponentModel
public class DecimalConverter : BaseNumberConverter // TypeDefIndex: 14193
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x34A719C Offset: 0x34A319C VA: 0x34A719C Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x34A71A4 Offset: 0x34A31A4 VA: 0x34A71A4 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x34A7210 Offset: 0x34A3210 VA: 0x34A7210 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x34A72D4 Offset: 0x34A32D4 VA: 0x34A72D4 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A760C Offset: 0x34A360C VA: 0x34A760C Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x34A76F8 Offset: 0x34A36F8 VA: 0x34A76F8 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34A77A4 Offset: 0x34A37A4 VA: 0x34A77A4 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34A788C Offset: 0x34A388C VA: 0x34A788C
	public void .ctor() { }
}
