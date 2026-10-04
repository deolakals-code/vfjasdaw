// Assembly: System.Xml.dll
// Namespace: System.Xml
internal struct XmlCharType // TypeDefIndex: 13441
{
	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0x33D52F0 Offset: 0x33D12F0 VA: 0x33D52F0
	private static object get_StaticLock() { }

	// RVA: 0x33D5384 Offset: 0x33D1384 VA: 0x33D5384
	private static void InitInstance() { }

	// RVA: 0x33D55E4 Offset: 0x33D15E4 VA: 0x33D55E4
	private static void SetProperties(byte[] chProps, string ranges, byte value) { }

	// RVA: 0x33D56A8 Offset: 0x33D16A8 VA: 0x33D56A8
	private void .ctor(byte[] charProperties) { }

	// RVA: 0x33D4BA4 Offset: 0x33D0BA4 VA: 0x33D4BA4
	public static XmlCharType get_Instance() { }

	// RVA: 0x33D56B0 Offset: 0x33D16B0 VA: 0x33D56B0
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x33D4B70 Offset: 0x33D0B70 VA: 0x33D4B70
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x33D4C1C Offset: 0x33D0C1C VA: 0x33D4C1C
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x33D56E4 Offset: 0x33D16E4 VA: 0x33D56E4
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x33D5708 Offset: 0x33D1708 VA: 0x33D5708
	public bool IsCharData(char ch) { }

	// RVA: 0x33D573C Offset: 0x33D173C VA: 0x33D573C
	public bool IsPubidChar(char ch) { }

	// RVA: 0x33D57B8 Offset: 0x33D17B8 VA: 0x33D57B8
	internal bool IsTextChar(char ch) { }

	// RVA: 0x33D57EC Offset: 0x33D17EC VA: 0x33D57EC
	public bool IsLetter(char ch) { }

	// RVA: 0x33D5820 Offset: 0x33D1820 VA: 0x33D5820
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x33D5854 Offset: 0x33D1854 VA: 0x33D5854
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x33D5878 Offset: 0x33D1878 VA: 0x33D5878
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0x33D589C Offset: 0x33D189C VA: 0x33D589C
	public static bool IsDigit(char ch) { }

	// RVA: 0x33D58C4 Offset: 0x33D18C4 VA: 0x33D58C4
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x33D58D4 Offset: 0x33D18D4 VA: 0x33D58D4
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x33D58E4 Offset: 0x33D18E4 VA: 0x33D58E4
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x33D58F4 Offset: 0x33D18F4 VA: 0x33D58F4
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x33D590C Offset: 0x33D190C VA: 0x33D590C
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x33D5940 Offset: 0x33D1940 VA: 0x33D5940
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x33D5958 Offset: 0x33D1958 VA: 0x33D5958
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x33D59E0 Offset: 0x33D19E0 VA: 0x33D59E0
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x33D5AB8 Offset: 0x33D1AB8 VA: 0x33D5AB8
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x33D5B60 Offset: 0x33D1B60 VA: 0x33D5B60
	internal int IsPublicId(string str) { }

	// RVA: 0x33D58B0 Offset: 0x33D18B0 VA: 0x33D58B0
	private static bool InRange(int value, int start, int end) { }
}
