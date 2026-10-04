// Assembly: mscorlib.dll
// Namespace: 
internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 9920
{
	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x3052310 Offset: 0x304E310 VA: 0x3052310
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x3052920 Offset: 0x304E920 VA: 0x3052920
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x3052E20 Offset: 0x304EE20 VA: 0x3052E20
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x30532DC Offset: 0x304F2DC VA: 0x30532DC
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x30537EC Offset: 0x304F7EC VA: 0x30537EC
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x3053AC8 Offset: 0x304FAC8 VA: 0x3053AC8
	public void .ctor() { }
}
