// Assembly: System.dll
// Namespace: System.Security.Authentication
[Flags]
public enum SslProtocols // TypeDefIndex: 14109
{
	// Fields
	public int value__; // 0x0
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls11 = 768;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Tls13 = 12288;
	public const SslProtocols Default = 240;
}
