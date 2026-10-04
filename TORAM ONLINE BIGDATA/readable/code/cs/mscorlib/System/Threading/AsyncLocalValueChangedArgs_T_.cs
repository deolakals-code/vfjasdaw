// Assembly: mscorlib.dll
// Namespace: System.Threading
[IsReadOnly]
public struct AsyncLocalValueChangedArgs<T> // TypeDefIndex: 9855
{
	// Fields
	[CompilerGenerated]
	private readonly T <PreviousValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly T <CurrentValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <ThreadContextChanged>k__BackingField; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T previousValue, T currentValue, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46208 Offset: 0x2B42208 VA: 0x2B46208
	|-AsyncLocalValueChangedArgs<object>..ctor
	|
	|-RVA: 0x2B46258 Offset: 0x2B42258 VA: 0x2B46258
	|-AsyncLocalValueChangedArgs<__Il2CppFullySharedGenericType>..ctor
	*/
}
