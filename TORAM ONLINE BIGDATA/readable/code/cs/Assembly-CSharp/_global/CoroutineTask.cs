// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CoroutineTask : ITask, IDisposable // TypeDefIndex: 5601
{
	// Fields
	private bool forcedEnd; // 0x10
	private IWorkerThread thread; // 0x18
	private IEnumerator task; // 0x20
	private CoroutineTask.InnerCustomYieldInstruction innerYieldInstruction; // 0x28
	private bool disposedValue; // 0x30

	// Properties
	public Action ThreadAction { get; }
	public CustomYieldInstruction YieldInstruction { get; }

	// Methods

	// RVA: 0x17A4DF8 Offset: 0x17A0DF8 VA: 0x17A4DF8
	public void ForcedEnd() { }

	// RVA: 0x17A4E04 Offset: 0x17A0E04 VA: 0x17A4E04 Slot: 5
	public Action get_ThreadAction() { }

	// RVA: 0x17A4E80 Offset: 0x17A0E80 VA: 0x17A4E80 Slot: 4
	public CustomYieldInstruction get_YieldInstruction() { }

	// RVA: 0x17A4E88 Offset: 0x17A0E88 VA: 0x17A4E88 Slot: 6
	public void SetWorkerThread(IWorkerThread thread) { }

	// RVA: 0x17A4F0C Offset: 0x17A0F0C VA: 0x17A4F0C
	public void SetEnumerator(IEnumerator enumetator) { }

	// RVA: 0x17A4F14 Offset: 0x17A0F14 VA: 0x17A4F14 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17A4F38 Offset: 0x17A0F38 VA: 0x17A4F38 Slot: 7
	public void Dispose() { }

	// RVA: 0x17A4F48 Offset: 0x17A0F48 VA: 0x17A4F48
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17A4F50 Offset: 0x17A0F50 VA: 0x17A4F50
	private void <get_ThreadAction>b__8_0() { }
}
