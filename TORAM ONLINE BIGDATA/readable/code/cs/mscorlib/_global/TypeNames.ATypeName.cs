// Assembly: mscorlib.dll
// Namespace: 
internal abstract class TypeNames.ATypeName : TypeName, IEquatable<TypeName> // TypeDefIndex: 9823
{
	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DisplayName();

	// RVA: 0x303D6FC Offset: 0x30396FC VA: 0x303D6FC Slot: 5
	public bool Equals(TypeName other) { }

	// RVA: 0x303D7CC Offset: 0x30397CC VA: 0x303D7CC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x303D7F4 Offset: 0x30397F4 VA: 0x303D7F4 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x303D854 Offset: 0x3039854 VA: 0x303D854
	protected void .ctor() { }
}
