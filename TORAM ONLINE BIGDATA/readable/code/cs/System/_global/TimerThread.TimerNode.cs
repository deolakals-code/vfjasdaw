// Assembly: System.dll
// Namespace: 
private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 14433
{
	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal override bool HasExpired { get; }
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x34F81F4 Offset: 0x34F41F4 VA: 0x34F81F4
	internal void .ctor(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x34F7F98 Offset: 0x34F3F98 VA: 0x34F7F98
	internal void .ctor() { }

	// RVA: 0x34F8770 Offset: 0x34F4770 VA: 0x34F8770 Slot: 6
	internal override bool get_HasExpired() { }

	// RVA: 0x34F8780 Offset: 0x34F4780 VA: 0x34F8780
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x34F8788 Offset: 0x34F4788 VA: 0x34F8788
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x34F8790 Offset: 0x34F4790 VA: 0x34F8790
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x34F8798 Offset: 0x34F4798 VA: 0x34F8798
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x34F87A0 Offset: 0x34F47A0 VA: 0x34F87A0 Slot: 5
	internal override bool Cancel() { }

	// RVA: 0x34F8400 Offset: 0x34F4400 VA: 0x34F8400
	internal bool Fire() { }
}
