// Assembly: mscorlib.dll
// Namespace: 
private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 10530
{
	// Fields
	internal readonly Action m_continuation; // 0x10
	private readonly Action m_invokeAction; // 0x18
	internal readonly Task m_innerTask; // 0x20

	// Methods

	// RVA: 0x2F220BC Offset: 0x2F1E0BC VA: 0x2F220BC
	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x2F224B4 Offset: 0x2F1E4B4 VA: 0x2F224B4
	internal void Invoke() { }
}
