// Assembly: mscorlib.dll
// Namespace: Mono
internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 9446
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x2E661CC Offset: 0x2E621CC VA: 0x2E661CC
	private static IntPtr StringToUtf8_icall(ref string str) { }

	// RVA: 0x2E661D0 Offset: 0x2E621D0 VA: 0x2E661D0
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x2E661E8 Offset: 0x2E621E8 VA: 0x2E661E8
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x2E65FEC Offset: 0x2E61FEC VA: 0x2E65FEC
	public void .ctor(string str) { }

	// RVA: 0x2E661EC Offset: 0x2E621EC VA: 0x2E661EC
	public IntPtr get_Value() { }

	// RVA: 0x2E66234 Offset: 0x2E62234 VA: 0x2E66234 Slot: 4
	public void Dispose() { }
}
