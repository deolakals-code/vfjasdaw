// Assembly: System.Core.dll
// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<SelectIterator>d__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 15190
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, int, TResult> selector; // 0x0
	public Func<TSource, int, TResult> <>3__selector; // 0x0
	private int <index>5__2; // 0x0
	private IEnumerator<TSource> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28239A0 Offset: 0x281F9A0 VA: 0x28239A0
	|-Enumerable.<SelectIterator>d__5<object, object>..ctor
	|
	|-RVA: 0x2823EA4 Offset: 0x281FEA4 VA: 0x2823EA4
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28239D4 Offset: 0x281F9D4 VA: 0x28239D4
	|-Enumerable.<SelectIterator>d__5<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x2823F0C Offset: 0x281FF0C VA: 0x2823F0C
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28239F0 Offset: 0x281F9F0 VA: 0x28239F0
	|-Enumerable.<SelectIterator>d__5<object, object>.MoveNext
	|
	|-RVA: 0x2823F6C Offset: 0x281FF6C VA: 0x2823F6C
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2823CFC Offset: 0x281FCFC VA: 0x2823CFC
	|-Enumerable.<SelectIterator>d__5<object, object>.<>m__Finally1
	|
	|-RVA: 0x2824518 Offset: 0x2820518 VA: 0x2824518
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2823DAC Offset: 0x281FDAC VA: 0x2823DAC
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x2824624 Offset: 0x2820624 VA: 0x2824624
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2823DB4 Offset: 0x281FDB4 VA: 0x2823DB4
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x28246C4 Offset: 0x28206C4 VA: 0x28246C4
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2823DE8 Offset: 0x281FDE8 VA: 0x2823DE8
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x28246F8 Offset: 0x28206F8 VA: 0x28246F8
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2823DF0 Offset: 0x281FDF0 VA: 0x2823DF0
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x282479C Offset: 0x282079C VA: 0x282479C
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2823E94 Offset: 0x281FE94 VA: 0x2823E94
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x28248E8 Offset: 0x28208E8 VA: 0x28248E8
	|-Enumerable.<SelectIterator>d__5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
