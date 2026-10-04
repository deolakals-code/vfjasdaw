// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Parties
public class PartyMemberFrameData : BinaryBase // TypeDefIndex: 13006
{
	// Fields
	[CompilerGenerated]
	private byte <FrameNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <Flag>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <Role>k__BackingField; // 0x1B

	// Properties
	public byte FrameNo { get; set; }
	public bool Flag { get; set; }
	public byte Role { get; set; }

	// Methods

	// RVA: 0x368BF8C Offset: 0x3687F8C VA: 0x368BF8C
	public void .ctor() { }

	// RVA: 0x368BF94 Offset: 0x3687F94 VA: 0x368BF94
	public void .ctor(byte frameNo, bool flag, byte role) { }

	[CompilerGenerated]
	// RVA: 0x368BFD8 Offset: 0x3687FD8 VA: 0x368BFD8
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x368BFE0 Offset: 0x3687FE0 VA: 0x368BFE0
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368BFE8 Offset: 0x3687FE8 VA: 0x368BFE8
	public bool get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x368BFF0 Offset: 0x3687FF0 VA: 0x368BFF0
	public void set_Flag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x368BFFC Offset: 0x3687FFC VA: 0x368BFFC
	public byte get_Role() { }

	[CompilerGenerated]
	// RVA: 0x368C004 Offset: 0x3688004 VA: 0x368C004
	public void set_Role(byte value) { }

	// RVA: 0x368C00C Offset: 0x368800C VA: 0x368C00C Slot: 3
	public override string ToString() { }

	// RVA: 0x368C0D8 Offset: 0x36880D8 VA: 0x368C0D8
	public string ToRole() { }

	// RVA: 0x368C29C Offset: 0x368829C VA: 0x368C29C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368C2E8 Offset: 0x36882E8 VA: 0x368C2E8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
