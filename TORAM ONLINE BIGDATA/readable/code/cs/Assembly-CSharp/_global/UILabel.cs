// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget, IUILabel // TypeDefIndex: 169
{
	// Fields
	[CompilerGenerated]
	private int <a>k__BackingField; // 0x104
	[SerializeField]
	[HideInInspector]
	protected UIFont mFont; // 0x108
	[SerializeField]
	[HideInInspector]
	protected string mText; // 0x110
	[SerializeField]
	[HideInInspector]
	protected bool mEncoding; // 0x118
	[HideInInspector]
	[SerializeField]
	protected int mMaxLineCount; // 0x11C
	[HideInInspector]
	[SerializeField]
	protected bool mPassword; // 0x120
	[SerializeField]
	[HideInInspector]
	protected bool mShowLastChar; // 0x121
	[HideInInspector]
	[SerializeField]
	protected UILabel.Effect mEffectStyle; // 0x124
	[SerializeField]
	[HideInInspector]
	protected Color mEffectColor; // 0x128
	[SerializeField]
	[HideInInspector]
	protected UIFont.SymbolStyle mSymbols; // 0x138
	[SerializeField]
	[HideInInspector]
	protected Vector2 mEffectDistance; // 0x13C
	[SerializeField]
	[HideInInspector]
	protected UILabel.Overflow mOverflow; // 0x144
	[HideInInspector]
	[SerializeField]
	protected bool mShrinkToFit; // 0x148
	[HideInInspector]
	[SerializeField]
	protected int mMaxLineWidth; // 0x14C
	[HideInInspector]
	[SerializeField]
	protected int mMaxLineHeight; // 0x150
	[HideInInspector]
	[SerializeField]
	protected float mLineWidth; // 0x154
	[HideInInspector]
	[SerializeField]
	protected bool mMultiline; // 0x158
	protected bool mShouldBeProcessed; // 0x159
	protected string mProcessedText; // 0x160
	public char wordWrapSeparatorChar; // 0x168
	protected bool mPremultiply; // 0x16A
	protected Vector2 mSize; // 0x16C
	protected float mScale; // 0x174
	protected int mLastWidth; // 0x178
	protected int mLastHeight; // 0x17C

	// Properties
	public int a { get; set; }
	private bool hasChanged { get; set; }
	public override Material material { get; }
	public UIFont font { get; set; }
	public string text { get; set; }
	public bool supportEncoding { get; set; }
	public UIFont.SymbolStyle symbolStyle { get; set; }
	public UILabel.Overflow overflowMethod { get; set; }
	[Obsolete("Use 'width' instead")]
	public int lineWidth { get; set; }
	[Obsolete("Use 'height' instead")]
	public int lineHeight { get; set; }
	public bool multiLine { get; set; }
	public int maxLineCount { get; set; }
	public bool password { get; set; }
	public bool showLastPasswordChar { get; set; }
	public UILabel.Effect effectStyle { get; set; }
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
	public bool shrinkToFit { get; set; }
	public string processedText { get; }
	public Vector2 printedSize { get; }
	public override Vector2 localSize { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FD4B68 Offset: 0x1FD0B68 VA: 0x1FD4B68
	public int get_a() { }

	[CompilerGenerated]
	// RVA: 0x1FD4B70 Offset: 0x1FD0B70 VA: 0x1FD4B70
	public void set_a(int value) { }

	// RVA: 0x1FD4B78 Offset: 0x1FD0B78 VA: 0x1FD4B78
	private bool get_hasChanged() { }

	// RVA: 0x1FD4B80 Offset: 0x1FD0B80 VA: 0x1FD4B80
	private void set_hasChanged(bool value) { }

	// RVA: 0x1FD4B9C Offset: 0x1FD0B9C VA: 0x1FD4B9C Slot: 14
	public override Material get_material() { }

	// RVA: 0x1FD4C20 Offset: 0x1FD0C20 VA: 0x1FD4C20
	public UIFont get_font() { }

	// RVA: 0x1FC7648 Offset: 0x1FC3648 VA: 0x1FC7648
	public void set_font(UIFont value) { }

	// RVA: 0x1FD4C28 Offset: 0x1FD0C28 VA: 0x1FD4C28 Slot: 30
	public string get_text() { }

	// RVA: 0x1FD1FCC Offset: 0x1FCDFCC VA: 0x1FD1FCC Slot: 31
	public void set_text(string value) { }

	// RVA: 0x1FD4C30 Offset: 0x1FD0C30 VA: 0x1FD4C30
	public bool get_supportEncoding() { }

	// RVA: 0x1FD1ED0 Offset: 0x1FCDED0 VA: 0x1FD1ED0
	public void set_supportEncoding(bool value) { }

	// RVA: 0x1FD4C38 Offset: 0x1FD0C38 VA: 0x1FD4C38
	public UIFont.SymbolStyle get_symbolStyle() { }

	// RVA: 0x1FD4C40 Offset: 0x1FD0C40 VA: 0x1FD4C40
	public void set_symbolStyle(UIFont.SymbolStyle value) { }

	// RVA: 0x1FD4C60 Offset: 0x1FD0C60 VA: 0x1FD4C60
	public UILabel.Overflow get_overflowMethod() { }

	// RVA: 0x1FD4C68 Offset: 0x1FD0C68 VA: 0x1FD4C68
	public void set_overflowMethod(UILabel.Overflow value) { }

	// RVA: 0x1FD4C88 Offset: 0x1FD0C88 VA: 0x1FD4C88
	public int get_lineWidth() { }

	// RVA: 0x1FD4C90 Offset: 0x1FD0C90 VA: 0x1FD4C90
	public void set_lineWidth(int value) { }

	// RVA: 0x1FD4C98 Offset: 0x1FD0C98 VA: 0x1FD4C98
	public int get_lineHeight() { }

	// RVA: 0x1FD4CA0 Offset: 0x1FD0CA0 VA: 0x1FD4CA0
	public void set_lineHeight(int value) { }

	// RVA: 0x1FD396C Offset: 0x1FCF96C VA: 0x1FD396C
	public bool get_multiLine() { }

	// RVA: 0x1FD4CA8 Offset: 0x1FD0CA8 VA: 0x1FD4CA8
	public void set_multiLine(bool value) { }

	// RVA: 0x1FD4CE4 Offset: 0x1FD0CE4 VA: 0x1FD4CE4
	public int get_maxLineCount() { }

	// RVA: 0x1FD24FC Offset: 0x1FCE4FC VA: 0x1FD24FC
	public void set_maxLineCount(int value) { }

	// RVA: 0x1FD4CEC Offset: 0x1FD0CEC VA: 0x1FD4CEC
	public bool get_password() { }

	// RVA: 0x1FD24C8 Offset: 0x1FCE4C8 VA: 0x1FD24C8
	public void set_password(bool value) { }

	// RVA: 0x1FD4CF4 Offset: 0x1FD0CF4 VA: 0x1FD4CF4
	public bool get_showLastPasswordChar() { }

	// RVA: 0x1FD20F8 Offset: 0x1FCE0F8 VA: 0x1FD20F8
	public void set_showLastPasswordChar(bool value) { }

	// RVA: 0x1FD4CFC Offset: 0x1FD0CFC VA: 0x1FD4CFC Slot: 36
	public UILabel.Effect get_effectStyle() { }

	// RVA: 0x1FD4D04 Offset: 0x1FD0D04 VA: 0x1FD4D04 Slot: 37
	public void set_effectStyle(UILabel.Effect value) { }

	// RVA: 0x1FD4D24 Offset: 0x1FD0D24 VA: 0x1FD4D24 Slot: 38
	public Color get_effectColor() { }

	// RVA: 0x1FD4D38 Offset: 0x1FD0D38 VA: 0x1FD4D38 Slot: 39
	public void set_effectColor(Color value) { }

	// RVA: 0x1FD4DD8 Offset: 0x1FD0DD8 VA: 0x1FD4DD8 Slot: 40
	public Vector2 get_effectDistance() { }

	// RVA: 0x1FD4DE4 Offset: 0x1FD0DE4 VA: 0x1FD4DE4 Slot: 41
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x1FD4E28 Offset: 0x1FD0E28 VA: 0x1FD4E28
	public bool get_shrinkToFit() { }

	// RVA: 0x1FD4E38 Offset: 0x1FD0E38 VA: 0x1FD4E38
	public void set_shrinkToFit(bool value) { }

	// RVA: 0x1FD3B50 Offset: 0x1FCFB50 VA: 0x1FD3B50
	public string get_processedText() { }

	// RVA: 0x1FD4E60 Offset: 0x1FD0E60 VA: 0x1FD4E60 Slot: 47
	public Vector2 get_printedSize() { }

	// RVA: 0x1FD4E8C Offset: 0x1FD0E8C VA: 0x1FD4E8C Slot: 13
	public override Vector2 get_localSize() { }

	// RVA: 0x1FD4EB8 Offset: 0x1FD0EB8 VA: 0x1FD4EB8 Slot: 20
	protected override void OnEnable() { }

	// RVA: 0x1FD5004 Offset: 0x1FD1004 VA: 0x1FD5004 Slot: 23
	protected override void OnDisable() { }

	// RVA: 0x1FD5150 Offset: 0x1FD1150 VA: 0x1FD5150 Slot: 21
	protected override void UpgradeFrom265() { }

	// RVA: 0x1FD5ED0 Offset: 0x1FD1ED0 VA: 0x1FD5ED0 Slot: 28
	protected override void OnStart() { }

	// RVA: 0x1FD6108 Offset: 0x1FD2108 VA: 0x1FD6108 Slot: 18
	public override void MarkAsChanged() { }

	// RVA: 0x1FD4E58 Offset: 0x1FD0E58 VA: 0x1FD4E58
	private void ProcessText() { }

	// RVA: 0x1FD5424 Offset: 0x1FD1424 VA: 0x1FD5424
	private void ProcessText(bool legacyMode) { }

	// RVA: 0x1FD611C Offset: 0x1FD211C VA: 0x1FD611C Slot: 24
	public override void MakePixelPerfect() { }

	// RVA: 0x1FD669C Offset: 0x1FD269C VA: 0x1FD669C
	protected void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y, float valpha) { }

	// RVA: 0x1FD6980 Offset: 0x1FD2980 VA: 0x1FD6980 Slot: 29
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float valpha) { }

	// RVA: 0x1FD6F2C Offset: 0x1FD2F2C VA: 0x1FD6F2C
	public void .ctor() { }

	// RVA: 0x1FD703C Offset: 0x1FD303C VA: 0x1FD703C Slot: 43
	private bool IUILabel.get_enabled() { }

	// RVA: 0x1FD7044 Offset: 0x1FD3044 VA: 0x1FD7044 Slot: 44
	private void IUILabel.set_enabled(bool value) { }
}
