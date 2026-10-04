// Assembly: System.dll
// Namespace: System.ComponentModel
public class ReferenceConverter : TypeConverter // TypeDefIndex: 14227
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x34B0CF4 Offset: 0x34ACCF4 VA: 0x34B0CF4
	public void .ctor(Type type) { }

	// RVA: 0x34B0D24 Offset: 0x34ACD24 VA: 0x34B0D24 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x34B0DF0 Offset: 0x34ACDF0 VA: 0x34B0DF0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34B1138 Offset: 0x34AD138 VA: 0x34B1138 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34B1588 Offset: 0x34AD588 VA: 0x34B1588 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x34B1DC0 Offset: 0x34ADDC0 VA: 0x34B1DC0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x34B1DC8 Offset: 0x34ADDC8 VA: 0x34B1DC8 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34B1DD0 Offset: 0x34ADDD0 VA: 0x34B1DD0 Slot: 16
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x34B1DD8 Offset: 0x34ADDD8 VA: 0x34B1DD8
	private static void .cctor() { }
}
