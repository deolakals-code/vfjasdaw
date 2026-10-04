// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class ToolBase : MonoBehaviour // TypeDefIndex: 5615
{
	// Fields
	protected Rect ButtonRect; // 0x20
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x34

	// Properties
	public int AvatarUuid { get; set; }
	public bool IsValid { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17A6D94 Offset: 0x17A2D94 VA: 0x17A6D94
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x17A6D9C Offset: 0x17A2D9C VA: 0x17A6D9C
	protected void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x17A6DA4 Offset: 0x17A2DA4 VA: 0x17A6DA4
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x17A6DAC Offset: 0x17A2DAC VA: 0x17A6DAC
	protected void set_IsValid(bool value) { }

	// RVA: 0x17A6DB8 Offset: 0x17A2DB8 VA: 0x17A6DB8 Slot: 4
	public virtual void Invalid() { }

	// RVA: 0x17A6DC0 Offset: 0x17A2DC0 VA: 0x17A6DC0 Slot: 5
	public virtual void Valid() { }

	// RVA: 0x17A6DCC Offset: 0x17A2DCC VA: 0x17A6DCC Slot: 6
	public virtual void SetAvatarUuid(int uuid) { }

	// RVA: 0x17A6DD4 Offset: 0x17A2DD4 VA: 0x17A6DD4 Slot: 7
	public virtual void SetAvatarUuid(string uuid) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetState();

	// RVA: 0x17A6D38 Offset: 0x17A2D38 VA: 0x17A6D38
	protected void .ctor() { }
}
