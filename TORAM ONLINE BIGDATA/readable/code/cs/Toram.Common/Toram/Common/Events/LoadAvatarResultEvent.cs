// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class LoadAvatarResultEvent : PacketBase // TypeDefIndex: 12608
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20

	// Properties
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362F800 Offset: 0x362B800 VA: 0x362F800
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362F808 Offset: 0x362B808 VA: 0x362F808
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x362F810 Offset: 0x362B810 VA: 0x362F810
	public void set_ReturnCode(short value) { }

	// RVA: 0x362F818 Offset: 0x362B818 VA: 0x362F818 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362F820 Offset: 0x362B820 VA: 0x362F820 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x362F940 Offset: 0x362B940 VA: 0x362F940 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
