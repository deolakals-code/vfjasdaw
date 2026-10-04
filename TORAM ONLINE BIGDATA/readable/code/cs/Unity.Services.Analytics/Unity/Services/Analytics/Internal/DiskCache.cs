// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class DiskCache : IDiskCache // TypeDefIndex: 17466
{
	// Fields
	private readonly string k_CacheFilePath; // 0x10
	private readonly IFileSystemCalls k_SystemCalls; // 0x18
	private readonly long k_CacheFileMaximumSize; // 0x20

	// Methods

	// RVA: 0x379C5D0 Offset: 0x37985D0 VA: 0x379C5D0
	internal void .ctor(IFileSystemCalls systemCalls) { }

	// RVA: 0x37A6920 Offset: 0x37A2920 VA: 0x37A6920 Slot: 5
	public void Write(List<EventSummary> eventSummaries, Stream payload) { }

	// RVA: 0x37A6F28 Offset: 0x37A2F28 VA: 0x37A6F28 Slot: 4
	public void Clear() { }
}
