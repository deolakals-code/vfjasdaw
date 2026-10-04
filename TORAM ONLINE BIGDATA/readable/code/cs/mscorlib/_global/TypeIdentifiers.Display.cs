// Assembly: mscorlib.dll
// Namespace: 
private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 9825
{
	// Fields
	private string displayName; // 0x10
	private string internal_name; // 0x18

	// Properties
	public override string DisplayName { get; }
	public string InternalName { get; }

	// Methods

	// RVA: 0x303D8C4 Offset: 0x30398C4 VA: 0x303D8C4
	internal void .ctor(string displayName) { }

	// RVA: 0x303D8E8 Offset: 0x30398E8 VA: 0x303D8E8 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x303D8F0 Offset: 0x30398F0 VA: 0x303D8F0 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x303D930 Offset: 0x3039930 VA: 0x303D930
	private string GetInternalName() { }
}
