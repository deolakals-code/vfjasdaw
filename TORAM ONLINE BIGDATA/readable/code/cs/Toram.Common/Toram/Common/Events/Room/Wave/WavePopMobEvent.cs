// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WavePopMobEvent : EventSubBase // TypeDefIndex: 12765
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

	// RVA: 0x36541CC Offset: 0x36501CC VA: 0x36541CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36541D4 Offset: 0x36501D4 VA: 0x36541D4 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36541DC Offset: 0x36501DC VA: 0x36541DC
	public short[] get_PopIds() { }

	[CompilerGenerated]
	// RVA: 0x36541E4 Offset: 0x36501E4 VA: 0x36541E4
	public void set_PopIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36541EC Offset: 0x36501EC VA: 0x36541EC
	public short[] get_PopMaxIds() { }

	[CompilerGenerated]
	// RVA: 0x36541F4 Offset: 0x36501F4 VA: 0x36541F4
	public void set_PopMaxIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36541FC Offset: 0x36501FC VA: 0x36541FC
	public WaveMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3654204 Offset: 0x3650204 VA: 0x3654204
	public void set_MobList(WaveMobData[] value) { }

	// RVA: 0x365420C Offset: 0x365020C VA: 0x365420C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654214 Offset: 0x3650214 VA: 0x3654214
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654314 Offset: 0x3650314 VA: 0x3654314
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36543A0 Offset: 0x36503A0 VA: 0x36543A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654588 Offset: 0x3650588 VA: 0x3654588 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
