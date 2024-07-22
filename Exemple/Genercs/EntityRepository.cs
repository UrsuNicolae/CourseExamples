namespace Exemple.Genercs
{
    public interface IRepository<T, TKey> where T : class, new()
        where TKey : struct
    {
        void Create(T entity);
        void Read(TKey entity);

        void Update(T entity);

        void Delete(T entity);
    }


    public class BaseEntity<TKey> where TKey : struct
    {
        public TKey Id { get; private set; }

        public BaseEntity(TKey id)
        {
            Id = id;
        }
    }



    public class EntityRepository<T, TKey> : IRepository<T, TKey>
        where T : BaseEntity<TKey>, new()
        where TKey : struct
    {
        private readonly Dictionary<TKey, T> _store;
        public EntityRepository()
        {
            _store = new Dictionary<TKey, T>();
        }
        public void Create(T entity)
        {
            if (_store.ContainsKey(entity.Id))
            {
                throw new InvalidOperationException($"Entity with id {entity.Id} already exists");
            }
            _store.Add(entity.Id, entity);
        }

        public void Delete(T entity)
        {
            if (!_store.ContainsKey(entity.Id))
            {
                throw new InvalidOperationException($"Entity with id {entity.Id} already exists");
            }
            _store.Remove(entity.Id);
        }

        public void Read(TKey key)
        {
            if (!_store.ContainsKey(key))
            {
                throw new InvalidOperationException($"Entity with id {key} already exists");
            }
            var value = _store.GetValueOrDefault(key);
            Console.WriteLine(value);
        }

        public void Update(T entity)
        {
            if (_store.ContainsKey(entity.Id))
            {
                _store[entity.Id] = entity;
            }
        }
    }

    public class StoreCustomer : BaseEntity<int>
    {
        public string Name { get; set; }

        public StoreCustomer() : base(0)
        {
        }

        public StoreCustomer(int id, string name) : base(id)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    };

    public class StoreProduct<TKey> : BaseEntity<TKey> where TKey : struct
    {
        public string Name { get; set; }

        public StoreProduct() : base(default)
        {
        }

        public StoreProduct(TKey id, string name) : base(id)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    };
}
