// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
[Serializable]
public struct Scene // TypeDefIndex: 16440
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }

	// Methods

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x37F6CC8 Offset: 0x37F2CC8 VA: 0x37F6CC8
	private static string GetNameInternal(int sceneHandle) { }

	// RVA: 0x37F6D04 Offset: 0x37F2D04 VA: 0x37F6D04
	public int get_handle() { }

	// RVA: 0x37F6D0C Offset: 0x37F2D0C VA: 0x37F6D0C
	public string get_name() { }

	// RVA: 0x37F6D48 Offset: 0x37F2D48 VA: 0x37F6D48 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37F6D50 Offset: 0x37F2D50 VA: 0x37F6D50 Slot: 0
	public override bool Equals(object other) { }
}
