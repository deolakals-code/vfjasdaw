// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class Behaviour : Component // TypeDefIndex: 16343
{
	// Properties
	[RequiredByNativeCode]
	[NativeProperty]
	public bool enabled { get; set; }
	[NativeProperty]
	public bool isActiveAndEnabled { get; }

	// Methods

	// RVA: 0x37EA910 Offset: 0x37E6910 VA: 0x37EA910
	public bool get_enabled() { }

	// RVA: 0x37EA94C Offset: 0x37E694C VA: 0x37EA94C
	public void set_enabled(bool value) { }

	[NativeMethod("IsAddedToManager")]
	// RVA: 0x37EA990 Offset: 0x37E6990 VA: 0x37EA990
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x37EA9CC Offset: 0x37E69CC VA: 0x37EA9CC
	public void .ctor() { }
}
