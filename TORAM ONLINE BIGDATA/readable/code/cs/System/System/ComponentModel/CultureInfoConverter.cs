// Assembly: System.dll
// Namespace: System.ComponentModel
public class CultureInfoConverter : TypeConverter // TypeDefIndex: 14190
{
	// Fields
	private TypeConverter.StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Properties
	private string DefaultCultureString { get; }

	// Methods

	// RVA: 0x34A0FE4 Offset: 0x349CFE4 VA: 0x34A0FE4
	private string get_DefaultCultureString() { }

	// RVA: 0x34A1024 Offset: 0x349D024 VA: 0x34A1024 Slot: 16
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x34A1048 Offset: 0x349D048 VA: 0x34A1048 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x34A1110 Offset: 0x349D110 VA: 0x34A1110 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x34A11D8 Offset: 0x349D1D8 VA: 0x34A11D8 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34A1B8C Offset: 0x349DB8C VA: 0x34A1B8C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A2010 Offset: 0x349E010 VA: 0x34A2010 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x34A2258 Offset: 0x349E258 VA: 0x34A2258 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x34A2260 Offset: 0x349E260 VA: 0x34A2260 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34A2268 Offset: 0x349E268 VA: 0x34A2268
	public void .ctor() { }
}
