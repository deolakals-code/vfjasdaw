// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IBufferDebug // TypeDefIndex: 17469
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_EventRecorded(Action<string, string, DateTime, byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_EventRecorded(Action<string, string, DateTime, byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_EventsClearing(Action<HashSet<string>> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_EventsClearing(Action<HashSet<string>> value);
}
