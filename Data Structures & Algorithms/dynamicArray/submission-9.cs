public class DynamicArray {
    private int _capacity;
    private int[] _array;
    private int _size;
    
    public DynamicArray(int capacity) {
        _capacity = capacity;
        _array = new int[_capacity];
        _size = 0;
    }

    public int Get(int i) {
        return _array[i];
    }

    public void Set(int i, int n) {
        _array[i] = n;
        //_size+=1;
    }

    public void PushBack(int n) {
        if (_size+1 > _capacity) {
            Resize();
        }
        _array[_size] = n;
        _size+=1;
    }

    public int PopBack() {
        _size-=1;
        return _array[_size];
    }

    private void Resize() {
        int new_cap = _capacity * 2;
        int[] new_array = new int[new_cap];
        _array.CopyTo(new_array, 0);

        _array = new_array;
        _capacity = new_cap;
    }

    public int GetSize() {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
