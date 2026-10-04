// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CraneGame
public class CraneGameAddPlayCountResponse : OperationResponseBase // TypeDefIndex: 12262
{
	// Fields
	[CompilerGenerated]
	private byte <PlayCount>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24

	// Properties
	public byte PlayCount { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E8EB0 Offset: 0x35E4EB0 VA: 0x35E8EB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E8EB8 Offset: 0x35E4EB8 VA: 0x35E8EB8
	public byte get_PlayCount() { }

	[CompilerGenerated]
	// RVA: 0x35E8EC0 Offset: 0x35E4EC0 VA: 0x35E8EC0
	public void set_PlayCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E8EC8 Offset: 0x35E4EC8 VA: 0x35E8EC8
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35E8ED0 Offset: 0x35E4ED0 VA: 0x35E8ED0
	public void set_Gold(int value) { }

	// RVA: 0x35E8ED8 Offset: 0x35E4ED8 VA: 0x35E8ED8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E8EE0 Offset: 0x35E4EE0 VA: 0x35E8EE0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E8EE8 Offset: 0x35E4EE8 VA: 0x35E8EE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E8FC4 Offset: 0x35E4FC4 VA: 0x35E8FC4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
