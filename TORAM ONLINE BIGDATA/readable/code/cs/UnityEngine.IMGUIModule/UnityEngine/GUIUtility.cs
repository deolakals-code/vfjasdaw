// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
public class GUIUtility // TypeDefIndex: 17041
{
	// Fields
	internal static int s_ControlCount; // 0x0
	internal static int s_SkinMode; // 0x4
	internal static int s_OriginalID; // 0x8
	internal static Action takeCapture; // 0x10
	internal static Action releaseCapture; // 0x18
	internal static Func<int, IntPtr, bool> processEvent; // 0x20
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	internal static Action guiChanged; // 0x30
	internal static Action<EventType, KeyCode> beforeEventProcessed; // 0x38
	private static Event m_Event; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <guiIsExiting>k__BackingField; // 0x48
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x50

	// Properties
	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, 1)]
	internal static float pixelsPerPoint { get; }
	[NativeProperty("GetGUIState().m_OnGUIDepth", True, 1)]
	internal static int guiDepth { get; }
	[StaticAccessor("GetInputManager()", 0)]
	internal static bool textFieldInput { set; }
	public static string systemCopyBuffer { get; set; }
	[StaticAccessor("InputBindings", 2)]
	internal static string compositionString { get; }
	[StaticAccessor("InputBindings", 2)]
	internal static Vector2 compositionCursorPos { set; }
	internal static bool guiIsExiting { set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; set; }

	// Methods

	// RVA: 0x380A0D0 Offset: 0x38060D0 VA: 0x380A0D0
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x380EC94 Offset: 0x380AC94 VA: 0x380EC94
	internal static int get_guiDepth() { }

	// RVA: 0x3807994 Offset: 0x3803994 VA: 0x3807994
	internal static void set_textFieldInput(bool value) { }

	[FreeFunction("GetCopyBuffer")]
	// RVA: 0x380ECBC Offset: 0x380ACBC VA: 0x380ECBC
	public static string get_systemCopyBuffer() { }

	[FreeFunction("SetCopyBuffer")]
	// RVA: 0x380ECE4 Offset: 0x380ACE4 VA: 0x380ECE4
	public static void set_systemCopyBuffer(string value) { }

	[FreeFunction("GetGUIState().GetControlID")]
	// RVA: 0x380ED20 Offset: 0x380AD20 VA: 0x380ED20
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x3805340 Offset: 0x3801340 VA: 0x3805340
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x3807528 Offset: 0x3803528 VA: 0x3807528
	internal static string get_compositionString() { }

	// RVA: 0x380EE10 Offset: 0x380AE10 VA: 0x380EE10
	internal static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x380EEC4 Offset: 0x380AEC4 VA: 0x380EEC4
	private static int Internal_GetHotControl() { }

	// RVA: 0x380EEEC Offset: 0x380AEEC VA: 0x380EEEC
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x380EF14 Offset: 0x380AF14 VA: 0x380EF14
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x380EF50 Offset: 0x380AF50 VA: 0x380EF50
	private static void Internal_SetKeyboardControl(int value) { }

	// RVA: 0x380EF8C Offset: 0x380AF8C VA: 0x380EF8C
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x380EFC8 Offset: 0x380AFC8 VA: 0x380EFC8
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCode]
	// RVA: 0x380EFF0 Offset: 0x380AFF0 VA: 0x380EFF0
	private static void MarkGUIChanged() { }

	// RVA: 0x38098AC Offset: 0x38058AC VA: 0x38098AC
	public static int GetControlID(FocusType focus) { }

	// RVA: 0x380F064 Offset: 0x380B064 VA: 0x380F064
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x3805C4C Offset: 0x3801C4C VA: 0x3805C4C
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGenerated]
	// RVA: 0x380F100 Offset: 0x380B100 VA: 0x380F100
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x38071F4 Offset: 0x38031F4 VA: 0x38071F4
	public static int get_hotControl() { }

	// RVA: 0x3806EC8 Offset: 0x3802EC8 VA: 0x3806EC8
	public static void set_hotControl(int value) { }

	[RequiredByNativeCode]
	// RVA: 0x380F160 Offset: 0x380B160 VA: 0x380F160
	internal static void TakeCapture() { }

	[RequiredByNativeCode]
	// RVA: 0x380F1D4 Offset: 0x380B1D4 VA: 0x380F1D4
	internal static void RemoveCapture() { }

	// RVA: 0x3806F3C Offset: 0x3802F3C VA: 0x3806F3C
	public static int get_keyboardControl() { }

	// RVA: 0x3806FA4 Offset: 0x3802FA4 VA: 0x3806FA4
	public static void set_keyboardControl(int value) { }

	// RVA: 0x380E298 Offset: 0x380A298 VA: 0x380E298
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x3804BC8 Offset: 0x3800BC8 VA: 0x3804BC8
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCode]
	// RVA: 0x380F248 Offset: 0x380B248 VA: 0x380F248
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x380F408 Offset: 0x380B408 VA: 0x380F408
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCode]
	// RVA: 0x380F5E0 Offset: 0x380B5E0 VA: 0x380F5E0
	internal static void DestroyGUI(int instanceID) { }

	[RequiredByNativeCode]
	// RVA: 0x380F638 Offset: 0x380B638 VA: 0x380F638
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	// RVA: 0x380F864 Offset: 0x380B864 VA: 0x380F864
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	// RVA: 0x380F92C Offset: 0x380B92C VA: 0x380F92C
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x380F4B4 Offset: 0x380B4B4 VA: 0x380F4B4
	internal static void ResetGlobalState() { }

	// RVA: 0x380F9CC Offset: 0x380B9CC VA: 0x380F9CC
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x380F8D8 Offset: 0x380B8D8 VA: 0x380F8D8
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x38049B8 Offset: 0x38009B8 VA: 0x38049B8
	internal static void CheckOnGUI() { }

	// RVA: 0x380FA50 Offset: 0x380BA50 VA: 0x380FA50
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x380FA9C Offset: 0x380BA9C VA: 0x380FA9C
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x3807F18 Offset: 0x3803F18 VA: 0x3807F18
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x380FB5C Offset: 0x380BB5C VA: 0x380FB5C
	private static void .cctor() { }

	// RVA: 0x380EDBC Offset: 0x380ADBC VA: 0x380EDBC
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }

	// RVA: 0x380EE88 Offset: 0x380AE88 VA: 0x380EE88
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }
}
