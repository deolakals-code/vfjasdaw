// Assembly: mscorlib.dll
// Namespace: System.Security
[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable // TypeDefIndex: 10072
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x2EA4110 Offset: 0x2EA0110 VA: 0x2EA4110
	public void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x2EA42D0 Offset: 0x2EA02D0 VA: 0x2EA42D0
	public void .ctor(char* value, int length) { }

	// RVA: 0x2EA4414 Offset: 0x2EA0414 VA: 0x2EA4414
	public int get_Length() { }

	// RVA: 0x2EA4474 Offset: 0x2EA0474 VA: 0x2EA4474 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EA4410 Offset: 0x2EA0410 VA: 0x2EA4410
	private void Encrypt() { }

	// RVA: 0x2EA44C4 Offset: 0x2EA04C4 VA: 0x2EA44C4
	private void Decrypt() { }

	// RVA: 0x2EA4134 Offset: 0x2EA0134 VA: 0x2EA4134
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x2EA44C8 Offset: 0x2EA04C8 VA: 0x2EA44C8
	internal byte[] GetBuffer() { }
}
