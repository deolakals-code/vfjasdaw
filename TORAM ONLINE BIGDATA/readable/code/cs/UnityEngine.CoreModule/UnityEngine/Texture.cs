// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
public class Texture : Object // TypeDefIndex: 16279
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Properties
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { set; }
	public FilterMode filterMode { set; }

	// Methods

	// RVA: 0x37D9AD4 Offset: 0x37D5AD4 VA: 0x37D9AD4
	protected void .ctor() { }

	// RVA: 0x37D9B2C Offset: 0x37D5B2C VA: 0x37D9B2C
	private int GetDataWidth() { }

	// RVA: 0x37D9B68 Offset: 0x37D5B68 VA: 0x37D9B68
	private int GetDataHeight() { }

	// RVA: 0x37D9BA4 Offset: 0x37D5BA4 VA: 0x37D9BA4 Slot: 4
	public virtual int get_width() { }

	// RVA: 0x37D9BE0 Offset: 0x37D5BE0 VA: 0x37D9BE0 Slot: 5
	public virtual void set_width(int value) { }

	// RVA: 0x37D9C18 Offset: 0x37D5C18 VA: 0x37D9C18 Slot: 6
	public virtual int get_height() { }

	// RVA: 0x37D9C54 Offset: 0x37D5C54 VA: 0x37D9C54 Slot: 7
	public virtual void set_height(int value) { }

	// RVA: 0x37D9C8C Offset: 0x37D5C8C VA: 0x37D9C8C Slot: 8
	public virtual bool get_isReadable() { }

	// RVA: 0x37D9CC8 Offset: 0x37D5CC8 VA: 0x37D9CC8
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x37D9D0C Offset: 0x37D5D0C VA: 0x37D9D0C
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x37D9D50 Offset: 0x37D5D50 VA: 0x37D9D50
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x37D9D5C Offset: 0x37D5D5C VA: 0x37D9D5C
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x37D9DBC Offset: 0x37D5DBC VA: 0x37D9DBC
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x37D9F7C Offset: 0x37D5F7C VA: 0x37D9F7C
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x37DA134 Offset: 0x37D6134 VA: 0x37DA134
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x37DA1D4 Offset: 0x37D61D4 VA: 0x37DA1D4
	private static void .cctor() { }
}
