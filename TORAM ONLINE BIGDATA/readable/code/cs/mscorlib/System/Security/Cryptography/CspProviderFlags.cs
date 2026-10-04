// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Flags]
[Serializable]
public enum CspProviderFlags // TypeDefIndex: 10109
{
	// Fields
	public int value__; // 0x0
	public const CspProviderFlags NoFlags = 0;
	public const CspProviderFlags UseMachineKeyStore = 1;
	public const CspProviderFlags UseDefaultKeyContainer = 2;
	public const CspProviderFlags UseNonExportableKey = 4;
	public const CspProviderFlags UseExistingKey = 8;
	public const CspProviderFlags UseArchivableKey = 16;
	public const CspProviderFlags UseUserProtectedKey = 32;
	public const CspProviderFlags NoPrompt = 64;
	public const CspProviderFlags CreateEphemeralKey = 128;
}
