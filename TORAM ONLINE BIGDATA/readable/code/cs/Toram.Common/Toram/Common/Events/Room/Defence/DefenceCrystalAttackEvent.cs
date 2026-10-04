// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class DefenceCrystalAttackEvent : EventSubBase // TypeDefIndex: 12771
{
	// Fields
	[CompilerGenerated]
	private MobData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <CrystalId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <CrystalHp>k__BackingField; // 0x2C

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 76, IsOptional = True)]
	public MobData MobData { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public byte CrystalId { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int CrystalHp { get; set; }

	// Methods

	// RVA: 0x36554D4 Offset: 0x36514D4 VA: 0x36554D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36554DC Offset: 0x36514DC VA: 0x36554DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36554E4 Offset: 0x36514E4 VA: 0x36554E4 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36554EC Offset: 0x36514EC VA: 0x36554EC
	public MobData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36554F4 Offset: 0x36514F4 VA: 0x36554F4
	public void set_MobData(MobData value) { }

	[CompilerGenerated]
	// RVA: 0x36554FC Offset: 0x36514FC VA: 0x36554FC
	public byte get_CrystalId() { }

	[CompilerGenerated]
	// RVA: 0x3655504 Offset: 0x3651504 VA: 0x3655504
	public void set_CrystalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365550C Offset: 0x365150C VA: 0x365550C
	public int get_CrystalHp() { }

	[CompilerGenerated]
	// RVA: 0x3655514 Offset: 0x3651514 VA: 0x3655514
	public void set_CrystalHp(int value) { }

	// RVA: 0x365551C Offset: 0x365151C VA: 0x365551C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x365563C Offset: 0x365163C VA: 0x365563C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36556B8 Offset: 0x36516B8 VA: 0x36556B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3655840 Offset: 0x3651840 VA: 0x3655840 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
