// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.WaveRaid
public class CheckWaveRaidRoom : OperationRequestBase // TypeDefIndex: 11787
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x25

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374B3B4 Offset: 0x37473B4 VA: 0x374B3B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374B3BC Offset: 0x37473BC VA: 0x374B3BC
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x374B3C4 Offset: 0x37473C4 VA: 0x374B3C4
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374B3CC Offset: 0x37473CC VA: 0x374B3CC
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x374B3D4 Offset: 0x37473D4 VA: 0x374B3D4
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374B3DC Offset: 0x37473DC VA: 0x374B3DC
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x374B3E4 Offset: 0x37473E4 VA: 0x374B3E4
	public void set_Flag(byte value) { }

	// RVA: 0x374B3EC Offset: 0x37473EC VA: 0x374B3EC
	public void SetForcibly(bool isForcibly) { }

	// RVA: 0x374B418 Offset: 0x3747418 VA: 0x374B418
	public void SetMatching(bool isMatching) { }

	// RVA: 0x374B438 Offset: 0x3747438 VA: 0x374B438
	public void SetSecondParty(bool isSecondParty) { }

	// RVA: 0x374B3FC Offset: 0x37473FC VA: 0x374B3FC
	private void SetFlag(byte flag, bool isOn) { }

	// RVA: 0x374B458 Offset: 0x3747458 VA: 0x374B458 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374B460 Offset: 0x3747460 VA: 0x374B460 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374B468 Offset: 0x3747468 VA: 0x374B468 Slot: 3
	public override string ToString() { }

	// RVA: 0x374B524 Offset: 0x3747524 VA: 0x374B524 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374B6E8 Offset: 0x37476E8 VA: 0x374B6E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
