// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class FieldScriptCameraActionBase // TypeDefIndex: 4814
{
	// Fields
	private Transform cameraTrans; // 0x10

	// Properties
	protected Transform transform { get; }
	public virtual FieldScriptCameraActionBase.ActionType CurrentType { get; }
	public virtual bool IsAction { get; }

	// Methods

	// RVA: 0x25B1D14 Offset: 0x25ADD14 VA: 0x25B1D14
	protected Transform get_transform() { }

	// RVA: 0x25B1D1C Offset: 0x25ADD1C VA: 0x25B1D1C Slot: 4
	public virtual FieldScriptCameraActionBase.ActionType get_CurrentType() { }

	// RVA: 0x25B1D24 Offset: 0x25ADD24 VA: 0x25B1D24 Slot: 5
	public virtual bool get_IsAction() { }

	// RVA: 0x25B1D2C Offset: 0x25ADD2C VA: 0x25B1D2C
	public void .ctor(Transform camera) { }

	// RVA: 0x25B1D5C Offset: 0x25ADD5C VA: 0x25B1D5C Slot: 6
	public virtual void End() { }

	// RVA: 0x25B1D68 Offset: 0x25ADD68 VA: 0x25B1D68 Slot: 7
	public virtual void Update() { }

	// RVA: 0x25B1D6C Offset: 0x25ADD6C VA: 0x25B1D6C Slot: 8
	public virtual void Skip() { }
}
