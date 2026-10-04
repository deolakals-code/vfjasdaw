// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable // TypeDefIndex: 10649
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x2F372C0 Offset: 0x2F332C0 VA: 0x2F372C0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x2F372C8 Offset: 0x2F332C8 VA: 0x2F372C8 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x2F372E8 Offset: 0x2F332E8 VA: 0x2F372E8
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x2F3736C Offset: 0x2F3336C VA: 0x2F3736C
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x2F372CC Offset: 0x2F332CC VA: 0x2F372CC
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x2F373F0 Offset: 0x2F333F0 VA: 0x2F373F0 Slot: 34
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F374A4 Offset: 0x2F334A4 VA: 0x2F374A4 Slot: 31
	internal override object UnsafeGetValue(object obj) { }

	// RVA: 0x2F374A8 Offset: 0x2F334A8 VA: 0x2F374A8 Slot: 33
	internal override void CheckConsistency(object target) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x2F3761C Offset: 0x2F3361C VA: 0x2F3761C Slot: 32
	internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F37680 Offset: 0x2F33680 VA: 0x2F37680 Slot: 28
	public override void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x2F377DC Offset: 0x2F337DC VA: 0x2F377DC Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x2F377E4 Offset: 0x2F337E4 VA: 0x2F377E4 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x2F377EC Offset: 0x2F337EC VA: 0x2F377EC
	private Type ResolveType() { }

	// RVA: 0x2F377F0 Offset: 0x2F337F0 VA: 0x2F377F0 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x2F37880 Offset: 0x2F33880 VA: 0x2F37880
	private Type GetParentType(bool declaring) { }

	// RVA: 0x2F37888 Offset: 0x2F33888 VA: 0x2F37888 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F37890 Offset: 0x2F33890 VA: 0x2F37890 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F37898 Offset: 0x2F33898 VA: 0x2F37898 Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F378A0 Offset: 0x2F338A0 VA: 0x2F378A0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F37910 Offset: 0x2F33910 VA: 0x2F37910 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F37978 Offset: 0x2F33978 VA: 0x2F37978 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F379E8 Offset: 0x2F339E8 VA: 0x2F379E8 Slot: 30
	internal override int GetFieldOffset() { }

	// RVA: 0x2F379EC Offset: 0x2F339EC VA: 0x2F379EC
	private object GetValueInternal(object obj) { }

	// RVA: 0x2F379F0 Offset: 0x2F339F0 VA: 0x2F379F0 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x2F37BEC Offset: 0x2F33BEC VA: 0x2F37BEC Slot: 3
	public override string ToString() { }

	// RVA: 0x2F37C54 Offset: 0x2F33C54 VA: 0x2F37C54
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x2F37C58 Offset: 0x2F33C58 VA: 0x2F37C58 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x2F37EFC Offset: 0x2F33EFC VA: 0x2F37EFC Slot: 29
	public override object GetRawConstantValue() { }

	// RVA: 0x2F37B70 Offset: 0x2F33B70 VA: 0x2F37B70
	private void CheckGeneric() { }

	// RVA: 0x2F37F00 Offset: 0x2F33F00 VA: 0x2F37F00 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2F37F04 Offset: 0x2F33F04 VA: 0x2F37F04
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	// RVA: 0x2F37F08 Offset: 0x2F33F08 VA: 0x2F37F08
	public void .ctor() { }
}
