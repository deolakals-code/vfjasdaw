// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : Object // TypeDefIndex: 16277
{
	// Properties
	[NativeName("BindPosesFromScript")]
	public Matrix4x4[] bindposes { set; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { set; }
	public Vector4[] tangents { set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { set; }
	public int[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }

	// Methods

	[FreeFunction("MeshScripting::CreateMesh")]
	// RVA: 0x37D7A30 Offset: 0x37D3A30 VA: 0x37D7A30
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCode]
	// RVA: 0x37D7A6C Offset: 0x37D3A6C VA: 0x37D7A6C
	public void .ctor() { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	// RVA: 0x37D7AEC Offset: 0x37D3AEC VA: 0x37D7AEC
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37D7B40 Offset: 0x37D3B40 VA: 0x37D7B40
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	// RVA: 0x37D7BDC Offset: 0x37D3BDC VA: 0x37D7BDC
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	// RVA: 0x37D7C20 Offset: 0x37D3C20 VA: 0x37D7C20
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	// RVA: 0x37D7C64 Offset: 0x37D3C64 VA: 0x37D7C64
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x37D7D00 Offset: 0x37D3D00 VA: 0x37D7D00
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = True)]
	// RVA: 0x37D7D5C Offset: 0x37D3D5C VA: 0x37D7D5C
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	// RVA: 0x37D7D98 Offset: 0x37D3D98 VA: 0x37D7D98
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x37D7DDC Offset: 0x37D3DDC VA: 0x37D7DDC
	public void set_bindposes(Matrix4x4[] value) { }

	[NativeMethod("CanAccessFromScript")]
	// RVA: 0x37D7E20 Offset: 0x37D3E20 VA: 0x37D7E20
	internal bool get_canAccess() { }

	[NativeMethod("GetVertexCount")]
	// RVA: 0x37D7E5C Offset: 0x37D3E5C VA: 0x37D7E5C
	public int get_vertexCount() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	// RVA: 0x37D7E98 Offset: 0x37D3E98 VA: 0x37D7E98
	public int get_subMeshCount() { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	// RVA: 0x37D7ED4 Offset: 0x37D3ED4 VA: 0x37D7ED4
	public void set_subMeshCount(int value) { }

	// RVA: 0x37D7F18 Offset: 0x37D3F18 VA: 0x37D7F18
	public Bounds get_bounds() { }

	// RVA: 0x37D7FC4 Offset: 0x37D3FC4 VA: 0x37D7FC4
	public void set_bounds(Bounds value) { }

	[NativeMethod("Clear")]
	// RVA: 0x37D804C Offset: 0x37D404C VA: 0x37D804C
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethod("RecalculateBounds")]
	// RVA: 0x37D8090 Offset: 0x37D4090 VA: 0x37D8090
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateNormals")]
	// RVA: 0x37D80D4 Offset: 0x37D40D4 VA: 0x37D80D4
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("MarkDynamic")]
	// RVA: 0x37D8118 Offset: 0x37D4118 VA: 0x37D8118
	private void MarkDynamicImpl() { }

	// RVA: 0x37D8154 Offset: 0x37D4154 VA: 0x37D8154
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x37D81C8 Offset: 0x37D41C8 VA: 0x37D81C8
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DB1CC Offset: 0x26D71CC VA: 0x26DB1CC
	|-Mesh.GetAllocArrayFromChannel<Color>
	|
	|-RVA: 0x26DB2C4 Offset: 0x26D72C4 VA: 0x26DB2C4
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|
	|-RVA: 0x26DB3BC Offset: 0x26D73BC VA: 0x26DB3BC
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x26DB4B4 Offset: 0x26D74B4 VA: 0x26DB4B4
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DB078 Offset: 0x26D7078 VA: 0x26DB078
	|-Mesh.GetAllocArrayFromChannel<Color>
	|
	|-RVA: 0x26DB0CC Offset: 0x26D70CC VA: 0x26DB0CC
	|-Mesh.GetAllocArrayFromChannel<Vector2>
	|
	|-RVA: 0x26DB120 Offset: 0x26D7120 VA: 0x26DB120
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x26DB174 Offset: 0x26D7174 VA: 0x26DB174
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37D8264 Offset: 0x37D4264 VA: 0x37D8264
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DB818 Offset: 0x26D7818 VA: 0x26DB818
	|-Mesh.SetArrayForChannel<Color32>
	|
	|-RVA: 0x26DB894 Offset: 0x26D7894 VA: 0x26DB894
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DB5AC Offset: 0x26D75AC VA: 0x26DB5AC
	|-Mesh.SetArrayForChannel<Color>
	|
	|-RVA: 0x26DB628 Offset: 0x26D7628 VA: 0x26DB628
	|-Mesh.SetArrayForChannel<Vector2>
	|
	|-RVA: 0x26DB6A4 Offset: 0x26D76A4 VA: 0x26DB6A4
	|-Mesh.SetArrayForChannel<Vector3>
	|
	|-RVA: 0x26DB720 Offset: 0x26D7720 VA: 0x26DB720
	|-Mesh.SetArrayForChannel<Vector4>
	|
	|-RVA: 0x26DB79C Offset: 0x26D779C VA: 0x26DB79C
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DBB78 Offset: 0x26D7B78 VA: 0x26DBB78
	|-Mesh.SetListForChannel<Vector2>
	|
	|-RVA: 0x26DBC44 Offset: 0x26D7C44 VA: 0x26DBC44
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DB910 Offset: 0x26D7910 VA: 0x26DB910
	|-Mesh.SetListForChannel<Color>
	|
	|-RVA: 0x26DB9E4 Offset: 0x26D79E4 VA: 0x26DB9E4
	|-Mesh.SetListForChannel<Vector3>
	|
	|-RVA: 0x26DBAB8 Offset: 0x26D7AB8 VA: 0x26DBAB8
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37D84F8 Offset: 0x37D44F8 VA: 0x37D84F8
	public Vector3[] get_vertices() { }

	// RVA: 0x37D8544 Offset: 0x37D4544 VA: 0x37D8544
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x37D85A4 Offset: 0x37D45A4 VA: 0x37D85A4
	public void set_normals(Vector3[] value) { }

	// RVA: 0x37D8604 Offset: 0x37D4604 VA: 0x37D8604
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x37D8664 Offset: 0x37D4664 VA: 0x37D8664
	public Vector2[] get_uv() { }

	// RVA: 0x37D86B0 Offset: 0x37D46B0 VA: 0x37D86B0
	public void set_uv(Vector2[] value) { }

	// RVA: 0x37D8710 Offset: 0x37D4710 VA: 0x37D8710
	public Vector2[] get_uv2() { }

	// RVA: 0x37D875C Offset: 0x37D475C VA: 0x37D875C
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x37D87BC Offset: 0x37D47BC VA: 0x37D87BC
	public Color[] get_colors() { }

	// RVA: 0x37D8808 Offset: 0x37D4808 VA: 0x37D8808
	public void set_colors(Color[] value) { }

	// RVA: 0x37D8868 Offset: 0x37D4868 VA: 0x37D8868
	public void set_colors32(Color32[] value) { }

	// RVA: 0x37D88D0 Offset: 0x37D48D0 VA: 0x37D88D0
	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocs]
	// RVA: 0x37D893C Offset: 0x37D493C VA: 0x37D893C
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x37D8944 Offset: 0x37D4944 VA: 0x37D8944
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x37D89C0 Offset: 0x37D49C0 VA: 0x37D89C0
	public void SetColors(List<Color> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x37D8A2C Offset: 0x37D4A2C VA: 0x37D8A2C
	public void SetColors(List<Color> inColors, int start, int length) { }

	// RVA: 0x37D8A34 Offset: 0x37D4A34 VA: 0x37D8A34
	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DBCFC Offset: 0x26D7CFC VA: 0x26DBCFC
	|-Mesh.SetUvsImpl<Vector2>
	|
	|-RVA: 0x26DBE08 Offset: 0x26D7E08 VA: 0x26DBE08
	|-Mesh.SetUvsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37D8AB0 Offset: 0x37D4AB0 VA: 0x37D8AB0
	public void SetUVs(int channel, List<Vector2> uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x37D8B24 Offset: 0x37D4B24 VA: 0x37D8B24
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	// RVA: 0x37D8B2C Offset: 0x37D4B2C VA: 0x37D8B2C
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x37D8BB8 Offset: 0x37D4BB8 VA: 0x37D8BB8
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x37D8C50 Offset: 0x37D4C50 VA: 0x37D8C50
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x37D8D90 Offset: 0x37D4D90 VA: 0x37D8D90
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x37D8D98 Offset: 0x37D4D98 VA: 0x37D8D98
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x37D8DA0 Offset: 0x37D4DA0 VA: 0x37D8DA0
	public int[] get_triangles() { }

	// RVA: 0x37D8E54 Offset: 0x37D4E54 VA: 0x37D8E54
	public void set_triangles(int[] value) { }

	// RVA: 0x37D8F9C Offset: 0x37D4F9C VA: 0x37D8F9C
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x37D8FA4 Offset: 0x37D4FA4 VA: 0x37D8FA4
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x37D904C Offset: 0x37D504C VA: 0x37D904C
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x37D8EFC Offset: 0x37D4EFC VA: 0x37D8EFC
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x37D91E8 Offset: 0x37D51E8 VA: 0x37D91E8
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x37D9230 Offset: 0x37D5230 VA: 0x37D9230
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x37D9288 Offset: 0x37D5288 VA: 0x37D9288
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x37D9314 Offset: 0x37D5314 VA: 0x37D9314
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	// RVA: 0x37D9378 Offset: 0x37D5378 VA: 0x37D9378
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x37D93EC Offset: 0x37D53EC VA: 0x37D93EC
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	// RVA: 0x37D94C0 Offset: 0x37D54C0 VA: 0x37D94C0
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x37D94FC Offset: 0x37D54FC VA: 0x37D94FC
	public void set_boneWeights(BoneWeight[] value) { }

	[ExcludeFromDocs]
	// RVA: 0x37D9540 Offset: 0x37D5540 VA: 0x37D9540
	public void Clear() { }

	[ExcludeFromDocs]
	// RVA: 0x37D9580 Offset: 0x37D5580 VA: 0x37D9580
	public void RecalculateBounds() { }

	[ExcludeFromDocs]
	// RVA: 0x37D967C Offset: 0x37D567C VA: 0x37D967C
	public void RecalculateNormals() { }

	// RVA: 0x37D9588 Offset: 0x37D5588 VA: 0x37D9588
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x37D9684 Offset: 0x37D5684 VA: 0x37D9684
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	// RVA: 0x37D9778 Offset: 0x37D5778 VA: 0x37D9778
	public void MarkDynamic() { }

	// RVA: 0x37D7F80 Offset: 0x37D3F80 VA: 0x37D7F80
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x37D8008 Offset: 0x37D4008 VA: 0x37D8008
	private void set_bounds_Injected(ref Bounds value) { }
}
