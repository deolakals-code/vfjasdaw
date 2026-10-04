// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaDeadDropEvent : EventSubBase // TypeDefIndex: 12664
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

	// RVA: 0x363CEC4 Offset: 0x3638EC4 VA: 0x363CEC4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363CECC Offset: 0x3638ECC VA: 0x363CECC
	public byte get_EquipNo() { }

	[CompilerGenerated]
	// RVA: 0x363CED4 Offset: 0x3638ED4 VA: 0x363CED4
	public void set_EquipNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363CEDC Offset: 0x3638EDC VA: 0x363CEDC
	public short get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x363CEE4 Offset: 0x3638EE4 VA: 0x363CEE4
	public void set_ItemId(short value) { }

	// RVA: 0x363CEEC Offset: 0x3638EEC VA: 0x363CEEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363CEF4 Offset: 0x3638EF4 VA: 0x363CEF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363CEFC Offset: 0x3638EFC VA: 0x363CEFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363CFD4 Offset: 0x3638FD4 VA: 0x363CFD4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
