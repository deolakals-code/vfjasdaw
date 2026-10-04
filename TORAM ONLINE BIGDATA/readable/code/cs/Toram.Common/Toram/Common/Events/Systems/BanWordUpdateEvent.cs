// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class BanWordUpdateEvent : PacketBase // TypeDefIndex: 12729
{
	// Fields
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 172, IsOptional = True)]
	public DateTime UpdateDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364C3F0 Offset: 0x36483F0 VA: 0x364C3F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364C3F8 Offset: 0x36483F8 VA: 0x364C3F8
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x364C400 Offset: 0x3648400 VA: 0x364C400
	public void set_UpdateDate(DateTime value) { }

	// RVA: 0x364C408 Offset: 0x3648408 VA: 0x364C408 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364C410 Offset: 0x3648410 VA: 0x364C410 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364C57C Offset: 0x364857C VA: 0x364C57C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
