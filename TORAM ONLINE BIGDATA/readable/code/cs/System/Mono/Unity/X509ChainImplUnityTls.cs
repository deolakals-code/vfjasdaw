// Assembly: System.dll
// Namespace: Mono.Unity
internal class X509ChainImplUnityTls : X509ChainImpl // TypeDefIndex: 13981
{
	// Fields
	private X509ChainElementCollection elements; // 0x10
	private UnityTls.unitytls_x509list* ownedList; // 0x18
	private UnityTls.unitytls_x509list_ref nativeCertificateChain; // 0x20
	private X509ChainPolicy policy; // 0x28
	private List<X509ChainStatus> chainStatusList; // 0x30
	private bool reverseOrder; // 0x38

	// Properties
	public override bool IsValid { get; }
	internal UnityTls.unitytls_x509list_ref NativeCertificateChain { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x319588C Offset: 0x319188C VA: 0x319588C
	internal void .ctor(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = False) { }

	// RVA: 0x3196CD8 Offset: 0x3192CD8 VA: 0x3196CD8
	internal void .ctor(UnityTls.unitytls_x509list* ownedList, UnityTls.unitytls_errorstate* errorState, bool reverseOrder = False) { }

	// RVA: 0x3196F9C Offset: 0x3192F9C VA: 0x3196F9C Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x3196FC4 Offset: 0x3192FC4 VA: 0x3196FC4
	internal UnityTls.unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0x3196FCC Offset: 0x3192FCC VA: 0x3196FCC Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x31972B8 Offset: 0x31932B8 VA: 0x31972B8 Slot: 9
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x31973D8 Offset: 0x31933D8 VA: 0x31973D8 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x31973E0 Offset: 0x31933E0 VA: 0x31973E0 Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x31973E8 Offset: 0x31933E8 VA: 0x31973E8 Slot: 10
	public override void Reset() { }

	// RVA: 0x3197470 Offset: 0x3193470 VA: 0x3197470 Slot: 11
	protected override void Dispose(bool disposing) { }
}
