// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIWidget : MonoBehaviour, IUIWidget // TypeDefIndex: 93
{
	// Fields
	public static BetterList<UIWidget> list; // 0x0
	[SerializeField]
	[HideInInspector]
	protected Color mColor; // 0x20
	[SerializeField]
	[HideInInspector]
	protected UIWidget.Pivot mPivot; // 0x30
	[HideInInspector]
	[SerializeField]
	protected int mWidth; // 0x34
	[SerializeField]
	[HideInInspector]
	protected int mHeight; // 0x38
	[HideInInspector]
	[SerializeField]
	protected int mDepth; // 0x3C
	protected GameObject mGo; // 0x40
	protected Transform mTrans; // 0x48
	protected UIPanel mPanel; // 0x50
	protected bool mChanged; // 0x58
	protected bool mPlayMode; // 0x59
	private bool mStarted; // 0x5A
	private Vector3 mDiffPos; // 0x5C
	private Quaternion mDiffRot; // 0x68
	private Vector3 mDiffScale; // 0x78
	private Matrix4x4 mLocalToPanel; // 0x84
	private bool mVisibleByPanel; // 0xC4
	private float mLastAlpha; // 0xC8
	private float vertexAlpha; // 0xCC
	[CompilerGenerated]
	private UIDrawCall <drawCall>k__BackingField; // 0xD0
	private UIGeometry mGeom; // 0xD8
	private Vector3[] mCorners; // 0xE0
	private bool mForceVisible; // 0xE8
	private Vector3 mOldV0; // 0xEC
	private Vector3 mOldV1; // 0xF8

	// Properties
	public float VAlpha { set; }
	public UIDrawCall drawCall { get; set; }
	public bool isVisible { get; }
	public int width { get; set; }
	public int height { get; set; }
	public virtual Color color { get; set; }
	public float alpha { get; set; }
	public float finalAlpha { get; }
	public UIWidget.Pivot pivot { get; set; }
	public int depth { get; set; }
	public Vector3[] localCorners { get; }
	public virtual Vector2 localSize { get; }
	public Vector3[] worldCorners { get; }
	public Vector3[] innerWorldCorners { get; }
	public bool hasVertices { get; }
	public Vector2 pivotOffset { get; }
	public GameObject cachedGameObject { get; }
	public Transform cachedTransform { get; }
	public virtual Material material { get; set; }
	public virtual Texture mainTexture { get; set; }
	public UIPanel panel { get; set; }
	[Obsolete("There is no relative scale anymore. Widgets now have width and height instead")]
	public Vector2 relativeSize { get; }
	public virtual int minWidth { get; }
	public virtual int minHeight { get; }
	public virtual Vector4 border { get; }

	// Methods

	// RVA: 0x173587C Offset: 0x173187C VA: 0x173587C
	public void set_VAlpha(float value) { }

	[CompilerGenerated]
	// RVA: 0x17358A8 Offset: 0x17318A8 VA: 0x17358A8
	public UIDrawCall get_drawCall() { }

	[CompilerGenerated]
	// RVA: 0x17358B0 Offset: 0x17318B0 VA: 0x17358B0
	public void set_drawCall(UIDrawCall value) { }

	// RVA: 0x17358B8 Offset: 0x17318B8 VA: 0x17358B8
	public bool get_isVisible() { }

	// RVA: 0x17359A0 Offset: 0x17319A0 VA: 0x17359A0 Slot: 8
	public int get_width() { }

	// RVA: 0x1725DA4 Offset: 0x1721DA4 VA: 0x1725DA4
	public void set_width(int value) { }

	// RVA: 0x17359A8 Offset: 0x17319A8 VA: 0x17359A8
	public int get_height() { }

	// RVA: 0x1725E08 Offset: 0x1721E08 VA: 0x1725E08
	public void set_height(int value) { }

	// RVA: 0x17359B0 Offset: 0x17319B0 VA: 0x17359B0 Slot: 9
	public virtual Color get_color() { }

	// RVA: 0x17359BC Offset: 0x17319BC VA: 0x17359BC Slot: 10
	public virtual void set_color(Color value) { }

	// RVA: 0x1735A48 Offset: 0x1731A48 VA: 0x1735A48 Slot: 4
	public float get_alpha() { }

	// RVA: 0x1727838 Offset: 0x1723838 VA: 0x1727838 Slot: 5
	public void set_alpha(float value) { }

	// RVA: 0x17358E8 Offset: 0x17318E8 VA: 0x17358E8
	public float get_finalAlpha() { }

	// RVA: 0x1735C1C Offset: 0x1731C1C VA: 0x1735C1C Slot: 11
	public UIWidget.Pivot get_pivot() { }

	// RVA: 0x1735C24 Offset: 0x1731C24 VA: 0x1735C24 Slot: 12
	public void set_pivot(UIWidget.Pivot value) { }

	// RVA: 0x1735E44 Offset: 0x1731E44 VA: 0x1735E44
	public int get_depth() { }

	// RVA: 0x1730DB8 Offset: 0x172CDB8 VA: 0x1730DB8
	public void set_depth(int value) { }

	// RVA: 0x17250D0 Offset: 0x17210D0 VA: 0x17250D0
	public Vector3[] get_localCorners() { }

	// RVA: 0x1735E54 Offset: 0x1731E54 VA: 0x1735E54 Slot: 13
	public virtual Vector2 get_localSize() { }

	// RVA: 0x172DDD4 Offset: 0x1729DD4 VA: 0x172DDD4
	public Vector3[] get_worldCorners() { }

	// RVA: 0x172E494 Offset: 0x172A494 VA: 0x172E494
	public Vector3[] get_innerWorldCorners() { }

	// RVA: 0x1735E8C Offset: 0x1731E8C VA: 0x1735E8C
	public bool get_hasVertices() { }

	// RVA: 0x1735E4C Offset: 0x1731E4C VA: 0x1735E4C
	public Vector2 get_pivotOffset() { }

	// RVA: 0x1730C38 Offset: 0x172CC38 VA: 0x1730C38
	public GameObject get_cachedGameObject() { }

	// RVA: 0x172E624 Offset: 0x172A624 VA: 0x172E624
	public Transform get_cachedTransform() { }

	// RVA: 0x1735EC0 Offset: 0x1731EC0 VA: 0x1735EC0 Slot: 14
	public virtual Material get_material() { }

	// RVA: 0x1735EC8 Offset: 0x1731EC8 VA: 0x1735EC8 Slot: 15
	public virtual void set_material(Material value) { }

	// RVA: 0x1735F48 Offset: 0x1731F48 VA: 0x1735F48 Slot: 16
	public virtual Texture get_mainTexture() { }

	// RVA: 0x1735FE8 Offset: 0x1731FE8 VA: 0x1735FE8 Slot: 17
	public virtual void set_mainTexture(Texture value) { }

	// RVA: 0x1736068 Offset: 0x1732068 VA: 0x1736068
	public UIPanel get_panel() { }

	// RVA: 0x17360DC Offset: 0x17320DC VA: 0x17360DC
	public void set_panel(UIPanel value) { }

	// RVA: 0x17360E4 Offset: 0x17320E4 VA: 0x17360E4
	public Vector2 get_relativeSize() { }

	// RVA: 0x1736124 Offset: 0x1732124 VA: 0x1736124
	public static BetterList<UIWidget> Raycast(GameObject root, Vector2 mousePos) { }

	// RVA: 0x17363C4 Offset: 0x17323C4 VA: 0x17363C4
	public static int CompareFunc(UIWidget left, UIWidget right) { }

	// RVA: 0x17363E8 Offset: 0x17323E8 VA: 0x17363E8
	public Bounds CalculateBounds() { }

	// RVA: 0x173641C Offset: 0x173241C VA: 0x173641C
	public Bounds CalculateBounds(Transform relativeParent) { }

	// RVA: 0x17366C8 Offset: 0x17326C8 VA: 0x17366C8
	private void SetDirty() { }

	// RVA: 0x17367B8 Offset: 0x17327B8 VA: 0x17367B8
	protected void RemoveFromPanel() { }

	// RVA: 0x173589C Offset: 0x173189C VA: 0x173589C
	public void MarkAsChangedLite() { }

	// RVA: 0x1736860 Offset: 0x1732860 VA: 0x1736860 Slot: 18
	public virtual void MarkAsChanged() { }

	// RVA: 0x1735A50 Offset: 0x1731A50 VA: 0x1735A50
	public void CreatePanel() { }

	// RVA: 0x17369AC Offset: 0x17329AC VA: 0x17369AC
	public void CheckLayer() { }

	// RVA: 0x173267C Offset: 0x172E67C VA: 0x173267C
	public void ParentHasChanged() { }

	// RVA: 0x1736AA4 Offset: 0x1732AA4 VA: 0x1736AA4 Slot: 19
	protected virtual void Awake() { }

	// RVA: 0x1736B20 Offset: 0x1732B20 VA: 0x1736B20 Slot: 20
	protected virtual void OnEnable() { }

	// RVA: 0x1736C40 Offset: 0x1732C40 VA: 0x1736C40 Slot: 21
	protected virtual void UpgradeFrom265() { }

	// RVA: 0x1736F3C Offset: 0x1732F3C VA: 0x1736F3C
	private void Start() { }

	// RVA: 0x1736F68 Offset: 0x1732F68 VA: 0x1736F68 Slot: 22
	public virtual void Update() { }

	// RVA: 0x1736FE0 Offset: 0x1732FE0 VA: 0x1736FE0 Slot: 23
	protected virtual void OnDisable() { }

	// RVA: 0x1737068 Offset: 0x1733068 VA: 0x1737068
	private void OnDestroy() { }

	// RVA: 0x173706C Offset: 0x173306C VA: 0x173706C
	private bool HasTransformChanged() { }

	// RVA: 0x17370B8 Offset: 0x17330B8 VA: 0x17370B8
	public bool UpdateGeometry(UIPanel p, bool forceVisible) { }

	// RVA: 0x173764C Offset: 0x173364C VA: 0x173764C
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t) { }

	// RVA: 0x1737664 Offset: 0x1733664 VA: 0x1737664 Slot: 24
	public virtual void MakePixelPerfect() { }

	// RVA: 0x1737868 Offset: 0x1733868 VA: 0x1737868 Slot: 25
	public virtual int get_minWidth() { }

	// RVA: 0x1737870 Offset: 0x1733870 VA: 0x1737870 Slot: 26
	public virtual int get_minHeight() { }

	// RVA: 0x1737878 Offset: 0x1733878 VA: 0x1737878 Slot: 27
	public virtual Vector4 get_border() { }

	// RVA: 0x17378BC Offset: 0x17338BC VA: 0x17378BC Slot: 28
	protected virtual void OnStart() { }

	// RVA: 0x17378C0 Offset: 0x17338C0 VA: 0x17378C0 Slot: 29
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x17378C4 Offset: 0x17338C4 VA: 0x17378C4
	protected void .ctor() { }

	// RVA: 0x173798C Offset: 0x173398C VA: 0x173798C
	private static void .cctor() { }
}
