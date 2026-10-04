// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Camera/Light.h")]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour // TypeDefIndex: 16253
{
	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativeProperty("LightType")]
	public LightType type { get; }
	public float spotAngle { get; }
	public Color color { get; set; }
	public float colorTemperature { get; }
	public bool useColorTemperature { get; }
	public float intensity { get; }
	public float bounceIntensity { get; }
	public float range { get; }
	public LightBakingOutput bakingOutput { get; }
	public LightShadows shadows { get; }
	public float cookieSize { get; }
	public Texture cookie { get; }

	// Methods

	// RVA: 0x37D72B8 Offset: 0x37D32B8 VA: 0x37D72B8
	public LightType get_type() { }

	// RVA: 0x37D72F4 Offset: 0x37D32F4 VA: 0x37D72F4
	public float get_spotAngle() { }

	// RVA: 0x37D7330 Offset: 0x37D3330 VA: 0x37D7330
	public Color get_color() { }

	// RVA: 0x37D73CC Offset: 0x37D33CC VA: 0x37D73CC
	public void set_color(Color value) { }

	// RVA: 0x37D7464 Offset: 0x37D3464 VA: 0x37D7464
	public float get_colorTemperature() { }

	// RVA: 0x37D74A0 Offset: 0x37D34A0 VA: 0x37D74A0
	public bool get_useColorTemperature() { }

	// RVA: 0x37D74DC Offset: 0x37D34DC VA: 0x37D74DC
	public float get_intensity() { }

	// RVA: 0x37D7518 Offset: 0x37D3518 VA: 0x37D7518
	public float get_bounceIntensity() { }

	// RVA: 0x37D7554 Offset: 0x37D3554 VA: 0x37D7554
	public float get_range() { }

	// RVA: 0x37D7590 Offset: 0x37D3590 VA: 0x37D7590
	public LightBakingOutput get_bakingOutput() { }

	[NativeMethod("GetShadowType")]
	// RVA: 0x37D763C Offset: 0x37D363C VA: 0x37D763C
	public LightShadows get_shadows() { }

	// RVA: 0x37D7678 Offset: 0x37D3678 VA: 0x37D7678
	public float get_cookieSize() { }

	// RVA: 0x37D76B4 Offset: 0x37D36B4 VA: 0x37D76B4
	public Texture get_cookie() { }

	// RVA: 0x37D76F0 Offset: 0x37D36F0 VA: 0x37D76F0
	public void .ctor() { }

	// RVA: 0x37D7388 Offset: 0x37D3388 VA: 0x37D7388
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x37D7420 Offset: 0x37D3420 VA: 0x37D7420
	private void set_color_Injected(ref Color value) { }

	// RVA: 0x37D75F8 Offset: 0x37D35F8 VA: 0x37D75F8
	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }
}
