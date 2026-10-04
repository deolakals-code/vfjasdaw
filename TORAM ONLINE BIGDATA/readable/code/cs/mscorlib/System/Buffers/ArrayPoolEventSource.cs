// Assembly: mscorlib.dll
// Namespace: System.Buffers
[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
internal sealed class ArrayPoolEventSource : EventSource // TypeDefIndex: 10989
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	// RVA: 0x2FC44B8 Offset: 0x2FC04B8 VA: 0x2FC44B8
	private void .ctor() { }

	[Event(1, Level = 5)]
	// RVA: 0x2FC4564 Offset: 0x2FC0564 VA: 0x2FC4564
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Event(2, Level = 4)]
	// RVA: 0x2FC4674 Offset: 0x2FC0674 VA: 0x2FC4674
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason) { }

	[Event(3, Level = 5)]
	// RVA: 0x2FC47A4 Offset: 0x2FC07A4 VA: 0x2FC47A4
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[Event(4, Level = 4)]
	// RVA: 0x2FC47BC Offset: 0x2FC07BC VA: 0x2FC47BC
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[Event(5, Level = 4)]
	// RVA: 0x2FC47D4 Offset: 0x2FC07D4 VA: 0x2FC47D4
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

	// RVA: 0x2FC47E8 Offset: 0x2FC07E8 VA: 0x2FC47E8
	private static void .cctor() { }
}
