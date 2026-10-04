// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils // TypeDefIndex: 16675
{
	// Methods

	// RVA: 0x37FDE80 Offset: 0x37F9E80 VA: 0x37FDE80
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x37FDEA0 Offset: 0x37F9EA0 VA: 0x37FDEA0
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x37FDF18 Offset: 0x37F9F18 VA: 0x37FDF18
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x37FDF6C Offset: 0x37F9F6C VA: 0x37FDF6C
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x37FE000 Offset: 0x37FA000 VA: 0x37FE000
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x37FE048 Offset: 0x37FA048 VA: 0x37FE048
	public static void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x37FE208 Offset: 0x37FA208 VA: 0x37FE208
	public static void Extract(Light l, ref PointLight point) { }

	// RVA: 0x37FE3E0 Offset: 0x37FA3E0 VA: 0x37FE3E0
	public static void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x37FE5E0 Offset: 0x37FA5E0 VA: 0x37FE5E0
	public static void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x37FE7B8 Offset: 0x37FA7B8 VA: 0x37FE7B8
	public static void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x37FE990 Offset: 0x37FA990 VA: 0x37FE990
	public static void Extract(Light l, out Cookie cookie) { }
}
