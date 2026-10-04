// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 10660
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private RuntimePropertyInfo.GetterAdapter cached_getter; // 0x58

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x2F3BD4C Offset: 0x2F37D4C VA: 0x2F3BD4C
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x2F3BD50 Offset: 0x2F37D50 VA: 0x2F3BD50
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x2F3BD58 Offset: 0x2F37D58 VA: 0x2F3BD58 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x2F3BD78 Offset: 0x2F37D78 VA: 0x2F3BD78
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x2F3BDFC Offset: 0x2F37DFC VA: 0x2F3BDFC
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x2F3BD5C Offset: 0x2F37D5C VA: 0x2F3BD5C
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x2F3BE80 Offset: 0x2F37E80 VA: 0x2F3BE80 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F3BE88 Offset: 0x2F37E88 VA: 0x2F3BE88
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x2F3BFF8 Offset: 0x2F37FF8 VA: 0x2F3BFF8 Slot: 29
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3C0C4 Offset: 0x2F380C4 VA: 0x2F3C0C4
	internal string SerializationToString() { }

	// RVA: 0x2F3C0CC Offset: 0x2F380CC VA: 0x2F3C0CC
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x2F3C10C Offset: 0x2F3810C VA: 0x2F3C10C Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x2F3C14C Offset: 0x2F3814C VA: 0x2F3C14C Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x2F3C18C Offset: 0x2F3818C VA: 0x2F3C18C Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x2F3C23C Offset: 0x2F3823C VA: 0x2F3C23C Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2F3C274 Offset: 0x2F38274 VA: 0x2F3C274 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x2F3C2AC Offset: 0x2F382AC VA: 0x2F3C2AC Slot: 8
	public override string get_Name() { }

	// RVA: 0x2F3C2E4 Offset: 0x2F382E4 VA: 0x2F3C2E4 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x2F3C368 Offset: 0x2F38368 VA: 0x2F3C368 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x2F3C540 Offset: 0x2F38540 VA: 0x2F3C540 Slot: 24
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x2F3C5C4 Offset: 0x2F385C4 VA: 0x2F3C5C4 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F3C630 Offset: 0x2F38630 VA: 0x2F3C630 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F3C68C Offset: 0x2F3868C VA: 0x2F3C68C Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EE354 Offset: 0x26EA354 VA: 0x26EE354
	|-RuntimePropertyInfo.GetterAdapterFrame<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EE468 Offset: 0x26EA468 VA: 0x26EE468
	|-RuntimePropertyInfo.StaticGetterAdapterFrame<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F3C6F8 Offset: 0x2F386F8 VA: 0x2F3C6F8 Slot: 25
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x2F3C718 Offset: 0x2F38718 VA: 0x2F3C718 Slot: 26
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x2F3C90C Offset: 0x2F3890C VA: 0x2F3C90C Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x2F3CB0C Offset: 0x2F38B0C VA: 0x2F3CB0C Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x2F3CB10 Offset: 0x2F38B10 VA: 0x2F3CB10
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	// RVA: 0x2F3CB14 Offset: 0x2F38B14 VA: 0x2F3CB14
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x2F3CB18 Offset: 0x2F38B18 VA: 0x2F3CB18
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x2F3CBD0 Offset: 0x2F38BD0 VA: 0x2F3CBD0
	public void .ctor() { }
}
