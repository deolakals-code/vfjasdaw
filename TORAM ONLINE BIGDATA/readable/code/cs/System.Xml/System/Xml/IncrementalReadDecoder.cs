// Assembly: System.Xml.dll
// Namespace: System.Xml
internal abstract class IncrementalReadDecoder // TypeDefIndex: 13295
{
	// Properties
	internal abstract bool IsFull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool get_IsFull();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int Decode(char[] chars, int startPos, int len);

	// RVA: 0x3387C60 Offset: 0x3383C60 VA: 0x3387C60
	protected void .ctor() { }
}
