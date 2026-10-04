// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceSkillForgetResponse : UnityHashBase // TypeDefIndex: 11884
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

	// RVA: 0x375D6D8 Offset: 0x37596D8 VA: 0x375D6D8
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375D6E0 Offset: 0x37596E0 VA: 0x375D6E0
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x375D6E8 Offset: 0x37596E8 VA: 0x375D6E8
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375D6F0 Offset: 0x37596F0 VA: 0x375D6F0
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375D6F8 Offset: 0x37596F8 VA: 0x375D6F8
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375D700 Offset: 0x3759700 VA: 0x375D700
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x375D708 Offset: 0x3759708 VA: 0x375D708
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x375D710 Offset: 0x3759710 VA: 0x375D710
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375D954 Offset: 0x3759954 VA: 0x375D954
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375DA60 Offset: 0x3759A60 VA: 0x375DA60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375DA68 Offset: 0x3759A68 VA: 0x375DA68 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375DC28 Offset: 0x3759C28 VA: 0x375DC28 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
