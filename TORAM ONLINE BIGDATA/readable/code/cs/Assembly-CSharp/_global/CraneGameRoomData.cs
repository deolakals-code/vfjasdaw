// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CraneGameRoomData : RoomDataBase // TypeDefIndex: 2327
{
	// Fields
	private GameObject field; // 0x68
	private Vector3 fieldStartPos; // 0x70
	private CraneGameController controller; // 0x80
	private CameraCraneGameController cameraController; // 0x88
	private CraneGameCharacterModelManager characterModelManager; // 0x90
	private UICraneGameManager uiManager; // 0x98
	private int userGold; // 0xA0
	private int playCount; // 0xA4
	private int totalPlayCount; // 0xA8
	private int totalGetCount; // 0xAC
	private List<int> scoreList; // 0xB0
	private int totalScore; // 0xB8
	private List<int> getScoreList; // 0xC0
	private Vector3 cameraStartPos; // 0xC8
	private Vector3 cameraAngle; // 0xD4
	private const float changeActiveAngle = 22;
	private bool isSetCamera; // 0xE0
	private bool isEnter; // 0xE1
	public const int ITEMCOUNT = 5;
	public readonly int UseOnePlayGold; // 0xE4
	public readonly int UseSixPlayGold; // 0xE8
	private GameObject craneGameField; // 0xF0

	// Properties
	public override byte RoomType { get; }
	public int UserGold { get; }
	public int PlayCount { get; }
	public int TotalPlayCount { get; }
	public int TotalGetCount { get; }
	public List<int> ScoreList { get; }
	public int TotalScore { get; }
	public CraneGameController CraneGameController { get; }
	public Vector3 FieldStartPos { get; }
	public Vector3 CameraStartPos { get; }
	public override string[] LoadAssetsPath { get; }

	// Methods

	// RVA: 0x2185A58 Offset: 0x2181A58 VA: 0x2185A58 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x2185A60 Offset: 0x2181A60 VA: 0x2185A60
	public int get_UserGold() { }

	// RVA: 0x2185A68 Offset: 0x2181A68 VA: 0x2185A68
	public int get_PlayCount() { }

	// RVA: 0x2185A70 Offset: 0x2181A70 VA: 0x2185A70
	public int get_TotalPlayCount() { }

	// RVA: 0x2185A78 Offset: 0x2181A78 VA: 0x2185A78
	public int get_TotalGetCount() { }

	// RVA: 0x2185A80 Offset: 0x2181A80 VA: 0x2185A80
	public List<int> get_ScoreList() { }

	// RVA: 0x2185A88 Offset: 0x2181A88 VA: 0x2185A88
	public int get_TotalScore() { }

	// RVA: 0x2185A90 Offset: 0x2181A90 VA: 0x2185A90
	public CraneGameController get_CraneGameController() { }

	// RVA: 0x2185A98 Offset: 0x2181A98 VA: 0x2185A98
	public Vector3 get_FieldStartPos() { }

	// RVA: 0x2185AA4 Offset: 0x2181AA4 VA: 0x2185AA4
	public Vector3 get_CameraStartPos() { }

	// RVA: 0x2185AB0 Offset: 0x2181AB0 VA: 0x2185AB0 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x2185B7C Offset: 0x2181B7C VA: 0x2185B7C
	public void .ctor() { }

	// RVA: 0x2185D44 Offset: 0x2181D44 VA: 0x2185D44 Slot: 12
	public override void Clear() { }

	// RVA: 0x2185D48 Offset: 0x2181D48 VA: 0x2185D48 Slot: 13
	public override void Enter() { }

	// RVA: 0x2186148 Offset: 0x2182148 VA: 0x2186148 Slot: 14
	public override void Leave() { }

	// RVA: 0x21863A0 Offset: 0x21823A0 VA: 0x21863A0 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x218647C Offset: 0x218247C VA: 0x218647C Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x2186480 Offset: 0x2182480 VA: 0x2186480 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2186484 Offset: 0x2182484 VA: 0x2186484 Slot: 15
	public override void Update() { }

	// RVA: 0x2186B78 Offset: 0x2182B78 VA: 0x2186B78 Slot: 35
	public override bool PlayerInputMoveCheck() { }

	// RVA: 0x2186B80 Offset: 0x2182B80 VA: 0x2186B80 Slot: 28
	public override bool CheckTapPlayerRoom() { }

	// RVA: 0x2186B88 Offset: 0x2182B88 VA: 0x2186B88 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x2186B90 Offset: 0x2182B90 VA: 0x2186B90
	public void LeaveField() { }

	// RVA: 0x2186C20 Offset: 0x2182C20 VA: 0x2186C20
	public void CraneGameAddPlayCountMethod(byte count) { }

	// RVA: 0x2186CFC Offset: 0x2182CFC VA: 0x2186CFC
	public void CraneGamePlayMethod() { }

	// RVA: 0x2186DD0 Offset: 0x2182DD0 VA: 0x2186DD0
	public void CraneGameResultMethod(bool isGet, int score) { }

	// RVA: 0x2186EE8 Offset: 0x2182EE8 VA: 0x2186EE8
	public void CraneGameResetMethod() { }

	// RVA: 0x2186F78 Offset: 0x2182F78 VA: 0x2186F78
	public void AddTotalScore(int getScore) { }

	// RVA: 0x2186AB8 Offset: 0x2182AB8 VA: 0x2186AB8
	public void ResetGame() { }
}
