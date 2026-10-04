// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo // TypeDefIndex: 16906
{
	// Fields
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2E57C08 Offset: 0x2E53C08 VA: 0x2E57C08
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	// RVA: 0x2E57C10 Offset: 0x2E53C10 VA: 0x2E57C10
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	// RVA: 0x2E57C18 Offset: 0x2E53C18 VA: 0x2E57C18
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x2E57C20 Offset: 0x2E53C20 VA: 0x2E57C20
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGenerated]
	// RVA: 0x2E57C28 Offset: 0x2E53C28 VA: 0x2E57C28
	public void set_PeerDomainName(string value) { }

	// RVA: 0x2E57C30 Offset: 0x2E53C30 VA: 0x2E57C30 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E57CEC Offset: 0x2E53CEC VA: 0x2E57CEC
	public void .ctor() { }
}
