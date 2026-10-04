// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Operations
public class CheckNewWaveRoomResponse : OperationResponseBase // TypeDefIndex: 13046
{
	// Fields
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <PointBoost>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 29, IsOptional = True)]
	public RoomLobbySetting Setting { get; set; }
	[PacketParameter(Code = 5, IsOptional = True)]
	public RoomMemberData[] Members { get; set; }
	public byte PointBoost { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3696AB0 Offset: 0x3692AB0 VA: 0x3696AB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3696AB8 Offset: 0x3692AB8 VA: 0x3696AB8
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3696AC0 Offset: 0x3692AC0 VA: 0x3696AC0
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x3696AC8 Offset: 0x3692AC8 VA: 0x3696AC8
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3696AD0 Offset: 0x3692AD0 VA: 0x3696AD0
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3696AD8 Offset: 0x3692AD8 VA: 0x3696AD8
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x3696AE0 Offset: 0x3692AE0 VA: 0x3696AE0
	public void set_PointBoost(byte value) { }

	// RVA: 0x3696AE8 Offset: 0x3692AE8 VA: 0x3696AE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3696AF0 Offset: 0x3692AF0 VA: 0x3696AF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3696AF8 Offset: 0x3692AF8 VA: 0x3696AF8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3696D7C Offset: 0x3692D7C VA: 0x3696D7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
