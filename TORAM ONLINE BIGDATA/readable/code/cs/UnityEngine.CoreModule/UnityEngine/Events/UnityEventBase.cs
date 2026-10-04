// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
[UsedByNativeCode]
[Serializable]
public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 16425
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x37F6148 Offset: 0x37F2148 VA: 0x37F6148
	protected void .ctor() { }

	// RVA: 0x37F61F4 Offset: 0x37F21F4 VA: 0x37F61F4 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x37F6220 Offset: 0x37F2220 VA: 0x37F6220 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x37F5120 Offset: 0x37F1120 VA: 0x37F5120
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x37F6224 Offset: 0x37F2224 VA: 0x37F6224
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x37F61F8 Offset: 0x37F21F8 VA: 0x37F61F8
	private void DirtyPersistentCalls() { }

	// RVA: 0x37F66F0 Offset: 0x37F26F0 VA: 0x37F66F0
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x37F6724 Offset: 0x37F2724 VA: 0x37F6724
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x37F673C Offset: 0x37F273C VA: 0x37F673C
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x37F6754 Offset: 0x37F2754 VA: 0x37F6754
	public void RemoveAllListeners() { }

	// RVA: 0x37F676C Offset: 0x37F276C VA: 0x37F676C
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x37F678C Offset: 0x37F278C VA: 0x37F678C Slot: 3
	public override string ToString() { }

	// RVA: 0x37F6508 Offset: 0x37F2508 VA: 0x37F6508
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }
}
