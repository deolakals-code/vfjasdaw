// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus // TypeDefIndex: 14150
{
	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x3497A30 Offset: 0x3493A30 VA: 0x3497A30
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x349AAA0 Offset: 0x3496AA0 VA: 0x349AAA0
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x349AAA8 Offset: 0x3496AA8 VA: 0x349AAA8
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x349AAB0 Offset: 0x3496AB0 VA: 0x349AAB0
	public void set_StatusInformation(string value) { }

	// RVA: 0x3496440 Offset: 0x3492440 VA: 0x3496440
	internal static string GetInformation(X509ChainStatusFlags flags) { }
}
