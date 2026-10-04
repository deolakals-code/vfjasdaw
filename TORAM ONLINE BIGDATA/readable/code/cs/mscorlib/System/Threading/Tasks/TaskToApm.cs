// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
internal static class TaskToApm // TypeDefIndex: 9949
{
	// Methods

	// RVA: 0x3058608 Offset: 0x3054608 VA: 0x3058608
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x30588C4 Offset: 0x30548C4 VA: 0x30588C4
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F65A4 Offset: 0x26F25A4 VA: 0x26F65A4
	|-TaskToApm.End<int>
	|
	|-RVA: 0x26F669C Offset: 0x26F269C VA: 0x26F669C
	|-TaskToApm.End<object>
	|
	|-RVA: 0x26F6794 Offset: 0x26F2794 VA: 0x26F6794
	|-TaskToApm.End<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x30587B4 Offset: 0x30547B4 VA: 0x30587B4
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}
