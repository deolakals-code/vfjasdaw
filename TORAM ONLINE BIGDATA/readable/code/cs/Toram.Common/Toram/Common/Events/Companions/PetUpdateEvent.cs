// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Companions
public class PetUpdateEvent : EventSubBase // TypeDefIndex: 12646
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <WeaponAtk>k__BackingField; // 0x32
	[CompilerGenerated]
	private PetSkillData[] <LevelupSkills>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Stamina>k__BackingField; // 0x40

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public long PetUuid { get; set; }
	public short Level { get; set; }
	public int Hp { get; set; }
	public short Mp { get; set; }
	public short WeaponAtk { get; set; }
	public PetSkillData[] LevelupSkills { get; set; }
	public int Stamina { get; set; }

	// Methods

	// RVA: 0x36388F8 Offset: 0x36348F8 VA: 0x36388F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638900 Offset: 0x3634900 VA: 0x3638900 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3638908 Offset: 0x3634908 VA: 0x3638908 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3638910 Offset: 0x3634910 VA: 0x3638910
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3638918 Offset: 0x3634918 VA: 0x3638918
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3638920 Offset: 0x3634920 VA: 0x3638920
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3638928 Offset: 0x3634928 VA: 0x3638928
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x3638930 Offset: 0x3634930 VA: 0x3638930
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3638938 Offset: 0x3634938 VA: 0x3638938
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3638940 Offset: 0x3634940 VA: 0x3638940
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3638948 Offset: 0x3634948 VA: 0x3638948
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3638950 Offset: 0x3634950 VA: 0x3638950
	public short get_WeaponAtk() { }

	[CompilerGenerated]
	// RVA: 0x3638958 Offset: 0x3634958 VA: 0x3638958
	public void set_WeaponAtk(short value) { }

	[CompilerGenerated]
	// RVA: 0x3638960 Offset: 0x3634960 VA: 0x3638960
	public PetSkillData[] get_LevelupSkills() { }

	[CompilerGenerated]
	// RVA: 0x3638968 Offset: 0x3634968 VA: 0x3638968
	public void set_LevelupSkills(PetSkillData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3638970 Offset: 0x3634970 VA: 0x3638970
	public int get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x3638978 Offset: 0x3634978 VA: 0x3638978
	public void set_Stamina(int value) { }

	// RVA: 0x3638980 Offset: 0x3634980 VA: 0x3638980
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638A70 Offset: 0x3634A70 VA: 0x3638A70
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638AFC Offset: 0x3634AFC VA: 0x3638AFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638DFC Offset: 0x3634DFC VA: 0x3638DFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
