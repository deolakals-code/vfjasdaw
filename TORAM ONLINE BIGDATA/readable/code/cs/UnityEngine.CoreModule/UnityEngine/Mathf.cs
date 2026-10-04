// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Utilities/BitUtility.h")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
public struct Mathf // TypeDefIndex: 16303
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37E600C Offset: 0x37E200C VA: 0x37E600C
	public static bool IsPowerOfTwo(int value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37E6048 Offset: 0x37E2048 VA: 0x37E6048
	public static float GammaToLinearSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37E6080 Offset: 0x37E2080 VA: 0x37E6080
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	// RVA: 0x37E6124 Offset: 0x37E2124 VA: 0x37E6124
	public static float Sin(float f) { }

	// RVA: 0x37E6188 Offset: 0x37E2188 VA: 0x37E6188
	public static float Cos(float f) { }

	// RVA: 0x37E61EC Offset: 0x37E21EC VA: 0x37E61EC
	public static float Tan(float f) { }

	// RVA: 0x37E6250 Offset: 0x37E2250 VA: 0x37E6250
	public static float Asin(float f) { }

	// RVA: 0x37E62B4 Offset: 0x37E22B4 VA: 0x37E62B4
	public static float Acos(float f) { }

	// RVA: 0x37E6318 Offset: 0x37E2318 VA: 0x37E6318
	public static float Atan(float f) { }

	// RVA: 0x37E637C Offset: 0x37E237C VA: 0x37E637C
	public static float Atan2(float y, float x) { }

	// RVA: 0x37E63E8 Offset: 0x37E23E8 VA: 0x37E63E8
	public static float Sqrt(float f) { }

	// RVA: 0x37E6444 Offset: 0x37E2444 VA: 0x37E6444
	public static float Abs(float f) { }

	// RVA: 0x37E64A0 Offset: 0x37E24A0 VA: 0x37E64A0
	public static int Abs(int value) { }

	// RVA: 0x37E64F8 Offset: 0x37E24F8 VA: 0x37E64F8
	public static float Min(float a, float b) { }

	// RVA: 0x37E6504 Offset: 0x37E2504 VA: 0x37E6504
	public static float Min(float[] values) { }

	// RVA: 0x37E6554 Offset: 0x37E2554 VA: 0x37E6554
	public static int Min(int a, int b) { }

	// RVA: 0x37E6560 Offset: 0x37E2560 VA: 0x37E6560
	public static float Max(float a, float b) { }

	// RVA: 0x37E656C Offset: 0x37E256C VA: 0x37E656C
	public static float Max(float[] values) { }

	// RVA: 0x37E65BC Offset: 0x37E25BC VA: 0x37E65BC
	public static int Max(int a, int b) { }

	// RVA: 0x37E65C8 Offset: 0x37E25C8 VA: 0x37E65C8
	public static float Pow(float f, float p) { }

	// RVA: 0x37E6638 Offset: 0x37E2638 VA: 0x37E6638
	public static float Log(float f) { }

	// RVA: 0x37E669C Offset: 0x37E269C VA: 0x37E669C
	public static float Log10(float f) { }

	// RVA: 0x37E6700 Offset: 0x37E2700 VA: 0x37E6700
	public static float Ceil(float f) { }

	// RVA: 0x37E675C Offset: 0x37E275C VA: 0x37E675C
	public static float Floor(float f) { }

	// RVA: 0x37E67B8 Offset: 0x37E27B8 VA: 0x37E67B8
	public static float Round(float f) { }

	// RVA: 0x37E6880 Offset: 0x37E2880 VA: 0x37E6880
	public static int CeilToInt(float f) { }

	// RVA: 0x37E68F4 Offset: 0x37E28F4 VA: 0x37E68F4
	public static int FloorToInt(float f) { }

	// RVA: 0x37E6968 Offset: 0x37E2968 VA: 0x37E6968
	public static int RoundToInt(float f) { }

	// RVA: 0x37E6A44 Offset: 0x37E2A44 VA: 0x37E6A44
	public static float Sign(float f) { }

	// RVA: 0x37E6A58 Offset: 0x37E2A58 VA: 0x37E6A58
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x37E6A74 Offset: 0x37E2A74 VA: 0x37E6A74
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x37E6A90 Offset: 0x37E2A90 VA: 0x37E6A90
	public static float Clamp01(float value) { }

	// RVA: 0x37E6AAC Offset: 0x37E2AAC VA: 0x37E6AAC
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x37E6AD0 Offset: 0x37E2AD0 VA: 0x37E6AD0
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x37E6B14 Offset: 0x37E2B14 VA: 0x37E6B14
	public static bool Approximately(float a, float b) { }

	// RVA: 0x37E6BA4 Offset: 0x37E2BA4 VA: 0x37E6BA4
	private static void .cctor() { }

	// RVA: 0x37E60D8 Offset: 0x37E20D8 VA: 0x37E60D8
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }
}
