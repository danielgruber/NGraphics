using System;

namespace NGraphics
{
	public class Font
	{
		string name = "Georgia";
		bool bold = false;
		bool italic = false;
		bool underline = false;
		bool strokeThrough = false;

		public Font ()
		{
			Size = 16;
		}

		public Font (string name, double size)
		{
			this.name = name;
			this.Size = size;
		}

		public override bool Equals (object obj)
		{
			var o = obj as Font;
			return o != null && o.Name == Name && o.Size == Size;
		}

		public override int GetHashCode ()
		{
			return Name.GetHashCode () * 3 + 11 * Size.GetHashCode ();
		}

		public bool Bold {
			get {
				return this.bold;
			}
			set {
				bold = value;
			}
		}

		public bool Italic {
			get {
				return this.italic;
			}
			set {
				italic = value;
			}
		}

		public bool Underline {
			get {
				return this.underline;
			}
			set {
				underline = value;
			}
		}

		public bool StrokeThrough {
			get {
				return this.strokeThrough;
			}
			set {
				strokeThrough = value;
			}
		}

		public string Name { get { return name; } set { name = value; } }
		public string Family { get { return name; } set { name = value; } }

		public double Size { get; set; }

		public Font WithSize (double newSize)
		{
			return new Font (Name, newSize);
		}

		public override string ToString ()
		{
			return string.Format ("Font(\"{0}\", {1})", Name, Size);
		}
	}

	public enum TextAlignment
	{
		Left,
		Center,
		Right
	}
}
