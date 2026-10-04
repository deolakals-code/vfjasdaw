// Assembly: System.dll
// Namespace: 
internal abstract class TimerThread.Queue // TypeDefIndex: 14427
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Properties
	internal int Duration { get; }

	// Methods

	// RVA: 0x34F7D34 Offset: 0x34F3D34 VA: 0x34F7D34
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x34F7D5C Offset: 0x34F3D5C VA: 0x34F7D5C
	internal int get_Duration() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);
}
