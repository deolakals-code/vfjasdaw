// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MonsterResultData : PacketBase // TypeDefIndex: 13213
{
	// Fields
	[CompilerGenerated]
	private int <MobUniqueId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ExpType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x28
	[CompilerGenerated]
	private DropData[] <DropList>k__BackingField; // 0x30

	// Properties
	public int MobUniqueId { get; set; }
	public byte ExpType { get; set; }
	public int Exp { get; set; }
	public DropData[] DropList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36E2E5C Offset: 0x36DEE5C VA: 0x36E2E5C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36E2E64 Offset: 0x36DEE64 VA: 0x36E2E64
	public int get_MobUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x36E2E6C Offset: 0x36DEE6C VA: 0x36E2E6C
	public void set_MobUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E2E74 Offset: 0x36DEE74 VA: 0x36E2E74
	public byte get_ExpType() { }

	[CompilerGenerated]
	// RVA: 0x36E2E7C Offset: 0x36DEE7C VA: 0x36E2E7C
	public void set_ExpType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36E2E84 Offset: 0x36DEE84 VA: 0x36E2E84
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x36E2E8C Offset: 0x36DEE8C VA: 0x36E2E8C
	public void set_Exp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36E2E94 Offset: 0x36DEE94 VA: 0x36E2E94
	public DropData[] get_DropList() { }

	[CompilerGenerated]
	// RVA: 0x36E2E9C Offset: 0x36DEE9C VA: 0x36E2E9C
	public void set_DropList(DropData[] value) { }

	// RVA: 0x36E2EA4 Offset: 0x36DEEA4 VA: 0x36E2EA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36E2EAC Offset: 0x36DEEAC VA: 0x36E2EAC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36E3138 Offset: 0x36DF138 VA: 0x36E3138 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
