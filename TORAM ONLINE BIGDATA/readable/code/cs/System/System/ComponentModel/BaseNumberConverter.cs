// Assembly: System.dll
// Namespace: System.ComponentModel
public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 14181
{
	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x349FC7C Offset: 0x349BC7C VA: 0x349FC7C
	internal void .ctor() { }

	// RVA: 0x349FC84 Offset: 0x349BC84 VA: 0x349FC84 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x349FC8C Offset: 0x349BC8C VA: 0x349FC8C Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x349FD54 Offset: 0x349BD54 VA: 0x349FD54 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34A014C Offset: 0x349C14C VA: 0x34A014C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A03EC Offset: 0x349C3EC VA: 0x34A03EC Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }
}
