// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 14135
{
	// Fields
	private static string[] newline_split; // 0x0

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x34913CC Offset: 0x348D3CC VA: 0x34913CC
	public void .ctor() { }

	// RVA: 0x34913DC Offset: 0x348D3DC VA: 0x34913DC
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x3491478 Offset: 0x348D478 VA: 0x3491478
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x349159C Offset: 0x348D59C VA: 0x349159C
	public int Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x3491408 Offset: 0x348D408 VA: 0x3491408
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x349160C Offset: 0x348D60C VA: 0x349160C
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x349194C Offset: 0x348D94C VA: 0x349194C
	private string GetKeyIdentifier(X509Certificate2 x) { }

	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	// RVA: 0x34921F8 Offset: 0x348E1F8 VA: 0x34921F8
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x34933A4 Offset: 0x348F3A4 VA: 0x34933A4
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x34934B8 Offset: 0x348F4B8 VA: 0x34934B8
	private static void .cctor() { }
}
