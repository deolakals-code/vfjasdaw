// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobBufferIcon : MonoBehaviour // TypeDefIndex: 8998
{
	// Fields
	[SerializeField]
	private GameObject baseIcon; // 0x20
	[SerializeField]
	private GameObject subIcon; // 0x28
	[SerializeField]
	private GameObject barrierIcon; // 0x30
	private MobBuffId bufferType; // 0x38
	private byte bufferFlag; // 0x3C
	private bool isDelete; // 0x3D
	private UIGLSprite subGLIcon; // 0x40

	// Properties
	public MobBuffId BufferType { get; }
	public bool HasSubIcon { get; }

	// Methods

	// RVA: 0x1E8970C Offset: 0x1E8570C VA: 0x1E8970C
	public MobBuffId get_BufferType() { }

	// RVA: 0x1E89714 Offset: 0x1E85714 VA: 0x1E89714
	public bool get_HasSubIcon() { }

	// RVA: 0x1E89774 Offset: 0x1E85774 VA: 0x1E89774
	public bool CheckBuffer(MobBuffId bufferType, byte flag) { }

	// RVA: 0x1E897A0 Offset: 0x1E857A0 VA: 0x1E897A0
	public void SetIcon(MobBuffId type, byte flag) { }

	// RVA: 0x1E89DBC Offset: 0x1E85DBC VA: 0x1E89DBC
	public void CloseBuffer() { }

	// RVA: 0x1E89EA0 Offset: 0x1E85EA0 VA: 0x1E89EA0
	public void AddIcon() { }

	// RVA: 0x1E89BB0 Offset: 0x1E85BB0 VA: 0x1E89BB0
	private UIGLSprite CreateBaseIcon(string spriteName) { }

	// RVA: 0x1E89C1C Offset: 0x1E85C1C VA: 0x1E89C1C
	private UIGLSprite CreateIcon(GameObject iconObject, string spriteName, Vector3 pos) { }

	// RVA: 0x1E89F64 Offset: 0x1E85F64 VA: 0x1E89F64
	public void .ctor() { }
}
