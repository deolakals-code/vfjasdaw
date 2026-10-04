// Assembly: System.dll
// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal // TypeDefIndex: 14552
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Properties
	internal static object ClassSyncObject { get; }
	internal IWebProxy WebProxy { get; }

	// Methods

	// RVA: 0x344CE50 Offset: 0x3448E50 VA: 0x344CE50
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x344CE58 Offset: 0x3448E58 VA: 0x344CE58
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x344CE60 Offset: 0x3448E60 VA: 0x344CE60
	internal static object get_ClassSyncObject() { }

	// RVA: 0x344CEF8 Offset: 0x3448EF8 VA: 0x344CEF8
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x344D01C Offset: 0x344901C VA: 0x344D01C
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x344D014 Offset: 0x3449014 VA: 0x344D014
	public void .ctor() { }
}
