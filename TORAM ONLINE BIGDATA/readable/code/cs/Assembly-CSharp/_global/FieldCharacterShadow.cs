// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldCharacterShadow : MonoBehaviour // TypeDefIndex: 3897
{
	// Fields
	private FieldRayPick fieldRayPick; // 0x20
	private Transform mainTrans; // 0x28
	private Transform rootBone; // 0x30
	private bool activeFlag; // 0x38
	private float baseShadowScale; // 0x3C
	private FieldAreaManager fieldAreaManager; // 0x40
	private Vector3 shadowBoneBaseScale; // 0x48
	private bool shadowReset; // 0x54
	private bool isCameraClip; // 0x55

	// Methods

	// RVA: 0x2409174 Offset: 0x2405174 VA: 0x2409174
	private void Start() { }

	// RVA: 0x240945C Offset: 0x240545C VA: 0x240945C
	public void SetCharacterMove(CharacterMove characterMove) { }

	// RVA: 0x24094E8 Offset: 0x24054E8 VA: 0x24094E8
	public void SetCharacterMove(Transform mainTrans, FieldRayPick fieldRayPick) { }

	// RVA: 0x240956C Offset: 0x240556C VA: 0x240956C
	public void ShadowCheck(bool flag) { }

	// RVA: 0x2409578 Offset: 0x2405578 VA: 0x2409578
	public void SetCameraClip(bool isClip) { }

	// RVA: 0x2409584 Offset: 0x2405584 VA: 0x2409584
	private void LateUpdate() { }

	// RVA: 0x2409CD4 Offset: 0x2405CD4 VA: 0x2409CD4
	public void .ctor() { }
}
