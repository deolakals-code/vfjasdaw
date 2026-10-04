// Assembly: System.dll
// Namespace: System.Collections.Specialized
public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 14300
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Methods

	// RVA: 0x34D3998 Offset: 0x34CF998 VA: 0x34D3998
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x34D3B44 Offset: 0x34CFB44 VA: 0x34D3B44
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x34D3D34 Offset: 0x34CFD34 VA: 0x34D3D34
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x34D3F68 Offset: 0x34CFF68 VA: 0x34D3F68
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x34D3D1C Offset: 0x34CFD1C VA: 0x34D3D1C
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x34D3AA8 Offset: 0x34CFAA8 VA: 0x34D3AA8
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x34D4118 Offset: 0x34D0118 VA: 0x34D4118
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x34D3F24 Offset: 0x34CFF24 VA: 0x34D3F24
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }
}
