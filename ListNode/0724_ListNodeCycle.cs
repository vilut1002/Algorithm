
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode fast, slow;
        if(head==null || head.next == null){
            return false;
        }
        fast = head.next;
        slow = head;
        while(fast!=null && fast.next!=null){
            if(fast == slow){
                return true;
            }
            fast = fast.next.next;
            slow = slow.next;
        }
        return false;
    }
}