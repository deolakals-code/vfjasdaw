// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaRespawnGhostResponse : OperationResponseBase // TypeDefIndex: 11611
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
	[CompilerGenerated]
	private int <SecondUntilNextWarp>k__BackingField; // 0x34

	// Properties
	public short ReturnCode { get; set; }
	public short RespawnTime { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public int State { get; set; }
	public int SecondUntilNextWarp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37248AC Offset: 0x37208AC VA: 0x37248AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37248B4 Offset: 0x37208B4 VA: 0x37248B4
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37248BC Offset: 0x37208BC VA: 0x37248BC
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x37248C4 Offset: 0x37208C4 VA: 0x37248C4
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x37248CC Offset: 0x37208CC VA: 0x37248CC
	public void set_RespawnTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x37248D4 Offset: 0x37208D4 VA: 0x37248D4
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x37248DC Offset: 0x37208DC VA: 0x37248DC
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x37248E4 Offset: 0x37208E4 VA: 0x37248E4
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x37248EC Offset: 0x37208EC VA: 0x37248EC
	public void set_State(int value) { }

	[CompilerGenerated]
	// RVA: 0x37248F4 Offset: 0x37208F4 VA: 0x37248F4
	public int get_SecondUntilNextWarp() { }

	[CompilerGenerated]
	// RVA: 0x37248FC Offset: 0x37208FC VA: 0x37248FC
	public void set_SecondUntilNextWarp(int value) { }

	// RVA: 0x3724904 Offset: 0x3720904 VA: 0x3724904 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372490C Offset: 0x372090C VA: 0x372490C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3724914 Offset: 0x3720914 VA: 0x3724914 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3724A7C Offset: 0x3720A7C VA: 0x3724A7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
