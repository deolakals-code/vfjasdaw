// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
internal class InvokableCallList // TypeDefIndex: 16424
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x37F5A44 Offset: 0x37F1A44 VA: 0x37F5A44
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x37F5AF8 Offset: 0x37F1AF8 VA: 0x37F5AF8
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x37F5BAC Offset: 0x37F1BAC VA: 0x37F5BAC
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x37F5E2C Offset: 0x37F1E2C VA: 0x37F5E2C
	public void Clear() { }

	// RVA: 0x37F5EF4 Offset: 0x37F1EF4 VA: 0x37F5EF4
	public void ClearPersistent() { }

	// RVA: 0x37F5FBC Offset: 0x37F1FBC VA: 0x37F5FBC
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x37F6070 Offset: 0x37F2070 VA: 0x37F6070
	public void .ctor() { }
}
