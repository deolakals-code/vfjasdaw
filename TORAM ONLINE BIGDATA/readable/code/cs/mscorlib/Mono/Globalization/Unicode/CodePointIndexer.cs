// Assembly: mscorlib.dll
// Namespace: Mono.Globalization.Unicode
internal class CodePointIndexer // TypeDefIndex: 9455
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x2E6869C Offset: 0x2E6469C VA: 0x2E6869C
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x2E68820 Offset: 0x2E64820 VA: 0x2E68820
	public int ToIndex(int cp) { }
}
