// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class HideSeekCheckResponse : OperationResponseBase // TypeDefIndex: 12001
{
	// Fields
	[CompilerGenerated]
	private int <ManageId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SignatureId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <SignatureName>k__BackingField; // 0x28

	// Properties
	public int ManageId { get; set; }
	public int SignatureId { get; set; }
	public string SignatureName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377481C Offset: 0x377081C VA: 0x377481C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3774824 Offset: 0x3770824 VA: 0x3774824
	public int get_ManageId() { }

	[CompilerGenerated]
	// RVA: 0x377482C Offset: 0x377082C VA: 0x377482C
	public void set_ManageId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3774834 Offset: 0x3770834 VA: 0x3774834
	public int get_SignatureId() { }

	[CompilerGenerated]
	// RVA: 0x377483C Offset: 0x377083C VA: 0x377483C
	public void set_SignatureId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3774844 Offset: 0x3770844 VA: 0x3774844
	public string get_SignatureName() { }

	[CompilerGenerated]
	// RVA: 0x377484C Offset: 0x377084C VA: 0x377484C
	public void set_SignatureName(string value) { }

	// RVA: 0x3774854 Offset: 0x3770854 VA: 0x3774854 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377485C Offset: 0x377085C VA: 0x377485C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3774864 Offset: 0x3770864 VA: 0x3774864 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3774A54 Offset: 0x3770A54 VA: 0x3774A54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
