// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 16429
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDC888 Offset: 0x2CD8888 VA: 0x2CDC888
	|-UnityEvent<int>..ctor
	|
	|-RVA: 0x2CDCD68 Offset: 0x2CD8D68 VA: 0x2CDCD68
	|-UnityEvent<object>..ctor
	|
	|-RVA: 0x2CDD224 Offset: 0x2CD9224 VA: 0x2CDD224
	|-UnityEvent<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDC8AC Offset: 0x2CD88AC VA: 0x2CDC8AC
	|-UnityEvent<int>.AddListener
	|
	|-RVA: 0x2CDCD8C Offset: 0x2CD8D8C VA: 0x2CDCD8C
	|-UnityEvent<object>.AddListener
	|
	|-RVA: 0x2CDD248 Offset: 0x2CD9248 VA: 0x2CDD248
	|-UnityEvent<__Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDC8E8 Offset: 0x2CD88E8 VA: 0x2CDC8E8
	|-UnityEvent<int>.RemoveListener
	|
	|-RVA: 0x2CDCDC8 Offset: 0x2CD8DC8 VA: 0x2CDCDC8
	|-UnityEvent<object>.RemoveListener
	|
	|-RVA: 0x2CDD288 Offset: 0x2CD9288 VA: 0x2CDD288
	|-UnityEvent<__Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDC92C Offset: 0x2CD892C VA: 0x2CDC92C
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x2CDCE0C Offset: 0x2CD8E0C VA: 0x2CDCE0C
	|-UnityEvent<object>.FindMethod_Impl
	|
	|-RVA: 0x2CDD2CC Offset: 0x2CD92CC VA: 0x2CDD2CC
	|-UnityEvent<__Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDCA30 Offset: 0x2CD8A30 VA: 0x2CDCA30
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x2CDCF10 Offset: 0x2CD8F10 VA: 0x2CDCF10
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0x2CDD3D0 Offset: 0x2CD93D0 VA: 0x2CDD3D0
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDCA8C Offset: 0x2CD8A8C VA: 0x2CDCA8C
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x2CDCF6C Offset: 0x2CD8F6C VA: 0x2CDCF6C
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0x2CDD430 Offset: 0x2CD9430 VA: 0x2CDD430
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CDCB0C Offset: 0x2CD8B0C VA: 0x2CDCB0C
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x2CDCFEC Offset: 0x2CD8FEC VA: 0x2CDCFEC
	|-UnityEvent<object>.Invoke
	|
	|-RVA: 0x2CDD4E0 Offset: 0x2CD94E0 VA: 0x2CDD4E0
	|-UnityEvent<__Il2CppFullySharedGenericType>.Invoke
	*/
}
