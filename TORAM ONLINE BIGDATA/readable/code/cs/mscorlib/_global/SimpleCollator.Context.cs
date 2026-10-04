// Assembly: mscorlib.dll
// Namespace: 
internal struct SimpleCollator.Context // TypeDefIndex: 9464
{
	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x2E6C96C Offset: 0x2E6896C VA: 0x2E6C96C
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }
}
