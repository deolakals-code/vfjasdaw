// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[UsedByNativeCode]
[Serializable]
public class RectOffset : IFormattable // TypeDefIndex: 16232
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("left", False, 1)]
	public int left { get; }
	[NativeProperty("right", False, 1)]
	public int right { get; }
	[NativeProperty("top", False, 1)]
	public int top { get; }
	[NativeProperty("bottom", False, 1)]
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x37D3044 Offset: 0x37CF044 VA: 0x37D3044
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x37D30B4 Offset: 0x37CF0B4 VA: 0x37D30B4
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x37D30F0 Offset: 0x37CF0F0 VA: 0x37D30F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x37D31EC Offset: 0x37CF1EC VA: 0x37D31EC Slot: 3
	public override string ToString() { }

	// RVA: 0x37D31FC Offset: 0x37CF1FC VA: 0x37D31FC Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37D3190 Offset: 0x37CF190 VA: 0x37D3190
	private void Destroy() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x37D308C Offset: 0x37CF08C VA: 0x37D308C
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x37D35B4 Offset: 0x37CF5B4 VA: 0x37D35B4
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x37D34C4 Offset: 0x37CF4C4 VA: 0x37D34C4
	public int get_left() { }

	// RVA: 0x37D3500 Offset: 0x37CF500 VA: 0x37D3500
	public int get_right() { }

	// RVA: 0x37D353C Offset: 0x37CF53C VA: 0x37D353C
	public int get_top() { }

	// RVA: 0x37D3578 Offset: 0x37CF578 VA: 0x37D3578
	public int get_bottom() { }

	// RVA: 0x37D35F0 Offset: 0x37CF5F0 VA: 0x37D35F0
	public int get_horizontal() { }

	// RVA: 0x37D362C Offset: 0x37CF62C VA: 0x37D362C
	public int get_vertical() { }

	// RVA: 0x37D3668 Offset: 0x37CF668 VA: 0x37D3668
	public Rect Remove(Rect rect) { }

	// RVA: 0x37D36CC Offset: 0x37CF6CC VA: 0x37D36CC
	private void Remove_Injected(ref Rect rect, out Rect ret) { }
}
