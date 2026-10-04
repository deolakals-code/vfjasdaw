// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
public class GUI // TypeDefIndex: 17024
{
	// Fields
	private static int s_HotTextField; // 0x0
	private static readonly int s_BoxHash; // 0x4
	private static readonly int s_ButonHash; // 0x8
	private static readonly int s_RepeatButtonHash; // 0xC
	private static readonly int s_ToggleHash; // 0x10
	private static readonly int s_ButtonGridHash; // 0x14
	private static readonly int s_SliderHash; // 0x18
	private static readonly int s_BeginGroupHash; // 0x1C
	private static readonly int s_ScrollviewHash; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x28
	private static GUISkin s_Skin; // 0x30
	internal static Rect s_ToolTipRect; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static GenericStack <scrollViewStates>k__BackingField; // 0x48

	// Properties
	public static bool changed { set; }
	internal static DateTime nextScrollStepTime { set; }
	public static GUISkin skin { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x380456C Offset: 0x380056C VA: 0x380456C
	public static void set_changed(bool value) { }

	// RVA: 0x38045A8 Offset: 0x38005A8 VA: 0x38045A8
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x38045E4 Offset: 0x38005E4 VA: 0x38045E4
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x3804620 Offset: 0x3800620 VA: 0x3804620
	internal static void ReleaseMouseControl() { }

	// RVA: 0x3804648 Offset: 0x3800648 VA: 0x3804648
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x38048E0 Offset: 0x38008E0 VA: 0x38048E0
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x380493C Offset: 0x380093C VA: 0x380493C
	public static void set_skin(GUISkin value) { }

	// RVA: 0x3804B48 Offset: 0x3800B48 VA: 0x3804B48
	public static GUISkin get_skin() { }

	// RVA: 0x3804A78 Offset: 0x3800A78 VA: 0x3804A78
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x3804D48 Offset: 0x3800D48 VA: 0x3804D48
	public static void Label(Rect position, string text) { }

	// RVA: 0x3804ED4 Offset: 0x3800ED4 VA: 0x3804ED4
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x380525C Offset: 0x380125C VA: 0x380525C
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x38053E8 Offset: 0x38013E8 VA: 0x38053E8
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x38055BC Offset: 0x38015BC VA: 0x38055BC
	internal static string PasswordFieldGetStrToShow(string password, char maskChar) { }

	// RVA: 0x3805700 Offset: 0x3801700 VA: 0x3805700
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style) { }

	// RVA: 0x38057B8 Offset: 0x38017B8 VA: 0x38057B8
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText) { }

	// RVA: 0x3805880 Offset: 0x3801880 VA: 0x3805880
	internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar) { }

	// RVA: 0x38061C8 Offset: 0x38021C8 VA: 0x38061C8
	private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor) { }

	// RVA: 0x3806664 Offset: 0x3802664 VA: 0x3806664
	private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor) { }

	// RVA: 0x3805E2C Offset: 0x3801E2C VA: 0x3805E2C
	private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor) { }

	// RVA: 0x38079D0 Offset: 0x38039D0 VA: 0x38079D0
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x3804F90 Offset: 0x3800F90 VA: 0x3804F90
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x38054AC Offset: 0x38014AC VA: 0x38054AC
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	[CompilerGenerated]
	// RVA: 0x38080F8 Offset: 0x38040F8 VA: 0x38080F8
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCode]
	// RVA: 0x3808150 Offset: 0x3804150 VA: 0x3808150
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }
}
