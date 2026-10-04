// Assembly: System.Core.dll
// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 15193
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28248FC Offset: 0x28208FC VA: 0x28248FC
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	|
	|-RVA: 0x28250F0 Offset: 0x28210F0 VA: 0x28250F0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2824930 Offset: 0x2820930 VA: 0x2824930
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x2825158 Offset: 0x2821158 VA: 0x2825158
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28249E0 Offset: 0x28209E0 VA: 0x28249E0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	|
	|-RVA: 0x2825250 Offset: 0x2821250 VA: 0x2825250
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2824E98 Offset: 0x2820E98 VA: 0x2824E98
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	|
	|-RVA: 0x28259F0 Offset: 0x28219F0 VA: 0x28259F0
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2824F48 Offset: 0x2820F48 VA: 0x2824F48
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	|
	|-RVA: 0x2825AFC Offset: 0x2821AFC VA: 0x2825AFC
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally2
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2824FF8 Offset: 0x2820FF8 VA: 0x2824FF8
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2825C08 Offset: 0x2821C08 VA: 0x2825C08
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2825000 Offset: 0x2821000 VA: 0x2825000
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2825CA8 Offset: 0x2821CA8 VA: 0x2825CA8
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2825034 Offset: 0x2821034 VA: 0x2825034
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2825CDC Offset: 0x2821CDC VA: 0x2825CDC
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x282503C Offset: 0x282103C VA: 0x282503C
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x2825D80 Offset: 0x2821D80 VA: 0x2825D80
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28250E0 Offset: 0x28210E0 VA: 0x28250E0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2825ECC Offset: 0x2821ECC VA: 0x2825ECC
	|-Enumerable.<SelectManyIterator>d__17<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
