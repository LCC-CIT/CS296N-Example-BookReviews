using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using BookReviews.Models;

namespace Tests
{
	public class TestAsyncQueryableDataSource : IQueryable<Review>, IEnumerable<Review>, IAsyncEnumerable<Review>
    {
		ObservableCollection<Review> _data;
		IQueryable _query;

		public TestAsyncQueryableDataSource()
		{
			_data = new ObservableCollection<Review>();
			_query = _data.AsQueryable();
		}

        public Review Add(Review item)
        {
            _data.Add(item);
            return item;
        }

        // Implement IQueryable

        IQueryProvider IQueryable.Provider
        {
            get { return new TestAsyncQueryProvider<Review>(_query.Provider); }
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        // Implement IEnumerable

                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<Review> IEnumerable<Review>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        /*
        // Implement IDbAsyncEnumerable

        IDbAsyncEnumerator<Review> IDbAsyncEnumerable<Review>.GetAsyncEnumerator()
        {
            return new TestDbAsyncEnumerator<Review>(_data.GetEnumerator());
        }

        public IDbAsyncEnumerator GetAsyncEnumerator()
        {
            throw new NotImplementedException();
        }
        */

        // Implement IDbAsyncEnumerable
        public IAsyncEnumerator<Review> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new TestAsyncEnumerator<Review>(_data.GetEnumerator());
        }
    }
}

