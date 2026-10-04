// Assembly: System.Core.dll
// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 15196
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2817F7C Offset: 0x2813F7C VA: 0x2817F7C
	|-Enumerable.<DistinctIterator>d__68<byte>..ctor
	|
	|-RVA: 0x28184D8 Offset: 0x28144D8 VA: 0x28184D8
	|-Enumerable.<DistinctIterator>d__68<int>..ctor
	|
	|-RVA: 0x2818A30 Offset: 0x2814A30 VA: 0x2818A30
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2817FB0 Offset: 0x2813FB0 VA: 0x2817FB0
	|-Enumerable.<DistinctIterator>d__68<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0x281850C Offset: 0x281450C VA: 0x281850C
	|-Enumerable.<DistinctIterator>d__68<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x2818A98 Offset: 0x2814A98 VA: 0x2818A98
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2817FCC Offset: 0x2813FCC VA: 0x2817FCC
	|-Enumerable.<DistinctIterator>d__68<byte>.MoveNext
	|
	|-RVA: 0x2818528 Offset: 0x2814528 VA: 0x2818528
	|-Enumerable.<DistinctIterator>d__68<int>.MoveNext
	|
	|-RVA: 0x2818AF8 Offset: 0x2814AF8 VA: 0x2818AF8
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2818310 Offset: 0x2814310 VA: 0x2818310
	|-Enumerable.<DistinctIterator>d__68<byte>.<>m__Finally1
	|
	|-RVA: 0x2818868 Offset: 0x2814868 VA: 0x2818868
	|-Enumerable.<DistinctIterator>d__68<int>.<>m__Finally1
	|
	|-RVA: 0x2819088 Offset: 0x2815088 VA: 0x2819088
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28183C0 Offset: 0x28143C0 VA: 0x28183C0
	|-Enumerable.<DistinctIterator>d__68<byte>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2818918 Offset: 0x2814918 VA: 0x2818918
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2819194 Offset: 0x2815194 VA: 0x2819194
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28183C8 Offset: 0x28143C8 VA: 0x28183C8
	|-Enumerable.<DistinctIterator>d__68<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2818920 Offset: 0x2814920 VA: 0x2818920
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2819234 Offset: 0x2815234 VA: 0x2819234
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28183FC Offset: 0x28143FC VA: 0x28183FC
	|-Enumerable.<DistinctIterator>d__68<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2818954 Offset: 0x2814954 VA: 0x2818954
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2819268 Offset: 0x2815268 VA: 0x2819268
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2818424 Offset: 0x2814424 VA: 0x2818424
	|-Enumerable.<DistinctIterator>d__68<byte>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x281897C Offset: 0x281497C VA: 0x281897C
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x281930C Offset: 0x281530C VA: 0x281930C
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28184C8 Offset: 0x28144C8 VA: 0x28184C8
	|-Enumerable.<DistinctIterator>d__68<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2818A20 Offset: 0x2814A20 VA: 0x2818A20
	|-Enumerable.<DistinctIterator>d__68<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2819458 Offset: 0x2815458 VA: 0x2819458
	|-Enumerable.<DistinctIterator>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
