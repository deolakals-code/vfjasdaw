// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummerMmoRoomData : SummerEventRoomData // TypeDefIndex: 2476
{
	// Fields
	private RaycastHit ray; // 0x154

	// Properties
	public override byte RoomType { get; }
	protected override UIActiveState fieldMainUIState { get; }
	public override string[] LoadAssetsPath { get; }

	// Methods

	// RVA: 0x21D07EC Offset: 0x21CC7EC VA: 0x21D07EC Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21D07F4 Offset: 0x21CC7F4 VA: 0x21D07F4 Slot: 40
	protected override UIActiveState get_fieldMainUIState() { }

	// RVA: 0x21D07FC Offset: 0x21CC7FC VA: 0x21D07FC Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21D08B8 Offset: 0x21CC8B8 VA: 0x21D08B8
	public void RoomPlayerEnterSettings() { }

	// RVA: 0x21D08C8 Offset: 0x21CC8C8 VA: 0x21D08C8 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21D09E0 Offset: 0x21CC9E0 VA: 0x21D09E0 Slot: 45
	protected override void EnterPlayerSettings() { }

	// RVA: 0x21D0AB0 Offset: 0x21CCAB0 VA: 0x21D0AB0 Slot: 42
	protected override Vector3 MoveAreaCheck(Vector3 pos) { }

	// RVA: 0x21D0C40 Offset: 0x21CCC40 VA: 0x21D0C40 Slot: 46
	protected override void HitCheckPlayerMove(Vector3 pos, Vector3 move) { }

	// RVA: 0x21D1114 Offset: 0x21CD114 VA: 0x21D1114 Slot: 23
	public override NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21D1138 Offset: 0x21CD138 VA: 0x21D1138 Slot: 24
	public override void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x21D161C Offset: 0x21CD61C VA: 0x21D161C
	public void .ctor() { }
}
