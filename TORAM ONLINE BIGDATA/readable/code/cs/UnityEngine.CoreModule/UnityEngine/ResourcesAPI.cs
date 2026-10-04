// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class ResourcesAPI // TypeDefIndex: 16325
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static ResourcesAPI ActiveAPI { get; }
	public static ResourcesAPI overrideAPI { get; }

	// Methods

	// RVA: 0x37E9700 Offset: 0x37E5700 VA: 0x37E9700
	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x37E97A8 Offset: 0x37E57A8 VA: 0x37E97A8
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x37E9800 Offset: 0x37E5800 VA: 0x37E9800
	protected internal void .ctor() { }

	// RVA: 0x37E9808 Offset: 0x37E5808 VA: 0x37E9808 Slot: 4
	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x37E9844 Offset: 0x37E5844 VA: 0x37E9844 Slot: 5
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x37E9880 Offset: 0x37E5880 VA: 0x37E9880 Slot: 6
	protected internal virtual Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x37E98C4 Offset: 0x37E58C4 VA: 0x37E98C4 Slot: 7
	protected internal virtual void UnloadAsset(Object assetToUnload) { }

	// RVA: 0x37E9900 Offset: 0x37E5900 VA: 0x37E9900
	private static void .cctor() { }
}
