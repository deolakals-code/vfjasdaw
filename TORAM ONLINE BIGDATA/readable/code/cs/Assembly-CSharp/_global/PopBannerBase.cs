// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PopBannerBase // TypeDefIndex: 1705
{
	// Fields
	public readonly byte Priority; // 0x10
	public readonly PopBannerType Type; // 0x14
	private readonly string textureFile; // 0x18

	// Properties
	public string TextureFile { get; }
	public virtual string DefaultTextureFile { get; }

	// Methods

	// RVA: 0x20AC430 Offset: 0x20A8430 VA: 0x20AC430
	public string get_TextureFile() { }

	// RVA: 0x20AC438 Offset: 0x20A8438 VA: 0x20AC438 Slot: 4
	public virtual string get_DefaultTextureFile() { }

	// RVA: 0x20AC478 Offset: 0x20A8478 VA: 0x20AC478 Slot: 5
	public virtual bool IsActive() { }

	// RVA: 0x20AC480 Offset: 0x20A8480 VA: 0x20AC480
	public void .ctor(byte priority, PopBannerType type, string file) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ClickAction();
}
