// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Nullable(0)]
[NullableContext(1)]
internal abstract class ReflectionDelegateFactory // TypeDefIndex: 15946
{
	// Methods

	// RVA: -1 Offset: -1
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E689C Offset: 0x26E289C VA: 0x26E689C
	|-ReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x26E6A74 Offset: 0x26E2A74 VA: 0x26E6A74
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E6C4C Offset: 0x26E2C4C VA: 0x26E6C4C
	|-ReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x26E6DA0 Offset: 0x26E2DA0 VA: 0x26E6DA0
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x30935F8 Offset: 0x308F5F8 VA: 0x30935F8
	protected void .ctor() { }
}
