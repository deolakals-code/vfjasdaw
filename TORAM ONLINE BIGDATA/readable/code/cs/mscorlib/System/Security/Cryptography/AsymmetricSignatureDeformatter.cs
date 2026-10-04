// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 10102
{
	// Methods

	// RVA: 0x2EAD774 Offset: 0x2EA9774 VA: 0x2EAD774
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetKey(AsymmetricAlgorithm key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetHashAlgorithm(string strName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
}
