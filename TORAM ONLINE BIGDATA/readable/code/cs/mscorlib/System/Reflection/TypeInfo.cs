// Assembly: mscorlib.dll
// Namespace: System.Reflection
public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 10630
{
	// Fields
	private const BindingFlags DeclaredOnlyLookup = 62;

	// Properties
	public virtual IEnumerable<Type> ImplementedInterfaces { get; }

	// Methods

	// RVA: 0x2F2FE18 Offset: 0x2F2BE18 VA: 0x2F2FE18
	protected void .ctor() { }

	// RVA: 0x2F304C0 Offset: 0x2F2C4C0 VA: 0x2F304C0 Slot: 129
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0x2F304C4 Offset: 0x2F2C4C4 VA: 0x2F304C4 Slot: 130
	public virtual IEnumerable<Type> get_ImplementedInterfaces() { }
}
