// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class MethodInfo : MethodBase // TypeDefIndex: 10606
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual ParameterInfo ReturnParameter { get; }
	public virtual Type ReturnType { get; }
	internal virtual int GenericParameterCount { get; }

	// Methods

	// RVA: 0x2F2BFB0 Offset: 0x2F27FB0 VA: 0x2F2BFB0
	protected void .ctor() { }

	// RVA: 0x2F2BFB8 Offset: 0x2F27FB8 VA: 0x2F2BFB8 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x2F2BFC0 Offset: 0x2F27FC0 VA: 0x2F2BFC0 Slot: 39
	public virtual ParameterInfo get_ReturnParameter() { }

	// RVA: 0x2F2BFE8 Offset: 0x2F27FE8 VA: 0x2F2BFE8 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: 0x2F2C010 Offset: 0x2F28010 VA: 0x2F2C010 Slot: 28
	public override Type[] GetGenericArguments() { }

	// RVA: 0x2F2C05C Offset: 0x2F2805C VA: 0x2F2C05C Slot: 41
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x2F2C0A8 Offset: 0x2F280A8 VA: 0x2F2C0A8 Slot: 42
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo GetBaseDefinition();

	// RVA: 0x2F2C0F4 Offset: 0x2F280F4 VA: 0x2F2C0F4 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x2F2C140 Offset: 0x2F28140 VA: 0x2F2C140 Slot: 45
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x2F2C18C Offset: 0x2F2818C VA: 0x2F2C18C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F2C194 Offset: 0x2F28194 VA: 0x2F2C194 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F1F6E8 Offset: 0x2F1B6E8 VA: 0x2F1F6E8
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x2F2B914 Offset: 0x2F27914 VA: 0x2F2B914
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x2F2C19C Offset: 0x2F2819C VA: 0x2F2C19C Slot: 46
	internal virtual int get_GenericParameterCount() { }
}
