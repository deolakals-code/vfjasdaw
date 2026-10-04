// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServicePersonalityChangeResponse : UnityHashBase // TypeDefIndex: 11882
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x375CC78 Offset: 0x3758C78 VA: 0x375CC78
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375CC80 Offset: 0x3758C80 VA: 0x375CC80
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x375CC88 Offset: 0x3758C88 VA: 0x375CC88
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375CC90 Offset: 0x3758C90 VA: 0x375CC90
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375CC98 Offset: 0x3758C98 VA: 0x375CC98
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x375CCA0 Offset: 0x3758CA0 VA: 0x375CCA0
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375CEE4 Offset: 0x3758EE4 VA: 0x375CEE4
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375CFF0 Offset: 0x3758FF0 VA: 0x375CFF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375CFF8 Offset: 0x3758FF8 VA: 0x375CFF8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375D090 Offset: 0x3759090 VA: 0x375D090 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
