// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AcceptPrison : PacketBase // TypeDefIndex: 11943
{
	// Fields
	[CompilerGenerated]
	private int <OffenderId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 200)]
	public int OffenderId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376B634 Offset: 0x3767634 VA: 0x376B634
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376B63C Offset: 0x376763C VA: 0x376B63C
	public int get_OffenderId() { }

	[CompilerGenerated]
	// RVA: 0x376B644 Offset: 0x3767644 VA: 0x376B644
	public void set_OffenderId(int value) { }

	// RVA: 0x376B64C Offset: 0x376764C VA: 0x376B64C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376B654 Offset: 0x3767654 VA: 0x376B654 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376B774 Offset: 0x3767774 VA: 0x376B774 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
