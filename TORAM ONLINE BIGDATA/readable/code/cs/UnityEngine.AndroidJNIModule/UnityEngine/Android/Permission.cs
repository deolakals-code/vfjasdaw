// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public struct Permission // TypeDefIndex: 17081
{
	// Fields
	private static AndroidJavaObject m_UnityPermissions; // 0x0

	// Methods

	// RVA: 0x37C7614 Offset: 0x37C3614 VA: 0x37C7614
	private static AndroidJavaObject GetUnityPermissions() { }

	// RVA: 0x37C76D4 Offset: 0x37C36D4 VA: 0x37C76D4
	public static bool HasUserAuthorizedPermission(string permission) { }

	// RVA: 0x37C780C Offset: 0x37C380C VA: 0x37C780C
	public static void RequestUserPermission(string permission) { }

	// RVA: 0x37C7898 Offset: 0x37C3898 VA: 0x37C7898
	public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks) { }
}
