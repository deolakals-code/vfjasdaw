// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
public class TouchScreenKeyboard // TypeDefIndex: 16398
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Properties
	public static bool isSupported { get; }
	internal static bool disableInPlaceEditing { get; }
	public static bool isInPlaceEditingAllowed { get; }
	internal static bool isRequiredToForceOpen { get; }
	public string text { get; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }

	// Methods

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	// RVA: 0x37F1CBC Offset: 0x37EDCBC VA: 0x37F1CBC
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x37F1CF8 Offset: 0x37EDCF8 VA: 0x37F1CF8
	private void Destroy() { }

	// RVA: 0x37F1D9C Offset: 0x37EDD9C VA: 0x37F1D9C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x37F1E30 Offset: 0x37EDE30 VA: 0x37F1E30
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	// RVA: 0x37F1F8C Offset: 0x37EDF8C VA: 0x37F1F8C
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x37F1FE0 Offset: 0x37EDFE0 VA: 0x37F1FE0
	public static bool get_isSupported() { }

	[CompilerGenerated]
	// RVA: 0x37F208C Offset: 0x37EE08C VA: 0x37F208C
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x37F20D4 Offset: 0x37EE0D4 VA: 0x37F20D4
	public static bool get_isInPlaceEditingAllowed() { }

	[FreeFunction("TouchScreenKeyboard_IsInplaceEditingAllowed")]
	// RVA: 0x37F2140 Offset: 0x37EE140 VA: 0x37F2140
	private static bool IsInPlaceEditingAllowed() { }

	// RVA: 0x37F2168 Offset: 0x37EE168 VA: 0x37F2168
	internal static bool get_isRequiredToForceOpen() { }

	[FreeFunction("TouchScreenKeyboard_IsRequiredToForceOpen")]
	// RVA: 0x37F2190 Offset: 0x37EE190 VA: 0x37F2190
	private static bool IsRequiredToForceOpen() { }

	// RVA: 0x37F21B8 Offset: 0x37EE1B8 VA: 0x37F21B8
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocs]
	// RVA: 0x37F2270 Offset: 0x37EE270 VA: 0x37F2270
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeName("GetText")]
	// RVA: 0x37F22FC Offset: 0x37EE2FC VA: 0x37F22FC
	public string get_text() { }

	[NativeName("IsActive")]
	// RVA: 0x37F2338 Offset: 0x37EE338 VA: 0x37F2338
	public bool get_active() { }

	[NativeName("SetActive")]
	// RVA: 0x37F2374 Offset: 0x37EE374 VA: 0x37F2374
	public void set_active(bool value) { }

	[NativeName("GetKeyboardStatus")]
	// RVA: 0x37F23B8 Offset: 0x37EE3B8 VA: 0x37F23B8
	public TouchScreenKeyboard.Status get_status() { }
}
