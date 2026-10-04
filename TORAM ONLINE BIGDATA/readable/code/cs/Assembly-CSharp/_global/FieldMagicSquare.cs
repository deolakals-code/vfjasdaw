// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldMagicSquare : MonoBehaviour, IDisposable // TypeDefIndex: 3901
{
	// Fields
	private GameObject model; // 0x20
	private Motion motion; // 0x28
	private SkinnedMeshRenderer render; // 0x30
	private bool isPop; // 0x38
	private Action popCallback; // 0x40
	private Vector3 scalling; // 0x48
	private Vector3 localScale; // 0x54
	private Vector3 lastScale; // 0x60
	private float scalingTime; // 0x6C
	private float scalingTimer; // 0x70
	private bool isScaling; // 0x74
	private Action scaleCallback; // 0x78
	private Vector3 auraColor; // 0x80
	private Vector3 localAuraColor; // 0x8C
	private Vector3 auraColoring; // 0x98
	private Vector3 auraLastColor; // 0xA4
	private Vector3 surfaceColor; // 0xB0
	private Vector3 localSurfaceColor; // 0xBC
	private Vector3 surfaceColoring; // 0xC8
	private Vector3 surfaceLastColor; // 0xD4
	private float coloringTime; // 0xE0
	private float coloringTimer; // 0xE4
	private bool isColoring; // 0xE8
	private Action colorCallback; // 0xF0

	// Properties
	public bool IsModel { get; }
	public bool IsScaling { get; }
	public bool IsColoring { get; }

	// Methods

	// RVA: 0x240A25C Offset: 0x240625C VA: 0x240A25C
	public bool get_IsModel() { }

	// RVA: 0x240A2BC Offset: 0x24062BC VA: 0x240A2BC
	public bool get_IsScaling() { }

	// RVA: 0x240A2C4 Offset: 0x24062C4 VA: 0x240A2C4
	public bool get_IsColoring() { }

	// RVA: 0x240A2CC Offset: 0x24062CC VA: 0x240A2CC Slot: 4
	public void Dispose() { }

	// RVA: 0x240A2D4 Offset: 0x24062D4 VA: 0x240A2D4
	public void Dispose(bool dispose) { }

	// RVA: 0x240A348 Offset: 0x2406348 VA: 0x240A348
	private void Awake() { }

	// RVA: 0x240A42C Offset: 0x240642C VA: 0x240A42C
	private void Update() { }

	// RVA: 0x240A690 Offset: 0x2406690 VA: 0x240A690
	public void Pop(Action callback) { }

	// RVA: 0x240A7A0 Offset: 0x24067A0 VA: 0x240A7A0
	public void SetScale(float x, float y, float z) { }

	// RVA: 0x240A7A4 Offset: 0x24067A4 VA: 0x240A7A4
	public void SetScale(Vector3 scale) { }

	// RVA: 0x240A864 Offset: 0x2406864 VA: 0x240A864
	public void Scaling(float time, float x, float y, float z, Action callback) { }

	// RVA: 0x240A870 Offset: 0x2406870 VA: 0x240A870
	public void Scaling(float time, Vector3 scale, Action callback) { }

	// RVA: 0x240AA0C Offset: 0x2406A0C VA: 0x240AA0C
	public void ForceScaling(float time, float x, float y, float z, Action callback) { }

	// RVA: 0x240AA18 Offset: 0x2406A18 VA: 0x240AA18
	public void ForceScaling(float time, Vector3 scale, Action callback) { }

	// RVA: 0x240AA24 Offset: 0x2406A24 VA: 0x240AA24
	public void SetSurfaceColor(Vector3 color) { }

	// RVA: 0x240AA28 Offset: 0x2406A28 VA: 0x240AA28
	public void SetSurfaceColor(float r, float g, float b) { }

	// RVA: 0x240ABE8 Offset: 0x2406BE8 VA: 0x240ABE8
	public void SetAuraColor(Vector3 color) { }

	// RVA: 0x240ABEC Offset: 0x2406BEC VA: 0x240ABEC
	public void SetAuraColor(float r, float g, float b) { }

	// RVA: 0x240ADB4 Offset: 0x2406DB4 VA: 0x240ADB4
	public void Coloring(float time, float surfaceR, float surfaceG, float surfaceB, float auraR, float auraG, float auraB, Action callback) { }

	// RVA: 0x240ADB8 Offset: 0x2406DB8 VA: 0x240ADB8
	public void Coloring(float time, Vector3 surfaceColor, Vector3 auraColor, Action callback) { }

	// RVA: 0x240AF08 Offset: 0x2406F08 VA: 0x240AF08 Slot: 5
	protected virtual void SetModel(GameObject modelObject) { }

	// RVA: 0x240A34C Offset: 0x240634C VA: 0x240A34C
	private void Initialize() { }

	// RVA: 0x240A44C Offset: 0x240644C VA: 0x240A44C
	private void PopUpdate() { }

	// RVA: 0x240A4A8 Offset: 0x24064A8 VA: 0x240A4A8
	private void ScaleUpdate() { }

	// RVA: 0x240A87C Offset: 0x240687C VA: 0x240A87C
	private void scaling(float time, Vector3 scale, bool force, Action callback) { }

	// RVA: 0x240A59C Offset: 0x240659C VA: 0x240A59C
	private void ColorUpdate() { }

	// RVA: 0x240B14C Offset: 0x240714C VA: 0x240B14C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x240B1AC Offset: 0x24071AC VA: 0x240B1AC
	private void <Initialize>b__48_0(bool b, GameObject x) { }
}
