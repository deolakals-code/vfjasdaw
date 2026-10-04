// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Panel")]
public class UIPanel : MonoBehaviour // TypeDefIndex: 175
{
	// Fields
	public static BetterList<UIPanel> list; // 0x0
	public UIPanel.OnChangeDelegate onChange; // 0x20
	public bool showInPanelTool; // 0x28
	public bool generateNormals; // 0x29
	public bool widgetsAreStatic; // 0x2A
	public bool cullWhileDragging; // 0x2B
	[HideInInspector]
	public Matrix4x4 worldToLocal; // 0x2C
	[HideInInspector]
	[SerializeField]
	private float mAlpha; // 0x6C
	[HideInInspector]
	[SerializeField]
	private UIDrawCall.Clipping mClipping; // 0x70
	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange; // 0x74
	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness; // 0x84
	private static bool mFullRebuild; // 0x8
	private static BetterList<Vector3> mVerts; // 0x10
	private static BetterList<Vector3> mNorms; // 0x18
	private static BetterList<Vector4> mTans; // 0x20
	private static BetterList<Vector2> mUvs; // 0x28
	private static BetterList<Color32> mCols; // 0x30
	private GameObject mGo; // 0x90
	private Transform mTrans; // 0x98
	private Camera mCam; // 0xA0
	private int mLayer; // 0xA8
	private float mCullTime; // 0xAC
	private float mUpdateTime; // 0xB0
	private float mMatrixTime; // 0xB4
	private static float[] mTemp; // 0x38
	private Vector2 mMin; // 0xB8
	private Vector2 mMax; // 0xC0
	private UIPanel[] mChildPanels; // 0xC8

	// Properties
	public GameObject cachedGameObject { get; }
	public Transform cachedTransform { get; }
	public float alpha { get; set; }
	public int drawCallCount { get; }
	public UIDrawCall.Clipping clipping { get; set; }
	public Vector4 clipRange { get; set; }
	public Vector2 clipSoftness { get; set; }

	// Methods

	// RVA: 0x20D01D4 Offset: 0x20CC1D4 VA: 0x20D01D4
	public GameObject get_cachedGameObject() { }

	// RVA: 0x20D0268 Offset: 0x20CC268 VA: 0x20D0268
	public Transform get_cachedTransform() { }

	// RVA: 0x20D02FC Offset: 0x20CC2FC VA: 0x20D02FC
	public float get_alpha() { }

	// RVA: 0x20D0304 Offset: 0x20CC304 VA: 0x20D0304
	public void set_alpha(float value) { }

	// RVA: 0x20D0558 Offset: 0x20CC558 VA: 0x20D0558
	public int get_drawCallCount() { }

	// RVA: 0x20D0678 Offset: 0x20CC678 VA: 0x20D0678
	public void SetAlphaRecursive(float val, bool rebuildList) { }

	// RVA: 0x20D074C Offset: 0x20CC74C VA: 0x20D074C
	public UIDrawCall.Clipping get_clipping() { }

	// RVA: 0x20D0754 Offset: 0x20CC754 VA: 0x20D0754
	public void set_clipping(UIDrawCall.Clipping value) { }

	// RVA: 0x20D0A80 Offset: 0x20CCA80 VA: 0x20D0A80
	public Vector4 get_clipRange() { }

	// RVA: 0x20D0A8C Offset: 0x20CCA8C VA: 0x20D0A8C
	public void set_clipRange(Vector4 value) { }

	// RVA: 0x20D0B50 Offset: 0x20CCB50 VA: 0x20D0B50
	public Vector2 get_clipSoftness() { }

	// RVA: 0x20D0B58 Offset: 0x20CCB58 VA: 0x20D0B58
	public void set_clipSoftness(Vector2 value) { }

	// RVA: 0x20D0B8C Offset: 0x20CCB8C VA: 0x20D0B8C
	private bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x20D0F9C Offset: 0x20CCF9C VA: 0x20D0F9C
	public bool IsVisible(Vector3 worldPos) { }

	// RVA: 0x20D1040 Offset: 0x20CD040 VA: 0x20D1040 Slot: 4
	protected virtual bool IsAlpha() { }

	// RVA: 0x20D1058 Offset: 0x20CD058 VA: 0x20D1058
	public bool IsVisible(UIWidget w) { }

	// RVA: 0x20D11A4 Offset: 0x20CD1A4 VA: 0x20D11A4
	public static void SetDirty() { }

	// RVA: 0x20D1200 Offset: 0x20CD200 VA: 0x20D1200
	private UIDrawCall GetDrawCall(int index, Material mat) { }

	// RVA: 0x20D16F0 Offset: 0x20CD6F0 VA: 0x20D16F0
	private void Awake() { }

	// RVA: 0x20D1730 Offset: 0x20CD730 VA: 0x20D1730
	private void Start() { }

	// RVA: 0x20D1844 Offset: 0x20CD844 VA: 0x20D1844
	private void OnEnable() { }

	// RVA: 0x20D18CC Offset: 0x20CD8CC VA: 0x20D18CC
	private void OnDisable() { }

	// RVA: 0x20D0E0C Offset: 0x20CCE0C VA: 0x20D0E0C
	private void UpdateTransformMatrix() { }

	// RVA: 0x20D0770 Offset: 0x20CC770 VA: 0x20D0770
	private void UpdateDrawcalls() { }

	// RVA: 0x20D1A7C Offset: 0x20CDA7C VA: 0x20D1A7C
	private void LateUpdate() { }

	// RVA: 0x20D15D4 Offset: 0x20CD5D4 VA: 0x20D15D4
	private static void DestroyDrawCall(UIDrawCall dc, int index) { }

	// RVA: 0x20D1DD8 Offset: 0x20CDDD8 VA: 0x20D1DD8
	private void UpdateLayers() { }

	// RVA: 0x20D206C Offset: 0x20CE06C VA: 0x20D206C
	private void UpdateWidgets() { }

	// RVA: 0x20D2D58 Offset: 0x20CED58 VA: 0x20D2D58
	public void Refresh() { }

	// RVA: 0x20D2DE4 Offset: 0x20CEDE4 VA: 0x20D2DE4
	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max) { }

	// RVA: 0x20D2E60 Offset: 0x20CEE60 VA: 0x20D2E60
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate) { }

	// RVA: 0x20D3058 Offset: 0x20CF058 VA: 0x20D3058
	public bool ConstrainTargetToBounds(Transform target, bool immediate) { }

	// RVA: 0x20D2BCC Offset: 0x20CEBCC VA: 0x20D2BCC
	private static void SetChildLayer(Transform t, int layer) { }

	// RVA: 0x20D30BC Offset: 0x20CF0BC VA: 0x20D30BC
	public static UIPanel Find(Transform trans, bool createIfMissing) { }

	// RVA: 0x20D32E4 Offset: 0x20CF2E4 VA: 0x20D32E4
	public static UIPanel Find(Transform trans) { }

	// RVA: 0x20D22C0 Offset: 0x20CE2C0 VA: 0x20D22C0
	private static void Fill() { }

	// RVA: 0x20D333C Offset: 0x20CF33C VA: 0x20D333C
	private void SubmitDrawCall(UIDrawCall dc) { }

	// RVA: 0x20D27D4 Offset: 0x20CE7D4 VA: 0x20D27D4
	private static bool Fill(UIDrawCall dc) { }

	// RVA: 0x20D34F4 Offset: 0x20CF4F4 VA: 0x20D34F4
	public void .ctor() { }

	// RVA: 0x20D35F8 Offset: 0x20CF5F8 VA: 0x20D35F8
	private static void .cctor() { }
}
