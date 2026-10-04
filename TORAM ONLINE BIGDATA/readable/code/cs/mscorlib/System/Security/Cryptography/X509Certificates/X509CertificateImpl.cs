// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 10175
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract string Issuer { get; }
	public abstract string Subject { get; }
	public abstract byte[] RawData { get; }
	public abstract DateTime NotAfter { get; }
	public abstract DateTime NotBefore { get; }
	public abstract byte[] Thumbprint { get; }
	public abstract string KeyAlgorithm { get; }
	public abstract byte[] KeyAlgorithmParameters { get; }
	public abstract byte[] PublicKeyValue { get; }
	public abstract byte[] SerialNumber { get; }
	public abstract bool HasPrivateKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x2EC797C Offset: 0x2EC397C VA: 0x2EC797C
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Issuer();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Subject();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] get_RawData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime get_NotAfter();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime get_NotBefore();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract byte[] get_Thumbprint();

	// RVA: 0x2EC7A38 Offset: 0x2EC3A38 VA: 0x2EC7A38 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_KeyAlgorithm();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] get_KeyAlgorithmParameters();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract byte[] get_PublicKeyValue();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract byte[] get_SerialNumber();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_HasPrivateKey();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RSA GetRSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract DSA GetDSAPrivateKey();

	// RVA: 0x2EC7AC0 Offset: 0x2EC3AC0 VA: 0x2EC7AC0 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x2EC67E4 Offset: 0x2EC27E4 VA: 0x2EC67E4 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EC7C4C Offset: 0x2EC3C4C VA: 0x2EC7C4C Slot: 20
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2EC7C50 Offset: 0x2EC3C50 VA: 0x2EC7C50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EC7CF4 Offset: 0x2EC3CF4 VA: 0x2EC7CF4
	protected void .ctor() { }
}
