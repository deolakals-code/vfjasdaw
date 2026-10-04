// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class StackGuard // TypeDefIndex: 15345
{
	// Fields
	private int _executionStackCount; // 0x10

	// Methods

	// RVA: 0x314177C Offset: 0x313D77C VA: 0x314177C
	public bool TryEnterOnCurrentStack() { }

	// RVA: -1 Offset: -1
	public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F14E4 Offset: 0x26ED4E4 VA: 0x26F14E4
	|-StackGuard.RunOnEmptyStack<object, object>
	|
	|-RVA: 0x26F1668 Offset: 0x26ED668 VA: 0x26F1668
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private R RunOnEmptyStackCore<R>(Func<object, R> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F18DC Offset: 0x26ED8DC VA: 0x26F18DC
	|-StackGuard.RunOnEmptyStackCore<object>
	|
	|-RVA: 0x26F1BC0 Offset: 0x26EDBC0 VA: 0x26F1BC0
	|-StackGuard.RunOnEmptyStackCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x31417DC Offset: 0x313D7DC VA: 0x31417DC
	public void .ctor() { }
}
