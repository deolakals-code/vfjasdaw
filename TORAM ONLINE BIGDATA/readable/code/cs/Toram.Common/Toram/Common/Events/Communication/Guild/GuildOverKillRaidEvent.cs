// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildOverKillRaidEvent : EventSubBase // TypeDefIndex: 12904
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <HpGage>k__BackingField; // 0x28

	// Properties
	public string Name { get; set; }
	public byte HpGage { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36737F0 Offset: 0x366F7F0 VA: 0x36737F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36737F8 Offset: 0x366F7F8 VA: 0x36737F8
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3673800 Offset: 0x366F800 VA: 0x3673800
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3673808 Offset: 0x366F808 VA: 0x3673808
	public byte get_HpGage() { }

	[CompilerGenerated]
	// RVA: 0x3673810 Offset: 0x366F810 VA: 0x3673810
	public void set_HpGage(byte value) { }

	// RVA: 0x3673818 Offset: 0x366F818 VA: 0x3673818 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3673820 Offset: 0x366F820 VA: 0x3673820 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3673828 Offset: 0x366F828 VA: 0x3673828 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36738D8 Offset: 0x366F8D8 VA: 0x36738D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
