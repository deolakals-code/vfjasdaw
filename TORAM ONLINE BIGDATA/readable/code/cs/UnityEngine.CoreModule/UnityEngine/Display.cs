// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/DisplayManager.h")]
public class Display // TypeDefIndex: 16237
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Properties
	public int systemWidth { get; }
	public int systemHeight { get; }

	// Methods

	// RVA: 0x37D3890 Offset: 0x37CF890 VA: 0x37D3890
	internal void .ctor() { }

	// RVA: 0x37D38CC Offset: 0x37CF8CC VA: 0x37D38CC
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x37D38F4 Offset: 0x37CF8F4 VA: 0x37D38F4
	public int get_systemWidth() { }

	// RVA: 0x37D39DC Offset: 0x37CF9DC VA: 0x37D39DC
	public int get_systemHeight() { }

	// RVA: 0x37D3A70 Offset: 0x37CFA70 VA: 0x37D3A70
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	[RequiredByNativeCode]
	// RVA: 0x37D3B8C Offset: 0x37CFB8C VA: 0x37D3B8C
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCode]
	// RVA: 0x37D3D1C Offset: 0x37CFD1C VA: 0x37D3D1C
	internal static void FireDisplaysUpdated() { }

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	// RVA: 0x37D3988 Offset: 0x37CF988 VA: 0x37D3988
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	// RVA: 0x37D3B30 Offset: 0x37CFB30 VA: 0x37D3B30
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x37D3DB0 Offset: 0x37CFDB0 VA: 0x37D3DB0
	private static void .cctor() { }
}
