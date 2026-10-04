// Assembly: Assembly-CSharp.dll
// Namespace: 
private struct BaseCloneRender.cloneTrans // TypeDefIndex: 5297
{
	// Fields
	private Vector3 position; // 0x0
	private Quaternion rotation; // 0xC
	private Vector3 scale; // 0x1C
	private Matrix4x4 transMatrix; // 0x28
	private bool isUpdate; // 0x68

	// Methods

	// RVA: 0x2626F7C Offset: 0x2622F7C VA: 0x2626F7C
	public void Clear() { }

	// RVA: 0x26271EC Offset: 0x26231EC VA: 0x26271EC
	public void SetPosition(Vector3 pos) { }

	// RVA: 0x2627248 Offset: 0x2623248 VA: 0x2627248
	public void SetRotation(Vector3 rot) { }

	// RVA: 0x26272D0 Offset: 0x26232D0 VA: 0x26272D0
	public void SetScale(Vector3 scale) { }

	// RVA: 0x2627090 Offset: 0x2623090 VA: 0x2627090
	public Matrix4x4 UpdateTrans(Matrix4x4 parentTrans) { }
}
