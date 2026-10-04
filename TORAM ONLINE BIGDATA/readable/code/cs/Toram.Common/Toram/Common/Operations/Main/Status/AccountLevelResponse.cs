// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class AccountLevelResponse : PacketBase // TypeDefIndex: 12073
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x24

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 29, IsOptional = True)]
	public short Level { get; set; }

	// Methods

	// RVA: 0x3782218 Offset: 0x377E218 VA: 0x3782218
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3782220 Offset: 0x377E220 VA: 0x3782220 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3782228 Offset: 0x377E228 VA: 0x3782228
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3782230 Offset: 0x377E230 VA: 0x3782230
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3782238 Offset: 0x377E238 VA: 0x3782238
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3782240 Offset: 0x377E240 VA: 0x3782240
	public void set_Level(short value) { }

	// RVA: 0x3782248 Offset: 0x377E248 VA: 0x3782248 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37823EC Offset: 0x377E3EC VA: 0x37823EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
