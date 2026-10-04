// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IDispatcherDebug // TypeDefIndex: 17470
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_FlushStarted(Action<byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_FlushStarted(Action<byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value);
}
