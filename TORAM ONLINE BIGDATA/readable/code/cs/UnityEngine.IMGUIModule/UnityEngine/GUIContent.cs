// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIContent.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Serializable]
public class GUIContent // TypeDefIndex: 17026
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Texture m_Image; // 0x18
	[SerializeField]
	private string m_Tooltip; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action OnTextChanged; // 0x28
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x3805BDC Offset: 0x3801BDC VA: 0x3805BDC
	public string get_text() { }

	// RVA: 0x3805BE4 Offset: 0x3801BE4 VA: 0x3805BE4
	public void set_text(string value) { }

	// RVA: 0x3808E0C Offset: 0x3804E0C VA: 0x3808E0C
	public void set_image(Texture value) { }

	// RVA: 0x3807FE0 Offset: 0x3803FE0 VA: 0x3807FE0
	public string get_tooltip() { }

	// RVA: 0x3808E14 Offset: 0x3804E14 VA: 0x3808E14
	public void set_tooltip(string value) { }

	// RVA: 0x3808E1C Offset: 0x3804E1C VA: 0x3808E1C
	public void .ctor() { }

	// RVA: 0x3808E94 Offset: 0x3804E94 VA: 0x3808E94
	public void .ctor(string text) { }

	// RVA: 0x3808EF8 Offset: 0x3804EF8 VA: 0x3808EF8
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x3808FBC Offset: 0x3804FBC VA: 0x3808FBC
	public void .ctor(GUIContent src) { }

	// RVA: 0x3804E18 Offset: 0x3800E18 VA: 0x3804E18
	internal static GUIContent Temp(string t) { }

	// RVA: 0x3809078 Offset: 0x3805078 VA: 0x3809078
	internal static void ClearStaticCache() { }

	// RVA: 0x3809190 Offset: 0x3805190 VA: 0x3809190 Slot: 3
	public override string ToString() { }

	// RVA: 0x38091B0 Offset: 0x38051B0 VA: 0x38091B0
	private static void .cctor() { }
}
