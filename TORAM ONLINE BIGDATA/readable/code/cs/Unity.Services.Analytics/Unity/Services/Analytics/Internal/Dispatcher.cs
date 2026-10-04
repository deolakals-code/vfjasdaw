// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class Dispatcher : IDispatcher, IDispatcherDebug // TypeDefIndex: 17468
{
	// Fields
	private readonly IWebRequestHelper m_WebRequestHelper; // 0x10
	private readonly string m_CollectUrl; // 0x18
	private IBuffer m_DataBuffer; // 0x20
	private IWebRequest m_FlushRequest; // 0x28
	private byte[] m_LastFlushPayload; // 0x30
	private int m_FlushBufferIndex; // 0x38
	[CompilerGenerated]
	private int <ConsecutiveFailedUploadCount>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <FlushInProgress>k__BackingField; // 0x40
	[CompilerGenerated]
	private Action<byte[]> FlushStarted; // 0x48
	[CompilerGenerated]
	private Action<int, bool, bool, bool, bool, byte[]> FlushFinished; // 0x50

	// Properties
	public int ConsecutiveFailedUploadCount { get; set; }
	public bool FlushInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37A70C0 Offset: 0x37A30C0 VA: 0x37A70C0 Slot: 4
	public int get_ConsecutiveFailedUploadCount() { }

	[CompilerGenerated]
	// RVA: 0x37A70C8 Offset: 0x37A30C8 VA: 0x37A70C8
	private void set_ConsecutiveFailedUploadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x37A70D0 Offset: 0x37A30D0 VA: 0x37A70D0 Slot: 11
	public bool get_FlushInProgress() { }

	[CompilerGenerated]
	// RVA: 0x37A70D8 Offset: 0x37A30D8 VA: 0x37A70D8
	private void set_FlushInProgress(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37A70E4 Offset: 0x37A30E4 VA: 0x37A70E4 Slot: 7
	public void add_FlushStarted(Action<byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x37A7194 Offset: 0x37A3194 VA: 0x37A7194 Slot: 8
	public void remove_FlushStarted(Action<byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x37A7244 Offset: 0x37A3244 VA: 0x37A7244 Slot: 9
	public void add_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0x37A72F4 Offset: 0x37A32F4 VA: 0x37A72F4 Slot: 10
	public void remove_FlushFinished(Action<int, bool, bool, bool, bool, byte[]> value) { }

	// RVA: 0x379D324 Offset: 0x3799324 VA: 0x379D324
	public void .ctor(IWebRequestHelper webRequestHelper, string collectUrl) { }

	// RVA: 0x37A73A4 Offset: 0x37A33A4 VA: 0x37A73A4 Slot: 5
	public void SetBuffer(IBuffer buffer) { }

	// RVA: 0x37A73AC Offset: 0x37A33AC VA: 0x37A73AC Slot: 6
	public void Flush() { }

	// RVA: 0x37A7430 Offset: 0x37A3430 VA: 0x37A7430
	private void FlushBufferToService() { }

	// RVA: 0x37A7858 Offset: 0x37A3858 VA: 0x37A7858
	private void UploadCompleted(long responseCode) { }
}
