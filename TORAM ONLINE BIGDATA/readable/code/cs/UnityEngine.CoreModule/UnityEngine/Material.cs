// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/Material.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public class Material : Object // TypeDefIndex: 16251
{
	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public Vector2 mainTextureOffset { get; set; }
	public Vector2 mainTextureScale { set; }
	public int renderQueue { get; set; }

	// Methods

	[FreeFunction("MaterialScripting::CreateWithShader")]
	// RVA: 0x37D5D48 Offset: 0x37D1D48 VA: 0x37D5D48
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	// RVA: 0x37D5D8C Offset: 0x37D1D8C VA: 0x37D5D8C
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	// RVA: 0x37D5DD0 Offset: 0x37D1DD0 VA: 0x37D5DD0
	private static void CreateWithString(Material self) { }

	// RVA: 0x37D5E0C Offset: 0x37D1E0C VA: 0x37D5E0C
	public void .ctor(Shader shader) { }

	[RequiredByNativeCode]
	// RVA: 0x37D5E9C Offset: 0x37D1E9C VA: 0x37D5E9C
	public void .ctor(Material source) { }

	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	[EditorBrowsable(1)]
	// RVA: 0x37D5F2C Offset: 0x37D1F2C VA: 0x37D5F2C
	public void .ctor(string contents) { }

	// RVA: 0x37D5FAC Offset: 0x37D1FAC VA: 0x37D5FAC
	public Shader get_shader() { }

	// RVA: 0x37D5FE8 Offset: 0x37D1FE8 VA: 0x37D5FE8
	public void set_shader(Shader value) { }

	// RVA: 0x37D602C Offset: 0x37D202C VA: 0x37D602C
	public Color get_color() { }

	// RVA: 0x37D614C Offset: 0x37D214C VA: 0x37D614C
	public void set_color(Color value) { }

	// RVA: 0x37D62A0 Offset: 0x37D22A0 VA: 0x37D62A0
	public Texture get_mainTexture() { }

	// RVA: 0x37D6404 Offset: 0x37D2404 VA: 0x37D6404
	public void set_mainTexture(Texture value) { }

	// RVA: 0x37D65A0 Offset: 0x37D25A0 VA: 0x37D65A0
	public Vector2 get_mainTextureOffset() { }

	// RVA: 0x37D66A8 Offset: 0x37D26A8 VA: 0x37D66A8
	public void set_mainTextureOffset(Vector2 value) { }

	// RVA: 0x37D67C0 Offset: 0x37D27C0 VA: 0x37D67C0
	public void set_mainTextureScale(Vector2 value) { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	// RVA: 0x37D60B8 Offset: 0x37D20B8 VA: 0x37D60B8
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeName("HasPropertyFromScript")]
	// RVA: 0x37D68D8 Offset: 0x37D28D8 VA: 0x37D68D8
	public bool HasProperty(int nameID) { }

	// RVA: 0x37D691C Offset: 0x37D291C VA: 0x37D691C
	public bool HasProperty(string name) { }

	[NativeName("GetActualRenderQueue")]
	// RVA: 0x37D698C Offset: 0x37D298C VA: 0x37D698C
	public int get_renderQueue() { }

	[NativeName("SetCustomRenderQueue")]
	// RVA: 0x37D69C8 Offset: 0x37D29C8 VA: 0x37D69C8
	public void set_renderQueue(int value) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	// RVA: 0x37D6A0C Offset: 0x37D2A0C VA: 0x37D6A0C
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	// RVA: 0x37D6A50 Offset: 0x37D2A50 VA: 0x37D6A50
	public void CopyPropertiesFromMaterial(Material mat) { }

	[NativeName("SetFloatFromScript")]
	// RVA: 0x37D6A94 Offset: 0x37D2A94 VA: 0x37D6A94
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetColorFromScript")]
	// RVA: 0x37D6AE8 Offset: 0x37D2AE8 VA: 0x37D6AE8
	private void SetColorImpl(int name, Color value) { }

	[NativeName("SetMatrixFromScript")]
	// RVA: 0x37D6B98 Offset: 0x37D2B98 VA: 0x37D6B98
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	// RVA: 0x37D6C40 Offset: 0x37D2C40 VA: 0x37D6C40
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("GetFloatFromScript")]
	// RVA: 0x37D6C94 Offset: 0x37D2C94 VA: 0x37D6C94
	private float GetFloatImpl(int name) { }

	[NativeName("GetColorFromScript")]
	// RVA: 0x37D6CD8 Offset: 0x37D2CD8 VA: 0x37D6CD8
	private Color GetColorImpl(int name) { }

	[NativeName("GetTextureFromScript")]
	// RVA: 0x37D6D8C Offset: 0x37D2D8C VA: 0x37D6D8C
	private Texture GetTextureImpl(int name) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	// RVA: 0x37D6DD0 Offset: 0x37D2DD0 VA: 0x37D6DD0
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[NativeName("SetTextureOffsetFromScript")]
	// RVA: 0x37D6E84 Offset: 0x37D2E84 VA: 0x37D6E84
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeName("SetTextureScaleFromScript")]
	// RVA: 0x37D6F30 Offset: 0x37D2F30 VA: 0x37D6F30
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x37D6FDC Offset: 0x37D2FDC VA: 0x37D6FDC
	public void SetInt(string name, int value) { }

	// RVA: 0x37D705C Offset: 0x37D305C VA: 0x37D705C
	public void SetFloat(string name, float value) { }

	// RVA: 0x37D70DC Offset: 0x37D30DC VA: 0x37D70DC
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x37D6224 Offset: 0x37D2224 VA: 0x37D6224
	public void SetColor(string name, Color value) { }

	// RVA: 0x37D6220 Offset: 0x37D2220 VA: 0x37D6220
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x37D7130 Offset: 0x37D3130 VA: 0x37D7130
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x37D71AC Offset: 0x37D31AC VA: 0x37D71AC
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x37D6520 Offset: 0x37D2520 VA: 0x37D6520
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x37D64CC Offset: 0x37D24CC VA: 0x37D64CC
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x37D7248 Offset: 0x37D3248 VA: 0x37D7248
	public float GetFloat(string name) { }

	// RVA: 0x37D6100 Offset: 0x37D2100 VA: 0x37D6100
	public Color GetColor(string name) { }

	// RVA: 0x37D60FC Offset: 0x37D20FC VA: 0x37D60FC
	public Color GetColor(int nameID) { }

	// RVA: 0x37D6394 Offset: 0x37D2394 VA: 0x37D6394
	public Texture GetTexture(string name) { }

	// RVA: 0x37D6350 Offset: 0x37D2350 VA: 0x37D6350
	public Texture GetTexture(int nameID) { }

	// RVA: 0x37D675C Offset: 0x37D275C VA: 0x37D675C
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x37D6758 Offset: 0x37D2758 VA: 0x37D6758
	public void SetTextureOffset(int nameID, Vector2 value) { }

	// RVA: 0x37D6874 Offset: 0x37D2874 VA: 0x37D6874
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x37D6870 Offset: 0x37D2870 VA: 0x37D6870
	public void SetTextureScale(int nameID, Vector2 value) { }

	// RVA: 0x37D6650 Offset: 0x37D2650 VA: 0x37D6650
	public Vector2 GetTextureOffset(string name) { }

	// RVA: 0x37D6638 Offset: 0x37D2638 VA: 0x37D6638
	public Vector2 GetTextureOffset(int nameID) { }

	// RVA: 0x37D6B44 Offset: 0x37D2B44 VA: 0x37D6B44
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x37D6BEC Offset: 0x37D2BEC VA: 0x37D6BEC
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x37D6D38 Offset: 0x37D2D38 VA: 0x37D6D38
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x37D6E30 Offset: 0x37D2E30 VA: 0x37D6E30
	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x37D6EDC Offset: 0x37D2EDC VA: 0x37D6EDC
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x37D6F88 Offset: 0x37D2F88 VA: 0x37D6F88
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }
}
