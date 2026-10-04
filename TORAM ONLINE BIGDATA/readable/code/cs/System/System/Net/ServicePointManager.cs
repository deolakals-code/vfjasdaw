// Assembly: System.dll
// Namespace: System.Net
public class ServicePointManager // TypeDefIndex: 14501
{
	// Fields
	private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }

	// Methods

	// RVA: 0x3515D58 Offset: 0x3511D58 VA: 0x3515D58
	private static void .cctor() { }

	// RVA: 0x3515E18 Offset: 0x3511E18 VA: 0x3515E18
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x3515E70 Offset: 0x3511E70 VA: 0x3515E70
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x3515EC8 Offset: 0x3511EC8 VA: 0x3515EC8
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x3515F20 Offset: 0x3511F20 VA: 0x3515F20
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x3515F78 Offset: 0x3511F78 VA: 0x3515F78
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x3515FD0 Offset: 0x3511FD0 VA: 0x3515FD0
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x3516058 Offset: 0x3512058 VA: 0x3516058
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x3516718 Offset: 0x3512718 VA: 0x3516718
	internal static void RemoveServicePoint(ServicePoint sp) { }
}
