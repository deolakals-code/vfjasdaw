// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class CspParameters // TypeDefIndex: 10110
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x2EAD9D4 Offset: 0x2EA99D4 VA: 0x2EAD9D4
	public CspProviderFlags get_Flags() { }

	// RVA: 0x2EAD9DC Offset: 0x2EA99DC VA: 0x2EAD9DC
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x2EADAC0 Offset: 0x2EA9AC0 VA: 0x2EADAC0
	public void .ctor() { }

	// RVA: 0x2EADADC Offset: 0x2EA9ADC VA: 0x2EADADC
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x2EADAD4 Offset: 0x2EA9AD4 VA: 0x2EADAD4
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x2EADAEC Offset: 0x2EA9AEC VA: 0x2EADAEC
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}
