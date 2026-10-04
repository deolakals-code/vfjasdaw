// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong
public class MahjongMemberData : PacketBase // TypeDefIndex: 12563
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private NewArchetypeProperties <ArchetypeProperties>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x31
	[CompilerGenerated]
	private byte <Psi>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <VoiceId>k__BackingField; // 0x33

	// Properties
	public int ArchetypeId { get; set; }
	public NewArchetypeProperties ArchetypeProperties { get; set; }
	public byte State { get; set; }
	public byte Flag { get; set; }
	public byte Psi { get; set; }
	public byte VoiceId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362190C Offset: 0x361D90C VA: 0x362190C
	public void .ctor() { }

	// RVA: 0x3621914 Offset: 0x361D914 VA: 0x3621914
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362191C Offset: 0x361D91C VA: 0x362191C Slot: 7
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3621924 Offset: 0x361D924 VA: 0x3621924
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362192C Offset: 0x361D92C VA: 0x362192C Slot: 8
	public NewArchetypeProperties get_ArchetypeProperties() { }

	[CompilerGenerated]
	// RVA: 0x3621934 Offset: 0x361D934 VA: 0x3621934
	public void set_ArchetypeProperties(NewArchetypeProperties value) { }

	[CompilerGenerated]
	// RVA: 0x362193C Offset: 0x361D93C VA: 0x362193C Slot: 9
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3621944 Offset: 0x361D944 VA: 0x3621944
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362194C Offset: 0x361D94C VA: 0x362194C Slot: 10
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3621954 Offset: 0x361D954 VA: 0x3621954
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362195C Offset: 0x361D95C VA: 0x362195C Slot: 11
	public byte get_Psi() { }

	[CompilerGenerated]
	// RVA: 0x3621964 Offset: 0x361D964 VA: 0x3621964
	public void set_Psi(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362196C Offset: 0x361D96C VA: 0x362196C Slot: 12
	public byte get_VoiceId() { }

	[CompilerGenerated]
	// RVA: 0x3621974 Offset: 0x361D974 VA: 0x3621974
	public void set_VoiceId(byte value) { }

	// RVA: 0x362197C Offset: 0x361D97C VA: 0x362197C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3621984 Offset: 0x361D984 VA: 0x3621984 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3621B34 Offset: 0x361DB34 VA: 0x3621B34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
