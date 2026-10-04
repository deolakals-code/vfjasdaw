// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IUILabel // TypeDefIndex: 203
{
	// Properties
	public abstract string text { get; set; }
	public abstract float alpha { get; set; }
	public abstract Color color { get; set; }
	public abstract UILabel.Effect effectStyle { get; set; }
	public abstract Color effectColor { get; set; }
	public abstract Vector2 effectDistance { get; set; }
	public abstract int width { get; }
	public abstract bool enabled { get; set; }
	public abstract UIWidget.Pivot pivot { get; set; }
	public abstract Vector2 printedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_text();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_text(string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_alpha();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_alpha(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Color get_color();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_color(Color value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract UILabel.Effect get_effectStyle();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_effectStyle(UILabel.Effect value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Color get_effectColor();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_effectColor(Color value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Vector2 get_effectDistance();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_effectDistance(Vector2 value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_width();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract UIWidget.Pivot get_pivot();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_pivot(UIWidget.Pivot value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Vector2 get_printedSize();
}
