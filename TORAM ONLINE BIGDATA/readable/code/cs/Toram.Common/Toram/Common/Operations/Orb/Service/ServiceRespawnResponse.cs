// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.Service
public class ServiceRespawnResponse : UnityHashBase // TypeDefIndex: 11883
{
	// Fields
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private GameStatusData <PetGameStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ResultCode>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	[UnityHash(Code = 181, IsOptional = True)]
	public GameStatusData PetGameStatus { get; set; }
	[UnityHash(Code = 13)]
	public byte ResultCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x375D110 Offset: 0x3759110 VA: 0x375D110
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375D118 Offset: 0x3759118 VA: 0x375D118
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375D120 Offset: 0x3759120 VA: 0x375D120
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375D128 Offset: 0x3759128 VA: 0x375D128
	public GameStatusData get_PetGameStatus() { }

	[CompilerGenerated]
	// RVA: 0x375D130 Offset: 0x3759130 VA: 0x375D130
	public void set_PetGameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x375D138 Offset: 0x3759138 VA: 0x375D138
	public byte get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x375D140 Offset: 0x3759140 VA: 0x375D140
	public void set_ResultCode(byte value) { }

	// RVA: 0x375D148 Offset: 0x3759148 VA: 0x375D148
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375D380 Offset: 0x3759380 VA: 0x375D380
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x375D48C Offset: 0x375948C VA: 0x375D48C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375D494 Offset: 0x3759494 VA: 0x375D494 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x375D5E0 Offset: 0x37595E0 VA: 0x375D5E0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
