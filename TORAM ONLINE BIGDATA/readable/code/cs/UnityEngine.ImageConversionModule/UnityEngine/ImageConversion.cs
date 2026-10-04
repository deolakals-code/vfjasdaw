// Assembly: UnityEngine.ImageConversionModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
[Extension]
public static class ImageConversion // TypeDefIndex: 17877
{
	// Methods

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x3800CF4 Offset: 0x37FCCF4 VA: 0x3800CF4
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	// RVA: 0x3800D30 Offset: 0x37FCD30 VA: 0x3800D30
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[Extension]
	// RVA: 0x3800D84 Offset: 0x37FCD84 VA: 0x3800D84
	public static bool LoadImage(Texture2D tex, byte[] data) { }
}
