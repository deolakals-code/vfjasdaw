// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class DungeonTrapDamageResponseData : UnityHashBase // TypeDefIndex: 13154
{
	// Fields
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 50)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B6EBC Offset: 0x36B2EBC VA: 0x36B6EBC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B6EC4 Offset: 0x36B2EC4 VA: 0x36B6EC4
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36B6ECC Offset: 0x36B2ECC VA: 0x36B6ECC
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B6ED4 Offset: 0x36B2ED4 VA: 0x36B6ED4
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36B6EDC Offset: 0x36B2EDC VA: 0x36B6EDC
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x36B6EE4 Offset: 0x36B2EE4 VA: 0x36B6EE4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B6EEC Offset: 0x36B2EEC VA: 0x36B6EEC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B70E8 Offset: 0x36B30E8 VA: 0x36B70E8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
