// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider // TypeDefIndex: 10601
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual Module Module { get; }
	public virtual int MetadataToken { get; }

	// Methods

	// RVA: 0x2F29A7C Offset: 0x2F25A7C VA: 0x2F29A7C
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: 0x2F2B414 Offset: 0x2F27414 VA: 0x2F2B414 Slot: 11
	public virtual Module get_Module() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: 0x2F2B4E8 Offset: 0x2F274E8 VA: 0x2F2B4E8 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0x2F29D24 Offset: 0x2F25D24 VA: 0x2F29D24 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F29D34 Offset: 0x2F25D34 VA: 0x2F29D34 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F1C108 Offset: 0x2F18108 VA: 0x2F1C108
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x2F1C464 Offset: 0x2F18464 VA: 0x2F1C464
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }
}
