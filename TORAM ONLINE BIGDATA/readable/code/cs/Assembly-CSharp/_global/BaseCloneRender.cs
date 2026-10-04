// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BaseCloneRender : MonoBehaviour // TypeDefIndex: 5298
{
	// Fields
	private int renderNum; // 0x20
	private BaseCloneRender.cloneTrans[] trans; // 0x28
	private SkinnedMeshRenderer skin; // 0x30

	// Methods

	// RVA: 0x2626B14 Offset: 0x2622B14 VA: 0x2626B14 Slot: 4
	protected virtual Shader ConvertShader(Material mat) { }

	// RVA: 0x2626B84 Offset: 0x2622B84 VA: 0x2626B84
	public void Initialize(int cloneNum) { }

	// RVA: 0x26271A0 Offset: 0x26231A0 VA: 0x26271A0 Slot: 5
	public virtual void SetClonePosition(byte id, Vector3 pos) { }

	// RVA: 0x2627200 Offset: 0x2623200 VA: 0x2627200 Slot: 6
	public virtual void SetCloneRotation(byte id, Vector3 rot) { }

	// RVA: 0x2627284 Offset: 0x2623284 VA: 0x2627284 Slot: 7
	public virtual void SetCloneScale(byte id, Vector3 scale) { }

	// RVA: 0x26272E4 Offset: 0x26232E4 VA: 0x26272E4
	private void Update() { }

	// RVA: 0x26277A0 Offset: 0x26237A0 VA: 0x26277A0
	public void .ctor() { }
}
