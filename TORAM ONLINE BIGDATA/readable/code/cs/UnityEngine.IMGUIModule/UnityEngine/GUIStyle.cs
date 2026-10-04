// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 17038
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativeProperty("Name", False, 0)]
	internal string rawName { get; set; }
	[NativeProperty("Font", False, 0)]
	public Font font { get; }
	[NativeProperty("m_ImagePosition", False, 1)]
	public ImagePosition imagePosition { get; }
	[NativeProperty("m_WordWrap", False, 1)]
	public bool wordWrap { get; }
	[NativeProperty("m_ContentOffset", False, 1)]
	public Vector2 contentOffset { get; set; }
	[NativeProperty("m_FixedWidth", False, 1)]
	public float fixedWidth { get; }
	[NativeProperty("m_FixedHeight", False, 1)]
	public float fixedHeight { get; }
	[NativeProperty("m_StretchWidth", False, 1)]
	public bool stretchWidth { get; }
	[NativeProperty("m_StretchHeight", False, 1)]
	public bool stretchHeight { get; set; }
	[NativeProperty("m_ClipOffset", False, 1)]
	internal Vector2 Internal_clipOffset { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x380D06C Offset: 0x380906C VA: 0x380D06C
	internal string get_rawName() { }

	// RVA: 0x380D0A8 Offset: 0x38090A8 VA: 0x380D0A8
	internal void set_rawName(string value) { }

	// RVA: 0x3807470 Offset: 0x3803470 VA: 0x3807470
	public Font get_font() { }

	// RVA: 0x380D0EC Offset: 0x38090EC VA: 0x380D0EC
	public ImagePosition get_imagePosition() { }

	// RVA: 0x380D128 Offset: 0x3809128 VA: 0x380D128
	public bool get_wordWrap() { }

	// RVA: 0x380D164 Offset: 0x3809164 VA: 0x380D164
	public Vector2 get_contentOffset() { }

	// RVA: 0x380D1F4 Offset: 0x38091F4 VA: 0x380D1F4
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x380D280 Offset: 0x3809280 VA: 0x380D280
	public float get_fixedWidth() { }

	// RVA: 0x380D2BC Offset: 0x38092BC VA: 0x380D2BC
	public float get_fixedHeight() { }

	// RVA: 0x380D2F8 Offset: 0x38092F8 VA: 0x380D2F8
	public bool get_stretchWidth() { }

	// RVA: 0x380D334 Offset: 0x3809334 VA: 0x380D334
	public bool get_stretchHeight() { }

	// RVA: 0x380C6B0 Offset: 0x38086B0 VA: 0x380C6B0
	public void set_stretchHeight(bool value) { }

	// RVA: 0x380D370 Offset: 0x3809370 VA: 0x380D370
	internal void set_Internal_clipOffset(Vector2 value) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x380D3FC Offset: 0x38093FC VA: 0x380D3FC
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x380D438 Offset: 0x3809438 VA: 0x380D438
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x380D474 Offset: 0x3809474 VA: 0x380D474
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	// RVA: 0x380D4B8 Offset: 0x38094B8 VA: 0x380D4B8
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
	// RVA: 0x380D4FC Offset: 0x38094FC VA: 0x380D4FC
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	// RVA: 0x380D538 Offset: 0x3809538 VA: 0x380D538
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	// RVA: 0x380D648 Offset: 0x3809648 VA: 0x380D648
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = True)]
	// RVA: 0x380D728 Offset: 0x3809728 VA: 0x380D728
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = True)]
	// RVA: 0x380D80C Offset: 0x380980C VA: 0x380D80C
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = True)]
	// RVA: 0x380D998 Offset: 0x3809998 VA: 0x380D998
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = True)]
	// RVA: 0x380DA78 Offset: 0x3809A78 VA: 0x380DA78
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = True)]
	// RVA: 0x380DB38 Offset: 0x3809B38 VA: 0x380DB38
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = True)]
	// RVA: 0x380DC18 Offset: 0x3809C18 VA: 0x380DC18
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	// RVA: 0x380DCC8 Offset: 0x3809CC8 VA: 0x380DCC8
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	// RVA: 0x380DD88 Offset: 0x3809D88 VA: 0x380DD88
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	// RVA: 0x380DDDC Offset: 0x3809DDC VA: 0x380DDDC
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	// RVA: 0x380806C Offset: 0x380406C VA: 0x380806C
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	// RVA: 0x3808030 Offset: 0x3804030 VA: 0x3808030
	internal static bool IsTooltipActive(string tooltip) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
	// RVA: 0x380DED0 Offset: 0x3809ED0 VA: 0x380DED0
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	// RVA: 0x380B43C Offset: 0x380743C VA: 0x380B43C
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x380B888 Offset: 0x3807888 VA: 0x380B888
	public void .ctor() { }

	// RVA: 0x380DEF8 Offset: 0x3809EF8 VA: 0x380DEF8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x380C64C Offset: 0x380864C VA: 0x380C64C
	public string get_name() { }

	// RVA: 0x380B910 Offset: 0x3807910 VA: 0x380B910
	public void set_name(string value) { }

	// RVA: 0x380C6F4 Offset: 0x38086F4 VA: 0x380C6F4
	public GUIStyleState get_normal() { }

	// RVA: 0x380E008 Offset: 0x380A008 VA: 0x380E008
	public RectOffset get_margin() { }

	// RVA: 0x380E0C0 Offset: 0x380A0C0 VA: 0x380E0C0
	public RectOffset get_padding() { }

	// RVA: 0x380E178 Offset: 0x380A178 VA: 0x380E178
	public float get_lineHeight() { }

	// RVA: 0x3807FCC Offset: 0x3803FCC VA: 0x3807FCC
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x3807018 Offset: 0x3803018 VA: 0x3807018
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x3807E48 Offset: 0x3803E48 VA: 0x3807E48
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x380E274 Offset: 0x380A274 VA: 0x380E274
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x380E358 Offset: 0x380A358 VA: 0x380E358
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	// RVA: 0x380E570 Offset: 0x380A570 VA: 0x380E570
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	// RVA: 0x380E7F4 Offset: 0x380A7F4 VA: 0x380E7F4
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	// RVA: 0x380E958 Offset: 0x380A958 VA: 0x380E958
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	// RVA: 0x38089DC Offset: 0x38049DC VA: 0x38089DC
	public static GUIStyle get_none() { }

	// RVA: 0x380E960 Offset: 0x380A960 VA: 0x380E960
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x380E964 Offset: 0x380A964 VA: 0x380E964
	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	// RVA: 0x380E968 Offset: 0x380A968 VA: 0x380E968
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x380ABE8 Offset: 0x3806BE8 VA: 0x380ABE8
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x380E96C Offset: 0x380A96C VA: 0x380E96C
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x380A9B0 Offset: 0x38069B0 VA: 0x380A9B0
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x380E9C0 Offset: 0x380A9C0 VA: 0x380E9C0
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x380E9E8 Offset: 0x380A9E8 VA: 0x380E9E8 Slot: 3
	public override string ToString() { }

	// RVA: 0x380EAAC Offset: 0x380AAAC VA: 0x380EAAC
	private static void .cctor() { }

	// RVA: 0x380D1B0 Offset: 0x38091B0 VA: 0x380D1B0
	private void get_contentOffset_Injected(out Vector2 ret) { }

	// RVA: 0x380D23C Offset: 0x380923C VA: 0x380D23C
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x380D3B8 Offset: 0x38093B8 VA: 0x380D3B8
	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	// RVA: 0x380D5C4 Offset: 0x38095C4 VA: 0x380D5C4
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x380D6BC Offset: 0x38096BC VA: 0x380D6BC
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x380D7A0 Offset: 0x38097A0 VA: 0x380D7A0
	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	// RVA: 0x380D8DC Offset: 0x38098DC VA: 0x380D8DC
	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	// RVA: 0x380DA0C Offset: 0x3809A0C VA: 0x380DA0C
	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	// RVA: 0x380DADC Offset: 0x3809ADC VA: 0x380DADC
	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	// RVA: 0x380DBAC Offset: 0x3809BAC VA: 0x380DBAC
	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	// RVA: 0x380DC74 Offset: 0x3809C74 VA: 0x380DC74
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x380DD2C Offset: 0x3809D2C VA: 0x380DD2C
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x380DE38 Offset: 0x3809E38 VA: 0x380DE38
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x380DE8C Offset: 0x3809E8C VA: 0x380DE8C
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }
}
