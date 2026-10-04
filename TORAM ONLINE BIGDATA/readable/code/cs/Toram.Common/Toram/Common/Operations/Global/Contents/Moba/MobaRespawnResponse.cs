// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaRespawnResponse : OperationResponseBase // TypeDefIndex: 11612
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x22
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <State>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public short RespawnTime { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public int State { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3724D90 Offset: 0x3720D90 VA: 0x3724D90
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3724D98 Offset: 0x3720D98 VA: 0x3724D98
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3724DA0 Offset: 0x3720DA0 VA: 0x3724DA0
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3724DA8 Offset: 0x3720DA8 VA: 0x3724DA8
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x3724DB0 Offset: 0x3720DB0 VA: 0x3724DB0
	public void set_RespawnTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x3724DB8 Offset: 0x3720DB8 VA: 0x3724DB8
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3724DC0 Offset: 0x3720DC0 VA: 0x3724DC0
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3724DC8 Offset: 0x3720DC8 VA: 0x3724DC8
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x3724DD0 Offset: 0x3720DD0 VA: 0x3724DD0
	public void set_State(int value) { }

	// RVA: 0x3724DD8 Offset: 0x3720DD8 VA: 0x3724DD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3724DE0 Offset: 0x3720DE0 VA: 0x3724DE0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3724DE8 Offset: 0x3720DE8 VA: 0x3724DE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3724F28 Offset: 0x3720F28 VA: 0x3724F28 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
