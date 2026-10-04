// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public class TouchScreenKeyboard // TypeDefIndex: 17086
{
	// Fields
	private static AndroidJavaClass dialogIme; // 0x0
	[CompilerGenerated]
	private static bool <hideInput>k__BackingField; // 0x8
	[CompilerGenerated]
	private static int <maxLength>k__BackingField; // 0xC
	[CompilerGenerated]
	private static int <maxLines>k__BackingField; // 0x10
	private AndroidJavaObject imeObject; // 0x10
	private bool isDone; // 0x18

	// Properties
	public static Rect area { get; }
	public static bool hideInput { get; set; }
	public static int maxLength { get; set; }
	public static int maxLines { get; set; }
	public static bool isSupported { get; }
	public static bool visible { get; }
	public bool active { get; set; }
	public bool done { get; }
	public string text { get; set; }
	public bool wasCanceled { get; }

	// Methods

	// RVA: 0x16FF508 Offset: 0x16FB508 VA: 0x16FF508
	public static Rect get_area() { }

	[CompilerGenerated]
	// RVA: 0x16FF51C Offset: 0x16FB51C VA: 0x16FF51C
	public static bool get_hideInput() { }

	[CompilerGenerated]
	// RVA: 0x16FF574 Offset: 0x16FB574 VA: 0x16FF574
	public static void set_hideInput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x16FF5D4 Offset: 0x16FB5D4 VA: 0x16FF5D4
	public static int get_maxLength() { }

	[CompilerGenerated]
	// RVA: 0x16FF62C Offset: 0x16FB62C VA: 0x16FF62C
	public static void set_maxLength(int value) { }

	[CompilerGenerated]
	// RVA: 0x16FF688 Offset: 0x16FB688 VA: 0x16FF688
	public static int get_maxLines() { }

	[CompilerGenerated]
	// RVA: 0x16FF6E0 Offset: 0x16FB6E0 VA: 0x16FF6E0
	public static void set_maxLines(int value) { }

	// RVA: 0x16FF73C Offset: 0x16FB73C VA: 0x16FF73C
	public static bool get_isSupported() { }

	// RVA: 0x16FF744 Offset: 0x16FB744 VA: 0x16FF744
	public static bool get_visible() { }

	// RVA: 0x16FF74C Offset: 0x16FB74C VA: 0x16FF74C
	private static void .cctor() { }

	// RVA: 0x16FF7FC Offset: 0x16FB7FC VA: 0x16FF7FC
	public static TouchScreenKeyboard Open(string text) { }

	// RVA: 0x16FFE0C Offset: 0x16FBE0C VA: 0x16FFE0C
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType) { }

	// RVA: 0x16FFEA4 Offset: 0x16FBEA4 VA: 0x16FFEA4
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection) { }

	// RVA: 0x16FFF48 Offset: 0x16FBF48 VA: 0x16FFF48
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline) { }

	// RVA: 0x16FFFF0 Offset: 0x16FBFF0 VA: 0x16FFFF0
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	// RVA: 0x17000A4 Offset: 0x16FC0A4 VA: 0x17000A4
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert) { }

	// RVA: 0x1700158 Offset: 0x16FC158 VA: 0x1700158
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder) { }

	// RVA: 0x17001FC Offset: 0x16FC1FC VA: 0x17001FC
	public bool get_active() { }

	// RVA: 0x17002D8 Offset: 0x16FC2D8 VA: 0x17002D8
	public void set_active(bool value) { }

	// RVA: 0x17002DC Offset: 0x16FC2DC VA: 0x17002DC
	public bool get_done() { }

	// RVA: 0x17003B8 Offset: 0x16FC3B8 VA: 0x17003B8
	public string get_text() { }

	// RVA: 0x17004A8 Offset: 0x16FC4A8 VA: 0x17004A8
	public void set_text(string value) { }

	// RVA: 0x1700588 Offset: 0x16FC588 VA: 0x1700588
	public bool get_wasCanceled() { }

	// RVA: 0x16FF890 Offset: 0x16FB890 VA: 0x16FF890
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder) { }

	// RVA: 0x1700664 Offset: 0x16FC664 VA: 0x1700664 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1700718 Offset: 0x16FC718 VA: 0x1700718
	public void Dispose() { }

	// RVA: 0x17007DC Offset: 0x16FC7DC VA: 0x17007DC
	public void Close() { }
}
