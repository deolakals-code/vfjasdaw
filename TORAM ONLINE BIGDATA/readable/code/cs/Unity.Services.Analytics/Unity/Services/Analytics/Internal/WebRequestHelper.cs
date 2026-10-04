// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class WebRequestHelper : IWebRequestHelper // TypeDefIndex: 17478
{
	// Fields
	private readonly string k_ClientIdHeaderValue; // 0x10

	// Methods

	// RVA: 0x37A7C70 Offset: 0x37A3C70 VA: 0x37A7C70 Slot: 4
	public IWebRequest CreateWebRequest(string url, string method, byte[] postBytes) { }

	// RVA: 0x37A7D80 Offset: 0x37A3D80 VA: 0x37A7D80 Slot: 5
	public void SendWebRequest(IWebRequest request, Action<long> onCompleted) { }

	// RVA: 0x379D290 Offset: 0x3799290 VA: 0x379D290
	public void .ctor() { }
}
