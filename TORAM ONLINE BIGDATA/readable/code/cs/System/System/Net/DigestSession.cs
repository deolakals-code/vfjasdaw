// Assembly: System.dll
// Namespace: System.Net
internal class DigestSession // TypeDefIndex: 14475
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x35093CC Offset: 0x35053CC VA: 0x35093CC
	private static void .cctor() { }

	// RVA: 0x3509428 Offset: 0x3505428 VA: 0x3509428
	public void .ctor() { }

	// RVA: 0x3509498 Offset: 0x3505498 VA: 0x3509498
	public string get_Algorithm() { }

	// RVA: 0x35094B0 Offset: 0x35054B0 VA: 0x35094B0
	public string get_Realm() { }

	// RVA: 0x35094C8 Offset: 0x35054C8 VA: 0x35094C8
	public string get_Nonce() { }

	// RVA: 0x35094E0 Offset: 0x35054E0 VA: 0x35094E0
	public string get_Opaque() { }

	// RVA: 0x35094F8 Offset: 0x35054F8 VA: 0x35094F8
	public string get_QOP() { }

	// RVA: 0x3509510 Offset: 0x3505510 VA: 0x3509510
	public string get_CNonce() { }

	// RVA: 0x3509610 Offset: 0x3505610 VA: 0x3509610
	public bool Parse(string challenge) { }

	// RVA: 0x3509708 Offset: 0x3505708 VA: 0x3509708
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x350985C Offset: 0x350585C VA: 0x350985C
	private string HA1(string username, string password) { }

	// RVA: 0x3509980 Offset: 0x3505980 VA: 0x3509980
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x3509A50 Offset: 0x3505A50 VA: 0x3509A50
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x3509BB0 Offset: 0x3505BB0 VA: 0x3509BB0
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x350A174 Offset: 0x3506174 VA: 0x350A174
	public DateTime get_LastUse() { }
}
