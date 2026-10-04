// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Store : IDisposable // TypeDefIndex: 14157
{
	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0x34981E8 Offset: 0x34941E8 VA: 0x34981E8
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x3497E9C Offset: 0x3493E9C VA: 0x3497E9C
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x349C400 Offset: 0x3498400 VA: 0x349C400
	private X509Stores get_Factory() { }

	// RVA: 0x349C41C Offset: 0x349841C VA: 0x349C41C
	internal X509Store get_Store() { }

	// RVA: 0x3497BA4 Offset: 0x3493BA4 VA: 0x3497BA4
	public void Close() { }

	// RVA: 0x349C424 Offset: 0x3498424 VA: 0x349C424 Slot: 4
	public void Dispose() { }

	// RVA: 0x3498320 Offset: 0x3494320 VA: 0x3498320
	public void Open(OpenFlags flags) { }
}
