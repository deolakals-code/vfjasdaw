// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class MethodBase : MemberInfo // TypeDefIndex: 10604
{
	// Properties
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public bool IsAbstract { get; }
	public bool IsConstructor { get; }
	public bool IsSpecialName { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsPublic { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public virtual bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x2F297DC Offset: 0x2F257DC VA: 0x2F297DC
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: 0x2F2B754 Offset: 0x2F27754 VA: 0x2F2B754 Slot: 19
	public virtual CallingConventions get_CallingConvention() { }

	// RVA: 0x2F2B75C Offset: 0x2F2775C VA: 0x2F2B75C Slot: 20
	public bool get_IsAbstract() { }

	// RVA: 0x2F2B77C Offset: 0x2F2777C VA: 0x2F2B77C Slot: 21
	public bool get_IsConstructor() { }

	// RVA: 0x2F2B820 Offset: 0x2F27820 VA: 0x2F2B820 Slot: 22
	public bool get_IsSpecialName() { }

	// RVA: 0x2F29F24 Offset: 0x2F25F24 VA: 0x2F29F24 Slot: 23
	public bool get_IsStatic() { }

	// RVA: 0x2F2B840 Offset: 0x2F27840 VA: 0x2F2B840 Slot: 24
	public bool get_IsVirtual() { }

	// RVA: 0x2F2B860 Offset: 0x2F27860 VA: 0x2F2B860 Slot: 25
	public bool get_IsPublic() { }

	// RVA: 0x2F2B888 Offset: 0x2F27888 VA: 0x2F2B888 Slot: 26
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x2F2B890 Offset: 0x2F27890 VA: 0x2F2B890 Slot: 27
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x2F2B898 Offset: 0x2F27898 VA: 0x2F2B898 Slot: 28
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x2F2B8E4 Offset: 0x2F278E4 VA: 0x2F2B8E4 Slot: 29
	public virtual bool get_ContainsGenericParameters() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F29CFC Offset: 0x2F25CFC VA: 0x2F29CFC Slot: 30
	public object Invoke(object obj, object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: 0x2F2B8EC Offset: 0x2F278EC VA: 0x2F2B8EC Slot: 33
	public virtual bool get_IsSecurityCritical() { }

	// RVA: 0x2F29814 Offset: 0x2F25814 VA: 0x2F29814 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F29824 Offset: 0x2F25824 VA: 0x2F29824 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F2B538 Offset: 0x2F27538 VA: 0x2F2B538
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x2F2B520 Offset: 0x2F27520 VA: 0x2F2B520
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x2F2B950 Offset: 0x2F27950 VA: 0x2F2B950 Slot: 34
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x2F2B960 Offset: 0x2F27960 VA: 0x2F2B960 Slot: 35
	internal virtual int GetParametersCount() { }

	// RVA: 0x2F2B988 Offset: 0x2F27988 VA: 0x2F2B988 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x2F2BCA4 Offset: 0x2F27CA4 VA: 0x2F2BCA4 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x2F2BDC0 Offset: 0x2F27DC0 VA: 0x2F2BDC0 Slot: 38
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: 0x2F2BDD0 Offset: 0x2F27DD0 VA: 0x2F2BDD0
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x2F2BAAC Offset: 0x2F27AAC VA: 0x2F2BAAC
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }
}
