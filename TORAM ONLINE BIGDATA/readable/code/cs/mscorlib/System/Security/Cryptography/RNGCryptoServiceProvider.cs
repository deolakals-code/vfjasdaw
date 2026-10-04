// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 10165
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x2EC49AC Offset: 0x2EC09AC VA: 0x2EC49AC
	private static void .cctor() { }

	// RVA: 0x2EBDAE8 Offset: 0x2EB9AE8 VA: 0x2EBDAE8
	public void .ctor() { }

	// RVA: 0x2EC4A44 Offset: 0x2EC0A44 VA: 0x2EC4A44
	private void Check() { }

	// RVA: 0x2EC4A3C Offset: 0x2EC0A3C VA: 0x2EC4A3C
	private static bool RngOpen() { }

	// RVA: 0x2EC4A40 Offset: 0x2EC0A40 VA: 0x2EC4A40
	private static IntPtr RngInitialize(byte* seed, IntPtr seed_length) { }

	// RVA: 0x2EC4ABC Offset: 0x2EC0ABC VA: 0x2EC4ABC
	private static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length) { }

	// RVA: 0x2EC4AC0 Offset: 0x2EC0AC0 VA: 0x2EC4AC0
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x2EC4AC4 Offset: 0x2EC0AC4 VA: 0x2EC4AC4 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x2EC4CDC Offset: 0x2EC0CDC VA: 0x2EC4CDC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EC4DCC Offset: 0x2EC0DCC VA: 0x2EC4DCC Slot: 5
	protected override void Dispose(bool disposing) { }
}
