// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceSkillTreeResetResponse : UnityHashBase // TypeDefIndex: 11886
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

	// RVA: 0x375DF50 Offset: 0x3759F50 VA: 0x375DF50
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375DF58 Offset: 0x3759F58 VA: 0x375DF58
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x375DF60 Offset: 0x3759F60 VA: 0x375DF60
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375DF68 Offset: 0x3759F68 VA: 0x375DF68
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375DF70 Offset: 0x3759F70 VA: 0x375DF70
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375DF78 Offset: 0x3759F78 VA: 0x375DF78
	public Dictionary<short, byte> get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x375DF80 Offset: 0x3759F80 VA: 0x375DF80
	public void set_SkillList(Dictionary<short, byte> value) { }

	// RVA: 0x375DF88 Offset: 0x3759F88 VA: 0x375DF88
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375E1CC Offset: 0x375A1CC VA: 0x375E1CC
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375E2D8 Offset: 0x375A2D8 VA: 0x375E2D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375E2E0 Offset: 0x375A2E0 VA: 0x375E2E0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375E4A0 Offset: 0x375A4A0 VA: 0x375E4A0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
