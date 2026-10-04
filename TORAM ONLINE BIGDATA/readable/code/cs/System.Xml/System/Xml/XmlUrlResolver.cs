// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlUrlResolver : XmlResolver // TypeDefIndex: 13474
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x33E2D38 Offset: 0x33DED38 VA: 0x33E2D38
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x33E2E04 Offset: 0x33DEE04 VA: 0x33E2E04
	public void .ctor() { }

	// RVA: 0x33E2E0C Offset: 0x33DEE0C VA: 0x33E2E0C Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x33E2F84 Offset: 0x33DEF84 VA: 0x33E2F84 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachine(typeof(XmlUrlResolver.<GetEntityAsync>d__15))]
	// RVA: 0x33E2F88 Offset: 0x33DEF88 VA: 0x33E2F88 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }
}
