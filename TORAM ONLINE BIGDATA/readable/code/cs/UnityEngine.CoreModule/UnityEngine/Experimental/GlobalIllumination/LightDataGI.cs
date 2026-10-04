// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.GlobalIllumination
[UsedByNativeCode]
public struct LightDataGI // TypeDefIndex: 16674
{
	// Fields
	public int instanceID; // 0x0
	public int cookieID; // 0x4
	public float cookieScale; // 0x8
	public LinearColor color; // 0xC
	public LinearColor indirectColor; // 0x1C
	public Quaternion orientation; // 0x2C
	public Vector3 position; // 0x3C
	public float range; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public float shape0; // 0x54
	public float shape1; // 0x58
	public LightType type; // 0x5C
	public LightMode mode; // 0x5D
	public byte shadow; // 0x5E
	public FalloffType falloff; // 0x5F

	// Methods

	// RVA: 0x37FDC0C Offset: 0x37F9C0C VA: 0x37FDC0C
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x37FDC80 Offset: 0x37F9C80 VA: 0x37FDC80
	public void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x37FDCFC Offset: 0x37F9CFC VA: 0x37FDCFC
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x37FDD7C Offset: 0x37F9D7C VA: 0x37FDD7C
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x37FDDF4 Offset: 0x37F9DF4 VA: 0x37FDDF4
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x37FDE70 Offset: 0x37F9E70 VA: 0x37FDE70
	public void InitNoBake(int lightInstanceID) { }
}
