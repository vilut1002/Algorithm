public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] result = new char[s.Length];
        string res = "";
        for(int i=0; i<indices.Length; i++){
            result[indices[i]] = s[i];
        }
        for(int i=0; i<result.Length; i++){
            res+= result[i];
        }
        return res;
        
    }
}