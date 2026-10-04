// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceMagicSquare : MonoBehaviour, IDisposable // TypeDefIndex: 3864
{
	// Fields
	private GameObject model; // 0x20
	private Animation anime; // 0x28
	private Motion motion; // 0x30
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x38
	private readonly int normalId; // 0x40
	private readonly int popMotionId; // 0x44
	private Vector3 scale; // 0x48
	private Vector3 scaling; // 0x54
	private Vector3 lastScale; // 0x60
	private float scalingTime; // 0x6C
	private readonly float FPS; // 0x70
	private readonly DefenceMagicSquare.Colors initializeSurfaceColor; // 0x78
	private DefenceMagicSquare.Colors surfaceCurrentColor; // 0x80
	private DefenceMagicSquare.Colors surfaceColouring; // 0x88
	private DefenceMagicSquare.Colors surfaceLastColor; // 0x90
	private readonly DefenceMagicSquare.Colors initializeAuraColor; // 0x98
	private DefenceMagicSquare.Colors auraCurrentColor; // 0xA0
	private DefenceMagicSquare.Colors auraColouring; // 0xA8
	private DefenceMagicSquare.Colors auraLastColor; // 0xB0
	private float colouringTime; // 0xB8
	private Action<float> ReinstateScale; // 0xC0
	private float reinstateScaleTime; // 0xC8
	private Action<float> ReinstateColor; // 0xD0
	private float reinstateColorTime; // 0xD8
	private float height; // 0xDC
	[CompilerGenerated]
	private bool <IsSetModel>k__BackingField; // 0xE0
	[CompilerGenerated]
	private bool <IsPopAnimation>k__BackingField; // 0xE1
	[CompilerGenerated]
	private bool <IsScaling>k__BackingField; // 0xE2
	[CompilerGenerated]
	private bool <IsColouring>k__BackingField; // 0xE3
	private bool disposedValue; // 0xE4

	// Properties
	public bool IsSetModel { get; set; }
	public bool IsPopAnimation { get; set; }
	public Vector3 Scale { get; }
	public bool IsScaling { get; set; }
	public bool IsColouring { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23FF024 Offset: 0x23FB024 VA: 0x23FF024
	public bool get_IsSetModel() { }

	[CompilerGenerated]
	// RVA: 0x23FF02C Offset: 0x23FB02C VA: 0x23FF02C
	private void set_IsSetModel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23FF038 Offset: 0x23FB038 VA: 0x23FF038
	public bool get_IsPopAnimation() { }

	[CompilerGenerated]
	// RVA: 0x23FF040 Offset: 0x23FB040 VA: 0x23FF040
	private void set_IsPopAnimation(bool value) { }

	// RVA: 0x23FF04C Offset: 0x23FB04C VA: 0x23FF04C
	public Vector3 get_Scale() { }

	[CompilerGenerated]
	// RVA: 0x23FF110 Offset: 0x23FB110 VA: 0x23FF110
	public bool get_IsScaling() { }

	[CompilerGenerated]
	// RVA: 0x23FF118 Offset: 0x23FB118 VA: 0x23FF118
	private void set_IsScaling(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23FF124 Offset: 0x23FB124 VA: 0x23FF124
	public bool get_IsColouring() { }

	[CompilerGenerated]
	// RVA: 0x23FF12C Offset: 0x23FB12C VA: 0x23FF12C
	private void set_IsColouring(bool value) { }

	// RVA: 0x23FF138 Offset: 0x23FB138 VA: 0x23FF138
	private void Awake() { }

	// RVA: 0x23FF254 Offset: 0x23FB254 VA: 0x23FF254
	private void Update() { }

	// RVA: 0x23FF3C0 Offset: 0x23FB3C0 VA: 0x23FF3C0
	private void UpdateScale() { }

	// RVA: 0x23FF470 Offset: 0x23FB470 VA: 0x23FF470
	private void UpdateColor() { }

	// RVA: 0x23FF174 Offset: 0x23FB174 VA: 0x23FF174
	private void Load() { }

	// RVA: 0x23FF70C Offset: 0x23FB70C VA: 0x23FF70C
	private void SetModel(GameObject modelObject) { }

	// RVA: 0x23FF988 Offset: 0x23FB988 VA: 0x23FF988
	private void SetMagicSquareSurfaceColor(float r, float g, float b) { }

	// RVA: 0x23FF69C Offset: 0x23FB69C VA: 0x23FF69C
	private void SetMagicSquareSurfaceColor(float[] color) { }

	// RVA: 0x23FFB40 Offset: 0x23FBB40 VA: 0x23FFB40
	private void SetMagicSquareAuraColor(float r, float g, float b) { }

	// RVA: 0x23FF6D4 Offset: 0x23FB6D4 VA: 0x23FF6D4
	private void SetMagicSquareAuraColor(float[] color) { }

	// RVA: 0x23FFCFC Offset: 0x23FBCFC VA: 0x23FFCFC
	public void Pop() { }

	// RVA: 0x23FFE3C Offset: 0x23FBE3C VA: 0x23FFE3C
	public void SetScale(float x, float y, float z) { }

	// RVA: 0x23FFF04 Offset: 0x23FBF04 VA: 0x23FFF04
	public void SetScale(Vector3 scale) { }

	// RVA: 0x23FFFCC Offset: 0x23FBFCC VA: 0x23FFFCC
	public void Scaling(float time, float x, float y, float z, float reinstate) { }

	// RVA: 0x2400188 Offset: 0x23FC188 VA: 0x2400188
	public void Scaling(float time, Vector3 scaling, float reinstate) { }

	// RVA: 0x2400344 Offset: 0x23FC344 VA: 0x2400344
	public void InitializeScale(float time) { }

	// RVA: 0x24003E0 Offset: 0x23FC3E0 VA: 0x24003E0
	public void Colouring(float time, float surfaceR, float surfaceG, float surfaceB, float auraR, float auraG, float auraB, float reinstateTime) { }

	// RVA: 0x2400718 Offset: 0x23FC718 VA: 0x2400718
	public void Colouring(float time, float[] surfaceColor, float[] auraColor, float reinstateTime) { }

	// RVA: 0x2400ACC Offset: 0x23FCACC VA: 0x2400ACC
	public void InitializeColor(float time) { }

	// RVA: 0x2400B5C Offset: 0x23FCB5C VA: 0x2400B5C
	public void SetHeight(float height) { }

	// RVA: 0x2400C4C Offset: 0x23FCC4C VA: 0x2400C4C Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2400CD8 Offset: 0x23FCCD8 VA: 0x2400CD8 Slot: 4
	public void Dispose() { }

	// RVA: 0x2400CE8 Offset: 0x23FCCE8 VA: 0x2400CE8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2400DC0 Offset: 0x23FCDC0 VA: 0x2400DC0
	private void <Load>b__48_0(bool b, GameObject x) { }

	[CompilerGenerated]
	// RVA: 0x2400DC8 Offset: 0x23FCDC8 VA: 0x2400DC8
	private void <Scaling>b__57_0(float a) { }

	[CompilerGenerated]
	// RVA: 0x2400E3C Offset: 0x23FCE3C VA: 0x2400E3C
	private void <Scaling>b__58_0(float a) { }

	[CompilerGenerated]
	// RVA: 0x2400EB0 Offset: 0x23FCEB0 VA: 0x2400EB0
	private void <Colouring>b__60_0(float x) { }

	[CompilerGenerated]
	// RVA: 0x2400F0C Offset: 0x23FCF0C VA: 0x2400F0C
	private void <Colouring>b__61_0(float x) { }
}
