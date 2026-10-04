// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 9784
{
	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private IntPtr interp_method; // 0x48
	private IntPtr interp_invoke_impl; // 0x50
	private MethodInfo method_info; // 0x58
	private MethodInfo original_method_info; // 0x60
	private DelegateData data; // 0x68
	private bool method_is_virtual; // 0x70

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x302EC8C Offset: 0x302AC8C VA: 0x302EC8C
	public MethodInfo get_Method() { }

	// RVA: 0x302EC98 Offset: 0x302AC98 VA: 0x302EC98
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x302EC9C Offset: 0x302AC9C VA: 0x302EC9C
	public object get_Target() { }

	// RVA: 0x302ECA4 Offset: 0x302ACA4 VA: 0x302ECA4
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0x302ECAC Offset: 0x302ACAC VA: 0x302ECAC
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0x302EE44 Offset: 0x302AE44 VA: 0x302EE44
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0x302EFA0 Offset: 0x302AFA0 VA: 0x302EFA0
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0x302F1B8 Offset: 0x302B1B8 VA: 0x302F1B8
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0x302F9F0 Offset: 0x302B9F0 VA: 0x302F9F0
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0x302F9FC Offset: 0x302B9FC VA: 0x302F9FC
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x302FA14 Offset: 0x302BA14 VA: 0x302FA14
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0x302FA28 Offset: 0x302BA28 VA: 0x302FA28
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0x302FA40 Offset: 0x302BA40 VA: 0x302FA40
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x302FEAC Offset: 0x302BEAC VA: 0x302FEAC
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x302FFD4 Offset: 0x302BFD4 VA: 0x302FFD4
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0x302FFE0 Offset: 0x302BFE0 VA: 0x302FFE0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x302FA34 Offset: 0x302BA34 VA: 0x302FA34
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0x30300BC Offset: 0x302C0BC VA: 0x30300BC Slot: 6
	public virtual object Clone() { }

	// RVA: 0x30300C4 Offset: 0x302C0C4 VA: 0x30300C4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3030278 Offset: 0x302C278 VA: 0x3030278 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x30302F0 Offset: 0x302C2F0 VA: 0x30302F0 Slot: 7
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0x30303F8 Offset: 0x302C3F8 VA: 0x30303F8 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3030650 Offset: 0x302C650 VA: 0x3030650 Slot: 9
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0x302B0BC Offset: 0x30270BC VA: 0x302B0BC
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisible(True)]
	// RVA: 0x30306EC Offset: 0x302C6EC VA: 0x30306EC
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0x3030750 Offset: 0x302C750 VA: 0x3030750 Slot: 10
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0x302B2B4 Offset: 0x30272B4 VA: 0x302B2B4
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0x30307A4 Offset: 0x302C7A4 VA: 0x30307A4 Slot: 11
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0x30307C8 Offset: 0x302C7C8 VA: 0x30307C8
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0x30307F0 Offset: 0x302C7F0 VA: 0x30307F0
	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	// RVA: 0x3030828 Offset: 0x302C828 VA: 0x3030828
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }
}
