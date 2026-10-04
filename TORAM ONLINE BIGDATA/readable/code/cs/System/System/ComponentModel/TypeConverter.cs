// Assembly: System.dll
// Namespace: System.ComponentModel
[ComVisible(True)]
public class TypeConverter // TypeDefIndex: 14260
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x34C2590 Offset: 0x34BE590 VA: 0x34C2590
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x34C25E0 Offset: 0x34BE5E0 VA: 0x34C25E0
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x34C25F4 Offset: 0x34BE5F4 VA: 0x34C25F4 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x34C267C Offset: 0x34BE67C VA: 0x34C267C
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x34C2690 Offset: 0x34BE690 VA: 0x34C2690 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x34C2718 Offset: 0x34BE718 VA: 0x34C2718
	public object ConvertFrom(object value) { }

	// RVA: 0x34C2794 Offset: 0x34BE794 VA: 0x34C2794 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34C2C98 Offset: 0x34BEC98 VA: 0x34C2C98
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x34C2D20 Offset: 0x34BED20 VA: 0x34C2D20
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x34C2DA0 Offset: 0x34BEDA0 VA: 0x34C2DA0
	public object ConvertFromString(string text) { }

	// RVA: 0x34C2DB8 Offset: 0x34BEDB8 VA: 0x34C2DB8
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x34C2D14 Offset: 0x34BED14 VA: 0x34C2D14
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x34C2E38 Offset: 0x34BEE38 VA: 0x34C2E38
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x34C2E54 Offset: 0x34BEE54 VA: 0x34C2E54 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34C3200 Offset: 0x34BF200 VA: 0x34C3200
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x34C3350 Offset: 0x34BF350 VA: 0x34C3350
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x34C33C8 Offset: 0x34BF3C8 VA: 0x34C33C8
	public string ConvertToString(object value) { }

	// RVA: 0x34C34C8 Offset: 0x34BF4C8 VA: 0x34C34C8
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x34C3274 Offset: 0x34BF274 VA: 0x34C3274
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34C35CC Offset: 0x34BF5CC VA: 0x34C35CC
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x34C35E0 Offset: 0x34BF5E0 VA: 0x34C35E0 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x34C2B6C Offset: 0x34BEB6C VA: 0x34C2B6C
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x34C3088 Offset: 0x34BF088 VA: 0x34C3088
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x34C35E8 Offset: 0x34BF5E8 VA: 0x34C35E8
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x34C35F8 Offset: 0x34BF5F8 VA: 0x34C35F8 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34C3600 Offset: 0x34BF600 VA: 0x34C3600
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x34C360C Offset: 0x34BF60C VA: 0x34C360C
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x34C3708 Offset: 0x34BF708 VA: 0x34C3708 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x34C3710 Offset: 0x34BF710 VA: 0x34C3710
	public bool GetPropertiesSupported() { }

	// RVA: 0x34C3720 Offset: 0x34BF720 VA: 0x34C3720 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34C3728 Offset: 0x34BF728 VA: 0x34C3728
	public ICollection GetStandardValues() { }

	// RVA: 0x34C3738 Offset: 0x34BF738 VA: 0x34C3738 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x34C3740 Offset: 0x34BF740 VA: 0x34C3740
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x34C3754 Offset: 0x34BF754 VA: 0x34C3754 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x34C375C Offset: 0x34BF75C VA: 0x34C375C
	public bool GetStandardValuesSupported() { }

	// RVA: 0x34C3770 Offset: 0x34BF770 VA: 0x34C3770 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34C3778 Offset: 0x34BF778 VA: 0x34C3778
	public bool IsValid(object value) { }

	// RVA: 0x34C3790 Offset: 0x34BF790 VA: 0x34C3790 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x34C38D0 Offset: 0x34BF8D0 VA: 0x34C38D0
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x34C3908 Offset: 0x34BF908 VA: 0x34C3908
	public void .ctor() { }
}
