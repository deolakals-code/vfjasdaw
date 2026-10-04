// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaArchetypeUnsubscribed : EventSubBase // TypeDefIndex: 12666
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363D654 Offset: 0x3639654 VA: 0x363D654
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363D65C Offset: 0x363965C VA: 0x363D65C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363D664 Offset: 0x3639664 VA: 0x363D664
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363D66C Offset: 0x363966C VA: 0x363D66C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363D674 Offset: 0x3639674 VA: 0x363D674
	public void set_ArchetypeId(int value) { }

	// RVA: 0x363D67C Offset: 0x363967C VA: 0x363D67C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363D684 Offset: 0x3639684 VA: 0x363D684 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363D68C Offset: 0x363968C VA: 0x363D68C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363D764 Offset: 0x3639764 VA: 0x363D764 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
