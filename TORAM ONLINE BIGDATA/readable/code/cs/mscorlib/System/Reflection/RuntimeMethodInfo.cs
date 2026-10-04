// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
internal class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 10651
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override ParameterInfo ReturnParameter { get; }
	public override Type ReturnType { get; }
	public override int MetadataToken { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x2F380C0 Offset: 0x2F340C0 VA: 0x2F380C0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x2F380C8 Offset: 0x2F340C8 VA: 0x2F380C8 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x2F38158 Offset: 0x2F34158 VA: 0x2F38158
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x2F381DC Offset: 0x2F341DC VA: 0x2F381DC Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x2F38530 Offset: 0x2F34530 VA: 0x2F38530 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x2F38544 Offset: 0x2F34544 VA: 0x2F38544 Slot: 45
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x2F3855C Offset: 0x2F3455C VA: 0x2F3855C Slot: 3
	public override string ToString() { }

	// RVA: 0x2F380CC Offset: 0x2F340CC VA: 0x2F380CC
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x2F385EC Offset: 0x2F345EC VA: 0x2F385EC Slot: 47
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3870C Offset: 0x2F3470C VA: 0x2F3870C
	internal string SerializationToString() { }

	// RVA: 0x2F387A8 Offset: 0x2F347A8 VA: 0x2F387A8
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x2F387BC Offset: 0x2F347BC VA: 0x2F387BC
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x2F387C4 Offset: 0x2F347C4 VA: 0x2F387C4
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x2F387B4 Offset: 0x2F347B4 VA: 0x2F387B4
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	// RVA: 0x2F387CC Offset: 0x2F347CC VA: 0x2F387CC
	internal void .ctor() { }

	// RVA: 0x2F387D4 Offset: 0x2F347D4 VA: 0x2F387D4
	internal static string get_name(MethodBase method) { }

	// RVA: 0x2F387D8 Offset: 0x2F347D8 VA: 0x2F387D8
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	// RVA: 0x2F387E0 Offset: 0x2F347E0 VA: 0x2F387E0
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	// RVA: 0x2F387E4 Offset: 0x2F347E4 VA: 0x2F387E4 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x2F387EC Offset: 0x2F347EC VA: 0x2F387EC
	internal MethodInfo GetBaseMethod() { }

	// RVA: 0x2F387F4 Offset: 0x2F347F4 VA: 0x2F387F4 Slot: 39
	public override ParameterInfo get_ReturnParameter() { }

	// RVA: 0x2F387F8 Offset: 0x2F347F8 VA: 0x2F387F8 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x2F38824 Offset: 0x2F34824 VA: 0x2F38824 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2F38828 Offset: 0x2F34828 VA: 0x2F38828 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x2F38854 Offset: 0x2F34854 VA: 0x2F38854 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x2F388E4 Offset: 0x2F348E4 VA: 0x2F388E4 Slot: 34
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x2F388F0 Offset: 0x2F348F0 VA: 0x2F388F0 Slot: 35
	internal override int GetParametersCount() { }

	// RVA: 0x2F38914 Offset: 0x2F34914 VA: 0x2F38914
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F38918 Offset: 0x2F34918 VA: 0x2F38918 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F38BFC Offset: 0x2F34BFC VA: 0x2F38BFC
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x2F38EC0 Offset: 0x2F34EC0 VA: 0x2F38EC0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x2F38EC8 Offset: 0x2F34EC8 VA: 0x2F38EC8 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x2F38ED0 Offset: 0x2F34ED0 VA: 0x2F38ED0 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x2F38EFC Offset: 0x2F34EFC VA: 0x2F38EFC Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F38F04 Offset: 0x2F34F04 VA: 0x2F38F04 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F38F30 Offset: 0x2F34F30 VA: 0x2F38F30 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F38F44 Offset: 0x2F34F44 VA: 0x2F38F44 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F38FB4 Offset: 0x2F34FB4 VA: 0x2F38FB4 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3901C Offset: 0x2F3501C VA: 0x2F3901C Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3908C Offset: 0x2F3508C VA: 0x2F3908C
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x2F39090 Offset: 0x2F35090 VA: 0x2F39090
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x2F39214 Offset: 0x2F35214 VA: 0x2F39214
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x2F393F8 Offset: 0x2F353F8 VA: 0x2F393F8
	private CustomAttributeData GetDllImportAttributeData() { }

	// RVA: 0x2F39BA8 Offset: 0x2F35BA8 VA: 0x2F39BA8 Slot: 42
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x2F39EE8 Offset: 0x2F35EE8 VA: 0x2F39EE8
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x2F39EEC Offset: 0x2F35EEC VA: 0x2F39EEC Slot: 28
	public override Type[] GetGenericArguments() { }

	// RVA: 0x2F39EF0 Offset: 0x2F35EF0 VA: 0x2F39EF0
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x2F39EF4 Offset: 0x2F35EF4 VA: 0x2F39EF4 Slot: 41
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x2F39F50 Offset: 0x2F35F50 VA: 0x2F39F50 Slot: 27
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x2F39F54 Offset: 0x2F35F54 VA: 0x2F39F54 Slot: 26
	public override bool get_IsGenericMethod() { }

	// RVA: 0x2F39F58 Offset: 0x2F35F58 VA: 0x2F39F58 Slot: 29
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x2F3A020 Offset: 0x2F36020 VA: 0x2F3A020
	private static int get_core_clr_security_level() { }

	// RVA: 0x2F3A028 Offset: 0x2F36028 VA: 0x2F3A028 Slot: 33
	public override bool get_IsSecurityCritical() { }
}
