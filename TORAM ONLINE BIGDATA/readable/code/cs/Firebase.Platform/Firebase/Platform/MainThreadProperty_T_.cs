// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Platform
internal class MainThreadProperty<T> // TypeDefIndex: 17746
{
	// Fields
	private Func<T> getPropertyDelegate; // 0x0
	private int lastGetPropertyTickCount; // 0x0
	private T cachedValue; // 0x0

	// Properties
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> getPropertyDelegate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA4DAC Offset: 0x2BA0DAC VA: 0x2BA4DAC
	|-MainThreadProperty<bool>..ctor
	|
	|-RVA: 0x2BA5240 Offset: 0x2BA1240 VA: 0x2BA5240
	|-MainThreadProperty<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA4DE4 Offset: 0x2BA0DE4 VA: 0x2BA4DE4
	|-MainThreadProperty<bool>.get_Value
	|
	|-RVA: 0x2BA52A0 Offset: 0x2BA12A0 VA: 0x2BA52A0
	|-MainThreadProperty<__Il2CppFullySharedGenericType>.get_Value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private T <get_Value>b__5_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA5114 Offset: 0x2BA1114 VA: 0x2BA5114
	|-MainThreadProperty<bool>.<get_Value>b__5_0
	|
	|-RVA: 0x2BA575C Offset: 0x2BA175C VA: 0x2BA575C
	|-MainThreadProperty<__Il2CppFullySharedGenericType>.<get_Value>b__5_0
	*/
}
