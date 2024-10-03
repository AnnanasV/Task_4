namespace Storage
{
    public class Storage <T>
    {
        private T _value;

        public void SetItem(T item)
        {
            _value = item;
        }

        public T GetItem() => _value;
    }
}