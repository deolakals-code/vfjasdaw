// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.ScoreAttack
public class CheckScoreAttackRoom : OperationRequestBase // TypeDefIndex: 11799
{
	// Fields
	[CompilerGenerated]
	private bool <IsSolo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <BossId>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <IsIgnoreRotation>k__BackingField; // 0x22

	// Properties
	public bool IsSolo { get; set; }
	public byte BossId { get; set; }
	public bool IsIgnoreRotation { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374DFE0 Offset: 0x3749FE0 VA: 0x374DFE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374DFE8 Offset: 0x3749FE8 VA: 0x374DFE8
	public bool get_IsSolo() { }

	[CompilerGenerated]
	// RVA: 0x374DFF0 Offset: 0x3749FF0 VA: 0x374DFF0
	public void set_IsSolo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x374DFFC Offset: 0x3749FFC VA: 0x374DFFC
	public byte get_BossId() { }

	[CompilerGenerated]
	// RVA: 0x374E004 Offset: 0x374A004 VA: 0x374E004
	public void set_BossId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374E00C Offset: 0x374A00C VA: 0x374E00C
	public bool get_IsIgnoreRotation() { }

	[CompilerGenerated]
	// RVA: 0x374E014 Offset: 0x374A014 VA: 0x374E014
	public void set_IsIgnoreRotation(bool value) { }

	// RVA: 0x374E020 Offset: 0x374A020 VA: 0x374E020 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374E028 Offset: 0x374A028 VA: 0x374E028 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374E030 Offset: 0x374A030 VA: 0x374E030 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374E150 Offset: 0x374A150 VA: 0x374E150 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
