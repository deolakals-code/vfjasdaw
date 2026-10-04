// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T> // TypeDefIndex: 15968
{
	// Fields
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<object, T> TypeAttributeCache; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static T GetAttribute(object type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C745B4 Offset: 0x2C705B4 VA: 0x2C745B4
	|-CachedAttributeGetter<object>.GetAttribute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7465C Offset: 0x2C7065C VA: 0x2C7465C
	|-CachedAttributeGetter<object>..cctor
	*/
}
