// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 10139
{
	// Methods

	// RVA: 0x2EB72A4 Offset: 0x2EB32A4 VA: 0x2EB72A4
	protected void .ctor() { }

	// RVA: 0x2EB72AC Offset: 0x2EB32AC VA: 0x2EB72AC
	public static RSA Create() { }

	// RVA: 0x2EB7344 Offset: 0x2EB3344 VA: 0x2EB7344 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x2EB739C Offset: 0x2EB339C VA: 0x2EB739C Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x2EB7944 Offset: 0x2EB3944 VA: 0x2EB7944 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);
}
