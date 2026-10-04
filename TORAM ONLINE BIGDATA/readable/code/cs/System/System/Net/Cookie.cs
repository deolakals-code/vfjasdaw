// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public sealed class Cookie // TypeDefIndex: 14437
{
	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalField]
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x34F893C Offset: 0x34F493C VA: 0x34F893C
	public void .ctor() { }

	// RVA: 0x34F8A8C Offset: 0x34F4A8C VA: 0x34F8A8C
	public string get_Comment() { }

	// RVA: 0x34F8A94 Offset: 0x34F4A94 VA: 0x34F8A94
	public void set_Comment(string value) { }

	// RVA: 0x34F8AF4 Offset: 0x34F4AF4 VA: 0x34F8AF4
	public void set_CommentUri(Uri value) { }

	// RVA: 0x34F8AFC Offset: 0x34F4AFC VA: 0x34F8AFC
	public void set_HttpOnly(bool value) { }

	// RVA: 0x34F8B08 Offset: 0x34F4B08 VA: 0x34F8B08
	public void set_Discard(bool value) { }

	// RVA: 0x34F8B14 Offset: 0x34F4B14 VA: 0x34F8B14
	public string get_Domain() { }

	// RVA: 0x34F8B1C Offset: 0x34F4B1C VA: 0x34F8B1C
	public void set_Domain(string value) { }

	// RVA: 0x34F8BA0 Offset: 0x34F4BA0 VA: 0x34F8BA0
	private string get__Domain() { }

	// RVA: 0x34F8C7C Offset: 0x34F4C7C VA: 0x34F8C7C
	public bool get_Expired() { }

	// RVA: 0x34F8D34 Offset: 0x34F4D34 VA: 0x34F8D34
	public void set_Expires(DateTime value) { }

	// RVA: 0x34F8D3C Offset: 0x34F4D3C VA: 0x34F8D3C
	public string get_Name() { }

	// RVA: 0x34F8D44 Offset: 0x34F4D44 VA: 0x34F8D44
	internal bool InternalSetName(string value) { }

	// RVA: 0x34F8E60 Offset: 0x34F4E60 VA: 0x34F8E60
	public string get_Path() { }

	// RVA: 0x34F8E68 Offset: 0x34F4E68 VA: 0x34F8E68
	public void set_Path(string value) { }

	// RVA: 0x34F8EE0 Offset: 0x34F4EE0 VA: 0x34F8EE0
	private string get__Path() { }

	// RVA: 0x34F8C6C Offset: 0x34F4C6C VA: 0x34F8C6C
	internal bool get_Plain() { }

	// RVA: 0x34F8F7C Offset: 0x34F4F7C VA: 0x34F8F7C
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x34F8FD4 Offset: 0x34F4FD4 VA: 0x34F8FD4
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x34F9A68 Offset: 0x34F5A68 VA: 0x34F9A68
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x34F9BE0 Offset: 0x34F5BE0 VA: 0x34F9BE0
	public void set_Port(string value) { }

	// RVA: 0x34F9F2C Offset: 0x34F5F2C VA: 0x34F9F2C
	internal int[] get_PortList() { }

	// RVA: 0x34F9F34 Offset: 0x34F5F34 VA: 0x34F9F34
	private string get__Port() { }

	// RVA: 0x34F9FFC Offset: 0x34F5FFC VA: 0x34F9FFC
	public bool get_Secure() { }

	// RVA: 0x34FA004 Offset: 0x34F6004 VA: 0x34FA004
	public void set_Secure(bool value) { }

	// RVA: 0x34FA010 Offset: 0x34F6010 VA: 0x34FA010
	public string get_Value() { }

	// RVA: 0x34FA018 Offset: 0x34F6018 VA: 0x34FA018
	public void set_Value(string value) { }

	// RVA: 0x34FA088 Offset: 0x34F6088 VA: 0x34FA088
	internal CookieVariant get_Variant() { }

	// RVA: 0x34FA090 Offset: 0x34F6090 VA: 0x34FA090
	internal string get_DomainKey() { }

	// RVA: 0x34FA0AC Offset: 0x34F60AC VA: 0x34FA0AC
	public int get_Version() { }

	// RVA: 0x34FA0B4 Offset: 0x34F60B4 VA: 0x34FA0B4
	public void set_Version(int value) { }

	// RVA: 0x34FA128 Offset: 0x34F6128 VA: 0x34FA128
	private string get__Version() { }

	// RVA: 0x34FA234 Offset: 0x34F6234 VA: 0x34FA234
	internal static IComparer GetComparer() { }

	// RVA: 0x34FA28C Offset: 0x34F628C VA: 0x34FA28C Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x34FA35C Offset: 0x34F635C VA: 0x34FA35C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34FA544 Offset: 0x34F6544 VA: 0x34FA544 Slot: 3
	public override string ToString() { }

	// RVA: 0x34FA7F8 Offset: 0x34F67F8 VA: 0x34FA7F8
	private static void .cctor() { }
}
