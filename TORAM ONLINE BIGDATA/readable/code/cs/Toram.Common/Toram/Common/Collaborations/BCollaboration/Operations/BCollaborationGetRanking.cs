// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationGetRanking : OperationRequestBase // TypeDefIndex: 13063
{
	// Fields
	[CompilerGenerated]
	private short <MainWeapon>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SubWeapon>k__BackingField; // 0x22

	// Properties
	[PacketParameter(Code = 78)]
	public short MainWeapon { get; set; }
	[PacketParameter(Code = 79)]
	public short SubWeapon { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369B308 Offset: 0x3697308 VA: 0x369B308
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x369B310 Offset: 0x3697310 VA: 0x369B310
	public short get_MainWeapon() { }

	[CompilerGenerated]
	// RVA: 0x369B318 Offset: 0x3697318 VA: 0x369B318
	public void set_MainWeapon(short value) { }

	[CompilerGenerated]
	// RVA: 0x369B320 Offset: 0x3697320 VA: 0x369B320
	public short get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x369B328 Offset: 0x3697328 VA: 0x369B328
	public void set_SubWeapon(short value) { }

	// RVA: 0x369B330 Offset: 0x3697330 VA: 0x369B330 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369B338 Offset: 0x3697338 VA: 0x369B338 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369B340 Offset: 0x3697340 VA: 0x369B340 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369B4AC Offset: 0x36974AC VA: 0x369B4AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
