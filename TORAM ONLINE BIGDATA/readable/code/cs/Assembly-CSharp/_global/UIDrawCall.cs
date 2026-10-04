// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Draw Call")]
public class UIDrawCall : MonoBehaviour // TypeDefIndex: 81
{
	// Fields
	public static BetterList<UIDrawCall> list; // 0x0
	private Transform mTrans; // 0x20
	private Material mSharedMat; // 0x28
	private Mesh mMesh0; // 0x30
	private Mesh mMesh1; // 0x38
	private MeshFilter mFilter; // 0x40
	private MeshRenderer mRen; // 0x48
	private UIDrawCall.Clipping mClipping; // 0x50
	private Vector4 mClipRange; // 0x54
	private Vector2 mClipSoft; // 0x64
	private Material mMat; // 0x70
	private int[] mIndices; // 0x78
	private bool mDirty; // 0x80
	private bool mReset; // 0x81
	private bool mEven; // 0x82
	private int mRenderQueue; // 0x84
	[CompilerGenerated]
	private UIPanel <panel>k__BackingField; // 0x88

	// Properties
	public UIPanel panel { get; set; }
	public bool isDirty { get; set; }
	public int renderQueue { get; set; }
	public Transform cachedTransform { get; }
	public Material material { get; set; }
	public Texture mainTexture { get; set; }
	public int triangles { get; }
	public bool isClipped { get; }
	public UIDrawCall.Clipping clipping { get; set; }
	public Vector4 clipRange { get; set; }
	public Vector2 clipSoftness { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17332D4 Offset: 0x172F2D4 VA: 0x17332D4
	public UIPanel get_panel() { }

	[CompilerGenerated]
	// RVA: 0x17332DC Offset: 0x172F2DC VA: 0x17332DC
	public void set_panel(UIPanel value) { }

	// RVA: 0x17332E4 Offset: 0x172F2E4 VA: 0x17332E4
	public bool get_isDirty() { }

	// RVA: 0x17332EC Offset: 0x172F2EC VA: 0x17332EC
	public void set_isDirty(bool value) { }

	// RVA: 0x17332F8 Offset: 0x172F2F8 VA: 0x17332F8
	public int get_renderQueue() { }

	// RVA: 0x1733300 Offset: 0x172F300 VA: 0x1733300
	public void set_renderQueue(int value) { }

	// RVA: 0x17333E4 Offset: 0x172F3E4 VA: 0x17333E4
	public Transform get_cachedTransform() { }

	// RVA: 0x1733478 Offset: 0x172F478 VA: 0x1733478
	public Material get_material() { }

	// RVA: 0x1733480 Offset: 0x172F480 VA: 0x1733480
	public void set_material(Material value) { }

	// RVA: 0x1733488 Offset: 0x172F488 VA: 0x1733488
	public Texture get_mainTexture() { }

	// RVA: 0x1733510 Offset: 0x172F510 VA: 0x1733510
	public void set_mainTexture(Texture value) { }

	// RVA: 0x17335A8 Offset: 0x172F5A8 VA: 0x17335A8
	public int get_triangles() { }

	// RVA: 0x1733644 Offset: 0x172F644 VA: 0x1733644
	public bool get_isClipped() { }

	// RVA: 0x1733654 Offset: 0x172F654 VA: 0x1733654
	public UIDrawCall.Clipping get_clipping() { }

	// RVA: 0x173365C Offset: 0x172F65C VA: 0x173365C
	public void set_clipping(UIDrawCall.Clipping value) { }

	// RVA: 0x1733678 Offset: 0x172F678 VA: 0x1733678
	public Vector4 get_clipRange() { }

	// RVA: 0x1733684 Offset: 0x172F684 VA: 0x1733684
	public void set_clipRange(Vector4 value) { }

	// RVA: 0x1733690 Offset: 0x172F690 VA: 0x1733690
	public Vector2 get_clipSoftness() { }

	// RVA: 0x1733698 Offset: 0x172F698 VA: 0x1733698
	public void set_clipSoftness(Vector2 value) { }

	// RVA: 0x17336A0 Offset: 0x172F6A0 VA: 0x17336A0
	private Mesh GetMesh(ref bool rebuildIndices, int vertexCount) { }

	// RVA: 0x17338B8 Offset: 0x172F8B8 VA: 0x17338B8
	public void RebuildMaterial() { }

	// RVA: 0x17339B4 Offset: 0x172F9B4 VA: 0x17339B4
	private void UpdateMaterials() { }

	// RVA: 0x1733CD4 Offset: 0x172FCD4 VA: 0x1733CD4
	public void Set(BetterList<Vector3> verts, BetterList<Vector3> norms, BetterList<Vector4> tans, BetterList<Vector2> uvs, BetterList<Color32> cols) { }

	// RVA: 0x17343F4 Offset: 0x17303F4 VA: 0x17343F4
	private void OnWillRenderObject() { }

	// RVA: 0x1734538 Offset: 0x1730538 VA: 0x1734538
	private void OnDestroy() { }

	// RVA: 0x17345A0 Offset: 0x17305A0 VA: 0x17345A0
	public void .ctor() { }

	// RVA: 0x17345B0 Offset: 0x17305B0 VA: 0x17345B0
	private static void .cctor() { }
}
