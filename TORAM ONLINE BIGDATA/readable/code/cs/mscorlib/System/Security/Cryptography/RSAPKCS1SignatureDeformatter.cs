// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 10166
{
	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x2EC0124 Offset: 0x2EBC124 VA: 0x2EC0124
	public void .ctor() { }

	// RVA: 0x2EC4DD8 Offset: 0x2EC0DD8 VA: 0x2EC4DD8
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x2EC4E0C Offset: 0x2EC0E0C VA: 0x2EC4E0C Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x2EC4E68 Offset: 0x2EC0E68 VA: 0x2EC4E68 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x2EC4F58 Offset: 0x2EC0F58 VA: 0x2EC4F58 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}
