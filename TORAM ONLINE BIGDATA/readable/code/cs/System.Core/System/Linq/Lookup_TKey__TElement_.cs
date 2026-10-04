// Assembly: System.Core.dll
// Namespace: System.Linq
[DefaultMember("Item")]
public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 15212
{
	// Fields
	private IEqualityComparer<TKey> comparer; // 0x0
	private Lookup.Grouping<TKey, TElement>[] groupings; // 0x0
	private Lookup.Grouping<TKey, TElement> lastGrouping; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267A2F0 Offset: 0x26762F0 VA: 0x267A2F0
	|-Lookup<byte, object>.Create<object>
	|
	|-RVA: 0x267A71C Offset: 0x267671C VA: 0x267A71C
	|-Lookup<int, int>.Create<int>
	|
	|-RVA: 0x267AB48 Offset: 0x2676B48 VA: 0x267AB48
	|-Lookup<object, object>.Create<object>
	|
	|-RVA: 0x267AF74 Offset: 0x2676F74 VA: 0x267AF74
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F060 Offset: 0x2B9B060 VA: 0x2B9F060
	|-Lookup<byte, object>..ctor
	|
	|-RVA: 0x2B9F5BC Offset: 0x2B9B5BC VA: 0x2B9F5BC
	|-Lookup<int, int>..ctor
	|
	|-RVA: 0x2B9FB14 Offset: 0x2B9BB14 VA: 0x2B9FB14
	|-Lookup<object, object>..ctor
	|
	|-RVA: 0x2BA008C Offset: 0x2B9C08C VA: 0x2BA008C
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(Lookup.<GetEnumerator>d__12<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F0DC Offset: 0x2B9B0DC VA: 0x2B9F0DC
	|-Lookup<byte, object>.GetEnumerator
	|
	|-RVA: 0x2B9F638 Offset: 0x2B9B638 VA: 0x2B9F638
	|-Lookup<int, int>.GetEnumerator
	|
	|-RVA: 0x2B9FB90 Offset: 0x2B9BB90 VA: 0x2B9FB90
	|-Lookup<object, object>.GetEnumerator
	|
	|-RVA: 0x2BA010C Offset: 0x2B9C10C VA: 0x2BA010C
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F154 Offset: 0x2B9B154 VA: 0x2B9F154
	|-Lookup<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B9F6B0 Offset: 0x2B9B6B0 VA: 0x2B9F6B0
	|-Lookup<int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B9FC08 Offset: 0x2B9BC08 VA: 0x2B9FC08
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BA0188 Offset: 0x2B9C188 VA: 0x2BA0188
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F164 Offset: 0x2B9B164 VA: 0x2B9F164
	|-Lookup<byte, object>.InternalGetHashCode
	|
	|-RVA: 0x2B9F6C0 Offset: 0x2B9B6C0 VA: 0x2B9F6C0
	|-Lookup<int, int>.InternalGetHashCode
	|
	|-RVA: 0x2B9FC18 Offset: 0x2B9BC18 VA: 0x2B9FC18
	|-Lookup<object, object>.InternalGetHashCode
	|
	|-RVA: 0x2BA019C Offset: 0x2B9C19C VA: 0x2BA019C
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	internal Lookup.Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F208 Offset: 0x2B9B208 VA: 0x2B9F208
	|-Lookup<byte, object>.GetGrouping
	|
	|-RVA: 0x2B9F764 Offset: 0x2B9B764 VA: 0x2B9F764
	|-Lookup<int, int>.GetGrouping
	|
	|-RVA: 0x2B9FCC8 Offset: 0x2B9BCC8 VA: 0x2B9FCC8
	|-Lookup<object, object>.GetGrouping
	|
	|-RVA: 0x2BA0334 Offset: 0x2B9C334 VA: 0x2BA0334
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetGrouping
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F4AC Offset: 0x2B9B4AC VA: 0x2B9F4AC
	|-Lookup<byte, object>.Resize
	|
	|-RVA: 0x2B9FA04 Offset: 0x2B9BA04 VA: 0x2B9FA04
	|-Lookup<int, int>.Resize
	|
	|-RVA: 0x2B9FF7C Offset: 0x2B9BF7C VA: 0x2B9FF7C
	|-Lookup<object, object>.Resize
	|
	|-RVA: 0x2BA080C Offset: 0x2B9C80C VA: 0x2BA080C
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/
}
