// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class EndComboBonusEvent : PacketBase // TypeDefIndex: 12605
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362F004 Offset: 0x362B004 VA: 0x362F004
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362F00C Offset: 0x362B00C VA: 0x362F00C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x362F014 Offset: 0x362B014 VA: 0x362F014
	public void set_ArchetypeId(int value) { }

	// RVA: 0x362F01C Offset: 0x362B01C VA: 0x362F01C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362F024 Offset: 0x362B024 VA: 0x362F024 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x362F0F8 Offset: 0x362B0F8 VA: 0x362F0F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
