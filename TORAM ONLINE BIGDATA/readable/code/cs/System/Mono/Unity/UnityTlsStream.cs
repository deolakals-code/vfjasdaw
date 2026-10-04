// Assembly: System.dll
// Namespace: Mono.Unity
internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 13980
{
	// Methods

	// RVA: 0x319630C Offset: 0x319230C VA: 0x319630C
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x3196F34 Offset: 0x3192F34 VA: 0x3196F34 Slot: 40
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }
}
