// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class StampData : UnityHashBase // TypeDefIndex: 11130
{
	// Fields
	[CompilerGenerated]
	private bool <Ticket>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <StampId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <OrbShard>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 43, IsOptional = True)]
	public bool Ticket { get; set; }
	[UnityHash(Code = 200)]
	public byte StampId { get; set; }
	[UnityHash(Code = 230, IsOptional = True)]
	public int OrbShard { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C55CC Offset: 0x35C15CC VA: 0x35C55CC
	public void .ctor() { }

	// RVA: 0x35C55D4 Offset: 0x35C15D4 VA: 0x35C55D4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35C55DC Offset: 0x35C15DC VA: 0x35C55DC
	public bool get_Ticket() { }

	[CompilerGenerated]
	// RVA: 0x35C55E4 Offset: 0x35C15E4 VA: 0x35C55E4
	protected void set_Ticket(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35C55F0 Offset: 0x35C15F0 VA: 0x35C55F0
	public byte get_StampId() { }

	[CompilerGenerated]
	// RVA: 0x35C55F8 Offset: 0x35C15F8 VA: 0x35C55F8
	protected void set_StampId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C5600 Offset: 0x35C1600 VA: 0x35C5600
	public int get_OrbShard() { }

	[CompilerGenerated]
	// RVA: 0x35C5608 Offset: 0x35C1608 VA: 0x35C5608
	protected void set_OrbShard(int value) { }

	// RVA: 0x35C5610 Offset: 0x35C1610 VA: 0x35C5610 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C5618 Offset: 0x35C1618 VA: 0x35C5618 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C56D4 Offset: 0x35C16D4 VA: 0x35C56D4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C596C Offset: 0x35C196C VA: 0x35C596C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
