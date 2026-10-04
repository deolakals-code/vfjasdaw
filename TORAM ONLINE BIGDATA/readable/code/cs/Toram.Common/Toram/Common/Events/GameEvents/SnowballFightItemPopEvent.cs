// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class SnowballFightItemPopEvent : EventSubBase // TypeDefIndex: 12680
{
	// Fields
	[CompilerGenerated]
	private byte <ItemUid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ItemType>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <PopPoint>k__BackingField; // 0x22

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public byte ItemUid { get; set; }
	public byte ItemType { get; set; }
	public byte PopPoint { get; set; }

	// Methods

	// RVA: 0x364094C Offset: 0x363C94C VA: 0x364094C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3640954 Offset: 0x363C954 VA: 0x3640954 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x364095C Offset: 0x363C95C VA: 0x364095C
	public byte get_ItemUid() { }

	[CompilerGenerated]
	// RVA: 0x3640964 Offset: 0x363C964 VA: 0x3640964
	public void set_ItemUid(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364096C Offset: 0x363C96C VA: 0x364096C
	public byte get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x3640974 Offset: 0x363C974 VA: 0x3640974
	public void set_ItemType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364097C Offset: 0x363C97C VA: 0x364097C
	public byte get_PopPoint() { }

	[CompilerGenerated]
	// RVA: 0x3640984 Offset: 0x363C984 VA: 0x3640984
	public void set_PopPoint(byte value) { }

	// RVA: 0x364098C Offset: 0x363C98C VA: 0x364098C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3640994 Offset: 0x363C994 VA: 0x3640994 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3640A8C Offset: 0x363CA8C VA: 0x3640A8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
