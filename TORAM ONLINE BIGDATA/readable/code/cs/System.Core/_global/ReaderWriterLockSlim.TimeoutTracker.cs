// Assembly: System.Core.dll
// Namespace: 
private struct ReaderWriterLockSlim.TimeoutTracker // TypeDefIndex: 15809
{
	// Fields
	private int m_total; // 0x0
	private int m_start; // 0x4

	// Properties
	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }

	// Methods

	// RVA: 0x318E2CC Offset: 0x318A2CC VA: 0x318E2CC
	public void .ctor(int millisecondsTimeout) { }

	// RVA: 0x318F63C Offset: 0x318B63C VA: 0x318F63C
	public int get_RemainingMilliseconds() { }

	// RVA: 0x318E6E4 Offset: 0x318A6E4 VA: 0x318E6E4
	public bool get_IsExpired() { }
}
