// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameRoomData : RoomDataBase // TypeDefIndex: 2321
{
	// Fields
	private float timer; // 0x64
	private bool isMoveTimer; // 0x68

	// Properties
	public override byte RoomType { get; }
	public override string[] LoadAssetsPath { get; }

	// Methods

	// RVA: 0x2185408 Offset: 0x2181408 VA: 0x2185408 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x2185410 Offset: 0x2181410 VA: 0x2185410 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x2185498 Offset: 0x2181498 VA: 0x2185498
	public void .ctor() { }

	// RVA: 0x2185660 Offset: 0x2181660 VA: 0x2185660 Slot: 12
	public override void Clear() { }

	// RVA: 0x2185664 Offset: 0x2181664 VA: 0x2185664 Slot: 13
	public override void Enter() { }

	// RVA: 0x2185668 Offset: 0x2181668 VA: 0x2185668 Slot: 14
	public override void Leave() { }

	// RVA: 0x218566C Offset: 0x218166C VA: 0x218566C Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21856BC Offset: 0x21816BC VA: 0x21856BC Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21856C0 Offset: 0x21816C0 VA: 0x21856C0 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21856C4 Offset: 0x21816C4 VA: 0x21856C4 Slot: 15
	public override void Update() { }

	// RVA: 0x21857B8 Offset: 0x21817B8 VA: 0x21857B8 Slot: 26
	public override bool OnActionOtherMove(OtherPlayerActionManager otherPlayerActionManager, IMoveData eventData) { }

	// RVA: 0x218584C Offset: 0x218184C VA: 0x218584C Slot: 24
	public override void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x2185928 Offset: 0x2181928 VA: 0x2185928 Slot: 29
	public override bool CheckVisibleOtherPlayerRoom(Archetype archetype) { }

	// RVA: 0x2185A50 Offset: 0x2181A50 VA: 0x2185A50 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x2185784 Offset: 0x2181784 VA: 0x2185784
	public void UpdateTimer() { }
}
