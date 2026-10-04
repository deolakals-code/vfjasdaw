// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.U2D
[NativeType(1, "ScriptingSpriteBone")]
[RequiredByNativeCode]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[MovedFrom("UnityEngine.Experimental.U2D")]
[Serializable]
public struct SpriteBone // TypeDefIndex: 16407
{
	// Fields
	[NativeName("name")]
	[SerializeField]
	private string m_Name; // 0x0
	[SerializeField]
	[NativeName("guid")]
	private string m_Guid; // 0x8
	[SerializeField]
	[NativeName("position")]
	private Vector3 m_Position; // 0x10
	[NativeName("rotation")]
	[SerializeField]
	private Quaternion m_Rotation; // 0x1C
	[NativeName("length")]
	[SerializeField]
	private float m_Length; // 0x2C
	[SerializeField]
	[NativeName("parentId")]
	private int m_ParentId; // 0x30
	[SerializeField]
	[NativeName("color")]
	private Color32 m_Color; // 0x34
}
