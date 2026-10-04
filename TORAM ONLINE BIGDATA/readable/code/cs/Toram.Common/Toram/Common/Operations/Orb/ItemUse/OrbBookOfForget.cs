// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.ItemUse
public class OrbBookOfForget : UnityHashBase // TypeDefIndex: 11845
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<short, byte> <SkillList>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public Dictionary<short, byte> SkillList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37559D0 Offset: 0x37519D0 VA: 0x37559D0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37559D8 Offset: 0x37519D8 VA: 0x37559D8
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x37559E0 Offset: 0x37519E0 VA: 0x37559E0
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x37559E8 Offset: 0x37519E8 VA: 0x37559E8
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x37559F0 Offset: 0x37519F0 VA: 0x37559F0
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x37559F8 Offset: 0x37519F8 VA: 0x37559F8
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x3755A00 Offset: 0x3751A00 VA: 0x3755A00
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x3755A08 Offset: 0x3751A08 VA: 0x3755A08
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3755CF4 Offset: 0x3751CF4 VA: 0x3755CF4
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3755E34 Offset: 0x3751E34 VA: 0x3755E34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3755E3C Offset: 0x3751E3C VA: 0x3755E3C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3755ED4 Offset: 0x3751ED4 VA: 0x3755ED4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
