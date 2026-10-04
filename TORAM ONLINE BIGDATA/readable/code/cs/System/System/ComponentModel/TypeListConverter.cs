// Assembly: System.dll
// Namespace: System.ComponentModel
public abstract class TypeListConverter : TypeConverter // TypeDefIndex: 14238
{
	// Fields
	private readonly Type[] _types; // 0x10
	private TypeConverter.StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x34B33D4 Offset: 0x34AF3D4 VA: 0x34B33D4
	protected void .ctor(Type[] types) { }

	// RVA: 0x34B3404 Offset: 0x34AF404 VA: 0x34B3404 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x34B34CC Offset: 0x34AF4CC VA: 0x34B34CC Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x34B3594 Offset: 0x34AF594 VA: 0x34B3594 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34B36A4 Offset: 0x34AF6A4 VA: 0x34B36A4 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34B3854 Offset: 0x34AF854 VA: 0x34B3854 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x34B3920 Offset: 0x34AF920 VA: 0x34B3920 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x34B3928 Offset: 0x34AF928 VA: 0x34B3928 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }
}
