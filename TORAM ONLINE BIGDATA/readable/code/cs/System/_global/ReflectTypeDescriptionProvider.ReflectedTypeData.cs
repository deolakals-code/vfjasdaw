// Assembly: System.dll
// Namespace: 
private class ReflectTypeDescriptionProvider.ReflectedTypeData // TypeDefIndex: 14256
{
	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	// Properties
	internal bool IsPopulated { get; }

	// Methods

	// RVA: 0x34C11B8 Offset: 0x34BD1B8 VA: 0x34C11B8
	internal void .ctor(Type type) { }

	// RVA: 0x34C11E8 Offset: 0x34BD1E8 VA: 0x34C11E8
	internal bool get_IsPopulated() { }

	// RVA: 0x34C1204 Offset: 0x34BD204 VA: 0x34C1204
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x34C1B30 Offset: 0x34BDB30 VA: 0x34C1B30
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x34C2210 Offset: 0x34BE210 VA: 0x34C2210
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x34C2064 Offset: 0x34BE064 VA: 0x34C2064
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x34C2520 Offset: 0x34BE520 VA: 0x34C2520
	internal void Refresh() { }
}
