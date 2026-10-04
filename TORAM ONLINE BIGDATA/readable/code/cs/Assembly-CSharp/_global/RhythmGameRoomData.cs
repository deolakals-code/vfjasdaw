// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RhythmGameRoomData : RoomDataBase // TypeDefIndex: 2448
{
	// Fields
	[CompilerGenerated]
	private int <CheckConnect>k__BackingField; // 0x64
	private CameraManager cameraManager; // 0x68

	// Properties
	public int CheckConnect { get; set; }
	public override string[] LoadAssetsPath { get; }
	public override byte RoomType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21B676C Offset: 0x21B276C VA: 0x21B676C
	public int get_CheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x21B6774 Offset: 0x21B2774 VA: 0x21B6774
	private void set_CheckConnect(int value) { }

	// RVA: 0x21B677C Offset: 0x21B277C VA: 0x21B677C Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x21B6804 Offset: 0x21B2804 VA: 0x21B6804 Slot: 28
	public override bool CheckTapPlayerRoom() { }

	// RVA: 0x21B680C Offset: 0x21B280C VA: 0x21B680C Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21B6814 Offset: 0x21B2814 VA: 0x21B6814
	public void .ctor() { }

	// RVA: 0x21B69DC Offset: 0x21B29DC VA: 0x21B69DC
	public void ReceiveRhythmGameData() { }

	// RVA: 0x21B69E4 Offset: 0x21B29E4 VA: 0x21B69E4
	public void Destroy() { }

	// RVA: 0x21B69E8 Offset: 0x21B29E8 VA: 0x21B69E8 Slot: 13
	public override void Enter() { }

	// RVA: 0x21B69EC Offset: 0x21B29EC VA: 0x21B69EC Slot: 14
	public override void Leave() { }

	// RVA: 0x21B69F0 Offset: 0x21B29F0 VA: 0x21B69F0 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21B6AD8 Offset: 0x21B2AD8 VA: 0x21B6AD8 Slot: 15
	public override void Update() { }

	// RVA: 0x21B6B5C Offset: 0x21B2B5C VA: 0x21B6B5C Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21B6B60 Offset: 0x21B2B60 VA: 0x21B6B60 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21B6B64 Offset: 0x21B2B64 VA: 0x21B6B64 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x21B6B6C Offset: 0x21B2B6C VA: 0x21B6B6C Slot: 11
	public override void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x21B6B70 Offset: 0x21B2B70 VA: 0x21B6B70 Slot: 12
	public override void Clear() { }

	// RVA: 0x21B6B7C Offset: 0x21B2B7C VA: 0x21B6B7C Slot: 29
	public override bool CheckVisibleOtherPlayerRoom(Archetype archetype) { }

	// RVA: 0x21B6B84 Offset: 0x21B2B84 VA: 0x21B6B84 Slot: 32
	public override bool InitCameraUpdate(CameraManager manager) { }
}
