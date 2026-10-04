// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IBufferSystemCalls // TypeDefIndex: 17459
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GenerateGuid();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DateTime Now();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan GetTimeZoneUtcOffset(DateTime dateTime);
}
