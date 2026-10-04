// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore // TypeDefIndex: 17421
{
	// Fields
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; // 0x0
	private static readonly List<Type> s_RegisteredTypes; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Type, IPropertyBag> NewTypeRegistered; // 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

	// Methods

	// RVA: 0x38213B8 Offset: 0x381D3B8 VA: 0x38213B8
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DF55C Offset: 0x26DB55C VA: 0x26DF55C
	|-PropertyBagStore.AddPropertyBag<Bounds>
	|
	|-RVA: 0x26DFB14 Offset: 0x26DBB14 VA: 0x26DFB14
	|-PropertyBagStore.AddPropertyBag<BoundsInt>
	|
	|-RVA: 0x26E00CC Offset: 0x26DC0CC VA: 0x26E00CC
	|-PropertyBagStore.AddPropertyBag<Color>
	|
	|-RVA: 0x26E0684 Offset: 0x26DC684 VA: 0x26E0684
	|-PropertyBagStore.AddPropertyBag<object>
	|
	|-RVA: 0x26E0C3C Offset: 0x26DCC3C VA: 0x26E0C3C
	|-PropertyBagStore.AddPropertyBag<Rect>
	|
	|-RVA: 0x26E11F4 Offset: 0x26DD1F4 VA: 0x26E11F4
	|-PropertyBagStore.AddPropertyBag<RectInt>
	|
	|-RVA: 0x26E17AC Offset: 0x26DD7AC VA: 0x26E17AC
	|-PropertyBagStore.AddPropertyBag<Vector2>
	|
	|-RVA: 0x26E1D64 Offset: 0x26DDD64 VA: 0x26E1D64
	|-PropertyBagStore.AddPropertyBag<Vector2Int>
	|
	|-RVA: 0x26E231C Offset: 0x26DE31C VA: 0x26E231C
	|-PropertyBagStore.AddPropertyBag<Vector3>
	|
	|-RVA: 0x26E28D4 Offset: 0x26DE8D4 VA: 0x26E28D4
	|-PropertyBagStore.AddPropertyBag<Vector3Int>
	|
	|-RVA: 0x26E2E8C Offset: 0x26DEE8C VA: 0x26E2E8C
	|-PropertyBagStore.AddPropertyBag<Vector4>
	|
	|-RVA: 0x26E3444 Offset: 0x26DF444 VA: 0x26E3444
	|-PropertyBagStore.AddPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E3954 Offset: 0x26DF954 VA: 0x26E3954
	|-PropertyBagStore.GetPropertyBag<Bounds>
	|
	|-RVA: 0x26E3A9C Offset: 0x26DFA9C VA: 0x26E3A9C
	|-PropertyBagStore.GetPropertyBag<BoundsInt>
	|
	|-RVA: 0x26E3BE4 Offset: 0x26DFBE4 VA: 0x26E3BE4
	|-PropertyBagStore.GetPropertyBag<Color>
	|
	|-RVA: 0x26E3D2C Offset: 0x26DFD2C VA: 0x26E3D2C
	|-PropertyBagStore.GetPropertyBag<object>
	|
	|-RVA: 0x26E3E74 Offset: 0x26DFE74 VA: 0x26E3E74
	|-PropertyBagStore.GetPropertyBag<Rect>
	|
	|-RVA: 0x26E3FBC Offset: 0x26DFFBC VA: 0x26E3FBC
	|-PropertyBagStore.GetPropertyBag<RectInt>
	|
	|-RVA: 0x26E4104 Offset: 0x26E0104 VA: 0x26E4104
	|-PropertyBagStore.GetPropertyBag<Vector2>
	|
	|-RVA: 0x26E424C Offset: 0x26E024C VA: 0x26E424C
	|-PropertyBagStore.GetPropertyBag<Vector2Int>
	|
	|-RVA: 0x26E4394 Offset: 0x26E0394 VA: 0x26E4394
	|-PropertyBagStore.GetPropertyBag<Vector3>
	|
	|-RVA: 0x26E44DC Offset: 0x26E04DC VA: 0x26E44DC
	|-PropertyBagStore.GetPropertyBag<Vector3Int>
	|
	|-RVA: 0x26E4624 Offset: 0x26E0624 VA: 0x26E4624
	|-PropertyBagStore.GetPropertyBag<Vector4>
	|
	|-RVA: 0x26E476C Offset: 0x26E076C VA: 0x26E476C
	|-PropertyBagStore.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x381E7F8 Offset: 0x381A7F8 VA: 0x381E7F8
	internal static IPropertyBag GetPropertyBag(Type type) { }
}
