// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping // TypeDefIndex: 16678
{
	// Fields
	[RequiredByNativeCode]
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCode]
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37FF038 Offset: 0x37FB038 VA: 0x37FF038
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCode]
	// RVA: 0x37FF0B4 Offset: 0x37FB0B4 VA: 0x37FF0B4
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x37FF10C Offset: 0x37FB10C VA: 0x37FF10C
	public static void ResetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x37FF168 Offset: 0x37FB168 VA: 0x37FF168
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x37FF234 Offset: 0x37FB234 VA: 0x37FF234
	private static void .cctor() { }
}
