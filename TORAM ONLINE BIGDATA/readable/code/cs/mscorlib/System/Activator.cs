// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[ClassInterface(0)]
[ComDefaultInterface(typeof(_Activator))]
public sealed class Activator // TypeDefIndex: 9740
{
	// Methods

	// RVA: 0x300EE4C Offset: 0x300AE4C VA: 0x300EE4C
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture) { }

	// RVA: 0x300EE54 Offset: 0x300AE54 VA: 0x300EE54
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	// RVA: 0x300FA04 Offset: 0x300BA04 VA: 0x300FA04
	public static object CreateInstance(Type type, object[] args) { }

	// RVA: 0x300FA1C Offset: 0x300BA1C VA: 0x300FA1C
	public static object CreateInstance(Type type, object[] args, object[] activationAttributes) { }

	// RVA: 0x300FA34 Offset: 0x300BA34 VA: 0x300FA34
	public static object CreateInstance(Type type) { }

	// RVA: 0x300FA40 Offset: 0x300BA40 VA: 0x300FA40
	public static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x300FA4C Offset: 0x300BA4C VA: 0x300FA4C
	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26885DC Offset: 0x26845DC VA: 0x26885DC
	|-Activator.CreateInstance<Bounds>
	|
	|-RVA: 0x268876C Offset: 0x268476C VA: 0x268876C
	|-Activator.CreateInstance<BoundsInt>
	|
	|-RVA: 0x26888FC Offset: 0x26848FC VA: 0x26888FC
	|-Activator.CreateInstance<Color>
	|
	|-RVA: 0x2688A80 Offset: 0x2684A80 VA: 0x2688A80
	|-Activator.CreateInstance<object>
	|
	|-RVA: 0x2688BFC Offset: 0x2684BFC VA: 0x2688BFC
	|-Activator.CreateInstance<Rect>
	|
	|-RVA: 0x2688D80 Offset: 0x2684D80 VA: 0x2688D80
	|-Activator.CreateInstance<RectInt>
	|
	|-RVA: 0x2688F04 Offset: 0x2684F04 VA: 0x2688F04
	|-Activator.CreateInstance<Vector2>
	|
	|-RVA: 0x2689084 Offset: 0x2685084 VA: 0x2689084
	|-Activator.CreateInstance<Vector2Int>
	|
	|-RVA: 0x2689204 Offset: 0x2685204 VA: 0x2689204
	|-Activator.CreateInstance<Vector3>
	|
	|-RVA: 0x2689388 Offset: 0x2685388 VA: 0x2689388
	|-Activator.CreateInstance<Vector3Int>
	|
	|-RVA: 0x2689510 Offset: 0x2685510 VA: 0x2689510
	|-Activator.CreateInstance<Vector4>
	|
	|-RVA: 0x2689694 Offset: 0x2685694 VA: 0x2689694
	|-Activator.CreateInstance<__Il2CppFullySharedGenericType>
	*/
}
