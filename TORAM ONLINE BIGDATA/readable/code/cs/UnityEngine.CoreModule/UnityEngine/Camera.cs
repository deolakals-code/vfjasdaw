// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/Shader.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public sealed class Camera : Behaviour // TypeDefIndex: 16215
{
	// Fields
	public const float kMinAperture = 0.7;
	public const float kMaxAperture = 32;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativeProperty("Near")]
	public float nearClipPlane { get; set; }
	[NativeProperty("Far")]
	public float farClipPlane { get; set; }
	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView { get; set; }
	public bool allowHDR { set; }
	public bool allowDynamicResolution { set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public float depth { get; set; }
	public float aspect { get; }
	public int cullingMask { get; set; }
	public int eventMask { get; set; }
	public bool useOcclusionCulling { set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	[NativeProperty("NormalizedViewportRect")]
	public Rect rect { get; set; }
	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect { get; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public RenderTexture targetTexture { get; }
	public int targetDisplay { get; }
	public Matrix4x4 worldToCameraMatrix { get; }
	public Matrix4x4 projectionMatrix { get; }
	public static Camera main { get; }
	public static Camera current { get; }
	public static int allCamerasCount { get; }

	// Methods

	// RVA: 0x37CE190 Offset: 0x37CA190 VA: 0x37CE190
	public void .ctor() { }

	// RVA: 0x37CE198 Offset: 0x37CA198 VA: 0x37CE198
	public float get_nearClipPlane() { }

	// RVA: 0x37CE1D4 Offset: 0x37CA1D4 VA: 0x37CE1D4
	public void set_nearClipPlane(float value) { }

	// RVA: 0x37CE220 Offset: 0x37CA220 VA: 0x37CE220
	public float get_farClipPlane() { }

	// RVA: 0x37CE25C Offset: 0x37CA25C VA: 0x37CE25C
	public void set_farClipPlane(float value) { }

	// RVA: 0x37CE2A8 Offset: 0x37CA2A8 VA: 0x37CE2A8
	public float get_fieldOfView() { }

	// RVA: 0x37CE2E4 Offset: 0x37CA2E4 VA: 0x37CE2E4
	public void set_fieldOfView(float value) { }

	// RVA: 0x37CE330 Offset: 0x37CA330 VA: 0x37CE330
	public void set_allowHDR(bool value) { }

	// RVA: 0x37CE374 Offset: 0x37CA374 VA: 0x37CE374
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x37CE3B8 Offset: 0x37CA3B8 VA: 0x37CE3B8
	public float get_orthographicSize() { }

	// RVA: 0x37CE3F4 Offset: 0x37CA3F4 VA: 0x37CE3F4
	public void set_orthographicSize(float value) { }

	// RVA: 0x37CE440 Offset: 0x37CA440 VA: 0x37CE440
	public bool get_orthographic() { }

	// RVA: 0x37CE47C Offset: 0x37CA47C VA: 0x37CE47C
	public void set_orthographic(bool value) { }

	// RVA: 0x37CE4C0 Offset: 0x37CA4C0 VA: 0x37CE4C0
	public float get_depth() { }

	// RVA: 0x37CE4FC Offset: 0x37CA4FC VA: 0x37CE4FC
	public void set_depth(float value) { }

	// RVA: 0x37CE548 Offset: 0x37CA548 VA: 0x37CE548
	public float get_aspect() { }

	// RVA: 0x37CE584 Offset: 0x37CA584 VA: 0x37CE584
	public int get_cullingMask() { }

	// RVA: 0x37CE5C0 Offset: 0x37CA5C0 VA: 0x37CE5C0
	public void set_cullingMask(int value) { }

	// RVA: 0x37CE604 Offset: 0x37CA604 VA: 0x37CE604
	public int get_eventMask() { }

	// RVA: 0x37CE640 Offset: 0x37CA640 VA: 0x37CE640
	public void set_eventMask(int value) { }

	// RVA: 0x37CE684 Offset: 0x37CA684 VA: 0x37CE684
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x37CE6C8 Offset: 0x37CA6C8 VA: 0x37CE6C8
	public Color get_backgroundColor() { }

	// RVA: 0x37CE764 Offset: 0x37CA764 VA: 0x37CE764
	public void set_backgroundColor(Color value) { }

	// RVA: 0x37CE7FC Offset: 0x37CA7FC VA: 0x37CE7FC
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x37CE838 Offset: 0x37CA838 VA: 0x37CE838
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x37CE87C Offset: 0x37CA87C VA: 0x37CE87C
	public Rect get_rect() { }

	// RVA: 0x37CE918 Offset: 0x37CA918 VA: 0x37CE918
	public void set_rect(Rect value) { }

	// RVA: 0x37CE9B0 Offset: 0x37CA9B0 VA: 0x37CE9B0
	public Rect get_pixelRect() { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	// RVA: 0x37CEA4C Offset: 0x37CAA4C VA: 0x37CEA4C
	public int get_pixelWidth() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	// RVA: 0x37CEA88 Offset: 0x37CAA88 VA: 0x37CEA88
	public int get_pixelHeight() { }

	// RVA: 0x37CEAC4 Offset: 0x37CAAC4 VA: 0x37CEAC4
	public RenderTexture get_targetTexture() { }

	// RVA: 0x37CEB00 Offset: 0x37CAB00 VA: 0x37CEB00
	public int get_targetDisplay() { }

	// RVA: 0x37CEB3C Offset: 0x37CAB3C VA: 0x37CEB3C
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x37CEBEC Offset: 0x37CABEC VA: 0x37CEBEC
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x37CEC9C Offset: 0x37CAC9C VA: 0x37CEC9C
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x37CED68 Offset: 0x37CAD68 VA: 0x37CED68
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x37CEE34 Offset: 0x37CAE34 VA: 0x37CEE34
	public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x37CEF00 Offset: 0x37CAF00 VA: 0x37CEF00
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x37CEFCC Offset: 0x37CAFCC VA: 0x37CEFCC
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x37CEFD4 Offset: 0x37CAFD4 VA: 0x37CEFD4
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x37CEFDC Offset: 0x37CAFDC VA: 0x37CEFDC
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x37CEFE4 Offset: 0x37CAFE4 VA: 0x37CEFE4
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x37CEFEC Offset: 0x37CAFEC VA: 0x37CEFEC
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x37CF0A8 Offset: 0x37CB0A8 VA: 0x37CF0A8
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x37CF17C Offset: 0x37CB17C VA: 0x37CF17C
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x37CF1B4 Offset: 0x37CB1B4 VA: 0x37CF1B4
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunction("FindMainCamera")]
	// RVA: 0x37CF1F8 Offset: 0x37CB1F8 VA: 0x37CF1F8
	public static Camera get_main() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	// RVA: 0x37CF220 Offset: 0x37CB220 VA: 0x37CF220
	public static Camera get_current() { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	// RVA: 0x37CF248 Offset: 0x37CB248 VA: 0x37CF248
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	// RVA: 0x37CF270 Offset: 0x37CB270 VA: 0x37CF270
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x37CF2AC Offset: 0x37CB2AC VA: 0x37CF2AC
	public static int get_allCamerasCount() { }

	// RVA: 0x37CF2D4 Offset: 0x37CB2D4 VA: 0x37CF2D4
	public static int GetAllCameras(Camera[] cameras) { }

	[RequiredByNativeCode]
	// RVA: 0x37CF3AC Offset: 0x37CB3AC VA: 0x37CF3AC
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x37CF418 Offset: 0x37CB418 VA: 0x37CF418
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x37CF484 Offset: 0x37CB484 VA: 0x37CF484
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x37CE720 Offset: 0x37CA720 VA: 0x37CE720
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x37CE7B8 Offset: 0x37CA7B8 VA: 0x37CE7B8
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x37CE8D4 Offset: 0x37CA8D4 VA: 0x37CE8D4
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x37CE96C Offset: 0x37CA96C VA: 0x37CE96C
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x37CEA08 Offset: 0x37CAA08 VA: 0x37CEA08
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x37CEBA8 Offset: 0x37CABA8 VA: 0x37CEBA8
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x37CEC58 Offset: 0x37CAC58 VA: 0x37CEC58
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x37CED0C Offset: 0x37CAD0C VA: 0x37CED0C
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x37CEDD8 Offset: 0x37CADD8 VA: 0x37CEDD8
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x37CEEA4 Offset: 0x37CAEA4 VA: 0x37CEEA4
	private void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x37CEF70 Offset: 0x37CAF70 VA: 0x37CEF70
	private void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x37CF054 Offset: 0x37CB054 VA: 0x37CF054
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x37CF120 Offset: 0x37CB120 VA: 0x37CF120
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }
}
