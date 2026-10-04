// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class CookieContainer // TypeDefIndex: 14447
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x34FCE90 Offset: 0x34F8E90 VA: 0x34FCE90
	public void .ctor() { }

	// RVA: 0x34FCFB8 Offset: 0x34F8FB8 VA: 0x34FCFB8
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x34FD0DC Offset: 0x34F90DC VA: 0x34FD0DC
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x34FDF24 Offset: 0x34F9F24 VA: 0x34FDF24
	private bool AgeCookies(string domain) { }

	// RVA: 0x34FF494 Offset: 0x34FB494 VA: 0x34FF494
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x34FF624 Offset: 0x34FB624 VA: 0x34FF624
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x34FF8C4 Offset: 0x34FB8C4 VA: 0x34FF8C4
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x34FFF9C Offset: 0x34FBF9C VA: 0x34FFF9C
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x350044C Offset: 0x34FC44C VA: 0x350044C
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x3500C90 Offset: 0x34FCC90 VA: 0x3500C90
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x3500E9C Offset: 0x34FCE9C VA: 0x3500E9C
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x3500F68 Offset: 0x34FCF68 VA: 0x3500F68
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x350130C Offset: 0x34FD30C VA: 0x350130C
	private static void .cctor() { }
}
