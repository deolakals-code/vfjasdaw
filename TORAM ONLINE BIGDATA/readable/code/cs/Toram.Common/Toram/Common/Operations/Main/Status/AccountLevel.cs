// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class AccountLevel : PacketBase // TypeDefIndex: 12072
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }

	// Methods

	// RVA: 0x3782004 Offset: 0x377E004 VA: 0x3782004
	public void .ctor() { }

	// RVA: 0x378200C Offset: 0x377E00C VA: 0x378200C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3782014 Offset: 0x377E014 VA: 0x3782014
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x378201C Offset: 0x377E01C VA: 0x378201C
	public void set_AvatarUuid(int value) { }

	// RVA: 0x3782024 Offset: 0x377E024 VA: 0x3782024 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3782144 Offset: 0x377E144 VA: 0x3782144 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
