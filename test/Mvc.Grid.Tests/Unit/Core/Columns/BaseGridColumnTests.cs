﻿using NSubstitute;
using System;
using Xunit;

namespace NonFactors.Mvc.Grid.Tests.Unit
{
    public class BaseGridColumnTests
    {
        private BaseGridColumn<GridModel, String> column;

        public BaseGridColumnTests()
        {
            column = Substitute.ForPartsOf<BaseGridColumn<GridModel, String>>();
        }

        #region IGridColumn<T>.Expression

        [Fact]
        public void IGridColumnExpression_ReturnsExpression()
        {
            IGridColumn<GridModel> gridColumn = column;

            Object actual = gridColumn.Expression;
            Object expected = column.Expression;

            Assert.Same(expected, actual);
        }

        #endregion

        #region IGridColumn.Filter

        [Fact]
        public void IFilterableColumnFilter_ReturnsFilter()
        {
            IGridColumn gridColumn = column;

            Object actual = gridColumn.Filter;
            Object expected = column.Filter;

            Assert.Same(expected, actual);
        }

        #endregion
    }
}
