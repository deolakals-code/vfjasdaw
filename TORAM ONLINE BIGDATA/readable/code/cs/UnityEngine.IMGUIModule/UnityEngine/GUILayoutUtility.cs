// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility // TypeDefIndex: 17032
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18

	// Methods

	// RVA: 0x380993C Offset: 0x380593C VA: 0x380993C
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x3809A10 Offset: 0x3805A10 VA: 0x3809A10
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x3809AE0 Offset: 0x3805AE0 VA: 0x3809AE0
	internal static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	// RVA: 0x3808448 Offset: 0x3804448 VA: 0x3808448
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x3809C88 Offset: 0x3805C88 VA: 0x3809C88
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x3809D5C Offset: 0x3805D5C VA: 0x3809D5C
	internal static void Begin(int instanceID) { }

	// RVA: 0x38086FC Offset: 0x38046FC VA: 0x38086FC
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3808A6C Offset: 0x3804A6C VA: 0x3808A6C
	internal static void Layout() { }

	// RVA: 0x380A42C Offset: 0x380642C VA: 0x380A42C
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x380A0F8 Offset: 0x38060F8 VA: 0x380A0F8
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x380A2B4 Offset: 0x38062B4 VA: 0x380A2B4
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x380940C Offset: 0x380540C VA: 0x380940C
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x380A644 Offset: 0x3806644 VA: 0x380A644
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x380AFC0 Offset: 0x3806FC0 VA: 0x380AFC0
	private static void .cctor() { }

	// RVA: 0x38099CC Offset: 0x38059CC VA: 0x38099CC
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x3809A9C Offset: 0x3805A9C VA: 0x3809A9C
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }
}
