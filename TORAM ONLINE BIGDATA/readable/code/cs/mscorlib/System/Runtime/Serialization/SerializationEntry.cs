// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[IsReadOnly]
public struct SerializationEntry // TypeDefIndex: 10335
{
	// Fields
	private readonly string _name; // 0x0
	private readonly object _value; // 0x8
	private readonly Type _type; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x2EFA978 Offset: 0x2EF6978 VA: 0x2EFA978
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

	// RVA: 0x2EFA9BC Offset: 0x2EF69BC VA: 0x2EFA9BC
	public object get_Value() { }

	// RVA: 0x2EFA9C4 Offset: 0x2EF69C4 VA: 0x2EFA9C4
	public string get_Name() { }
}
