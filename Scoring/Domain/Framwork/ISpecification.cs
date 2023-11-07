using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Framwork
{
    public interface ISpecification<T>
    {
        bool IsStatisFieldBy(T value);
    }
    public abstract class CompositeSpection<T> : Specification<T>
    {

        public ISpecification<T> _left { get; private set; }
        public ISpecification<T> _right { get; private set; }

        //public readonly ISpecification<T> _left;
        //public readonly ISpecification<T> _right;

        protected CompositeSpection(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }




    }

    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract bool IsStatisFieldBy(T value);
        public Specification<T> And(ISpecification<T> left)
        {
            return new AndSpection<T>(this, left);
        }
    }


    public class OrSpection<T> : CompositeSpection<T>
    {
        public OrSpection(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsStatisFieldBy(T value)
        {
            return _right.IsStatisFieldBy(value) || _left.IsStatisFieldBy(value);
        }
    }


    public class AndSpection<T> : CompositeSpection<T>
    {
        public AndSpection(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsStatisFieldBy(T value)
        {
            return _right.IsStatisFieldBy(value) && _left.IsStatisFieldBy(value);
        }
    }
}
