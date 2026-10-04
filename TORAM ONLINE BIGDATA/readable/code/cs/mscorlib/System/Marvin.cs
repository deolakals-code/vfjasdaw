// Assembly: mscorlib.dll
// Namespace: System
internal static class Marvin // TypeDefIndex: 9627
{
	// Fields
	[CompilerGenerated]
	private static readonly ulong <DefaultSeed>k__BackingField; // 0x0

	// Properties
	public static ulong DefaultSeed { get; }

	// Methods

	// RVA: 0x2FE5E38 Offset: 0x2FE1E38 VA: 0x2FE5E38
	public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed) { }

	// RVA: 0x2FE5EE4 Offset: 0x2FE1EE4 VA: 0x2FE5EE4
	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	// RVA: 0x2FE62D4 Offset: 0x2FE22D4 VA: 0x2FE62D4
	private static void Block(ref uint rp0, ref uint rp1) { }

	// RVA: 0x2FE635C Offset: 0x2FE235C VA: 0x2FE635C
	private static uint _rotl(uint value, int shift) { }

	[CompilerGenerated]
	// RVA: 0x2FE6368 Offset: 0x2FE2368 VA: 0x2FE6368
	public static ulong get_DefaultSeed() { }

	// RVA: 0x2FE63C0 Offset: 0x2FE23C0 VA: 0x2FE63C0
	private static ulong GenerateSeed() { }

	// RVA: 0x2FE63CC Offset: 0x2FE23CC VA: 0x2FE63CC
	private static void .cctor() { }
}
