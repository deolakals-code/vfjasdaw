// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaChestEvent : EventSubBase // TypeDefIndex: 12668
{
	// Fields
	[CompilerGenerated]
	private int[] <ChestUniqueIds>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x28

	// Properties
	public int[] ChestUniqueIds { get; set; }
	public byte State { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363D8DC Offset: 0x36398DC VA: 0x363D8DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363D8E4 Offset: 0x36398E4 VA: 0x363D8E4
	public int[] get_ChestUniqueIds() { }

	[CompilerGenerated]
	// RVA: 0x363D8EC Offset: 0x36398EC VA: 0x363D8EC
	public void set_ChestUniqueIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x363D8F4 Offset: 0x36398F4 VA: 0x363D8F4
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x363D8FC Offset: 0x36398FC VA: 0x363D8FC
	public void set_State(byte value) { }

	// RVA: 0x363D904 Offset: 0x3639904 VA: 0x363D904 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363D90C Offset: 0x363990C VA: 0x363D90C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363D914 Offset: 0x3639914 VA: 0x363D914 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363D9C0 Offset: 0x36399C0 VA: 0x363D9C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
