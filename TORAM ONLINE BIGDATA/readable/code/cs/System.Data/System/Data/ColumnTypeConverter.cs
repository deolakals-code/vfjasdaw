// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 14672
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0x31DC9D8 Offset: 0x31D89D8 VA: 0x31DC9D8
	public void .ctor() { }

	// RVA: 0x31DC9E0 Offset: 0x31D89E0 VA: 0x31DC9E0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x31DCAA8 Offset: 0x31D8AA8 VA: 0x31DCAA8 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x31DCFA8 Offset: 0x31D8FA8 VA: 0x31DCFA8 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x31DD070 Offset: 0x31D9070 VA: 0x31DD070 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x31DD278 Offset: 0x31D9278 VA: 0x31DD278 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x31DD398 Offset: 0x31D9398 VA: 0x31DD398 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x31DD3A0 Offset: 0x31D93A0 VA: 0x31DD3A0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x31DD3A8 Offset: 0x31D93A8 VA: 0x31DD3A8
	private static void .cctor() { }
}
