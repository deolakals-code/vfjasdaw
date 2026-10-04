// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 10129
{
	// Methods

	// RVA: 0x2EB1A28 Offset: 0x2EADA28 VA: 0x2EB1A28
	protected void .ctor() { }

	// RVA: 0x2EB1A30 Offset: 0x2EADA30 VA: 0x2EB1A30
	public static RandomNumberGenerator Create() { }

	// RVA: 0x2EB1A84 Offset: 0x2EADA84 VA: 0x2EB1A84 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EB1AF0 Offset: 0x2EADAF0 VA: 0x2EB1AF0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);
}
