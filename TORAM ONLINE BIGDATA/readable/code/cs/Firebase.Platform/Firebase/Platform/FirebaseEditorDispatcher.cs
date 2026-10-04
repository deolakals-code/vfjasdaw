// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Platform
internal sealed class FirebaseEditorDispatcher // TypeDefIndex: 17755
{
	// Properties
	private static Type EditorApplicationType { get; }
	public static bool EditorIsPlaying { get; }
	public static bool EditorIsPlayingOrWillChangePlaymode { get; }

	// Methods

	// RVA: 0x266C018 Offset: 0x2668018 VA: 0x266C018
	private static Type get_EditorApplicationType() { }

	// RVA: 0x266A27C Offset: 0x266627C VA: 0x266A27C
	public static bool get_EditorIsPlaying() { }

	// RVA: 0x266C0AC Offset: 0x26680AC VA: 0x266C0AC
	public static bool get_EditorIsPlayingOrWillChangePlaymode() { }

	// RVA: 0x266A81C Offset: 0x266681C VA: 0x266A81C
	public static void StartEditorUpdate() { }

	// RVA: 0x266C3B0 Offset: 0x26683B0 VA: 0x266C3B0
	public static void StopEditorUpdate() { }

	// RVA: 0x266C4B4 Offset: 0x26684B4 VA: 0x266C4B4
	public static void Update() { }

	// RVA: 0x266A394 Offset: 0x2666394 VA: 0x266A394
	public static void ListenToPlayState(bool start = True) { }

	// RVA: 0x266C50C Offset: 0x266850C VA: 0x266C50C
	private static void PlayModeStateChanged() { }

	// RVA: -1 Offset: -1
	private static void PlayModeStateChangedWithArg<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2424 Offset: 0x26BE424 VA: 0x26C2424
	|-FirebaseEditorDispatcher.PlayModeStateChangedWithArg<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x266C1C4 Offset: 0x26681C4 VA: 0x266C1C4
	private static void AddRemoveCallbackToField(FieldInfo eventField, Action callback, object target, bool add = True, string errorMessage) { }
}
