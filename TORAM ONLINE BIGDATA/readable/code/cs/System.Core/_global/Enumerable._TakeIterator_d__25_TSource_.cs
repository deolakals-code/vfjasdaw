// Assembly: System.Core.dll
// Namespace: 
[CompilerGenerated]
private sealed class Enumerable.<TakeIterator>d__25<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 15194
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2825EE0 Offset: 0x2821EE0 VA: 0x2825EE0
	|-Enumerable.<TakeIterator>d__25<object>..ctor
	|
	|-RVA: 0x28263B0 Offset: 0x28223B0 VA: 0x28263B0
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2825F14 Offset: 0x2821F14 VA: 0x2825F14
	|-Enumerable.<TakeIterator>d__25<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x2826418 Offset: 0x2822418 VA: 0x2826418
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2825F30 Offset: 0x2821F30 VA: 0x2825F30
	|-Enumerable.<TakeIterator>d__25<object>.MoveNext
	|
	|-RVA: 0x2826478 Offset: 0x2822478 VA: 0x2826478
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2826210 Offset: 0x2822210 VA: 0x2826210
	|-Enumerable.<TakeIterator>d__25<object>.<>m__Finally1
	|
	|-RVA: 0x2826968 Offset: 0x2822968 VA: 0x2826968
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28262C0 Offset: 0x28222C0 VA: 0x28262C0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2826A74 Offset: 0x2822A74 VA: 0x2826A74
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28262C8 Offset: 0x28222C8 VA: 0x28262C8
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2826B14 Offset: 0x2822B14 VA: 0x2826B14
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28262FC Offset: 0x28222FC VA: 0x28262FC
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2826B48 Offset: 0x2822B48 VA: 0x2826B48
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2826304 Offset: 0x2822304 VA: 0x2826304
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2826BEC Offset: 0x2822BEC VA: 0x2826BEC
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28263A0 Offset: 0x28223A0 VA: 0x28263A0
	|-Enumerable.<TakeIterator>d__25<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2826D38 Offset: 0x2822D38 VA: 0x2826D38
	|-Enumerable.<TakeIterator>d__25<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
