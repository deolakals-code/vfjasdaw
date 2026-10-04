// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaDetailHistory : OperationRequestBase // TypeDefIndex: 11574
{
	// Fields
	[CompilerGenerated]
	private int <GameUniqueId>k__BackingField; // 0x20

	// Properties
	public int GameUniqueId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371D6CC Offset: 0x37196CC VA: 0x371D6CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371D6D4 Offset: 0x37196D4 VA: 0x371D6D4
	public int get_GameUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x371D6DC Offset: 0x37196DC VA: 0x371D6DC
	public void set_GameUniqueId(int value) { }

	// RVA: 0x371D6E4 Offset: 0x37196E4 VA: 0x371D6E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371D6EC Offset: 0x37196EC VA: 0x371D6EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371D6F4 Offset: 0x37196F4 VA: 0x371D6F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371D794 Offset: 0x3719794 VA: 0x371D794 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
