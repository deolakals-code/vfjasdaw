// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
public enum EventType // TypeDefIndex: 17020
{
	// Fields
	public int value__; // 0x0
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType TouchDown = 30;
	public const EventType TouchUp = 31;
	public const EventType TouchMove = 32;
	public const EventType TouchEnter = 33;
	public const EventType TouchLeave = 34;
	public const EventType TouchStationary = 35;
	[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", True)]
	[EditorBrowsable(1)]
	public const EventType mouseDown = 0;
	[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", True)]
	[EditorBrowsable(1)]
	public const EventType mouseUp = 1;
	[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", True)]
	[EditorBrowsable(1)]
	public const EventType mouseMove = 2;
	[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", True)]
	[EditorBrowsable(1)]
	public const EventType mouseDrag = 3;
	[EditorBrowsable(1)]
	[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", True)]
	public const EventType keyDown = 4;
	[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", True)]
	[EditorBrowsable(1)]
	public const EventType keyUp = 5;
	[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", True)]
	[EditorBrowsable(1)]
	public const EventType scrollWheel = 6;
	[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", True)]
	[EditorBrowsable(1)]
	public const EventType repaint = 7;
	[EditorBrowsable(1)]
	[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", True)]
	public const EventType layout = 8;
	[EditorBrowsable(1)]
	[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", True)]
	public const EventType dragUpdated = 9;
	[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", True)]
	[EditorBrowsable(1)]
	public const EventType dragPerform = 10;
	[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", True)]
	[EditorBrowsable(1)]
	public const EventType ignore = 11;
	[EditorBrowsable(1)]
	[Obsolete("Use Used instead (UnityUpgradable) -> Used", True)]
	public const EventType used = 12;
}
