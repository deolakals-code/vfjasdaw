// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class DefencePopMobEvent : EventSubBase // TypeDefIndex: 12774
{
	// Fields
	[CompilerGenerated]
	private DefenceMobData[] <MobList>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PopType>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 89, IsOptional = True)]
	public DefenceMobData[] MobList { get; set; }
	[PacketClass(Code = 245)]
	public byte PopType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365610C Offset: 0x365210C VA: 0x365610C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3656114 Offset: 0x3652114 VA: 0x3656114
	public DefenceMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365611C Offset: 0x365211C VA: 0x365611C
	public void set_MobList(DefenceMobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3656124 Offset: 0x3652124 VA: 0x3656124
	public byte get_PopType() { }

	[CompilerGenerated]
	// RVA: 0x365612C Offset: 0x365212C VA: 0x365612C
	public void set_PopType(byte value) { }

	// RVA: 0x3656134 Offset: 0x3652134 VA: 0x3656134
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3656234 Offset: 0x3652234 VA: 0x3656234
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36562C0 Offset: 0x36522C0 VA: 0x36562C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36562C8 Offset: 0x36522C8 VA: 0x36562C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36562D0 Offset: 0x36522D0 VA: 0x36562D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3656400 Offset: 0x3652400 VA: 0x3656400 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
