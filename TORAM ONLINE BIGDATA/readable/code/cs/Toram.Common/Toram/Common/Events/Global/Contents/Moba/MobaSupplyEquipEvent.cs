// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaSupplyEquipEvent : EventSubBase // TypeDefIndex: 12663
{
	// Fields
	[CompilerGenerated]
	private byte <EquipNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ItemId>k__BackingField; // 0x22

	// Properties
	public byte EquipNo { get; set; }
	public short ItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363CC3C Offset: 0x3638C3C VA: 0x363CC3C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363CC44 Offset: 0x3638C44 VA: 0x363CC44
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x363CC4C Offset: 0x3638C4C VA: 0x363CC4C
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363CC54 Offset: 0x3638C54 VA: 0x363CC54
	public short get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x363CC5C Offset: 0x3638C5C VA: 0x363CC5C
	public void set_ItemId(short value) { }

	// RVA: 0x363CC64 Offset: 0x3638C64 VA: 0x363CC64 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363CC6C Offset: 0x3638C6C VA: 0x363CC6C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363CC74 Offset: 0x3638C74 VA: 0x363CC74 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363CD4C Offset: 0x3638D4C VA: 0x363CD4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
