// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class CristaBreak : PacketBase // TypeDefIndex: 12153
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 169)]
	public int TargetItemUuid { get; set; }
	[PacketParameter(Code = 171)]
	public byte Slot { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3792150 Offset: 0x378E150 VA: 0x3792150
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3792158 Offset: 0x378E158 VA: 0x3792158
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x3792160 Offset: 0x378E160 VA: 0x3792160
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3792168 Offset: 0x378E168 VA: 0x3792168
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x3792170 Offset: 0x378E170 VA: 0x3792170
	public void set_Slot(byte value) { }

	// RVA: 0x3792178 Offset: 0x378E178 VA: 0x3792178 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3792180 Offset: 0x378E180 VA: 0x3792180 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37922F8 Offset: 0x378E2F8 VA: 0x37922F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
