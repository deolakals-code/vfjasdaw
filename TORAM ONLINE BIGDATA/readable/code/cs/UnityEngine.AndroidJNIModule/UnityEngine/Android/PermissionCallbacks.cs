// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine.Android
public class PermissionCallbacks : AndroidJavaProxy // TypeDefIndex: 17080
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<string> PermissionGranted; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<string> PermissionDenied; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<string> PermissionDeniedAndDontAskAgain; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x37C712C Offset: 0x37C312C VA: 0x37C712C
	public void add_PermissionGranted(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x37C71DC Offset: 0x37C31DC VA: 0x37C71DC
	public void remove_PermissionGranted(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x37C728C Offset: 0x37C328C VA: 0x37C728C
	public void add_PermissionDenied(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x37C733C Offset: 0x37C333C VA: 0x37C733C
	public void remove_PermissionDenied(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x37C73EC Offset: 0x37C33EC VA: 0x37C73EC
	public void add_PermissionDeniedAndDontAskAgain(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0x37C749C Offset: 0x37C349C VA: 0x37C749C
	public void remove_PermissionDeniedAndDontAskAgain(Action<string> value) { }

	// RVA: 0x37C754C Offset: 0x37C354C VA: 0x37C754C
	public void .ctor() { }

	[Preserve]
	// RVA: 0x37C75B8 Offset: 0x37C35B8 VA: 0x37C75B8
	private void onPermissionGranted(string permissionName) { }

	[Preserve]
	// RVA: 0x37C75D4 Offset: 0x37C35D4 VA: 0x37C75D4
	private void onPermissionDenied(string permissionName) { }

	[Preserve]
	// RVA: 0x37C75F0 Offset: 0x37C35F0 VA: 0x37C75F0
	private void onPermissionDeniedAndDontAskAgain(string permissionName) { }
}
