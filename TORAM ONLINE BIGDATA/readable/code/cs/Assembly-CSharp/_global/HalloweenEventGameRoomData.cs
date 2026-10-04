// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HalloweenEventGameRoomData : RoomDataBase, IRoomSetPointData // TypeDefIndex: 2349
{
	// Fields
	private HalloweenMobActionManager[] popMob; // 0x68
	private Halloween2024Master master; // 0x70
	private Dictionary<byte, Halloween2024Master.SearchPointData> searchPoints; // 0x78
	private Dictionary<int, int> bagItem; // 0x80
	private Dictionary<int, byte> useItem; // 0x88
	private int battleCount; // 0x90
	private int searchCount; // 0x94
	private bool isPlayerMoveLock; // 0x98
	private int skillPlayTakeUid; // 0x9C
	[CompilerGenerated]
	private int <AccessPoint>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <PlayerHp>k__BackingField; // 0xA4
	[CompilerGenerated]
	private int <PlayerMaxHp>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <IsWalk>k__BackingField; // 0xAC
	private float recoveryTimer; // 0xB0
	private float fallTimer; // 0xB4
	private float seMoveTiming; // 0xB8
	private byte seMoveLevel; // 0xBC
	private byte redKeyNo; // 0xBD
	private byte blueKeyNo; // 0xBE
	private int selectMinimapId; // 0xC0
	private GameObject redWarpObject; // 0xC8
	private GameObject blueWarpObject; // 0xD0
	[CompilerGenerated]
	private bool <IsGameStart>k__BackingField; // 0xD8
	private int goalWarpFieldId; // 0xDC
	private byte goalWarpRoomType; // 0xE0
	private byte goalWarpRoomId; // 0xE1
	private Vector3 goalWarpPosition; // 0xE4
	private float goalWarpRot; // 0xF0
	private float goalWarpCameraRot; // 0xF4

	// Properties
	public override byte RoomType { get; }
	public int AccessPoint { get; set; }
	public int PlayerHp { get; set; }
	public int PlayerMaxHp { get; set; }
	public bool IsWalk { get; set; }
	public bool IsGameStart { get; set; }
	public bool IsPlaySkill { get; }

	// Methods

	// RVA: 0x2190834 Offset: 0x218C834 VA: 0x2190834 Slot: 4
	public override byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x219083C Offset: 0x218C83C VA: 0x219083C Slot: 40
	public int get_AccessPoint() { }

	[CompilerGenerated]
	// RVA: 0x2190844 Offset: 0x218C844 VA: 0x2190844
	private void set_AccessPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x219084C Offset: 0x218C84C VA: 0x219084C
	public int get_PlayerHp() { }

	[CompilerGenerated]
	// RVA: 0x2190854 Offset: 0x218C854 VA: 0x2190854
	private void set_PlayerHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x219085C Offset: 0x218C85C VA: 0x219085C
	public int get_PlayerMaxHp() { }

	[CompilerGenerated]
	// RVA: 0x2190864 Offset: 0x218C864 VA: 0x2190864
	private void set_PlayerMaxHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x219086C Offset: 0x218C86C VA: 0x219086C
	public bool get_IsWalk() { }

	[CompilerGenerated]
	// RVA: 0x2190874 Offset: 0x218C874 VA: 0x2190874
	private void set_IsWalk(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2190880 Offset: 0x218C880 VA: 0x2190880
	public bool get_IsGameStart() { }

	[CompilerGenerated]
	// RVA: 0x2190888 Offset: 0x218C888 VA: 0x2190888
	private void set_IsGameStart(bool value) { }

	// RVA: 0x2190894 Offset: 0x218C894 VA: 0x2190894
	public bool get_IsPlaySkill() { }

	// RVA: 0x21908A4 Offset: 0x218C8A4 VA: 0x21908A4
	public void .ctor() { }

	// RVA: 0x2190B08 Offset: 0x218CB08 VA: 0x2190B08 Slot: 12
	public override void Clear() { }

	// RVA: 0x2190EC0 Offset: 0x218CEC0 VA: 0x2190EC0 Slot: 13
	public override void Enter() { }

	// RVA: 0x2190FB0 Offset: 0x218CFB0 VA: 0x2190FB0
	private void SetFieldData(byte[] removePoints) { }

	// RVA: 0x2191160 Offset: 0x218D160 VA: 0x2191160 Slot: 14
	public override void Leave() { }

	// RVA: 0x21912F4 Offset: 0x218D2F4 VA: 0x21912F4 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21912F8 Offset: 0x218D2F8 VA: 0x21912F8 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21912FC Offset: 0x218D2FC VA: 0x21912FC Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2191300 Offset: 0x218D300 VA: 0x2191300 Slot: 15
	public override void Update() { }

	// RVA: 0x2191CC0 Offset: 0x218DCC0 VA: 0x2191CC0
	public void EnterHalloweenMapWarp(int fieldId, int randField, Vector3 position, float rot, int goalFieldId, byte goalRoomType, byte goalRoomId, Vector3 goalPosition, float goalRot, float goalWarpCameraRot, EmergencyPositionData emergency) { }

	// RVA: 0x2191DF4 Offset: 0x218DDF4 VA: 0x2191DF4 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x2192054 Offset: 0x218E054 VA: 0x2192054
	private void BagUpdate(Dictionary<byte, byte> updateBag, byte blueKeyNo, byte redKeyNo) { }

	// RVA: 0x21927AC Offset: 0x218E7AC VA: 0x21927AC
	public Vector3 MoveHitRoot(int index, Vector3 pos, Vector3 move, float speed) { }

	// RVA: 0x2192A8C Offset: 0x218EA8C VA: 0x2192A8C Slot: 23
	public override NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x2191E70 Offset: 0x218DE70 VA: 0x2191E70 Slot: 41
	public void SetAccessPoint(int point) { }

	// RVA: 0x2192AAC Offset: 0x218EAAC VA: 0x2192AAC
	public bool GetRewardPoint(int point, Action<int[]> rewardCallback) { }

	// RVA: 0x2192C30 Offset: 0x218EC30 VA: 0x2192C30
	public float GetPlayerHateDist() { }

	// RVA: 0x2192D30 Offset: 0x218ED30 VA: 0x2192D30
	public int GetItemNum(int id) { }

	// RVA: 0x2192E54 Offset: 0x218EE54 VA: 0x2192E54
	public void UseItem(int id) { }

	// RVA: 0x2191B58 Offset: 0x218DB58 VA: 0x2191B58
	public void PlayreHate(Vector3 pos) { }

	// RVA: 0x2192F34 Offset: 0x218EF34 VA: 0x2192F34 Slot: 35
	public override bool PlayerInputMoveCheck() { }

	// RVA: 0x2192F54 Offset: 0x218EF54 VA: 0x2192F54
	public void PlaySkillTake(int uid) { }

	// RVA: 0x2192F88 Offset: 0x218EF88 VA: 0x2192F88
	public void EndSkillTake(int uid) { }

	// RVA: 0x2192FC4 Offset: 0x218EFC4 VA: 0x2192FC4
	public void MobToPlayerAttack(GameObject mob) { }

	// RVA: 0x2193404 Offset: 0x218F404 VA: 0x2193404
	public void PlayerChangeWalk() { }

	// RVA: 0x2193440 Offset: 0x218F440 VA: 0x2193440
	public void GameStart() { }

	// RVA: 0x21934D8 Offset: 0x218F4D8 VA: 0x21934D8
	public void GoalWarpField() { }

	// RVA: 0x21935D8 Offset: 0x218F5D8 VA: 0x21935D8
	public void BattleCountUp() { }

	// RVA: 0x21935E8 Offset: 0x218F5E8 VA: 0x21935E8
	public Vector3 GetKeyPosition(bool isRedKey) { }

	[CompilerGenerated]
	// RVA: 0x219243C Offset: 0x218E43C VA: 0x219243C
	private void <BagUpdate>g__AddGoalPoint|62_0(byte id, Vector3 pos) { }
}
