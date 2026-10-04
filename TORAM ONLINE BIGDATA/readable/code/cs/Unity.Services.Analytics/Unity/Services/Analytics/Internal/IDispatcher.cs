// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IDispatcher // TypeDefIndex: 17467
{
	// Properties
	public abstract int ConsecutiveFailedUploadCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ConsecutiveFailedUploadCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetBuffer(IBuffer buffer);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Flush();
}
