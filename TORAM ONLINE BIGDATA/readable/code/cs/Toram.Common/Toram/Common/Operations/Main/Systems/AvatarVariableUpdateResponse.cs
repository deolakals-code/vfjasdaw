// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AvatarVariableUpdateResponse : PacketBase // TypeDefIndex: 11950
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ValueI>k__BackingField; // 0x24
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x28

	// Properties
	public byte Type { get; set; }
	public int ValueI { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376C8DC Offset: 0x37688DC VA: 0x376C8DC
	public void .ctor() { }

	// RVA: 0x376C8E4 Offset: 0x37688E4 VA: 0x376C8E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376C8EC Offset: 0x37688EC VA: 0x376C8EC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x376C8F4 Offset: 0x37688F4 VA: 0x376C8F4
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376C8FC Offset: 0x37688FC VA: 0x376C8FC
	public int get_ValueI() { }

	[CompilerGenerated]
	// RVA: 0x376C904 Offset: 0x3768904 VA: 0x376C904
	public void set_ValueI(int value) { }

	[CompilerGenerated]
	// RVA: 0x376C90C Offset: 0x376890C VA: 0x376C90C
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x376C914 Offset: 0x3768914 VA: 0x376C914
	public void set_Reward(RewardResponseDatav2 value) { }

	// RVA: 0x376C91C Offset: 0x376891C VA: 0x376C91C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376C924 Offset: 0x3768924 VA: 0x376C924 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376CB70 Offset: 0x3768B70 VA: 0x376CB70 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
