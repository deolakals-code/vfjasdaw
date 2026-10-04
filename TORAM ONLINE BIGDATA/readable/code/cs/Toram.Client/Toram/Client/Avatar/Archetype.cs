// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class Archetype : IDisposable // TypeDefIndex: 15145
{
	// Fields
	[CompilerGenerated]
	private Game <Game>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ArchetypeUid <ArchetypeUid>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x28
	[CompilerGenerated]
	private NewArchetypeProperties <Properties>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PropertyRevision>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsDestroyed>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <IsArea>k__BackingField; // 0x3D
	[CompilerGenerated]
	private bool <IsPartyMember>k__BackingField; // 0x3E
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <Rotation>k__BackingField; // 0x48

	// Properties
	[CLSCompliant(False)]
	public Game Game { get; set; }
	public byte Type { get; set; }
	public int Id { get; set; }
	public ArchetypeUid ArchetypeUid { get; set; }
	public string Name { get; }
	protected long UniqueId { set; }
	public int GuildId { get; }
	public string GuildName { get; }
	public byte GuildPost { get; }
	public NewArchetypeProperties Properties { get; set; }
	public int PropertyRevision { get; set; }
	public bool IsDestroyed { set; }
	public virtual bool IsMine { get; }
	public bool IsArea { get; set; }
	public bool IsPartyMember { get; set; }
	public short[] Position { get; set; }
	public float Rotation { get; set; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35AB4F4 Offset: 0x35A74F4 VA: 0x35AB4F4
	protected void .ctor(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x35AB5B8 Offset: 0x35A75B8 VA: 0x35AB5B8 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	// RVA: 0x35AB658 Offset: 0x35A7658 VA: 0x35AB658
	public Game get_Game() { }

	[CompilerGenerated]
	// RVA: 0x35AB660 Offset: 0x35A7660 VA: 0x35AB660
	private void set_Game(Game value) { }

	[CompilerGenerated]
	// RVA: 0x35AB668 Offset: 0x35A7668 VA: 0x35AB668
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35AB670 Offset: 0x35A7670 VA: 0x35AB670
	private void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35AB678 Offset: 0x35A7678 VA: 0x35AB678
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35AB680 Offset: 0x35A7680 VA: 0x35AB680
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35AB688 Offset: 0x35A7688 VA: 0x35AB688
	public ArchetypeUid get_ArchetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x35AB690 Offset: 0x35A7690 VA: 0x35AB690
	private void set_ArchetypeUid(ArchetypeUid value) { }

	// RVA: 0x35AB698 Offset: 0x35A7698 VA: 0x35AB698
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x35AB6B4 Offset: 0x35A76B4 VA: 0x35AB6B4
	protected void set_UniqueId(long value) { }

	// RVA: 0x35AB6BC Offset: 0x35A76BC VA: 0x35AB6BC
	public int get_GuildId() { }

	// RVA: 0x35AB6D8 Offset: 0x35A76D8 VA: 0x35AB6D8
	public string get_GuildName() { }

	// RVA: 0x35AB6F4 Offset: 0x35A76F4 VA: 0x35AB6F4
	public byte get_GuildPost() { }

	[CompilerGenerated]
	// RVA: 0x35AB710 Offset: 0x35A7710 VA: 0x35AB710
	public NewArchetypeProperties get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x35AB718 Offset: 0x35A7718 VA: 0x35AB718
	private void set_Properties(NewArchetypeProperties value) { }

	[CompilerGenerated]
	// RVA: 0x35AB720 Offset: 0x35A7720 VA: 0x35AB720
	public int get_PropertyRevision() { }

	[CompilerGenerated]
	// RVA: 0x35AB728 Offset: 0x35A7728 VA: 0x35AB728
	private void set_PropertyRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x35AB730 Offset: 0x35A7730 VA: 0x35AB730
	public void set_IsDestroyed(bool value) { }

	// RVA: 0x35AB73C Offset: 0x35A773C VA: 0x35AB73C Slot: 5
	public virtual bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x35AB744 Offset: 0x35A7744 VA: 0x35AB744
	public bool get_IsArea() { }

	[CompilerGenerated]
	// RVA: 0x35AB74C Offset: 0x35A774C VA: 0x35AB74C
	public void set_IsArea(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35AB758 Offset: 0x35A7758 VA: 0x35AB758
	public bool get_IsPartyMember() { }

	[CompilerGenerated]
	// RVA: 0x35AB760 Offset: 0x35A7760 VA: 0x35AB760
	public void set_IsPartyMember(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35AB76C Offset: 0x35A776C VA: 0x35AB76C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x35AB774 Offset: 0x35A7774 VA: 0x35AB774
	private void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35AB77C Offset: 0x35A777C VA: 0x35AB77C
	public float get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x35AB784 Offset: 0x35A7784 VA: 0x35AB784
	private void set_Rotation(float value) { }

	// RVA: 0x35AB78C Offset: 0x35A778C VA: 0x35AB78C Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x35AB790 Offset: 0x35A7790 VA: 0x35AB790 Slot: 4
	public void Dispose() { }

	// RVA: 0x35AB7FC Offset: 0x35A77FC VA: 0x35AB7FC Slot: 3
	public override string ToString() { }

	// RVA: 0x35AB8BC Offset: 0x35A78BC VA: 0x35AB8BC
	internal void SetArea(bool isArea) { }

	// RVA: 0x35AB8C8 Offset: 0x35A78C8 VA: 0x35AB8C8
	internal void SetPartyMember(bool isMember) { }

	// RVA: 0x35AB8D4 Offset: 0x35A78D4 VA: 0x35AB8D4
	public void LeavePartyMember() { }

	// RVA: 0x35AB910 Offset: 0x35A7910 VA: 0x35AB910
	public void SetPosition(short[] position, float rotation) { }

	// RVA: 0x35AB93C Offset: 0x35A793C VA: 0x35AB93C
	public void SetPosition(short[] position) { }

	// RVA: 0x35AB94C Offset: 0x35A794C VA: 0x35AB94C
	public void SetArchetypeProperties(Dictionary<byte, object> updateProperties, int propertiesRevision) { }

	// RVA: 0x35AB988 Offset: 0x35A7988 VA: 0x35AB988 Slot: 7
	public virtual void SetAdditionnalData(AdditionalData additionalData) { }

	// RVA: 0x35AB98C Offset: 0x35A798C VA: 0x35AB98C
	public void OperationGetProperties() { }

	// RVA: 0x35AB9A4 Offset: 0x35A79A4 VA: 0x35AB9A4
	public void ReceiveActionEvent(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x35AB9B0 Offset: 0x35A79B0 VA: 0x35AB9B0
	protected float CorrectionRotation(float rot) { }

	// RVA: 0x35AB9E8 Offset: 0x35A79E8 VA: 0x35AB9E8 Slot: 8
	internal virtual void OnOperation(PacketBase operation) { }

	// RVA: 0x35AB9EC Offset: 0x35A79EC VA: 0x35AB9EC Slot: 9
	internal virtual void OnEvent(PacketBase events) { }

	// RVA: 0x35AB9F0 Offset: 0x35A79F0 VA: 0x35AB9F0 Slot: 10
	internal virtual void OnActionEvent(ArchetypeActionEvent action) { }

	[CLSCompliant(False)]
	// RVA: 0x35AB9F4 Offset: 0x35A79F4 VA: 0x35AB9F4
	public static Archetype GetCompanionArchetype(Game game, CompanionData companionData) { }
}
