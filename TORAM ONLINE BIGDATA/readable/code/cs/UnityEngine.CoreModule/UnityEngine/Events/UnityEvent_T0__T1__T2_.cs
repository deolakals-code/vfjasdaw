// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 16433
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDD9D4 Offset: 0x2CD99D4 VA: 0x2CDD9D4
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDD9F8 Offset: 0x2CD99F8 VA: 0x2CDD9F8
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDDB94 Offset: 0x2CD9B94 VA: 0x2CDDB94
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/
}
