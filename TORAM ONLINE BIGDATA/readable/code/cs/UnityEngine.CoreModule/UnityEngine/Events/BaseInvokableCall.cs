// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall // TypeDefIndex: 16414
{
	// Methods

	// RVA: 0x37F4874 Offset: 0x37F0874 VA: 0x37F4874
	protected void .ctor() { }

	// RVA: 0x37F487C Offset: 0x37F087C VA: 0x37F487C
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DB748 Offset: 0x27D7748 VA: 0x27DB748
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x27DB890 Offset: 0x27D7890 VA: 0x27DB890
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x27DB9D8 Offset: 0x27D79D8 VA: 0x27DB9D8
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x27DBB20 Offset: 0x27D7B20 VA: 0x27DBB20
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x27DBC68 Offset: 0x27D7C68 VA: 0x27DBC68
	|-BaseInvokableCall.ThrowOnInvalidArg<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37F4970 Offset: 0x37F0970 VA: 0x37F4970
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);
}
