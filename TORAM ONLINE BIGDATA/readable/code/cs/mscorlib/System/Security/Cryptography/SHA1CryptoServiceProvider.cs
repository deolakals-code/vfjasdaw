// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 10169
{
	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x2EC0134 Offset: 0x2EBC134 VA: 0x2EC0134
	public void .ctor() { }

	// RVA: 0x2EC63AC Offset: 0x2EC23AC VA: 0x2EC63AC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EC644C Offset: 0x2EC244C VA: 0x2EC644C Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EC6458 Offset: 0x2EC2458 VA: 0x2EC6458 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EC647C Offset: 0x2EC247C VA: 0x2EC647C Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EC649C Offset: 0x2EC249C VA: 0x2EC649C Slot: 18
	public override void Initialize() { }
}
