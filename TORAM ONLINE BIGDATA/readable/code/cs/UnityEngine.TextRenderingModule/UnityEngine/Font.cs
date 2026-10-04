// Assembly: UnityEngine.TextRenderingModule.dll
// Namespace: UnityEngine
[StaticAccessor("TextRenderingPrivate", 2)]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeClass("TextRendering::Font")]
public sealed class Font : Object // TypeDefIndex: 17854
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Font> textureRebuilt; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public string[] fontNames { get; }
	public bool dynamic { get; }
	[Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
	public Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

	// Methods

	// RVA: 0x3823334 Offset: 0x381F334 VA: 0x3823334
	public Material get_material() { }

	// RVA: 0x3823370 Offset: 0x381F370 VA: 0x3823370
	public string[] get_fontNames() { }

	// RVA: 0x38233AC Offset: 0x381F3AC VA: 0x38233AC
	public bool get_dynamic() { }

	// RVA: 0x38233E8 Offset: 0x381F3E8 VA: 0x38233E8
	public Font.FontTextureRebuildCallback get_textureRebuildCallback() { }

	// RVA: 0x38233F0 Offset: 0x381F3F0 VA: 0x38233F0
	public void set_textureRebuildCallback(Font.FontTextureRebuildCallback value) { }

	// RVA: 0x38233F8 Offset: 0x381F3F8 VA: 0x38233F8
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x38234C0 Offset: 0x381F4C0 VA: 0x38234C0
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x382354C Offset: 0x381F54C VA: 0x382354C
	public bool HasCharacter(char c) { }

	// RVA: 0x3823590 Offset: 0x381F590 VA: 0x3823590
	private bool HasCharacter(int c) { }

	// RVA: 0x382347C Offset: 0x381F47C VA: 0x382347C
	private static void Internal_CreateFont(Font self, string name) { }

	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	// RVA: 0x38235D4 Offset: 0x381F5D4 VA: 0x38235D4
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	// RVA: 0x3823640 Offset: 0x381F640 VA: 0x3823640
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }
}
