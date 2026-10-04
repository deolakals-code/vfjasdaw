// Assembly: Ionic.Zlib.CF.dll
// Namespace: 
internal class DeflateManager.Config // TypeDefIndex: 17160
{
	// Fields
	internal int GoodLength; // 0x10
	internal int MaxLazy; // 0x14
	internal int NiceLength; // 0x18
	internal int MaxChainLength; // 0x1C
	internal DeflateFlavor Flavor; // 0x20
	private static readonly DeflateManager.Config[] Table; // 0x0

	// Methods

	// RVA: 0x2E3967C Offset: 0x2E3567C VA: 0x2E3967C
	private void .ctor(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor) { }

	// RVA: 0x2E34DB0 Offset: 0x2E30DB0 VA: 0x2E34DB0
	public static DeflateManager.Config Lookup(CompressionLevel level) { }

	// RVA: 0x2E396CC Offset: 0x2E356CC VA: 0x2E396CC
	private static void .cctor() { }
}
