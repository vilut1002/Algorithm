public class Solution {
    public bool IsValid(string s) {
        Stack stack = new Stack();
        for(int i=0; i<s.Length ; i++){
            if(s[i]=='('||s[i]=='['||s[i]=='{'){
                stack.Push(s[i]);
            }
            else if(s[i]==')'){
                if(stack.Count>0&&stack.Peek().ToString()[0]=='('){
                        stack.Pop();
                    }
                else{
                    return false;
                }
            }
            else if(s[i]==']'){
                if(stack.Count>0&&stack.Peek().ToString()[0]=='['){
                    stack.Pop();
                }
                else{
                    return false;
                }
                
            }
            else if(s[i]=='}'){
                if(stack.Count>0&&stack.Peek().ToString()[0]=='{'){
                        stack.Pop();
                }
                else{
                    return false;
                }
            }
        }
        if(stack.Count==0){
        return true;
        }
        else{
            return false;
        }
    }
}