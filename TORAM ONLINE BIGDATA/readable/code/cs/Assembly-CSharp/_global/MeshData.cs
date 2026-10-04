// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MeshData // TypeDefIndex: 5321
{
	// Fields
	public Vector3[] Vertices; // 0x10
	public Color[] VerticesColor; // 0x18
	public Vector2[] UV1; // 0x20
	public Vector2[] UV2; // 0x28
	public BoneWeight[] Weight; // 0x30
	public Dictionary<byte, int[]> Triangles; // 0x38
	public string[] Bone; // 0x40
	private byte offset; // 0x48

	// Properties
	public float Offset { get; }

	// Methods

	// RVA: 0x262EE14 Offset: 0x262AE14 VA: 0x262EE14
	public float get_Offset() { }

	// RVA: 0x262EE30 Offset: 0x262AE30 VA: 0x262EE30
	public void SetOffset(byte offsetData) { }

	// RVA: 0x262EE38 Offset: 0x262AE38 VA: 0x262EE38
	public void Clear() { }

	// RVA: 0x262EEE8 Offset: 0x262AEE8 VA: 0x262EEE8
	public void Load(byte[] binary, long position) { }

	// RVA: 0x262F748 Offset: 0x262B748 VA: 0x262F748
	public void .ctor() { }
}
