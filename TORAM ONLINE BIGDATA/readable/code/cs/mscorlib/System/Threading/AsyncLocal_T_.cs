// Assembly: mscorlib.dll
// Namespace: System.Threading
public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 9853
{
	// Fields
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4646C Offset: 0x2B4246C VA: 0x2B4646C
	|-AsyncLocal<object>..ctor
	|
	|-RVA: 0x2B465AC Offset: 0x2B425AC VA: 0x2B465AC
	|-AsyncLocal<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46474 Offset: 0x2B42474 VA: 0x2B46474
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	|
	|-RVA: 0x2B465B4 Offset: 0x2B425B4 VA: 0x2B465B4
	|-AsyncLocal<__Il2CppFullySharedGenericType>.System.Threading.IAsyncLocal.OnValueChanged
	*/
}
