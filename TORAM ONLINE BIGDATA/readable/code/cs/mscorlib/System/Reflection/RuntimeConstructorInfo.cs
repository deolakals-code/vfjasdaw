// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 10652
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x2F3A030 Offset: 0x2F36030 VA: 0x2F3A030 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x2F3A034 Offset: 0x2F36034 VA: 0x2F3A034
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x2F3A0BC Offset: 0x2F360BC VA: 0x2F3A0BC
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x2F3A0C4 Offset: 0x2F360C4 VA: 0x2F3A0C4
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x2F3A148 Offset: 0x2F36148 VA: 0x2F3A148 Slot: 40
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3A220 Offset: 0x2F36220 VA: 0x2F3A220
	internal string SerializationToString() { }

	// RVA: 0x2F3A234 Offset: 0x2F36234 VA: 0x2F3A234
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3A364 Offset: 0x2F36364 VA: 0x2F3A364 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x2F3A390 Offset: 0x2F36390 VA: 0x2F3A390 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x2F3A39C Offset: 0x2F3639C VA: 0x2F3A39C Slot: 34
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x2F3A3A8 Offset: 0x2F363A8 VA: 0x2F3A3A8 Slot: 35
	internal override int GetParametersCount() { }

	// RVA: 0x2F3A3C8 Offset: 0x2F363C8 VA: 0x2F3A3C8
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F3A3CC Offset: 0x2F363CC VA: 0x2F3A3CC Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F3A4C8 Offset: 0x2F364C8 VA: 0x2F3A4C8
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F3A6A0 Offset: 0x2F366A0 VA: 0x2F3A6A0
	public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F3A7F8 Offset: 0x2F367F8 VA: 0x2F3A7F8 Slot: 39
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x2F3A810 Offset: 0x2F36810 VA: 0x2F3A810 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x2F3A818 Offset: 0x2F36818 VA: 0x2F3A818 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x2F3A820 Offset: 0x2F36820 VA: 0x2F3A820 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x2F3A84C Offset: 0x2F3684C VA: 0x2F3A84C Slot: 29
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x2F3A878 Offset: 0x2F36878 VA: 0x2F3A878 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3A880 Offset: 0x2F36880 VA: 0x2F3A880 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3A8AC Offset: 0x2F368AC VA: 0x2F3A8AC Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3A8C0 Offset: 0x2F368C0 VA: 0x2F3A8C0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3A930 Offset: 0x2F36930 VA: 0x2F3A930 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3A998 Offset: 0x2F36998 VA: 0x2F3A998 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F3AA08 Offset: 0x2F36A08 VA: 0x2F3AA08 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F3AA70 Offset: 0x2F36A70 VA: 0x2F3AA70
	private static int get_core_clr_security_level() { }

	// RVA: 0x2F3AA78 Offset: 0x2F36A78 VA: 0x2F3AA78 Slot: 33
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x2F3AA80 Offset: 0x2F36A80 VA: 0x2F3AA80 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2F3AA84 Offset: 0x2F36A84 VA: 0x2F3AA84
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	// RVA: 0x2F3AA88 Offset: 0x2F36A88 VA: 0x2F3AA88
	public void .ctor() { }
}
