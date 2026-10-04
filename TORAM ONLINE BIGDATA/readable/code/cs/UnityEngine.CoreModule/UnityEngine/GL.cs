// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetGfxDevice()", 0)]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Camera/CameraUtil.h")]
public sealed class GL // TypeDefIndex: 16241
{
	// Methods

	[NativeName("ImmediateVertex")]
	// RVA: 0x37D49E4 Offset: 0x37D09E4 VA: 0x37D49E4
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x37D4A34 Offset: 0x37D0A34 VA: 0x37D4A34
	public static void Vertex(Vector3 v) { }

	[NativeName("ImmediateTexCoordAll")]
	// RVA: 0x37D4A84 Offset: 0x37D0A84 VA: 0x37D4A84
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x37D4AD4 Offset: 0x37D0AD4 VA: 0x37D4AD4
	public static void TexCoord(Vector3 v) { }

	[NativeName("ImmediateColor")]
	// RVA: 0x37D4B24 Offset: 0x37D0B24 VA: 0x37D4B24
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x37D4B7C Offset: 0x37D0B7C VA: 0x37D4B7C
	public static void Color(Color c) { }

	[NativeName("SetWorldMatrix")]
	// RVA: 0x37D4BD4 Offset: 0x37D0BD4 VA: 0x37D4BD4
	public static void MultMatrix(Matrix4x4 m) { }

	[FreeFunction("GLPushMatrixScript")]
	// RVA: 0x37D4C4C Offset: 0x37D0C4C VA: 0x37D4C4C
	public static void PushMatrix() { }

	[FreeFunction("GLPopMatrixScript")]
	// RVA: 0x37D4C74 Offset: 0x37D0C74 VA: 0x37D4C74
	public static void PopMatrix() { }

	[FreeFunction("GLBegin", ThrowsException = True)]
	// RVA: 0x37D4C9C Offset: 0x37D0C9C VA: 0x37D4C9C
	public static void Begin(int mode) { }

	[FreeFunction("GLEnd")]
	// RVA: 0x37D4CD8 Offset: 0x37D0CD8 VA: 0x37D4CD8
	public static void End() { }

	// RVA: 0x37D4C10 Offset: 0x37D0C10 VA: 0x37D4C10
	private static void MultMatrix_Injected(ref Matrix4x4 m) { }
}
