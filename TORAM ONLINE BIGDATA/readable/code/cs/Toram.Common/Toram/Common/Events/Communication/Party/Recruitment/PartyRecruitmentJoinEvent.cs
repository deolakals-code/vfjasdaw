// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party.Recruitment
public class PartyRecruitmentJoinEvent : EventSubBase // TypeDefIndex: 12886
{
	// Fields
	[CompilerGenerated]
	private byte <FrameNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <KickoutMemberType>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <KickoutMemberId>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <KickoutOwnerId>k__BackingField; // 0x38

	// Properties
	public byte FrameNo { get; set; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public byte KickoutMemberType { get; set; }
	public int KickoutMemberId { get; set; }
	public int KickoutOwnerId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x366FB10 Offset: 0x366BB10 VA: 0x366FB10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366FB18 Offset: 0x366BB18 VA: 0x366FB18
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x366FB20 Offset: 0x366BB20 VA: 0x366FB20
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366FB28 Offset: 0x366BB28 VA: 0x366FB28
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x366FB30 Offset: 0x366BB30 VA: 0x366FB30
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366FB38 Offset: 0x366BB38 VA: 0x366FB38
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x366FB40 Offset: 0x366BB40 VA: 0x366FB40
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366FB48 Offset: 0x366BB48 VA: 0x366FB48
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x366FB50 Offset: 0x366BB50 VA: 0x366FB50
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x366FB58 Offset: 0x366BB58 VA: 0x366FB58
	public byte get_KickoutMemberType() { }

	[CompilerGenerated]
	// RVA: 0x366FB60 Offset: 0x366BB60 VA: 0x366FB60
	public void set_KickoutMemberType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x366FB68 Offset: 0x366BB68 VA: 0x366FB68
	public int get_KickoutMemberId() { }

	[CompilerGenerated]
	// RVA: 0x366FB70 Offset: 0x366BB70 VA: 0x366FB70
	public void set_KickoutMemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366FB78 Offset: 0x366BB78 VA: 0x366FB78
	public int get_KickoutOwnerId() { }

	[CompilerGenerated]
	// RVA: 0x366FB80 Offset: 0x366BB80 VA: 0x366FB80
	public void set_KickoutOwnerId(int value) { }

	// RVA: 0x366FB88 Offset: 0x366BB88 VA: 0x366FB88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366FB90 Offset: 0x366BB90 VA: 0x366FB90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x366FB98 Offset: 0x366BB98 VA: 0x366FB98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x366FD30 Offset: 0x366BD30 VA: 0x366FD30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
