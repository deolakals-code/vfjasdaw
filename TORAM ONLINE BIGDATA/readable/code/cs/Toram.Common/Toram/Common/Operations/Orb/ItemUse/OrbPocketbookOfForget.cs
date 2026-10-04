// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.ItemUse
public class OrbPocketbookOfForget : UnityHashBase // TypeDefIndex: 11852
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

	// RVA: 0x3757628 Offset: 0x3753628 VA: 0x3757628
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3757630 Offset: 0x3753630 VA: 0x3757630
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3757638 Offset: 0x3753638 VA: 0x3757638
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3757640 Offset: 0x3753640 VA: 0x3757640
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3757648 Offset: 0x3753648 VA: 0x3757648
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3757650 Offset: 0x3753650 VA: 0x3757650
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x3757658 Offset: 0x3753658 VA: 0x3757658
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x3757660 Offset: 0x3753660 VA: 0x3757660
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375794C Offset: 0x375394C VA: 0x375794C
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3757A8C Offset: 0x3753A8C VA: 0x3757A8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3757A94 Offset: 0x3753A94 VA: 0x3757A94 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3757B2C Offset: 0x3753B2C VA: 0x3757B2C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
