// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
[Flags]
[Serializable]
public enum X509ChainStatusFlags // TypeDefIndex: 16883
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags UntrustedRoot = 32;
}
