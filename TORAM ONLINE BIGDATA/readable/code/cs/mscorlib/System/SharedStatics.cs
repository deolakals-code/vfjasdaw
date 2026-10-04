// Assembly: mscorlib.dll
// Namespace: System
internal sealed class SharedStatics // TypeDefIndex: 9763
{
	// Fields
	private static readonly SharedStatics _sharedStatics; // 0x0
	private Tokenizer.StringMaker _maker; // 0x10

	// Methods

	// RVA: 0x3027DC8 Offset: 0x3023DC8 VA: 0x3027DC8
	private void .ctor() { }

	// RVA: 0x3027DD0 Offset: 0x3023DD0 VA: 0x3027DD0
	public static Tokenizer.StringMaker GetSharedStringMaker() { }

	// RVA: 0x3027FAC Offset: 0x3023FAC VA: 0x3027FAC
	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) { }

	// RVA: 0x3028110 Offset: 0x3024110 VA: 0x3028110
	private static void .cctor() { }
}
