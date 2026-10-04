// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceAllSkillTreeResetResponse : UnityHashBase // TypeDefIndex: 11892
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

	// RVA: 0x375F4F0 Offset: 0x375B4F0 VA: 0x375F4F0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375F4F8 Offset: 0x375B4F8 VA: 0x375F4F8
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x375F500 Offset: 0x375B500 VA: 0x375F500
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375F508 Offset: 0x375B508 VA: 0x375F508
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375F510 Offset: 0x375B510 VA: 0x375F510
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375F518 Offset: 0x375B518 VA: 0x375F518
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x375F520 Offset: 0x375B520 VA: 0x375F520
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x375F528 Offset: 0x375B528 VA: 0x375F528
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375F76C Offset: 0x375B76C VA: 0x375F76C
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375F878 Offset: 0x375B878 VA: 0x375F878 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375F880 Offset: 0x375B880 VA: 0x375F880 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375FA40 Offset: 0x375BA40 VA: 0x375FA40 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
