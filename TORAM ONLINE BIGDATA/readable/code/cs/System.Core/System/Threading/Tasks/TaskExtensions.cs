// Assembly: System.Core.dll
// Namespace: System.Threading.Tasks
[Extension]
public static class TaskExtensions // TypeDefIndex: 15811
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static Task<TResult> Unwrap<TResult>(Task<Task<TResult>> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F59D8 Offset: 0x26F19D8 VA: 0x26F59D8
	|-TaskExtensions.Unwrap<Int32Enum>
	|
	|-RVA: 0x26F5AEC Offset: 0x26F1AEC VA: 0x26F5AEC
	|-TaskExtensions.Unwrap<__Il2CppFullySharedGenericType>
	*/
}
