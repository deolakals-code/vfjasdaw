// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectDropItem : MonoBehaviour // TypeDefIndex: 231
{
	// Fields
	private GameObject effectObject; // 0x20
	private SkinnedMeshRenderer effectSkin; // 0x28
	private Transform[] effectfloor; // 0x30
	private UIIconBase effectIcon; // 0x38
	private float speed; // 0x40
	private Transform traceObject; // 0x48
	private int itemId; // 0x50
	private Vector3 move; // 0x54
	private float height; // 0x60
	private Action callBack; // 0x68
	private byte state; // 0x70
	private byte itemRareLavel; // 0x71
	private byte dropItemType; // 0x72
	private float d2Speed; // 0x74

	// Methods

	// RVA: 0x22A2A0C Offset: 0x229EA0C VA: 0x22A2A0C
	public void Initialize(Vector3 position, Transform traget, float wait, int dropItemId, byte dropItemRareLavel, byte itemType, Action call) { }

	// RVA: 0x22A2FEC Offset: 0x229EFEC VA: 0x22A2FEC
	private void Update() { }

	// RVA: 0x22A416C Offset: 0x22A016C VA: 0x22A416C
	private void LateUpdate() { }

	// RVA: 0x22A4334 Offset: 0x22A0334 VA: 0x22A4334
	private void OnDestroy() { }

	// RVA: 0x22A319C Offset: 0x229F19C VA: 0x22A319C
	private bool DropItem() { }

	// RVA: 0x22A3540 Offset: 0x229F540 VA: 0x22A3540
	private bool PlayerTrace() { }

	// RVA: 0x22A3B8C Offset: 0x229FB8C VA: 0x22A3B8C
	private bool Storage() { }

	// RVA: 0x22A43DC Offset: 0x22A03DC VA: 0x22A43DC
	public void .ctor() { }
}
