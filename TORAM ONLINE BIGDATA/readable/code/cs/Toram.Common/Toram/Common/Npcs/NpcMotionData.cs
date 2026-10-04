// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcMotionData : BinaryBase // TypeDefIndex: 11155
{
	// Fields
	[CompilerGenerated]
	private byte <MotionIndex>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <MotionId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <MotionType>k__BackingField; // 0x20

	// Properties
	[BinaryParameter]
	public byte MotionIndex { get; set; }
	[BinaryParameter]
	public int MotionId { get; set; }
	[BinaryParameter]
	public byte MotionType { get; set; }

	// Methods

	// RVA: 0x35CB224 Offset: 0x35C7224 VA: 0x35CB224
	public void .ctor() { }

	// RVA: 0x35CB22C Offset: 0x35C722C VA: 0x35CB22C
	public void .ctor(byte motionIdx, int motionId, byte motionType) { }

	[CompilerGenerated]
	// RVA: 0x35CB26C Offset: 0x35C726C VA: 0x35CB26C
	public byte get_MotionIndex() { }

	[CompilerGenerated]
	// RVA: 0x35CB274 Offset: 0x35C7274 VA: 0x35CB274
	protected void set_MotionIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35CB27C Offset: 0x35C727C VA: 0x35CB27C
	public int get_MotionId() { }

	[CompilerGenerated]
	// RVA: 0x35CB284 Offset: 0x35C7284 VA: 0x35CB284
	protected void set_MotionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CB28C Offset: 0x35C728C VA: 0x35CB28C
	public byte get_MotionType() { }

	[CompilerGenerated]
	// RVA: 0x35CB294 Offset: 0x35C7294 VA: 0x35CB294
	protected void set_MotionType(byte value) { }

	// RVA: 0x35CB29C Offset: 0x35C729C VA: 0x35CB29C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35CB3BC Offset: 0x35C73BC VA: 0x35CB3BC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
