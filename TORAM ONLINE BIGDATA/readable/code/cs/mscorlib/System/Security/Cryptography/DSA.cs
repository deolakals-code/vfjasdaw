// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 10114
{
	// Methods

	// RVA: 0x2EAE8F4 Offset: 0x2EAA8F4 VA: 0x2EAE8F4
	protected void .ctor() { }

	// RVA: 0x2EAE8FC Offset: 0x2EAA8FC VA: 0x2EAE8FC
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x2EAE950 Offset: 0x2EAA950 VA: 0x2EAE950 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x2EAF020 Offset: 0x2EAB020 VA: 0x2EAF020 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);
}
