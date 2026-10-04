// Assembly: mscorlib.dll
// Namespace: System
[NonVersionable]
[Serializable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable // TypeDefIndex: 9605
{
	// Fields
	public static readonly Guid Empty; // 0x0
	private int _a; // 0x0
	private short _b; // 0x4
	private short _c; // 0x6
	private byte _d; // 0x8
	private byte _e; // 0x9
	private byte _f; // 0xA
	private byte _g; // 0xB
	private byte _h; // 0xC
	private byte _i; // 0xD
	private byte _j; // 0xE
	private byte _k; // 0xF

	// Methods

	// RVA: 0x2FDE5D0 Offset: 0x2FDA5D0 VA: 0x2FDE5D0
	public static Guid NewGuid() { }

	// RVA: 0x2FDE61C Offset: 0x2FDA61C VA: 0x2FDE61C
	public void .ctor(byte[] b) { }

	// RVA: 0x2FDE6B0 Offset: 0x2FDA6B0 VA: 0x2FDE6B0
	public void .ctor(ReadOnlySpan<byte> b) { }

	// RVA: 0x2FDE7D4 Offset: 0x2FDA7D4 VA: 0x2FDE7D4
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x2FDE814 Offset: 0x2FDA814 VA: 0x2FDE814
	public void .ctor(string g) { }

	// RVA: 0x2FDECB0 Offset: 0x2FDACB0 VA: 0x2FDECB0
	public static Guid Parse(string input) { }

	// RVA: 0x2FDED44 Offset: 0x2FDAD44 VA: 0x2FDED44
	public static Guid Parse(ReadOnlySpan<char> input) { }

	// RVA: 0x2FDEDA8 Offset: 0x2FDADA8 VA: 0x2FDEDA8
	public static bool TryParseExact(string input, string format, out Guid result) { }

	// RVA: 0x2FDEE6C Offset: 0x2FDAE6C VA: 0x2FDEE6C
	public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result) { }

	// RVA: 0x2FDE8F8 Offset: 0x2FDA8F8 VA: 0x2FDE8F8
	private static bool TryParseGuid(ReadOnlySpan<char> guidString, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x2FDF2C0 Offset: 0x2FDB2C0 VA: 0x2FDF2C0
	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x2FDF8FC Offset: 0x2FDB8FC VA: 0x2FDF8FC
	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x2FDEFD8 Offset: 0x2FDAFD8 VA: 0x2FDEFD8
	private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x2FDFFD8 Offset: 0x2FDBFD8 VA: 0x2FDFFD8
	private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x2FE0370 Offset: 0x2FDC370 VA: 0x2FE0370
	private static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x2FDFFAC Offset: 0x2FDBFAC VA: 0x2FDFFAC
	private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x2FE0178 Offset: 0x2FDC178 VA: 0x2FE0178
	private static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x2FE001C Offset: 0x2FDC01C VA: 0x2FE001C
	private static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x2FDFC9C Offset: 0x2FDBC9C VA: 0x2FDFC9C
	private static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str) { }

	// RVA: 0x2FDFED4 Offset: 0x2FDBED4 VA: 0x2FDFED4
	private static bool IsHexPrefix(ReadOnlySpan<char> str, int i) { }

	// RVA: 0x2FE03B4 Offset: 0x2FDC3B4 VA: 0x2FE03B4
	private void WriteByteHelper(Span<byte> destination) { }

	// RVA: 0x2FE04C4 Offset: 0x2FDC4C4 VA: 0x2FE04C4
	public byte[] ToByteArray() { }

	// RVA: 0x2FE0558 Offset: 0x2FDC558 VA: 0x2FE0558 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FE0798 Offset: 0x2FDC798 VA: 0x2FE0798 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FE07B0 Offset: 0x2FDC7B0 VA: 0x2FE07B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2FE0858 Offset: 0x2FDC858 VA: 0x2FE0858 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x2FE089C Offset: 0x2FDC89C VA: 0x2FE089C
	private int GetResult(uint me, uint them) { }

	// RVA: 0x2FE08AC Offset: 0x2FDC8AC VA: 0x2FE08AC Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x2FE0A34 Offset: 0x2FDCA34 VA: 0x2FE0A34 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x2FE0B18 Offset: 0x2FDCB18 VA: 0x2FE0B18
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x2FE0B54 Offset: 0x2FDCB54 VA: 0x2FE0B54
	public string ToString(string format) { }

	// RVA: 0x2FE0B58 Offset: 0x2FDCB58 VA: 0x2FE0B58
	private static char HexToChar(int a) { }

	// RVA: 0x2FE0B74 Offset: 0x2FDCB74 VA: 0x2FE0B74
	private static int HexsToChars(char* guidChars, int a, int b) { }

	// RVA: 0x2FE0BF0 Offset: 0x2FDCBF0 VA: 0x2FE0BF0
	private static int HexsToCharsHexOutput(char* guidChars, int a, int b) { }

	// RVA: 0x2FE05A0 Offset: 0x2FDC5A0 VA: 0x2FE05A0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FE0C8C Offset: 0x2FDCC8C VA: 0x2FE0C8C
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format) { }

	// RVA: 0x2FE10C8 Offset: 0x2FDD0C8 VA: 0x2FE10C8 Slot: 8
	private bool System.ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }
}
