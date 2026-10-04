// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
internal sealed class InflateManager // TypeDefIndex: 17168
{
	// Fields
	private InflateManager.InflateManagerMode mode; // 0x10
	internal ZlibCodec _codec; // 0x18
	internal int method; // 0x20
	internal uint computedCheck; // 0x24
	internal uint expectedCheck; // 0x28
	internal int marker; // 0x2C
	private bool _handleRfc1950HeaderBytes; // 0x30
	internal int wbits; // 0x34
	internal InflateBlocks blocks; // 0x38
	private static readonly byte[] mark; // 0x0

	// Properties
	internal bool HandleRfc1950HeaderBytes { get; }

	// Methods

	// RVA: 0x2E3D6B8 Offset: 0x2E396B8 VA: 0x2E3D6B8
	internal bool get_HandleRfc1950HeaderBytes() { }

	// RVA: 0x2E3D6C0 Offset: 0x2E396C0 VA: 0x2E3D6C0
	public void .ctor(bool expectRfc1950HeaderBytes) { }

	// RVA: 0x2E3D6F0 Offset: 0x2E396F0 VA: 0x2E3D6F0
	internal int Reset() { }

	// RVA: 0x2E3D744 Offset: 0x2E39744 VA: 0x2E3D744
	internal int End() { }

	// RVA: 0x2E3D774 Offset: 0x2E39774 VA: 0x2E3D774
	internal int Initialize(ZlibCodec codec, int w) { }

	// RVA: 0x2E3D8B0 Offset: 0x2E398B0 VA: 0x2E3D8B0
	internal int Inflate(FlushType flush) { }

	// RVA: 0x2E3DFE0 Offset: 0x2E39FE0 VA: 0x2E3DFE0
	private static void .cctor() { }
}
