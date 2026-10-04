// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLWidgetsConvert : MonoBehaviour // TypeDefIndex: 224
{
	// Fields
	[SerializeField]
	private byte[] glMaterialId; // 0x20
	[SerializeField]
	private int[] widgetsMaterial; // 0x28
	[SerializeField]
	private UIWidget[] widgets; // 0x30
	private BetterList<Vector3> bufferVerts; // 0x38
	private BetterList<Vector2> bufferUVs; // 0x40
	private BetterList<Color32> bufferColors; // 0x48
	private BetterList<Vector3> verts; // 0x50
	private BetterList<Vector2> uvs; // 0x58
	private BetterList<Color32> cols; // 0x60

	// Methods

	// RVA: 0x21C745C Offset: 0x21C345C VA: 0x21C745C
	public Dictionary<byte, Mesh> GetsMesh() { }

	// RVA: 0x21C7C34 Offset: 0x21C3C34 VA: 0x21C7C34
	public void SetGLMesh(UIGLMesh glMesh) { }

	// RVA: 0x21C7544 Offset: 0x21C3544 VA: 0x21C7544
	private Mesh GetMesh(byte id) { }

	// RVA: 0x21C7D24 Offset: 0x21C3D24 VA: 0x21C7D24
	public void .ctor() { }
}
