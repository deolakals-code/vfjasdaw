// Assembly: Assembly-CSharp.dll
// Namespace: 
private interface GUIDebugParamRenderer.IRenderObject // TypeDefIndex: 1883
{
	// Properties
	public abstract string paramName { get; set; }
	public abstract bool drawEnable { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_paramName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_paramName(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_drawEnable();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_drawEnable(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Draw();
}
