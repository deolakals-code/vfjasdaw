// Assembly: System.dll
// Namespace: System.Net.Security
[Flags]
public enum SslPolicyErrors // TypeDefIndex: 14599
{
	// Fields
	public int value__; // 0x0
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}
