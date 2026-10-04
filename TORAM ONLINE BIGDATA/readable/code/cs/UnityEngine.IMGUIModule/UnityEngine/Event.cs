// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[StaticAccessor("GUIEvent", 2)]
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
public sealed class Event // TypeDefIndex: 17019
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static Event s_Current; // 0x0
	private static Event s_MasterEvent; // 0x8

	// Properties
	[NativeProperty("type", False, 1)]
	public EventType rawType { get; }
	[NativeProperty("mousePosition", False, 1)]
	public Vector2 mousePosition { get; }
	[NativeProperty("pointerType", False, 1)]
	public PointerType pointerType { get; }
	[NativeProperty("modifiers", False, 1)]
	public EventModifiers modifiers { get; set; }
	[NativeProperty("clickCount", False, 1)]
	public int clickCount { get; }
	[NativeProperty("character", False, 1)]
	public char character { get; set; }
	[NativeProperty("keycode", False, 1)]
	public KeyCode keyCode { get; set; }
	[NativeProperty("displayIndex", False, 1)]
	public int displayIndex { set; }
	public EventType type { get; set; }
	public string commandName { get; }
	public bool shift { get; }
	public bool control { get; }
	public bool alt { get; }
	public bool command { get; }
	public static Event current { get; }
	public bool isKey { get; }
	public bool isMouse { get; }
	internal bool isDirectManipulationDevice { get; }

	// Methods

	// RVA: 0x3800DCC Offset: 0x37FCDCC VA: 0x3800DCC
	public EventType get_rawType() { }

	// RVA: 0x3800E08 Offset: 0x37FCE08 VA: 0x3800E08
	public Vector2 get_mousePosition() { }

	// RVA: 0x3800E98 Offset: 0x37FCE98 VA: 0x3800E98
	public PointerType get_pointerType() { }

	// RVA: 0x3800ED4 Offset: 0x37FCED4 VA: 0x3800ED4
	public EventModifiers get_modifiers() { }

	// RVA: 0x3800F10 Offset: 0x37FCF10 VA: 0x3800F10
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x3800F54 Offset: 0x37FCF54 VA: 0x3800F54
	public int get_clickCount() { }

	// RVA: 0x3800F90 Offset: 0x37FCF90 VA: 0x3800F90
	public char get_character() { }

	// RVA: 0x3800FCC Offset: 0x37FCFCC VA: 0x3800FCC
	public void set_character(char value) { }

	// RVA: 0x3801010 Offset: 0x37FD010 VA: 0x3801010
	public KeyCode get_keyCode() { }

	// RVA: 0x380104C Offset: 0x37FD04C VA: 0x380104C
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x3801090 Offset: 0x37FD090 VA: 0x3801090
	public void set_displayIndex(int value) { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	// RVA: 0x38010D4 Offset: 0x37FD0D4 VA: 0x38010D4
	public EventType get_type() { }

	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	// RVA: 0x3801110 Offset: 0x37FD110 VA: 0x3801110
	public void set_type(EventType value) { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	// RVA: 0x3801154 Offset: 0x37FD154 VA: 0x3801154
	public string get_commandName() { }

	[NativeMethod("Use")]
	// RVA: 0x3801190 Offset: 0x37FD190 VA: 0x3801190
	private void Internal_Use() { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x38011CC Offset: 0x37FD1CC VA: 0x38011CC
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x3801208 Offset: 0x37FD208 VA: 0x3801208
	private static void Internal_Destroy(IntPtr ptr) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x3801244 Offset: 0x37FD244 VA: 0x3801244
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x3801288 Offset: 0x37FD288 VA: 0x3801288
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x38012C4 Offset: 0x37FD2C4 VA: 0x38012C4
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x3801424 Offset: 0x37FD424 VA: 0x3801424
	public void .ctor() { }

	// RVA: 0x38013D4 Offset: 0x37FD3D4 VA: 0x38013D4
	public void .ctor(int displayIndex) { }

	// RVA: 0x3801470 Offset: 0x37FD470 VA: 0x3801470 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3801548 Offset: 0x37FD548 VA: 0x3801548
	public bool get_shift() { }

	// RVA: 0x380158C Offset: 0x37FD58C VA: 0x380158C
	public bool get_control() { }

	// RVA: 0x38015D0 Offset: 0x37FD5D0 VA: 0x38015D0
	public bool get_alt() { }

	// RVA: 0x3801614 Offset: 0x37FD614 VA: 0x3801614
	public bool get_command() { }

	// RVA: 0x3801658 Offset: 0x37FD658 VA: 0x3801658
	public static Event get_current() { }

	// RVA: 0x38016A0 Offset: 0x37FD6A0 VA: 0x38016A0
	public bool get_isKey() { }

	// RVA: 0x38016EC Offset: 0x37FD6EC VA: 0x38016EC
	public bool get_isMouse() { }

	// RVA: 0x3801750 Offset: 0x37FD750 VA: 0x3801750
	internal bool get_isDirectManipulationDevice() { }

	// RVA: 0x38017CC Offset: 0x37FD7CC VA: 0x38017CC
	public static Event KeyboardEvent(string key) { }

	// RVA: 0x38037AC Offset: 0x37FF7AC VA: 0x38037AC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x38038AC Offset: 0x37FF8AC VA: 0x38038AC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3803B18 Offset: 0x37FFB18 VA: 0x3803B18 Slot: 3
	public override string ToString() { }

	// RVA: 0x3804394 Offset: 0x3800394 VA: 0x3804394
	public void Use() { }

	// RVA: 0x3800E54 Offset: 0x37FCE54 VA: 0x3800E54
	private void get_mousePosition_Injected(out Vector2 ret) { }
}
