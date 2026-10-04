// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Wave
public class WaveMobTargetAttack : OperationRequestBase // TypeDefIndex: 11798
{
	// Fields
	[CompilerGenerated]
	private int <MobUniqueId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsCombo>k__BackingField; // 0x2C

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 244)]
	public override byte SubCode { get; }
	[UnityHash(Code = 88)]
	public int MobUniqueId { get; set; }
	[UnityHash(Code = 96)]
	public short TargetId { get; set; }
	[UnityHash(Code = 195)]
	public int Damage { get; set; }
	[UnityHash(Code = 223)]
	public bool IsCombo { get; set; }

	// Methods

	// RVA: 0x374DBA0 Offset: 0x3749BA0 VA: 0x374DBA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374DBA8 Offset: 0x3749BA8 VA: 0x374DBA8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x374DBB0 Offset: 0x3749BB0 VA: 0x374DBB0
	public int get_MobUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x374DBB8 Offset: 0x3749BB8 VA: 0x374DBB8
	public void set_MobUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374DBC0 Offset: 0x3749BC0 VA: 0x374DBC0
	public short get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x374DBC8 Offset: 0x3749BC8 VA: 0x374DBC8
	public void set_TargetId(short value) { }

	[CompilerGenerated]
	// RVA: 0x374DBD0 Offset: 0x3749BD0 VA: 0x374DBD0
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x374DBD8 Offset: 0x3749BD8 VA: 0x374DBD8
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x374DBE0 Offset: 0x3749BE0 VA: 0x374DBE0
	public bool get_IsCombo() { }

	[CompilerGenerated]
	// RVA: 0x374DBE8 Offset: 0x3749BE8 VA: 0x374DBE8
	public void set_IsCombo(bool value) { }

	// RVA: 0x374DBF4 Offset: 0x3749BF4 VA: 0x374DBF4
	public void .ctor() { }

	// RVA: 0x374DBFC Offset: 0x3749BFC VA: 0x374DBFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374DDC4 Offset: 0x3749DC4 VA: 0x374DDC4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
