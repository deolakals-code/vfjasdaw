// Assembly: System.Core.dll
// Namespace: System.Dynamic
public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 15783
{
	// Fields
	private static readonly MethodInfo s_expandoTryGetValue; // 0x0
	private static readonly MethodInfo s_expandoTrySetValue; // 0x8
	private static readonly MethodInfo s_expandoTryDeleteValue; // 0x10
	private static readonly MethodInfo s_expandoPromoteClass; // 0x18
	private static readonly MethodInfo s_expandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; set; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x3184C8C Offset: 0x3180C8C VA: 0x3184C8C
	public void .ctor() { }

	// RVA: 0x3180DA0 Offset: 0x317CDA0 VA: 0x3180DA0
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x3180F08 Offset: 0x317CF08 VA: 0x3180F08
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x3181338 Offset: 0x317D338 VA: 0x3181338
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x3184B78 Offset: 0x3180B78 VA: 0x3184B78
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x3181670 Offset: 0x317D670 VA: 0x3181670
	internal ExpandoClass get_Class() { }

	// RVA: 0x3184D34 Offset: 0x3180D34 VA: 0x3184D34
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x318169C Offset: 0x317D69C VA: 0x318169C
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x3184D7C Offset: 0x3180D7C VA: 0x3184D7C Slot: 4
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x3184DE8 Offset: 0x3180DE8 VA: 0x3184DE8
	private void TryAddMember(string key, object value) { }

	// RVA: 0x3184E64 Offset: 0x3180E64 VA: 0x3184E64
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x3184E7C Offset: 0x3180E7C VA: 0x3184E7C
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x3184EA8 Offset: 0x3180EA8 VA: 0x3184EA8 Slot: 7
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x318500C Offset: 0x318100C VA: 0x318500C Slot: 8
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	// RVA: 0x3185068 Offset: 0x3181068 VA: 0x3185068 Slot: 5
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x31850CC Offset: 0x31810CC VA: 0x31850CC Slot: 6
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	// RVA: 0x3185148 Offset: 0x3181148 VA: 0x3185148 Slot: 10
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x318514C Offset: 0x318114C VA: 0x318514C Slot: 9
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x3185220 Offset: 0x3181220 VA: 0x3185220 Slot: 11
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	// RVA: 0x31852C0 Offset: 0x31812C0 VA: 0x31852C0 Slot: 12
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x31852D8 Offset: 0x31812D8 VA: 0x31852D8 Slot: 13
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x31852E0 Offset: 0x31812E0 VA: 0x31852E0 Slot: 14
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x31852E8 Offset: 0x31812E8 VA: 0x31852E8 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x3185348 Offset: 0x3181348 VA: 0x3185348 Slot: 16
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x318557C Offset: 0x318157C VA: 0x318557C Slot: 17
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x3185610 Offset: 0x3181610 VA: 0x3185610 Slot: 18
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x3185A50 Offset: 0x3181A50 VA: 0x3185A50 Slot: 19
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x3185ABC Offset: 0x3181ABC VA: 0x3185ABC Slot: 20
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x3185B70 Offset: 0x3181B70 VA: 0x3185B70 Slot: 21
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ExpandoObject.<GetExpandoEnumerator>d__51))]
	// RVA: 0x3185AD8 Offset: 0x3181AD8 VA: 0x3185AD8
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x3185B8C Offset: 0x3181B8C VA: 0x3185B8C
	private static void .cctor() { }
}
