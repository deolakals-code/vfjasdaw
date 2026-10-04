// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameBattleCameraManager // TypeDefIndex: 4247
{
	// Fields
	private CameraManager cameraManager; // 0x10
	private List<CardGameTakeBase> currentTakeList; // 0x18
	private CardGameBattleCameraManager.CameraTransform beforCamera; // 0x20
	private CardGameBattleCameraManager.CameraTransform afterCamera; // 0x28
	private readonly CardGameBattleCameraManager.CameraTransform fixedCamera; // 0x30
	private float changeRate; // 0x38
	private CardGameBattleCameraManager.BattleCameraMode cameraMode; // 0x3C

	// Methods

	// RVA: 0x24B4F94 Offset: 0x24B0F94 VA: 0x24B4F94
	public void .ctor() { }

	// RVA: 0x24B5118 Offset: 0x24B1118 VA: 0x24B5118
	public void Initialize() { }

	// RVA: 0x24B51C4 Offset: 0x24B11C4 VA: 0x24B51C4
	public void StartTake(List<CardGameTakeBase> takeList) { }

	// RVA: 0x24B5734 Offset: 0x24B1734 VA: 0x24B5734
	public void Update() { }

	// RVA: 0x24B5978 Offset: 0x24B1978 VA: 0x24B5978
	private void UpdateCameraPosition(Vector3 pos, Vector3 rot) { }

	// RVA: 0x24B58A0 Offset: 0x24B18A0 VA: 0x24B58A0
	private void UpdateCameraPosLookTarget(Vector3 pos, Vector3 target) { }

	// RVA: 0x24B5A50 Offset: 0x24B1A50 VA: 0x24B5A50
	private Vector3 GetPosForPolarCoord(Vector3 target, float dist, float shita, float phi) { }

	// RVA: 0x24B53CC Offset: 0x24B13CC VA: 0x24B53CC
	private void SetMoveAttackCamera() { }

	// RVA: 0x24B547C Offset: 0x24B147C VA: 0x24B547C
	private void SetRangeAttackCamera() { }
}
