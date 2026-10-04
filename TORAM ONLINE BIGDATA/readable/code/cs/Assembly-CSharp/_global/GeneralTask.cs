// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralTask : ITask, IDisposable // TypeDefIndex: 5605
{
	// Fields
	private GeneralTask.InnerCustomYieldInstruction innerYieldInstruction; // 0x10
	private IWorkerThread thread; // 0x18
	[CompilerGenerated]
	private Action<GeneralTask.IForcedEnd> TaskAction; // 0x20
	private GeneralTask.ForcedEndData end; // 0x28
	private bool disposedValue; // 0x30

	// Properties
	public Action ThreadAction { get; }
	public CustomYieldInstruction YieldInstruction { get; }

	// Methods

	// RVA: 0x17A53C4 Offset: 0x17A13C4 VA: 0x17A53C4
	public void .ctor() { }

	// RVA: 0x17A5438 Offset: 0x17A1438 VA: 0x17A5438
	public void .ctor(Action<GeneralTask.IForcedEnd> action) { }

	[CompilerGenerated]
	// RVA: 0x17A54C0 Offset: 0x17A14C0 VA: 0x17A54C0
	public void add_TaskAction(Action<GeneralTask.IForcedEnd> value) { }

	[CompilerGenerated]
	// RVA: 0x17A5570 Offset: 0x17A1570 VA: 0x17A5570
	public void remove_TaskAction(Action<GeneralTask.IForcedEnd> value) { }

	// RVA: 0x17A5620 Offset: 0x17A1620 VA: 0x17A5620 Slot: 5
	public Action get_ThreadAction() { }

	// RVA: 0x17A569C Offset: 0x17A169C VA: 0x17A569C Slot: 4
	public CustomYieldInstruction get_YieldInstruction() { }

	// RVA: 0x17A56A4 Offset: 0x17A16A4 VA: 0x17A56A4
	public void ForcedEnd() { }

	// RVA: 0x17A56C4 Offset: 0x17A16C4 VA: 0x17A56C4 Slot: 6
	public void SetWorkerThread(IWorkerThread thread) { }

	// RVA: 0x17A5748 Offset: 0x17A1748 VA: 0x17A5748 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17A577C Offset: 0x17A177C VA: 0x17A577C Slot: 7
	public void Dispose() { }

	[CompilerGenerated]
	// RVA: 0x17A578C Offset: 0x17A178C VA: 0x17A578C
	private void <get_ThreadAction>b__12_0() { }
}
