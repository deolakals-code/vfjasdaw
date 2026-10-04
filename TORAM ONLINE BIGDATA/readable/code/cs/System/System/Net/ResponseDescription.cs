// Assembly: System.dll
// Namespace: System.Net
internal class ResponseDescription // TypeDefIndex: 14366
{
	// Fields
	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Properties
	internal bool PositiveIntermediate { get; }
	internal bool PositiveCompletion { get; }
	internal bool TransientFailure { get; }
	internal bool PermanentFailure { get; }
	internal bool InvalidStatusCode { get; }

	// Methods

	// RVA: 0x34E0BA4 Offset: 0x34DCBA4 VA: 0x34E0BA4
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x34E0BB8 Offset: 0x34DCBB8 VA: 0x34E0BB8
	internal bool get_PositiveCompletion() { }

	// RVA: 0x34E0BCC Offset: 0x34DCBCC VA: 0x34E0BCC
	internal bool get_TransientFailure() { }

	// RVA: 0x34E0BE0 Offset: 0x34DCBE0 VA: 0x34E0BE0
	internal bool get_PermanentFailure() { }

	// RVA: 0x34E0BF4 Offset: 0x34DCBF4 VA: 0x34E0BF4
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x34E0C08 Offset: 0x34DCC08 VA: 0x34E0C08
	public void .ctor() { }
}
