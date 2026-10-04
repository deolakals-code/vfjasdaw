// Assembly: mscorlib.dll
// Namespace: System.Collections.Concurrent
[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
internal sealed class CDSCollectionETWBCLProvider : EventSource // TypeDefIndex: 10908
{
	// Fields
	public static CDSCollectionETWBCLProvider Log; // 0x0

	// Methods

	// RVA: 0x2FC3E34 Offset: 0x2FBFE34 VA: 0x2FC3E34
	private void .ctor() { }

	[Event(3, Level = 3)]
	// RVA: 0x2FC3E3C Offset: 0x2FBFE3C VA: 0x2FC3E3C
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

	// RVA: 0x2FC3E88 Offset: 0x2FBFE88 VA: 0x2FC3E88
	private static void .cctor() { }
}
