// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewWaveEventData : GameEventDataBase // TypeDefIndex: 1861
{
	// Fields
	public const byte MaxPointBoost = 9;
	private NewWaveEventData eventData; // 0x18

	// Properties
	public override byte GameEventType { get; }
	public byte PointBoost { get; }

	// Methods

	// RVA: 0x20F2E9C Offset: 0x20EEE9C VA: 0x20F2E9C Slot: 4
	public override byte get_GameEventType() { }

	// RVA: 0x20F2EA4 Offset: 0x20EEEA4 VA: 0x20F2EA4
	public byte get_PointBoost() { }

	// RVA: 0x20F2EBC Offset: 0x20EEEBC VA: 0x20F2EBC Slot: 7
	public override void Clear() { }

	// RVA: 0x20F2EC0 Offset: 0x20EEEC0 VA: 0x20F2EC0 Slot: 5
	public override void Initialize(byte[] binary) { }

	// RVA: 0x20F2F44 Offset: 0x20EEF44 VA: 0x20F2F44 Slot: 8
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x20EC5F4 Offset: 0x20E85F4 VA: 0x20EC5F4
	public void .ctor() { }
}
