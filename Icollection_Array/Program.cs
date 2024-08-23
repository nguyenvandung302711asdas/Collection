using System;
using System.Collections;
public class MyArrayList : ICollection
{
    private object[] lstObj; // mảng giá trị
    private int count; // số lượng phần tử
    private const int MAXCOUNT = 100; // số lượng phần tử tối đa

    public MyArrayList()
    {
        count = -1;
        lstObj = new object[MAXCOUNT];
    }

    public MyArrayList(int count)
    {
        this.count = count;
        lstObj = new object[count];
    }

    public MyArrayList(Array array)
    {
        array.CopyTo(lstObj, 0);
        count = array.Length;
    }

    public void CopyTo(Array array, int index)
    {
        // thực hiện copy các phần tử trong lstObj từ vị trí index đến cuối sang mảng array.
        lstObj.CopyTo(array, index);
    }

    public int Count
    {
        get { return count; }
    }

    public bool IsSynchronized
    {
        get { throw new NotImplementedException(); }
    }

    public object SyncRoot
    {
        get { throw new NotImplementedException(); }
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
