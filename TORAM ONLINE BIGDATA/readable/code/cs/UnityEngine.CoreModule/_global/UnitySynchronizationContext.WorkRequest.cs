// Assembly: UnityEngine.CoreModule.dll
// Namespace: 
private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 16378
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0x37F0D88 Offset: 0x37ECD88 VA: 0x37F0D88
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x37F11D4 Offset: 0x37ED1D4 VA: 0x37F11D4
	public void Invoke() { }
}
