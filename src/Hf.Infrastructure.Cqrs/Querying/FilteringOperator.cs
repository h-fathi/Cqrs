namespace Hf.Cqrs.Infrastructure.Querying
{
    public sealed class FilteringOperator
    {
        private readonly string _value;

        public static readonly FilteringOperator IsEqualTo = new FilteringOperator("eq");
        public static readonly FilteringOperator IsEqualToField = new FilteringOperator("eqf");
        public static readonly FilteringOperator IsNotEqualTo = new FilteringOperator("neq");
        public static readonly FilteringOperator IsNotEqualToField = new FilteringOperator("neqf");
        public static readonly FilteringOperator IsLessThan = new FilteringOperator("lt");
        public static readonly FilteringOperator IsLessThanField = new FilteringOperator("ltf");
        public static readonly FilteringOperator IsLessThanOrEqualTo = new FilteringOperator("lte");
        public static readonly FilteringOperator IsLessThanOrEqualToField = new FilteringOperator("ltef");
        public static readonly FilteringOperator IsGreaterThan = new FilteringOperator("gt");
        public static readonly FilteringOperator IsGreaterThanField = new FilteringOperator("gtf");
        public static readonly FilteringOperator IsGreaterThanOrEqualTo = new FilteringOperator("gte");
        public static readonly FilteringOperator IsGreaterThanOrEqualToField = new FilteringOperator("gtef");

        public FilteringOperator(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return _value != null ? _value.GetHashCode() : 0;
        }
    }
}