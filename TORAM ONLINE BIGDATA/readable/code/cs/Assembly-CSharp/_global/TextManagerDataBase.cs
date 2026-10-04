// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class TextManagerDataBase // TypeDefIndex: 5278
{
	// Fields
	protected readonly string Text; // 0x10
	protected readonly string Name; // 0x18
	protected readonly string Description; // 0x20

	// Methods

	// RVA: 0x261C7D4 Offset: 0x26187D4 VA: 0x261C7D4
	public void .ctor() { }

	// RVA: 0x2621A0C Offset: 0x261DA0C VA: 0x2621A0C
	public void .ctor(string text) { }

	// RVA: 0x261C7DC Offset: 0x26187DC VA: 0x261C7DC
	public void .ctor(string name, string description) { }

	// RVA: 0x2621A3C Offset: 0x261DA3C VA: 0x2621A3C Slot: 4
	public virtual string GetText() { }

	// RVA: 0x2621A44 Offset: 0x261DA44 VA: 0x2621A44 Slot: 5
	public virtual string GetName() { }

	// RVA: 0x2621A4C Offset: 0x261DA4C VA: 0x2621A4C Slot: 6
	public virtual string GetDescription() { }

	// RVA: 0x2621A54 Offset: 0x261DA54 VA: 0x2621A54 Slot: 7
	public virtual string GetTextFormat(object[] args) { }

	// RVA: 0x2621A60 Offset: 0x261DA60 VA: 0x2621A60 Slot: 8
	public virtual string GetNameFormat(object[] args) { }

	// RVA: 0x2621A6C Offset: 0x261DA6C VA: 0x2621A6C Slot: 9
	public virtual string GetDescriptionFormat(object[] args) { }
}
