// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidPopMobEvent : EventSubBase // TypeDefIndex: 12786
{
	// Fields
	[CompilerGenerated]
	private short[] <PopIds>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <PopMaxIds>k__BackingField; // 0x28
	[CompilerGenerated]
	private WaveMobData[] <MobList>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 19, IsOptional = True)]
	public short[] PopIds { get; set; }
	[PacketClass(Code = 185, IsOptional = True)]
	public short[] PopMaxIds { get; set; }
	[PacketClass(Code = 89, IsOptional = True)]
	public WaveMobData[] MobList { get; set; }

	// Methods

	// RVA: 0x36588D0 Offset: 0x36548D0 VA: 0x36588D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36588D8 Offset: 0x36548D8 VA: 0x36588D8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36588E0 Offset: 0x36548E0 VA: 0x36588E0
	public short[] get_PopIds() { }

	[CompilerGenerated]
	// RVA: 0x36588E8 Offset: 0x36548E8 VA: 0x36588E8
	public void set_PopIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36588F0 Offset: 0x36548F0 VA: 0x36588F0
	public short[] get_PopMaxIds() { }

	[CompilerGenerated]
	// RVA: 0x36588F8 Offset: 0x36548F8 VA: 0x36588F8
	public void set_PopMaxIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3658900 Offset: 0x3654900 VA: 0x3658900
	public WaveMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3658908 Offset: 0x3654908 VA: 0x3658908
	public void set_MobList(WaveMobData[] value) { }

	// RVA: 0x3658910 Offset: 0x3654910 VA: 0x3658910
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658918 Offset: 0x3654918 VA: 0x3658918
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658A18 Offset: 0x3654A18 VA: 0x3658A18
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658AA4 Offset: 0x3654AA4 VA: 0x3658AA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658C8C Offset: 0x3654C8C VA: 0x3658C8C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
