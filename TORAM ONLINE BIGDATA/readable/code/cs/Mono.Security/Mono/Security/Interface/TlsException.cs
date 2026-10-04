// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public sealed class TlsException : Exception // TypeDefIndex: 16913
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0x2E58308 Offset: 0x2E54308 VA: 0x2E58308
	public void .ctor(Alert alert, string message) { }

	// RVA: 0x2E58384 Offset: 0x2E54384 VA: 0x2E58384
	public void .ctor(AlertDescription description, string message) { }
}
