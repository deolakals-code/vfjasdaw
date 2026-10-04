// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetRaceCourse : MonoBehaviour // TypeDefIndex: 4450
{
	// Fields
	[SerializeField]
	private Transform[] checkPoints; // 0x20
	[SerializeField]
	private byte[] lapPoint; // 0x28
	[SerializeField]
	private PetRaceCourse.ObstacleItem[] obstacleItems; // 0x30
	[SerializeField]
	private Transform[] recoveryItemPoints; // 0x38
	[SerializeField]
	private Transform resultUserTrans; // 0x40
	[SerializeField]
	private Vector3[] resultUserCamera; // 0x48
	[SerializeField]
	private Transform[] resultTrans; // 0x50
	[SerializeField]
	private Vector3[] resultRankingCamera; // 0x58

	// Properties
	public int LapNum { get; }
	public int EesultUserCameraNum { get; }

	// Methods

	// RVA: 0x24F6918 Offset: 0x24F2918 VA: 0x24F6918
	public int get_LapNum() { }

	// RVA: 0x24F6934 Offset: 0x24F2934 VA: 0x24F6934
	public int get_EesultUserCameraNum() { }

	// RVA: 0x24F6958 Offset: 0x24F2958 VA: 0x24F6958
	public void SetResultUserView(GameObject model) { }

	// RVA: 0x24F6A7C Offset: 0x24F2A7C VA: 0x24F6A7C
	public bool SetResultFixedPointView(CameraManager cameraManager, int id) { }

	// RVA: 0x24F6B08 Offset: 0x24F2B08 VA: 0x24F6B08
	public void SetResultView(CameraManager cameraManager, GameObject item, GameObject[] goalInModel, GameObject[] timeUpModel) { }

	// RVA: 0x24F6FA0 Offset: 0x24F2FA0 VA: 0x24F6FA0
	public List<GameObject> CreateObstacleItems(int seed, GameObject[] block) { }

	// RVA: 0x24F76A8 Offset: 0x24F36A8 VA: 0x24F76A8
	public GameObject[] CreateRecoveryItems(int bit, GameObject item) { }

	// RVA: 0x24F7998 Offset: 0x24F3998 VA: 0x24F7998
	public bool CheckMoveRoute(int rootId, Vector3 position, Vector3 lastPosition) { }

	// RVA: 0x24F7B54 Offset: 0x24F3B54 VA: 0x24F7B54
	public bool CheckGoal(int id) { }

	// RVA: 0x24F7B74 Offset: 0x24F3B74 VA: 0x24F7B74
	public int GetNowLap(int id) { }

	// RVA: 0x24F7BCC Offset: 0x24F3BCC VA: 0x24F7BCC
	public Vector3 GetPointPos(int rootId) { }

	// RVA: 0x24F7D18 Offset: 0x24F3D18 VA: 0x24F7D18
	public void .ctor() { }
}
