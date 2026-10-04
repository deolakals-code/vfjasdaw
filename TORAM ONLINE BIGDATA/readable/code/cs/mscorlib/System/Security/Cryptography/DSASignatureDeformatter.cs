// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 10115
{
	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x2EAF580 Offset: 0x2EAB580 VA: 0x2EAF580
	public void .ctor() { }

	// RVA: 0x2EAF608 Offset: 0x2EAB608 VA: 0x2EAF608
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x2EAF700 Offset: 0x2EAB700 VA: 0x2EAF700 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x2EAF7F0 Offset: 0x2EAB7F0 VA: 0x2EAF7F0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x2EAF8B8 Offset: 0x2EAB8B8 VA: 0x2EAF8B8 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}
