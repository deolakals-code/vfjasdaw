// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public enum TextureFormat // TypeDefIndex: 16265
{
	// Fields
	public int value__; // 0x0
	public const TextureFormat Alpha8 = 1;
	public const TextureFormat ARGB4444 = 2;
	public const TextureFormat RGB24 = 3;
	public const TextureFormat RGBA32 = 4;
	public const TextureFormat ARGB32 = 5;
	public const TextureFormat RGB565 = 7;
	public const TextureFormat R16 = 9;
	public const TextureFormat DXT1 = 10;
	public const TextureFormat DXT5 = 12;
	public const TextureFormat RGBA4444 = 13;
	public const TextureFormat BGRA32 = 14;
	public const TextureFormat RHalf = 15;
	public const TextureFormat RGHalf = 16;
	public const TextureFormat RGBAHalf = 17;
	public const TextureFormat RFloat = 18;
	public const TextureFormat RGFloat = 19;
	public const TextureFormat RGBAFloat = 20;
	public const TextureFormat YUY2 = 21;
	public const TextureFormat RGB9e5Float = 22;
	public const TextureFormat BC4 = 26;
	public const TextureFormat BC5 = 27;
	public const TextureFormat BC6H = 24;
	public const TextureFormat BC7 = 25;
	public const TextureFormat DXT1Crunched = 28;
	public const TextureFormat DXT5Crunched = 29;
	public const TextureFormat PVRTC_RGB2 = 30;
	public const TextureFormat PVRTC_RGBA2 = 31;
	public const TextureFormat PVRTC_RGB4 = 32;
	public const TextureFormat PVRTC_RGBA4 = 33;
	public const TextureFormat ETC_RGB4 = 34;
	public const TextureFormat EAC_R = 41;
	public const TextureFormat EAC_R_SIGNED = 42;
	public const TextureFormat EAC_RG = 43;
	public const TextureFormat EAC_RG_SIGNED = 44;
	public const TextureFormat ETC2_RGB = 45;
	public const TextureFormat ETC2_RGBA1 = 46;
	public const TextureFormat ETC2_RGBA8 = 47;
	public const TextureFormat ASTC_4x4 = 48;
	public const TextureFormat ASTC_5x5 = 49;
	public const TextureFormat ASTC_6x6 = 50;
	public const TextureFormat ASTC_8x8 = 51;
	public const TextureFormat ASTC_10x10 = 52;
	public const TextureFormat ASTC_12x12 = 53;
	[Obsolete("Nintendo 3DS is no longer supported.")]
	public const TextureFormat ETC_RGB4_3DS = 60;
	[Obsolete("Nintendo 3DS is no longer supported.")]
	public const TextureFormat ETC_RGBA8_3DS = 61;
	public const TextureFormat RG16 = 62;
	public const TextureFormat R8 = 63;
	public const TextureFormat ETC_RGB4Crunched = 64;
	public const TextureFormat ETC2_RGBA8Crunched = 65;
	public const TextureFormat ASTC_HDR_4x4 = 66;
	public const TextureFormat ASTC_HDR_5x5 = 67;
	public const TextureFormat ASTC_HDR_6x6 = 68;
	public const TextureFormat ASTC_HDR_8x8 = 69;
	public const TextureFormat ASTC_HDR_10x10 = 70;
	public const TextureFormat ASTC_HDR_12x12 = 71;
	public const TextureFormat RG32 = 72;
	public const TextureFormat RGB48 = 73;
	public const TextureFormat RGBA64 = 74;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
	public const TextureFormat ASTC_RGB_4x4 = 48;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
	public const TextureFormat ASTC_RGB_5x5 = 49;
	[Obsolete("Enum member TextureFormat.ASTC_RGB_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGB_6x6 = 50;
	[Obsolete("Enum member TextureFormat.ASTC_RGB_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGB_8x8 = 51;
	[Obsolete("Enum member TextureFormat.ASTC_RGB_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGB_10x10 = 52;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
	public const TextureFormat ASTC_RGB_12x12 = 53;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
	public const TextureFormat ASTC_RGBA_4x4 = 54;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_5x5 = 55;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_6x6 = 56;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_8x8 = 57;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_10x10 = 58;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_12x12 = 59;
}
