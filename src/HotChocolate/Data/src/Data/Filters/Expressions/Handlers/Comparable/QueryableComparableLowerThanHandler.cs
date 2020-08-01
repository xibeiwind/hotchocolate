using System.Linq.Expressions;
using HotChocolate.Language;
using HotChocolate.Types;
using HotChocolate.Utilities;

namespace HotChocolate.Data.Filters.Expressions
{
    public class QueryableComparableLowerThanHandler
        : QueryableComparableOperationHandler
    {
        public QueryableComparableLowerThanHandler(
            ITypeConverter typeConverter)
            : base(typeConverter)
        {
        }

        protected override int Operation => Operations.LowerThan;

        public override Expression HandleOperation(
            QueryableFilterContext context,
            IFilterInputType declaringType,
            IFilterOperationField field,
            IType fieldType,
            IValueNode value,
            object parsedValue)
        {
            Expression property = context.GetInstance();
            parsedValue = ParseValue(value, parsedValue, fieldType, context);
            return FilterExpressionBuilder.LowerThan(property, parsedValue);
        }
    }
}