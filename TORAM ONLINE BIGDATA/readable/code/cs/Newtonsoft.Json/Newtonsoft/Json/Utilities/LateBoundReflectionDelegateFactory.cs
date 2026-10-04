// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 15942
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x30933EC Offset: 0x308F3EC VA: 0x30933EC
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x3093444 Offset: 0x308F444 VA: 0x3093444 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8014 Offset: 0x26C4014 VA: 0x26C8014
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	|
	|-RVA: 0x26C819C Offset: 0x26C419C VA: 0x26C819C
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C7870 Offset: 0x26C3870 VA: 0x26C7870
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	|
	|-RVA: 0x26C7A84 Offset: 0x26C3A84 VA: 0x26C7A84
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C7D7C Offset: 0x26C3D7C VA: 0x26C7D7C
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x26C7F34 Offset: 0x26C3F34 VA: 0x26C7F34
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C7CA4 Offset: 0x26C3CA4 VA: 0x26C7CA4
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x26C7E54 Offset: 0x26C3E54 VA: 0x26C7E54
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C832C Offset: 0x26C432C VA: 0x26C832C
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x26C84DC Offset: 0x26C44DC VA: 0x26C84DC
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C8404 Offset: 0x26C4404 VA: 0x26C8404
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x26C85BC Offset: 0x26C45BC VA: 0x26C85BC
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x30935F0 Offset: 0x308F5F0 VA: 0x30935F0
	public void .ctor() { }

	// RVA: 0x3093600 Offset: 0x308F600 VA: 0x3093600
	private static void .cctor() { }
}
