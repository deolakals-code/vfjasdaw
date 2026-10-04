// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 17037
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("textColor", False, 1)]
	public Color textColor { set; }

	// Methods

	// RVA: 0x380C768 Offset: 0x3808768 VA: 0x380C768
	public void set_textColor(Color value) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x380CE48 Offset: 0x3808E48 VA: 0x380CE48
	private static IntPtr Init() { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x380CE70 Offset: 0x3808E70 VA: 0x380CE70
	private void Cleanup() { }

	// RVA: 0x380CEAC Offset: 0x3808EAC VA: 0x380CEAC
	public void .ctor() { }

	// RVA: 0x380CEF4 Offset: 0x3808EF4 VA: 0x380CEF4
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x380CF30 Offset: 0x3808F30 VA: 0x380CF30
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x380CFA8 Offset: 0x3808FA8 VA: 0x380CFA8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x380CE04 Offset: 0x3808E04 VA: 0x380CE04
	private void set_textColor_Injected(ref Color value) { }
}
