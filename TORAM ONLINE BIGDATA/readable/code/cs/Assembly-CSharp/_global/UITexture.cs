// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Texture")]
[ExecuteInEditMode]
public class UITexture : UIWidget // TypeDefIndex: 192
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private Rect mRect; // 0x104
	[HideInInspector]
	[SerializeField]
	private Shader mShader; // 0x118
	[HideInInspector]
	[SerializeField]
	private Texture mTexture; // 0x120
	[HideInInspector]
	[SerializeField]
	private Material mMat; // 0x128
	private bool mCreatingMat; // 0x130
	private Material mDynamicMat; // 0x138
	private int mPMA; // 0x140

	// Properties
	public Rect uvRect { get; set; }
	public Shader shader { get; set; }
	public bool hasDynamicMaterial { get; }
	public override Material material { get; set; }
	public bool premultipliedAlpha { get; }
	public override Texture mainTexture { get; set; }
	protected Vector4 drawingDimensions { get; }

	// Methods

	// RVA: 0x20DAAE0 Offset: 0x20D6AE0 VA: 0x20DAAE0
	public Rect get_uvRect() { }

	// RVA: 0x20DAAF4 Offset: 0x20D6AF4 VA: 0x20DAAF4
	public void set_uvRect(Rect value) { }

	// RVA: 0x20DAB48 Offset: 0x20D6B48 VA: 0x20DAB48
	public Shader get_shader() { }

	// RVA: 0x20DAC7C Offset: 0x20D6C7C VA: 0x20DAC7C
	public void set_shader(Shader value) { }

	// RVA: 0x20DAD60 Offset: 0x20D6D60 VA: 0x20DAD60
	public bool get_hasDynamicMaterial() { }

	// RVA: 0x20DADC0 Offset: 0x20D6DC0 VA: 0x20DADC0 Slot: 14
	public override Material get_material() { }

	// RVA: 0x20DB02C Offset: 0x20D702C VA: 0x20DB02C Slot: 15
	public override void set_material(Material value) { }

	// RVA: 0x20DB0E4 Offset: 0x20D70E4 VA: 0x20DB0E4
	public bool get_premultipliedAlpha() { }

	// RVA: 0x20DB22C Offset: 0x20D722C VA: 0x20DB22C Slot: 16
	public override Texture get_mainTexture() { }

	// RVA: 0x20DB2E4 Offset: 0x20D72E4 VA: 0x20DB2E4 Slot: 17
	public override void set_mainTexture(Texture value) { }

	// RVA: 0x20DB420 Offset: 0x20D7420 VA: 0x20DB420
	protected Vector4 get_drawingDimensions() { }

	// RVA: 0x20DB6D0 Offset: 0x20D76D0 VA: 0x20DB6D0
	private void OnDestroy() { }

	// RVA: 0x20DAF74 Offset: 0x20D6F74 VA: 0x20DAF74
	private void Cleanup() { }

	// RVA: 0x20DB6D4 Offset: 0x20D76D4 VA: 0x20DB6D4 Slot: 24
	public override void MakePixelPerfect() { }

	// RVA: 0x20DB7B4 Offset: 0x20D77B4 VA: 0x20DB7B4 Slot: 29
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x20DBA10 Offset: 0x20D7A10 VA: 0x20DBA10
	public void .ctor() { }
}
