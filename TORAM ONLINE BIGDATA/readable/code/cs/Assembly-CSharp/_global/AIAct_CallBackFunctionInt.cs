// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIAct_CallBackFunctionInt : ActionStateBase // TypeDefIndex: 1563
{
	// Fields
	private GetDataFormat format; // 0x18
	private Action<int, bool> callBack; // 0x20
	private bool callbackSendFlag; // 0x28

	// Methods

	// RVA: 0x208B180 Offset: 0x2087180 VA: 0x208B180
	public void .ctor(IScriptAICentral _script_central, GetDataFormat _data_format, bool callbackSendFlag, Action<int, bool> _callback) { }

	// RVA: 0x208B21C Offset: 0x208721C VA: 0x208B21C Slot: 8
	public override void Init() { }

	// RVA: 0x208B220 Offset: 0x2087220 VA: 0x208B220 Slot: 9
	public override bool Action() { }
}
