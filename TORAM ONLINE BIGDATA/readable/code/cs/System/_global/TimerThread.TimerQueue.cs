// Assembly: System.dll
// Namespace: 
private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 14430
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerThread.TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x34F7ED8 Offset: 0x34F3ED8 VA: 0x34F7ED8
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x34F7FC8 Offset: 0x34F3FC8 VA: 0x34F7FC8 Slot: 4
	internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context) { }

	// RVA: 0x34F8270 Offset: 0x34F4270 VA: 0x34F8270
	internal bool Fire(out int nextExpiration) { }
}
