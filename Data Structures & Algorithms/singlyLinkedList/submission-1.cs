public class LinkedList {
    private List<int> _ll;

    public LinkedList() {
        _ll = new List<int>();
    }

    public int Get(int index) {
        if (index > _ll.Count-1) {
            return -1;
        }
        return _ll[index];
    }

    public void InsertHead(int val) {
        _ll.Insert(0, val);
    }

    public void InsertTail(int val) {
        _ll.Add(val);
    }

    public bool Remove(int index) {
        if (index > _ll.Count-1) {
            return false;
        }
        _ll.RemoveAt(index);
        return true;
    }

    public List<int> GetValues() {
        return _ll;
    }
}