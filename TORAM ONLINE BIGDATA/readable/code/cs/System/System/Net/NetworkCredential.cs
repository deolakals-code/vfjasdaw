// Assembly: System.dll
// Namespace: System.Net
public class NetworkCredential : ICredentials // TypeDefIndex: 14403
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x34E7C24 Offset: 0x34E3C24 VA: 0x34E7C24
	public void .ctor(string userName, string password) { }

	// RVA: 0x34ED140 Offset: 0x34E9140 VA: 0x34ED140
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x34E4680 Offset: 0x34E0680 VA: 0x34E4680
	public string get_UserName() { }

	// RVA: 0x34EED5C Offset: 0x34EAD5C VA: 0x34EED5C
	public void set_UserName(string value) { }

	// RVA: 0x34E4690 Offset: 0x34E0690 VA: 0x34E4690
	public string get_Password() { }

	// RVA: 0x34EEDC8 Offset: 0x34EADC8 VA: 0x34EEDC8
	public void set_Password(string value) { }

	// RVA: 0x34E4688 Offset: 0x34E0688 VA: 0x34E4688
	public string get_Domain() { }

	// RVA: 0x34EEDF0 Offset: 0x34EADF0 VA: 0x34EEDF0
	public void set_Domain(string value) { }

	// RVA: 0x34EEE68 Offset: 0x34EAE68 VA: 0x34EEE68
	internal string InternalGetUserName() { }

	// RVA: 0x34EEE5C Offset: 0x34EAE5C VA: 0x34EEE5C
	internal string InternalGetPassword() { }

	// RVA: 0x34EEE70 Offset: 0x34EAE70 VA: 0x34EEE70
	internal string InternalGetDomain() { }

	// RVA: 0x34EEE78 Offset: 0x34EAE78 VA: 0x34EEE78 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }
}
