// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGeometry // TypeDefIndex: 90
{
	// Fields
	public BetterList<Vector3> verts; // 0x10
	public BetterList<Vector2> uvs; // 0x18
	public BetterList<Color32> cols; // 0x20
	private BetterList<Vector3> mRtpVerts; // 0x28
	private Vector3 mRtpNormal; // 0x30
	private Vector4 mRtpTan; // 0x3C

	// Properties
	public bool hasVertices { get; }
	public bool hasTransformed { get; }

	// Methods

	// RVA: 0x1735088 Offset: 0x1731088 VA: 0x1735088
	public bool get_hasVertices() { }

	// RVA: 0x17350AC Offset: 0x17310AC VA: 0x17350AC
	public bool get_hasTransformed() { }

	// RVA: 0x17350EC Offset: 0x17310EC VA: 0x17350EC
	public void Clear() { }

	// RVA: 0x1735194 Offset: 0x1731194 VA: 0x1735194
	public void ApplyTransform(Matrix4x4 widgetToPanel) { }

	// RVA: 0x173547C Offset: 0x173147C VA: 0x173547C
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t) { }

	// RVA: 0x1735728 Offset: 0x1731728 VA: 0x1735728
	public void .ctor() { }
}
