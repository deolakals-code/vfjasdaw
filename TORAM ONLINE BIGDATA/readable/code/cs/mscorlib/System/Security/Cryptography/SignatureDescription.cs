// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SignatureDescription // TypeDefIndex: 10149
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x2EBBC5C Offset: 0x2EB7C5C VA: 0x2EBBC5C
	public void .ctor() { }

	// RVA: 0x2EBBC64 Offset: 0x2EB7C64 VA: 0x2EBBC64
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x2EBBC6C Offset: 0x2EB7C6C VA: 0x2EBBC6C
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x2EBBC74 Offset: 0x2EB7C74 VA: 0x2EBBC74
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x2EBBC7C Offset: 0x2EB7C7C VA: 0x2EBBC7C
	public void set_DeformatterAlgorithm(string value) { }
}
