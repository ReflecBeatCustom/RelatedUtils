using System;
using System.Collections.Generic;
using System.Text;

namespace RBConverter
{
    /// <summary>
    /// Comparable Key-Value pair class.
    /// Requires key comparable.
    /// </summary>
    public class ComparableKeyValuePair<TKey, TValue> : IComparable<ComparableKeyValuePair<TKey, TValue>>
        where TKey : IComparable<TKey>
    {
        #region Fields

        private TKey _key = default(TKey);
        private TValue _value = default(TValue);

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of a ComparableKeyValuePair&lt;TKey, TValue&gt; class.
        /// </summary>
        /// <param name="key">Key of this instance.</param>
        /// <param name="value">Value of this instance.</param>
        public ComparableKeyValuePair(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the key of this instance.
        /// </summary>
        public TKey Key
        {
            get
            {
                return _key;
            }
            set
            {
                _key = value;
            }
        }

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        public TValue Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        #endregion

        #region IComparable<SortableKeyValuePair<TKey,TValue>> Members

        /// <summary>
        /// Compares this instance to another instance.
        /// </summary>
        /// <param name="other">Instance compared to.</param>
        /// <returns></returns>
        public int CompareTo(ComparableKeyValuePair<TKey, TValue> other)
        {
            return _key.CompareTo(other._key);
        }

        #endregion

        #region Override Methods

        /// <summary>
        /// Returns a System.String that represents current instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}", _key.ToString(), _value.ToString());
        }

        #endregion
    }
}
