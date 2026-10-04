// Assembly: mscorlib.dll
// Namespace: System
internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 9813
{
	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x303709C Offset: 0x303309C VA: 0x303709C
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x30371C8 Offset: 0x30331C8 VA: 0x30371C8
	private static string SearchTerminfo(string term) { }

	// RVA: 0x303733C Offset: 0x303333C VA: 0x303733C
	private void WriteConsole(string str) { }

	// RVA: 0x302E8CC Offset: 0x302A8CC VA: 0x302E8CC
	public void .ctor(string term) { }

	// RVA: 0x30376CC Offset: 0x30336CC VA: 0x30376CC Slot: 5
	public bool get_Initialized() { }

	// RVA: 0x30376D4 Offset: 0x30336D4 VA: 0x30376D4 Slot: 6
	public void Init() { }

	// RVA: 0x30382FC Offset: 0x30342FC VA: 0x30382FC
	private void IncrementX() { }

	// RVA: 0x30383C0 Offset: 0x30343C0 VA: 0x30383C0
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x30386E4 Offset: 0x30346E4 VA: 0x30386E4
	public void WriteSpecialKey(char c) { }

	// RVA: 0x3038890 Offset: 0x3034890 VA: 0x3038890
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x3038914 Offset: 0x3034914 VA: 0x3038914
	public bool IsSpecialKey(char c) { }

	// RVA: 0x303806C Offset: 0x303406C VA: 0x303806C
	private void GetCursorPosition() { }

	// RVA: 0x3038A34 Offset: 0x3034A34 VA: 0x3038A34
	private void CheckWindowDimensions() { }

	// RVA: 0x3038394 Offset: 0x3034394 VA: 0x3038394 Slot: 7
	public int get_WindowHeight() { }

	// RVA: 0x3038368 Offset: 0x3034368 VA: 0x3038368 Slot: 8
	public int get_WindowWidth() { }

	// RVA: 0x303893C Offset: 0x303493C VA: 0x303893C
	private void AddToBuffer(int b) { }

	// RVA: 0x3038B54 Offset: 0x3034B54 VA: 0x3038B54
	private void AdjustBuffer() { }

	// RVA: 0x303870C Offset: 0x303470C VA: 0x303870C
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x3038B68 Offset: 0x3034B68 VA: 0x3038B68
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x3039338 Offset: 0x3035338 VA: 0x3039338
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x3039670 Offset: 0x3035670 VA: 0x3039670
	private bool InputPending() { }

	// RVA: 0x30396A4 Offset: 0x30356A4 VA: 0x30396A4
	private void QueueEcho(char c) { }

	// RVA: 0x3039790 Offset: 0x3035790 VA: 0x3039790
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x30397E4 Offset: 0x30357E4 VA: 0x30397E4
	private void EchoFlush() { }

	// RVA: 0x3039818 Offset: 0x3035818 VA: 0x3039818
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x3039B38 Offset: 0x3035B38 VA: 0x3039B38 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x3039B9C Offset: 0x3035B9C VA: 0x3039B9C Slot: 9
	public string ReadLine() { }

	// RVA: 0x3039D80 Offset: 0x3035D80 VA: 0x3039D80
	public string ReadToEnd() { }

	// RVA: 0x3039BA4 Offset: 0x3035BA4 VA: 0x3039BA4
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x30384D4 Offset: 0x30344D4 VA: 0x30384D4 Slot: 10
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x3039F18 Offset: 0x3035F18 VA: 0x3039F18
	private void CreateKeyMap() { }

	// RVA: 0x30394F8 Offset: 0x30354F8 VA: 0x30394F8
	private void InitKeys() { }

	// RVA: 0x303BE44 Offset: 0x3037E44 VA: 0x303BE44
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x303C044 Offset: 0x3038044 VA: 0x303C044
	private static void .cctor() { }
}
