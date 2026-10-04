// Assembly: System.dll
// Namespace: System.ComponentModel
public class NullableConverter : TypeConverter // TypeDefIndex: 14221
{
	// Fields
	[CompilerGenerated]
	private readonly Type <NullableType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Properties
	public Type NullableType { get; }
	public Type UnderlyingType { get; }
	public TypeConverter UnderlyingTypeConverter { get; }

	// Methods

	// RVA: 0x34ACCF0 Offset: 0x34A8CF0 VA: 0x34ACCF0
	public void .ctor(Type type) { }

	// RVA: 0x34ACE3C Offset: 0x34A8E3C VA: 0x34ACE3C Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x34ACF00 Offset: 0x34A8F00 VA: 0x34ACF00 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34AD03C Offset: 0x34A903C VA: 0x34AD03C Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x34AD100 Offset: 0x34A9100 VA: 0x34AD100 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34AD2EC Offset: 0x34A92EC VA: 0x34AD2EC Slot: 8
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x34AD310 Offset: 0x34A9310 VA: 0x34AD310 Slot: 9
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34AD334 Offset: 0x34A9334 VA: 0x34AD334 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x34AD358 Offset: 0x34A9358 VA: 0x34AD358 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34AD37C Offset: 0x34A937C VA: 0x34AD37C Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x34AD748 Offset: 0x34A9748 VA: 0x34AD748 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x34AD770 Offset: 0x34A9770 VA: 0x34AD770 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34AD798 Offset: 0x34A9798 VA: 0x34AD798 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	[CompilerGenerated]
	// RVA: 0x34AD7CC Offset: 0x34A97CC VA: 0x34AD7CC
	public Type get_NullableType() { }

	[CompilerGenerated]
	// RVA: 0x34AD7D4 Offset: 0x34A97D4 VA: 0x34AD7D4
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	// RVA: 0x34AD7DC Offset: 0x34A97DC VA: 0x34AD7DC
	public TypeConverter get_UnderlyingTypeConverter() { }
}
