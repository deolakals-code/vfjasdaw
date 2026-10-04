// Assembly: mscorlib.dll
// Namespace: 
internal class Task.ContingentProperties // TypeDefIndex: 9967
{
	// Fields
	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal object m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal LowLevelListWithIList<Task> m_exceptionalChildren; // 0x40

	// Methods

	// RVA: 0x305D0A0 Offset: 0x30590A0 VA: 0x305D0A0
	internal void SetCompleted() { }

	// RVA: 0x305D0C8 Offset: 0x30590C8 VA: 0x305D0C8
	internal void UnregisterCancellationCallback() { }

	// RVA: 0x305A128 Offset: 0x3056128 VA: 0x305A128
	public void .ctor() { }
}
