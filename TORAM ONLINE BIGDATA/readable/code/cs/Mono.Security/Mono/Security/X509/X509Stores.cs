// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public class X509Stores // TypeDefIndex: 16888
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Properties
	public X509Store TrustedRoot { get; }

	// Methods

	// RVA: 0x2E52F6C Offset: 0x2E4EF6C VA: 0x2E52F6C
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0x2E5305C Offset: 0x2E4F05C VA: 0x2E5305C
	public X509Store get_TrustedRoot() { }

	// RVA: 0x2E5314C Offset: 0x2E4F14C VA: 0x2E5314C
	public X509Store Open(string storeName, bool create) { }
}
