// Assembly: UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 17770
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x38170D0 Offset: 0x38130D0 VA: 0x38170D0
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x3817294 Offset: 0x3813294 VA: 0x3817294
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x38172F0 Offset: 0x38132F0 VA: 0x38172F0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x3817C98 Offset: 0x3813C98 VA: 0x3817C98
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x3818244 Offset: 0x3814244 VA: 0x3818244
	private static void .cctor() { }
}
