// Assembly: System.dll
// Namespace: System.ComponentModel
public class EnumConverter : TypeConverter // TypeDefIndex: 14252
{
	// Fields
	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected Type EnumType { get; }
	protected TypeConverter.StandardValuesCollection Values { get; set; }
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0x34B5768 Offset: 0x34B1768 VA: 0x34B5768
	public void .ctor(Type type) { }

	// RVA: 0x34B5798 Offset: 0x34B1798 VA: 0x34B5798
	protected Type get_EnumType() { }

	// RVA: 0x34B57A0 Offset: 0x34B17A0 VA: 0x34B57A0
	protected TypeConverter.StandardValuesCollection get_Values() { }

	// RVA: 0x34B57A8 Offset: 0x34B17A8 VA: 0x34B57A8
	protected void set_Values(TypeConverter.StandardValuesCollection value) { }

	// RVA: 0x34B57B0 Offset: 0x34B17B0 VA: 0x34B57B0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x34B58C0 Offset: 0x34B18C0 VA: 0x34B58C0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x34B59D0 Offset: 0x34B19D0 VA: 0x34B59D0 Slot: 16
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x34B5A28 Offset: 0x34B1A28 VA: 0x34B5A28 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34B5F4C Offset: 0x34B1F4C VA: 0x34B5F4C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34B6D58 Offset: 0x34B2D58 VA: 0x34B6D58 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x34B714C Offset: 0x34B314C VA: 0x34B714C Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x34B71F4 Offset: 0x34B31F4 VA: 0x34B71F4 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34B71FC Offset: 0x34B31FC VA: 0x34B71FC Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }
}
