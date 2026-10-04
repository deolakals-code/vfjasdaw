// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIState.h")]
[NativeHeader("Modules/IMGUI/GUIClip.h")]
internal sealed class GUIClip // TypeDefIndex: 17025
{
	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	// RVA: 0x3807FE8 Offset: 0x3803FE8 VA: 0x3807FE8
	internal static Rect get_visibleRect() { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
	// RVA: 0x3808D78 Offset: 0x3804D78 VA: 0x3808D78
	private static Vector2 UnclipToWindow_Vector2(Vector2 pos) { }

	// RVA: 0x3808E08 Offset: 0x3804E08 VA: 0x3808E08
	public static Vector2 UnclipToWindow(Vector2 pos) { }

	// RVA: 0x3808D3C Offset: 0x3804D3C VA: 0x3808D3C
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x3808DC4 Offset: 0x3804DC4 VA: 0x3808DC4
	private static void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }
}
