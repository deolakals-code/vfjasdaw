// Assembly: System.dll
// Namespace: 
internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 14428
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Properties
	internal int StartTime { get; }
	internal int Expiration { get; }
	internal abstract bool HasExpired { get; }

	// Methods

	// RVA: 0x34F7D64 Offset: 0x34F3D64 VA: 0x34F7D64
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x34F7D98 Offset: 0x34F3D98 VA: 0x34F7D98
	internal int get_StartTime() { }

	// RVA: 0x34F7DA0 Offset: 0x34F3DA0 VA: 0x34F7DA0
	internal int get_Expiration() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool get_HasExpired();

	// RVA: 0x34F7DAC Offset: 0x34F3DAC VA: 0x34F7DAC Slot: 4
	public void Dispose() { }
}
