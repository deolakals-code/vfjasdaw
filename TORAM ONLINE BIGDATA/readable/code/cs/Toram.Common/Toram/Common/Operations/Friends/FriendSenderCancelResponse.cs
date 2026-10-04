// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendSenderCancelResponse : PacketBase // TypeDefIndex: 11646
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x372AC48 Offset: 0x3726C48 VA: 0x372AC48
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372AC50 Offset: 0x3726C50 VA: 0x372AC50
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x372AC58 Offset: 0x3726C58 VA: 0x372AC58
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x372AC60 Offset: 0x3726C60 VA: 0x372AC60
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x372AC68 Offset: 0x3726C68 VA: 0x372AC68
	public void set_TargetName(string value) { }

	// RVA: 0x372AC70 Offset: 0x3726C70 VA: 0x372AC70 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372AC78 Offset: 0x3726C78 VA: 0x372AC78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372ADF0 Offset: 0x3726DF0 VA: 0x372ADF0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
