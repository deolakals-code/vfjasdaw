// Assembly: System.Core.dll
// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<UnionIterator>d__71<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 15197
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
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
	|-RVA: 0x2826D4C Offset: 0x2822D4C VA: 0x2826D4C
	|-Enumerable.<UnionIterator>d__71<char>..ctor
	|
	|-RVA: 0x28275A4 Offset: 0x28235A4 VA: 0x28275A4
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2826D80 Offset: 0x2822D80 VA: 0x2826D80
	|-Enumerable.<UnionIterator>d__71<char>.System.IDisposable.Dispose
	|
	|-RVA: 0x282760C Offset: 0x282360C VA: 0x282760C
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2826DB4 Offset: 0x2822DB4 VA: 0x2826DB4
	|-Enumerable.<UnionIterator>d__71<char>.MoveNext
	|
	|-RVA: 0x2827694 Offset: 0x2823694 VA: 0x2827694
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x282731C Offset: 0x282331C VA: 0x282731C
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally1
	|
	|-RVA: 0x2827FC8 Offset: 0x2823FC8 VA: 0x2827FC8
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28273CC Offset: 0x28233CC VA: 0x28273CC
	|-Enumerable.<UnionIterator>d__71<char>.<>m__Finally2
	|
	|-RVA: 0x28280D4 Offset: 0x28240D4 VA: 0x28280D4
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x282747C Offset: 0x282347C VA: 0x282747C
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x28281E0 Offset: 0x28241E0 VA: 0x28281E0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2827484 Offset: 0x2823484 VA: 0x2827484
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2828280 Offset: 0x2824280 VA: 0x2828280
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28274B8 Offset: 0x28234B8 VA: 0x28274B8
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28282B4 Offset: 0x28242B4 VA: 0x28282B4
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28274E0 Offset: 0x28234E0 VA: 0x28274E0
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2828358 Offset: 0x2824358 VA: 0x2828358
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2827594 Offset: 0x2823594 VA: 0x2827594
	|-Enumerable.<UnionIterator>d__71<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28284E0 Offset: 0x28244E0 VA: 0x28284E0
	|-Enumerable.<UnionIterator>d__71<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
