// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyLeaderChangeEvent : PacketBase // TypeDefIndex: 12875
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366D920 Offset: 0x3669920 VA: 0x366D920
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366D928 Offset: 0x3669928 VA: 0x366D928
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366D930 Offset: 0x3669930 VA: 0x366D930
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366D938 Offset: 0x3669938 VA: 0x366D938
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366D940 Offset: 0x3669940 VA: 0x366D940
	public void set_UserName(string value) { }

	// RVA: 0x366D948 Offset: 0x3669948 VA: 0x366D948 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366D950 Offset: 0x3669950 VA: 0x366D950 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366DAC8 Offset: 0x3669AC8 VA: 0x366DAC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
