
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum=0, remain=0, carry=0;
        ListNode head = new ListNode(), tmp;
        tmp = head;
        while(l1!=null || l2!=null || carry>0){
            if(l1 == null){
                l1 = new ListNode();
            }
            if(l2 == null){
                l2 = new ListNode();
            }
            sum = l1.val + l2.val + carry;
            remain = sum%10;
            carry = sum/10;
            tmp.next = new ListNode(remain);
            tmp = tmp.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        return head.next;
    }
}