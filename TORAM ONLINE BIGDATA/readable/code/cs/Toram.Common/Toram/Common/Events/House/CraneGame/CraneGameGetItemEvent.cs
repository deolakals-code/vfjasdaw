// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CraneGame
public class CraneGameGetItemEvent : EventSubBase // TypeDefIndex: 12829
{
	// Fields
	[CompilerGenerated]
	private string <AvatarName>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <GetCount>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x2C

	// Properties
	public string AvatarName { get; set; }
	public short GetCount { get; set; }
	public int Score { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3663614 Offset: 0x365F614 VA: 0x3663614
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366361C Offset: 0x365F61C VA: 0x366361C
	public string get_AvatarName() { }

	[CompilerGenerated]
	// RVA: 0x3663624 Offset: 0x365F624 VA: 0x3663624
	public void set_AvatarName(string value) { }

	[CompilerGenerated]
	// RVA: 0x366362C Offset: 0x365F62C VA: 0x366362C
	public short get_GetCount() { }

	[CompilerGenerated]
	// RVA: 0x3663634 Offset: 0x365F634 VA: 0x3663634
	public void set_GetCount(short value) { }

	[CompilerGenerated]
	// RVA: 0x366363C Offset: 0x365F63C VA: 0x366363C
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x3663644 Offset: 0x365F644 VA: 0x3663644
	public void set_Score(int value) { }

	// RVA: 0x366364C Offset: 0x365F64C VA: 0x366364C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3663654 Offset: 0x365F654 VA: 0x3663654 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366365C Offset: 0x365F65C VA: 0x366365C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366382C Offset: 0x365F82C VA: 0x366382C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
