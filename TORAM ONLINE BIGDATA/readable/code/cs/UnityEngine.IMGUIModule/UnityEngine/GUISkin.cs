// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[ExecuteInEditMode]
[RequiredByNativeCode]
[AssetFileNameExtension("guiskin", new[] {  })]
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 17035
{
	// Fields
	[SerializeField]
	private Font m_Font; // 0x18
	[SerializeField]
	private GUIStyle m_box; // 0x20
	[SerializeField]
	private GUIStyle m_button; // 0x28
	[SerializeField]
	private GUIStyle m_toggle; // 0x30
	[SerializeField]
	private GUIStyle m_label; // 0x38
	[SerializeField]
	private GUIStyle m_textField; // 0x40
	[SerializeField]
	private GUIStyle m_textArea; // 0x48
	[SerializeField]
	private GUIStyle m_window; // 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField]
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x380B184 Offset: 0x3807184 VA: 0x380B184
	public void .ctor() { }

	// RVA: 0x380B25C Offset: 0x380725C VA: 0x380B25C
	internal void OnEnable() { }

	// RVA: 0x380B2DC Offset: 0x38072DC VA: 0x380B2DC
	internal static void CleanupRoots() { }

	// RVA: 0x38074AC Offset: 0x38034AC VA: 0x38074AC
	public Font get_font() { }

	// RVA: 0x380B344 Offset: 0x3807344 VA: 0x380B344
	public void set_font(Font value) { }

	// RVA: 0x380B478 Offset: 0x3807478 VA: 0x380B478
	public GUIStyle get_box() { }

	// RVA: 0x380B480 Offset: 0x3807480 VA: 0x380B480
	public void set_box(GUIStyle value) { }

	// RVA: 0x3804ECC Offset: 0x3800ECC VA: 0x3804ECC
	public GUIStyle get_label() { }

	// RVA: 0x380B49C Offset: 0x380749C VA: 0x380B49C
	public void set_label(GUIStyle value) { }

	// RVA: 0x3809670 Offset: 0x3805670 VA: 0x3809670
	public GUIStyle get_textField() { }

	// RVA: 0x380B4B8 Offset: 0x38074B8 VA: 0x380B4B8
	public void set_textField(GUIStyle value) { }

	// RVA: 0x380B4D4 Offset: 0x38074D4 VA: 0x380B4D4
	public GUIStyle get_textArea() { }

	// RVA: 0x380B4DC Offset: 0x38074DC VA: 0x380B4DC
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x3809520 Offset: 0x3805520 VA: 0x3809520
	public GUIStyle get_button() { }

	// RVA: 0x380B4F8 Offset: 0x38074F8 VA: 0x380B4F8
	public void set_button(GUIStyle value) { }

	// RVA: 0x380B514 Offset: 0x3807514 VA: 0x380B514
	public GUIStyle get_toggle() { }

	// RVA: 0x380B51C Offset: 0x380751C VA: 0x380B51C
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x380B538 Offset: 0x3807538 VA: 0x380B538
	public GUIStyle get_window() { }

	// RVA: 0x380B540 Offset: 0x3807540 VA: 0x380B540
	public void set_window(GUIStyle value) { }

	// RVA: 0x380B55C Offset: 0x380755C VA: 0x380B55C
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x380B564 Offset: 0x3807564 VA: 0x380B564
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x380B580 Offset: 0x3807580 VA: 0x380B580
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x380B588 Offset: 0x3807588 VA: 0x380B588
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x380B5A4 Offset: 0x38075A4 VA: 0x380B5A4
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x380B5AC Offset: 0x38075AC VA: 0x380B5AC
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x380B5C8 Offset: 0x38075C8 VA: 0x380B5C8
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x380B5D0 Offset: 0x38075D0 VA: 0x380B5D0
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x380B5EC Offset: 0x38075EC VA: 0x380B5EC
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x380B5F4 Offset: 0x38075F4 VA: 0x380B5F4
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x380B610 Offset: 0x3807610 VA: 0x380B610
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x380B618 Offset: 0x3807618 VA: 0x380B618
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x380B634 Offset: 0x3807634 VA: 0x380B634
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x380B63C Offset: 0x380763C VA: 0x380B63C
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x380B658 Offset: 0x3807658 VA: 0x380B658
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x380B660 Offset: 0x3807660 VA: 0x380B660
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x380B67C Offset: 0x380767C VA: 0x380B67C
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x380B684 Offset: 0x3807684 VA: 0x380B684
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x380B6A0 Offset: 0x38076A0 VA: 0x380B6A0
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x380B6A8 Offset: 0x38076A8 VA: 0x380B6A8
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x380B6C4 Offset: 0x38076C4 VA: 0x380B6C4
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x380B6CC Offset: 0x38076CC VA: 0x380B6CC
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x380B6E8 Offset: 0x38076E8 VA: 0x380B6E8
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x380B6F0 Offset: 0x38076F0 VA: 0x380B6F0
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x380B70C Offset: 0x380770C VA: 0x380B70C
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x380B714 Offset: 0x3807714 VA: 0x380B714
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x380B730 Offset: 0x3807730 VA: 0x380B730
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x380B738 Offset: 0x3807738 VA: 0x380B738
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x380B754 Offset: 0x3807754 VA: 0x380B754
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x380B75C Offset: 0x380775C VA: 0x380B75C
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x380B778 Offset: 0x3807778 VA: 0x380B778
	public GUIStyle get_scrollView() { }

	// RVA: 0x380B780 Offset: 0x3807780 VA: 0x380B780
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x380B79C Offset: 0x380779C VA: 0x380B79C
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x380B7A4 Offset: 0x38077A4 VA: 0x380B7A4
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x38070C8 Offset: 0x38030C8 VA: 0x38070C8
	public GUISettings get_settings() { }

	// RVA: 0x380B7C0 Offset: 0x38077C0 VA: 0x380B7C0
	internal static GUIStyle get_error() { }

	// RVA: 0x380B260 Offset: 0x3807260 VA: 0x380B260
	internal void Apply() { }

	// RVA: 0x380B95C Offset: 0x380795C VA: 0x380B95C
	private void BuildStyleCache() { }

	// RVA: 0x380C7BC Offset: 0x38087BC VA: 0x380C7BC
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x380CA2C Offset: 0x3808A2C VA: 0x380CA2C
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x3804C70 Offset: 0x3800C70 VA: 0x3804C70
	internal void MakeCurrent() { }

	// RVA: 0x380CAB4 Offset: 0x3808AB4 VA: 0x380CAB4
	public IEnumerator GetEnumerator() { }
}
