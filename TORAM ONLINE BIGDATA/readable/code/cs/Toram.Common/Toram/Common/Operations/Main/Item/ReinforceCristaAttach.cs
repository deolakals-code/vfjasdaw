// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ReinforceCristaAttach : PacketBase // TypeDefIndex: 12149
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <CristaUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ReinforceType>k__BackingField; // 0x29
	[CompilerGenerated]
	private int <ReinforceValue>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 169)]
	public int TargetItemUuid { get; set; }
	[PacketParameter(Code = 170)]
	public int CristaUuid { get; set; }
	[PacketParameter(Code = 171)]
	public byte Slot { get; set; }
	[PacketParameter(Code = 245)]
	public byte ReinforceType { get; set; }
	[PacketParameter(Code = 195)]
	public int ReinforceValue { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3790E48 Offset: 0x378CE48 VA: 0x3790E48
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3790E50 Offset: 0x378CE50 VA: 0x3790E50
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x3790E58 Offset: 0x378CE58 VA: 0x3790E58
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3790E60 Offset: 0x378CE60 VA: 0x3790E60
	public int get_CristaUuid() { }

	[CompilerGenerated]
	// RVA: 0x3790E68 Offset: 0x378CE68 VA: 0x3790E68
	public void set_CristaUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3790E70 Offset: 0x378CE70 VA: 0x3790E70
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x3790E78 Offset: 0x378CE78 VA: 0x3790E78
	public void set_Slot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3790E80 Offset: 0x378CE80 VA: 0x3790E80
	public byte get_ReinforceType() { }

	[CompilerGenerated]
	// RVA: 0x3790E88 Offset: 0x378CE88 VA: 0x3790E88
	public void set_ReinforceType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3790E90 Offset: 0x378CE90 VA: 0x3790E90
	public int get_ReinforceValue() { }

	[CompilerGenerated]
	// RVA: 0x3790E98 Offset: 0x378CE98 VA: 0x3790E98
	public void set_ReinforceValue(int value) { }

	// RVA: 0x3790EA0 Offset: 0x378CEA0 VA: 0x3790EA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3790EA8 Offset: 0x378CEA8 VA: 0x3790EA8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37910F4 Offset: 0x378D0F4 VA: 0x37910F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
