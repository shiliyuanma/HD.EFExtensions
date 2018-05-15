using EntityFramework.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Spatial;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFramework.BulkInsert.Helpers
{
    internal class MappedDataReader<T> : IDataReader
    {
        private readonly IEnumerator<T> _enumerator;

        public Dictionary<Type, Dictionary<int, Func<T, object>>> Selectors { get; private set; }

        /// <summary>
        /// Property maps by ordinal position
        /// </summary>
        public Dictionary<int, PropertyMap> Cols { get; private set; } 

        public Dictionary<Type, List<object>> Refs { get; private set; } 

        /// <summary>
        /// Ordinal positions of columns
        /// </summary>
        public Dictionary<string, int> Indexes { get; private set; }

        public int FieldCount { get; private set; }

        public EntityMap EntiyMap { get; set; }

        public MappedDataReader(IEnumerable<T> enumerable, EntityMap entiyMap)
        {
            EntiyMap = entiyMap;
            Refs = new Dictionary<Type, List<object>>();
            Indexes = new Dictionary<string, int>();
            Cols = new Dictionary<int, PropertyMap>();
            Selectors = new Dictionary<Type, Dictionary<int, Func<T, object>>>();

            _enumerator = enumerable.GetEnumerator();

            int i = 0;

            var entityType = entiyMap.EntityType;
            Selectors[entityType] = new Dictionary<int, Func<T, object>>();


            var propertyMaps = entiyMap.PropertyMaps;
                //.Where(x => !x.Computed && (!x.IsNavigationProperty || x.IsFk));

            foreach (var col in propertyMaps)
            {
                var currentIndex = i;

                if (Indexes.ContainsKey(col.ColumnName))
                {
                    currentIndex = Indexes[col.ColumnName];
                }
                else
                {
                    Cols[currentIndex] = col;
                    Indexes[col.ColumnName] = currentIndex;
                    ++i;
                }

                var x = Expression.Parameter(entityType, "x");

                var propNames = col.PropertyName.Split('.');
                Expression propertyExpression = Expression.PropertyOrField(x, propNames[0]);
                propertyExpression = propNames.Skip(1).Aggregate(propertyExpression, Expression.PropertyOrField);

                var expression = Expression.Lambda<Func<T, object>>(Expression.Convert(propertyExpression, typeof(object)), x);
                var selector = expression.Compile();
                Selectors[entityType][currentIndex] = selector;
            }

            FieldCount = i;
        }

        public void Dispose()
        {
            Selectors = null;
            _enumerator.Dispose();
        }

        private Dictionary<int, Func<T, object>> _currentEntityTypeSelectors; 
        public bool Read()
        {
            var read = _enumerator.MoveNext();
            if (read)
            {
                var t = _enumerator.Current.GetType();
                try
                {
                    _currentEntityTypeSelectors = Selectors[t];
                }
                catch (KeyNotFoundException)
                {
                    throw new KeyNotFoundException("Entity Type Not Found : " + t.FullName);
                }
            }
            return read;
        }

        public object GetValue(int i)
        {
            if (_enumerator.Current == null)
            {
                return System.DBNull.Value;
            }

            try
            {
                object value;
                try
                {
                    value = _currentEntityTypeSelectors[i](_enumerator.Current);
                }
                catch (KeyNotFoundException)
                {
                    return System.DBNull.Value;
                }

                return value != null ? value : System.DBNull.Value;
            }
            catch (NullReferenceException)
            {
                return System.DBNull.Value;
            }
        }

        public bool IsDBNull(int i)
        {
            return GetValue(i) == null;
        }

        public int GetOrdinal(string name)
        {
            return Indexes[name];
        }

        public string GetName(int i)
        {
            throw new NotImplementedException();
        }

        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        public Type GetFieldType(int i)
        {
            var propInfo = EntiyMap.ModelType.Properties.FirstOrDefault(q=>q.Name == Cols[i].PropertyName);
            if(propInfo.IsPrimitiveType)
            {
                return propInfo.PrimitiveType.ClrEquivalentType;
            }
            else if (propInfo.IsUnderlyingPrimitiveType)
            {
                return propInfo.UnderlyingPrimitiveType.ClrEquivalentType;
            }
            else
            {
                return typeof(object);
            }
        }

        #region not needed methods

        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        public bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        object IDataRecord.this[int i]
        {
            get { throw new NotImplementedException(); }
        }

        object IDataRecord.this[string name]
        {
            get { throw new NotImplementedException(); }
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public DataTable GetSchemaTable()
        {
            throw new NotImplementedException();
        }

        public bool NextResult()
        {
            throw new NotImplementedException();
        }

        public int Depth { get; private set; }
        public bool IsClosed { get; private set; }
        public int RecordsAffected { get; private set; }

        #endregion
    }
}