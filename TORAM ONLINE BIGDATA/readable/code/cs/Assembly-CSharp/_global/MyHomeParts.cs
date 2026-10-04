// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MyHomeParts : MonoBehaviour // TypeDefIndex: 3972
{
	// Fields
	[SerializeField]
	private GameObject[] mainModel; // 0x20
	[SerializeField]
	private Mesh cameraColiderMesh; // 0x28
	[SerializeField]
	private Mesh floorColiderMesh; // 0x30
	[SerializeField]
	private Mesh wallColiderMesh; // 0x38
	[SerializeField]
	private Texture maskTexture; // 0x40
	[SerializeField]
	private int flag; // 0x48

	// Properties
	public Texture MaskTexture { get; }
	public GameObject[] MainModel { get; }
	public Mesh CameraColiderMesh { get; }
	public Mesh FloorColiderMesh { get; }
	public Mesh WallColiderMesh { get; }
	public int Flag { get; }

	// Methods

	// RVA: 0x2429D50 Offset: 0x2425D50 VA: 0x2429D50
	public Texture get_MaskTexture() { }

	// RVA: 0x2429D58 Offset: 0x2425D58 VA: 0x2429D58
	public GameObject[] get_MainModel() { }

	// RVA: 0x2429D60 Offset: 0x2425D60 VA: 0x2429D60
	public Mesh get_CameraColiderMesh() { }

	// RVA: 0x2429D68 Offset: 0x2425D68 VA: 0x2429D68
	public Mesh get_FloorColiderMesh() { }

	// RVA: 0x2429D70 Offset: 0x2425D70 VA: 0x2429D70
	public Mesh get_WallColiderMesh() { }

	// RVA: 0x2429D78 Offset: 0x2425D78 VA: 0x2429D78
	public int get_Flag() { }

	// RVA: 0x2429D80 Offset: 0x2425D80 VA: 0x2429D80
	public void .ctor() { }
}
