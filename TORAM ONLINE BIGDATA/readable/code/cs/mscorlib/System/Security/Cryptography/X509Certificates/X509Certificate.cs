// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable // TypeDefIndex: 10174
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private byte[] lazyCertHash; // 0x18
	private byte[] lazySerialNumber; // 0x20
	private string lazyIssuer; // 0x28
	private string lazySubject; // 0x30
	private string lazyKeyAlgorithm; // 0x38
	private byte[] lazyKeyAlgorithmParameters; // 0x40
	private byte[] lazyPublicKey; // 0x48
	private DateTime lazyNotBefore; // 0x50
	private DateTime lazyNotAfter; // 0x58

	// Properties
	public string Issuer { get; }
	public string Subject { get; }
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }

	// Methods

	// RVA: 0x2EC66CC Offset: 0x2EC26CC VA: 0x2EC66CC Slot: 7
	public virtual void Reset() { }

	// RVA: 0x2EC6854 Offset: 0x2EC2854 VA: 0x2EC6854
	public void .ctor() { }

	// RVA: 0x2EC68C8 Offset: 0x2EC28C8 VA: 0x2EC68C8
	public void .ctor(byte[] data) { }

	// RVA: 0x2EC6A28 Offset: 0x2EC2A28 VA: 0x2EC6A28
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x2EC6AE8 Offset: 0x2EC2AE8 VA: 0x2EC6AE8
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x2EC6C7C Offset: 0x2EC2C7C VA: 0x2EC6C7C
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EC6CB8 Offset: 0x2EC2CB8 VA: 0x2EC6CB8 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EC6CF0 Offset: 0x2EC2CF0 VA: 0x2EC6CF0 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2EC6D28 Offset: 0x2EC2D28 VA: 0x2EC6D28
	public string get_Issuer() { }

	// RVA: 0x2EC6D94 Offset: 0x2EC2D94 VA: 0x2EC6D94
	public string get_Subject() { }

	// RVA: 0x2EC6DF8 Offset: 0x2EC2DF8 VA: 0x2EC6DF8 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EC6E08 Offset: 0x2EC2E08 VA: 0x2EC6E08 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2EC6E1C Offset: 0x2EC2E1C VA: 0x2EC6E1C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2EC6EB0 Offset: 0x2EC2EB0 VA: 0x2EC6EB0 Slot: 9
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x2EC7008 Offset: 0x2EC3008 VA: 0x2EC7008 Slot: 10
	public virtual byte[] GetCertHash() { }

	// RVA: 0x2EC7088 Offset: 0x2EC3088 VA: 0x2EC7088 Slot: 11
	public virtual string GetCertHashString() { }

	// RVA: 0x2EC702C Offset: 0x2EC302C VA: 0x2EC702C
	private byte[] GetRawCertHash() { }

	// RVA: 0x2EC70AC Offset: 0x2EC30AC VA: 0x2EC70AC Slot: 12
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x2EC70E0 Offset: 0x2EC30E0 VA: 0x2EC70E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EC7150 Offset: 0x2EC3150 VA: 0x2EC7150 Slot: 13
	public virtual string GetKeyAlgorithm() { }

	// RVA: 0x2EC71B8 Offset: 0x2EC31B8 VA: 0x2EC71B8 Slot: 14
	public virtual byte[] GetKeyAlgorithmParameters() { }

	// RVA: 0x2EC7224 Offset: 0x2EC3224 VA: 0x2EC7224 Slot: 15
	public virtual byte[] GetPublicKey() { }

	// RVA: 0x2EC7290 Offset: 0x2EC3290 VA: 0x2EC7290 Slot: 16
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x2EC72F8 Offset: 0x2EC32F8 VA: 0x2EC72F8 Slot: 17
	public virtual string GetSerialNumberString() { }

	// RVA: 0x2EC6FA8 Offset: 0x2EC2FA8 VA: 0x2EC6FA8
	private byte[] GetRawSerialNumber() { }

	// RVA: 0x2EC731C Offset: 0x2EC331C VA: 0x2EC731C Slot: 3
	public override string ToString() { }

	// RVA: 0x2EC7330 Offset: 0x2EC3330 VA: 0x2EC7330 Slot: 18
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x2EC7848 Offset: 0x2EC3848 VA: 0x2EC7848
	internal DateTime GetNotAfter() { }

	// RVA: 0x2EC7664 Offset: 0x2EC3664 VA: 0x2EC7664
	internal DateTime GetNotBefore() { }

	// RVA: 0x2EC7700 Offset: 0x2EC3700 VA: 0x2EC7700
	protected static string FormatDate(DateTime date) { }

	// RVA: 0x2EC78E4 Offset: 0x2EC38E4 VA: 0x2EC78E4
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x2EC791C Offset: 0x2EC391C VA: 0x2EC791C
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x2EC7924 Offset: 0x2EC3924 VA: 0x2EC7924
	internal bool get_IsValid() { }

	// RVA: 0x2EC6D8C Offset: 0x2EC2D8C VA: 0x2EC6D8C
	internal void ThrowIfInvalid() { }
}
