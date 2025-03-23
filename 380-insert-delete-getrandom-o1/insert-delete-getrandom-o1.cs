public class RandomizedSet {
    // the   solution
    private Dictionary<int, int> myDictio;
    private List<int> myList; 
    private Random value; 

    public RandomizedSet() {
        myDictio = new Dictionary<int, int>();
        myList = new List<int>();
        value = new Random();
    }

    public bool Insert(int val) {
        if (myDictio.ContainsKey(val)) {
            return false;
        }
        
        myList.Add(val);
        myDictio[val] = myList.Count - 1;
        return true;
    }

    public bool Remove(int val) {
        if (!myDictio.ContainsKey(val)) {
            return false;
        }

        int indexToRemove = myDictio[val];
        
        int lastValue = myList[myList.Count - 1];
        myList[indexToRemove] = lastValue; 
        myDictio[lastValue] = indexToRemove;

        myList.RemoveAt(myList.Count - 1);
        myDictio.Remove(val);

        return true;
    }

    public int GetRandom() {
        int randomIndex = value.Next(myList.Count);
        return myList[randomIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */