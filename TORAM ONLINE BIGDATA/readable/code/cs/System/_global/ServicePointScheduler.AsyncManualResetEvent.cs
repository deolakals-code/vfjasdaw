// Assembly: System.dll
// Namespace: 
private class ServicePointScheduler.AsyncManualResetEvent // TypeDefIndex: 14504
{
	// Fields
	private TaskCompletionSource<bool> m_tcs; // 0x10

	// Methods

	// RVA: 0x3518CDC Offset: 0x3514CDC VA: 0x3518CDC
	public Task<bool> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x3516C98 Offset: 0x3512C98 VA: 0x3516C98
	public void Set() { }

	// RVA: 0x3517394 Offset: 0x3513394 VA: 0x3517394
	public void Reset() { }

	// RVA: 0x35169F0 Offset: 0x35129F0 VA: 0x35169F0
	public void .ctor(bool state) { }
}
