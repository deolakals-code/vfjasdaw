// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
public sealed class Shader : Object // TypeDefIndex: 16250
{
	// Methods

	// RVA: 0x37D5B48 Offset: 0x37D1B48 VA: 0x37D5B48
	public static Shader Find(string name) { }

	[FreeFunction("ShaderScripting::TagToID")]
	// RVA: 0x37D5BB4 Offset: 0x37D1BB4 VA: 0x37D5BB4
	internal static int TagToID(string name) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	// RVA: 0x37D5BF0 Offset: 0x37D1BF0 VA: 0x37D5BF0
	public static int PropertyToID(string name) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	// RVA: 0x37D5C2C Offset: 0x37D1C2C VA: 0x37D5C2C
	private static void SetGlobalFloatImpl(int name, float value) { }

	// RVA: 0x37D5C78 Offset: 0x37D1C78 VA: 0x37D5C78
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x37D5CF0 Offset: 0x37D1CF0 VA: 0x37D5CF0
	private void .ctor() { }
}
