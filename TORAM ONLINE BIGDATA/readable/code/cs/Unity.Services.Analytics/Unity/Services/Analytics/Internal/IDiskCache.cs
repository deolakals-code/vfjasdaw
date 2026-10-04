// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IDiskCache // TypeDefIndex: 17463
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Write(List<EventSummary> eventSummaries, Stream payload);
}
