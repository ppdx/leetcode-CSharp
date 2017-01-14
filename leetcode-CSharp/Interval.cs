namespace leetcode_CSharp
{
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }

        public static bool operator ==(Interval that, Interval oth)
        {
            if (ReferenceEquals(that, null)) return ReferenceEquals(oth, null);
            return that.Equals(oth);
        }

        public static bool operator !=(Interval that, Interval oth)
        {
            return !(that == oth);
        }

        public override bool Equals(object obj)
        {
            try
            {
                var oth = (Interval)obj;
                return start == oth.start && end == oth.end;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"[{start}, {end}]";
        }

        public override int GetHashCode()
        {
            return start.GetHashCode() ^ end.GetHashCode();
        }
    }

}
