// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeActionLightEvent : PacketBase // TypeDefIndex: 12601
{
	// Fields
	[CompilerGenerated]
	private byte <ActionCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <ActionBinary>k__BackingField; // 0x28

	// Properties
	public byte ActionCode { get; set; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte[] ActionBinary { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362E0AC Offset: 0x362A0AC VA: 0x362E0AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362E0B4 Offset: 0x362A0B4 VA: 0x362E0B4
	public byte get_ActionCode() { }

	[CompilerGenerated]
	// RVA: 0x362E0BC Offset: 0x362A0BC VA: 0x362E0BC
	public void set_ActionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362E0C4 Offset: 0x362A0C4 VA: 0x362E0C4
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x362E0CC Offset: 0x362A0CC VA: 0x362E0CC
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362E0D4 Offset: 0x362A0D4 VA: 0x362E0D4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x362E0DC Offset: 0x362A0DC VA: 0x362E0DC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362E0E4 Offset: 0x362A0E4 VA: 0x362E0E4
	public byte[] get_ActionBinary() { }

	[CompilerGenerated]
	// RVA: 0x362E0EC Offset: 0x362A0EC VA: 0x362E0EC
	public void set_ActionBinary(byte[] value) { }

	// RVA: 0x362E0F4 Offset: 0x362A0F4 VA: 0x362E0F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362E0FC Offset: 0x362A0FC VA: 0x362E0FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x362E24C Offset: 0x362A24C VA: 0x362E24C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
