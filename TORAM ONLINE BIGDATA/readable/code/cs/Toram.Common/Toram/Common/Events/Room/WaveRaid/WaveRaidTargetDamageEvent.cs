// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidTargetDamageEvent : EventSubBase // TypeDefIndex: 12788
{
	// Fields
	[CompilerGenerated]
	private short <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetHp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 96)]
	public short TargetId { get; set; }
	[PacketParameter(Code = 25)]
	public int TargetHp { get; set; }
	[PacketParameter(Code = 195)]
	public int Damage { get; set; }

	// Methods

	// RVA: 0x3659234 Offset: 0x3655234 VA: 0x3659234 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365923C Offset: 0x365523C VA: 0x365923C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3659244 Offset: 0x3655244 VA: 0x3659244
	public short get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x365924C Offset: 0x365524C VA: 0x365924C
	public void set_TargetId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3659254 Offset: 0x3655254 VA: 0x3659254
	public int get_TargetHp() { }

	[CompilerGenerated]
	// RVA: 0x365925C Offset: 0x365525C VA: 0x365925C
	public void set_TargetHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3659264 Offset: 0x3655264 VA: 0x3659264
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x365926C Offset: 0x365526C VA: 0x365926C
	public void set_Damage(int value) { }

	// RVA: 0x3659274 Offset: 0x3655274 VA: 0x3659274
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x365927C Offset: 0x365527C VA: 0x365927C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3659280 Offset: 0x3655280 VA: 0x3659280
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3659284 Offset: 0x3655284 VA: 0x3659284 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3659448 Offset: 0x3655448 VA: 0x3659448 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
