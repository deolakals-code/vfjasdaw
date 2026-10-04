// Assembly: mscorlib.dll
// Namespace: System.Resources
internal struct ResourceLocator // TypeDefIndex: 10563
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x2F2417C Offset: 0x2F2017C VA: 0x2F2417C
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x2F25790 Offset: 0x2F21790 VA: 0x2F25790
	internal int get_DataPosition() { }

	// RVA: 0x2F25798 Offset: 0x2F21798 VA: 0x2F25798
	internal object get_Value() { }

	// RVA: 0x2F257A0 Offset: 0x2F217A0 VA: 0x2F257A0
	internal void set_Value(object value) { }

	// RVA: 0x2F24170 Offset: 0x2F20170 VA: 0x2F24170
	internal static bool CanCache(ResourceTypeCode value) { }
}
