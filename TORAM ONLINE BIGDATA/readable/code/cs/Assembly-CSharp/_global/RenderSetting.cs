// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("Iruna2/Render/RenderSetting")]
public class RenderSetting : MonoBehaviour // TypeDefIndex: 5405
{
	// Fields
	private static float brightness; // 0x0
	[SerializeField]
	private bool animationFlag; // 0x20
	[SerializeField]
	private bool fogFlag; // 0x21
	[SerializeField]
	private Color fogColor; // 0x24
	[SerializeField]
	private Color ambientColor; // 0x34
	[SerializeField]
	private Color cameraBackColor; // 0x44
	[SerializeField]
	private float fogStartDistance; // 0x54
	[SerializeField]
	private float fogEndDistance; // 0x58
	[SerializeField]
	private float fogDensity; // 0x5C
	[SerializeField]
	private FogMode fogEffectMode; // 0x60
	[SerializeField]
	private float worldBrightness; // 0x64
	[SerializeField]
	private float cameraUp; // 0x68
	[SerializeField]
	private float cameraDown; // 0x6C
	[SerializeField]
	private float cameraFarClip; // 0x70
	[SerializeField]
	private float colliderSize; // 0x74
	[SerializeField]
	private float dropHeight; // 0x78
	[SerializeField]
	private Texture[] miniMap; // 0x80
	[SerializeField]
	private GameObject[] fieldObject; // 0x88
	[SerializeField]
	private GameObject[] screenObject; // 0x90
	[SerializeField]
	private Transform[] childrenObject; // 0x98

	// Properties
	public static float Brightness { get; }
	public bool AnimeationFlag { get; }
	public bool FogFlag { get; }
	public Color FogColor { get; }
	public Color AmbientColor { get; }
	public Color CameraBackColor { get; }
	public float FogStartDistance { get; }
	public float FogEndDistance { get; }
	public float FogDensity { get; }
	public FogMode FogEffectMode { get; }
	public float WorldBrightness { get; }
	public float CameraUp { get; }
	public float CameraDown { get; }
	public float CameraFarClip { get; }
	public float ColliderSize { get; }
	public float DropHeight { get; }
	public Texture[] MiniMap { get; }
	public GameObject[] FieldObject { get; }

	// Methods

	// RVA: 0x175E164 Offset: 0x175A164 VA: 0x175E164
	public static float get_Brightness() { }

	// RVA: 0x175E1BC Offset: 0x175A1BC VA: 0x175E1BC
	public bool get_AnimeationFlag() { }

	// RVA: 0x175E1C4 Offset: 0x175A1C4 VA: 0x175E1C4
	public bool get_FogFlag() { }

	// RVA: 0x175E1CC Offset: 0x175A1CC VA: 0x175E1CC
	public Color get_FogColor() { }

	// RVA: 0x175E1D8 Offset: 0x175A1D8 VA: 0x175E1D8
	public Color get_AmbientColor() { }

	// RVA: 0x175E1E4 Offset: 0x175A1E4 VA: 0x175E1E4
	public Color get_CameraBackColor() { }

	// RVA: 0x175E1F0 Offset: 0x175A1F0 VA: 0x175E1F0
	public float get_FogStartDistance() { }

	// RVA: 0x175E1F8 Offset: 0x175A1F8 VA: 0x175E1F8
	public float get_FogEndDistance() { }

	// RVA: 0x175E200 Offset: 0x175A200 VA: 0x175E200
	public float get_FogDensity() { }

	// RVA: 0x175E208 Offset: 0x175A208 VA: 0x175E208
	public FogMode get_FogEffectMode() { }

	// RVA: 0x175E210 Offset: 0x175A210 VA: 0x175E210
	public float get_WorldBrightness() { }

	// RVA: 0x175E218 Offset: 0x175A218 VA: 0x175E218
	public float get_CameraUp() { }

	// RVA: 0x175E220 Offset: 0x175A220 VA: 0x175E220
	public float get_CameraDown() { }

	// RVA: 0x175E228 Offset: 0x175A228 VA: 0x175E228
	public float get_CameraFarClip() { }

	// RVA: 0x175E230 Offset: 0x175A230 VA: 0x175E230
	public float get_ColliderSize() { }

	// RVA: 0x175E238 Offset: 0x175A238 VA: 0x175E238
	public float get_DropHeight() { }

	// RVA: 0x175E240 Offset: 0x175A240 VA: 0x175E240
	public Texture[] get_MiniMap() { }

	// RVA: 0x175E248 Offset: 0x175A248 VA: 0x175E248
	public GameObject[] get_FieldObject() { }

	// RVA: 0x175E250 Offset: 0x175A250 VA: 0x175E250
	private void Awake() { }

	// RVA: 0x175E254 Offset: 0x175A254 VA: 0x175E254
	private void Start() { }

	// RVA: 0x175E6B8 Offset: 0x175A6B8 VA: 0x175E6B8
	private void OnDisable() { }

	// RVA: 0x175E46C Offset: 0x175A46C VA: 0x175E46C
	private void OnEnable() { }

	// RVA: 0x175E8EC Offset: 0x175A8EC VA: 0x175E8EC
	private void LateUpdate() { }

	// RVA: 0x175E9F8 Offset: 0x175A9F8 VA: 0x175E9F8
	private void OnDestroy() { }

	// RVA: 0x175E348 Offset: 0x175A348 VA: 0x175E348
	private void SetRenderSettings() { }

	// RVA: 0x175EAB0 Offset: 0x175AAB0 VA: 0x175EAB0
	public void SettingChange(Color setFogColor, float setFogDensity, float setFogStartDistance, float setFogEndDistance, float setWorldBrightness) { }

	// RVA: 0x175EAC8 Offset: 0x175AAC8 VA: 0x175EAC8
	public void ReRender() { }

	// RVA: 0x175EACC Offset: 0x175AACC VA: 0x175EACC
	public void EnterReset() { }

	// RVA: 0x175ED84 Offset: 0x175AD84 VA: 0x175ED84
	public void FromRenderSettings() { }

	// RVA: 0x175EE2C Offset: 0x175AE2C VA: 0x175EE2C
	public void SetRandamMapMiniMap(Texture miniMapData) { }

	// RVA: 0x175EEDC Offset: 0x175AEDC VA: 0x175EEDC
	public void .ctor() { }

	// RVA: 0x175EF34 Offset: 0x175AF34 VA: 0x175EF34
	private static void .cctor() { }
}
