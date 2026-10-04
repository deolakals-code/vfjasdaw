// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent : UnityEventBase // TypeDefIndex: 16427
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37F68C0 Offset: 0x37F28C0 VA: 0x37F68C0
	public void .ctor() { }

	// RVA: 0x37F68E0 Offset: 0x37F28E0 VA: 0x37F68E0
	public void AddListener(UnityAction call) { }

	// RVA: 0x37F6970 Offset: 0x37F2970 VA: 0x37F6970 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x37F69D4 Offset: 0x37F29D4 VA: 0x37F69D4 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x37F690C Offset: 0x37F290C VA: 0x37F690C
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x37F6A3C Offset: 0x37F2A3C VA: 0x37F6A3C
	public void Invoke() { }
}
