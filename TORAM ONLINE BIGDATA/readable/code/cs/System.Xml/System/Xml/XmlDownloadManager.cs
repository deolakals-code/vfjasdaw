// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlDownloadManager // TypeDefIndex: 13448
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x33DCDE8 Offset: 0x33D8DE8 VA: 0x33DCDE8
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x33DCEE8 Offset: 0x33D8EE8 VA: 0x33DCEE8
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x33DD588 Offset: 0x33D9588 VA: 0x33DD588
	internal void Remove(string host) { }

	// RVA: 0x33DD6F4 Offset: 0x33D96F4 VA: 0x33DD6F4
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachine(typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5))]
	// RVA: 0x33DD86C Offset: 0x33D986C VA: 0x33DD86C
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x33DD9EC Offset: 0x33D99EC VA: 0x33DD9EC
	public void .ctor() { }
}
