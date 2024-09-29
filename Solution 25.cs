public class MyCircularDeque {
    private int[] deque;
    private int front, rear, count, capacity;

    public MyCircularDeque(int k) {
        capacity = k;
        deque = new int[k];
        front = 0;
        rear = -1;
        count = 0;
    }
    
    public bool InsertFront(int value) {
        if (IsFull())
            return false;
        front = (front - 1 + capacity) % capacity;
        deque[front] = value;
        count++;
        return true;
    }
    
    public bool InsertLast(int value) {
        if (IsFull())
            return false;
        rear = (rear + 1) % capacity;
        deque[rear] = value;
        count++;
        return true;
    }
    
    public bool DeleteFront() {
        if (IsEmpty())
            return false;
        front = (front + 1) % capacity;
        count--;
        return true;
    }
    
    public bool DeleteLast() {
        if (IsEmpty())
            return false;
        rear = (rear - 1 + capacity) % capacity;
        count--;
        return true;
    }
    
    public int GetFront() {
        return IsEmpty() ? -1 : deque[front];
    }
    
    public int GetRear() {
        return IsEmpty() ? -1 : deque[rear];
    }
    
    public bool IsEmpty() {
        return count == 0;
    }
    
    public bool IsFull() {
        return count == capacity;
    }
}

// Usage
MyCircularDeque obj = new MyCircularDeque(3);
bool param_1 = obj.InsertFront(1);
bool param_2 = obj.InsertLast(2);
bool param_3 = obj.DeleteFront();
bool param_4 = obj.DeleteLast();
int param_5 = obj.GetFront();
int param_6 = obj.GetRear();
bool param_7 = obj.IsEmpty();
bool param_8 = obj.IsFull();
