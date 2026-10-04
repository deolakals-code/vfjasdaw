// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
[Extension]
public static class TypeUtility // TypeDefIndex: 17371
{
	// Fields
	private static readonly ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName; // 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x381D540 Offset: 0x3819540 VA: 0x381D540
	private static void .cctor() { }

	// RVA: 0x381D984 Offset: 0x3819984 VA: 0x381D984
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x381DA9C Offset: 0x3819A9C VA: 0x381DA9C
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Extension]
	// RVA: 0x381E440 Offset: 0x381A440 VA: 0x381E440
	public static Type GetRootType(Type type) { }

	[Preserve]
	// RVA: 0x381E574 Offset: 0x381A574 VA: 0x381E574
	private static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F7CAC Offset: 0x26F3CAC VA: 0x26F7CAC
	|-TypeUtility.CreateTypeConstructor<Bounds>
	|
	|-RVA: 0x26F7DDC Offset: 0x26F3DDC VA: 0x26F7DDC
	|-TypeUtility.CreateTypeConstructor<BoundsInt>
	|
	|-RVA: 0x26F7F0C Offset: 0x26F3F0C VA: 0x26F7F0C
	|-TypeUtility.CreateTypeConstructor<Color>
	|
	|-RVA: 0x26F803C Offset: 0x26F403C VA: 0x26F803C
	|-TypeUtility.CreateTypeConstructor<object>
	|
	|-RVA: 0x26F816C Offset: 0x26F416C VA: 0x26F816C
	|-TypeUtility.CreateTypeConstructor<Rect>
	|
	|-RVA: 0x26F829C Offset: 0x26F429C VA: 0x26F829C
	|-TypeUtility.CreateTypeConstructor<RectInt>
	|
	|-RVA: 0x26F83CC Offset: 0x26F43CC VA: 0x26F83CC
	|-TypeUtility.CreateTypeConstructor<Vector2>
	|
	|-RVA: 0x26F84FC Offset: 0x26F44FC VA: 0x26F84FC
	|-TypeUtility.CreateTypeConstructor<Vector2Int>
	|
	|-RVA: 0x26F862C Offset: 0x26F462C VA: 0x26F862C
	|-TypeUtility.CreateTypeConstructor<Vector3>
	|
	|-RVA: 0x26F875C Offset: 0x26F475C VA: 0x26F875C
	|-TypeUtility.CreateTypeConstructor<Vector3Int>
	|
	|-RVA: 0x26F888C Offset: 0x26F488C VA: 0x26F888C
	|-TypeUtility.CreateTypeConstructor<Vector4>
	|
	|-RVA: 0x26F89BC Offset: 0x26F49BC VA: 0x26F89BC
	|-TypeUtility.CreateTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x381EA8C Offset: 0x381AA8C VA: 0x381EA8C
	private static TypeUtility.ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F8AF0 Offset: 0x26F4AF0 VA: 0x26F8AF0
	|-TypeUtility.GetTypeConstructor<object>
	|
	|-RVA: 0x26F8B88 Offset: 0x26F4B88 VA: 0x26F8B88
	|-TypeUtility.GetTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x381EB44 Offset: 0x381AB44 VA: 0x381EB44
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1 Offset: -1
	public static bool CanBeInstantiated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F7A90 Offset: 0x26F3A90 VA: 0x26F7A90
	|-TypeUtility.CanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F9828 Offset: 0x26F5828 VA: 0x26F9828
	|-TypeUtility.SetExplicitInstantiationMethod<object>
	|
	|-RVA: 0x26F990C Offset: 0x26F590C VA: 0x26F990C
	|-TypeUtility.SetExplicitInstantiationMethod<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F8C24 Offset: 0x26F4C24 VA: 0x26F8C24
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(out T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F99F4 Offset: 0x26F59F4 VA: 0x26F99F4
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Type derivedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F8DD8 Offset: 0x26F4DD8 VA: 0x26F8DD8
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(Type derivedType, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F9C08 Offset: 0x26F5C08 VA: 0x26F9C08
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F8FF8 Offset: 0x26F4FF8 VA: 0x26F8FF8
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F9E8C Offset: 0x26F5E8C VA: 0x26F9E8C
	|-TypeUtility.TryInstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F9410 Offset: 0x26F5410 VA: 0x26F9410
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x381EC10 Offset: 0x381AC10 VA: 0x381EC10
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: -1 Offset: -1
	private static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F7B60 Offset: 0x26F3B60 VA: 0x26F7B60
	|-TypeUtility.CheckCanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x381ED78 Offset: 0x381AD78 VA: 0x381ED78
	private static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type) { }
}
