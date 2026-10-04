// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class HouseBgmChangeEvent : EventSubBase // TypeDefIndex: 12606
{
	// Fields
	[CompilerGenerated]
	private int <BgmItemId>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 200)]
	public int BgmItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x362F218 Offset: 0x362B218 VA: 0x362F218
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362F228 Offset: 0x362B228 VA: 0x362F228
	public int get_BgmItemId() { }

	[CompilerGenerated]
	// RVA: 0x362F230 Offset: 0x362B230 VA: 0x362F230
	public void set_BgmItemId(int value) { }

	// RVA: 0x362F238 Offset: 0x362B238 VA: 0x362F238 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362F240 Offset: 0x362B240 VA: 0x362F240 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x362F248 Offset: 0x362B248 VA: 0x362F248 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x362F368 Offset: 0x362B368 VA: 0x362F368 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
