// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidMoveMobEvent : EventSubBase // TypeDefIndex: 12784
{
	// Fields
	[CompilerGenerated]
	private MobData[] <MobList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 89, IsOptional = True)]
	public MobData[] MobList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36581BC Offset: 0x36541BC VA: 0x36581BC
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36581C4 Offset: 0x36541C4 VA: 0x36581C4
	public void set_MobList(MobData[] value) { }

	// RVA: 0x36581CC Offset: 0x36541CC VA: 0x36581CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36581D4 Offset: 0x36541D4 VA: 0x36581D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36581DC Offset: 0x36541DC VA: 0x36581DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36581E4 Offset: 0x36541E4 VA: 0x36581E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365837C Offset: 0x365437C VA: 0x365837C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365827C Offset: 0x365427C VA: 0x365827C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36583B0 Offset: 0x36543B0 VA: 0x36583B0
	private void GetClass(Dictionary<byte, object> parameters) { }
}
