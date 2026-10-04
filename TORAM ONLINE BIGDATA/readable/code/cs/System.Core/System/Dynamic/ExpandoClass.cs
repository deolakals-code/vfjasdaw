// Assembly: System.Core.dll
// Namespace: System.Dynamic
internal class ExpandoClass // TypeDefIndex: 15771
{
	// Fields
	private readonly string[] _keys; // 0x10
	private readonly int _hashCode; // 0x18
	private Dictionary<int, List<WeakReference>> _transitions; // 0x20
	internal static readonly ExpandoClass Empty; // 0x0

	// Properties
	internal string[] Keys { get; }

	// Methods

	// RVA: 0x3184384 Offset: 0x3180384 VA: 0x3184384
	internal void .ctor() { }

	// RVA: 0x3184430 Offset: 0x3180430 VA: 0x3184430
	internal void .ctor(string[] keys, int hashCode) { }

	// RVA: 0x3184468 Offset: 0x3180468 VA: 0x3184468
	internal ExpandoClass FindNewClass(string newKey) { }

	// RVA: 0x3184840 Offset: 0x3180840 VA: 0x3184840
	private List<WeakReference> GetTransitionList(int hashCode) { }

	// RVA: 0x3184978 Offset: 0x3180978 VA: 0x3184978
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	// RVA: 0x3184B04 Offset: 0x3180B04 VA: 0x3184B04
	internal int GetValueIndexCaseSensitive(string name) { }

	// RVA: 0x3184988 Offset: 0x3180988 VA: 0x3184988
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	// RVA: 0x3184C20 Offset: 0x3180C20 VA: 0x3184C20
	internal string[] get_Keys() { }

	// RVA: 0x3184C28 Offset: 0x3180C28 VA: 0x3184C28
	private static void .cctor() { }
}
