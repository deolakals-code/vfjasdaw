// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ColorSynthesis : OperationRequestBase // TypeDefIndex: 11724
{
	// Fields
	public static readonly int[] SupportIdOrders; // 0x0
	[CompilerGenerated]
	private int <MainGemId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <SubGemIds>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <UseSupportList>k__BackingField; // 0x30
	[CompilerGenerated]
	private ColorSynthesisType <SynthesisType>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <EquipType>k__BackingField; // 0x3A
	[CompilerGenerated]
	private bool <SpecifyColorPosition>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte <ColorPosition>k__BackingField; // 0x3D
	[CompilerGenerated]
	private int <MetalPoint>k__BackingField; // 0x40

	// Properties
	public int MainGemId { get; set; }
	public int[] SubGemIds { get; set; }
	public short[] UseSupportList { get; set; }
	public ColorSynthesisType SynthesisType { get; set; }
	public short EquipType { get; set; }
	public bool SpecifyColorPosition { get; set; }
	public byte ColorPosition { get; set; }
	public int MetalPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373BFB4 Offset: 0x3737FB4 VA: 0x373BFB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373BFBC Offset: 0x3737FBC VA: 0x373BFBC
	public int get_MainGemId() { }

	[CompilerGenerated]
	// RVA: 0x373BFC4 Offset: 0x3737FC4 VA: 0x373BFC4
	public void set_MainGemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373BFCC Offset: 0x3737FCC VA: 0x373BFCC
	public int[] get_SubGemIds() { }

	[CompilerGenerated]
	// RVA: 0x373BFD4 Offset: 0x3737FD4 VA: 0x373BFD4
	public void set_SubGemIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x373BFDC Offset: 0x3737FDC VA: 0x373BFDC
	public short[] get_UseSupportList() { }

	[CompilerGenerated]
	// RVA: 0x373BFE4 Offset: 0x3737FE4 VA: 0x373BFE4
	public void set_UseSupportList(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x373BFEC Offset: 0x3737FEC VA: 0x373BFEC
	public ColorSynthesisType get_SynthesisType() { }

	[CompilerGenerated]
	// RVA: 0x373BFF4 Offset: 0x3737FF4 VA: 0x373BFF4
	public void set_SynthesisType(ColorSynthesisType value) { }

	[CompilerGenerated]
	// RVA: 0x373BFFC Offset: 0x3737FFC VA: 0x373BFFC
	public short get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x373C004 Offset: 0x3738004 VA: 0x373C004
	public void set_EquipType(short value) { }

	[CompilerGenerated]
	// RVA: 0x373C00C Offset: 0x373800C VA: 0x373C00C
	public bool get_SpecifyColorPosition() { }

	[CompilerGenerated]
	// RVA: 0x373C014 Offset: 0x3738014 VA: 0x373C014
	public void set_SpecifyColorPosition(bool value) { }

	[CompilerGenerated]
	// RVA: 0x373C020 Offset: 0x3738020 VA: 0x373C020
	public byte get_ColorPosition() { }

	[CompilerGenerated]
	// RVA: 0x373C028 Offset: 0x3738028 VA: 0x373C028
	public void set_ColorPosition(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373C030 Offset: 0x3738030 VA: 0x373C030
	public int get_MetalPoint() { }

	[CompilerGenerated]
	// RVA: 0x373C038 Offset: 0x3738038 VA: 0x373C038
	public void set_MetalPoint(int value) { }

	// RVA: 0x373C040 Offset: 0x3738040 VA: 0x373C040 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373C048 Offset: 0x3738048 VA: 0x373C048 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373C050 Offset: 0x3738050 VA: 0x373C050 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373C240 Offset: 0x3738240 VA: 0x373C240 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x373C618 Offset: 0x3738618 VA: 0x373C618
	private static void .cctor() { }
}
