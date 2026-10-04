// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.Versatile
public abstract class ActionVersatileDataBase : UnityHashBase // TypeDefIndex: 13216
{
	// Properties
	public override byte Code { get; }
	public abstract byte VersatileCode { get; }

	// Methods

	// RVA: 0x36E32B4 Offset: 0x36DF2B4 VA: 0x36E32B4
	public void .ctor() { }

	// RVA: 0x36E38A0 Offset: 0x36DF8A0 VA: 0x36E38A0 Slot: 4
	public override byte get_Code() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract byte get_VersatileCode();

	// RVA: 0x36E38A8 Offset: 0x36DF8A8 VA: 0x36E38A8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36E352C Offset: 0x36DF52C VA: 0x36E352C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
